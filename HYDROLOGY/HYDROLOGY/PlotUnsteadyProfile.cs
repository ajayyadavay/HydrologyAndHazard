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
    public partial class FrmPlotUnsteadyProfile : Form
    {
        int i, n, j;
        int numberOfZoom = 0;
        int TimeInterval;

        public FrmPlotUnsteadyProfile()
        {
            InitializeComponent();

            ChartMusking.MouseWheel += ChartMusking_MouseWheel;
        }

        private void PlotUnsteadyProfile_Load(object sender, EventArgs e)
        {
            try
            {
                LblTimeplot.Text = " T (Max:" + FrmUnsteadyRiverBedVariation.USFM_Total_t + ") = ";
                //MessageBox.Show(" " + FrmUnsteadyRiverBedVariation.USFM_h[0,3]);
                TimerAnimateSteady.Enabled = false;
                n = FrmUnsteadyRiverBedVariation.USFM_n_Section;
                UnsteadyProfilePlot(0,0);
            }
            catch
            {

            }
        }

        private void TxtTotalTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //TimerAnimateSteady.Enabled = false;
                int timeValue = Convert.ToInt32(TxtTotalTime.Text);
                n = FrmUnsteadyRiverBedVariation.USFM_n_Section;
                UnsteadyProfilePlot(timeValue, timeValue);
            }
            catch
            {

            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int timeValue = Convert.ToInt32(TxtTotalTime.Text);
            if (timeValue < FrmUnsteadyRiverBedVariation.USFM_Total_t)
            {
                TxtTotalTime.Text = (timeValue + 1).ToString();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            int timeValue;

            timeValue = Convert.ToInt32(TxtTotalTime.Text);
            if (timeValue > 0)
            {
                TxtTotalTime.Text = (timeValue - 1).ToString();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveGraph_Click(object sender, EventArgs e)
        {
            try
            {
                string ImagePath = Environment.CurrentDirectory + "\\RiverBedVariationUnSteadyFlow" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";

                ChartMusking.SaveImage(ImagePath, ChartImageFormat.Png);

                MessageBox.Show("RiverBedVariationUnSteadyFlow Saved to: \n" + ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnStopAnimation_Click(object sender, EventArgs e)
        {
            BtnStopAnimation.ForeColor = Color.Orange;
            TimerAnimateSteady.Enabled = false;
            BtnNext.Enabled = true;
            BtnPrevious.Enabled = true;
            BtnSaveGraph.Enabled = true;
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

        private void TimerAnimateSteady_Tick(object sender, EventArgs e)
        {
            int timeValue;
            timeValue = Convert.ToInt32(TxtTotalTime.Text);

            if (timeValue < FrmUnsteadyRiverBedVariation.USFM_Total_t)
            {
                TxtTotalTime.Text = (timeValue + 1).ToString();
            }
        }

        public void UnsteadyProfilePlot(int time1, int time2)
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
                //for (j = 0; j <= FrmUnsteadyRiverBedVariation.USFM_Total_t; j++)
                for (j = time1; j <= time2; j++)
                {
                    //MessageBox.Show("Here" + j);
                    //Color myColor = Color.FromArgb(20 + j * 20, 50 + j * 200, 75);
                    if (j > 0)
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

                    for (i = 0; i <= n; i++)
                    {
                        //MessageBox.Show("Herebedlevel" + FrmUnsteadyRiverBedVariation.USFM_zb[0, i]);
                        ChartMusking.Series["BedLevel0"].Points.AddXY(i, FrmUnsteadyRiverBedVariation.USFM_zb[0, i]);
                        if (j > 0)
                        {
                            ChartMusking.Series["BedLevel" + j].Points.AddXY(i, FrmUnsteadyRiverBedVariation.USFM_zb[j, i]);
                        }
                        
                    }
                }

                // Water Level
                // for (j = 0; j <= FrmUnsteadyRiverBedVariation.USFM_Total_t; j++)
                for (j = time1; j <= time2; j++)
                {
                    //Color myColor = Color.FromArgb(50 + j * 10, 100, 150);
                    if (j > 0)
                    {
                        ChartMusking.Series.Add("WaterSurface" + j);
                        ChartMusking.Series["WaterSurface" + j].ChartType = SeriesChartType.Line;
                        ChartMusking.Series["WaterSurface" + j].BorderWidth = 2;
                    }
                    ChartMusking.Series.Add("WaterSurface0");
                    //ChartMusking.Series["WaterSurface" + j].Color = myColor;
                    ChartMusking.Series["WaterSurface0"].ChartType = SeriesChartType.Line;

                    ChartMusking.Series["WaterSurface0"].BorderWidth = 2;

                    if (j % 2 != 0)
                    {
                        ChartMusking.Series["WaterSurface" + j].BorderDashStyle = ChartDashStyle.Dash;
                    }


                    for (i = 0; i <= n; i++)
                    {
                        ChartMusking.Series["WaterSurface0"].Points.AddXY(i, FrmUnsteadyRiverBedVariation.USFM_h[0, i] + FrmUnsteadyRiverBedVariation.USFM_zb[0, i]);
                        if(j > 0)
                        {
                           ChartMusking.Series["WaterSurface" + j].Points.AddXY(i, FrmUnsteadyRiverBedVariation.USFM_h[j, i] + FrmUnsteadyRiverBedVariation.USFM_zb[j, i]);

                        }
                    }
                }

            }
            catch
            {

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
    }
}
