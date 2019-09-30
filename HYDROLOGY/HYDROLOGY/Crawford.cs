using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace HYDROLOGY
{
    public partial class FrmCrawford : Form
    {
        int n, i,start_Year,ny,cell_val,CurrentYear,newN;
        int month_no;
        Boolean SimulateFromTextBox;
        string path;
        double value, Nominal, PSUB, GWF,IMS,IGW,Area;
        double[] MoistureStorage = new double[1000];
        double[] StorageRatio = new double[1000];
        double[] PPT_by_PET = new double[1000];
        double[] AET_by_PET = new double[1000];
        double[] AET = new double[1000];
        double[] WaterBalance = new double[1000];
        double[] ExcessMoistureRatio = new double[1000];
        double[] ExcessMoisture = new double[1000];
        double[] DeltaStorage = new double[1000];
        double[] BeginGW = new double[1000];
        double[] EndGW = new double[1000];
        double[] GWFlow = new double[1000];
        double[] DirectFlow = new double[1000];
        double[] TotalFlow = new double[1000];
        double[] PPT = new double[1000];
        double[] PET = new double[1000];

        double[] ObsFlow = new double[1000];
        double[] ObsFlow_mm = new double[1000];

        string[] MonthName = new string[1000];
        int[] MonthDays = new int[1000];

        double[] Xaxis = new double[1000];
        double[] YaxisEstimated = new double[1000];
        double[] YaxisObserved = new double[1000];

        double meanObs,nashEff;
        double maxIMS, minIMS, maxNOMINAL, minNOMINAL, maxPSUB, minPSUB, maxGWF, minGWF, maxIGW, minIGW;
        double stepIMS, stepNOMINAL, stepPSUB, stepGWF, stepIGW;
        double optIMS, optNOMINAL, optPSUB, optGWF, optEFF,optIGW;
        int count;
        Boolean checkInputOpt;

        public FrmCrawford()
        {
            InitializeComponent();
        }

        private void CopyFromGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            try
            {
                CopySelectedtoClipboard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void IMPORTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SimulateFromTextBox = false;
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

                dataGridViewMusking.DataSource = null;

            for (int j = 0; j < dataGridViewMusking.Rows.Count - 1; j++)
            {
                dataGridViewMusking.Rows.RemoveAt(j);
                j--;
                while (dataGridViewMusking.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            try
            {
                value = worksheet.Cells[1, 2].value;
                TxtIMS.Text = value.ToString();

                value = worksheet.Cells[2, 2].value;
                TxtNominal.Text =value.ToString();

                value = worksheet.Cells[3, 2].value;
                TxtPSUB.Text = value.ToString();

                value = worksheet.Cells[4, 2].value; ;
                TxtGWF.Text = value.ToString();

                value = worksheet.Cells[5, 2].value;
                TxtEFF.Text = value.ToString();

                value = worksheet.Cells[6, 2].value;
                TxtInitialGW.Text = value.ToString();

                value = worksheet.Cells[7, 2].value;
                TxtArea.Text = value.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //int rcount = worksheet.UsedRange.Rows.Count;
                int rcount = n;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[i].Cells["ColYear"].Value = worksheet.Cells[i + 10, 1].value;
                    dataGridViewMusking.Rows[i].Cells["ColMonth"].Value = worksheet.Cells[i + 10, 2].value;
                    dataGridViewMusking.Rows[i].Cells["ColPPT"].Value = worksheet.Cells[i + 10, 3].value;
                    dataGridViewMusking.Rows[i].Cells["ColPET"].Value = worksheet.Cells[i + 10, 4].value;
                    dataGridViewMusking.Rows[i].Cells["ColObsFlow"].Value = worksheet.Cells[i + 10, 5].value;

                   
                    //worksheet.cells[rows, column].value; here rows column starts from 1 and rows starts from 1 of excel.
                }

                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
                // Marshal.ReleaseComObject(rcount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                workbook.Close();
                app.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(workbooks);
                Marshal.ReleaseComObject(worksheet);
            }
            MessageBox.Show("IMPORT COMPLETE !");

        }

        private void optimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPleaseWait fpw = new FrmPleaseWait();
                fpw.Show();
                Application.DoEvents();
            
                count = 0;
                Optimization();

                fpw.Close();

                MessageBox.Show("Optimization Complete !");


            }
            catch
            {

            }
        }

        private void TxtStartYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void TxtYearNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void FrmCrawford_Load(object sender, EventArgs e)
        {
            SetGridColorAndFont();
            SimulateFromTextBox = false;
        }

        private void SelectedGridOnlyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "CRAWFORD MODEL " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "IMS";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtIMS.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "NOMINAL";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtNominal.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "PSUB";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtPSUB.Text;

                ((Excel.Range)xlWorkSheet.Cells[5, 1]).Value = "GWF";
                ((Excel.Range)xlWorkSheet.Cells[5, 2]).Value = this.TxtGWF.Text;

                ((Excel.Range)xlWorkSheet.Cells[6, 1]).Value = "Nash Eff";
                ((Excel.Range)xlWorkSheet.Cells[6, 2]).Value = this.TxtEFF.Text;

                ((Excel.Range)xlWorkSheet.Cells[7, 1]).Value = "INITIAL GW";
                ((Excel.Range)xlWorkSheet.Cells[7, 2]).Value = this.TxtInitialGW.Text;

                ((Excel.Range)xlWorkSheet.Cells[8, 1]).Value = "Area_km2";
                ((Excel.Range)xlWorkSheet.Cells[8, 2]).Value = this.TxtArea.Text;



                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[10, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void AllGridToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "CRAWFORD MODEL " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "IMS";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtIMS.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "NOMINAL";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtNominal.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "PSUB";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtPSUB.Text;

                ((Excel.Range)xlWorkSheet.Cells[5, 1]).Value = "GWF";
                ((Excel.Range)xlWorkSheet.Cells[5, 2]).Value = this.TxtGWF.Text;

                ((Excel.Range)xlWorkSheet.Cells[6, 1]).Value = "Nash Eff";
                ((Excel.Range)xlWorkSheet.Cells[6, 2]).Value = this.TxtEFF.Text;

                ((Excel.Range)xlWorkSheet.Cells[7, 1]).Value = "INITIAL GW";
                ((Excel.Range)xlWorkSheet.Cells[7, 2]).Value = this.TxtInitialGW.Text;

                ((Excel.Range)xlWorkSheet.Cells[8, 1]).Value = "Area_km2";
                ((Excel.Range)xlWorkSheet.Cells[8, 2]).Value = this.TxtArea.Text;


                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[10, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // xlWorkBook.Close();
                //  xlexcel.Quit();
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void CopyFromGridToolStripMenuItem_Click(object sender, EventArgs e)
        {


            try
            {
                CopySelectedtoClipboard();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PasteToGidCellsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMusking.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridViewMusking.SelectedCells[0].RowIndex;
                int col = dataGridViewMusking.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridViewMusking.Columns.Count) continue;
                        dataGridViewMusking.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void EXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void RemoveOneSelectedRowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewMusking.CurrentCell.RowIndex;
                dataGridViewMusking.Rows.RemoveAt(row);
                dataGridViewMusking.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearValueOfSelectedCellsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridViewMusking.SelectedCells)
                {
                    string i = "";
                    cell.Value = (object)i;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtIMS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(SimulateFromTextBox==true) Simulation();
            }
            catch
            {

            }
        }

        private void TxtNominal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SimulateFromTextBox == true) Simulation();
            }
            catch
            {

            }
        }

        private void TxtPSUB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SimulateFromTextBox == true) Simulation();
            }
            catch
            {

            }
        }

        private void TxtGWF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SimulateFromTextBox == true) Simulation();
            }
            catch
            {

            }
        }

        private void TxtInitialGW_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SimulateFromTextBox == true) Simulation();
            }
            catch
            {

            }
        }

        private void SWAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtIMS.Text= TxtOPT_IMS.Text;
                TxtNominal.Text= TxtOpt_Nominal.Text;
                TxtPSUB.Text = TxtPSUB_OPT.Text;
                TxtGWF.Text = TxtGWF_OPT.Text;
                TxtEFF.Text = TxtEFF_OPT.Text;
                TxtInitialGW.Text = TxtInitialGW_OPT.Text;
            }
            catch
            {

            }
        }

        private void CRAWFORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCrawfordModel Fcrawfordmodel = new FrmCrawfordModel();
                Fcrawfordmodel.Show();
            }
            catch
            {

            }
        }

        private void RemoveAllGridsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMusking.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveGraphToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\CRAWFORD" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartMusking.SaveImage(ImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                MessageBox.Show("CrawFord Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CopyAlltoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void CopySelectedtoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Simulation();
                SimulateFromTextBox = true;
            }
            catch
            {

            }
   
            
        }

        public void SetGridColorAndFont()
        {
            this.dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 10);
            this.dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        public void Generaterows()
        {
            int DaysInYear;
            try
            {
                ny = Convert.ToInt32(TxtYearNo.Text); 
                start_Year = Convert.ToInt32(TxtStartYear.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridViewMusking.Rows.Clear();

            n = ny * 12;
     
            for (i = 0; i < n; i++)
            {
                i = dataGridViewMusking.Rows.Add();
                if (i % 12 ==0)
                {
                    cell_val = start_Year + i/12;
                    Xaxis[i] = i;
                    dataGridViewMusking.Rows[i].Cells[0].Value = cell_val;
                    dataGridViewMusking.Rows[i].Cells[1].Value = "JAN";
                    month_no = 0;
                }
                else
                {
                    Xaxis[i] = i;
                    month_no++;
                    if (month_no == 1) dataGridViewMusking.Rows[i].Cells[1].Value = "FEB";
                    if (month_no == 2) dataGridViewMusking.Rows[i].Cells[1].Value = "MAR";
                    if (month_no == 3) dataGridViewMusking.Rows[i].Cells[1].Value = "APR";
                    if (month_no == 4) dataGridViewMusking.Rows[i].Cells[1].Value = "MAY";
                    if (month_no == 5) dataGridViewMusking.Rows[i].Cells[1].Value = "JUN";
                    if (month_no == 6) dataGridViewMusking.Rows[i].Cells[1].Value = "JUL";
                    if (month_no == 7) dataGridViewMusking.Rows[i].Cells[1].Value = "AUG";
                    if (month_no == 8) dataGridViewMusking.Rows[i].Cells[1].Value = "SEP";
                    if (month_no == 9) dataGridViewMusking.Rows[i].Cells[1].Value = "OCT";
                    if (month_no == 10) dataGridViewMusking.Rows[i].Cells[1].Value = "NOV";
                    if (month_no == 11) dataGridViewMusking.Rows[i].Cells[1].Value = "DEC";

                }
            }
        }

        public void InputData()
        {
            try
            {
                IMS = Convert.ToDouble(TxtIMS.Text);
                Nominal = Convert.ToDouble(TxtNominal.Text);
                PSUB = Convert.ToDouble(TxtPSUB.Text);
                GWF = Convert.ToDouble(TxtGWF.Text);
                IGW = Convert.ToDouble(TxtInitialGW.Text); //Initial Ground Water
                Area = Convert.ToDouble(TxtArea.Text);

                for(i=0;i<n;i++)
                {
                    MonthName[i] = (dataGridViewMusking.Rows[i].Cells["ColMonth"].Value).ToString();
                    PPT[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColPPT"].Value);
                    PET[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColPET"].Value);
                    ObsFlow[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColObsFlow"].Value);

                }

            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void Simulation()
        {
            try
            {
                InputData();
                newN = 0;
                ObservedFlowCalculation();

                for (i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        MoistureStorage[i] = IMS;
                        StorageRatio[i] = MoistureStorage[i] / Nominal;
                        PPT_by_PET[i] = PPT[i] / PET[i];
                        if (PPT_by_PET[i] >= 1 || StorageRatio[i] >= 2)
                        {
                            AET_by_PET[i] = 1;
                        }
                        else
                        {
                            AET_by_PET[i] = (1 - StorageRatio[i] / 2) * PPT_by_PET[i] + StorageRatio[i] / 2;
                        }

                        AET[i] = AET_by_PET[i] * PET[i];
                        WaterBalance[i] = PPT[i] - AET[i];

                        if (StorageRatio[i] >= 0 && StorageRatio[i] <= 0.5)
                        {
                            ExcessMoistureRatio[i] = 0.2 * StorageRatio[i];
                        }
                        else if (StorageRatio[i] > 0.5 && StorageRatio[i] <= 1.5)
                        {
                            ExcessMoistureRatio[i] = 0.8 * (StorageRatio[i] - 0.5) + 0.1;
                        }
                        else if (StorageRatio[i] > 1.5 && StorageRatio[i] <= 2)
                        {
                            ExcessMoistureRatio[i] = 0.2 * (StorageRatio[i] - 1.5) + 0.9;
                        }
                        else if (StorageRatio[i] > 2)
                        {
                            ExcessMoistureRatio[i] = 1;
                        }

                        ExcessMoisture[i] = ExcessMoistureRatio[i] * WaterBalance[i];
                        if (ExcessMoisture[i] <= 0) ExcessMoisture[i] = 0;

                        DeltaStorage[i] = WaterBalance[i] - ExcessMoisture[i];
                        BeginGW[i] = IGW;
                        EndGW[i] = PSUB * ExcessMoisture[i] + BeginGW[i];
                        GWFlow[i] = GWF * EndGW[i];
                        DirectFlow[i] = (1 - PSUB) * ExcessMoisture[i];
                        TotalFlow[i] = DirectFlow[i] + GWFlow[i];
                    }
                    else           // for rows other than first row
                    {
                        MoistureStorage[i] = MoistureStorage[i - 1] + DeltaStorage[i - 1];
                        if (MoistureStorage[i] <= 0) MoistureStorage[i] = 0;

                        StorageRatio[i] = MoistureStorage[i] / Nominal;
                        PPT_by_PET[i] = PPT[i] / PET[i];
                        if (PPT_by_PET[i] >= 1 || StorageRatio[i] >= 2)
                        {
                            AET_by_PET[i] = 1;
                        }
                        else
                        {
                            AET_by_PET[i] = (1 - StorageRatio[i] / 2) * PPT_by_PET[i] + StorageRatio[i] / 2;
                        }

                        AET[i] = AET_by_PET[i] * PET[i];
                        WaterBalance[i] = PPT[i] - AET[i];

                        if (StorageRatio[i] >= 0 && StorageRatio[i] <= 0.5)
                        {
                            ExcessMoistureRatio[i] = 0.2 * StorageRatio[i];
                        }
                        else if (StorageRatio[i] > 0.5 && StorageRatio[i] <= 1.5)
                        {
                            ExcessMoistureRatio[i] = 0.8 * (StorageRatio[i] - 0.5) + 0.1;
                        }
                        else if (StorageRatio[i] > 1.5 && StorageRatio[i] <= 2)
                        {
                            ExcessMoistureRatio[i] = 0.2 * (StorageRatio[i] - 1.5) + 0.9;
                        }
                        else if (StorageRatio[i] > 2)
                        {
                            ExcessMoistureRatio[i] = 1;
                        }

                        ExcessMoisture[i] = ExcessMoistureRatio[i] * WaterBalance[i];
                        if (ExcessMoisture[i] <= 0) ExcessMoisture[i] = 0;

                        DeltaStorage[i] = WaterBalance[i] - ExcessMoisture[i];

                        BeginGW[i] = EndGW[i - 1] - GWFlow[i - 1];
                        if (BeginGW[i] <= 0) BeginGW[i] = 0;

                        EndGW[i] = PSUB * ExcessMoisture[i] + BeginGW[i];
                        GWFlow[i] = GWF * EndGW[i];
                        DirectFlow[i] = (1 - PSUB) * ExcessMoisture[i];
                        TotalFlow[i] = DirectFlow[i] + GWFlow[i];
                    }

                    //output to grid
                    dataGridViewMusking.Rows[i].Cells["ColMoistureRatio"].Value = MoistureStorage[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColStorageRatio"].Value = StorageRatio[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColPPT_PET"].Value = PPT_by_PET[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColAET_PET"].Value = AET_by_PET[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColAET"].Value = AET[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColWaterBalance"].Value = WaterBalance[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColExcessMoistureRatio"].Value = ExcessMoistureRatio[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColExcessMoisture"].Value = ExcessMoisture[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColDeltaStorage"].Value = DeltaStorage[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColBGW"].Value = BeginGW[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColEndGW"].Value = EndGW[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColGWF"].Value = GWFlow[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColDirectFlow"].Value = DirectFlow[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColTotalFlow"].Value = TotalFlow[i].ToString("0.00");

                    dataGridViewMusking.Rows[i].Cells["ColObsFlow_mm"].Value = ObsFlow_mm[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColDays"].Value = MonthDays[i].ToString();

                }
                
                PlotGraph();

                NashEfficiency();
                TxtEFF.Text = nashEff.ToString("0.00");
            }
            catch
            {

            }
            
        }
       
        public void ObservedFlowCalculation()
        {
            //int DaysOfMonth=30;
            try
            {
                for (i = 0; i < n; i++)
                {
                    CurrentYear = start_Year + i / 12;
                    if(MonthName[i] == "JAN" || MonthName[i]=="MAR" || MonthName[i]=="MAY" || MonthName[i]=="JUL" || MonthName[i] =="AUG" || MonthName[i] =="OCT" || MonthName[i]=="DEC")
                    {
                        //ObsFlow_mm[i] = ObsFlow[i] * 31 * 86400 * 1000 / (Area * 1000000);
                        MonthDays[i] = 31;
                        //DaysOfMonth = 31;
                    }
                    else if (MonthName[i] == "FEB")
                    {
                        if (DateTime.IsLeapYear(CurrentYear)) MonthDays[i] = 29;
                        else MonthDays[i] = 28;
                        //ObsFlow_mm[i] = ObsFlow[i] * DaysOfMonth * 86400 * 1000 / (Area * 1000000);
                    }
                    
                    else if (MonthName[i] == "APR" || MonthName[i]=="JUN" || MonthName[i]== "SEP" || MonthName[i]=="NOV")
                    {
                        //ObsFlow_mm[i] = ObsFlow[i] * 30 * 86400 * 1000 / (Area * 1000000);
                        MonthDays[i] = 30;
                    }

                    ObsFlow_mm[i] = ObsFlow[i] * MonthDays[i] * 86400 * 1000 / (Area * 1000000);
                    if (ObsFlow_mm[i] >= 0)
                    {
                        YaxisObserved[i] = ObsFlow_mm[i];
                        //YaxisEstimated[i] = TotalFlow[i];
                        newN++;
                    }

                    //dataGridViewMusking.Rows[i].Cells["ColObsFlow_mm"].Value = ObsFlow_mm[i].ToString("0.000");
                    //dataGridViewMusking.Rows[i].Cells["ColDays"].Value = MonthDays[i].ToString("0.000");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void PlotGraph()
        {
            ChartMusking.Series.Clear();
            ChartMusking.Series.Add("Estimated");
            ChartMusking.Series.Add("Observed");

            for (i = 0; i < n; i++)
            {
                ChartMusking.Series["Estimated"].Points.AddXY(Xaxis[i], TotalFlow[i]);
                //ChartMusking.Series["Observed"].Points.AddXY(Xaxis[i], ObsFlow_mm[i]);
                ChartMusking.Series["Observed"].Points.AddXY(Xaxis[i], YaxisObserved[i]);
            }

            ChartMusking.Series["Estimated"].Color = Color.Green;
            ChartMusking.Series["Observed"].Color = Color.Red;

            ChartMusking.Series["Estimated"].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartMusking.Series["Estimated"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            ChartMusking.Series["Observed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        public void NashEfficiency()
        {
            double sum = 0,numerator=0, denominator=0;
            int nNonNeg=0;
            try
            {
                for (i=0;i<n;i++)
                {
                    if (ObsFlow_mm[i] >= 0)
                    {
                        sum = sum + ObsFlow_mm[i];
                        numerator = numerator + (TotalFlow[i] - ObsFlow_mm[i]) * (TotalFlow[i] - ObsFlow_mm[i]);
                        nNonNeg++; //number of non negative observed discharge
                    }
                        
                }
                meanObs = sum / nNonNeg;

                for(i=0;i<n;i++)
                {
                    if (ObsFlow_mm[i] >= 0)
                    {
                        denominator = denominator + (ObsFlow_mm[i] - meanObs) * (ObsFlow_mm[i] - meanObs);
                    } 
                }

                nashEff = (1 - numerator / denominator) * 100;
            }
            catch
            {

            }
        }
        public void InputOptParaData()
        {
            try
            {

                maxIMS = Convert.ToDouble(TxtMaxIMS.Text);
                minIMS = Convert.ToDouble(TxtMinIMS.Text);
                stepIMS = Convert.ToDouble(TxtStepIMS.Text);

                maxNOMINAL = Convert.ToDouble(TxtMaxNominal.Text);
                minNOMINAL = Convert.ToDouble(TxtMinNominal.Text);
                stepNOMINAL = Convert.ToDouble(TxtStepNominal.Text);

                maxPSUB = Convert.ToDouble(TxtMaxPSUB.Text);
                minPSUB = Convert.ToDouble(TxtMinPSUB.Text);
                stepPSUB = Convert.ToDouble(TxtStepPSUB.Text);

                maxGWF = Convert.ToDouble(TxtMaxGWF.Text);
                minGWF = Convert.ToDouble(TxtMinGWF.Text);
                stepGWF = Convert.ToDouble(TxtStepGWF.Text);

                maxIGW = Convert.ToDouble(TxtMaxIGW.Text);
                minIGW = Convert.ToDouble(TxtMinIGW.Text);
                stepIGW = Convert.ToDouble(TxtStepIGW.Text);
  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Optimization()
        {
            double IMS1, Nominal1, PSUB1, GWF1, IGW1, nashEff1;
            try
            {
                //NashEfficiency();
                InputOptParaData();
                for (IMS1 = minIMS; IMS1 <= maxIMS; IMS1 = IMS1 + stepIMS)
                {
                    for (Nominal1 = minNOMINAL; Nominal1 <= maxNOMINAL; Nominal1 = Nominal1 + stepNOMINAL)
                    {
                        for (PSUB1 = minPSUB; PSUB1 <= maxPSUB; PSUB1 = PSUB1 + stepPSUB)
                        {
                            for (GWF1 = minGWF; GWF1 <= maxGWF; GWF1 = GWF1 + stepGWF)
                            {
                                for (IGW1 = minIGW; IGW1 <= maxIGW; IGW1 = IGW1 + stepIGW)
                                {
                                    count++;

                                    TxtIMS.Text = IMS1.ToString();
                                    TxtNominal.Text = Nominal1.ToString();
                                    TxtPSUB.Text = PSUB1.ToString();
                                    TxtGWF.Text = GWF1.ToString();
                                    TxtInitialGW.Text = IGW1.ToString();

                                    optEFF = Convert.ToDouble(TxtEFF_OPT.Text);
                                    nashEff1 = Convert.ToDouble(TxtEFF.Text);

                                    if (optEFF < nashEff1)
                                    {
                                        optEFF = nashEff1;
                                        TxtOPT_IMS.Text = IMS1.ToString();
                                        TxtOpt_Nominal.Text = Nominal1.ToString();
                                        TxtPSUB_OPT.Text = PSUB1.ToString();
                                        TxtGWF_OPT.Text = GWF1.ToString();
                                        TxtInitialGW_OPT.Text = IGW1.ToString();
                                        TxtEFF_OPT.Text = optEFF.ToString("0.00");
                                    }

                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Count: " + count.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
