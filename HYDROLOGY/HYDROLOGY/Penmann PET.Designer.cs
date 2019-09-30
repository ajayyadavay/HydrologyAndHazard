namespace HYDROLOGY
{
    partial class FrmPenmann_PET
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtStartYear = new System.Windows.Forms.TextBox();
            this.LblStartYear = new System.Windows.Forms.Label();
            this.LblNum = new System.Windows.Forms.Label();
            this.Txtnum = new System.Windows.Forms.TextBox();
            this.Txtgamma = new System.Windows.Forms.TextBox();
            this.Lblgamma = new System.Windows.Forms.Label();
            this.Txtsigma = new System.Windows.Forms.TextBox();
            this.Lblsigma = new System.Windows.Forms.Label();
            this.Txtb = new System.Windows.Forms.TextBox();
            this.Lblb = new System.Windows.Forms.Label();
            this.Lbla = new System.Windows.Forms.Label();
            this.Txta = new System.Windows.Forms.TextBox();
            this.Txtphi = new System.Windows.Forms.TextBox();
            this.Lblphi = new System.Windows.Forms.Label();
            this.Lblr = new System.Windows.Forms.Label();
            this.Txtr = new System.Windows.Forms.TextBox();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHumidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaxSunshine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColU2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPET = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtStartYear);
            this.groupBox1.Controls.Add(this.LblStartYear);
            this.groupBox1.Controls.Add(this.LblNum);
            this.groupBox1.Controls.Add(this.Txtnum);
            this.groupBox1.Controls.Add(this.Txtgamma);
            this.groupBox1.Controls.Add(this.Lblgamma);
            this.groupBox1.Controls.Add(this.Txtsigma);
            this.groupBox1.Controls.Add(this.Lblsigma);
            this.groupBox1.Controls.Add(this.Txtb);
            this.groupBox1.Controls.Add(this.Lblb);
            this.groupBox1.Controls.Add(this.Lbla);
            this.groupBox1.Controls.Add(this.Txta);
            this.groupBox1.Controls.Add(this.Txtphi);
            this.groupBox1.Controls.Add(this.Lblphi);
            this.groupBox1.Controls.Add(this.Lblr);
            this.groupBox1.Controls.Add(this.Txtr);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(64, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1235, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penmann Equation Parameters";
            // 
            // TxtStartYear
            // 
            this.TxtStartYear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartYear.Location = new System.Drawing.Point(282, 61);
            this.TxtStartYear.Name = "TxtStartYear";
            this.TxtStartYear.Size = new System.Drawing.Size(99, 30);
            this.TxtStartYear.TabIndex = 44;
            this.TxtStartYear.TextChanged += new System.EventHandler(this.TxtStartYear_TextChanged);
            // 
            // LblStartYear
            // 
            this.LblStartYear.AutoSize = true;
            this.LblStartYear.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblStartYear.Location = new System.Drawing.Point(277, 29);
            this.LblStartYear.Name = "LblStartYear";
            this.LblStartYear.Size = new System.Drawing.Size(107, 26);
            this.LblStartYear.TabIndex = 43;
            this.LblStartYear.Text = "Start Year";
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblNum.Location = new System.Drawing.Point(38, 30);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(164, 26);
            this.LblNum.TabIndex = 40;
            this.LblNum.Text = "Number of Years";
            // 
            // Txtnum
            // 
            this.Txtnum.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtnum.Location = new System.Drawing.Point(43, 61);
            this.Txtnum.Name = "Txtnum";
            this.Txtnum.Size = new System.Drawing.Size(151, 30);
            this.Txtnum.TabIndex = 39;
            this.Txtnum.TextChanged += new System.EventHandler(this.Txtnum_TextChanged);
            // 
            // Txtgamma
            // 
            this.Txtgamma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtgamma.Location = new System.Drawing.Point(727, 119);
            this.Txtgamma.Name = "Txtgamma";
            this.Txtgamma.ReadOnly = true;
            this.Txtgamma.Size = new System.Drawing.Size(135, 30);
            this.Txtgamma.TabIndex = 38;
            this.Txtgamma.Text = "0.49";
            // 
            // Lblgamma
            // 
            this.Lblgamma.AutoSize = true;
            this.Lblgamma.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblgamma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lblgamma.Location = new System.Drawing.Point(476, 124);
            this.Lblgamma.Name = "Lblgamma";
            this.Lblgamma.Size = new System.Drawing.Size(232, 26);
            this.Lblgamma.TabIndex = 37;
            this.Lblgamma.Text = "γ Psychrometric constant";
            // 
            // Txtsigma
            // 
            this.Txtsigma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtsigma.Location = new System.Drawing.Point(173, 119);
            this.Txtsigma.Name = "Txtsigma";
            this.Txtsigma.ReadOnly = true;
            this.Txtsigma.Size = new System.Drawing.Size(233, 30);
            this.Txtsigma.TabIndex = 36;
            this.Txtsigma.Text = "0.00000000201";
            // 
            // Lblsigma
            // 
            this.Lblsigma.AutoSize = true;
            this.Lblsigma.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsigma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lblsigma.Location = new System.Drawing.Point(38, 119);
            this.Lblsigma.Name = "Lblsigma";
            this.Lblsigma.Size = new System.Drawing.Size(113, 26);
            this.Lblsigma.TabIndex = 35;
            this.Lblsigma.Text = "σ (mm/day)";
            // 
            // Txtb
            // 
            this.Txtb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb.Location = new System.Drawing.Point(901, 59);
            this.Txtb.Name = "Txtb";
            this.Txtb.ReadOnly = true;
            this.Txtb.Size = new System.Drawing.Size(106, 30);
            this.Txtb.TabIndex = 34;
            this.Txtb.Text = "0.52";
            // 
            // Lblb
            // 
            this.Lblb.AutoSize = true;
            this.Lblb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lblb.Location = new System.Drawing.Point(935, 30);
            this.Lblb.Name = "Lblb";
            this.Lblb.Size = new System.Drawing.Size(23, 26);
            this.Lblb.TabIndex = 33;
            this.Lblb.Text = "b";
            // 
            // Lbla
            // 
            this.Lbla.AutoSize = true;
            this.Lbla.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbla.Location = new System.Drawing.Point(1112, 32);
            this.Lbla.Name = "Lbla";
            this.Lbla.Size = new System.Drawing.Size(22, 26);
            this.Lbla.TabIndex = 32;
            this.Lbla.Text = "a";
            this.Lbla.Click += new System.EventHandler(this.Lbla_Click);
            // 
            // Txta
            // 
            this.Txta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txta.Location = new System.Drawing.Point(1076, 61);
            this.Txta.Name = "Txta";
            this.Txta.ReadOnly = true;
            this.Txta.Size = new System.Drawing.Size(106, 30);
            this.Txta.TabIndex = 31;
            this.Txta.TextChanged += new System.EventHandler(this.Txta_TextChanged);
            // 
            // Txtphi
            // 
            this.Txtphi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtphi.Location = new System.Drawing.Point(646, 59);
            this.Txtphi.Name = "Txtphi";
            this.Txtphi.Size = new System.Drawing.Size(126, 30);
            this.Txtphi.TabIndex = 30;
            this.Txtphi.TextChanged += new System.EventHandler(this.Txtphi_TextChanged);
            // 
            // Lblphi
            // 
            this.Lblphi.AutoSize = true;
            this.Lblphi.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblphi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lblphi.Location = new System.Drawing.Point(656, 30);
            this.Lblphi.Name = "Lblphi";
            this.Lblphi.Size = new System.Drawing.Size(107, 26);
            this.Lblphi.TabIndex = 29;
            this.Lblphi.Text = "Φ (Degree)";
            // 
            // Lblr
            // 
            this.Lblr.AutoSize = true;
            this.Lblr.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lblr.Location = new System.Drawing.Point(520, 30);
            this.Lblr.Name = "Lblr";
            this.Lblr.Size = new System.Drawing.Size(21, 26);
            this.Lblr.TabIndex = 28;
            this.Lblr.Text = "r";
            // 
            // Txtr
            // 
            this.Txtr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtr.Location = new System.Drawing.Point(484, 59);
            this.Txtr.Name = "Txtr";
            this.Txtr.Size = new System.Drawing.Size(84, 30);
            this.Txtr.TabIndex = 27;
            // 
            // dataGridViewMusking
            // 
            this.dataGridViewMusking.AllowUserToResizeColumns = false;
            this.dataGridViewMusking.AllowUserToResizeRows = false;
            this.dataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColDay,
            this.ColTemperature,
            this.Coles,
            this.ColHumidity,
            this.Colea,
            this.ColA,
            this.ColHa,
            this.ColMaxSunshine,
            this.Coln,
            this.ColHn,
            this.ColU2,
            this.ColEva,
            this.ColPET});
            this.dataGridViewMusking.Location = new System.Drawing.Point(64, 234);
            this.dataGridViewMusking.Name = "dataGridViewMusking";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewMusking.RowHeadersVisible = false;
            this.dataGridViewMusking.Size = new System.Drawing.Size(1235, 425);
            this.dataGridViewMusking.TabIndex = 30;
            // 
            // ColYear
            // 
            this.ColYear.HeaderText = "Year";
            this.ColYear.Name = "ColYear";
            this.ColYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColYear.Width = 80;
            // 
            // ColDay
            // 
            this.ColDay.HeaderText = "Day";
            this.ColDay.Name = "ColDay";
            this.ColDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDay.Width = 70;
            // 
            // ColTemperature
            // 
            this.ColTemperature.HeaderText = "Temperature (oC)";
            this.ColTemperature.Name = "ColTemperature";
            this.ColTemperature.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Coles
            // 
            this.Coles.HeaderText = "es";
            this.Coles.Name = "Coles";
            this.Coles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColHumidity
            // 
            this.ColHumidity.HeaderText = "Humidity";
            this.ColHumidity.Name = "ColHumidity";
            this.ColHumidity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Colea
            // 
            this.Colea.HeaderText = "ea";
            this.Colea.Name = "Colea";
            this.Colea.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColA
            // 
            this.ColA.HeaderText = "A";
            this.ColA.Name = "ColA";
            this.ColA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColHa
            // 
            this.ColHa.HeaderText = "Ha";
            this.ColHa.Name = "ColHa";
            this.ColHa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColMaxSunshine
            // 
            this.ColMaxSunshine.HeaderText = "MaxSunshine";
            this.ColMaxSunshine.Name = "ColMaxSunshine";
            this.ColMaxSunshine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Coln
            // 
            this.Coln.HeaderText = "n (hr)";
            this.Coln.Name = "Coln";
            this.Coln.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColHn
            // 
            this.ColHn.HeaderText = "Hn (mm/day)";
            this.ColHn.Name = "ColHn";
            this.ColHn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColU2
            // 
            this.ColU2.HeaderText = "U2 (km/day)";
            this.ColU2.Name = "ColU2";
            this.ColU2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColEva
            // 
            this.ColEva.HeaderText = "Ea";
            this.ColEva.Name = "ColEva";
            this.ColEva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPET
            // 
            this.ColPET.HeaderText = "PET";
            this.ColPET.Name = "ColPET";
            this.ColPET.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.toolStripMenuItem5,
            this.EXITToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 176);
            // 
            // RUNToolStripMenuItem
            // 
            this.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem";
            this.RUNToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.RUNToolStripMenuItem.Text = "Calculate PET";
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
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.LblTitle.Location = new System.Drawing.Point(543, 14);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(324, 26);
            this.LblTitle.TabIndex = 45;
            this.LblTitle.Text = "PET Calculation by Penman Equation";
            // 
            // FrmPenmann_PET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 701);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.dataGridViewMusking);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPenmann_PET";
            this.Text = "Penmann PET";
            this.Load += new System.EventHandler(this.FrmPenmann_PET_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtsigma;
        private System.Windows.Forms.Label Lblsigma;
        private System.Windows.Forms.TextBox Txtb;
        private System.Windows.Forms.Label Lblb;
        private System.Windows.Forms.Label Lbla;
        private System.Windows.Forms.TextBox Txta;
        private System.Windows.Forms.TextBox Txtphi;
        private System.Windows.Forms.Label Lblphi;
        private System.Windows.Forms.Label Lblr;
        private System.Windows.Forms.TextBox Txtr;
        private System.Windows.Forms.TextBox Txtgamma;
        private System.Windows.Forms.Label Lblgamma;
        private System.Windows.Forms.DataGridView dataGridViewMusking;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox Txtnum;
        private System.Windows.Forms.TextBox TxtStartYear;
        private System.Windows.Forms.Label LblStartYear;
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHumidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaxSunshine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coln;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColU2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPET;
        private System.Windows.Forms.Label LblTitle;
    }
}