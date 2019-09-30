namespace HYDROLOGY
{
    partial class FrmPlotUnsteadyProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartMusking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnSaveGraph = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnStopAnimation = new System.Windows.Forms.Button();
            this.BtnAnimate = new System.Windows.Forms.Button();
            this.LblTimeplot = new System.Windows.Forms.Label();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.TxtTotalTime = new System.Windows.Forms.TextBox();
            this.TimerAnimateSteady = new System.Windows.Forms.Timer(this.components);
            this.TxtTimeInterval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartMusking
            // 
            this.ChartMusking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartMusking.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartMusking.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent90;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.ChartMusking.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BorderColor = System.Drawing.Color.Green;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.ChartMusking.Legends.Add(legend1);
            this.ChartMusking.Location = new System.Drawing.Point(12, 62);
            this.ChartMusking.Name = "ChartMusking";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Graph";
            this.ChartMusking.Series.Add(series1);
            this.ChartMusking.Size = new System.Drawing.Size(1161, 443);
            this.ChartMusking.TabIndex = 21;
            this.ChartMusking.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Green;
            title1.Name = "Graph_title";
            title1.Text = "Unsteady Profile Plot";
            title2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.DodgerBlue;
            title2.Name = "X_axis_label";
            title2.Position.Auto = false;
            title2.Position.Width = 94F;
            title2.Position.Y = 97F;
            title2.Text = "Section of river";
            title3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.DodgerBlue;
            title3.Name = "Y_axis_label";
            title3.Position.Auto = false;
            title3.Position.Height = 50F;
            title3.Position.X = 4F;
            title3.Position.Y = 30F;
            title3.Text = "Elevation";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.ChartMusking.Titles.Add(title1);
            this.ChartMusking.Titles.Add(title2);
            this.ChartMusking.Titles.Add(title3);
            // 
            // BtnSaveGraph
            // 
            this.BtnSaveGraph.BackColor = System.Drawing.Color.White;
            this.BtnSaveGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveGraph.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnSaveGraph.Location = new System.Drawing.Point(397, 19);
            this.BtnSaveGraph.Name = "BtnSaveGraph";
            this.BtnSaveGraph.Size = new System.Drawing.Size(116, 37);
            this.BtnSaveGraph.TabIndex = 66;
            this.BtnSaveGraph.Text = "Save Graph";
            this.BtnSaveGraph.UseVisualStyleBackColor = false;
            this.BtnSaveGraph.Click += new System.EventHandler(this.BtnSaveGraph_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnExit.Location = new System.Drawing.Point(519, 19);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 37);
            this.BtnExit.TabIndex = 65;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnStopAnimation
            // 
            this.BtnStopAnimation.BackColor = System.Drawing.Color.White;
            this.BtnStopAnimation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStopAnimation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStopAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnStopAnimation.Location = new System.Drawing.Point(245, 19);
            this.BtnStopAnimation.Name = "BtnStopAnimation";
            this.BtnStopAnimation.Size = new System.Drawing.Size(146, 37);
            this.BtnStopAnimation.TabIndex = 64;
            this.BtnStopAnimation.Text = "Stop Animation";
            this.BtnStopAnimation.UseVisualStyleBackColor = false;
            this.BtnStopAnimation.Click += new System.EventHandler(this.BtnStopAnimation_Click);
            // 
            // BtnAnimate
            // 
            this.BtnAnimate.BackColor = System.Drawing.Color.White;
            this.BtnAnimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAnimate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAnimate.Location = new System.Drawing.Point(12, 19);
            this.BtnAnimate.Name = "BtnAnimate";
            this.BtnAnimate.Size = new System.Drawing.Size(153, 37);
            this.BtnAnimate.TabIndex = 63;
            this.BtnAnimate.Text = "Start Animation";
            this.BtnAnimate.UseVisualStyleBackColor = false;
            this.BtnAnimate.Click += new System.EventHandler(this.BtnAnimate_Click);
            // 
            // LblTimeplot
            // 
            this.LblTimeplot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTimeplot.AutoSize = true;
            this.LblTimeplot.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeplot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblTimeplot.Location = new System.Drawing.Point(886, 24);
            this.LblTimeplot.Name = "LblTimeplot";
            this.LblTimeplot.Size = new System.Drawing.Size(99, 26);
            this.LblTimeplot.TabIndex = 62;
            this.LblTimeplot.Text = "T(MAX:)=";
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevious.BackColor = System.Drawing.Color.White;
            this.BtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrevious.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPrevious.Location = new System.Drawing.Point(674, 19);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(100, 37);
            this.BtnPrevious.TabIndex = 61;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.BackColor = System.Drawing.Color.White;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnNext.Location = new System.Drawing.Point(780, 19);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(100, 37);
            this.BtnNext.TabIndex = 60;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // TxtTotalTime
            // 
            this.TxtTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalTime.Location = new System.Drawing.Point(1060, 23);
            this.TxtTotalTime.Name = "TxtTotalTime";
            this.TxtTotalTime.Size = new System.Drawing.Size(113, 30);
            this.TxtTotalTime.TabIndex = 59;
            this.TxtTotalTime.Text = "0";
            this.TxtTotalTime.TextChanged += new System.EventHandler(this.TxtTotalTime_TextChanged);
            // 
            // TimerAnimateSteady
            // 
            this.TimerAnimateSteady.Interval = 400;
            this.TimerAnimateSteady.Tick += new System.EventHandler(this.TimerAnimateSteady_Tick);
            // 
            // TxtTimeInterval
            // 
            this.TxtTimeInterval.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimeInterval.Location = new System.Drawing.Point(171, 23);
            this.TxtTimeInterval.Name = "TxtTimeInterval";
            this.TxtTimeInterval.Size = new System.Drawing.Size(70, 30);
            this.TxtTimeInterval.TabIndex = 67;
            this.TxtTimeInterval.Text = "10";
            // 
            // FrmPlotUnsteadyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 517);
            this.Controls.Add(this.TxtTimeInterval);
            this.Controls.Add(this.BtnSaveGraph);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnStopAnimation);
            this.Controls.Add(this.BtnAnimate);
            this.Controls.Add(this.LblTimeplot);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.TxtTotalTime);
            this.Controls.Add(this.ChartMusking);
            this.Name = "FrmPlotUnsteadyProfile";
            this.Text = "PlotUnsteadyProfile";
            this.Load += new System.EventHandler(this.PlotUnsteadyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMusking;
        private System.Windows.Forms.Button BtnSaveGraph;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnStopAnimation;
        private System.Windows.Forms.Button BtnAnimate;
        private System.Windows.Forms.Label LblTimeplot;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox TxtTotalTime;
        private System.Windows.Forms.Timer TimerAnimateSteady;
        private System.Windows.Forms.TextBox TxtTimeInterval;
    }
}