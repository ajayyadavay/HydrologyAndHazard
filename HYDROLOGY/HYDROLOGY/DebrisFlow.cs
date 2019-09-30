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
    public partial class FrmDebrisFlow : Form
    {
        double [,] Debris_M = new double[1000,1000];
        double[,] Debris_h = new double[1000, 1000];
        double[,] Debris_c = new double[1000, 1000];
        double[,] Debris_z = new double[1000, 1000];
        //double[,] Debris_v = new double[1000, 1000]; 
        double XDX, CXDX, h_bar, c_bar, z_bar, rho_m_bar, theta, tau_y, f;
        double term1, term3a, term3b, term3, denominator, XDX1,XDX2,CXDX1,CXDX2;
        double v_ip1_bar, v_im1_bar, tanTheta0;
        double rho, sigma, dia, L, B, delT, delX;
        string path;

        private void BtnExportToExcel_Click(object sender, EventArgs e)
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "Debris Flow Simulation " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

                //((Excel.Range)xlWorkSheet.Cells[2, 1]).Value = "Δt (hr)";
                //value of k in Cell[1,2]
                //((Excel.Range)xlWorkSheet.Cells[2, 2]).Value = this.TxtDT.Text;

                //((Excel.Range)xlWorkSheet.Cells[4, 2]).Value = this.TxtDes.Text;

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

        private void CopyAlltoClipboard()
        {
            dataGridViewMusking.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewMusking.MultiSelect = true;
            dataGridViewMusking.SelectAll();
            DataObject dataObj = dataGridViewMusking.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void BtnImportBoundaries_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            openfiledialog1.FilterIndex = 1;

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openfiledialog1.FileName;
            }
            else if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            dataGridView2.DataSource = null;

            for (int j = 0; j < dataGridView2.Rows.Count - 1; j++)
            {
                dataGridView2.Rows.RemoveAt(j);
                j--;
                while (dataGridView2.Rows.Count == 0)
                    continue;
            }

            Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks workbooks = app.Workbooks;

            Excel.Workbook workbook = workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            try
            {
                int rcount = Debris_TotalTime;

                int i = 0;

                for (i = 0; i <= rcount; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = worksheet.Cells[i + 3, 8].value;
                    dataGridView2.Rows[i].Cells[1].Value = worksheet.Cells[i + 3, 9].value;
                    dataGridView2.Rows[i].Cells[2].Value = worksheet.Cells[i + 3, 10].value;
                    dataGridView2.Rows[i].Cells[3].Value = worksheet.Cells[i + 3, 11].value;
                    dataGridView2.Rows[i].Cells[4].Value = worksheet.Cells[i + 3, 12].value;
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
            MessageBox.Show("IMPORT FOR BOUNDARY CONDITIONS COMPLETED !");
        }


        private void BtnImportInitials_Click(object sender, EventArgs e)
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
                int rcount = Debris_totalSection;

                int i = 0;

                for (i = 0; i <= rcount; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = worksheet.Cells[i + 3, 2].value;
                    dataGridView1.Rows[i].Cells[1].Value = worksheet.Cells[i + 3, 3].value;
                    dataGridView1.Rows[i].Cells[2].Value = worksheet.Cells[i + 3, 4].value;
                    dataGridView1.Rows[i].Cells[3].Value = worksheet.Cells[i + 3, 5].value;
                    dataGridView1.Rows[i].Cells[4].Value = worksheet.Cells[i + 3, 6].value;
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
            MessageBox.Show("IMPORT FOR INITIAL CONDITION COMPLETED !");
        }

        private void TxtDelT_TextChanged(object sender, EventArgs e)
        {

        }

        double g = 9.81;
        double k1, k2,c_star,ST;

        private void TxtL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
                GeneraterowsForInitial();
            }
            catch
            {

            }
        }

        private void TxtDelX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
                GeneraterowsForInitial();
            }
            catch
            {

            }
        }
        private void GeneraterowsForInitial()
        {
            try
            {
                delX = Convert.ToDouble(TxtDelX.Text);
                L = Convert.ToDouble(TxtL.Text);
                Debris_totalSection = Convert.ToInt32(L / delX);
            }
            catch
            {
               
            }
            dataGridView1.Rows.Clear();

            for (i = 0; i <= Debris_totalSection; i++)
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i;

            }
        }

        private void TxtTotalTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
                GeneraterowsBoundary();
            }
            catch
            {

            }
        }

        private void GeneraterowsBoundary()
        {
            try
            {
                Debris_TotalTime = Convert.ToInt32(TxtTotalTime.Text);
            }
            catch
            {

            }
            dataGridView2.Rows.Clear();

            for (i = 0; i <= Debris_TotalTime; i++)
            {
                i = dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = i;

            }
        }

        double kg, kf, e, alpha, phi;
        int Debris_TotalTime, Debris_totalSection;
        double DebrisInitial_h, DebrisInitial_z, DebrisInitial_c, DebrisInitial_M, DebrisInitialSo;
        double DebrisBoundary_h, DebrisBoundary_z, DebrisBoundary_c, DebrisBoundary_M;
        //double DebrisInitial_v, DebrisBoundary_v;
        int i, j,k,Debris_n;


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                SimulateDebrisFlow();
            }
            catch
            {
                
            }
        }

        

        public FrmDebrisFlow() 
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDebrisFlow_Load(object sender, EventArgs e)
        {
            try
            {
                L = Convert.ToDouble(TxtL.Text);
                delX = Convert.ToDouble(TxtDelX.Text);
                Debris_TotalTime = Convert.ToInt32(TxtTotalTime.Text);

                Debris_totalSection = Convert.ToInt32(L / delX);

                //TxtBoundaryZ.Text = TxtInitialz.Text;
                Generaterows();
                GeneraterowsForInitial();
                GeneraterowsBoundary();
                SetGridColorAndFont();
            }
            catch
            {

            }
        }
        private void Input()
        {
            try
            {
                rho = Convert.ToDouble(TxtWaterDensity.Text);
                sigma = Convert.ToDouble(TxtSoilDensity.Text);
                dia = Convert.ToDouble(TxtParticleDiameter.Text);
                c_star = Convert.ToDouble(TxtCstar.Text);

                L = Convert.ToDouble(TxtL.Text);
                B = Convert.ToDouble(TxtB.Text);

                kg = Convert.ToDouble(Txtkg.Text);
                kf = Convert.ToDouble(Txtkf.Text);
                e = Convert.ToDouble(Txte.Text);
                alpha = Convert.ToDouble(Txtalpha.Text);
                phi = Convert.ToDouble(Txtphi.Text);

                delT = Convert.ToDouble(TxtDelT.Text);
                delX = Convert.ToDouble(TxtDelX.Text);
                Debris_TotalTime = Convert.ToInt32(TxtTotalTime.Text);

                /*DebrisInitial_h = Convert.ToDouble(TxtInitialh.Text);
                DebrisInitial_c = Convert.ToDouble(TxtinitialC.Text);
                //DebrisInitial_v = Convert.ToDouble(TxtinitialV.Text);
                DebrisInitial_z = Convert.ToDouble(TxtInitialz.Text);
                DebrisInitialSo = Convert.ToDouble(TxtInitialSo.Text);
                DebrisInitial_M = Convert.ToDouble(TxtinitialM.Text);*/

                //DebrisBoundary_h = Convert.ToDouble(TxtBoudaryWaterh.Text);
                //DebrisBoundary_c = Convert.ToDouble(TxtBoundaryC.Text);
                //DebrisBoundary_v = Convert.ToDouble(TxtBoundaryV.Text);
                //DebrisBoundary_z = Convert.ToDouble(TxtBoundaryZ.Text);
                //DebrisBoundary_M = Convert.ToDouble(TxtBoundaryM.Text);
            }
            catch
            {

            }
            
        }

        private void AssignInitialAndBoundaryCondition()
        {
            try
            {
                // assign intitial z to t = 1
                for(i=0;i<=Debris_totalSection;i++)
                {
                    //Debris_z[1, i] = DebrisInitial_z - DebrisInitialSo * delX * i;

                    Debris_z[1, i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    
                }
                
                // assign initial scalars to t = 1
                for (i = 0; i <= Debris_totalSection; i++)
                {
                    //Debris_h[1, i] = DebrisInitial_h;
                    //Debris_c[1, i] = DebrisInitial_c;

                    //Debris_v[1, i] = DebrisInitial_v;

                    Debris_h[1, i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    Debris_c[1, i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);

                }
                //assign initial M to zeroth time
                for (i = 0; i <= Debris_totalSection; i++)
                {
                    //Debris_M[0, i] = DebrisInitial_M;

                    Debris_M[0, i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }

                
                //------------------------------Boundary conditions-----------------------
                // assign boundary for z,h,c,v for node 1
                for (j = 0; j <= Debris_TotalTime; j++)
                {
                    /*Debris_z[j, 1] = Debris_z[1,1];

                    Debris_h[j, 1] = DebrisBoundary_h;
                    Debris_c[j, 1] = DebrisBoundary_c;*/
                    //Debris_v[j, 1] = DebrisBoundary_v;

                    Debris_z[j, 1] = Convert.ToDouble(dataGridView2.Rows[j].Cells[3].Value);

                    Debris_h[j, 1] = Convert.ToDouble(dataGridView2.Rows[j].Cells[2].Value);

                    Debris_c[j, 1] = Convert.ToDouble(dataGridView2.Rows[j].Cells[4].Value);

                }
                // assign boundary M for zeroth node
                for (j = 0; j <= Debris_TotalTime; j++)
                {
                    //Debris_M[j, 0] = DebrisBoundary_M;

                    Debris_M[j, 0] = Convert.ToDouble(dataGridView2.Rows[j].Cells[1].Value);

                }
            }
            catch
            {

            }
        }
        private void SimulateDebrisFlow()
        {
            try
            {
                // input
                Input();
                Debris_totalSection = Convert.ToInt32(L / delX);

                // boundary and initial conditions
                AssignInitialAndBoundaryCondition();

                // simulation
                // calculate M
                for(j = 2; j <= Debris_TotalTime; j++)
                {
                    for(i = 2; i <= Debris_totalSection; i++)
                    {
                        if(j % 2 == 0 && i % 2 == 0) // for M
                        {
                            h_bar = (Debris_h[j - 1, i - 1] + Debris_h[j - 1, i + 1]) / 2;
                            z_bar = (Debris_z[j - 1, i - 1] + Debris_z[j - 1, i + 1]) / 2;
                            c_bar = (Debris_c[j - 1, i - 1] + Debris_c[j - 1, i + 1]) / 2;
                            rho_m_bar = (sigma - rho) * c_bar + rho;
                            theta = -Math.Atan((Debris_z[j - 1, i + 1] - Debris_z[j - 1, i - 1]) / (2.0 * delX));// theta in radian
                            tau_y = (sigma - rho) * c_bar * g * h_bar* Math.Cos(theta) * 1 / (1 + alpha) * Math.Tan(phi * Math.PI / 180);
                            
                            f = (25.0 / 4) * (kf * Math.Pow(1 - c_bar, 5.0/3.0) / Math.Pow(c_bar, 2.0/3.0) + kg * sigma / rho * (1 - e * e) * Math.Pow(c_bar, 1.0/3.0)) * (Math.Pow(h_bar / dia, -2.0));

                            term1 = -g * h_bar * (Debris_h[j - 1, i + 1] - Debris_h[j - 1, i - 1] + Debris_z[j - 1, i + 1] - Debris_z[j - 1, i - 1]) / (2 * delX);
                            term3a = 1 / (2 * delT * 3600);
                            term3b = rho / rho_m_bar * f * 1 / (2 * h_bar) * Math.Abs(Debris_M[j - 2, i] / h_bar);
                            term3 = - tau_y / rho_m_bar + (term3a - term3b) * Debris_M[j - 2, i];

                            denominator = term3a + term3b;

                            v_ip1_bar = Debris_M[j - 2, i] / (Debris_h[j - 1, i - 1] + Debris_h[j - 1, i + 1]) + Debris_M[j - 2, i + 2] / (Debris_h[j - 1, i + 1] + Debris_h[j - 1, i + 3]);
                            v_im1_bar = Debris_M[j - 2, i] / (Debris_h[j - 1, i - 1] + Debris_h[j - 1, i + 1]) + Debris_M[j - 2, i - 2] / (Debris_h[j - 1, i - 1] + Debris_h[j - 1, i + 1]);

                            //v_ip1_bar = 3;
                            //v_im1_bar = 3;

                            XDX1 = v_ip1_bar * (Debris_M[j - 2, i] + Debris_M[j - 2, i + 2]) + Math.Abs(v_ip1_bar) * (Debris_M[j - 2, i] - Debris_M[j - 2, i + 2]);
                            XDX2 = -v_im1_bar * (Debris_M[j - 2, i - 2] + Debris_M[j - 2, i]) - Math.Abs(v_im1_bar) * (Debris_M[j - 2, i - 2] - Debris_M[j - 2, i]);
                            XDX = (XDX1 + XDX2) / (4 * delX);

                            Debris_M[j, i] = (term1 - XDX + term3) / denominator;
                            
                        }
                        else if(j % 2 != 0 && i % 2 != 0) // for scalars
                        {
                            tanTheta0 = -(Debris_z[j-2,i+2] - Debris_z[j-2,i]) / (2.0 * delX);
                            Debris_c[j, i] = rho * tanTheta0 / ((sigma - rho) * (Math.Tan(phi * Math.PI / 180) - tanTheta0));

                            CXDX1 = Debris_M[j - 1, i + 1] * (Debris_c[j - 2, i] + Debris_c[j - 2, i + 2]) + Math.Abs(Debris_M[j - 1, i - 1]) * (Debris_c[j - 2, i] - Debris_c[j - 2, i + 2]);
                            CXDX2 = -Debris_M[j - 1, i - 1] * (Debris_c[j - 2, i - 2] + Debris_c[j - 2, i]) - Math.Abs(Debris_M[j - 1, i - 1]) * (Debris_c[j - 2, i - 2] - Debris_c[j - 2, i]);
                            CXDX = (CXDX1 + CXDX2) / (4 * delX);

                            k1 = delT * 3600 / delX * (Debris_M[j - 1, i + 1] - Debris_M[j - 1, i - 1]) - Debris_h[j - 2, i];
                            k2 = 2 * delT * 3600 * CXDX - Debris_c[j - 2, i] * Debris_h[j - 2, i];

                            Debris_h[j, i] = (c_star * k1 - k2) / (Debris_c[j, i] - c_star);
                            ST = (Debris_c[j, i] * k1 - k2) / (2 * delT * 3600 * (Debris_c[j, i] - c_star));
                            Debris_z[j, i] = Debris_z[j - 2, i] - 2 * delT * 3600 * ST;
                        }

                    }
                }

                // output to the datagrid
                Generaterows();
                int index = 0;
                for (j = 0; j <= Debris_TotalTime; j++)
                {
                    for(i = 0; i <= Debris_totalSection; i++)
                    {
                        if (j % 2 != 0 && i % 2 != 0) // for scalars
                        {
                            dataGridViewMusking.Rows[index].Cells[3].Value = Debris_h[j, i].ToString("0.000000");
                            dataGridViewMusking.Rows[index].Cells[4].Value = Debris_c[j, i].ToString("0.000000");
                            dataGridViewMusking.Rows[index].Cells[5].Value = Debris_z[j, i].ToString("0.000000");
                            //dataGridViewMusking.Rows[index].Cells[6].Value = Debris_v[j, i].ToString("0.000000");
                            index++;
                        }
                        else if(j % 2 == 0 && i % 2 == 0) // for M
                        {
                            dataGridViewMusking.Rows[index].Cells[2].Value = Debris_M[j, i].ToString("0.000000");
                            index++;
                        }
                        else
                        {
                            index++;
                        }
                    }
                }
            }
            catch
            {

            }
        }

        public void SetGridColorAndFont()
        {
            dataGridViewMusking.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridViewMusking.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewMusking.DefaultCellStyle.SelectionForeColor = Color.White;
            //dataGridViewMusking.DefaultCellStyle.SelectionBackColor = Color.Purple;
            dataGridViewMusking.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView2.DefaultCellStyle.Font = new Font("Comic Sans MS", 12);
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        public void Generaterows()
        {
            try
            {
                delX= Convert.ToDouble(TxtDelX.Text);
                delT = Convert.ToDouble(TxtDelT.Text);
                L = Convert.ToDouble(TxtL.Text);

                Debris_TotalTime = Convert.ToInt32(TxtTotalTime.Text);

                Debris_totalSection = Convert.ToInt32(L / delX);
                TxtIntervalX.Text = Debris_totalSection.ToString();
                TxtSection.Text = (Debris_totalSection).ToString();

            }
            catch
            {

            }
            dataGridViewMusking.Rows.Clear();

            try
            {
                k = 0;
                Debris_n= 0;

                k = dataGridViewMusking.Rows.Add();

                for (i = 0; i <= Debris_TotalTime; i++)
                {
                    //k = dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[k].Cells[0].Value = i;

                    for (j = 0; j <= Debris_totalSection; j++)
                    {
                        dataGridViewMusking.Rows[k].Cells[1].Value = j;
                        k++;
                        Debris_n++;
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
