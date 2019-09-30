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
    public partial class FrmMuskingumParameter : Form
    {
        int n, i;
        string path, unit;
        double x, del_t, k, denominator, StartTime;
        double c0, c1, c2, cell_val, value;
        double I2, I1, O1, O2, p1, p2, p0;
        Boolean SimulateFromTextBox;

        double[] Xaxis = new double[1000];
        double[] YaxisInflow = new double[1000];
        double[] Storage = new double[1000];
        double[] WeightedFlow = new double[1000];
        double[] Slope = new double[1000];

        private void IMPORTToolStripMenuItem_Click(object sender, EventArgs e)
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
                TxtK.Text = value.ToString();

                value = worksheet.Cells[2, 2].value;
                TxtX.Text = value.ToString();

                unit = Convert.ToString(worksheet.Cells[3, 2].value);
                if (unit == "Days" || unit == "Hours")
                {
                    ComboBoxInterval.Text = unit;
                    ComboBoxK.Text = unit;
                }
                else
                {
                    ComboBoxInterval.Text = "";
                    ComboBoxK.Text = "";
                    MessageBox.Show("Unit of Time should be in Days or Hours \n (Days and Hours are Case-Senitive)");
                }

                /*unit = Convert.ToString(worksheet.Cells[4, 2].value);
                if (unit == "Days" || unit == "Hours")
                {
                    ComboBoxK.Text = unit;
                }
                else
                {
                    ComboBoxInterval.Text = "";
                    MessageBox.Show("Unit of K should be in Days or Hours \n (Days and Hours are Case-Senitive)");
                }*/
                //int rcount = worksheet.UsedRange.Rows.Count;

                int rcount = n;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[i].Cells["ColTime"].Value = worksheet.Cells[i + 6, 1].value;
                    dataGridViewMusking.Rows[i].Cells["ColInflow"].Value = worksheet.Cells[i + 6, 2].value;
                    dataGridViewMusking.Rows[i].Cells["ColOutflow"].Value = worksheet.Cells[i + 6, 3].value;
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

        private void TxtInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void TxtStartTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        double[] YaxisOutflow = new double[1000];

        private void TxtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CalculateStorage();
                Simulate();
                EstimatedOutflow();
                SimulateFromTextBox = true;
            }
            catch
            {

            }
        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SimulateFromTextBox == true)
                {
                    Simulate();
                    EstimatedOutflow();
                }
            }
            catch
            {

            }
        }

        private void FrmMuskingumParameter_Load(object sender, EventArgs e)
        {
            ComboBoxInterval.Items.Clear();
            //ComboBoxK.Items.Clear();

            ComboBoxInterval.Items.Add("Days");
            ComboBoxInterval.Items.Add("Hours");

            ComboBoxK.Items.Add("Days");
            ComboBoxK.Items.Add("Hours");

            ComboBoxK.Enabled = false;

            SetGridColorAndFont();
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


                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "MUSKINGUM PARAMETER CALIBRATION " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "K";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtK.Text;

                ((Excel.Range)xlWorkSheet.Cells[2, 4]).Value = "C0";
                ((Excel.Range)xlWorkSheet.Cells[2, 5]).Value = this.TxtC0.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "X";
                //value of X in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtX.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 4]).Value = "C1";
                ((Excel.Range)xlWorkSheet.Cells[3, 5]).Value = this.TxtC1.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "Time in";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = ComboBoxInterval.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 4]).Value = "C2";
                ((Excel.Range)xlWorkSheet.Cells[4, 5]).Value = this.TxtC2.Text;

                ((Excel.Range)xlWorkSheet.Cells[5, 1]).Value = "K in";
                ((Excel.Range)xlWorkSheet.Cells[5, 2]).Value = ComboBoxK.Text;


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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "MUSKINGUM PARAMETER CALIBRATION " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "K";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtK.Text;

                ((Excel.Range)xlWorkSheet.Cells[2, 4]).Value = "C0";
                ((Excel.Range)xlWorkSheet.Cells[2, 5]).Value = this.TxtC0.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 1]).Value = "X";
                //value of X in Cell[2,2]
                ((Excel.Range)xlWorkSheet.Cells[3, 2]).Value = this.TxtX.Text;

                ((Excel.Range)xlWorkSheet.Cells[3, 4]).Value = "C1";
                ((Excel.Range)xlWorkSheet.Cells[3, 5]).Value = this.TxtC1.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 1]).Value = "Time in";
                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = ComboBoxInterval.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 4]).Value = "C2";
                ((Excel.Range)xlWorkSheet.Cells[4, 5]).Value = this.TxtC2.Text;

                ((Excel.Range)xlWorkSheet.Cells[5, 1]).Value = "K in";
                ((Excel.Range)xlWorkSheet.Cells[5, 2]).Value = ComboBoxK.Text;



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

        private void ComboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxK.Text = ComboBoxInterval.Text;
        }

        public FrmMuskingumParameter()
        {
            InitializeComponent();
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

        private void SaveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\Calibration" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartMusking.SaveImage(ImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                MessageBox.Show("Calibration Graph Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void Generaterows()
        {
            try
            {
                del_t = Convert.ToDouble(TxtInterval.Text);
                n = Convert.ToInt32(TxtN.Text);
                StartTime = Convert.ToDouble(TxtStartTime.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridViewMusking.Rows.Clear();

            for (i = 0; i < n; i++)
            {
                i = dataGridViewMusking.Rows.Add();
                if (i == 0)
                {
                    /*cell_val = 0;
                    Xaxis[i] = cell_val;
                    dataGridViewMusking.Rows[i].Cells[0].Value = cell_val;*/
                    cell_val = StartTime;
                    Xaxis[i] = cell_val;
                    dataGridViewMusking.Rows[i].Cells[0].Value = cell_val;
                }
                else
                {
                    cell_val = cell_val + del_t;
                    Xaxis[i] = cell_val;
                    dataGridViewMusking.Rows[i].Cells[0].Value = cell_val;
                }
            }
        }

        public void SetGridColorAndFont()
        {
            this.dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        public void CalculateStorage()
        {
            try
            {
                Storage[0] = 0;
                dataGridViewMusking.Rows[0].Cells[3].Value = Storage[0].ToString("0.00");

                for (i = 1; i < n; i++)
                {
                    I2 = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells[1].Value);
                    I1 = Convert.ToDouble(dataGridViewMusking.Rows[i - 1].Cells[1].Value);
                    O1 = Convert.ToDouble(dataGridViewMusking.Rows[i - 1].Cells[2].Value);
                    O2 = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells[2].Value);

                    Storage[i] = Storage[i - 1] + del_t / 2 * ((I1 + I2) - (O1 + O2));

                    dataGridViewMusking.Rows[i].Cells[3].Value = Storage[i].ToString("0.00");

                }
            }
            catch
            {

            }
        }
        public void Simulate()
        {
            double sum = 0;
            try
            {

                //del_t = Convert.ToDouble(TxtInterval.Text);
                //k = Convert.ToDouble(TxtK.Text);
                x = Convert.ToDouble(TxtX.Text);
                n = Convert.ToInt32(TxtN.Text);

                //if (ComboBoxInterval.Text == "Days") del_t = del_t * 24;
                //if (ComboBoxInterval.Text == "Days") k = k * 24;

                /*denominator = del_t + 2 * k * (1 - x);

                c0 = (del_t - 2 * k * x) / denominator;
                TxtC0.Text = c0.ToString("0.00");

                c1 = (del_t + 2 * k * x) / denominator;
                TxtC1.Text = c1.ToString("0.00");

                c2 = 1 - c0 - c1;
                TxtC2.Text = c2.ToString("0.00");*/

                for (i = 0; i < n; i++)
                {
                    I2 = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells[1].Value);        
                    O2 = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells[2].Value);

                    WeightedFlow[i] = x * I2 + (1 - x) * O2;

                    dataGridViewMusking.Rows[i].Cells[4].Value = WeightedFlow[i].ToString("0.00");

                }

                for (i = 1; i < n; i++)
                {
                    Slope[i] = (Storage[i] - Storage[i - 1]) / (WeightedFlow[i] - WeightedFlow[i - 1]);
                    sum = sum + Slope[i];

                    dataGridViewMusking.Rows[i].Cells[5].Value = Slope[i].ToString("0.00");

                }
                TxtK.Text = (sum / (n-1)).ToString("0.0");

            }
            catch
            {
               
            }

            DrawGraph();

        }

        public void EstimatedOutflow()
        {
            try
            {
                del_t = Convert.ToDouble(TxtInterval.Text);
                k = Convert.ToDouble(TxtK.Text);
                x = Convert.ToDouble(TxtX.Text);
                n = Convert.ToInt32(TxtN.Text);

                if (ComboBoxInterval.Text == "Days") del_t = del_t * 24;
                if (ComboBoxInterval.Text == "Days") k = k * 24;

                denominator = del_t + 2 * k * (1 - x);

                c0 = (del_t - 2 * k * x) / denominator;
                TxtC0.Text = c0.ToString("0.00");

                c1 = (del_t + 2 * k * x) / denominator;
                TxtC1.Text = c1.ToString("0.00");

                c2 = 1 - c0 - c1;
                TxtC2.Text = c2.ToString("0.00");

                dataGridViewMusking.Rows[0].Cells[6].Value = dataGridViewMusking.Rows[0].Cells[1].Value;

                for (i = 1; i < n; i++)
                {
                    I2 = Convert.ToDouble(dataGridViewMusking.Rows[i].Cells[1].Value);
                    I1 = Convert.ToDouble(dataGridViewMusking.Rows[i - 1].Cells[1].Value);
                    O1 = Convert.ToDouble(dataGridViewMusking.Rows[i - 1].Cells[6].Value);

                    p0 = c0 * I2;
                    p1 = c1 * I1;
                    p2 = c2 * O1;

                    O2 = p0 + p1 + p2;

                    dataGridViewMusking.Rows[i].Cells[6].Value = O2.ToString("0.00");
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void DrawGraph()
        {
            ChartMusking.Series.Clear();
            ChartMusking.Series.Add("Calibration");

            for (i = 0; i < n; i++)
            {
                ChartMusking.Series["Calibration"].Points.AddXY(WeightedFlow[i], Storage[i]);
            }
      
            ChartMusking.Series["Calibration"].Color = Color.DarkGreen;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartMusking.Series["Calibration"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }
    }
}
