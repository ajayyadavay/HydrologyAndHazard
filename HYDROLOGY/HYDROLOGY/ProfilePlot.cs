using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace HYDROLOGY
{
    public partial class FrmProfilePlot : Form
    {
        int i, n,j;
        int TimeInterval;
        int numberOfZoom = 0;
        public FrmProfilePlot()
        {
            InitializeComponent();

            ChartMusking.MouseWheel += ChartMusking_MouseWheel;
        }

        private void ChartMusking_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmProfilePlot_Load(object sender, EventArgs e)
        {
            try
            {
                LblTimeplot.Text = " T (Max:" + FrmSteadyFlowModel.SFM_Total_Time + ") = ";
                TimerAnimateSteady.Enabled = false;
                n = FrmSteadyFlowModel.SFM_n_Section;
                PlotProfile(0,0);
            }
            catch
            {

            }
        }

        private void ChartMusking_Click(object sender, EventArgs e)
        {

        }

        private void TxtTotalTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //TimerAnimateSteady.Enabled = false;
                int timeValue =Convert.ToInt32(TxtTotalTime.Text);
                n = FrmSteadyFlowModel.SFM_n_Section;
                PlotProfile(timeValue,timeValue);
            }
            catch
            {

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int timeValue = Convert.ToInt32(TxtTotalTime.Text);
            if(timeValue < FrmSteadyFlowModel.SFM_Total_Time)
            {
                TxtTotalTime.Text = (timeValue + 1).ToString();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            int timeValue;
            
            timeValue = Convert.ToInt32(TxtTotalTime.Text);
            if(timeValue > 0)
            {
                TxtTotalTime.Text = (timeValue - 1).ToString();
            }
        }

        private void TimerAnimateSteady_Tick(object sender, EventArgs e)
        {
            //PlotProfile(0, FrmSteadyFlowModel.SFM_Total_Time);
            //BtnNext_Click(new object(), new EventArgs());
            int timeValue;
            
            timeValue = Convert.ToInt32(TxtTotalTime.Text);
            
            if (timeValue < FrmSteadyFlowModel.SFM_Total_Time)
            {
                TxtTotalTime.Text = (timeValue + 1).ToString();
            }
        }

        private void BtnAnimate_Click(object sender, EventArgs e)
        {
            TimeInterval = Convert.ToInt32(TxtTimeInterval.Text);
            TimerAnimateSteady.Enabled = true;
            TimerAnimateSteady.Interval = TimeInterval;
            BtnNext.Enabled = false;
            BtnPrevious.Enabled = false;
            BtnSaveGraph.Enabled = false;
            BtnStopAnimation.ForeColor = Color.Green;
        }

        private void BtnStopAnimation_Click(object sender, EventArgs e)
        {
            BtnStopAnimation.ForeColor = Color.DodgerBlue;
            TimerAnimateSteady.Enabled = false;
            BtnNext.Enabled = true;
            BtnPrevious.Enabled = true;
            BtnSaveGraph.Enabled = true;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveGraph_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\RiverBedVariationSteadyFlow" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartMusking.SaveImage(ImagePath, ChartImageFormat.Png);

                MessageBox.Show("RiverBedVariationSteadyFlow Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChartMusking_MouseWheel(object sender, MouseEventArgs e)
        {
            //ChartMusking.MouseWheel += ChartMusking_MouseWheel;
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            ChartMusking.ChartAreas[0].AxisX.LabelStyle.Format = "#.##";
            ChartMusking.ChartAreas[0].AxisY.LabelStyle.Format = "#.##";

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            var yMin = yAxis.ScaleView.ViewMinimum;
            var yMax = yAxis.ScaleView.ViewMaximum;

            int IntervalX = 2;
            int IntervalY = 2;
            try
            {
                if (e.Delta < 0 && numberOfZoom > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY * 2 / Math.Pow(2, numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY * 2 / Math.Pow(2, numberOfZoom);

                    if (posXStart < 0) posXStart = 0;
                    if (posYStart < 0) posYStart = 0;
                    if (posYFinish > yAxis.Maximum) posYFinish = yAxis.Maximum;
                    if (posXFinish > xAxis.Maximum) posYFinish = xAxis.Maximum;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    numberOfZoom--;
                }
                else if (e.Delta < 0 && numberOfZoom == 0) //Last scrolled dowm
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY / Math.Pow(2, numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, numberOfZoom);
                    
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    numberOfZoom++;
                }

                if (numberOfZoom < 0) numberOfZoom = 0;
            }
            catch { }

        }

        public void PlotProfile(int time1, int time2)
        {
            try
            {
                ChartMusking.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                ChartMusking.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                ChartMusking.ChartAreas[0].AxisX.LabelStyle.Format = "#.##";
                ChartMusking.ChartAreas[0].AxisY.LabelStyle.Format = "#.##";

                //ChartMusking.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                //ChartMusking.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;

                ChartMusking.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                ChartMusking.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

                ChartMusking.ChartAreas[0].CursorX.AutoScroll = true;
                ChartMusking.ChartAreas[0].CursorY.AutoScroll = true;

                ChartMusking.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                ChartMusking.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;

                ChartMusking.Series.Clear();

                // BedLevel
                for (j = time1; j <= time2; j++)
                {
                    //Color myColor = Color.FromArgb(20 + j * 20, 50 + j * 200, 75);
                    if(j > 0)
                    {
                        ChartMusking.Series.Add("BedLevel" + j);
                        ChartMusking.Series["BedLevel" + j].ChartType = SeriesChartType.Line;
                        ChartMusking.Series["BedLevel" + j].BorderWidth = 2;
                    }

                    ChartMusking.Series.Add("BedLevel0");

                    //ChartMusking.Series["BedLevel" + j].Color = myColor;
                    ChartMusking.Series["BedLevel0"].ChartType = SeriesChartType.Line;

                    ChartMusking.Series["BedLevel0"].BorderWidth = 2;

                    if (j % 2 != 0)
                    {
                        ChartMusking.Series["BedLevel" + j].BorderDashStyle = ChartDashStyle.DashDotDot;
                    }

                    for (i=0;i<=n;i++)
                    {
                        ChartMusking.Series["BedLevel0"].Points.AddXY(i, FrmSteadyFlowModel.SFM_zb[0, i]);

                        if(j > 0)
                        {
                            ChartMusking.Series["BedLevel" + j].Points.AddXY(i, FrmSteadyFlowModel.SFM_zb[j, i]);
                        }
                    
                    }

                }

                // Water Level
                for (j = time1; j <= time2; j++)
                {
                   // Color myColor = Color.FromArgb(50 + j * 10, 100, 150);
                   if(j > 0)
                    {
                        ChartMusking.Series.Add("WaterSurface" + j);
                        ChartMusking.Series["WaterSurface" + j].ChartType = SeriesChartType.Line;
                        ChartMusking.Series["WaterSurface" + j].BorderWidth = 2;
                    }
                    ChartMusking.Series.Add("WaterSurface0");
                    //ChartMusking.Series["WaterSurface" + j].Color = myColor;
                    ChartMusking.Series["WaterSurface0"].ChartType = SeriesChartType.Line;

                    ChartMusking.Series["WaterSurface0"].BorderWidth = 2;

                    if (j%2 !=0)
                    {
                        ChartMusking.Series["WaterSurface" + j].BorderDashStyle = ChartDashStyle.Dash;
                    }
                    
                    for (i = 0; i <= n; i++)
                    {
                        ChartMusking.Series["WaterSurface0"].Points.AddXY(i, FrmSteadyFlowModel.SFM_h[0, i] + FrmSteadyFlowModel.SFM_zb[0, i]);
                        if(j > 0)
                        {
                            ChartMusking.Series["WaterSurface" + j].Points.AddXY(i, FrmSteadyFlowModel.SFM_h[j, i] + FrmSteadyFlowModel.SFM_zb[j, i]);

                        }
                    }
                }




                /*ChartMusking.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                ChartMusking.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                
                ChartMusking.ChartAreas[0].CursorX.AutoScroll = true;
                ChartMusking.ChartAreas[0].CursorY.AutoScroll = true;

                ChartMusking.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                ChartMusking.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;*/
            }
            catch
            {

            }
        }
    }
}
