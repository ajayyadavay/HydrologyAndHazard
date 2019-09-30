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
    public partial class FrmUnsteadyRiverBedVariation : Form
    {
        int i, j, k;
        public static int USFM_n, USFM_n_Section, USFM_Total_t;
        double USFM_Mannings, USFM_Porosity;
        double USFM_Q, USFM_const_q_water;
        double USFM_Initial_h, USFM_Initial_zb, USFM_Initial_So, USFM_initial_qb; 
        double USFM_qs_a, USFM_qs_b;  
        double USFM_Boundary_h, USFM_Boundary_qb, USFM_Boundary_dqb, USFM_Fictitious_qb; 
        double USFM_del_X, USFM_del_t, USFM_L, USFM_B;
        
        double k1, k2, k3, k4, k5, k6, k7, k8, k9, g = 9.81;
        
        double[,] USFM_qs = new double[3000, 3000]; //sediment discharge
        double[,] USFM_Courant = new double[3000, 3000]; 
        public static double[,] USFM_h = new double[3000, 3000]; // water height
        public static double[,] USFM_zb = new double[3000, 3000]; // bed level from datum

        private void TxtDelT_TextChanged(object sender, EventArgs e)
        {

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

        private void BtnProfilePlot_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPlotUnsteadyProfile funsteadyplot = new FrmPlotUnsteadyProfile();
                funsteadyplot.Show();
            }
            catch
            {

            }
        }

        public static double[,] USFM_q_water = new double[5000, 5000]; // water discharge

        private void BtnIdentify_Click(object sender, EventArgs e)
        {
            IdentifyUnstableCourant();
        }

        private void TxtBoudarySedimentq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_h_at_boundary();
            }
            catch
            {

            }
        }

        private void Txtqsb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_h_at_boundary();
                //Find_initial_qs0();
            }
            catch
            {

            }
        }

        private void TxtInitialqs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_h_at_boundary();
            }
            catch
            {

            }
        }

        private void Txtqsa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_h_at_boundary();
                //Find_initial_qs0();
            }
            catch
            {

            }
        }

        public void IdentifyUnstableCourant()
        {
            double courant;
            try
            {
                TxtMsg.Text = "";
                int index = 0;
                bool UnstableFound = false;

                for (j = 0; j <= USFM_Total_t; j++)
                {
                    for (i = 0; i <= USFM_n_Section; i++)
                    {
                        courant = Convert.ToDouble(dataGridViewMusking.Rows[index].Cells[6].Value);

                        if(courant > 1 || courant <=0)
                        {
                            UnstableFound = true;
                            TxtMsg.ForeColor = Color.DarkRed;
                            TxtMsg.Text = TxtMsg.Text + "T-S-CN = " + j + " - " + i + " - " + courant + "\r\n";
                        }
                        
                        index++;
                    }
                }
                if (UnstableFound == false)
                {
                    TxtMsg.ForeColor = Color.Green;
                    TxtMsg.Text = "All Nodes at each time step have Courant number <= 1 and >= 0";
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

                ((Excel.Range)xlWorkSheet.Cells[1, 1]).Value = "UnSteady Flow Model " + DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

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

        private void TxtInitialh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_initial_qs0();
            }
            catch
            {

            }
        }

        // double qb, zb, fx, dq_by_dh, dz_by_dh, df_by_dh, h1, h0, error, myerr;

        double qb_steady;
        double h_i_star, q_i_star, qs_i_star, zb_i_star;
        double h_i_str_str, q_i_str_str, qs_i_str_str, zb_i_str_str;


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                TxtMsg.Text = "";
                CalcUnsteadyFlowRiverBedVar();
            }
            catch
            {

            }
        }


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

        private void Txtq_water_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_h_at_boundary();
                //Find_initial_qs0();
            }
            catch
            {

            }
        }

        private void TxtQ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_q_water();
            }
            catch
            {

            }
        }

        private void Find_q_water()
        {
            USFM_Q = Convert.ToDouble(TxtQ.Text);
            USFM_B = Convert.ToDouble(TxtB.Text);

            Txtq_water.Text = (USFM_Q / USFM_B).ToString();
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Find_q_water();
            }
            catch
            {

            }
        }


        public FrmUnsteadyRiverBedVariation()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUnsteadyRiverBedVariation_Load(object sender, EventArgs e)
        {
            try
            {
                Generaterows();
                SetGridColorAndFont();
                // calculate q_water
                Find_q_water();
                // calculate h at boundary
                Find_h_at_boundary();

                TxtIntervalX.BackColor = System.Drawing.SystemColors.Window;
                TxtBoudaryWaterh.BackColor = System.Drawing.SystemColors.Window;
                TxtSection.BackColor = System.Drawing.SystemColors.Window;
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

        public void Generaterows()
        {
           try
           {
                
                USFM_del_X = Convert.ToDouble(TxtDelX.Text);
                
                USFM_del_t = Convert.ToDouble(TxtDelT.Text);
                USFM_L = Convert.ToDouble(TxtL.Text);

                
                USFM_Total_t = Convert.ToInt32(TxtTotalTime.Text);


                USFM_n_Section = Convert.ToInt32(USFM_L / USFM_del_X);
                TxtIntervalX.Text = USFM_n_Section.ToString();
                TxtSection.Text = (USFM_n_Section).ToString();
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
                USFM_n = 0;

                k = dataGridViewMusking.Rows.Add();
                for (i = 0; i <= USFM_Total_t; i++)
                {
                    //k = dataGridViewMusking.Rows.Add();
                    dataGridViewMusking.Rows[k].Cells[0].Value = i;
                    for (j = 0; j <= USFM_n_Section; j++)
                    {
                        dataGridViewMusking.Rows[k].Cells[1].Value = j;
                        k++;
                        USFM_n++;
                        k = dataGridViewMusking.Rows.Add();
                    }
                }
            }
            catch
            {

            }
        }

        public void Input()
        {
            try
            {
                USFM_Mannings = Convert.ToDouble(TxtManning.Text);
                USFM_Porosity = Convert.ToDouble(TxtPorosity.Text);
                //USFM_WaterDensity = Convert.ToDouble(TxtWaterDensity.Text);
                //USFM_SoilDensity = Convert.ToDouble(TxtSoilDensity.Text);
                //USFM_SoilDiamter = Convert.ToDouble(TxtParticleDiameter.Text);

                USFM_Q = Convert.ToDouble(TxtQ.Text);
                USFM_const_q_water = Convert.ToDouble(Txtq_water.Text);

                USFM_L = Convert.ToDouble(TxtL.Text);
                USFM_B = Convert.ToDouble(TxtB.Text);

                USFM_qs_a = Convert.ToDouble(Txtqsa.Text);
                USFM_qs_b = Convert.ToDouble(Txtqsb.Text);

                USFM_del_X = Convert.ToDouble(TxtDelX.Text);
                USFM_del_t = Convert.ToDouble(TxtDelT.Text);
                USFM_Total_t = Convert.ToInt32(TxtTotalTime.Text);
                //myerr = Convert.ToDouble(TxtError.Text);

                USFM_Initial_h = Convert.ToDouble(TxtInitialh.Text);
                USFM_Initial_zb = Convert.ToDouble(TxtInitialz.Text);
                USFM_Initial_So = Convert.ToDouble(TxtInitialSo.Text);
                USFM_initial_qb = Convert.ToDouble(TxtInitialqs.Text);

                USFM_Boundary_h = Convert.ToDouble(TxtBoudaryWaterh.Text);
                USFM_Boundary_dqb = Convert.ToDouble(TxtBoudarySedimentq.Text);

            }
            catch
            {

            }
        }

        public void AssingInitialAndBoundaryCondititon()
        {
            // Initial Conditions at t = 0 for all sections------------------------------------------------
            // constants
           // k2 = USFM_Mannings * USFM_Mannings * USFM_Q * USFM_Q / (USFM_B * USFM_B);

            // at t = 0, for each section for zb and h and water discharge and sediment discharge
            for (i = 1; i <= USFM_n_Section; i++)
            {
                USFM_zb[0, i] = USFM_Initial_zb - i * USFM_Initial_So * USFM_del_X;
                USFM_h[0, i] = USFM_Initial_h;
                USFM_q_water[0, i] = USFM_const_q_water;
                //USFM_qs[0, i] = USFM_qs_a * Math.Pow(USFM_q_water[0, i] / USFM_h[0, i], USFM_qs_b);
                USFM_qs[0, i] = USFM_initial_qb;
            }


            // Boundary Conditions at node = 0-----------------------------------------------------------------
            //qb_steady = USFM_qs[0, 1];

            USFM_Fictitious_qb = USFM_initial_qb + USFM_Boundary_dqb;
            //USFM_Boundary_qb = USFM_initial_qb + USFM_Boundary_dqb;
            USFM_Boundary_qb = USFM_initial_qb;
            USFM_zb[0, 0] = USFM_Initial_zb;
            for (j = 0; j <= USFM_Total_t; j++)
            {
                USFM_qs[j, 0] = USFM_Boundary_qb;
                USFM_h[j, 0] = USFM_Boundary_h;
                USFM_q_water[j, 0] = USFM_const_q_water;
                if(j>=1)
                {
                    //USFM_zb[j, 0] = USFM_zb[j - 1, 0] - ((USFM_Boundary_qb- USFM_Fictitious_qb) * USFM_del_t) / (USFM_del_X * (1 - USFM_Porosity));
                    USFM_zb[j, 0] = USFM_zb[j - 1, 0] - (-USFM_Boundary_dqb * USFM_del_t) / (USFM_del_X * (1 - USFM_Porosity));
                }
                
            }
        }

        public void Find_initial_qs0() 
        {
            try
            {
                USFM_Initial_h = Convert.ToDouble(TxtInitialh.Text);
                USFM_const_q_water = Convert.ToDouble(Txtq_water.Text);

                USFM_qs_a = Convert.ToDouble(Txtqsa.Text);
                USFM_qs_b = Convert.ToDouble(Txtqsb.Text);

                USFM_initial_qb = USFM_qs_a * Math.Pow((USFM_const_q_water / USFM_Initial_h), USFM_qs_b);

                TxtInitialqs.Text = USFM_initial_qb.ToString();
            }
            catch
            {

            }
        }

        public void Find_h_at_boundary()
        {
            try
            {
                Find_initial_qs0();
                USFM_qs_a = Convert.ToDouble(Txtqsa.Text);
                USFM_qs_b = Convert.ToDouble(Txtqsb.Text);

                USFM_const_q_water = Convert.ToDouble(Txtq_water.Text);
                USFM_initial_qb = Convert.ToDouble(TxtInitialqs.Text);
                
                USFM_Boundary_dqb = Convert.ToDouble(TxtBoudarySedimentq.Text);

                USFM_Boundary_qb = USFM_initial_qb + USFM_Boundary_dqb;

                USFM_Boundary_h = Math.Pow((USFM_qs_a * Math.Pow(USFM_const_q_water, USFM_qs_b) / USFM_Boundary_qb), 1 / USFM_qs_b);

                TxtBoudaryWaterh.Text = USFM_Boundary_h.ToString();
            }
            catch
            {

            }
        }

        public void CalcUnsteadyFlowRiverBedVar()
        {
            Input();
            USFM_n_Section = Convert.ToInt32(USFM_L / USFM_del_X);

            AssingInitialAndBoundaryCondititon();

            //MessageBox.Show("123hik = " + USFM_h[k, i]);
            // predictor
            for (k = 1; k <= USFM_Total_t; k++)
            {
                for (i = 1; i < USFM_n_Section; i++)
                {
                    // Predictor part--------------------------------
                    h_i_star = Find_hi_star(USFM_h[k-1, i], USFM_q_water[k-1, i + 1], USFM_q_water[k-1, i]);
                    q_i_star = Find_qi_star(USFM_q_water[k-1, i+1], USFM_h[k-1, i+1], USFM_q_water[k-1, i], USFM_h[k-1, i],USFM_zb[k-1,i+1], USFM_zb[k-1, i]);
                    qs_i_star = Find_qs_i_star(q_i_star, h_i_star);

                    //USFM_qs[k - 1, i] = USFM_qs_a * Math.Pow(USFM_q_water[k-1, i] / USFM_h[k-1, i], USFM_qs_b);
                    USFM_qs[k - 1, i] = Find_qs_i_star(USFM_q_water[k - 1, i], USFM_h[k - 1, i]);

                    zb_i_star = Find_zb_i_star(USFM_zb[k - 1, i], qs_i_star,h_i_star,q_i_star, USFM_qs[k - 1, i], USFM_h[k - 1, i], USFM_q_water[k - 1, i], USFM_qs[k - 1, i+1], USFM_qs[k - 1, i]);

                    // Corrector Part------------------------------------
                    h_i_str_str = Find_hi_star(h_i_star, q_i_star, USFM_q_water[k, i - 1]);
                    q_i_str_str = Find_qi_star(q_i_star, h_i_star, USFM_q_water[k, i - 1], USFM_h[k, i - 1], zb_i_star, USFM_zb[k, i - 1]);
                    qs_i_str_str = Find_qs_i_star(q_i_str_str, h_i_str_str);

                    zb_i_str_str = Find_zb_i_star(zb_i_star, qs_i_str_str, h_i_str_str, q_i_str_str, qs_i_star, h_i_star, q_i_star, qs_i_star, USFM_qs[k, i-1]);

                    // output
                    /*USFM_h[k, i] = h_i_star;
                    USFM_q_water[k, i] = q_i_star;
                    USFM_qs[k, i] = qs_i_star;
                    USFM_zb[k, i] = zb_i_star;
                    USFM_Courant[k, i] = (USFM_q_water[k, i] / USFM_h[k, i] + Math.Sqrt(9.81 * USFM_h[k, i])) * USFM_del_t / USFM_del_X;
                    */

                    //output------------------------------------------------
                    USFM_h[k, i] = 0.5 * (USFM_h[k - 1, i] + h_i_str_str);
                    USFM_q_water[k, i] = 0.5 * (USFM_q_water[k - 1, i] + q_i_str_str);
                    USFM_zb[k, i] = 0.5 * (USFM_zb[k - 1, i] + zb_i_str_str);
                    USFM_qs[k, i] = 0.5 * (USFM_qs[k - 1, i] + qs_i_str_str);
                    //MessageBox.Show("hik = " + USFM_h[k, i]);
                }

                // For Last Node------------------------------------------------------
                USFM_h[k, USFM_n_Section] = Find_at_last_Node(USFM_h[k, USFM_n_Section-2], USFM_h[k, USFM_n_Section-1]);
                USFM_q_water[k, USFM_n_Section] = Find_at_last_Node(USFM_q_water[k, USFM_n_Section - 2], USFM_q_water[k, USFM_n_Section - 1]);
                USFM_zb[k, USFM_n_Section] = Find_at_last_Node(USFM_zb[k, USFM_n_Section - 2], USFM_zb[k, USFM_n_Section - 1]);
                USFM_qs[k, USFM_n_Section] = Find_at_last_Node(USFM_qs[k, USFM_n_Section - 2], USFM_qs[k, USFM_n_Section - 1]);
            }

                // write data to datagridview----------------------------------------------
                int index = 0;
                for (j = 0; j <= USFM_Total_t; j++)
                {
                    for (i = 0; i <= USFM_n_Section; i++)
                    {
                        dataGridViewMusking.Rows[index].Cells[2].Value = USFM_h[j, i].ToString("0.000000");
                        dataGridViewMusking.Rows[index].Cells[3].Value = USFM_qs[j, i].ToString("0.0000000");
                        dataGridViewMusking.Rows[index].Cells[4].Value =USFM_q_water[j, i].ToString("0.0000000");
                        dataGridViewMusking.Rows[index].Cells[5].Value = USFM_zb[j, i].ToString("0.0000000");

                        USFM_Courant[j, i] = (USFM_q_water[j, i] / USFM_h[j, i] + Math.Sqrt(9.81 * USFM_h[j, i])) * USFM_del_t / USFM_del_X;

                        dataGridViewMusking.Rows[index].Cells[6].Value = USFM_Courant[j, i].ToString("0.00");
                        index++;
                    }
                }
        }

        public double Find_at_last_Node(double y1, double y2)
        {
            double x1, x2, y, x;
            x2 = (USFM_n_Section - 1) * USFM_del_X;
            x1 = (USFM_n_Section - 2) * USFM_del_X;
            x  = (USFM_n_Section - 0) * USFM_del_X;
            y = y1 + (y2 - y1) / (x2 - x1) * (x - x1);

            return y;
        }

        public double Find_hi_star(double h_i_k, double q_ip1_k, double q_i_k)
        {
            double h_i_stars;
            h_i_stars = -USFM_del_t / USFM_del_X * (q_ip1_k - q_i_k) + h_i_k;

            return h_i_stars; 
        }
        //q_i_star = Find_qi_star(USFM_q_water[k-1, i+1], USFM_h[k-1, i+1], USFM_q_water[k-1, i], USFM_h[k-1, i],USFM_zb[k-1,i+1], USFM_zb[k-1, i]);

        public double Find_qi_star(double q_ip1_k, double h_ip1_k, double q_i_k, double h_i_k, double zb_ip1_k, double zb_i_k) 
        {
            double q_i_stars, term1a,term1b, term1, term2, term3;
            /*term1a = USFM_q_water[k - 1, i + 1] * USFM_q_water[k - 1, i + 1] / USFM_h[k - 1, i + 1] + 0.5 * 9.81 * USFM_h[k - 1, i + 1]* USFM_h[k - 1, i + 1];
            term1b = USFM_q_water[k - 1, i] * USFM_q_water[k - 1, i] / USFM_h[k - 1, i] + 0.5 * 9.81 * USFM_h[k - 1, i] * USFM_h[k - 1, i];
            term1 = (term1a - term1b) / USFM_del_X;

            term2 = 9.81 * USFM_h[k - 1, i] * (USFM_zb[k - 1, i + 1] - USFM_zb[k - 1, i]);
            term3 = 9.81 * USFM_h[k - 1, i] * USFM_Mannings * USFM_Mannings * USFM_q_water[k - 1, i] / Math.Pow(USFM_h[k - 1, i], 3.33);
            */
            term1a = q_ip1_k * q_ip1_k / h_ip1_k + 0.5 * 9.81 * h_ip1_k * h_ip1_k;
            term1b = q_i_k * q_i_k / h_i_k + 0.5 * 9.81 * h_i_k * h_i_k;
            term1 = (term1a - term1b) / USFM_del_X;

            term2 = 9.81 * h_i_k * (zb_ip1_k - zb_i_k)/USFM_del_X;
            term3 = 9.81 * h_i_k * USFM_Mannings * USFM_Mannings * q_i_k / Math.Pow(h_i_k, 3.33);

            q_i_stars = (-term1 - term2 - term3) * USFM_del_t + q_i_k;
            return q_i_stars;
        }

        public double Find_qs_i_star(double q_i_star, double h_i_star)
        {
            double qs_i_stars;
            qs_i_stars = USFM_qs_a * Math.Pow(q_i_star / h_i_star, USFM_qs_b);

            return qs_i_stars;
        }
        //Find_zb_i_star(USFM_zb[k - 1, i], qs_i_star,h_i_star,q_i_star, USFM_qs[k - 1, i], USFM_h[k - 1, i], USFM_q_water[k - 1, i], USFM_qs[k - 1, i+1])
        public double Find_zb_i_star(double zb_i_k, double qs_i_star, double h_i_star, double q_i_star, double qs_i_k, double h_i_k, double q_i_k, double qs_ip1_k, double qsik) 
        {
            double zb_i_stars, term1, term2;
            /* term1 = (qs_i_star * h_i_star / q_i_star - USFM_qs[k - 1, i] * USFM_h[k - 1, i] / USFM_q_water[k - 1, i]) / USFM_del_t;
             term2 = (USFM_qs[k - 1, i + 1] - USFM_qs[k - 1, i]) / USFM_del_X;
             */
            term1 = (qs_i_star * h_i_star / q_i_star - qs_i_k * h_i_k / q_i_k) / USFM_del_t;
            term2 = (qs_ip1_k - qsik) / USFM_del_X;

            zb_i_stars = (-term1 - term2) * USFM_del_t / (1 - USFM_Porosity) + zb_i_k;

            return zb_i_stars;
        }
    } 
}
