using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HYDROLOGY
{

    public partial class FrmStability : Form
    {
        int i,n,j;
        double ThetaU1, ThetaU2, Grad, h1, h2, del_t, Vu, r, FOS, L, velocity, L_ThetaDr_DelT;
        double ks, Gamma, z, D, GammaW, c_dash, ThetaR, ThetaS, ThetaDr, error;
        double[] RainInt = new double[1000];
        double[] Time = new double[1000]; 
        double[] XRainAmount = new double[1000];
        double FS, err;
        double available_shear, required_shear;
        double c1, c2, fx, f_dash_x, ThetaU22, q1, p1, p2, b1;
        double dt;
        string path;

        private void Txtr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Txtrain.Text = Txtr.Text;
            }
            catch
            {

            }
        }

        private void RadioAmount_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DrawGraph();
            }
            catch
            {

            }
        }

        private void saveGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\Stability Graph" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartMusking.SaveImage(ImagePath, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

                MessageBox.Show("HydroGraph Saved to: \n" + ImagePath);
            }
            catch
            {
               // MessageBox.Show(ex.Message);
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "STABILITY " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Δt (hr)";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDT.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtDes.Text;

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "STABILITY " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Δt (hr)";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDT.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtDes.Text;

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];
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

        private void ExportAlltoolStripMenuItem10_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAlltoClipboard1();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "STABILITY " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Δt (hr)";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDT.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtDes.Text;

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];
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
        private void CopyAlltoClipboard1()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }

        private void CopySelectedtoClipboard1() 
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            //dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ExportSelectedtoolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard1();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "STABILITY " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                ((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Δt (hr)";
                //value of k in Cell[1,2]
                ((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDT.Text;

                ((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtDes.Text;

                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[6, 1];
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

        private void CopytoolStripMenuItem12_Click(object sender, EventArgs e)
        {
            try
            {
                CopySelectedtoClipboard1();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void PastetoolStripMenuItem13_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count < 1) return;

                string[] lines;

                int row = dataGridView1.SelectedCells[0].RowIndex;
                int col = dataGridView1.SelectedCells[0].ColumnIndex;

                //get copied values
                lines = Clipboard.GetText().Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split('\t');

                    if (row >= dataGridView1.Rows.Count || dataGridView1.Rows[row].IsNewRow) continue;
                    //if (row >= dataGridViewMusking.Rows.Count || dataGridViewMusking.Rows[row].IsNewRow) dataGridViewMusking.Rows.Add();
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (col + j >= dataGridView1.Columns.Count) continue;
                        dataGridView1.Rows[row].Cells[col + j].Value = values[j];
                    }

                    row++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void RemoveOnetoolStripMenuItem15_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                dataGridView1.Refresh();

                /* row = dataGridView1.CurrentCell.RowIndex;
                 dataGridView1.Rows.RemoveAt(row);
                 dataGridView1.Refresh(); */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleartoolStripMenuItem16_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
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

        private void FrmStability_DragDrop(object sender, DragEventArgs e)
        {
            IMPORTToolStripMenuItem_Click(sender, e);
        }

        private void FrmStability_DragEnter(object sender, DragEventArgs e)
        {
            //IMPORTToolStripMenuItem_Click(sender, e);
        }

        private void EXPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveAlltoolStripMenuItem17_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            dataGridView1.DataSource = null;

            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                dataGridView1.Rows.RemoveAt(j);
                j--;
                while (dataGridView1.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                double temp_val;

                //soil characteristics
                temp_val = worksheet.Cells[5, 2].value;
                TxtThetaS.Text = temp_val.ToString();

                temp_val = worksheet.Cells[5, 3].value;
                TxtThetaR.Text = temp_val.ToString();

                temp_val = worksheet.Cells[5, 4].value;
                TxtThetaDR.Text = temp_val.ToString();

                temp_val = worksheet.Cells[5, 5].value;
                TxtThetaU1.Text = temp_val.ToString();

                temp_val = worksheet.Cells[5, 6].value;
                TxtKs.Text = temp_val.ToString();
                
                //Hill slope geometry

                temp_val = worksheet.Cells[9, 2].value;
                TxtL.Text = temp_val.ToString();

                temp_val = worksheet.Cells[9, 3].value;
                TxtAlpha.Text = temp_val.ToString();

                temp_val = worksheet.Cells[9, 4].value;
                TxtD.Text = temp_val.ToString();

                temp_val = worksheet.Cells[9, 5].value;
                Txth1.Text = temp_val.ToString();


                //stability parameters

                temp_val = worksheet.Cells[13, 2].value;
                TxtCDash.Text = temp_val.ToString();

                temp_val = worksheet.Cells[13, 3].value;
                Txtgamma.Text = temp_val.ToString();

                temp_val = worksheet.Cells[13, 4].value;
                Txtphi.Text = temp_val.ToString();

                temp_val = worksheet.Cells[13, 5].value;
                Txtbeta.Text = temp_val.ToString();

                temp_val = worksheet.Cells[13, 6].value;
                TxtgammaW.Text = temp_val.ToString();

                temp_val = worksheet.Cells[17, 2].value;
                Txtz.Text = temp_val.ToString();

                temp_val = worksheet.Cells[17, 3].value;
                TxtDT.Text = temp_val.ToString();

                int rcount = n;

                int i = 0;

                for (i = 0; i < rcount; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = worksheet.Cells[i + 5, 10].value;
                    dataGridView1.Rows[i].Cells[1].Value = worksheet.Cells[i + 5, 11].value;
                    //worksheet.cells[rows, column].value; here column starts from 1 and rows starts from 1 of excel.
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

        private void TxtTime_TextChanged(object sender, EventArgs e)
        {

        }

        double alpha, beta, phi;

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

               /* row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                dataGridView1.Refresh(); */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtRainData_TextChanged(object sender, EventArgs e)
        {
            Generaterows();
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

        private void ClearValueOfSelectedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridViewMusking.SelectedCells)
                {
                    string i = "";
                    cell.Value = (object)i;


                }
                /*

                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    string i = "";
                    cell.Value = (object)i;


                }*/
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

                //dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void RadioTime_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //ChartMusking.Titles.Clear();
                DrawGraph();
            }
            catch
            {

            }
        }

        

        private void TxtDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LDT_Calc();
            }
            catch
            {

            }
        }

        private void TxtThetaDR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LDT_Calc();
            }
            catch
            {

            }
        }

        private void TxtL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LDT_Calc();
            }
            catch
            {

            }
        }

        private void TxtAlpha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Velocity_calc();
            }
            catch
            {

            }
        }

        private void TxtKs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Velocity_calc();
            }
            catch
            {

            }
        }

        public FrmStability()
        {
            InitializeComponent();
        }

        private void loadExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TxtThetaS.Text = 0.5.ToString();
                TxtThetaR.Text = 0.1.ToString();
                TxtThetaDR.Text = 0.4.ToString();
                TxtThetaU1.Text = 0.1.ToString();
                TxtKs.Text = 0.1.ToString();

                TxtL.Text = 100.ToString();
                TxtAlpha.Text = 35.ToString();
                TxtD.Text = 3.ToString();
                Txth1.Text = 0.ToString();

                TxtCDash.Text = 5.ToString();
                Txtgamma.Text = 18.ToString();
                Txtphi.Text = 30.ToString();
                Txtbeta.Text = 35.ToString();
                TxtgammaW.Text = 9.81.ToString();

                //Txtr.Text = 100.ToString();
                Txtz.Text = 3.ToString();
                TxtDT.Text = 0.25.ToString();
                TxtError.Text = 0.000000005.ToString();
            }
            catch
            {

            }
            
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RUNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPleaseWait fpw = new FrmPleaseWait();
                //FrmAbout fa = new FrmAbout();

                //fa.Show();
                fpw.Show();
                //fpw.Text = "Please Wait...";
                Application.DoEvents();
                Calculate();

                //fa.Close();
                fpw.Close();
            }
            catch
            {

            }
            // L * ThetaDR /del_T
        }

        private void FrmStability_Load(object sender, EventArgs e)
        {
            SetGridColorAndFont();
            TxtV.BackColor = System.Drawing.SystemColors.Window;
            TxtLDt.BackColor = System.Drawing.SystemColors.Window;
            
        }
        public void CalcRainAmount()
        {
            try
            {
                //TxtRainAmount.Text = (Convert.ToDouble(Txtrain.Text) * Convert.ToDouble(TxtTime.Text)).ToString();
            }
           catch
            {

            }
        }
        public void AssignValues()
        {
            try
            {
                ThetaS = Convert.ToDouble(TxtThetaS.Text);
                ThetaDr = Convert.ToDouble(TxtThetaDR.Text);
                ThetaR = Convert.ToDouble(TxtThetaR.Text);
                ThetaU1 = Convert.ToDouble(TxtThetaU1.Text);
                ks = Convert.ToDouble(TxtKs.Text);

                L = Convert.ToDouble(TxtL.Text);
                alpha = Convert.ToDouble(TxtAlpha.Text);
                D = Convert.ToDouble(TxtD.Text);
                h1 = Convert.ToDouble(Txth1.Text);
                velocity = Convert.ToDouble(TxtV.Text);

                c_dash = Convert.ToDouble(TxtCDash.Text);
                Gamma = Convert.ToDouble(Txtgamma.Text);
                GammaW = Convert.ToDouble(TxtgammaW.Text);
                beta = Convert.ToDouble(Txtbeta.Text);
                phi = Convert.ToDouble(Txtphi.Text);
                
                //r = Convert.ToDouble(Txtr.Text);
                z = Convert.ToDouble(Txtz.Text);
                del_t = Convert.ToDouble(TxtDT.Text);
                dt = del_t;
                L_ThetaDr_DelT = Convert.ToDouble(TxtLDt.Text);
                err = Convert.ToDouble(TxtError.Text);
                
            }
            catch
            {

            }
            

        }
        public void Calculate()
        {
            int index = 0;
            int check;
            try
            {
                //i = 1;
                dataGridViewMusking.Rows.Clear();
                //AssignValues();
                RainIntensityInput();
                ThetaU2 = ThetaU1;
                i = 1;

                for(j=0;j<n;j++)
                {
                    check = 1;
                    AssignValues();
                    //MessageBox.Show("Rain = " + RainInt[j] + "  j = " + j);
                    //dataGridViewMusking.Rows[index].Cells[0].Value = RainInt[j].ToString("0.00");
                    while (true)
                    {
                        do
                        {
                            //ThetaU2 = ThetaU2 + 1;

                            //Grad = (ThetaU2 + ThetaU1 - 2 * ThetaR) / (2 * ThetaS - 2 * ThetaR) * ks / 100;

                            // h2 = (h1 * (L_ThetaDr_DelT - velocity) * 0.5 + Grad * L) / ((L_ThetaDr_DelT + velocity) * 0.5);

                            //Vu = L * D - 0.25 * h1 * L - 0.25 * h2 * L;


                            c1 = h1 * 0.5 * (L_ThetaDr_DelT - velocity);
                            c2 = 0.5 * (L_ThetaDr_DelT + velocity);

                            p1 = ThetaU1 - 2 * ThetaR;
                            p2 = 2 * (ThetaS - ThetaR);

                            q1 = L * D - 0.25 * h1 * L;

                            b1 = (q1 - L * 0.25 * ((c1 + (ThetaU2 + p1) * ks * 0.01 * L / p2) / c2));
                            fx = b1 * (ThetaU2 - ThetaU1) / del_t - (RainInt[j] / 1000 - (ThetaU2 + p1) * ks * 0.01 / p2) * L;

                            f_dash_x = b1 / del_t + (ThetaU2 - ThetaU1) / del_t * (-0.25 * L * ks * 0.01 * L / (p2 * c2)) + ks * 0.01 * L / p2;

                            ThetaU22 = ThetaU2 - fx / f_dash_x;

                            ThetaU2 = ThetaU22;

                            //b1 = (q1 - L * 0.25 * ((c1 + (ThetaU2 + p1) * ks * 0.01 * L / p2) / c2));
                            //fx = b1 * (ThetaU2 - ThetaU1) / del_t - (r - (ThetaU2 + p1) * ks * 0.01 / p2) * L;

                            error = Math.Abs(fx);

                            //MessageBox.Show("#" + i + "\n ThetaU2 = "+ThetaU2 + "\n error = " + error + "\n p1,p2 = " + p1 + " " + p2);


                        } while (error > err);

                        TxtMsg.Text = TxtMsg.Text + "iteration #" + i + " completed \r\n";

                        Grad = (ThetaU2 + ThetaU1 - 2 * ThetaR) / (2 * ThetaS - 2 * ThetaR) * ks / 100;

                        h2 = (h1 * (L_ThetaDr_DelT - velocity) * 0.5 + Grad * L) / ((L_ThetaDr_DelT + velocity) * 0.5);

                        Vu = L * D - 0.25 * h1 * L - 0.25 * h2 * L;

                        available_shear = c_dash + (Gamma * z - GammaW * h2) * Math.Cos(beta * Math.PI / 180) * Math.Cos(beta * Math.PI / 180) * Math.Tan(phi * Math.PI / 180);

                        required_shear = Gamma * z * Math.Sin(beta * Math.PI / 180) * Math.Cos(beta * Math.PI / 180);

                        FOS = available_shear / required_shear;

                        if (FOS >= 1) FS = FOS;

                        dataGridViewMusking.Rows.Add();

                        if(check==1)
                        {
                            dataGridViewMusking.Rows[index].Cells[0].Value = RainInt[j].ToString("0.00");
                            check = 0;
                        }

                        dataGridViewMusking.Rows[index].Cells[1].Value = del_t.ToString("0.00");
                        dataGridViewMusking.Rows[index].Cells[2].Value = ThetaU1.ToString("0.000");
                        dataGridViewMusking.Rows[index].Cells[3].Value = ThetaU2.ToString("0.00000");
                        dataGridViewMusking.Rows[index].Cells[4].Value = Grad;
                        dataGridViewMusking.Rows[index].Cells[5].Value = h1.ToString();
                        dataGridViewMusking.Rows[index].Cells[6].Value = h2;
                        dataGridViewMusking.Rows[index].Cells[7].Value = Vu;
                        dataGridViewMusking.Rows[index].Cells[8].Value = error.ToString("0.000000");
                        dataGridViewMusking.Rows[index].Cells[9].Value = FOS.ToString("0.0000");

                        i++;

                        if (FOS < 1)
                        {
                            //TxtTime.Text = (del_t - dt).ToString();
                            dataGridView1.Rows[j].Cells[2].Value = (del_t-dt).ToString("0.0000");
                            Time[j] = (del_t - dt);
                            XRainAmount[j] = RainInt[j] * (del_t - dt);
                            dataGridView1.Rows[j].Cells[3].Value = (RainInt[j] * (del_t-dt)).ToString("0.00");
                            dataGridView1.Rows[j].Cells[4].Value = FS.ToString("0.0000");
                            break;
                        }

                        ThetaU1 = ThetaU2;
                        h1 = h2;
                        del_t = del_t + dt;
                        index = index + 1;


                    }
                }

                DrawGraph();
                TxtMsg.Text = TxtMsg.Text + "...............END...................  \r\n";           

            }
            catch
            {

            }
        }

        public void DrawGraph()
        {
            ChartMusking.Series.Clear();
            ChartMusking.Series.Add("FOS = 1");

            for (i = 0; i < n; i++)
            {
                if(RadioAmount.Checked==true)
                {
                    ChartMusking.Series["FOS = 1"].Points.AddXY(XRainAmount[i], RainInt[i]);
                }
                else if(RadioTime.Checked == true)
                {
                    ChartMusking.Series["FOS = 1"].Points.AddXY(Time[i], RainInt[i]);
                    
                }
                
            }

            ChartMusking.Series["FOS = 1"].Color = Color.Green;

            //ChartMusking.Series["Line"].Points.AddXY(2, 2);
            ChartMusking.Series["FOS = 1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }


        public void Velocity_calc() 
        {
            try
            {
                TxtV.Text = (Convert.ToDouble(TxtKs.Text) / 100 * Math.Sin(Convert.ToDouble(TxtAlpha.Text) * Math.PI / 180)).ToString();
            }
            catch
            {

            }
            
        }
        public void LDT_Calc()
        {
            try
            {
                TxtLDt.Text = (Convert.ToDouble(TxtL.Text) * Convert.ToDouble(TxtThetaDR.Text) / Convert.ToDouble(TxtDT.Text)).ToString();
            }
            catch
            {

            }
            
        }

        public void SetGridColorAndFont()
        {
            this.dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;

            this.dataGridView1.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
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

        public void Generaterows()
        {
            try
            {
                n = Convert.ToInt32(TxtRainData.Text);
            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridView1.Rows.Clear();

            for (i = 0; i < n; i++)
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i+1;
                
            }
        }

        public void RainIntensityInput()
        {
            try
            {
                for(i=0;i<n;i++)
                {
                    RainInt[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                    //MessageBox.Show("Rainfall = " + RainInt[i]);
                }
            }
            catch
            {

            }
        }

    }
}
