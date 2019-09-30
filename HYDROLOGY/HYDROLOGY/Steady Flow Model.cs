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
    public partial class FrmSteadyFlowModel : Form
    {
        int i, j,k;
        public static int SFM_n, SFM_n_Section, SFM_Total_Time;
        double SFM_Mannings, SFM_WaterDensity, SFM_SoilDensity, SFM_SoilDiamter, SFM_Porosity;
        double SFM_Q;
        double SFM_Tau_C_Star, SFM_U_C_Star;
        double SFM_Initial_h, SFM_Initial_zb; 
        double SFM_Boundary_h, SFM_Boundary_qb;
        double  SFM_del_X, SFM_del_t, SFM_L, SFM_B,Fr;

        double k1, k2, k3, k4, k5, k6, k7, k8, k9,g = 9.81;

        private void TxtTauCStar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindUcStar();
                FindqbAtBoundary();
            }
            catch
            {

            }
            
        }

        private void TxtSoilDensity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindUcStar();
                FindqbAtBoundary();
            }
            catch
            {

            }
        }

        private void TxtWaterDensity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindUcStar();
                FindqbAtBoundary();
            }
            catch
            {

            }
        }

        private void TxtParticleDiameter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FindUcStar();
                FindqbAtBoundary();
            }
            catch
            {

            }
        }

        private void TxtBoudaryWaterh_TextChanged(object sender, EventArgs e)
        {
            FindqbAtBoundary();
        }

        public void FindUcStar()
        {
            double temp_uc_star, temp_tau_c_star;
            SFM_WaterDensity = Convert.ToDouble(TxtWaterDensity.Text);
            SFM_SoilDensity = Convert.ToDouble(TxtSoilDensity.Text);
            SFM_SoilDiamter = Convert.ToDouble(TxtParticleDiameter.Text);

            k4 = (SFM_SoilDensity / SFM_WaterDensity - 1) * g * SFM_SoilDiamter;

            temp_tau_c_star = Convert.ToDouble(TxtTauCStar.Text);
            temp_uc_star = Math.Sqrt(temp_tau_c_star * k4);

            TxtUCStar.Text = temp_uc_star.ToString("0.00000"); 
        }

        private void TxtManning_TextChanged(object sender, EventArgs e)
        {
            FindqbAtBoundary();
        }

        private void TxtQ_TextChanged(object sender, EventArgs e)
        {
            FindqbAtBoundary();
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            FindqbAtBoundary();
        }

        private void TxtInitialz_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtBoundaryZb.Text = TxtInitialz.Text;
            }
            catch
            {

            }
        }

        private void BtnSchematic_Click(object sender, EventArgs e)
        {
            FrmSteadySchematic fsteadyschematic = new FrmSteadySchematic();
            fsteadyschematic.Show();
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "Steady Flow Model " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

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

        private void TxtTotalTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void TxtDelT_TextChanged(object sender, EventArgs e)
        {

        }

        double x1, y1, x2, y2, y;
        int iterations = 2000;

        private void BtnImport_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnProfilePlot_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProfilePlot fprofileplot = new FrmProfilePlot();
                fprofileplot.Show();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public static double[,] SFM_qb = new double[5000, 5000];
        public static double[,] SFM_h = new double[5000, 5000];
        public static double[,] SFM_zb = new double[5000, 5000];

        double qb, zb, fx, dq_by_dh, dz_by_dh, df_by_dh, h1, h0, error, myerr;

        double ie, u_star, tau_star, qb_steady; 

        private void TxtL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
            }
            catch
            {

            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                SteadyFlowCalculation();
            }
            catch
            {

            }
        }

        public void SteadyFlowCalculation()
        {
            double term1, term2, term3, h_final,z_final, q_final, constant;
            //double ie_D1, u_st_D1, tau_st_D1, qb_D1, zb_D1, ie_U1, f_x, du_D1_by_dh, dqb_D1_by_dh, dzb__D1_by_dh, dfx_by_dh;
            //double dTau_D1_by_dh;
            try
            {
                // input
                Input();

                SFM_n_Section = Convert.ToInt32(SFM_L / SFM_del_X);

                // initial (zb) and boudaryconditions (qb, h, zb)
                AssingInitialAndBoundaryCondititon();

                // calculate h,q,z at each section of (t+1) time step
                //h0 = SFM_Initial_h + 0.1;
                h0 = SFM_Boundary_h - 0.05;
                constant = 1 / (1 - SFM_Porosity) * (SFM_del_t * 3600 / SFM_del_X);

                for (j = 0; j <= SFM_Total_Time; j++)
                {
                    ////h0 = SFM_h[j-1,0] - 0.01;
                    //y1 = 0.3;
                    //y1 = SFM_h[j-1, 0] + 0.1;
                    //x1 = 0.63425;
                    //x1 = k1 / (y1 * y1) + y1 + zb - k1 / (SFM_h[j, i - 1] * SFM_h[j, i - 1]) - SFM_h[j, i - 1] - SFM_zb[j, i - 1] + 0.5 * SFM_del_X * (k2 / (Math.Pow(h0, 3.33)) + k2 / (Math.Pow(SFM_h[j, i - 1], 3.33)));
                    h0 = SFM_Boundary_h - 0.05;
                    /* h_final = SFM_h[j, 0];
                     q_final = SFM_qb[j, 0];
                     z_final = SFM_zb[j, 0];*/

                    for (i = 1; i <= SFM_n_Section; i++)
                    {
                        if(j ==0)
                        {
                            h0 = SFM_h[j, i - 1];
                        }
                        else
                        {
                            h0 = SFM_h[j-1, i];
                        }
                        bool SolutionFound = false;
                        iterations = 20000;
                        ///do
                        for(int itr=1; itr <= iterations; itr++)
                        {
                            /*SFM_h[j, i - 1] = h_final;
                            SFM_zb[j, i - 1] = z_final;
                            SFM_qb[j, i - 1] = q_final;*/
                            if(j==0)
                            {
                                fx = k1 / (h0 * h0) + h0 + SFM_zb[j,i] - k1 / (SFM_h[j, i - 1] * SFM_h[j, i - 1]) - SFM_h[j, i - 1] - SFM_zb[j, i - 1] + 0.5 * SFM_del_X * (k2 / (Math.Pow(h0, 3.33)) + k2 / (Math.Pow(SFM_h[j, i - 1], 3.33)));

                                qb = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));

                                df_by_dh = -2 * k1 * Math.Pow(h0, -3) + 1 + SFM_del_X * 0.5 * k2 * (-3.33) * Math.Pow(h0, -4.33);
                                
                            }
                            else if(j > 0)
                            {
                                zb = SFM_zb[j - 1, i] - constant * (SFM_qb[j - 1, i] - SFM_qb[j - 1, i - 1]);

                                fx = k1 / (h0 * h0) + h0 + zb - k1 / (SFM_h[j, i - 1] * SFM_h[j, i - 1]) - SFM_h[j, i - 1] - SFM_zb[j, i - 1] + 0.5 * SFM_del_X * (k2 / (Math.Pow(h0, 3.33)) + k2 / (Math.Pow(SFM_h[j, i - 1], 3.33)));

                                qb = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                                
                                /*term1 = (-3.495 * Math.Pow(h0, -4.495) * k7) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                                term2 = (k7 * Math.Pow(h0, -3.495)) * (-k8 * 2.33 * Math.Pow(h0, 1.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                                term3 = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (-k9 * 1.165 * Math.Pow(h0, 0.165));
                                dq_by_dh = term1 + term2 + term3;

                                //dz_by_dh = -1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * dq_by_dh;
                                dz_by_dh = -constant * dq_by_dh;*/

                                //df_by_dh = -2 * k1 * Math.Pow(h0, -3) + 1 + dz_by_dh + SFM_del_X * 0.5 * k2 * (-3.33) * Math.Pow(h0, -4.33);
                                df_by_dh = -2 * k1 * Math.Pow(h0, -3) + 1 + SFM_del_X * 0.5 * k2 * (-3.33) * Math.Pow(h0, -4.33);
                            }
                            //MessageBox.Show("qb = " + qb + "\nzb = " + zb + "\nfx = " + fx + "\nh0 = " + h0);

                            ///qb = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                            //zb = SFM_zb[i, j - 1] - 1 / (1 - SFM_Porosity) * (SFM_del_t * 3600 / SFM_del_X) * (qb - SFM_qb[i - 1, j]);
                            ///zb = SFM_zb[j - 1, i] - 1 / (1 - SFM_Porosity) * (SFM_del_t * 3600 / SFM_del_X) * (qb - SFM_qb[j, i-1]);
                            //MessageBox.Show(k7 + "*" + h0 + "^" + (-3.495)  + " = " + k7* Math.Pow(h0, -3.495));
                            // MessageBox.Show( "qb, i = " + qb + " , " + i + " ; " + 1 + " - " + k9 + " * " + Math.Pow(h0, 2.33) + " = " + (1 - k9 * Math.Pow(h0, 1.165)));
                            //fx = k1 / (h0 * h0) + h0 + zb - k1 / (SFM_h[i - 1, j] * SFM_h[i - 1, j]) - SFM_h[i - 1, j] - SFM_zb[i - 1, j] + 0.5 * SFM_del_X * (k2 / (Math.Pow(h0, 3.33)) + k2 / (Math.Pow(SFM_h[i - 1, j], 3.33)));
                            ///fx = k1 / (h0 * h0) + h0 + zb - k1 / (SFM_h[j, i - 1] * SFM_h[j, i - 1]) - SFM_h[j, i - 1] - SFM_zb[j, i - 1] + 0.5 * SFM_del_X * (k2 / (Math.Pow(h0, 3.33)) + k2 / (Math.Pow(SFM_h[j, i - 1], 3.33)));

                            // derivatives
                            //----------------------------------
                            /*term1 = (-3.495 * Math.Pow(h0, -4.495) * k7) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                             term2 = (k7 * Math.Pow(h0, -3.495)) * (-k8 * 2.33 * Math.Pow(h0, 1.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                             term3 = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (-k9 * 1.165 * Math.Pow(h0, 0.165));
                             dq_by_dh = term1 + term2 + term3;

                             //dz_by_dh = -1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * dq_by_dh;
                             dz_by_dh = -constant * dq_by_dh;

                             df_by_dh = -2 * k1 * Math.Pow(h0, -3) + 1 + dz_by_dh + SFM_del_X *0.5 * k2 * (-3.33) * Math.Pow(h0, -4.33);
                             */ //-------------------------------

                            // MessageBox.Show("i = " + i + "\nqb: " + qb + "\nzb: " + zb + "\nterm1: " +term1 + "\nterm2: " +term2+ "\ndf/dh: " + df_by_dh);
                            // MessageBox.Show("Before h0: " + h0);
                            //Method 2:

                            /* ie_D1 = k2 * (Math.Pow(h0, -3.33));
                             //MessageBox.Show(k2 + " * " + h0 + " ^ -3.33" + " = " + k2 * (Math.Pow(h0, -3.33)));
                             u_st_D1 = k5 * Math.Pow(h0, -1.165);
                             tau_st_D1 = u_st_D1 * u_st_D1 / k4;
                             //qb_D1 = k3 * Math.Pow(tau_st_D1, 1.5) * (1 - SFM_Tau_C_Star / tau_st_D1) * (1 - SFM_U_C_Star / u_st_D1);
                             qb_D1 = (k7 * Math.Pow(h0, -3.495)) * (1 - k8 * Math.Pow(h0, 2.33)) * (1 - k9 * Math.Pow(h0, 1.165));
                             MessageBox.Show(i + "   " + qb_D1);
                             zb_D1 = SFM_zb[i, j - 1] - 1 / (1 - SFM_Porosity) * SFM_del_t * 3600/ SFM_del_X * (qb_D1 - SFM_qb[i - 1, j]);
                             ie_U1 = k2 / Math.Pow(SFM_h[i - 1, j], 3.33);
                             //f_x = k1 / (h0 * h0) + h0 + zb_D1 - k1/(SFM_h[i - 1, j]* SFM_h[i - 1, j]) - SFM_h[i - 1, j] - SFM_zb[i - 1, j] + SFM_del_X * 0.5 * (ie_D1 + ie_U1);
                             f_x = k1 / (h0 * h0) + h0 + zb_D1 - k1 / (SFM_h[i - 1, j] * SFM_h[i - 1, j]) - SFM_h[i - 1, j] - SFM_zb[i - 1, j]+ SFM_del_X * 0.5 *k2* (1/(h0*h0) + 1/ (SFM_h[i - 1, j] * SFM_h[i - 1, j]));
                             du_D1_by_dh = -1.165 * k5 * Math.Pow(h0, -2.165);
                             dTau_D1_by_dh = 1 / k4 * 2 * u_st_D1 * du_D1_by_dh;
                             term1 = 1.5 * k3 * Math.Pow(tau_st_D1, 0.5) * dTau_D1_by_dh * (1 - SFM_Tau_C_Star / tau_st_D1) * (1 - SFM_U_C_Star / u_st_D1);
                             term2 = k3 * Math.Pow(tau_st_D1, 1.5) * (-SFM_Tau_C_Star * (-1) * Math.Pow(tau_st_D1, -2)) * dTau_D1_by_dh * (1 - SFM_U_C_Star / u_st_D1);
                             term3 = k3 * Math.Pow(tau_st_D1, 1.5) * (1 - SFM_Tau_C_Star / tau_st_D1) * (-SFM_U_C_Star * (-1) * Math.Pow(u_st_D1, -2)) * du_D1_by_dh;
                             dqb_D1_by_dh = term1 + term2 + term3;
                             dzb__D1_by_dh = -1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * dqb_D1_by_dh;
                             dfx_by_dh = -2 * k1 * Math.Pow(h0, -3) + 1 + dzb__D1_by_dh + SFM_del_X * 0.5 * k2 * (-3.33 * Math.Pow(h0, -4.33)); */

                            //MessageBox.Show("qb: " + qb_D1 + "\nzb: " + zb_D1 + "\nie_D1: " + ie_D1 + "\nie_U1: " + ie_U1 + "\ndf/dh: " + dfx_by_dh);
                            //Newton Rapshon's Method

                            //h1 = h0 - f_x / dfx_by_dh;
                            // MessageBox.Show("Just h1: " + h1 + "\nf_x = " + fx + "\nSFM_zb[i - 1, j] = " + SFM_zb[i - 1, j] + "\nsfm_qb[i-1,j] = " + SFM_qb[i - 1, j] + "\nzb_D1 = " + zb);
                            h1 = h0 - fx / df_by_dh;
                            h0 = h1;
                            error = Math.Abs(fx);

                            if (error <= myerr)
                            {
                                if(j==0)
                                {
                                    SFM_h[j, i] = h0;
                                    SFM_qb[j, i] = qb;
                                }
                                else if(j > 0)
                                {
                                    SFM_h[j, i] = h0;
                                    SFM_qb[j, i] = qb;
                                    SFM_zb[j, i] = zb;
                                }
                                //SFM_zb[j, i] = zb;

                                SolutionFound = true;
                                break;
                            }

                            /* if(itr ==1)
                             {
                                 //y1 = h0;
                                 //x1 = fx;

                                // h0 = 0.3;
                                 y1 = 0.3;
                                 x1 = 0.63425;
                                 h0 = h0 + 0.1;
                             }

                             error = Math.Abs(fx);

                             if(itr > 1)
                             {
                                 x2 = fx;
                                 y2 = h0;

                                 y = Math.Abs(y1 + (y2 - y1) / (x2 - x1) * (0 - x1));

                                 h0 = y;
                                 x1 = x2;
                                 y1 = y2;
                             }

                             if(error <= myerr)
                             {
                                 h_final = h0;
                                 q_final = qb;
                                 z_final = zb;

                                 SFM_h[j, i] = h_final;
                                 SFM_qb[j, i] = q_final;
                                 SFM_zb[j, i] = z_final;

                                 flag = true;
                                 break;
                             }*/
                              
                            //MessageBox.Show("h0: " + h0 + "\nh1: " + h1 + "\nError: " + error);
                        } ///while (error > 0.0005);
                        // SFM_h[i, j] = h1;
                        if (SolutionFound == false)
                        {
                            //MessageBox.Show("Couldn't converge for given number of iteration at t = " + j + "for section onwards: " + i);
                            TxtMsg.Text = TxtMsg.Text + "Couldn't converge for given number of iteration at t = " + j + "for section onwards: " + i;
                            break;
                        }
                        ///SFM_h[j, i] = h1;
                        //SFM_qb[i,j] = (k7 * Math.Pow(SFM_h[i, j], -3.495)) * (1 - k8 * Math.Pow(SFM_h[i, j], 2.33)) * (1 - k9 * Math.Pow(SFM_h[i, j], 1.165));
                        ///SFM_qb[j, i] = (k7 * Math.Pow(SFM_h[j, i], -3.495)) * (1 - k8 * Math.Pow(SFM_h[j, i], 2.33)) * (1 - k9 * Math.Pow(SFM_h[j, i], 1.165));
                        //SFM_zb[i,j] = SFM_zb[i, j - 1] - 1 / (1 - SFM_Porosity) * (SFM_del_t / SFM_del_X) * (SFM_qb[i, j] - SFM_qb[i - 1, j]);
                        ///SFM_zb[j, i] = SFM_zb[j - 1,i] - 1 / (1 - SFM_Porosity) * (SFM_del_t / SFM_del_X) * (SFM_qb[j, i] - SFM_qb[j, i - 1]);
                        /* u_st_D1 = k5 * Math.Pow(SFM_h[i,j], -1.165);
                         tau_st_D1 = u_st_D1 * u_st_D1 / k4;

                         SFM_qb[i,j] = k3 * Math.Pow(tau_st_D1, 1.5) * (1 - SFM_Tau_C_Star / tau_st_D1) * (1 - SFM_U_C_Star / u_st_D1);

                         zb_D1 = SFM_zb[i, j - 1] - 1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * (SFM_qb[i, j] - SFM_qb[i - 1, j]);*/

                    }
                }
                TxtMsg.Text = TxtMsg.Text + "Calculation complete !";
                Generaterows();
                int index = 0;
                for (j = 0; j <= SFM_Total_Time; j++)
                {
                    for (i = 0; i <= SFM_n_Section; i++)
                    {
                        // dataGridViewMusking.Rows[index].Cells[2].Value = SFM_h[i, j].ToString("0.0000");
                        dataGridViewMusking.Rows[index].Cells[2].Value = SFM_h[j, i].ToString("0.000000");
                        // dataGridViewMusking.Rows[index].Cells[3].Value = SFM_qb[i, j].ToString("0.0000000");
                        dataGridViewMusking.Rows[index].Cells[3].Value = SFM_qb[j, i].ToString("E4");
                        // dataGridViewMusking.Rows[index].Cells[4].Value = SFM_zb[i, j].ToString("0.00000");
                        //MessageBox.Show("zbdsf " + i + " = " + SFM_zb[0, i]);
                        dataGridViewMusking.Rows[index].Cells[4].Value = SFM_zb[j, i].ToString("0.000000");
                        Fr = (SFM_Q / (SFM_B * SFM_h[j, i])) / (Math.Sqrt(9.81 * SFM_h[j, i]));
                        dataGridViewMusking.Rows[index].Cells[5].Value = Fr.ToString("0.00000");
                        index++;
                    }
                }
            }
            catch
            {

            }
        }
        public void FindqbAtBoundary()
        {
            try
            {
                SFM_Mannings = Convert.ToDouble(TxtManning.Text);
                SFM_WaterDensity = Convert.ToDouble(TxtWaterDensity.Text);
                SFM_SoilDensity = Convert.ToDouble(TxtSoilDensity.Text);
                SFM_SoilDiamter = Convert.ToDouble(TxtParticleDiameter.Text);

                SFM_Q = Convert.ToDouble(TxtQ.Text);

                SFM_B = Convert.ToDouble(TxtB.Text);

                SFM_Tau_C_Star = Convert.ToDouble(TxtTauCStar.Text);
                SFM_U_C_Star = Convert.ToDouble(TxtUCStar.Text);
                
                SFM_n_Section = Convert.ToInt32(SFM_L / SFM_del_X);
                k1 = SFM_Q * SFM_Q / (2 * g * SFM_B * SFM_B);
                k2 = SFM_Mannings * SFM_Mannings * SFM_Q * SFM_Q / (SFM_B * SFM_B);
                k3 = Math.Sqrt((SFM_SoilDensity / SFM_WaterDensity - 1) * g * SFM_SoilDiamter * SFM_SoilDiamter * SFM_SoilDiamter);
                k4 = (SFM_SoilDensity / SFM_WaterDensity - 1) * g * SFM_SoilDiamter;
                k5 = Math.Sqrt(g * k2);
                k6 = k5 * k5 / k4;
                k7 = k3 * Math.Pow(k6, 1.5);
                k8 = SFM_Tau_C_Star / k6;
                k9 = SFM_U_C_Star / k5;

                k7 = k3 * Math.Pow(k6, 1.5);
                k8 = SFM_Tau_C_Star / k6;
                k9 = SFM_U_C_Star / k5;

                SFM_Boundary_h = Convert.ToDouble(TxtBoudaryWaterh.Text);
                SFM_Boundary_qb = (k7 * Math.Pow(SFM_Boundary_h, -3.495)) * (1 - k8 * Math.Pow(SFM_Boundary_h, 2.33)) * (1 - k9 * Math.Pow(SFM_Boundary_h, 1.165));

                TxtBoudarySedimentq.Text = SFM_Boundary_qb.ToString("E4");
            }
            catch
            {

            }
        }


        public void AssingInitialAndBoundaryCondititon()
        {
            // assign values for initial bed depth for all sections along x at t = 0
           /* for(i = 0; i <= SFM_n_Section; i++)
            {
                SFM_zb[i, 0] = SFM_Initial_zb;
                SFM_h[i, 0] = SFM_Initial_h;
            }*/

            // constants
            k1 = SFM_Q * SFM_Q / (2 * g * SFM_B * SFM_B);
            k2 = SFM_Mannings * SFM_Mannings * SFM_Q * SFM_Q / (SFM_B * SFM_B);
            k3 = Math.Sqrt((SFM_SoilDensity / SFM_WaterDensity - 1) * g * SFM_SoilDiamter * SFM_SoilDiamter * SFM_SoilDiamter);
            k4 = (SFM_SoilDensity / SFM_WaterDensity - 1) * g * SFM_SoilDiamter;
            k5 = Math.Sqrt(g * k2);
            k6 = k5 * k5 / k4;
            k7 = k3 * Math.Pow(k6, 1.5);
            k8 = SFM_Tau_C_Star / k6;
            k9 = SFM_U_C_Star / k5;

            // calculating h

            // calculating qb_steady
            
            // ie = k2 / (Math.Pow(SFM_Boundary_h, 3.33));
            /*u_star = Math.Sqrt(g * SFM_Initial_h * ie);
            tau_star = u_star * u_star / k4;*/

            FindqbAtBoundary();
            // for all nodes at t = 0 for all section
            ie = k2 / (Math.Pow(SFM_Initial_h, 3.33));
            for (i = 0; i <= SFM_n_Section; i++)
            {
                //SFM_zb[i, 0] = SFM_Initial_zb - i * ie * SFM_del_X;
                SFM_zb[0, i] = SFM_Initial_zb - i * ie * SFM_del_X;
                //MessageBox.Show("zb " + i + " = " + SFM_zb[0, i]);
                // SFM_h[i, 0] = SFM_Initial_h;
                ///SFM_h[0, i] = SFM_Initial_h;
            }

            /*if (tau_star > SFM_Tau_C_Star)
            {
                qb_steady = k3 * Math.Pow(tau_star, 1.5) * (1 - SFM_Tau_C_Star / tau_star) * (1 - SFM_U_C_Star / u_star);
            }
            else
            {
                qb_steady = 0;
            }*/

            //MessageBox.Show("qb_Steady = " + qb_steady + "\n tau_star = " + tau_star + "\n 1-tc/t = " + (1-SFM_Tau_C_Star/tau_star) + "\nie = " + ie + "\n1-uc/u = " + (1-SFM_U_C_Star/u_star));
            
            // assign values for sediment flow for all sections along x at t = 0
           /* for (i = 1; i <= SFM_n_Section; i++)
            {
                //SFM_qb[i, 0] =  qb_steady;
                SFM_qb[0, i] = qb_steady;
            }*/
            
            // Boundary Conditions
            for (j = 0; j <= SFM_Total_Time; j++)
            {
                //SFM_qb[0,j] = qb_steady * SFM_Boundary_qb;
                SFM_qb[j, 0] = SFM_Boundary_qb;
                /// SFM_h[0, j] = SFM_Boundary_h;
                SFM_h[j, 0] = SFM_Boundary_h;

                SFM_zb[j, 0] = SFM_Initial_zb;
                // SFM_zb[j, 0] = SFM_zb[j-1, 0] - 1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * (SFM_qb[j-1, 1] - SFM_qb[j-1, 0]);

            }

            // SFM_zb[0, 1] = SFM_zb[0, 0] - 1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * (SFM_qb[1, 0] - SFM_qb[0, 0]);
            /////////SFM_zb[1, 0] = SFM_zb[0, 0] - 1 / (1 - SFM_Porosity) * SFM_del_t * 3600 / SFM_del_X * (SFM_qb[0, 1] - SFM_qb[0, 0]);
            // SFM_zb[0, 1] = SFM_Initial_zb;
            ///SFM_zb[1, 0] = SFM_Initial_zb;
            ///MessageBox.Show("Zb(0,1) = " +  SFM_zb[0,1] +  "\n qb_Steady = " + SFM_qb[0,1] + " \nand [0,0] =  " + SFM_qb[0,0]);
            //MessageBox.Show("Zb(0,1) = " + SFM_zb[1, 0]);
        }

        public void Input()
        {
            try
            {
                SFM_Mannings = Convert.ToDouble(TxtManning.Text);
                SFM_Porosity = Convert.ToDouble(TxtPorosity.Text);
                SFM_WaterDensity = Convert.ToDouble(TxtWaterDensity.Text);
                SFM_SoilDensity = Convert.ToDouble(TxtSoilDensity.Text);
                SFM_SoilDiamter = Convert.ToDouble(TxtParticleDiameter.Text);

                SFM_Q = Convert.ToDouble(TxtQ.Text);

                SFM_L = Convert.ToDouble(TxtL.Text);
                SFM_B = Convert.ToDouble(TxtB.Text);

                SFM_Tau_C_Star = Convert.ToDouble(TxtTauCStar.Text);
                SFM_U_C_Star = Convert.ToDouble(TxtUCStar.Text);

                SFM_del_X = Convert.ToDouble(TxtDelX.Text);
                SFM_del_t = Convert.ToDouble(TxtDelT.Text);
                SFM_Total_Time = Convert.ToInt32(TxtTotalTime.Text);
                myerr = Convert.ToDouble(TxtError.Text);

                SFM_Initial_h = Convert.ToDouble(TxtInitialh.Text);
                SFM_Initial_zb = Convert.ToDouble(TxtInitialz.Text);

                SFM_Boundary_h = Convert.ToDouble(TxtBoudaryWaterh.Text);
                SFM_Boundary_qb = Convert.ToDouble(TxtBoudarySedimentq.Text);

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
            }
            catch
            {

            }
        }

        public FrmSteadyFlowModel()
        {
            InitializeComponent();
        }

        private void FrmSteadyFlowModel_Load(object sender, EventArgs e)
        {
            try
            {
                SFM_L = Convert.ToDouble(TxtL.Text);
                SFM_del_X = Convert.ToDouble(TxtDelX.Text);
                SFM_Total_Time = Convert.ToInt32(TxtTotalTime.Text);

                SFM_n_Section = Convert.ToInt32(SFM_L / SFM_del_X);

                TxtBoundaryZb.Text = TxtInitialz.Text;
                Generaterows();
                SetGridColorAndFont();
                TxtIntervalX.BackColor = SystemColors.Window;
                TxtSection.BackColor = SystemColors.Window;
                TxtBoundaryZb.BackColor = SystemColors.Window;
                FindUcStar();
                FindqbAtBoundary();
                
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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Generaterows()
        {
            try
            {
                SFM_del_X = Convert.ToDouble(TxtDelX.Text);
                SFM_del_t = Convert.ToDouble(TxtDelT.Text);
                SFM_L = Convert.ToDouble(TxtL.Text);

                SFM_Total_Time = Convert.ToInt32(TxtTotalTime.Text);

                SFM_n_Section =Convert.ToInt32(SFM_L / SFM_del_X);
                TxtIntervalX.Text = SFM_n_Section.ToString();
                TxtSection.Text = (SFM_n_Section).ToString();
                // SFM_n = SFM_n_Section * 2;

            }
            catch
            {
                //MessageBox.Show("Del_t or N missing !!!");
            }
            dataGridViewMusking.Rows.Clear();

            try
            {
                k = 0;
                SFM_n = 0;

                k = dataGridViewMusking.Rows.Add();

                for (i = 0; i <= SFM_Total_Time; i++)
                {
                    //k = dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[k].Cells[0].Value = i;

                    for (j = 0; j <= SFM_n_Section; j++)
                    {
                        dataGridViewMusking.Rows[k].Cells[1].Value = j;
                        k++;
                        SFM_n++;
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
