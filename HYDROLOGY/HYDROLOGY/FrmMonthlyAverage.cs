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
    public partial class FrmMonthly : Form
    {
        int n, i, start_Year, ny;
        string path;
        double[] DaysNumber = new double[5000];
        double[] DayData = new double[5000];
        double[] MonthAverage = new double[5000];
        double[] MonthSum = new double[5000];

        string[] MonthName = new string[5000];

        int[] Years = new int[5000];
        int[] DaysInYear = new int[5000];
        int[] step = new int[5000];

        int SumOfDays = 0;
        int j, k;

        public FrmMonthly()
        {
            InitializeComponent();
        }

        private void FrmMonthlyAverage_Load(object sender, EventArgs e)
        {

            SetGridColorAndFont();
        }
        public void SetGridColorAndFont()
        {
            this.dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void dataGridViewMusking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                int rcount = n;

                int i=0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[i].Cells["ColYear"].Value = worksheet.Cells[i + 4, 1].value;
                    dataGridViewMusking.Rows[i].Cells["ColDay"].Value = worksheet.Cells[i + 4, 2].value;
                    dataGridViewMusking.Rows[i].Cells["ColDailyData"].Value = worksheet.Cells[i + 4, 3].value;
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
            MessageBox.Show("IMPORT COMPLETE !" + "\n i = " + i);
           
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate();
            }
            catch
            {

            }
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "Monthly Sum and Average " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "Montly Sum and Average  " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");
                
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[3, 1];
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
                ny = Convert.ToInt32(TxtYearNo.Text);
                start_Year = Convert.ToInt32(TxtStartYear.Text);

                Years[0] = start_Year;
                if (DateTime.IsLeapYear(Years[0])) DaysInYear[0] = 366;
                else DaysInYear[0] = 365;

                SumOfDays = SumOfDays + DaysInYear[0];

                for (i = 1; i < ny; i++)
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

            //n = SumOfDays;

            try
            {
                k = 0;
                n = 0;
                k = dataGridViewMusking.Rows.Add();
                for (i = 0; i < ny; i++)
                {
                    //k = dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[k].Cells[0].Value = Years[i];

                    for (j = 0; j < DaysInYear[i]; j++)
                    {
                        dataGridViewMusking.Rows[k].Cells[1].Value = j + 1;
                        k++;
                        n++;
                        k = dataGridViewMusking.Rows.Add();
                    }  
                }
            }
            catch
            {

            }
            
        }
        
        public void Calculate()
        {
            int start, stop,dayindex;
            int index;
            double sum;
            int monthindex = 0;

            try
            {
                MonthName[0] = "JAN"; MonthName[1] = "FEB"; MonthName[2] = "MAR"; MonthName[3] = "APR";
                MonthName[4] = "MAY"; MonthName[5] = "JUN"; MonthName[6] = "JUL"; MonthName[7] = "AUG";
                MonthName[8] = "SEP"; MonthName[9] = "OCT"; MonthName[10] = "NOV"; MonthName[11] = "DEC";

                step[0] = 31;
                step[2] = 31; step[3] = 30; step[4] = 31; step[5] = 30; step[6] = 31;
                step[7] = 31; step[8] = 30; step[9] = 31; step[10] = 30; step[11] = 31;

                for (i = 0; i < n; i++)
                {
                    DaysNumber[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColDay"].Value);
                    DayData[i] = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells["ColDailyData"].Value);
                }
                index = 0;
                for (i = 0; i < ny; i++)
                {
                    if (DateTime.IsLeapYear(Years[i]))
                    {
                        step[1] = 29;
                        DaysInYear[i] = 366;
                    }
                    else
                    {
                        step[1] = 28;
                        DaysInYear[i] = 365;
                    }

                    start = 1;
                    

                    for (j = 0; j < 12; j++)
                    {
                        stop = start + step[j] - 1;
                        sum = 0;

                        for (dayindex = start; dayindex <= stop; dayindex++) //to find monthly sum
                        {
                            sum = sum + DayData[index];
                            index++;
                        }

                        MonthSum[monthindex] = sum;
                        MonthAverage[monthindex] = sum/step[j]; // monthly average

                        /*
                        if (j == 0) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "JAN";
                        if (j == 1) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "FEB";
                        if (j == 2) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "MAR";
                        if (j == 3) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "APR";
                        if (j == 4) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "MAY";
                        if (j == 5) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "JUN";
                        if (j == 6) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "JUL";
                        if (j == 7) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "AUG";
                        if (j == 8) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "SEP";
                        if (j == 9) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "OCT";
                        if (j == 10) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "NOV";
                        if (j == 11) dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = "DEC"; */

                        if (j == 0) dataGridViewMusking.Rows[monthindex].Cells["ColYear2"].Value = Years[i];
                        dataGridViewMusking.Rows[monthindex].Cells["ColMonth"].Value = MonthName[j];
                        dataGridViewMusking.Rows[monthindex].Cells["ColSum"].Value = MonthSum[monthindex].ToString("0.00");
                        dataGridViewMusking.Rows[monthindex].Cells["ColAverage"].Value = MonthAverage[monthindex].ToString("0.000");

                        //Txttest.Text = Txttest.Text + "  \n   "  + MonthSum[monthindex].ToString(" 0.00    ");

                        start = stop + 1;
                        monthindex++;

                    }


                }

            }
            catch
            {

            }
        }
    }
}
