namespace HYDROLOGY
{
    partial class FrmUnsteadyRiverBedVariation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabParameters = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPorosity = new System.Windows.Forms.TextBox();
            this.LblCDash = new System.Windows.Forms.Label();
            this.TxtManning = new System.Windows.Forms.TextBox();
            this.TabFlow = new System.Windows.Forms.TabPage();
            this.Txtq_water = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtQ = new System.Windows.Forms.TextBox();
            this.Lblz = new System.Windows.Forms.Label();
            this.TabGeometry = new System.Windows.Forms.TabPage();
            this.LblD = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblL = new System.Windows.Forms.Label();
            this.TxtL = new System.Windows.Forms.TextBox();
            this.Tabqsconstant = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtqsb = new System.Windows.Forms.TextBox();
            this.LblThetaR = new System.Windows.Forms.Label();
            this.LblThetaS = new System.Windows.Forms.Label();
            this.Txtqsa = new System.Windows.Forms.TextBox();
            this.TabDiscritization = new System.Windows.Forms.TabPage();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.LblNode = new System.Windows.Forms.Label();
            this.TxtIntervalX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotalTime = new System.Windows.Forms.TextBox();
            this.LblTotalTime = new System.Windows.Forms.Label();
            this.TxtDelX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDelT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabInitial = new System.Windows.Forms.TabPage();
            this.TxtInitialqs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtInitialSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtInitialz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInitialh = new System.Windows.Forms.TextBox();
            this.TabBoundary = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBoudarySedimentq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoudaryWaterh = new System.Windows.Forms.TextBox();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColWaterDischarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBedDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCourantNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnIdentify = new System.Windows.Forms.Button();
            this.BtnProfilePlot = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabParameters.SuspendLayout();
            this.TabFlow.SuspendLayout();
            this.TabGeometry.SuspendLayout();
            this.Tabqsconstant.SuspendLayout();
            this.TabDiscritization.SuspendLayout();
            this.TabInitial.SuspendLayout();
            this.TabBoundary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabParameters);
            this.tabControl1.Controls.Add(this.TabFlow);
            this.tabControl1.Controls.Add(this.TabGeometry);
            this.tabControl1.Controls.Add(this.Tabqsconstant);
            this.tabControl1.Controls.Add(this.TabDiscritization);
            this.tabControl1.Controls.Add(this.TabInitial);
            this.tabControl1.Controls.Add(this.TabBoundary);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(60, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 252);
            this.tabControl1.TabIndex = 2;
            // 
            // TabParameters
            // 
            this.TabParameters.Controls.Add(this.label4);
            this.TabParameters.Controls.Add(this.TxtPorosity);
            this.TabParameters.Controls.Add(this.LblCDash);
            this.TabParameters.Controls.Add(this.TxtManning);
            this.TabParameters.Location = new System.Drawing.Point(4, 29);
            this.TabParameters.Name = "TabParameters";
            this.TabParameters.Size = new System.Drawing.Size(873, 219);
            this.TabParameters.TabIndex = 2;
            this.TabParameters.Text = "Parameters";
            this.TabParameters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Porosity of bed material, λ";
            // 
            // TxtPorosity
            // 
            this.TxtPorosity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorosity.Location = new System.Drawing.Point(313, 128);
            this.TxtPorosity.Name = "TxtPorosity";
            this.TxtPorosity.Size = new System.Drawing.Size(222, 30);
            this.TxtPorosity.TabIndex = 35;
            this.TxtPorosity.Text = "0.4";
            // 
            // LblCDash
            // 
            this.LblCDash.AutoSize = true;
            this.LblCDash.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCDash.ForeColor = System.Drawing.Color.Purple;
            this.LblCDash.Location = new System.Drawing.Point(43, 38);
            this.LblCDash.Name = "LblCDash";
            this.LblCDash.Size = new System.Drawing.Size(223, 26);
            this.LblCDash.TabIndex = 28;
            this.LblCDash.Text = "Manning\'s Coefficient, n";
            // 
            // TxtManning
            // 
            this.TxtManning.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtManning.Location = new System.Drawing.Point(313, 38);
            this.TxtManning.Name = "TxtManning";
            this.TxtManning.Size = new System.Drawing.Size(222, 30);
            this.TxtManning.TabIndex = 27;
            this.TxtManning.Text = "0.03";
            // 
            // TabFlow
            // 
            this.TabFlow.Controls.Add(this.Txtq_water);
            this.TabFlow.Controls.Add(this.label10);
            this.TabFlow.Controls.Add(this.TxtQ);
            this.TabFlow.Controls.Add(this.Lblz);
            this.TabFlow.Location = new System.Drawing.Point(4, 29);
            this.TabFlow.Name = "TabFlow";
            this.TabFlow.Size = new System.Drawing.Size(873, 219);
            this.TabFlow.TabIndex = 3;
            this.TabFlow.Text = "Flow";
            this.TabFlow.UseVisualStyleBackColor = true;
            // 
            // Txtq_water
            // 
            this.Txtq_water.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtq_water.ForeColor = System.Drawing.Color.Green;
            this.Txtq_water.Location = new System.Drawing.Point(410, 113);
            this.Txtq_water.Name = "Txtq_water";
            this.Txtq_water.Size = new System.Drawing.Size(255, 30);
            this.Txtq_water.TabIndex = 40;
            this.Txtq_water.TextChanged += new System.EventHandler(this.Txtq_water_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(46, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 26);
            this.label10.TabIndex = 39;
            this.label10.Text = "Steady Water Discharge, q (m3/s/m)";
            // 
            // TxtQ
            // 
            this.TxtQ.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQ.Location = new System.Drawing.Point(410, 54);
            this.TxtQ.Name = "TxtQ";
            this.TxtQ.Size = new System.Drawing.Size(255, 30);
            this.TxtQ.TabIndex = 38;
            this.TxtQ.Text = "15";
            this.TxtQ.TextChanged += new System.EventHandler(this.TxtQ_TextChanged);
            // 
            // Lblz
            // 
            this.Lblz.AutoSize = true;
            this.Lblz.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblz.ForeColor = System.Drawing.Color.Purple;
            this.Lblz.Location = new System.Drawing.Point(46, 54);
            this.Lblz.Name = "Lblz";
            this.Lblz.Size = new System.Drawing.Size(322, 26);
            this.Lblz.TabIndex = 37;
            this.Lblz.Text = "Steady Water Discharge, Q (m3/s)";
            // 
            // TabGeometry
            // 
            this.TabGeometry.Controls.Add(this.LblD);
            this.TabGeometry.Controls.Add(this.TxtB);
            this.TabGeometry.Controls.Add(this.LblL);
            this.TabGeometry.Controls.Add(this.TxtL);
            this.TabGeometry.Location = new System.Drawing.Point(4, 29);
            this.TabGeometry.Name = "TabGeometry";
            this.TabGeometry.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeometry.Size = new System.Drawing.Size(873, 219);
            this.TabGeometry.TabIndex = 1;
            this.TabGeometry.Text = "Geometry";
            this.TabGeometry.UseVisualStyleBackColor = true;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.ForeColor = System.Drawing.Color.Purple;
            this.LblD.Location = new System.Drawing.Point(46, 130);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(206, 26);
            this.LblD.TabIndex = 32;
            this.LblD.Text = "Width of Reach, B (m)";
            // 
            // TxtB
            // 
            this.TxtB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB.Location = new System.Drawing.Point(382, 130);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(210, 30);
            this.TxtB.TabIndex = 31;
            this.TxtB.Text = "50";
            this.TxtB.TextChanged += new System.EventHandler(this.TxtB_TextChanged);
            // 
            // LblL
            // 
            this.LblL.AutoSize = true;
            this.LblL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblL.ForeColor = System.Drawing.Color.Purple;
            this.LblL.Location = new System.Drawing.Point(46, 75);
            this.LblL.Name = "LblL";
            this.LblL.Size = new System.Drawing.Size(189, 26);
            this.LblL.TabIndex = 28;
            this.LblL.Text = "Lenght of Reach (m)";
            // 
            // TxtL
            // 
            this.TxtL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtL.Location = new System.Drawing.Point(382, 75);
            this.TxtL.Name = "TxtL";
            this.TxtL.Size = new System.Drawing.Size(210, 30);
            this.TxtL.TabIndex = 27;
            this.TxtL.Text = "300";
            this.TxtL.TextChanged += new System.EventHandler(this.TxtL_TextChanged);
            // 
            // Tabqsconstant
            // 
            this.Tabqsconstant.Controls.Add(this.label9);
            this.Tabqsconstant.Controls.Add(this.Txtqsb);
            this.Tabqsconstant.Controls.Add(this.LblThetaR);
            this.Tabqsconstant.Controls.Add(this.LblThetaS);
            this.Tabqsconstant.Controls.Add(this.Txtqsa);
            this.Tabqsconstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabqsconstant.ForeColor = System.Drawing.Color.Blue;
            this.Tabqsconstant.Location = new System.Drawing.Point(4, 29);
            this.Tabqsconstant.Name = "Tabqsconstant";
            this.Tabqsconstant.Padding = new System.Windows.Forms.Padding(3);
            this.Tabqsconstant.Size = new System.Drawing.Size(873, 219);
            this.Tabqsconstant.TabIndex = 0;
            this.Tabqsconstant.Text = "qs_constant";
            this.Tabqsconstant.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(527, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "qs = a (q/h) ^ b";
            // 
            // Txtqsb
            // 
            this.Txtqsb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtqsb.Location = new System.Drawing.Point(258, 112);
            this.Txtqsb.Name = "Txtqsb";
            this.Txtqsb.Size = new System.Drawing.Size(151, 30);
            this.Txtqsb.TabIndex = 20;
            this.Txtqsb.Text = "5";
            this.Txtqsb.TextChanged += new System.EventHandler(this.Txtqsb_TextChanged);
            // 
            // LblThetaR
            // 
            this.LblThetaR.AutoSize = true;
            this.LblThetaR.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThetaR.ForeColor = System.Drawing.Color.Purple;
            this.LblThetaR.Location = new System.Drawing.Point(63, 116);
            this.LblThetaR.Name = "LblThetaR";
            this.LblThetaR.Size = new System.Drawing.Size(23, 26);
            this.LblThetaR.TabIndex = 19;
            this.LblThetaR.Text = "b";
            // 
            // LblThetaS
            // 
            this.LblThetaS.AutoSize = true;
            this.LblThetaS.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThetaS.ForeColor = System.Drawing.Color.Purple;
            this.LblThetaS.Location = new System.Drawing.Point(63, 60);
            this.LblThetaS.Name = "LblThetaS";
            this.LblThetaS.Size = new System.Drawing.Size(22, 26);
            this.LblThetaS.TabIndex = 18;
            this.LblThetaS.Text = "a";
            // 
            // Txtqsa
            // 
            this.Txtqsa.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtqsa.Location = new System.Drawing.Point(258, 60);
            this.Txtqsa.Name = "Txtqsa";
            this.Txtqsa.Size = new System.Drawing.Size(151, 30);
            this.Txtqsa.TabIndex = 17;
            this.Txtqsa.Text = "0.00145";
            this.Txtqsa.TextChanged += new System.EventHandler(this.Txtqsa_TextChanged);
            // 
            // TabDiscritization
            // 
            this.TabDiscritization.Controls.Add(this.TxtSection);
            this.TabDiscritization.Controls.Add(this.LblNode);
            this.TabDiscritization.Controls.Add(this.TxtIntervalX);
            this.TabDiscritization.Controls.Add(this.label11);
            this.TabDiscritization.Controls.Add(this.TxtTotalTime);
            this.TabDiscritization.Controls.Add(this.LblTotalTime);
            this.TabDiscritization.Controls.Add(this.TxtDelX);
            this.TabDiscritization.Controls.Add(this.label2);
            this.TabDiscritization.Controls.Add(this.TxtDelT);
            this.TabDiscritization.Controls.Add(this.label1);
            this.TabDiscritization.Location = new System.Drawing.Point(4, 29);
            this.TabDiscritization.Name = "TabDiscritization";
            this.TabDiscritization.Size = new System.Drawing.Size(873, 219);
            this.TabDiscritization.TabIndex = 5;
            this.TabDiscritization.Text = "Discretization";
            this.TabDiscritization.UseVisualStyleBackColor = true;
            // 
            // TxtSection
            // 
            this.TxtSection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSection.ForeColor = System.Drawing.Color.Green;
            this.TxtSection.Location = new System.Drawing.Point(689, 163);
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.ReadOnly = true;
            this.TxtSection.Size = new System.Drawing.Size(119, 30);
            this.TxtSection.TabIndex = 60;
            this.TxtSection.Text = "10";
            // 
            // LblNode
            // 
            this.LblNode.AutoSize = true;
            this.LblNode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNode.ForeColor = System.Drawing.Color.Green;
            this.LblNode.Location = new System.Drawing.Point(455, 163);
            this.LblNode.Name = "LblNode";
            this.LblNode.Size = new System.Drawing.Size(213, 26);
            this.LblNode.TabIndex = 59;
            this.LblNode.Text = "Sections run from 0 to";
            // 
            // TxtIntervalX
            // 
            this.TxtIntervalX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalX.ForeColor = System.Drawing.Color.Green;
            this.TxtIntervalX.Location = new System.Drawing.Point(689, 103);
            this.TxtIntervalX.Name = "TxtIntervalX";
            this.TxtIntervalX.ReadOnly = true;
            this.TxtIntervalX.Size = new System.Drawing.Size(119, 30);
            this.TxtIntervalX.TabIndex = 58;
            this.TxtIntervalX.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(449, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = "Total Interval (qΔx), q =";
            // 
            // TxtTotalTime
            // 
            this.TxtTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalTime.Location = new System.Drawing.Point(689, 37);
            this.TxtTotalTime.Name = "TxtTotalTime";
            this.TxtTotalTime.Size = new System.Drawing.Size(113, 30);
            this.TxtTotalTime.TabIndex = 56;
            this.TxtTotalTime.Text = "50";
            this.TxtTotalTime.TextChanged += new System.EventHandler(this.TxtTotalTime_TextChanged);
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTime.ForeColor = System.Drawing.Color.Green;
            this.LblTotalTime.Location = new System.Drawing.Point(455, 38);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(196, 26);
            this.LblTotalTime.TabIndex = 55;
            this.LblTotalTime.Text = "Total Time (pΔt), p =";
            // 
            // TxtDelX
            // 
            this.TxtDelX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDelX.Location = new System.Drawing.Point(198, 103);
            this.TxtDelX.Name = "TxtDelX";
            this.TxtDelX.Size = new System.Drawing.Size(168, 30);
            this.TxtDelX.TabIndex = 46;
            this.TxtDelX.Text = "10";
            this.TxtDelX.TextChanged += new System.EventHandler(this.TxtDelX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(65, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Δx (m)";
            // 
            // TxtDelT
            // 
            this.TxtDelT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDelT.Location = new System.Drawing.Point(198, 41);
            this.TxtDelT.Name = "TxtDelT";
            this.TxtDelT.Size = new System.Drawing.Size(168, 30);
            this.TxtDelT.TabIndex = 44;
            this.TxtDelT.Text = "0.8";
            this.TxtDelT.TextChanged += new System.EventHandler(this.TxtDelT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Δt (sec)";
            // 
            // TabInitial
            // 
            this.TabInitial.Controls.Add(this.TxtInitialqs);
            this.TabInitial.Controls.Add(this.label6);
            this.TabInitial.Controls.Add(this.label8);
            this.TabInitial.Controls.Add(this.TxtInitialSo);
            this.TabInitial.Controls.Add(this.label5);
            this.TabInitial.Controls.Add(this.TxtInitialz);
            this.TabInitial.Controls.Add(this.label3);
            this.TabInitial.Controls.Add(this.TxtInitialh);
            this.TabInitial.Location = new System.Drawing.Point(4, 29);
            this.TabInitial.Name = "TabInitial";
            this.TabInitial.Size = new System.Drawing.Size(873, 219);
            this.TabInitial.TabIndex = 6;
            this.TabInitial.Text = "Initial";
            this.TabInitial.UseVisualStyleBackColor = true;
            // 
            // TxtInitialqs
            // 
            this.TxtInitialqs.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialqs.ForeColor = System.Drawing.Color.Green;
            this.TxtInitialqs.Location = new System.Drawing.Point(502, 174);
            this.TxtInitialqs.Name = "TxtInitialqs";
            this.TxtInitialqs.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialqs.TabIndex = 49;
            this.TxtInitialqs.TextChanged += new System.EventHandler(this.TxtInitialqs_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(29, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "Sediment discharge at boundary, qb0 (m3/s/m) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Bed slope at t = 0 (So)";
            // 
            // TxtInitialSo
            // 
            this.TxtInitialSo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialSo.Location = new System.Drawing.Point(502, 129);
            this.TxtInitialSo.Name = "TxtInitialSo";
            this.TxtInitialSo.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialSo.TabIndex = 43;
            this.TxtInitialSo.Text = "0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(29, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Bed depth at Initial (zeroth) node, z (m)";
            // 
            // TxtInitialz
            // 
            this.TxtInitialz.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialz.Location = new System.Drawing.Point(502, 82);
            this.TxtInitialz.Name = "TxtInitialz";
            this.TxtInitialz.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialz.TabIndex = 41;
            this.TxtInitialz.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Water height at Initial/Steady state, h (m)";
            // 
            // TxtInitialh
            // 
            this.TxtInitialh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialh.Location = new System.Drawing.Point(502, 30);
            this.TxtInitialh.Name = "TxtInitialh";
            this.TxtInitialh.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialh.TabIndex = 39;
            this.TxtInitialh.Text = "0.2";
            this.TxtInitialh.TextChanged += new System.EventHandler(this.TxtInitialh_TextChanged);
            // 
            // TabBoundary
            // 
            this.TabBoundary.Controls.Add(this.label12);
            this.TabBoundary.Controls.Add(this.TxtBoudarySedimentq);
            this.TabBoundary.Controls.Add(this.label7);
            this.TabBoundary.Controls.Add(this.TxtBoudaryWaterh);
            this.TabBoundary.Location = new System.Drawing.Point(4, 29);
            this.TabBoundary.Name = "TabBoundary";
            this.TabBoundary.Size = new System.Drawing.Size(873, 219);
            this.TabBoundary.TabIndex = 7;
            this.TabBoundary.Text = "Boundary";
            this.TabBoundary.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(34, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(445, 26);
            this.label12.TabIndex = 47;
            this.label12.Text = "Extra Sediment at fictitious node, Δqs (m3/s/m) ";
            // 
            // TxtBoudarySedimentq
            // 
            this.TxtBoudarySedimentq.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoudarySedimentq.Location = new System.Drawing.Point(495, 118);
            this.TxtBoudarySedimentq.Name = "TxtBoudarySedimentq";
            this.TxtBoudarySedimentq.Size = new System.Drawing.Size(171, 30);
            this.TxtBoudarySedimentq.TabIndex = 45;
            this.TxtBoudarySedimentq.Text = "0.00002";
            this.TxtBoudarySedimentq.TextChanged += new System.EventHandler(this.TxtBoudarySedimentq_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(34, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Water height at Boundary (m)";
            // 
            // TxtBoudaryWaterh
            // 
            this.TxtBoudaryWaterh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoudaryWaterh.ForeColor = System.Drawing.Color.Green;
            this.TxtBoudaryWaterh.Location = new System.Drawing.Point(495, 42);
            this.TxtBoudaryWaterh.Name = "TxtBoudaryWaterh";
            this.TxtBoudaryWaterh.ReadOnly = true;
            this.TxtBoudaryWaterh.Size = new System.Drawing.Size(171, 30);
            this.TxtBoudaryWaterh.TabIndex = 43;
            // 
            // dataGridViewMusking
            // 
            this.dataGridViewMusking.AllowUserToResizeColumns = false;
            this.dataGridViewMusking.AllowUserToResizeRows = false;
            this.dataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.ColSection,
            this.ColHeight,
            this.Colq,
            this.ColWaterDischarge,
            this.ColBedDepth,
            this.ColCourantNumber});
            this.dataGridViewMusking.Location = new System.Drawing.Point(60, 309);
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
            this.dataGridViewMusking.Size = new System.Drawing.Size(900, 383);
            this.dataGridViewMusking.TabIndex = 8;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTime.Width = 80;
            // 
            // ColSection
            // 
            this.ColSection.HeaderText = "Section";
            this.ColSection.Name = "ColSection";
            this.ColSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSection.Width = 80;
            // 
            // ColHeight
            // 
            this.ColHeight.HeaderText = "Height (m)";
            this.ColHeight.Name = "ColHeight";
            this.ColHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHeight.Width = 140;
            // 
            // Colq
            // 
            this.Colq.HeaderText = "Sediment Discharge, qs(m3/s/m)";
            this.Colq.Name = "Colq";
            this.Colq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colq.Width = 160;
            // 
            // ColWaterDischarge
            // 
            this.ColWaterDischarge.HeaderText = "Water Discharge q(m3/s/m)";
            this.ColWaterDischarge.Name = "ColWaterDischarge";
            this.ColWaterDischarge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColWaterDischarge.Width = 150;
            // 
            // ColBedDepth
            // 
            this.ColBedDepth.HeaderText = "Bed depth, z (m)";
            this.ColBedDepth.Name = "ColBedDepth";
            this.ColBedDepth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColBedDepth.Width = 150;
            // 
            // ColCourantNumber
            // 
            this.ColCourantNumber.HeaderText = "Courant Number";
            this.ColCourantNumber.Name = "ColCourantNumber";
            this.ColCourantNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCourantNumber.Width = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnExportToExcel);
            this.groupBox1.Controls.Add(this.BtnIdentify);
            this.groupBox1.Controls.Add(this.BtnProfilePlot);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(966, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 325);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // BtnIdentify
            // 
            this.BtnIdentify.BackColor = System.Drawing.Color.White;
            this.BtnIdentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIdentify.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnIdentify.Location = new System.Drawing.Point(13, 164);
            this.BtnIdentify.Name = "BtnIdentify";
            this.BtnIdentify.Size = new System.Drawing.Size(237, 37);
            this.BtnIdentify.TabIndex = 4;
            this.BtnIdentify.Text = "Identify invalid Cr";
            this.BtnIdentify.UseVisualStyleBackColor = false;
            this.BtnIdentify.Click += new System.EventHandler(this.BtnIdentify_Click);
            // 
            // BtnProfilePlot
            // 
            this.BtnProfilePlot.BackColor = System.Drawing.Color.White;
            this.BtnProfilePlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfilePlot.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnProfilePlot.Location = new System.Drawing.Point(13, 111);
            this.BtnProfilePlot.Name = "BtnProfilePlot";
            this.BtnProfilePlot.Size = new System.Drawing.Size(237, 37);
            this.BtnProfilePlot.TabIndex = 3;
            this.BtnProfilePlot.Text = "Plot Profile";
            this.BtnProfilePlot.UseVisualStyleBackColor = false;
            this.BtnProfilePlot.Click += new System.EventHandler(this.BtnProfilePlot_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.White;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnCalculate.Location = new System.Drawing.Point(13, 58);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(237, 37);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnExit.Location = new System.Drawing.Point(15, 261);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(237, 37);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.Teal;
            this.LblTitle.Location = new System.Drawing.Point(318, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(339, 26);
            this.LblTitle.TabIndex = 37;
            this.LblTitle.Text = "Unsteady Model - River Bed Variation";
            // 
            // TxtMsg
            // 
            this.TxtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMsg.Location = new System.Drawing.Point(966, 394);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.Size = new System.Drawing.Size(258, 327);
            this.TxtMsg.TabIndex = 47;
            this.TxtMsg.Text = "Identify Time and Section with \r\nCourant Number > 1\r\n\r\nFormat:\r\nT-S-CN = 0 - 2 - " +
    "3.2\r\nT = Time = 0\r\nS = Section = 2\r\nCN = Courant Number = 3.2";
            this.toolTip1.SetToolTip(this.TxtMsg, "Format: Time - Section - Courant Number");
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.BackColor = System.Drawing.Color.White;
            this.BtnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportToExcel.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnExportToExcel.Location = new System.Drawing.Point(13, 214);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(237, 37);
            this.BtnExportToExcel.TabIndex = 5;
            this.BtnExportToExcel.Text = "Export To Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = false;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // FrmUnsteadyRiverBedVariation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 746);
            this.Controls.Add(this.TxtMsg);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMusking);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUnsteadyRiverBedVariation";
            this.Text = "Unsteady River Bed Variation";
            this.Load += new System.EventHandler(this.FrmUnsteadyRiverBedVariation_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabParameters.ResumeLayout(false);
            this.TabParameters.PerformLayout();
            this.TabFlow.ResumeLayout(false);
            this.TabFlow.PerformLayout();
            this.TabGeometry.ResumeLayout(false);
            this.TabGeometry.PerformLayout();
            this.Tabqsconstant.ResumeLayout(false);
            this.Tabqsconstant.PerformLayout();
            this.TabDiscritization.ResumeLayout(false);
            this.TabDiscritization.PerformLayout();
            this.TabInitial.ResumeLayout(false);
            this.TabInitial.PerformLayout();
            this.TabBoundary.ResumeLayout(false);
            this.TabBoundary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabParameters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPorosity;
        private System.Windows.Forms.Label LblCDash;
        private System.Windows.Forms.TextBox TxtManning;
        private System.Windows.Forms.TabPage TabFlow;
        private System.Windows.Forms.TextBox TxtQ;
        private System.Windows.Forms.Label Lblz;
        private System.Windows.Forms.TabPage TabGeometry;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblL;
        private System.Windows.Forms.TextBox TxtL;
        private System.Windows.Forms.TabPage Tabqsconstant;
        private System.Windows.Forms.TextBox Txtqsb;
        private System.Windows.Forms.Label LblThetaR;
        private System.Windows.Forms.Label LblThetaS;
        private System.Windows.Forms.TextBox Txtqsa;
        private System.Windows.Forms.TabPage TabDiscritization;
        private System.Windows.Forms.TextBox TxtDelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDelT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtInitialz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInitialh;
        private System.Windows.Forms.TabPage TabBoundary;
        private System.Windows.Forms.TextBox TxtBoudarySedimentq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoudaryWaterh;
        private System.Windows.Forms.DataGridView dataGridViewMusking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnProfilePlot;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtInitialSo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtq_water;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.Label LblNode;
        private System.Windows.Forms.TextBox TxtIntervalX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalTime;
        private System.Windows.Forms.Label LblTotalTime;
        private System.Windows.Forms.Button BtnIdentify;
        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColWaterDischarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBedDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCourantNumber;
        private System.Windows.Forms.TextBox TxtInitialqs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnExportToExcel;
    }
}