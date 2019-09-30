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
    public partial class FrmPenmann_PET : Form
    {
        int NumberOfYear, i,start_year, current_year;
        string path;
        int[] Years = new int[5000];
        int[] DaysInYear = new int[5000];
        int[] step = new int[5000];

        int SumOfDays = 0,k,j;
        int n1;

        double phi, a, b, gamma, sigma, r;

        int[] TotalDaysInMonth = new int[20];

        double[] Temperature = new double[5000];
        double[] es = new double[5000];
        double[] Humidity = new double[5000];
        double[] ea = new double[5000];
        double[] Slope_Sat_vap_A = new double[5000]; 
        double[] Ha = new double[5000];
        double[] Ha_Monthly = new double[5000];
        double[] MaxSunshine_N = new double[5000];
        double[] MaxSunshine_N_Monthly = new double[5000]; 
        double[] ActualSunshine_n = new double[5000];
        double[] Hn = new double[5000];
        double[] WindVelocity_U2 = new double[5000];
        double[] PET_Ea = new double[5000];
        double[] PET = new double[5000];

        double[] Ha20 = {10.8, 12.3, 13.9, 15.2, 15.7, 15.8, 15.7, 15.3, 14.4, 12.9, 11.2, 10.3};
        double[] Ha30 = {8.5, 10.5, 12.7, 14.8, 16, 16.5, 16.2, 15.3, 13.5, 11.3, 9.1, 7.9}; 

        double[] N20 = {11.1, 11.5, 12, 12.6, 13.1, 13.3, 13.2, 12.8, 12.3, 11.7, 11.2, 10.9 };
        double[] N30 = {10.4, 11.1, 12, 12.9, 13.7, 14.1, 13.9, 13.2, 12.4, 11.5, 10.6, 10.2 };

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
                //int rcount = worksheet.UsedRange.Rows.Count;
                int rcount = n1;
                double val;
                int i;

                val = worksheet.Cells[2, 2].value;
                Txtr.Text = val.ToString();
                val = worksheet.Cells[3, 2].value;
                Txtphi.Text = val.ToString();

                for (i = 0; i < rcount; i++)
                {
                    dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[i].Cells["ColYear"].Value = worksheet.Cells[i + 6, 1].value;
                    dataGridViewMusking.Rows[i].Cells["ColDay"].Value = worksheet.Cells[i + 6, 2].value;
                    dataGridViewMusking.Rows[i].Cells["ColTemperature"].Value = worksheet.Cells[i + 6, 3].value;
                    dataGridViewMusking.Rows[i].Cells["ColHumidity"].Value = worksheet.Cells[i + 6, 4].value;
                    dataGridViewMusking.Rows[i].Cells["Coln"].Value = worksheet.Cells[i + 6, 5].value;
                    dataGridViewMusking.Rows[i].Cells["ColU2"].Value = worksheet.Cells[i + 6, 6].value;
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

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate_PET();
            }
            catch
            {

            }
        }

        public void Input()
        {
            try
            {
                r = Convert.ToDouble(Txtr.Text);
                phi = Convert.ToDouble(Txtphi.Text);
                b = Convert.ToDouble(Txtb.Text);
                a = Convert.ToDouble(Txta.Text);
                sigma = Convert.ToDouble(Txtsigma.Text);
                gamma = Convert.ToDouble(Txtgamma.Text);

                for(i = 0; i < n1; i++)
                {
                    Temperature[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColTemperature"].Value);
                    Humidity[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColHumidity"].Value);
                    ActualSunshine_n[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["Coln"].Value);
                    WindVelocity_U2[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColU2"].Value);
                }
            }
            catch
            {


            }
        }

        public void Calculate_PET()
        {
            int YearIndex, DaysIndex, MonthIndex;
            double term1, term2, rationOfSunshine;
            // i is total number of daily data
            try
            {
                Input();
                HaAndMaxSunshineInterpolated();  // it contains monthly interpolated Ha, N and days of all months except Feb

                i = 0;
                for(YearIndex = 0; YearIndex < NumberOfYear; YearIndex++)
                {
                    if (DaysInYear[YearIndex] == 365) TotalDaysInMonth[1] = 28; // Feb
                    if (DaysInYear[YearIndex] == 366) TotalDaysInMonth[1] = 29; // Feb

                    //for(DaysIndex = 0; DaysIndex < DaysInYear[YearIndex]; DaysIndex++)
                    for (MonthIndex = 0; MonthIndex < 12; MonthIndex++)
                    {
                        for (DaysIndex = 0; DaysIndex < TotalDaysInMonth[MonthIndex]; DaysIndex++)
                        {
                            es[i] = 4.584 * Math.Exp(17.27 * Temperature[i] / (237.3 + Temperature[i]));
                            
                            ea[i] = Humidity[i] / 100 * es[i];

                            Slope_Sat_vap_A[i] = 4098 * es[i] / ((237.3 + Temperature[i]) * (237.3 + Temperature[i]));

                            rationOfSunshine = ActualSunshine_n[i] / MaxSunshine_N_Monthly[MonthIndex];
                            term1 = Ha_Monthly[MonthIndex] * (1 - r) * (a + b * rationOfSunshine);
                            term2 = sigma * Math.Pow((Temperature[i] + 273), 4) * (0.56 - 0.092 * Math.Sqrt(ea[i])) * (0.1 + 0.9 * rationOfSunshine);

                            Ha[i] = Ha_Monthly[MonthIndex];
                            MaxSunshine_N[i] = MaxSunshine_N_Monthly[MonthIndex];

                            Hn[i] = term1 - term2;

                            PET_Ea[i] = 0.35 * (1 + WindVelocity_U2[i] / 160) * (es[i] - ea[i]);

                            PET[i] = (Slope_Sat_vap_A[i] * Hn[i] + PET_Ea[i] * gamma) / (Slope_Sat_vap_A[i] + gamma);

                            // writing output to datagridview
                            dataGridViewMusking.Rows[i].Cells["Coles"].Value = es[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColHumidity"].Value = Humidity[i].ToString();
                            dataGridViewMusking.Rows[i].Cells["Colea"].Value = ea[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColA"].Value = Slope_Sat_vap_A[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColHa"].Value = Ha[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColMaxSunshine"].Value = MaxSunshine_N[i].ToString();
                            dataGridViewMusking.Rows[i].Cells["Coln"].Value = ActualSunshine_n[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColHn"].Value = Hn[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColU2"].Value = WindVelocity_U2[i].ToString();
                            dataGridViewMusking.Rows[i].Cells["ColEva"].Value = PET_Ea[i].ToString("0.00");
                            dataGridViewMusking.Rows[i].Cells["ColPET"].Value = PET[i].ToString("0.00");

                            i++;
                            
                        }
                   
                    }
                }
                

            }
            catch
            {

               
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "PET Calculation by Penman Equation " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "r";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = Txtr.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "Latitude,Φ";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = Txtphi.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "a";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = Txta.Text;
                
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[7, 1];
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

        private void CopySelectedtoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "PET Calculation by Penman Equation " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "r";
                //value of IMS in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = Txtr.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "Latitude,Φ";
                //value of NOMINAL in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = Txtphi.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "a";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = Txta.Text;

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[7, 1];
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

        public void HaAndMaxSunshineInterpolated() 
        {
            try
            {
                for(i = 0; i < 12; i++) // for 12 months
                {
                    Ha_Monthly[i] = (Ha30[i] - Ha20[i]) / (30 - 20) * (phi - 20) + Ha20[i];

                    MaxSunshine_N_Monthly[i] = (N30[i] - N20[i]) / (30 - 20) * (phi - 20) + N20[i];
                }

                TotalDaysInMonth[0] = 31; //Jan
                TotalDaysInMonth[2] = 31; //Mar
                TotalDaysInMonth[4] = 31; //May
                TotalDaysInMonth[6] = 31; //Jul
                TotalDaysInMonth[7] = 31; //Aug
                TotalDaysInMonth[9] = 31; //Oct
                TotalDaysInMonth[11] = 31; //Dec

                TotalDaysInMonth[3] = 30; //Apr
                TotalDaysInMonth[5] = 30; //Jun
                TotalDaysInMonth[8] = 30; //Sep
                TotalDaysInMonth[10] = 30; //Nov

            }
            catch
            {

            }
        }

        public FrmPenmann_PET()
        {
            InitializeComponent();
        }

        private void Lbla_Click(object sender, EventArgs e)
        {

        }

        private void Txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPenmann_PET_Load(object sender, EventArgs e)
        {
            SetGridColorAndFont();
            ActiveControl = Txtnum;
            Txtb.BackColor = System.Drawing.SystemColors.Window;
            Txta.BackColor = System.Drawing.SystemColors.Window;
            Txtgamma.BackColor = System.Drawing.SystemColors.Window;
            Txtsigma.BackColor = System.Drawing.SystemColors.Window;
        }

        private void Txtphi_TextChanged(object sender, EventArgs e)
        {
            phi = Convert.ToDouble(Txtphi.Text);

            a = 0.29 * Math.Cos(phi * Math.PI / 180);
            Txta.Text = a.ToString();
        }

        public void SetGridColorAndFont()
        {
            dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;

        }

        private void Txtnum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
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

        public void Generaterows()
        {
            try
            {
                NumberOfYear = Convert.ToInt32(Txtnum.Text);
                start_year = Convert.ToInt32(TxtStartYear.Text);

                Years[0] = start_year;
                if (DateTime.IsLeapYear(Years[0])) DaysInYear[0] = 366;
                else DaysInYear[0] = 365;

                SumOfDays = SumOfDays + DaysInYear[0];

                for (i = 1; i < NumberOfYear; i++)
                {
                    Years[i] = Years[i - 1] + 1;
                    if (DateTime.IsLeapYear(Years[i])) DaysInYear[i] = 366;
                    else DaysInYear[i] = 365;

                    SumOfDays = SumOfDays + DaysInYear[i];
                }
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }

            dataGridViewMusking.Rows.Clear();

            //n1 = SumOfDays;

            try
            {
                k = 0;
                n1 = 0;
                k = dataGridViewMusking.Rows.Add();
                for (i = 0; i < NumberOfYear; i++)
                {
                    //k = dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[k].Cells[0].Value = Years[i];

                    for (j = 0; j < DaysInYear[i]; j++)
                    {
                        dataGridViewMusking.Rows[k].Cells[1].Value = j + 1;
                        k++;
                        n1++;
                        k = dataGridViewMusking.Rows.Add();
                    }
                }
            }
            catch
            {

            }
            
        }
    }
}
