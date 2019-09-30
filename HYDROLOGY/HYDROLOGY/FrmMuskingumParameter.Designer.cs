namespace HYDROLOGY
{
    partial class FrmMuskingumParameter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChartMusking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.TxtStartTime = new System.Windows.Forms.TextBox();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.LblN = new System.Windows.Forms.Label();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.ComboBoxK = new System.Windows.Forms.ComboBox();
            this.TxtK = new System.Windows.Forms.TextBox();
            this.LblK = new System.Windows.Forms.Label();
            this.ComboBoxInterval = new System.Windows.Forms.ComboBox();
            this.LblInterval = new System.Windows.Forms.Label();
            this.TxtInterval = new System.Windows.Forms.TextBox();
            this.GroupBoxCalibrate = new System.Windows.Forms.GroupBox();
            this.GroupBoxCoeff = new System.Windows.Forms.GroupBox();
            this.TxtC0 = new System.Windows.Forms.TextBox();
            this.LblC0 = new System.Windows.Forms.Label();
            this.TxtC1 = new System.Windows.Forms.TextBox();
            this.LblC1 = new System.Windows.Forms.Label();
            this.TxtC2 = new System.Windows.Forms.TextBox();
            this.LblC2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RUNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.IMPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedGridOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyFromGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToGidCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutFromGridCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveOneSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearValueOfSelectedCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveAllGridsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOutflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWeightedFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSlope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstOutflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.GroupBoxInput.SuspendLayout();
            this.GroupBoxCalibrate.SuspendLayout();
            this.GroupBoxCoeff.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartMusking
            // 
            this.ChartMusking.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartMusking.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.ChartMusking.ChartAreas.Add(chartArea5);
            legend5.BorderColor = System.Drawing.Color.Blue;
            legend5.Name = "Legend1";
            this.ChartMusking.Legends.Add(legend5);
            this.ChartMusking.Location = new System.Drawing.Point(737, 191);
            this.ChartMusking.Name = "ChartMusking";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Graph";
            this.ChartMusking.Series.Add(series5);
            this.ChartMusking.Size = new System.Drawing.Size(601, 467);
            this.ChartMusking.TabIndex = 20;
            this.ChartMusking.Text = "chart1";
            title13.BackColor = System.Drawing.Color.White;
            title13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title13.ForeColor = System.Drawing.Color.DarkViolet;
            title13.Name = "Graph_title";
            title13.Text = "Storage Vs [XI + (1-X)O]";
            title14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title14.ForeColor = System.Drawing.Color.Blue;
            title14.Name = "X_axis_label";
            title14.Position.Auto = false;
            title14.Position.Width = 94F;
            title14.Position.Y = 97F;
            title14.Text = "[XI + (1-X)O]";
            title15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title15.ForeColor = System.Drawing.Color.Blue;
            title15.Name = "Y_axis_label";
            title15.Position.Auto = false;
            title15.Position.Height = 50F;
            title15.Position.X = 4F;
            title15.Position.Y = 30F;
            title15.Text = "Storage";
            title15.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.ChartMusking.Titles.Add(title13);
            this.ChartMusking.Titles.Add(title14);
            this.ChartMusking.Titles.Add(title15);
            // 
            // dataGridViewMusking
            // 
            this.dataGridViewMusking.AllowUserToResizeColumns = false;
            this.dataGridViewMusking.AllowUserToResizeRows = false;
            this.dataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.ColInflow,
            this.ColOutflow,
            this.ColStorage,
            this.ColWeightedFlow,
            this.ColSlope,
            this.ColEstOutflow});
            this.dataGridViewMusking.Location = new System.Drawing.Point(12, 191);
            this.dataGridViewMusking.Name = "dataGridViewMusking";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMusking.RowHeadersVisible = false;
            this.dataGridViewMusking.Size = new System.Drawing.Size(719, 467);
            this.dataGridViewMusking.TabIndex = 21;
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.LblStartTime);
            this.GroupBoxInput.Controls.Add(this.TxtStartTime);
            this.GroupBoxInput.Controls.Add(this.TxtN);
            this.GroupBoxInput.Controls.Add(this.LblN);
            this.GroupBoxInput.Controls.Add(this.ComboBoxInterval);
            this.GroupBoxInput.Controls.Add(this.LblInterval);
            this.GroupBoxInput.Controls.Add(this.TxtInterval);
            this.GroupBoxInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxInput.ForeColor = System.Drawing.Color.Blue;
            this.GroupBoxInput.Location = new System.Drawing.Point(12, 76);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(481, 100);
            this.GroupBoxInput.TabIndex = 22;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "INPUT MUSKINGUM PARAMETERS";
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblStartTime.Location = new System.Drawing.Point(349, 25);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(108, 26);
            this.LblStartTime.TabIndex = 18;
            this.LblStartTime.Text = "Start Time";
            // 
            // TxtStartTime
            // 
            this.TxtStartTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartTime.Location = new System.Drawing.Point(374, 54);
            this.TxtStartTime.Name = "TxtStartTime";
            this.TxtStartTime.Size = new System.Drawing.Size(55, 30);
            this.TxtStartTime.TabIndex = 17;
            this.TxtStartTime.TextChanged += new System.EventHandler(this.TxtStartTime_TextChanged);
            // 
            // TxtN
            // 
            this.TxtN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtN.Location = new System.Drawing.Point(234, 55);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(55, 30);
            this.TxtN.TabIndex = 16;
            this.TxtN.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            // 
            // LblN
            // 
            this.LblN.AutoSize = true;
            this.LblN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblN.Location = new System.Drawing.Point(208, 25);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(115, 26);
            this.LblN.TabIndex = 15;
            this.LblN.Text = "No. of Data";
            // 
            // TxtX
            // 
            this.TxtX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(217, 55);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(55, 30);
            this.TxtX.TabIndex = 14;
            this.TxtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblX.Location = new System.Drawing.Point(235, 26);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(26, 26);
            this.LblX.TabIndex = 13;
            this.LblX.Text = "X";
            // 
            // ComboBoxK
            // 
            this.ComboBoxK.BackColor = System.Drawing.Color.White;
            this.ComboBoxK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxK.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxK.FormattingEnabled = true;
            this.ComboBoxK.Location = new System.Drawing.Point(98, 54);
            this.ComboBoxK.Name = "ComboBoxK";
            this.ComboBoxK.Size = new System.Drawing.Size(81, 31);
            this.ComboBoxK.TabIndex = 12;
            // 
            // TxtK
            // 
            this.TxtK.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtK.Location = new System.Drawing.Point(32, 54);
            this.TxtK.Name = "TxtK";
            this.TxtK.Size = new System.Drawing.Size(55, 30);
            this.TxtK.TabIndex = 11;
            this.TxtK.TextChanged += new System.EventHandler(this.TxtK_TextChanged);
            // 
            // LblK
            // 
            this.LblK.AutoSize = true;
            this.LblK.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblK.Location = new System.Drawing.Point(85, 25);
            this.LblK.Name = "LblK";
            this.LblK.Size = new System.Drawing.Size(24, 26);
            this.LblK.TabIndex = 10;
            this.LblK.Text = "K";
            // 
            // ComboBoxInterval
            // 
            this.ComboBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxInterval.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxInterval.FormattingEnabled = true;
            this.ComboBoxInterval.Location = new System.Drawing.Point(80, 54);
            this.ComboBoxInterval.Name = "ComboBoxInterval";
            this.ComboBoxInterval.Size = new System.Drawing.Size(83, 31);
            this.ComboBoxInterval.TabIndex = 9;
            this.ComboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInterval_SelectedIndexChanged);
            // 
            // LblInterval
            // 
            this.LblInterval.AutoSize = true;
            this.LblInterval.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblInterval.Location = new System.Drawing.Point(25, 25);
            this.LblInterval.Name = "LblInterval";
            this.LblInterval.Size = new System.Drawing.Size(125, 26);
            this.LblInterval.TabIndex = 8;
            this.LblInterval.Text = "Time interval";
            // 
            // TxtInterval
            // 
            this.TxtInterval.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInterval.Location = new System.Drawing.Point(19, 54);
            this.TxtInterval.Name = "TxtInterval";
            this.TxtInterval.Size = new System.Drawing.Size(55, 30);
            this.TxtInterval.TabIndex = 0;
            this.TxtInterval.TextChanged += new System.EventHandler(this.TxtInterval_TextChanged);
            // 
            // GroupBoxCalibrate
            // 
            this.GroupBoxCalibrate.Controls.Add(this.LblK);
            this.GroupBoxCalibrate.Controls.Add(this.ComboBoxK);
            this.GroupBoxCalibrate.Controls.Add(this.LblX);
            this.GroupBoxCalibrate.Controls.Add(this.TxtK);
            this.GroupBoxCalibrate.Controls.Add(this.TxtX);
            this.GroupBoxCalibrate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCalibrate.ForeColor = System.Drawing.Color.Blue;
            this.GroupBoxCalibrate.Location = new System.Drawing.Point(508, 76);
            this.GroupBoxCalibrate.Name = "GroupBoxCalibrate";
            this.GroupBoxCalibrate.Size = new System.Drawing.Size(305, 100);
            this.GroupBoxCalibrate.TabIndex = 23;
            this.GroupBoxCalibrate.TabStop = false;
            this.GroupBoxCalibrate.Text = "CALIBRATION PARAMETER";
            // 
            // GroupBoxCoeff
            // 
            this.GroupBoxCoeff.Controls.Add(this.TxtC0);
            this.GroupBoxCoeff.Controls.Add(this.LblC0);
            this.GroupBoxCoeff.Controls.Add(this.TxtC1);
            this.GroupBoxCoeff.Controls.Add(this.LblC1);
            this.GroupBoxCoeff.Controls.Add(this.TxtC2);
            this.GroupBoxCoeff.Controls.Add(this.LblC2);
            this.GroupBoxCoeff.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCoeff.ForeColor = System.Drawing.Color.Blue;
            this.GroupBoxCoeff.Location = new System.Drawing.Point(828, 76);
            this.GroupBoxCoeff.Name = "GroupBoxCoeff";
            this.GroupBoxCoeff.Size = new System.Drawing.Size(270, 100);
            this.GroupBoxCoeff.TabIndex = 24;
            this.GroupBoxCoeff.TabStop = false;
            this.GroupBoxCoeff.Text = "ROUTING COEFFICIENTS";
            // 
            // TxtC0
            // 
            this.TxtC0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtC0.Location = new System.Drawing.Point(22, 61);
            this.TxtC0.Name = "TxtC0";
            this.TxtC0.Size = new System.Drawing.Size(55, 30);
            this.TxtC0.TabIndex = 16;
            // 
            // LblC0
            // 
            this.LblC0.AutoSize = true;
            this.LblC0.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblC0.Location = new System.Drawing.Point(32, 32);
            this.LblC0.Name = "LblC0";
            this.LblC0.Size = new System.Drawing.Size(35, 26);
            this.LblC0.TabIndex = 15;
            this.LblC0.Text = "C0";
            // 
            // TxtC1
            // 
            this.TxtC1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtC1.Location = new System.Drawing.Point(100, 61);
            this.TxtC1.Name = "TxtC1";
            this.TxtC1.Size = new System.Drawing.Size(55, 30);
            this.TxtC1.TabIndex = 14;
            // 
            // LblC1
            // 
            this.LblC1.AutoSize = true;
            this.LblC1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblC1.Location = new System.Drawing.Point(107, 32);
            this.LblC1.Name = "LblC1";
            this.LblC1.Size = new System.Drawing.Size(32, 26);
            this.LblC1.TabIndex = 13;
            this.LblC1.Text = "C1";
            // 
            // TxtC2
            // 
            this.TxtC2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtC2.Location = new System.Drawing.Point(174, 61);
            this.TxtC2.Name = "TxtC2";
            this.TxtC2.Size = new System.Drawing.Size(55, 30);
            this.TxtC2.TabIndex = 11;
            // 
            // LblC2
            // 
            this.LblC2.AutoSize = true;
            this.LblC2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblC2.Location = new System.Drawing.Point(183, 32);
            this.LblC2.Name = "LblC2";
            this.LblC2.Size = new System.Drawing.Size(35, 26);
            this.LblC2.TabIndex = 10;
            this.LblC2.Text = "C2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RUNToolStripMenuItem,
            this.toolStripMenuItem2,
            this.IMPORTToolStripMenuItem,
            this.EXPORTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.CopyFromGridToolStripMenuItem,
            this.PasteToGidCellsToolStripMenuItem,
            this.CutFromGridCellsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.SaveGraphToolStripMenuItem,
            this.toolStripMenuItem5,
            this.EXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 204);
            // 
            // RUNToolStripMenuItem
            // 
            this.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem";
            this.RUNToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.RUNToolStripMenuItem.Text = "Simulate";
            this.RUNToolStripMenuItem.Click += new System.EventHandler(this.RUNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // IMPORTToolStripMenuItem
            // 
            this.IMPORTToolStripMenuItem.Name = "IMPORTToolStripMenuItem";
            this.IMPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.IMPORTToolStripMenuItem.Text = "Import From Excel";
            this.IMPORTToolStripMenuItem.Click += new System.EventHandler(this.IMPORTToolStripMenuItem_Click);
            // 
            // EXPORTToolStripMenuItem
            // 
            this.EXPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllGridToolStripMenuItem,
            this.SelectedGridOnlyToolStripMenuItem});
            this.EXPORTToolStripMenuItem.Name = "EXPORTToolStripMenuItem";
            this.EXPORTToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXPORTToolStripMenuItem.Text = "Export To Excel";
            // 
            // AllGridToolStripMenuItem
            // 
            this.AllGridToolStripMenuItem.Name = "AllGridToolStripMenuItem";
            this.AllGridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AllGridToolStripMenuItem.Text = "All Cells";
            this.AllGridToolStripMenuItem.Click += new System.EventHandler(this.AllGridToolStripMenuItem_Click);
            // 
            // SelectedGridOnlyToolStripMenuItem
            // 
            this.SelectedGridOnlyToolStripMenuItem.Name = "SelectedGridOnlyToolStripMenuItem";
            this.SelectedGridOnlyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SelectedGridOnlyToolStripMenuItem.Text = "Selected Cells Only";
            this.SelectedGridOnlyToolStripMenuItem.Click += new System.EventHandler(this.SelectedGridOnlyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // CopyFromGridToolStripMenuItem
            // 
            this.CopyFromGridToolStripMenuItem.Name = "CopyFromGridToolStripMenuItem";
            this.CopyFromGridToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CopyFromGridToolStripMenuItem.Text = "Copy From Grid Cells";
            this.CopyFromGridToolStripMenuItem.Click += new System.EventHandler(this.CopyFromGridToolStripMenuItem_Click);
            // 
            // PasteToGidCellsToolStripMenuItem
            // 
            this.PasteToGidCellsToolStripMenuItem.Name = "PasteToGidCellsToolStripMenuItem";
            this.PasteToGidCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.PasteToGidCellsToolStripMenuItem.Text = "Paste To Gid Cells";
            this.PasteToGidCellsToolStripMenuItem.Click += new System.EventHandler(this.PasteToGidCellsToolStripMenuItem_Click);
            // 
            // CutFromGridCellsToolStripMenuItem
            // 
            this.CutFromGridCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveOneSelectedRowToolStripMenuItem,
            this.ClearValueOfSelectedCellsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.RemoveAllGridsToolStripMenuItem});
            this.CutFromGridCellsToolStripMenuItem.Name = "CutFromGridCellsToolStripMenuItem";
            this.CutFromGridCellsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.CutFromGridCellsToolStripMenuItem.Text = "Clear";
            // 
            // RemoveOneSelectedRowToolStripMenuItem
            // 
            this.RemoveOneSelectedRowToolStripMenuItem.Name = "RemoveOneSelectedRowToolStripMenuItem";
            this.RemoveOneSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveOneSelectedRowToolStripMenuItem.Text = "Remove One Selected Row";
            this.RemoveOneSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.RemoveOneSelectedRowToolStripMenuItem_Click);
            // 
            // ClearValueOfSelectedCellsToolStripMenuItem
            // 
            this.ClearValueOfSelectedCellsToolStripMenuItem.Name = "ClearValueOfSelectedCellsToolStripMenuItem";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ClearValueOfSelectedCellsToolStripMenuItem.Text = "Clear Value Of Selected Cells";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Click += new System.EventHandler(this.ClearValueOfSelectedCellsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 6);
            // 
            // RemoveAllGridsToolStripMenuItem
            // 
            this.RemoveAllGridsToolStripMenuItem.Name = "RemoveAllGridsToolStripMenuItem";
            this.RemoveAllGridsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveAllGridsToolStripMenuItem.Text = "Remove All Grids";
            this.RemoveAllGridsToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllGridsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // SaveGraphToolStripMenuItem
            // 
            this.SaveGraphToolStripMenuItem.Name = "SaveGraphToolStripMenuItem";
            this.SaveGraphToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.SaveGraphToolStripMenuItem.Text = "Save Graph";
            this.SaveGraphToolStripMenuItem.Click += new System.EventHandler(this.SaveGraphToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 6);
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInflow
            // 
            this.ColInflow.HeaderText = "Inflow";
            this.ColInflow.Name = "ColInflow";
            this.ColInflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColOutflow
            // 
            this.ColOutflow.HeaderText = "Outflow";
            this.ColOutflow.Name = "ColOutflow";
            this.ColOutflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStorage
            // 
            this.ColStorage.HeaderText = "Storage";
            this.ColStorage.Name = "ColStorage";
            this.ColStorage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColWeightedFlow
            // 
            this.ColWeightedFlow.HeaderText = "[XI+(1-X)O]";
            this.ColWeightedFlow.Name = "ColWeightedFlow";
            this.ColWeightedFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSlope
            // 
            this.ColSlope.HeaderText = "Slope (K)";
            this.ColSlope.Name = "ColSlope";
            this.ColSlope.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEstOutflow
            // 
            this.ColEstOutflow.HeaderText = "Estimated Outflow";
            this.ColEstOutflow.Name = "ColEstOutflow";
            this.ColEstOutflow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lbltitle
            // 
            this.Lbltitle.AutoSize = true;
            this.Lbltitle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitle.ForeColor = System.Drawing.Color.Red;
            this.Lbltitle.Location = new System.Drawing.Point(327, 20);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(420, 33);
            this.Lbltitle.TabIndex = 26;
            this.Lbltitle.Text = "Calibration of X and K of Muskingum";
            // 
            // FrmMuskingumParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1347, 718);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Lbltitle);
            this.Controls.Add(this.GroupBoxCoeff);
            this.Controls.Add(this.GroupBoxCalibrate);
            this.Controls.Add(this.GroupBoxInput);
            this.Controls.Add(this.dataGridViewMusking);
            this.Controls.Add(this.ChartMusking);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmMuskingumParameter";
            this.Text = "Muskingum Parameter Calibration";
            this.Load += new System.EventHandler(this.FrmMuskingumParameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            this.GroupBoxCalibrate.ResumeLayout(false);
            this.GroupBoxCalibrate.PerformLayout();
            this.GroupBoxCoeff.ResumeLayout(false);
            this.GroupBoxCoeff.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMusking;
        private System.Windows.Forms.DataGridView dataGridViewMusking;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.TextBox TxtStartTime;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Label LblN;
        private System.Windows.Forms.ComboBox ComboBoxInterval;
        private System.Windows.Forms.Label LblInterval;
        private System.Windows.Forms.TextBox TxtInterval;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.ComboBox ComboBoxK;
        private System.Windows.Forms.TextBox TxtK;
        private System.Windows.Forms.Label LblK;
        private System.Windows.Forms.GroupBox GroupBoxCalibrate;
        private System.Windows.Forms.GroupBox GroupBoxCoeff;
        private System.Windows.Forms.TextBox TxtC0;
        private System.Windows.Forms.Label LblC0;
        private System.Windows.Forms.TextBox TxtC1;
        private System.Windows.Forms.Label LblC1;
        private System.Windows.Forms.TextBox TxtC2;
        private System.Windows.Forms.Label LblC2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RUNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem IMPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectedGridOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyFromGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToGidCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutFromGridCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveOneSelectedRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearValueOfSelectedCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllGridsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem SaveGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInflow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOutflow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWeightedFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSlope;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstOutflow;
        private System.Windows.Forms.Label Lbltitle;
    }
}