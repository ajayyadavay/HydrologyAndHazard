namespace HYDROLOGY
{
    partial class FrmCrawford
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMoistureRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStorageRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPPT_PET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAET_PET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWaterBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExcessMoistureRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExcessMoisture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeltaStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndGW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGWF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDirectFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObsFlow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObsFlow_mm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RUNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.optimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.SWAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CRAWFORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartMusking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxParameter = new System.Windows.Forms.GroupBox();
            this.LblOpt = new System.Windows.Forms.Label();
            this.TxtOpt_Nominal = new System.Windows.Forms.TextBox();
            this.LblNominal = new System.Windows.Forms.Label();
            this.TxtNominal = new System.Windows.Forms.TextBox();
            this.TxtInitialGW_OPT = new System.Windows.Forms.TextBox();
            this.TxtEFF_OPT = new System.Windows.Forms.TextBox();
            this.TxtGWF_OPT = new System.Windows.Forms.TextBox();
            this.TxtPSUB_OPT = new System.Windows.Forms.TextBox();
            this.TxtOPT_IMS = new System.Windows.Forms.TextBox();
            this.TxtInitialGW = new System.Windows.Forms.TextBox();
            this.LblInitialGW = new System.Windows.Forms.Label();
            this.TxtEFF = new System.Windows.Forms.TextBox();
            this.LblEFF = new System.Windows.Forms.Label();
            this.TxtGWF = new System.Windows.Forms.TextBox();
            this.LblGWF = new System.Windows.Forms.Label();
            this.TxtPSUB = new System.Windows.Forms.TextBox();
            this.LblPSUB = new System.Windows.Forms.Label();
            this.LblIMS = new System.Windows.Forms.Label();
            this.TxtIMS = new System.Windows.Forms.TextBox();
            this.TxtYearNo = new System.Windows.Forms.TextBox();
            this.LblYearNo = new System.Windows.Forms.Label();
            this.LblStartYear = new System.Windows.Forms.Label();
            this.TxtStartYear = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageIMS = new System.Windows.Forms.TabPage();
            this.LbltabIMS = new System.Windows.Forms.Label();
            this.LblStepIMS = new System.Windows.Forms.Label();
            this.TxtStepIMS = new System.Windows.Forms.TextBox();
            this.LblIMSMin = new System.Windows.Forms.Label();
            this.TxtMinIMS = new System.Windows.Forms.TextBox();
            this.LblMaxIMS = new System.Windows.Forms.Label();
            this.TxtMaxIMS = new System.Windows.Forms.TextBox();
            this.TabPageNominal = new System.Windows.Forms.TabPage();
            this.LblTabNominal = new System.Windows.Forms.Label();
            this.LblStepNominal = new System.Windows.Forms.Label();
            this.TxtStepNominal = new System.Windows.Forms.TextBox();
            this.LblMinNominal = new System.Windows.Forms.Label();
            this.TxtMinNominal = new System.Windows.Forms.TextBox();
            this.LblMaxNominal = new System.Windows.Forms.Label();
            this.TxtMaxNominal = new System.Windows.Forms.TextBox();
            this.TabPagePSUB = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblsteppsub = new System.Windows.Forms.Label();
            this.TxtStepPSUB = new System.Windows.Forms.TextBox();
            this.LblminPSUB = new System.Windows.Forms.Label();
            this.TxtMinPSUB = new System.Windows.Forms.TextBox();
            this.LblMaxPSUB = new System.Windows.Forms.Label();
            this.TxtMaxPSUB = new System.Windows.Forms.TextBox();
            this.TabPageGWF = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.LblStepGWF = new System.Windows.Forms.Label();
            this.TxtStepGWF = new System.Windows.Forms.TextBox();
            this.LblMinGWF = new System.Windows.Forms.Label();
            this.TxtMinGWF = new System.Windows.Forms.TextBox();
            this.LblMaxGWF = new System.Windows.Forms.Label();
            this.TxtMaxGWF = new System.Windows.Forms.TextBox();
            this.TabPageIGW = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.LblStepIGW = new System.Windows.Forms.Label();
            this.TxtStepIGW = new System.Windows.Forms.TextBox();
            this.LblMinIGW = new System.Windows.Forms.Label();
            this.TxtMinIGW = new System.Windows.Forms.TextBox();
            this.LblMaxIGW = new System.Windows.Forms.Label();
            this.TxtMaxIGW = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).BeginInit();
            this.GroupBoxParameter.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageIMS.SuspendLayout();
            this.TabPageNominal.SuspendLayout();
            this.TabPagePSUB.SuspendLayout();
            this.TabPageGWF.SuspendLayout();
            this.TabPageIGW.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMusking
            // 
            this.dataGridViewMusking.AllowUserToResizeColumns = false;
            this.dataGridViewMusking.AllowUserToResizeRows = false;
            this.dataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColMonth,
            this.ColPPT,
            this.ColPET,
            this.ColMoistureRatio,
            this.ColStorageRatio,
            this.ColPPT_PET,
            this.ColAET_PET,
            this.ColAET,
            this.ColWaterBalance,
            this.ColExcessMoistureRatio,
            this.ColExcessMoisture,
            this.ColDeltaStorage,
            this.ColBGW,
            this.ColEndGW,
            this.ColGWF,
            this.ColDirectFlow,
            this.ColTotalFlow,
            this.ColObsFlow,
            this.ColDays,
            this.ColObsFlow_mm});
            this.dataGridViewMusking.Location = new System.Drawing.Point(308, 355);
            this.dataGridViewMusking.Name = "dataGridViewMusking";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMusking.RowHeadersVisible = false;
            this.dataGridViewMusking.Size = new System.Drawing.Size(1021, 330);
            this.dataGridViewMusking.TabIndex = 7;
            // 
            // ColYear
            // 
            this.ColYear.HeaderText = "Year";
            this.ColYear.Name = "ColYear";
            this.ColYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColMonth
            // 
            this.ColMonth.HeaderText = "Month";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPPT
            // 
            this.ColPPT.HeaderText = "PPt";
            this.ColPPT.Name = "ColPPT";
            this.ColPPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPET
            // 
            this.ColPET.HeaderText = "PET";
            this.ColPET.Name = "ColPET";
            this.ColPET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColMoistureRatio
            // 
            this.ColMoistureRatio.HeaderText = "Moisture Ratio";
            this.ColMoistureRatio.Name = "ColMoistureRatio";
            this.ColMoistureRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColStorageRatio
            // 
            this.ColStorageRatio.HeaderText = "Storage Ratio";
            this.ColStorageRatio.Name = "ColStorageRatio";
            this.ColStorageRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPPT_PET
            // 
            this.ColPPT_PET.HeaderText = "PPT/PET";
            this.ColPPT_PET.Name = "ColPPT_PET";
            this.ColPPT_PET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAET_PET
            // 
            this.ColAET_PET.HeaderText = "AET/PET";
            this.ColAET_PET.Name = "ColAET_PET";
            this.ColAET_PET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAET
            // 
            this.ColAET.HeaderText = "AET";
            this.ColAET.Name = "ColAET";
            this.ColAET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColWaterBalance
            // 
            this.ColWaterBalance.HeaderText = "Water Balance";
            this.ColWaterBalance.Name = "ColWaterBalance";
            this.ColWaterBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColExcessMoistureRatio
            // 
            this.ColExcessMoistureRatio.HeaderText = "Excess Moisture Ratio";
            this.ColExcessMoistureRatio.Name = "ColExcessMoistureRatio";
            this.ColExcessMoistureRatio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColExcessMoisture
            // 
            this.ColExcessMoisture.HeaderText = "Excess Moisture";
            this.ColExcessMoisture.Name = "ColExcessMoisture";
            this.ColExcessMoisture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDeltaStorage
            // 
            this.ColDeltaStorage.HeaderText = "DeltaStorage";
            this.ColDeltaStorage.Name = "ColDeltaStorage";
            this.ColDeltaStorage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ColBGW
            // 
            this.ColBGW.HeaderText = "Beginning GW";
            this.ColBGW.Name = "ColBGW";
            this.ColBGW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEndGW
            // 
            this.ColEndGW.HeaderText = "End GW";
            this.ColEndGW.Name = "ColEndGW";
            this.ColEndGW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColGWF
            // 
            this.ColGWF.HeaderText = "GWF";
            this.ColGWF.Name = "ColGWF";
            this.ColGWF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDirectFlow
            // 
            this.ColDirectFlow.HeaderText = "Direct Flow";
            this.ColDirectFlow.Name = "ColDirectFlow";
            this.ColDirectFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTotalFlow
            // 
            this.ColTotalFlow.HeaderText = "Total Flow";
            this.ColTotalFlow.Name = "ColTotalFlow";
            this.ColTotalFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColObsFlow
            // 
            this.ColObsFlow.HeaderText = "Observed Flow m3/s";
            this.ColObsFlow.Name = "ColObsFlow";
            this.ColObsFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDays
            // 
            this.ColDays.HeaderText = "Days";
            this.ColDays.Name = "ColDays";
            this.ColDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColObsFlow_mm
            // 
            this.ColObsFlow_mm.HeaderText = "Observed Flow";
            this.ColObsFlow_mm.Name = "ColObsFlow_mm";
            this.ColObsFlow_mm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RUNToolStripMenuItem,
            this.toolStripMenuItem7,
            this.optimizeToolStripMenuItem,
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
            this.SWAPToolStripMenuItem,
            this.CRAWFORDToolStripMenuItem,
            this.toolStripMenuItem6,
            this.EXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 282);
            // 
            // RUNToolStripMenuItem
            // 
            this.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem";
            this.RUNToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.RUNToolStripMenuItem.Text = "Simulate";
            this.RUNToolStripMenuItem.Click += new System.EventHandler(this.RUNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(222, 6);
            // 
            // optimizeToolStripMenuItem
            // 
            this.optimizeToolStripMenuItem.Name = "optimizeToolStripMenuItem";
            this.optimizeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.optimizeToolStripMenuItem.Text = "Optimize";
            this.optimizeToolStripMenuItem.Click += new System.EventHandler(this.optimizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(222, 6);
            // 
            // IMPORTToolStripMenuItem
            // 
            this.IMPORTToolStripMenuItem.Name = "IMPORTToolStripMenuItem";
            this.IMPORTToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.IMPORTToolStripMenuItem.Text = "Import From Excel";
            this.IMPORTToolStripMenuItem.Click += new System.EventHandler(this.IMPORTToolStripMenuItem_Click_1);
            // 
            // EXPORTToolStripMenuItem
            // 
            this.EXPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllGridToolStripMenuItem,
            this.SelectedGridOnlyToolStripMenuItem});
            this.EXPORTToolStripMenuItem.Name = "EXPORTToolStripMenuItem";
            this.EXPORTToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.EXPORTToolStripMenuItem.Text = "Export To Excel";
            // 
            // AllGridToolStripMenuItem
            // 
            this.AllGridToolStripMenuItem.Name = "AllGridToolStripMenuItem";
            this.AllGridToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.AllGridToolStripMenuItem.Text = "All Cells";
            this.AllGridToolStripMenuItem.Click += new System.EventHandler(this.AllGridToolStripMenuItem_Click_1);
            // 
            // SelectedGridOnlyToolStripMenuItem
            // 
            this.SelectedGridOnlyToolStripMenuItem.Name = "SelectedGridOnlyToolStripMenuItem";
            this.SelectedGridOnlyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SelectedGridOnlyToolStripMenuItem.Text = "Selected Cells Only";
            this.SelectedGridOnlyToolStripMenuItem.Click += new System.EventHandler(this.SelectedGridOnlyToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // CopyFromGridToolStripMenuItem
            // 
            this.CopyFromGridToolStripMenuItem.Name = "CopyFromGridToolStripMenuItem";
            this.CopyFromGridToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CopyFromGridToolStripMenuItem.Text = "Copy From Grid Cells";
            this.CopyFromGridToolStripMenuItem.Click += new System.EventHandler(this.CopyFromGridToolStripMenuItem_Click_1);
            // 
            // PasteToGidCellsToolStripMenuItem
            // 
            this.PasteToGidCellsToolStripMenuItem.Name = "PasteToGidCellsToolStripMenuItem";
            this.PasteToGidCellsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.PasteToGidCellsToolStripMenuItem.Text = "Paste To Gid Cells";
            this.PasteToGidCellsToolStripMenuItem.Click += new System.EventHandler(this.PasteToGidCellsToolStripMenuItem_Click_1);
            // 
            // CutFromGridCellsToolStripMenuItem
            // 
            this.CutFromGridCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveOneSelectedRowToolStripMenuItem,
            this.ClearValueOfSelectedCellsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.RemoveAllGridsToolStripMenuItem});
            this.CutFromGridCellsToolStripMenuItem.Name = "CutFromGridCellsToolStripMenuItem";
            this.CutFromGridCellsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CutFromGridCellsToolStripMenuItem.Text = "Clear";
            // 
            // RemoveOneSelectedRowToolStripMenuItem
            // 
            this.RemoveOneSelectedRowToolStripMenuItem.Name = "RemoveOneSelectedRowToolStripMenuItem";
            this.RemoveOneSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.RemoveOneSelectedRowToolStripMenuItem.Text = "Remove One Selected Row";
            this.RemoveOneSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.RemoveOneSelectedRowToolStripMenuItem_Click_1);
            // 
            // ClearValueOfSelectedCellsToolStripMenuItem
            // 
            this.ClearValueOfSelectedCellsToolStripMenuItem.Name = "ClearValueOfSelectedCellsToolStripMenuItem";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.ClearValueOfSelectedCellsToolStripMenuItem.Text = "Clear Value Of Selected Cells";
            this.ClearValueOfSelectedCellsToolStripMenuItem.Click += new System.EventHandler(this.ClearValueOfSelectedCellsToolStripMenuItem_Click_1);
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
            this.RemoveAllGridsToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllGridsToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(222, 6);
            // 
            // SaveGraphToolStripMenuItem
            // 
            this.SaveGraphToolStripMenuItem.Name = "SaveGraphToolStripMenuItem";
            this.SaveGraphToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SaveGraphToolStripMenuItem.Text = "Save Graph";
            this.SaveGraphToolStripMenuItem.Click += new System.EventHandler(this.SaveGraphToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // SWAPToolStripMenuItem
            // 
            this.SWAPToolStripMenuItem.Name = "SWAPToolStripMenuItem";
            this.SWAPToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.SWAPToolStripMenuItem.Text = "Use Optimum Parameters";
            this.SWAPToolStripMenuItem.Click += new System.EventHandler(this.SWAPToolStripMenuItem_Click);
            // 
            // CRAWFORDToolStripMenuItem
            // 
            this.CRAWFORDToolStripMenuItem.Name = "CRAWFORDToolStripMenuItem";
            this.CRAWFORDToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.CRAWFORDToolStripMenuItem.Text = "Crawford";
            this.CRAWFORDToolStripMenuItem.Click += new System.EventHandler(this.CRAWFORDToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(222, 6);
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.EXITToolStripMenuItem.Text = "Exit";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click_1);
            // 
            // ChartMusking
            // 
            this.ChartMusking.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartMusking.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.ChartMusking.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Blue;
            legend1.Name = "Legend1";
            this.ChartMusking.Legends.Add(legend1);
            this.ChartMusking.Location = new System.Drawing.Point(308, 13);
            this.ChartMusking.Name = "ChartMusking";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Graph";
            this.ChartMusking.Series.Add(series1);
            this.ChartMusking.Size = new System.Drawing.Size(1021, 325);
            this.ChartMusking.TabIndex = 19;
            this.ChartMusking.Text = "chart1";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.DarkViolet;
            title1.Name = "Graph_title";
            title1.Text = "HYDROGRAPH";
            title2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "X_axis_label";
            title2.Position.Auto = false;
            title2.Position.Width = 94F;
            title2.Position.Y = 97F;
            title2.Text = "time";
            title3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Y_axis_label";
            title3.Position.Auto = false;
            title3.Position.Height = 50F;
            title3.Position.X = 4F;
            title3.Position.Y = 30F;
            title3.Text = "Discharge_mm";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.ChartMusking.Titles.Add(title1);
            this.ChartMusking.Titles.Add(title2);
            this.ChartMusking.Titles.Add(title3);
            // 
            // GroupBoxParameter
            // 
            this.GroupBoxParameter.Controls.Add(this.LblOpt);
            this.GroupBoxParameter.Controls.Add(this.TxtOpt_Nominal);
            this.GroupBoxParameter.Controls.Add(this.LblNominal);
            this.GroupBoxParameter.Controls.Add(this.TxtNominal);
            this.GroupBoxParameter.Controls.Add(this.TxtInitialGW_OPT);
            this.GroupBoxParameter.Controls.Add(this.TxtEFF_OPT);
            this.GroupBoxParameter.Controls.Add(this.TxtGWF_OPT);
            this.GroupBoxParameter.Controls.Add(this.TxtPSUB_OPT);
            this.GroupBoxParameter.Controls.Add(this.TxtOPT_IMS);
            this.GroupBoxParameter.Controls.Add(this.TxtInitialGW);
            this.GroupBoxParameter.Controls.Add(this.LblInitialGW);
            this.GroupBoxParameter.Controls.Add(this.TxtEFF);
            this.GroupBoxParameter.Controls.Add(this.LblEFF);
            this.GroupBoxParameter.Controls.Add(this.TxtGWF);
            this.GroupBoxParameter.Controls.Add(this.LblGWF);
            this.GroupBoxParameter.Controls.Add(this.TxtPSUB);
            this.GroupBoxParameter.Controls.Add(this.LblPSUB);
            this.GroupBoxParameter.Controls.Add(this.LblIMS);
            this.GroupBoxParameter.Controls.Add(this.TxtIMS);
            this.GroupBoxParameter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxParameter.ForeColor = System.Drawing.Color.Blue;
            this.GroupBoxParameter.Location = new System.Drawing.Point(28, 13);
            this.GroupBoxParameter.Name = "GroupBoxParameter";
            this.GroupBoxParameter.Size = new System.Drawing.Size(255, 243);
            this.GroupBoxParameter.TabIndex = 20;
            this.GroupBoxParameter.TabStop = false;
            this.GroupBoxParameter.Text = "PARAMETERS";
            // 
            // LblOpt
            // 
            this.LblOpt.AutoSize = true;
            this.LblOpt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblOpt.Location = new System.Drawing.Point(164, 22);
            this.LblOpt.Name = "LblOpt";
            this.LblOpt.Size = new System.Drawing.Size(80, 20);
            this.LblOpt.TabIndex = 27;
            this.LblOpt.Text = "Optimized";
            // 
            // TxtOpt_Nominal
            // 
            this.TxtOpt_Nominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOpt_Nominal.Location = new System.Drawing.Point(164, 77);
            this.TxtOpt_Nominal.Name = "TxtOpt_Nominal";
            this.TxtOpt_Nominal.Size = new System.Drawing.Size(75, 26);
            this.TxtOpt_Nominal.TabIndex = 26;
            // 
            // LblNominal
            // 
            this.LblNominal.AutoSize = true;
            this.LblNominal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblNominal.Location = new System.Drawing.Point(1, 78);
            this.LblNominal.Name = "LblNominal";
            this.LblNominal.Size = new System.Drawing.Size(64, 20);
            this.LblNominal.TabIndex = 25;
            this.LblNominal.Text = "Nominal";
            // 
            // TxtNominal
            // 
            this.TxtNominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNominal.Location = new System.Drawing.Point(72, 77);
            this.TxtNominal.Name = "TxtNominal";
            this.TxtNominal.Size = new System.Drawing.Size(73, 26);
            this.TxtNominal.TabIndex = 24;
            this.TxtNominal.TextChanged += new System.EventHandler(this.TxtNominal_TextChanged);
            // 
            // TxtInitialGW_OPT
            // 
            this.TxtInitialGW_OPT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialGW_OPT.Location = new System.Drawing.Point(164, 205);
            this.TxtInitialGW_OPT.Name = "TxtInitialGW_OPT";
            this.TxtInitialGW_OPT.Size = new System.Drawing.Size(75, 26);
            this.TxtInitialGW_OPT.TabIndex = 23;
            // 
            // TxtEFF_OPT
            // 
            this.TxtEFF_OPT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEFF_OPT.Location = new System.Drawing.Point(164, 173);
            this.TxtEFF_OPT.Name = "TxtEFF_OPT";
            this.TxtEFF_OPT.Size = new System.Drawing.Size(75, 26);
            this.TxtEFF_OPT.TabIndex = 22;
            this.TxtEFF_OPT.Text = "50";
            // 
            // TxtGWF_OPT
            // 
            this.TxtGWF_OPT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGWF_OPT.Location = new System.Drawing.Point(164, 141);
            this.TxtGWF_OPT.Name = "TxtGWF_OPT";
            this.TxtGWF_OPT.Size = new System.Drawing.Size(75, 26);
            this.TxtGWF_OPT.TabIndex = 21;
            // 
            // TxtPSUB_OPT
            // 
            this.TxtPSUB_OPT.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPSUB_OPT.Location = new System.Drawing.Point(164, 109);
            this.TxtPSUB_OPT.Name = "TxtPSUB_OPT";
            this.TxtPSUB_OPT.Size = new System.Drawing.Size(75, 26);
            this.TxtPSUB_OPT.TabIndex = 20;
            // 
            // TxtOPT_IMS
            // 
            this.TxtOPT_IMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOPT_IMS.Location = new System.Drawing.Point(164, 45);
            this.TxtOPT_IMS.Name = "TxtOPT_IMS";
            this.TxtOPT_IMS.Size = new System.Drawing.Size(75, 26);
            this.TxtOPT_IMS.TabIndex = 19;
            // 
            // TxtInitialGW
            // 
            this.TxtInitialGW.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialGW.Location = new System.Drawing.Point(72, 205);
            this.TxtInitialGW.Name = "TxtInitialGW";
            this.TxtInitialGW.Size = new System.Drawing.Size(73, 26);
            this.TxtInitialGW.TabIndex = 18;
            this.TxtInitialGW.TextChanged += new System.EventHandler(this.TxtInitialGW_TextChanged);
            // 
            // LblInitialGW
            // 
            this.LblInitialGW.AutoSize = true;
            this.LblInitialGW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInitialGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblInitialGW.Location = new System.Drawing.Point(6, 211);
            this.LblInitialGW.Name = "LblInitialGW";
            this.LblInitialGW.Size = new System.Drawing.Size(46, 20);
            this.LblInitialGW.TabIndex = 17;
            this.LblInitialGW.Text = "I GW";
            // 
            // TxtEFF
            // 
            this.TxtEFF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEFF.Location = new System.Drawing.Point(72, 173);
            this.TxtEFF.Name = "TxtEFF";
            this.TxtEFF.Size = new System.Drawing.Size(73, 26);
            this.TxtEFF.TabIndex = 16;
            // 
            // LblEFF
            // 
            this.LblEFF.AutoSize = true;
            this.LblEFF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblEFF.Location = new System.Drawing.Point(14, 179);
            this.LblEFF.Name = "LblEFF";
            this.LblEFF.Size = new System.Drawing.Size(37, 20);
            this.LblEFF.TabIndex = 15;
            this.LblEFF.Text = "Eff.";
            // 
            // TxtGWF
            // 
            this.TxtGWF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGWF.Location = new System.Drawing.Point(72, 141);
            this.TxtGWF.Name = "TxtGWF";
            this.TxtGWF.Size = new System.Drawing.Size(73, 26);
            this.TxtGWF.TabIndex = 14;
            this.TxtGWF.TextChanged += new System.EventHandler(this.TxtGWF_TextChanged);
            // 
            // LblGWF
            // 
            this.LblGWF.AutoSize = true;
            this.LblGWF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGWF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblGWF.Location = new System.Drawing.Point(9, 147);
            this.LblGWF.Name = "LblGWF";
            this.LblGWF.Size = new System.Drawing.Size(43, 20);
            this.LblGWF.TabIndex = 13;
            this.LblGWF.Text = "GWF";
            // 
            // TxtPSUB
            // 
            this.TxtPSUB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPSUB.Location = new System.Drawing.Point(72, 109);
            this.TxtPSUB.Name = "TxtPSUB";
            this.TxtPSUB.Size = new System.Drawing.Size(73, 26);
            this.TxtPSUB.TabIndex = 11;
            this.TxtPSUB.TextChanged += new System.EventHandler(this.TxtPSUB_TextChanged);
            // 
            // LblPSUB
            // 
            this.LblPSUB.AutoSize = true;
            this.LblPSUB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPSUB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblPSUB.Location = new System.Drawing.Point(4, 115);
            this.LblPSUB.Name = "LblPSUB";
            this.LblPSUB.Size = new System.Drawing.Size(47, 20);
            this.LblPSUB.TabIndex = 10;
            this.LblPSUB.Text = "PSUB";
            // 
            // LblIMS
            // 
            this.LblIMS.AutoSize = true;
            this.LblIMS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblIMS.Location = new System.Drawing.Point(9, 49);
            this.LblIMS.Name = "LblIMS";
            this.LblIMS.Size = new System.Drawing.Size(40, 20);
            this.LblIMS.TabIndex = 8;
            this.LblIMS.Text = "IMS";
            // 
            // TxtIMS
            // 
            this.TxtIMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIMS.Location = new System.Drawing.Point(72, 45);
            this.TxtIMS.Name = "TxtIMS";
            this.TxtIMS.Size = new System.Drawing.Size(73, 26);
            this.TxtIMS.TabIndex = 0;
            this.TxtIMS.TextChanged += new System.EventHandler(this.TxtIMS_TextChanged);
            // 
            // TxtYearNo
            // 
            this.TxtYearNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearNo.Location = new System.Drawing.Point(100, 261);
            this.TxtYearNo.Name = "TxtYearNo";
            this.TxtYearNo.Size = new System.Drawing.Size(167, 26);
            this.TxtYearNo.TabIndex = 28;
            this.TxtYearNo.TextChanged += new System.EventHandler(this.TxtYearNo_TextChanged);
            // 
            // LblYearNo
            // 
            this.LblYearNo.AutoSize = true;
            this.LblYearNo.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblYearNo.Location = new System.Drawing.Point(29, 263);
            this.LblYearNo.Name = "LblYearNo";
            this.LblYearNo.Size = new System.Drawing.Size(62, 20);
            this.LblYearNo.TabIndex = 27;
            this.LblYearNo.Text = "YearNo";
            // 
            // LblStartYear
            // 
            this.LblStartYear.AutoSize = true;
            this.LblStartYear.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblStartYear.Location = new System.Drawing.Point(29, 300);
            this.LblStartYear.Name = "LblStartYear";
            this.LblStartYear.Size = new System.Drawing.Size(48, 20);
            this.LblStartYear.TabIndex = 29;
            this.LblStartYear.Text = "Start";
            // 
            // TxtStartYear
            // 
            this.TxtStartYear.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartYear.Location = new System.Drawing.Point(100, 294);
            this.TxtStartYear.Name = "TxtStartYear";
            this.TxtStartYear.Size = new System.Drawing.Size(167, 26);
            this.TxtStartYear.TabIndex = 30;
            this.TxtStartYear.TextChanged += new System.EventHandler(this.TxtStartYear_TextChanged);
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblArea.Location = new System.Drawing.Point(29, 332);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(43, 20);
            this.LblArea.TabIndex = 31;
            this.LblArea.Text = "Area";
            // 
            // TxtArea
            // 
            this.TxtArea.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.Location = new System.Drawing.Point(100, 326);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(167, 26);
            this.TxtArea.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageIMS);
            this.tabControl1.Controls.Add(this.TabPageNominal);
            this.tabControl1.Controls.Add(this.TabPagePSUB);
            this.tabControl1.Controls.Add(this.TabPageGWF);
            this.tabControl1.Controls.Add(this.TabPageIGW);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 358);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(255, 327);
            this.tabControl1.TabIndex = 33;
            // 
            // TabPageIMS
            // 
            this.TabPageIMS.Controls.Add(this.LbltabIMS);
            this.TabPageIMS.Controls.Add(this.LblStepIMS);
            this.TabPageIMS.Controls.Add(this.TxtStepIMS);
            this.TabPageIMS.Controls.Add(this.LblIMSMin);
            this.TabPageIMS.Controls.Add(this.TxtMinIMS);
            this.TabPageIMS.Controls.Add(this.LblMaxIMS);
            this.TabPageIMS.Controls.Add(this.TxtMaxIMS);
            this.TabPageIMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageIMS.Location = new System.Drawing.Point(4, 27);
            this.TabPageIMS.Name = "TabPageIMS";
            this.TabPageIMS.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageIMS.Size = new System.Drawing.Size(247, 296);
            this.TabPageIMS.TabIndex = 0;
            this.TabPageIMS.Text = "IMS";
            this.TabPageIMS.UseVisualStyleBackColor = true;
            // 
            // LbltabIMS
            // 
            this.LbltabIMS.AutoSize = true;
            this.LbltabIMS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltabIMS.ForeColor = System.Drawing.Color.Blue;
            this.LbltabIMS.Location = new System.Drawing.Point(97, 39);
            this.LbltabIMS.Name = "LbltabIMS";
            this.LbltabIMS.Size = new System.Drawing.Size(40, 20);
            this.LbltabIMS.TabIndex = 15;
            this.LbltabIMS.Text = "IMS";
            // 
            // LblStepIMS
            // 
            this.LblStepIMS.AutoSize = true;
            this.LblStepIMS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStepIMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblStepIMS.Location = new System.Drawing.Point(64, 203);
            this.LblStepIMS.Name = "LblStepIMS";
            this.LblStepIMS.Size = new System.Drawing.Size(46, 20);
            this.LblStepIMS.TabIndex = 14;
            this.LblStepIMS.Text = "STEP";
            // 
            // TxtStepIMS
            // 
            this.TxtStepIMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepIMS.Location = new System.Drawing.Point(127, 199);
            this.TxtStepIMS.Name = "TxtStepIMS";
            this.TxtStepIMS.Size = new System.Drawing.Size(73, 26);
            this.TxtStepIMS.TabIndex = 13;
            this.TxtStepIMS.Text = "100";
            // 
            // LblIMSMin
            // 
            this.LblIMSMin.AutoSize = true;
            this.LblIMSMin.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIMSMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblIMSMin.Location = new System.Drawing.Point(64, 148);
            this.LblIMSMin.Name = "LblIMSMin";
            this.LblIMSMin.Size = new System.Drawing.Size(42, 20);
            this.LblIMSMin.TabIndex = 12;
            this.LblIMSMin.Text = "MIN";
            // 
            // TxtMinIMS
            // 
            this.TxtMinIMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinIMS.Location = new System.Drawing.Point(127, 144);
            this.TxtMinIMS.Name = "TxtMinIMS";
            this.TxtMinIMS.Size = new System.Drawing.Size(73, 26);
            this.TxtMinIMS.TabIndex = 11;
            this.TxtMinIMS.Text = "200";
            // 
            // LblMaxIMS
            // 
            this.LblMaxIMS.AutoSize = true;
            this.LblMaxIMS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxIMS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMaxIMS.Location = new System.Drawing.Point(64, 96);
            this.LblMaxIMS.Name = "LblMaxIMS";
            this.LblMaxIMS.Size = new System.Drawing.Size(44, 20);
            this.LblMaxIMS.TabIndex = 10;
            this.LblMaxIMS.Text = "MAX";
            // 
            // TxtMaxIMS
            // 
            this.TxtMaxIMS.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxIMS.Location = new System.Drawing.Point(127, 92);
            this.TxtMaxIMS.Name = "TxtMaxIMS";
            this.TxtMaxIMS.Size = new System.Drawing.Size(73, 26);
            this.TxtMaxIMS.TabIndex = 9;
            this.TxtMaxIMS.Text = "800";
            // 
            // TabPageNominal
            // 
            this.TabPageNominal.Controls.Add(this.LblTabNominal);
            this.TabPageNominal.Controls.Add(this.LblStepNominal);
            this.TabPageNominal.Controls.Add(this.TxtStepNominal);
            this.TabPageNominal.Controls.Add(this.LblMinNominal);
            this.TabPageNominal.Controls.Add(this.TxtMinNominal);
            this.TabPageNominal.Controls.Add(this.LblMaxNominal);
            this.TabPageNominal.Controls.Add(this.TxtMaxNominal);
            this.TabPageNominal.Location = new System.Drawing.Point(4, 27);
            this.TabPageNominal.Name = "TabPageNominal";
            this.TabPageNominal.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNominal.Size = new System.Drawing.Size(247, 296);
            this.TabPageNominal.TabIndex = 1;
            this.TabPageNominal.Text = "Nominal";
            this.TabPageNominal.UseVisualStyleBackColor = true;
            // 
            // LblTabNominal
            // 
            this.LblTabNominal.AutoSize = true;
            this.LblTabNominal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTabNominal.ForeColor = System.Drawing.Color.Blue;
            this.LblTabNominal.Location = new System.Drawing.Point(97, 39);
            this.LblTabNominal.Name = "LblTabNominal";
            this.LblTabNominal.Size = new System.Drawing.Size(85, 20);
            this.LblTabNominal.TabIndex = 21;
            this.LblTabNominal.Text = "NOMINAL";
            // 
            // LblStepNominal
            // 
            this.LblStepNominal.AutoSize = true;
            this.LblStepNominal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStepNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblStepNominal.Location = new System.Drawing.Point(64, 203);
            this.LblStepNominal.Name = "LblStepNominal";
            this.LblStepNominal.Size = new System.Drawing.Size(46, 20);
            this.LblStepNominal.TabIndex = 20;
            this.LblStepNominal.Text = "STEP";
            // 
            // TxtStepNominal
            // 
            this.TxtStepNominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepNominal.Location = new System.Drawing.Point(127, 199);
            this.TxtStepNominal.Name = "TxtStepNominal";
            this.TxtStepNominal.Size = new System.Drawing.Size(73, 26);
            this.TxtStepNominal.TabIndex = 19;
            this.TxtStepNominal.Text = "100";
            // 
            // LblMinNominal
            // 
            this.LblMinNominal.AutoSize = true;
            this.LblMinNominal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMinNominal.Location = new System.Drawing.Point(64, 148);
            this.LblMinNominal.Name = "LblMinNominal";
            this.LblMinNominal.Size = new System.Drawing.Size(42, 20);
            this.LblMinNominal.TabIndex = 18;
            this.LblMinNominal.Text = "MIN";
            // 
            // TxtMinNominal
            // 
            this.TxtMinNominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinNominal.Location = new System.Drawing.Point(127, 144);
            this.TxtMinNominal.Name = "TxtMinNominal";
            this.TxtMinNominal.Size = new System.Drawing.Size(73, 26);
            this.TxtMinNominal.TabIndex = 17;
            this.TxtMinNominal.Text = "200";
            // 
            // LblMaxNominal
            // 
            this.LblMaxNominal.AutoSize = true;
            this.LblMaxNominal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMaxNominal.Location = new System.Drawing.Point(64, 96);
            this.LblMaxNominal.Name = "LblMaxNominal";
            this.LblMaxNominal.Size = new System.Drawing.Size(44, 20);
            this.LblMaxNominal.TabIndex = 16;
            this.LblMaxNominal.Text = "MAX";
            // 
            // TxtMaxNominal
            // 
            this.TxtMaxNominal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxNominal.Location = new System.Drawing.Point(127, 92);
            this.TxtMaxNominal.Name = "TxtMaxNominal";
            this.TxtMaxNominal.Size = new System.Drawing.Size(73, 26);
            this.TxtMaxNominal.TabIndex = 15;
            this.TxtMaxNominal.Text = "800";
            // 
            // TabPagePSUB
            // 
            this.TabPagePSUB.Controls.Add(this.label1);
            this.TabPagePSUB.Controls.Add(this.Lblsteppsub);
            this.TabPagePSUB.Controls.Add(this.TxtStepPSUB);
            this.TabPagePSUB.Controls.Add(this.LblminPSUB);
            this.TabPagePSUB.Controls.Add(this.TxtMinPSUB);
            this.TabPagePSUB.Controls.Add(this.LblMaxPSUB);
            this.TabPagePSUB.Controls.Add(this.TxtMaxPSUB);
            this.TabPagePSUB.Location = new System.Drawing.Point(4, 27);
            this.TabPagePSUB.Name = "TabPagePSUB";
            this.TabPagePSUB.Size = new System.Drawing.Size(247, 296);
            this.TabPagePSUB.TabIndex = 2;
            this.TabPagePSUB.Text = "PSUB";
            this.TabPagePSUB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(97, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "PSUB";
            // 
            // Lblsteppsub
            // 
            this.Lblsteppsub.AutoSize = true;
            this.Lblsteppsub.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsteppsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.Lblsteppsub.Location = new System.Drawing.Point(64, 203);
            this.Lblsteppsub.Name = "Lblsteppsub";
            this.Lblsteppsub.Size = new System.Drawing.Size(46, 20);
            this.Lblsteppsub.TabIndex = 20;
            this.Lblsteppsub.Text = "STEP";
            // 
            // TxtStepPSUB
            // 
            this.TxtStepPSUB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepPSUB.Location = new System.Drawing.Point(127, 199);
            this.TxtStepPSUB.Name = "TxtStepPSUB";
            this.TxtStepPSUB.Size = new System.Drawing.Size(73, 26);
            this.TxtStepPSUB.TabIndex = 19;
            this.TxtStepPSUB.Text = "0.2";
            // 
            // LblminPSUB
            // 
            this.LblminPSUB.AutoSize = true;
            this.LblminPSUB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblminPSUB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblminPSUB.Location = new System.Drawing.Point(64, 148);
            this.LblminPSUB.Name = "LblminPSUB";
            this.LblminPSUB.Size = new System.Drawing.Size(42, 20);
            this.LblminPSUB.TabIndex = 18;
            this.LblminPSUB.Text = "MIN";
            // 
            // TxtMinPSUB
            // 
            this.TxtMinPSUB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinPSUB.Location = new System.Drawing.Point(127, 144);
            this.TxtMinPSUB.Name = "TxtMinPSUB";
            this.TxtMinPSUB.Size = new System.Drawing.Size(73, 26);
            this.TxtMinPSUB.TabIndex = 17;
            this.TxtMinPSUB.Text = "0.2";
            // 
            // LblMaxPSUB
            // 
            this.LblMaxPSUB.AutoSize = true;
            this.LblMaxPSUB.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxPSUB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMaxPSUB.Location = new System.Drawing.Point(64, 96);
            this.LblMaxPSUB.Name = "LblMaxPSUB";
            this.LblMaxPSUB.Size = new System.Drawing.Size(44, 20);
            this.LblMaxPSUB.TabIndex = 16;
            this.LblMaxPSUB.Text = "MAX";
            // 
            // TxtMaxPSUB
            // 
            this.TxtMaxPSUB.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxPSUB.Location = new System.Drawing.Point(127, 92);
            this.TxtMaxPSUB.Name = "TxtMaxPSUB";
            this.TxtMaxPSUB.Size = new System.Drawing.Size(73, 26);
            this.TxtMaxPSUB.TabIndex = 15;
            this.TxtMaxPSUB.Text = "0.8";
            // 
            // TabPageGWF
            // 
            this.TabPageGWF.Controls.Add(this.label2);
            this.TabPageGWF.Controls.Add(this.LblStepGWF);
            this.TabPageGWF.Controls.Add(this.TxtStepGWF);
            this.TabPageGWF.Controls.Add(this.LblMinGWF);
            this.TabPageGWF.Controls.Add(this.TxtMinGWF);
            this.TabPageGWF.Controls.Add(this.LblMaxGWF);
            this.TabPageGWF.Controls.Add(this.TxtMaxGWF);
            this.TabPageGWF.Location = new System.Drawing.Point(4, 27);
            this.TabPageGWF.Name = "TabPageGWF";
            this.TabPageGWF.Size = new System.Drawing.Size(247, 296);
            this.TabPageGWF.TabIndex = 3;
            this.TabPageGWF.Text = "GWF";
            this.TabPageGWF.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "GWF";
            // 
            // LblStepGWF
            // 
            this.LblStepGWF.AutoSize = true;
            this.LblStepGWF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStepGWF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblStepGWF.Location = new System.Drawing.Point(64, 203);
            this.LblStepGWF.Name = "LblStepGWF";
            this.LblStepGWF.Size = new System.Drawing.Size(46, 20);
            this.LblStepGWF.TabIndex = 26;
            this.LblStepGWF.Text = "STEP";
            // 
            // TxtStepGWF
            // 
            this.TxtStepGWF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepGWF.Location = new System.Drawing.Point(127, 199);
            this.TxtStepGWF.Name = "TxtStepGWF";
            this.TxtStepGWF.Size = new System.Drawing.Size(73, 26);
            this.TxtStepGWF.TabIndex = 25;
            this.TxtStepGWF.Text = "0.2";
            // 
            // LblMinGWF
            // 
            this.LblMinGWF.AutoSize = true;
            this.LblMinGWF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinGWF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMinGWF.Location = new System.Drawing.Point(64, 148);
            this.LblMinGWF.Name = "LblMinGWF";
            this.LblMinGWF.Size = new System.Drawing.Size(42, 20);
            this.LblMinGWF.TabIndex = 24;
            this.LblMinGWF.Text = "MIN";
            // 
            // TxtMinGWF
            // 
            this.TxtMinGWF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinGWF.Location = new System.Drawing.Point(127, 144);
            this.TxtMinGWF.Name = "TxtMinGWF";
            this.TxtMinGWF.Size = new System.Drawing.Size(73, 26);
            this.TxtMinGWF.TabIndex = 23;
            this.TxtMinGWF.Text = "0.2";
            // 
            // LblMaxGWF
            // 
            this.LblMaxGWF.AutoSize = true;
            this.LblMaxGWF.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxGWF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMaxGWF.Location = new System.Drawing.Point(64, 96);
            this.LblMaxGWF.Name = "LblMaxGWF";
            this.LblMaxGWF.Size = new System.Drawing.Size(44, 20);
            this.LblMaxGWF.TabIndex = 22;
            this.LblMaxGWF.Text = "MAX";
            // 
            // TxtMaxGWF
            // 
            this.TxtMaxGWF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxGWF.Location = new System.Drawing.Point(127, 92);
            this.TxtMaxGWF.Name = "TxtMaxGWF";
            this.TxtMaxGWF.Size = new System.Drawing.Size(73, 26);
            this.TxtMaxGWF.TabIndex = 21;
            this.TxtMaxGWF.Text = "0.8";
            // 
            // TabPageIGW
            // 
            this.TabPageIGW.Controls.Add(this.label3);
            this.TabPageIGW.Controls.Add(this.LblStepIGW);
            this.TabPageIGW.Controls.Add(this.TxtStepIGW);
            this.TabPageIGW.Controls.Add(this.LblMinIGW);
            this.TabPageIGW.Controls.Add(this.TxtMinIGW);
            this.TabPageIGW.Controls.Add(this.LblMaxIGW);
            this.TabPageIGW.Controls.Add(this.TxtMaxIGW);
            this.TabPageIGW.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageIGW.Location = new System.Drawing.Point(4, 27);
            this.TabPageIGW.Name = "TabPageIGW";
            this.TabPageIGW.Size = new System.Drawing.Size(247, 296);
            this.TabPageIGW.TabIndex = 4;
            this.TabPageIGW.Text = "IGW";
            this.TabPageIGW.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(64, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Initial Ground Water";
            // 
            // LblStepIGW
            // 
            this.LblStepIGW.AutoSize = true;
            this.LblStepIGW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStepIGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblStepIGW.Location = new System.Drawing.Point(64, 203);
            this.LblStepIGW.Name = "LblStepIGW";
            this.LblStepIGW.Size = new System.Drawing.Size(46, 20);
            this.LblStepIGW.TabIndex = 26;
            this.LblStepIGW.Text = "STEP";
            // 
            // TxtStepIGW
            // 
            this.TxtStepIGW.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepIGW.Location = new System.Drawing.Point(127, 199);
            this.TxtStepIGW.Name = "TxtStepIGW";
            this.TxtStepIGW.Size = new System.Drawing.Size(73, 26);
            this.TxtStepIGW.TabIndex = 25;
            this.TxtStepIGW.Text = "10";
            // 
            // LblMinIGW
            // 
            this.LblMinIGW.AutoSize = true;
            this.LblMinIGW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinIGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMinIGW.Location = new System.Drawing.Point(64, 148);
            this.LblMinIGW.Name = "LblMinIGW";
            this.LblMinIGW.Size = new System.Drawing.Size(42, 20);
            this.LblMinIGW.TabIndex = 24;
            this.LblMinIGW.Text = "MIN";
            // 
            // TxtMinIGW
            // 
            this.TxtMinIGW.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinIGW.Location = new System.Drawing.Point(127, 147);
            this.TxtMinIGW.Name = "TxtMinIGW";
            this.TxtMinIGW.Size = new System.Drawing.Size(73, 26);
            this.TxtMinIGW.TabIndex = 23;
            this.TxtMinIGW.Text = "40";
            // 
            // LblMaxIGW
            // 
            this.LblMaxIGW.AutoSize = true;
            this.LblMaxIGW.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxIGW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.LblMaxIGW.Location = new System.Drawing.Point(64, 96);
            this.LblMaxIGW.Name = "LblMaxIGW";
            this.LblMaxIGW.Size = new System.Drawing.Size(44, 20);
            this.LblMaxIGW.TabIndex = 22;
            this.LblMaxIGW.Text = "MAX";
            // 
            // TxtMaxIGW
            // 
            this.TxtMaxIGW.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxIGW.Location = new System.Drawing.Point(127, 92);
            this.TxtMaxIGW.Name = "TxtMaxIGW";
            this.TxtMaxIGW.Size = new System.Drawing.Size(73, 26);
            this.TxtMaxIGW.TabIndex = 21;
            this.TxtMaxIGW.Text = "50";
            // 
            // FrmCrawford
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.LblStartYear);
            this.Controls.Add(this.TxtStartYear);
            this.Controls.Add(this.LblYearNo);
            this.Controls.Add(this.TxtYearNo);
            this.Controls.Add(this.GroupBoxParameter);
            this.Controls.Add(this.ChartMusking);
            this.Controls.Add(this.dataGridViewMusking);
            this.Name = "FrmCrawford";
            this.Text = "Crawford";
            this.Load += new System.EventHandler(this.FrmCrawford_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartMusking)).EndInit();
            this.GroupBoxParameter.ResumeLayout(false);
            this.GroupBoxParameter.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPageIMS.ResumeLayout(false);
            this.TabPageIMS.PerformLayout();
            this.TabPageNominal.ResumeLayout(false);
            this.TabPageNominal.PerformLayout();
            this.TabPagePSUB.ResumeLayout(false);
            this.TabPagePSUB.PerformLayout();
            this.TabPageGWF.ResumeLayout(false);
            this.TabPageGWF.PerformLayout();
            this.TabPageIGW.ResumeLayout(false);
            this.TabPageIGW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusking;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartMusking;
        private System.Windows.Forms.GroupBox GroupBoxParameter;
        private System.Windows.Forms.TextBox TxtInitialGW;
        private System.Windows.Forms.Label LblInitialGW;
        private System.Windows.Forms.TextBox TxtEFF;
        private System.Windows.Forms.Label LblEFF;
        private System.Windows.Forms.TextBox TxtGWF;
        private System.Windows.Forms.Label LblGWF;
        private System.Windows.Forms.TextBox TxtPSUB;
        private System.Windows.Forms.Label LblPSUB;
        private System.Windows.Forms.Label LblIMS;
        private System.Windows.Forms.TextBox TxtIMS;
        private System.Windows.Forms.TextBox TxtInitialGW_OPT;
        private System.Windows.Forms.TextBox TxtEFF_OPT;
        private System.Windows.Forms.TextBox TxtGWF_OPT;
        private System.Windows.Forms.TextBox TxtPSUB_OPT;
        private System.Windows.Forms.TextBox TxtOPT_IMS;
        private System.Windows.Forms.TextBox TxtYearNo;
        private System.Windows.Forms.Label LblYearNo;
        private System.Windows.Forms.Label LblStartYear;
        private System.Windows.Forms.TextBox TxtStartYear;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.TextBox TxtOpt_Nominal;
        private System.Windows.Forms.Label LblNominal;
        private System.Windows.Forms.TextBox TxtNominal;
        private System.Windows.Forms.Label LblOpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMoistureRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStorageRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPPT_PET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAET_PET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWaterBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExcessMoistureRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExcessMoisture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeltaStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGWF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDirectFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObsFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObsFlow_mm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageIMS;
        private System.Windows.Forms.Label LblStepIMS;
        private System.Windows.Forms.TextBox TxtStepIMS;
        private System.Windows.Forms.Label LblIMSMin;
        private System.Windows.Forms.TextBox TxtMinIMS;
        private System.Windows.Forms.Label LblMaxIMS;
        private System.Windows.Forms.TextBox TxtMaxIMS;
        private System.Windows.Forms.TabPage TabPageNominal;
        private System.Windows.Forms.Label LblStepNominal;
        private System.Windows.Forms.TextBox TxtStepNominal;
        private System.Windows.Forms.Label LblMinNominal;
        private System.Windows.Forms.TextBox TxtMinNominal;
        private System.Windows.Forms.Label LblMaxNominal;
        private System.Windows.Forms.TextBox TxtMaxNominal;
        private System.Windows.Forms.TabPage TabPagePSUB;
        private System.Windows.Forms.Label Lblsteppsub;
        private System.Windows.Forms.TextBox TxtStepPSUB;
        private System.Windows.Forms.Label LblminPSUB;
        private System.Windows.Forms.TextBox TxtMinPSUB;
        private System.Windows.Forms.Label LblMaxPSUB;
        private System.Windows.Forms.TextBox TxtMaxPSUB;
        private System.Windows.Forms.TabPage TabPageGWF;
        private System.Windows.Forms.Label LblStepGWF;
        private System.Windows.Forms.TextBox TxtStepGWF;
        private System.Windows.Forms.Label LblMinGWF;
        private System.Windows.Forms.TextBox TxtMinGWF;
        private System.Windows.Forms.Label LblMaxGWF;
        private System.Windows.Forms.TextBox TxtMaxGWF;
        private System.Windows.Forms.TabPage TabPageIGW;
        private System.Windows.Forms.Label LblStepIGW;
        private System.Windows.Forms.TextBox TxtStepIGW;
        private System.Windows.Forms.Label LblMinIGW;
        private System.Windows.Forms.TextBox TxtMinIGW;
        private System.Windows.Forms.Label LblMaxIGW;
        private System.Windows.Forms.TextBox TxtMaxIGW;
        private System.Windows.Forms.Label LbltabIMS;
        private System.Windows.Forms.Label LblTabNominal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem SWAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem CRAWFORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
    }
}