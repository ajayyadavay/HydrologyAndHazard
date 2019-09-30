using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace HYDROLOGY
{
    public partial class FrmThornthwaite : Form
    {
        double Ddegree, minute, second, degree;
        int n, i, start_Year, ny, cell_val;
        int month_no;
        string path;
        double value, latitude;

        double[] Temp = new double[1000];
        double[] IndexI = new double[1000];
        double[] EfficiencyIndexJ = new double[1000];
        double[] C = new double[1000];
        double[] PET_0 = new double[1000];
        double[] K = new double[1000];
        double[] KPET_cm = new double[1000];
        double[] KPET_mm = new double[1000];

        double[] K20 = {0.92   , 0.96  ,  1 ,  1.05  ,  1.09 ,   1.11  ,  1.1 , 1.07 ,   1.02  ,  0.98  ,  0.93 ,   0.91};
        double[] K30 = {0.87  ,  0.93  ,  1 ,  1.07 ,   1.14 ,   1.17   , 1.16 ,   1.11 ,   1.03  ,  0.96 ,   0.89  ,  0.85};

        string[] MonthName = new string[1000];


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

        private void IMPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                if(Convert.ToString(worksheet.Cells[1, 2].value) == "YES")
                {
                    value = worksheet.Cells[2, 2].value;
                    TxtDegree.Text = value.ToString();

                    value = worksheet.Cells[3, 2].value;
                    TxtMinute.Text = value.ToString();

                    value = worksheet.Cells[4, 2].value;
                    TxtSecond.Text = value.ToString();
                }
                else
                {
                    value = worksheet.Cells[6, 2].value;
                    Txtonlydegree.Text = value.ToString();
                }
                
                int rcount = n;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[i].Cells["ColYear"].Value = worksheet.Cells[i + 10, 1].value;
                    dataGridViewMusking.Rows[i].Cells["ColMonth"].Value = worksheet.Cells[i + 10, 2].value;
                    dataGridViewMusking.Rows[i].Cells["ColTemp"].Value = worksheet.Cells[i + 10, 3].value;
                    //dataGridViewMusking.Rows[i].Cells["ColK"].Value = worksheet.Cells[i + 10, 4].value;

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

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveAllGridsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ClearValueOfSelectedCellsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void RemoveOneSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void PasteToGidCellsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void CopySelectedtoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void AllGridToolStripMenuItem_Click(object sender, EventArgs e)
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

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Degree";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDegree.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "Minutes";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtMinute.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "Seconds";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtSecond.Text;

                ((Excel.Range)xlWorkSheet.Cells[6, 1]).Value = "In Degree";
                ((Excel.Range)xlWorkSheet.Cells[6, 2]).Value = this.Txtonlydegree.Text;

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

        private void CopyAlltoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void SelectedGridOnlyToolStripMenuItem_Click(object sender, EventArgs e)
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

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Degree";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDegree.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "Minutes";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtMinute.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "Seconds";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtSecond.Text;

                ((Excel.Range)xlWorkSheet.Cells[6, 1]).Value = "In Degree";
                ((Excel.Range)xlWorkSheet.Cells[6, 2]).Value = this.Txtonlydegree.Text;

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

        private void FrmThornthwaite_Load(object sender, EventArgs e)
        {
            SetGridColorAndFont();
        }

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CalculatePET();
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

        private void daywisePETOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DayNo=30, CurrentYear, loop, number, flag;
            string textK;
            try
            {


               // CopyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "PET BY THORNTHWAITE METHOD " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Degree";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDegree.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "Minutes";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtMinute.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "Seconds";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtSecond.Text;

                ((Excel.Range)xlWorkSheet.Cells[6, 1]).Value = "In Degree";
                ((Excel.Range)xlWorkSheet.Cells[6, 2]).Value = this.Txtonlydegree.Text;

                ((Excel.Range)xlWorkSheet.Cells[9, 1]).Value = "Year";

                ((Excel.Range)xlWorkSheet.Cells[9, 2]).Value = "Month";

                ((Excel.Range)xlWorkSheet.Cells[9, 3]).Value = "Days of month";

                ((Excel.Range)xlWorkSheet.Cells[9, 4]).Value = "Daily PET mm";

                /*Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[10, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true); */

                // xlWorkBook.Close();
                //  xlexcel.Quit();

                /*Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);*/



                number = 10;
                for (i = 0; i < n; i++)
                {
                    CurrentYear = start_Year + i / 12;
                    if (MonthName[i] == "JAN" || MonthName[i] == "MAR" || MonthName[i] == "MAY" || MonthName[i] == "JUL" || MonthName[i] == "AUG" || MonthName[i] == "OCT" || MonthName[i] == "DEC")
                    {
                        DayNo = 31;
                    }
                    else if (MonthName[i] == "FEB")
                    {
                        if (DateTime.IsLeapYear(CurrentYear)) DayNo = 29;
                        else DayNo = 28;
                    }

                    else if (MonthName[i] == "APR" || MonthName[i] == "JUN" || MonthName[i] == "SEP" || MonthName[i] == "NOV")
                    {
                        DayNo = 30;
                    }

                    flag = 1;
                    ((Excel.Range)xlWorkSheet.Cells[number, 2]).Value = MonthName[i]; //MONTH

                    for (loop = 0; loop < DayNo; loop++)
                    {
                        if(flag ==1 && MonthName[i] == "JAN")
                        {
                            ((Excel.Range)xlWorkSheet.Cells[number, 1]).Value = (start_Year + i/12).ToString(); //YEAR
                            flag = 0;
                        }
                        textK = (KPET_mm[i]/DayNo).ToString();

                        ((Excel.Range)xlWorkSheet.Cells[number, 3]).Value = (loop+1).ToString(); //DAYS

                        ((Excel.Range)xlWorkSheet.Cells[number, 4]).Value = textK; // PET
                 
                        number++;

                    }



                }

                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlWorkSheet);

                MessageBox.Show("Export Completed Sucessfully.");
            }
            catch
            {

            }
        }

        private void TxtMinute_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 DMStoDegree();
            }
            catch
            {

            }
        }

        private void TxtSecond_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DMStoDegree();
            }
            catch
            {

            }
        }

        public FrmThornthwaite()
        {
            InitializeComponent();
        }

        private void TxtDegree_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DMStoDegree();
            }
            catch
            {

            }
        }
        public void DMStoDegree()
        {
            try
            {
                Ddegree = Convert.ToDouble(TxtDegree.Text);
                minute = Convert.ToDouble(TxtMinute.Text);
                second = Convert.ToDouble(TxtSecond.Text);

                degree = Ddegree + minute / 60 + second / 3600;
                Txtonlydegree.Text = degree.ToString("0.00");
            }
            catch
            {

            }
            
        }
        public void Generaterows()
        {
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
                if (i % 12 == 0)
                {
                    cell_val = start_Year + i / 12;
                    dataGridViewMusking.Rows[i].Cells[0].Value = cell_val;
                    dataGridViewMusking.Rows[i].Cells[1].Value = "JAN";
                    month_no = 0;
                }
                else
                {
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

        public void CalculatePET()
        {
            double sum = 0;
            int jcount = 0;
            try
            {
                //degree = Convert.ToDouble(Txtonlydegree.Text);
                
                for (i = 0; i < n; i++) // input
                {
                    MonthName[i] = (dataGridViewMusking.Rows[i].Cells["ColMonth"].Value).ToString();
                    Temp[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColTemp"].Value);
                    //K[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColK"].Value);
                }

                //calculation
                
                for (i = 0; i < n; i++)
                {
                    IndexI[i] = Math.Pow((Temp[i] / 5),1.514);

                    sum = sum + IndexI[i];

                    if((i+1) % 12 ==0)
                    {
                        EfficiencyIndexJ[jcount] = sum;
                        C[jcount] = 0.000000675 * Math.Pow(sum,3) - 0.0000771 * Math.Pow(sum,2) + 0.01792 * sum + 0.49239;

                        dataGridViewMusking.Rows[i].Cells["ColEffIndexJ"].Value = EfficiencyIndexJ[jcount].ToString("0.00");
                        dataGridViewMusking.Rows[i].Cells["ColC"].Value = C[jcount].ToString("0.00");

                        sum = 0;
                        jcount++;
                    }

                    dataGridViewMusking.Rows[i].Cells["ColIndexI"].Value = IndexI[i].ToString("0.00");
                }

                jcount = 0;
                FindCoeffKFromLat();
                for (i = 0; i < n; i++)
                {
                    PET_0[i] = 1.6 * Math.Pow((10 * Temp[i] / EfficiencyIndexJ[jcount]),C[jcount]);

                    KPET_cm[i] = K[i] * PET_0[i];
                    KPET_mm[i] = KPET_cm[i] * 10;

                    if ((i + 1) % 12 == 0)
                    {
                        jcount++;
                    }

                    dataGridViewMusking.Rows[i].Cells["ColK"].Value = K[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColPET"].Value = PET_0[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColK_PET_cm"].Value = KPET_cm[i].ToString("0.00");
                    dataGridViewMusking.Rows[i].Cells["ColK_PET_mm"].Value = KPET_mm[i].ToString("0.00");
                }
            }
            catch
            {

            }
  
        }
        public void FindCoeffKFromLat()
        {
            double[] k1 = new double[1000];
            int count;
            latitude = Convert.ToDouble(Txtonlydegree.Text);
            try
            {
                for (i = 0; i < 12; i++)
                {
                    k1[i] = (K30[i] - K20[i]) / (30 - 20) * (latitude - 20) + K20[i];
                }

                count = 0;
                for (i = 0; i < n; i++)
                {
                    K[i] = k1[count];
                    
                    count++;
                    if ((count) % 12 == 0)
                    {
                        count = 0;
                    }
                }
            }
            catch
            {

            }
          

        }
    }
}
