using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYDROLOGY
{
    public partial class FrmSteadySchematic : Form
    {
        Pen Hdrawpen = new Pen(Color.Red);
        Pen Vdrawpen = new Pen(Color.Green);
        Pen Circledrawpen = new Pen(Color.Blue); 
         
        Graphics g = null;
        static int Node_X, Time_Y;
        static int Start_steady_X, Start_Steady_Y;
        static int End_steady_X, End_Steady_Y;

        int X_Pos, Y_Pos;
        int i, Step_X, Step_Y, Y_Length,ix,iy;

        private void TxtNodeX_TextChanged(object sender, EventArgs e)
        {
            PanelCanvas.Refresh();
        }

        private void TxtX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int indexX = int.Parse(TxtX.Text);
                int indexY = int.Parse(TxtY.Text);

                string qb_Data = (FrmSteadyFlowModel.SFM_qb[indexY, indexX]).ToString("E4");
                string zb_Data = (FrmSteadyFlowModel.SFM_zb[indexY, indexX]).ToString("0.0000");
                string h_Data = (FrmSteadyFlowModel.SFM_h[indexY, indexX]).ToString("0.0000");

                string Data = h_Data + " , " + zb_Data + " , " + qb_Data;
                LblData.Text = Data;
            }
            catch
            {

            }
        }

        private void TxtY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int indexX = int.Parse(TxtX.Text);
                int indexY = int.Parse(TxtY.Text);

                string qb_Data = (FrmSteadyFlowModel.SFM_qb[indexY, indexX]).ToString("E4");
                string zb_Data = (FrmSteadyFlowModel.SFM_zb[indexY, indexX]).ToString("0.0000");
                string h_Data = (FrmSteadyFlowModel.SFM_h[indexY, indexX]).ToString("0.0000");

                string Data = h_Data + " , " + zb_Data + " , " + qb_Data;
                LblData.Text = Data;
            }
            catch
            {

            }
        }

        private void PanelCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            TxtX.Text = X_Pos.ToString();
            //TxtY.Text = (Y_Pos - 1).ToString();
            TxtY.Text = (Y_Pos).ToString();

            //string str = TxtX.Text + " , " + (Y_Pos - 1).ToString();
            string str = TxtX.Text + " , " + (Y_Pos).ToString();

            ix = X_Pos; // Node
            //iy = Y_Pos - 1; // Time
            iy = Y_Pos; // Time
            string qb_Data = (FrmSteadyFlowModel.SFM_qb[iy, ix]).ToString("E4");
            string zb_Data = (FrmSteadyFlowModel.SFM_zb[iy, ix]).ToString("0.0000");
            string h_Data = (FrmSteadyFlowModel.SFM_h[iy, ix]).ToString("0.0000");

            string Data = h_Data + " , " + zb_Data + " , " + qb_Data;
            ToolTipSeeData.SetToolTip(PanelCanvas, Data);
            LblData.Text = Data;
        }

        private void PanelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Node_X = int.Parse(TxtNodeX.Text);
                Time_Y = int.Parse(TxtTimeY.Text);

                Step_X = (PanelCanvas.Width - 15 * 2) / (Node_X + 1);//node_x + 1

                Step_Y = (PanelCanvas.Height - 10 * 2) / (Time_Y + 1); // time_y + 1

                X_Pos = Cursor.Position.X / Step_X;

                //Y_Pos = Cursor.Position.Y / Step_Y;
                Y_Pos = (Cursor.Position.Y - 81)/Step_Y;

                LblX.Text = "X: " + (X_Pos).ToString();
                //LblY.Text = "Y: " + (Y_Pos - 1).ToString();
                LblY.Text = "Y: " + (Y_Pos).ToString();


            }
            catch
            {

            }
            
        }

        private void TxtTimeY_TextChanged(object sender, EventArgs e)
        {
            PanelCanvas.Refresh();
        }

        private void FrmSteadySchematic_Resize(object sender, EventArgs e)
        {
            PanelCanvas.Refresh();
        }

        public FrmSteadySchematic()
        {
            InitializeComponent();
            Start_steady_X = PanelCanvas.Width /10;
            Start_Steady_Y = PanelCanvas.Height /10;
        }
      
            private void FrmSteadySchematic_Load(object sender, EventArgs e)
        {
            FrmSteadySchematic fstdschem = new FrmSteadySchematic();
            //PanelCanvas.Width = fstdschem.Bounds.Width;
            fstdschem.WindowState = FormWindowState.Maximized;
            

            TxtNodeX.Text = (FrmSteadyFlowModel.SFM_n_Section).ToString();
            TxtTimeY.Text = (FrmSteadyFlowModel.SFM_Total_Time).ToString();
        }

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Hdrawpen.Width = 1;
                Vdrawpen.Width = 1;
                // g = PanelCanvas.CreateGraphics();
                g = e.Graphics;
                //g.PageUnit = GraphicsUnit.Millimeter;

                TxtNodeX.Text = (FrmSteadyFlowModel.SFM_n_Section).ToString();
                TxtTimeY.Text = (FrmSteadyFlowModel.SFM_Total_Time).ToString();

                Node_X = int.Parse(TxtNodeX.Text);
                Time_Y = int.Parse(TxtTimeY.Text);

                // Draw Vertical lines
                int X_index = 0;
                Step_X = (PanelCanvas.Width - 15 * 2) / (Node_X + 1);
                for (i = 15; i <= (Node_X + 1) * Step_X; i = i + Step_X)
                {
                    Start_steady_X = i;
                    Start_Steady_Y = 10;
                    End_steady_X = i;
                    End_Steady_Y = PanelCanvas.Height - 10*2;
                    g.DrawLine(Vdrawpen, Start_steady_X, Start_Steady_Y, End_steady_X, End_Steady_Y);

                    g.DrawString(X_index.ToString(), new Font("Verdana", Step_X / 4), new SolidBrush(Color.Black), End_steady_X - 5, End_Steady_Y);
                    X_index++;
                }

                Y_Length = PanelCanvas.Height - 10*2;

                // Draw Horizontal lines
                int Y_index = 0;

                Step_Y = (Y_Length) / (Time_Y + 1);
                for (i = 10; i <= (Time_Y + 1) * Step_Y; i = i + Step_Y)
                {
                    Start_steady_X = 15;
                    Start_Steady_Y = i;
                    End_steady_X = PanelCanvas.Width - 15 * 2;
                    End_Steady_Y = i;
                    g.DrawLine(Hdrawpen, Start_steady_X, Start_Steady_Y, End_steady_X, End_Steady_Y);

                    g.DrawString(Y_index.ToString(), new Font("Verdana", Step_Y / 4), new SolidBrush(Color.Black), End_steady_X - 20, End_Steady_Y);
                    Y_index++;
                }
                
                
            }
            catch
            {

            }
           
            
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
