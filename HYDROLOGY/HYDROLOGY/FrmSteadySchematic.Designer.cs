namespace HYDROLOGY
{
    partial class FrmSteadySchematic
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
            this.LblNode = new System.Windows.Forms.Label();
            this.TxtNodeX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTimeY = new System.Windows.Forms.TextBox();
            this.PanelCanvas = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.LblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtY = new System.Windows.Forms.TextBox();
            this.TxtX = new System.Windows.Forms.TextBox();
            this.LblY = new System.Windows.Forms.Label();
            this.LblX = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ToolTipSeeData = new System.Windows.Forms.ToolTip(this.components);
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNode
            // 
            this.LblNode.AutoSize = true;
            this.LblNode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNode.ForeColor = System.Drawing.Color.White;
            this.LblNode.Location = new System.Drawing.Point(12, 19);
            this.LblNode.Name = "LblNode";
            this.LblNode.Size = new System.Drawing.Size(58, 26);
            this.LblNode.TabIndex = 34;
            this.LblNode.Text = "Node";
            // 
            // TxtNodeX
            // 
            this.TxtNodeX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNodeX.Location = new System.Drawing.Point(85, 18);
            this.TxtNodeX.Name = "TxtNodeX";
            this.TxtNodeX.Size = new System.Drawing.Size(69, 30);
            this.TxtNodeX.TabIndex = 33;
            this.TxtNodeX.Text = "30";
            this.TxtNodeX.TextChanged += new System.EventHandler(this.TxtNodeX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Time";
            // 
            // TxtTimeY
            // 
            this.TxtTimeY.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTimeY.Location = new System.Drawing.Point(220, 18);
            this.TxtTimeY.Name = "TxtTimeY";
            this.TxtTimeY.Size = new System.Drawing.Size(68, 30);
            this.TxtTimeY.TabIndex = 35;
            this.TxtTimeY.Text = "10";
            this.TxtTimeY.TextChanged += new System.EventHandler(this.TxtTimeY_TextChanged);
            // 
            // PanelCanvas
            // 
            this.PanelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelCanvas.Location = new System.Drawing.Point(0, 57);
            this.PanelCanvas.Name = "PanelCanvas";
            this.PanelCanvas.Size = new System.Drawing.Size(1236, 446);
            this.PanelCanvas.TabIndex = 38;
            this.PanelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCanvas_Paint);
            this.PanelCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseClick);
            this.PanelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseMove);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Teal;
            this.PanelMenu.Controls.Add(this.LblData);
            this.PanelMenu.Controls.Add(this.label3);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.TxtY);
            this.PanelMenu.Controls.Add(this.TxtX);
            this.PanelMenu.Controls.Add(this.LblY);
            this.PanelMenu.Controls.Add(this.LblX);
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Controls.Add(this.TxtNodeX);
            this.PanelMenu.Controls.Add(this.TxtTimeY);
            this.PanelMenu.Controls.Add(this.LblNode);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1236, 58);
            this.PanelMenu.TabIndex = 39;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.ForeColor = System.Drawing.Color.White;
            this.LblData.Location = new System.Drawing.Point(591, 19);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(344, 26);
            this.LblData.TabIndex = 45;
            this.LblData.Text = "Click on Node to see its data (h,zb,qb)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(963, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Node";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1096, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "Time";
            // 
            // TxtY
            // 
            this.TxtY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtY.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtY.Location = new System.Drawing.Point(1156, 17);
            this.TxtY.Name = "TxtY";
            this.TxtY.Size = new System.Drawing.Size(68, 30);
            this.TxtY.TabIndex = 42;
            this.TxtY.Text = "Y";
            this.TxtY.TextChanged += new System.EventHandler(this.TxtY_TextChanged);
            // 
            // TxtX
            // 
            this.TxtX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtX.Location = new System.Drawing.Point(1022, 18);
            this.TxtX.Name = "TxtX";
            this.TxtX.Size = new System.Drawing.Size(68, 30);
            this.TxtX.TabIndex = 41;
            this.TxtX.Text = "X";
            this.TxtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblY.ForeColor = System.Drawing.Color.White;
            this.LblY.Location = new System.Drawing.Point(504, 19);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(30, 26);
            this.LblY.TabIndex = 40;
            this.LblY.Text = "Y:";
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX.ForeColor = System.Drawing.Color.White;
            this.LblX.Location = new System.Drawing.Point(413, 19);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(32, 26);
            this.LblX.TabIndex = 39;
            this.LblX.Text = "X:";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Teal;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(294, 13);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(113, 37);
            this.BtnExit.TabIndex = 38;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ToolTipSeeData
            // 
            this.ToolTipSeeData.IsBalloon = true;
            // 
            // FrmSteadySchematic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 503);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSteadySchematic";
            this.Text = "Steady Schematic Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSteadySchematic_Load);
            this.Resize += new System.EventHandler(this.FrmSteadySchematic_Resize);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNode;
        private System.Windows.Forms.TextBox TxtNodeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTimeY;
        private System.Windows.Forms.Panel PanelCanvas;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.TextBox TxtY;
        private System.Windows.Forms.TextBox TxtX;
        private System.Windows.Forms.ToolTip ToolTipSeeData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblData;
    }
}