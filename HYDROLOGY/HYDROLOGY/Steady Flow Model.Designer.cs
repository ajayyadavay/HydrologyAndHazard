namespace HYDROLOGY
{
    partial class FrmSteadyFlowModel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabParameters = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPorosity = new System.Windows.Forms.TextBox();
            this.TxtSoilDensity = new System.Windows.Forms.TextBox();
            this.Lblbeta = new System.Windows.Forms.Label();
            this.LblPhi = new System.Windows.Forms.Label();
            this.TxtWaterDensity = new System.Windows.Forms.TextBox();
            this.TxtParticleDiameter = new System.Windows.Forms.TextBox();
            this.Lblgamma = new System.Windows.Forms.Label();
            this.LblCDash = new System.Windows.Forms.Label();
            this.TxtManning = new System.Windows.Forms.TextBox();
            this.TabFlow = new System.Windows.Forms.TabPage();
            this.TxtQ = new System.Windows.Forms.TextBox();
            this.Lblz = new System.Windows.Forms.Label();
            this.TabGeometry = new System.Windows.Forms.TabPage();
            this.LblD = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblL = new System.Windows.Forms.Label();
            this.TxtL = new System.Windows.Forms.TextBox();
            this.TabCritical = new System.Windows.Forms.TabPage();
            this.TxtUCStar = new System.Windows.Forms.TextBox();
            this.LblThetaR = new System.Windows.Forms.Label();
            this.LblThetaS = new System.Windows.Forms.Label();
            this.TxtTauCStar = new System.Windows.Forms.TextBox();
            this.TabDiscritization = new System.Windows.Forms.TabPage();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.LblNode = new System.Windows.Forms.Label();
            this.TxtIntervalX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTotalTime = new System.Windows.Forms.TextBox();
            this.LblTotalTime = new System.Windows.Forms.Label();
            this.TxtError = new System.Windows.Forms.TextBox();
            this.LblError = new System.Windows.Forms.Label();
            this.TxtDelX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDelT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabInitial = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtInitialz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtInitialh = new System.Windows.Forms.TextBox();
            this.TabBoundary = new System.Windows.Forms.TabPage();
            this.LblBedlevelBoundary = new System.Windows.Forms.Label();
            this.TxtBoundaryZb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoudarySedimentq = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoudaryWaterh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.BtnSchematic = new System.Windows.Forms.Button();
            this.BtnProfilePlot = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBedDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtMsg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabParameters.SuspendLayout();
            this.TabFlow.SuspendLayout();
            this.TabGeometry.SuspendLayout();
            this.TabCritical.SuspendLayout();
            this.TabDiscritization.SuspendLayout();
            this.TabInitial.SuspendLayout();
            this.TabBoundary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabParameters);
            this.tabControl1.Controls.Add(this.TabFlow);
            this.tabControl1.Controls.Add(this.TabGeometry);
            this.tabControl1.Controls.Add(this.TabCritical);
            this.tabControl1.Controls.Add(this.TabDiscritization);
            this.tabControl1.Controls.Add(this.TabInitial);
            this.tabControl1.Controls.Add(this.TabBoundary);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(69, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 252);
            this.tabControl1.TabIndex = 1;
            // 
            // TabParameters
            // 
            this.TabParameters.Controls.Add(this.label4);
            this.TabParameters.Controls.Add(this.TxtPorosity);
            this.TabParameters.Controls.Add(this.TxtSoilDensity);
            this.TabParameters.Controls.Add(this.Lblbeta);
            this.TabParameters.Controls.Add(this.LblPhi);
            this.TabParameters.Controls.Add(this.TxtWaterDensity);
            this.TabParameters.Controls.Add(this.TxtParticleDiameter);
            this.TabParameters.Controls.Add(this.Lblgamma);
            this.TabParameters.Controls.Add(this.LblCDash);
            this.TabParameters.Controls.Add(this.TxtManning);
            this.TabParameters.Location = new System.Drawing.Point(4, 29);
            this.TabParameters.Name = "TabParameters";
            this.TabParameters.Size = new System.Drawing.Size(808, 219);
            this.TabParameters.TabIndex = 2;
            this.TabParameters.Text = "Parameters";
            this.TabParameters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(628, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 52);
            this.label4.TabIndex = 36;
            this.label4.Text = "Porosity of \r\nbed material, λ";
            // 
            // TxtPorosity
            // 
            this.TxtPorosity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPorosity.Location = new System.Drawing.Point(633, 105);
            this.TxtPorosity.Name = "TxtPorosity";
            this.TxtPorosity.Size = new System.Drawing.Size(130, 30);
            this.TxtPorosity.TabIndex = 35;
            this.TxtPorosity.Text = "0.4";
            // 
            // TxtSoilDensity
            // 
            this.TxtSoilDensity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoilDensity.Location = new System.Drawing.Point(48, 161);
            this.TxtSoilDensity.Name = "TxtSoilDensity";
            this.TxtSoilDensity.Size = new System.Drawing.Size(223, 30);
            this.TxtSoilDensity.TabIndex = 34;
            this.TxtSoilDensity.Text = "2650";
            this.TxtSoilDensity.TextChanged += new System.EventHandler(this.TxtSoilDensity_TextChanged);
            // 
            // Lblbeta
            // 
            this.Lblbeta.AutoSize = true;
            this.Lblbeta.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbeta.ForeColor = System.Drawing.Color.Green;
            this.Lblbeta.Location = new System.Drawing.Point(44, 127);
            this.Lblbeta.Name = "Lblbeta";
            this.Lblbeta.Size = new System.Drawing.Size(227, 26);
            this.Lblbeta.TabIndex = 33;
            this.Lblbeta.Text = "Densit of soil, σ (Kg/m3)";
            // 
            // LblPhi
            // 
            this.LblPhi.AutoSize = true;
            this.LblPhi.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhi.ForeColor = System.Drawing.Color.Green;
            this.LblPhi.Location = new System.Drawing.Point(356, 38);
            this.LblPhi.Name = "LblPhi";
            this.LblPhi.Size = new System.Drawing.Size(244, 26);
            this.LblPhi.TabIndex = 32;
            this.LblPhi.Text = "Density of Water (Kg/m3)";
            // 
            // TxtWaterDensity
            // 
            this.TxtWaterDensity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWaterDensity.Location = new System.Drawing.Point(361, 72);
            this.TxtWaterDensity.Name = "TxtWaterDensity";
            this.TxtWaterDensity.Size = new System.Drawing.Size(239, 30);
            this.TxtWaterDensity.TabIndex = 31;
            this.TxtWaterDensity.Text = "1000";
            this.TxtWaterDensity.TextChanged += new System.EventHandler(this.TxtWaterDensity_TextChanged);
            // 
            // TxtParticleDiameter
            // 
            this.TxtParticleDiameter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParticleDiameter.Location = new System.Drawing.Point(361, 156);
            this.TxtParticleDiameter.Name = "TxtParticleDiameter";
            this.TxtParticleDiameter.Size = new System.Drawing.Size(239, 30);
            this.TxtParticleDiameter.TabIndex = 30;
            this.TxtParticleDiameter.Text = "0.0005";
            this.TxtParticleDiameter.TextChanged += new System.EventHandler(this.TxtParticleDiameter_TextChanged);
            // 
            // Lblgamma
            // 
            this.Lblgamma.AutoSize = true;
            this.Lblgamma.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblgamma.ForeColor = System.Drawing.Color.Green;
            this.Lblgamma.Location = new System.Drawing.Point(367, 127);
            this.Lblgamma.Name = "Lblgamma";
            this.Lblgamma.Size = new System.Drawing.Size(223, 26);
            this.Lblgamma.TabIndex = 29;
            this.Lblgamma.Text = "Soil Particle\'s Dia, d (m)";
            // 
            // LblCDash
            // 
            this.LblCDash.AutoSize = true;
            this.LblCDash.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCDash.ForeColor = System.Drawing.Color.Green;
            this.LblCDash.Location = new System.Drawing.Point(43, 38);
            this.LblCDash.Name = "LblCDash";
            this.LblCDash.Size = new System.Drawing.Size(223, 26);
            this.LblCDash.TabIndex = 28;
            this.LblCDash.Text = "Manning\'s Coefficient, n";
            // 
            // TxtManning
            // 
            this.TxtManning.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtManning.Location = new System.Drawing.Point(49, 72);
            this.TxtManning.Name = "TxtManning";
            this.TxtManning.Size = new System.Drawing.Size(222, 30);
            this.TxtManning.TabIndex = 27;
            this.TxtManning.Text = "0.03";
            this.TxtManning.TextChanged += new System.EventHandler(this.TxtManning_TextChanged);
            // 
            // TabFlow
            // 
            this.TabFlow.Controls.Add(this.TxtQ);
            this.TabFlow.Controls.Add(this.Lblz);
            this.TabFlow.Location = new System.Drawing.Point(4, 29);
            this.TabFlow.Name = "TabFlow";
            this.TabFlow.Size = new System.Drawing.Size(808, 219);
            this.TabFlow.TabIndex = 3;
            this.TabFlow.Text = "Flow";
            this.TabFlow.UseVisualStyleBackColor = true;
            // 
            // TxtQ
            // 
            this.TxtQ.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQ.Location = new System.Drawing.Point(359, 86);
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
            this.Lblz.ForeColor = System.Drawing.Color.Green;
            this.Lblz.Location = new System.Drawing.Point(48, 87);
            this.Lblz.Name = "Lblz";
            this.Lblz.Size = new System.Drawing.Size(260, 26);
            this.Lblz.TabIndex = 37;
            this.Lblz.Text = "Steady Discharge, Q (m3/s)";
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
            this.TabGeometry.Size = new System.Drawing.Size(808, 219);
            this.TabGeometry.TabIndex = 1;
            this.TabGeometry.Text = "Geometry";
            this.TabGeometry.UseVisualStyleBackColor = true;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.ForeColor = System.Drawing.Color.Green;
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
            this.LblL.ForeColor = System.Drawing.Color.Green;
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
            // TabCritical
            // 
            this.TabCritical.Controls.Add(this.TxtUCStar);
            this.TabCritical.Controls.Add(this.LblThetaR);
            this.TabCritical.Controls.Add(this.LblThetaS);
            this.TabCritical.Controls.Add(this.TxtTauCStar);
            this.TabCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCritical.ForeColor = System.Drawing.Color.Blue;
            this.TabCritical.Location = new System.Drawing.Point(4, 29);
            this.TabCritical.Name = "TabCritical";
            this.TabCritical.Padding = new System.Windows.Forms.Padding(3);
            this.TabCritical.Size = new System.Drawing.Size(808, 219);
            this.TabCritical.TabIndex = 0;
            this.TabCritical.Text = "Critical";
            this.TabCritical.UseVisualStyleBackColor = true;
            // 
            // TxtUCStar
            // 
            this.TxtUCStar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUCStar.Location = new System.Drawing.Point(258, 112);
            this.TxtUCStar.Name = "TxtUCStar";
            this.TxtUCStar.Size = new System.Drawing.Size(151, 30);
            this.TxtUCStar.TabIndex = 20;
            // 
            // LblThetaR
            // 
            this.LblThetaR.AutoSize = true;
            this.LblThetaR.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThetaR.ForeColor = System.Drawing.Color.Green;
            this.LblThetaR.Location = new System.Drawing.Point(63, 116);
            this.LblThetaR.Name = "LblThetaR";
            this.LblThetaR.Size = new System.Drawing.Size(101, 26);
            this.LblThetaR.TabIndex = 19;
            this.LblThetaR.Text = "U_C_Star";
            // 
            // LblThetaS
            // 
            this.LblThetaS.AutoSize = true;
            this.LblThetaS.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThetaS.ForeColor = System.Drawing.Color.Green;
            this.LblThetaS.Location = new System.Drawing.Point(63, 60);
            this.LblThetaS.Name = "LblThetaS";
            this.LblThetaS.Size = new System.Drawing.Size(120, 26);
            this.LblThetaS.TabIndex = 18;
            this.LblThetaS.Text = "Tau_C_Star";
            // 
            // TxtTauCStar
            // 
            this.TxtTauCStar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTauCStar.Location = new System.Drawing.Point(258, 60);
            this.TxtTauCStar.Name = "TxtTauCStar";
            this.TxtTauCStar.Size = new System.Drawing.Size(151, 30);
            this.TxtTauCStar.TabIndex = 17;
            this.TxtTauCStar.Text = "0.02";
            this.TxtTauCStar.TextChanged += new System.EventHandler(this.TxtTauCStar_TextChanged);
            // 
            // TabDiscritization
            // 
            this.TabDiscritization.Controls.Add(this.TxtSection);
            this.TabDiscritization.Controls.Add(this.LblNode);
            this.TabDiscritization.Controls.Add(this.TxtIntervalX);
            this.TabDiscritization.Controls.Add(this.label8);
            this.TabDiscritization.Controls.Add(this.TxtTotalTime);
            this.TabDiscritization.Controls.Add(this.LblTotalTime);
            this.TabDiscritization.Controls.Add(this.TxtError);
            this.TabDiscritization.Controls.Add(this.LblError);
            this.TabDiscritization.Controls.Add(this.TxtDelX);
            this.TabDiscritization.Controls.Add(this.label2);
            this.TabDiscritization.Controls.Add(this.TxtDelT);
            this.TabDiscritization.Controls.Add(this.label1);
            this.TabDiscritization.Location = new System.Drawing.Point(4, 29);
            this.TabDiscritization.Name = "TabDiscritization";
            this.TabDiscritization.Size = new System.Drawing.Size(808, 219);
            this.TabDiscritization.TabIndex = 5;
            this.TabDiscritization.Text = "Discretization";
            this.TabDiscritization.UseVisualStyleBackColor = true;
            // 
            // TxtSection
            // 
            this.TxtSection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSection.Location = new System.Drawing.Point(665, 134);
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.ReadOnly = true;
            this.TxtSection.Size = new System.Drawing.Size(119, 30);
            this.TxtSection.TabIndex = 54;
            this.TxtSection.Text = "10";
            // 
            // LblNode
            // 
            this.LblNode.AutoSize = true;
            this.LblNode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNode.ForeColor = System.Drawing.Color.Green;
            this.LblNode.Location = new System.Drawing.Point(431, 134);
            this.LblNode.Name = "LblNode";
            this.LblNode.Size = new System.Drawing.Size(213, 26);
            this.LblNode.TabIndex = 53;
            this.LblNode.Text = "Sections run from 0 to";
            // 
            // TxtIntervalX
            // 
            this.TxtIntervalX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalX.Location = new System.Drawing.Point(665, 89);
            this.TxtIntervalX.Name = "TxtIntervalX";
            this.TxtIntervalX.ReadOnly = true;
            this.TxtIntervalX.Size = new System.Drawing.Size(119, 30);
            this.TxtIntervalX.TabIndex = 52;
            this.TxtIntervalX.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(431, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 26);
            this.label8.TabIndex = 51;
            this.label8.Text = "Total Interval (qΔx), q =";
            // 
            // TxtTotalTime
            // 
            this.TxtTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalTime.Location = new System.Drawing.Point(665, 40);
            this.TxtTotalTime.Name = "TxtTotalTime";
            this.TxtTotalTime.Size = new System.Drawing.Size(113, 30);
            this.TxtTotalTime.TabIndex = 50;
            this.TxtTotalTime.Text = "10";
            this.TxtTotalTime.TextChanged += new System.EventHandler(this.TxtTotalTime_TextChanged);
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTime.ForeColor = System.Drawing.Color.Green;
            this.LblTotalTime.Location = new System.Drawing.Point(431, 41);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(196, 26);
            this.LblTotalTime.TabIndex = 49;
            this.LblTotalTime.Text = "Total Time (pΔt), p =";
            // 
            // TxtError
            // 
            this.TxtError.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtError.Location = new System.Drawing.Point(198, 160);
            this.TxtError.Name = "TxtError";
            this.TxtError.Size = new System.Drawing.Size(168, 30);
            this.TxtError.TabIndex = 48;
            this.TxtError.Text = "0.05";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Green;
            this.LblError.Location = new System.Drawing.Point(77, 164);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(61, 26);
            this.LblError.TabIndex = 47;
            this.LblError.Text = "Error";
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
            this.label2.ForeColor = System.Drawing.Color.Green;
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
            this.TxtDelT.Text = "1";
            this.TxtDelT.TextChanged += new System.EventHandler(this.TxtDelT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Δt (hr)";
            // 
            // TabInitial
            // 
            this.TabInitial.Controls.Add(this.label5);
            this.TabInitial.Controls.Add(this.TxtInitialz);
            this.TabInitial.Controls.Add(this.label3);
            this.TabInitial.Controls.Add(this.TxtInitialh);
            this.TabInitial.Location = new System.Drawing.Point(4, 29);
            this.TabInitial.Name = "TabInitial";
            this.TabInitial.Size = new System.Drawing.Size(808, 219);
            this.TabInitial.TabIndex = 6;
            this.TabInitial.Text = "Initial";
            this.TabInitial.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(29, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Bed level at node = 0, t = 0, z (m)";
            // 
            // TxtInitialz
            // 
            this.TxtInitialz.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialz.Location = new System.Drawing.Point(443, 112);
            this.TxtInitialz.Name = "TxtInitialz";
            this.TxtInitialz.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialz.TabIndex = 41;
            this.TxtInitialz.Text = "50";
            this.TxtInitialz.TextChanged += new System.EventHandler(this.TxtInitialz_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "Water height at Initial/Steady state, h (m)";
            // 
            // TxtInitialh
            // 
            this.TxtInitialh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInitialh.Location = new System.Drawing.Point(443, 40);
            this.TxtInitialh.Name = "TxtInitialh";
            this.TxtInitialh.Size = new System.Drawing.Size(171, 30);
            this.TxtInitialh.TabIndex = 39;
            this.TxtInitialh.Text = "0.25";
            // 
            // TabBoundary
            // 
            this.TabBoundary.Controls.Add(this.LblBedlevelBoundary);
            this.TabBoundary.Controls.Add(this.TxtBoundaryZb);
            this.TabBoundary.Controls.Add(this.label6);
            this.TabBoundary.Controls.Add(this.TxtBoudarySedimentq);
            this.TabBoundary.Controls.Add(this.label7);
            this.TabBoundary.Controls.Add(this.TxtBoudaryWaterh);
            this.TabBoundary.Location = new System.Drawing.Point(4, 29);
            this.TabBoundary.Name = "TabBoundary";
            this.TabBoundary.Size = new System.Drawing.Size(808, 219);
            this.TabBoundary.TabIndex = 7;
            this.TabBoundary.Text = "Boundary";
            this.TabBoundary.UseVisualStyleBackColor = true;
            // 
            // LblBedlevelBoundary
            // 
            this.LblBedlevelBoundary.AutoSize = true;
            this.LblBedlevelBoundary.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBedlevelBoundary.ForeColor = System.Drawing.Color.Green;
            this.LblBedlevelBoundary.Location = new System.Drawing.Point(43, 164);
            this.LblBedlevelBoundary.Name = "LblBedlevelBoundary";
            this.LblBedlevelBoundary.Size = new System.Drawing.Size(518, 26);
            this.LblBedlevelBoundary.TabIndex = 48;
            this.LblBedlevelBoundary.Text = "Bed level at all node =0 (Boundary considered rigid), z (m)";
            // 
            // TxtBoundaryZb
            // 
            this.TxtBoundaryZb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoundaryZb.Location = new System.Drawing.Point(567, 164);
            this.TxtBoundaryZb.Name = "TxtBoundaryZb";
            this.TxtBoundaryZb.ReadOnly = true;
            this.TxtBoundaryZb.Size = new System.Drawing.Size(171, 30);
            this.TxtBoundaryZb.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(43, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(422, 26);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sediment discharge at boundary, qb (m3/s/m) ";
            // 
            // TxtBoudarySedimentq
            // 
            this.TxtBoudarySedimentq.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoudarySedimentq.Location = new System.Drawing.Point(567, 104);
            this.TxtBoudarySedimentq.Name = "TxtBoudarySedimentq";
            this.TxtBoudarySedimentq.Size = new System.Drawing.Size(171, 30);
            this.TxtBoudarySedimentq.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(43, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 26);
            this.label7.TabIndex = 44;
            this.label7.Text = "Water height at Boundary (m)";
            // 
            // TxtBoudaryWaterh
            // 
            this.TxtBoudaryWaterh.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoudaryWaterh.Location = new System.Drawing.Point(567, 45);
            this.TxtBoudaryWaterh.Name = "TxtBoudaryWaterh";
            this.TxtBoudaryWaterh.Size = new System.Drawing.Size(171, 30);
            this.TxtBoudaryWaterh.TabIndex = 43;
            this.TxtBoudaryWaterh.Text = "0.4";
            this.TxtBoudaryWaterh.TextChanged += new System.EventHandler(this.TxtBoudaryWaterh_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnExportToExcel);
            this.groupBox1.Controls.Add(this.BtnSchematic);
            this.groupBox1.Controls.Add(this.BtnProfilePlot);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(902, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.BackColor = System.Drawing.Color.White;
            this.BtnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportToExcel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnExportToExcel.Location = new System.Drawing.Point(28, 205);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(265, 37);
            this.BtnExportToExcel.TabIndex = 5;
            this.BtnExportToExcel.Text = "Export To Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = false;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // BtnSchematic
            // 
            this.BtnSchematic.BackColor = System.Drawing.Color.White;
            this.BtnSchematic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSchematic.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSchematic.Location = new System.Drawing.Point(28, 153);
            this.BtnSchematic.Name = "BtnSchematic";
            this.BtnSchematic.Size = new System.Drawing.Size(265, 37);
            this.BtnSchematic.TabIndex = 4;
            this.BtnSchematic.Text = "Schematic Grid";
            this.BtnSchematic.UseVisualStyleBackColor = false;
            this.BtnSchematic.Click += new System.EventHandler(this.BtnSchematic_Click);
            // 
            // BtnProfilePlot
            // 
            this.BtnProfilePlot.BackColor = System.Drawing.Color.White;
            this.BtnProfilePlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProfilePlot.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnProfilePlot.Location = new System.Drawing.Point(28, 101);
            this.BtnProfilePlot.Name = "BtnProfilePlot";
            this.BtnProfilePlot.Size = new System.Drawing.Size(265, 37);
            this.BtnProfilePlot.TabIndex = 3;
            this.BtnProfilePlot.Text = "Plot Profile";
            this.BtnProfilePlot.UseVisualStyleBackColor = false;
            this.BtnProfilePlot.Click += new System.EventHandler(this.BtnProfilePlot_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.White;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnCalculate.Location = new System.Drawing.Point(28, 49);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(265, 37);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.Location = new System.Drawing.Point(28, 259);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(265, 37);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.ColBedDepth,
            this.ColFr});
            this.dataGridViewMusking.Location = new System.Drawing.Point(69, 287);
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
            this.dataGridViewMusking.Size = new System.Drawing.Size(816, 409);
            this.dataGridViewMusking.TabIndex = 7;
            // 
            // ColTime
            // 
            this.ColTime.HeaderText = "Time";
            this.ColTime.Name = "ColTime";
            this.ColTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTime.Width = 85;
            // 
            // ColSection
            // 
            this.ColSection.HeaderText = "Section";
            this.ColSection.Name = "ColSection";
            this.ColSection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSection.Width = 85;
            // 
            // ColHeight
            // 
            this.ColHeight.HeaderText = "Height (m)";
            this.ColHeight.Name = "ColHeight";
            this.ColHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHeight.Width = 125;
            // 
            // Colq
            // 
            this.Colq.HeaderText = "Sediment Discharge, q (m3/s/m)";
            this.Colq.Name = "Colq";
            this.Colq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Colq.Width = 215;
            // 
            // ColBedDepth
            // 
            this.ColBedDepth.HeaderText = "Bed depth, z (m)";
            this.ColBedDepth.Name = "ColBedDepth";
            this.ColBedDepth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColBedDepth.Width = 175;
            // 
            // ColFr
            // 
            this.ColFr.HeaderText = "Fr";
            this.ColFr.Name = "ColFr";
            this.ColFr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TxtMsg
            // 
            this.TxtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtMsg.Location = new System.Drawing.Point(902, 395);
            this.TxtMsg.Multiline = true;
            this.TxtMsg.Name = "TxtMsg";
            this.TxtMsg.Size = new System.Drawing.Size(311, 301);
            this.TxtMsg.TabIndex = 48;
            // 
            // FrmSteadyFlowModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 736);
            this.Controls.Add(this.TxtMsg);
            this.Controls.Add(this.dataGridViewMusking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmSteadyFlowModel";
            this.Text = "River Bed Variation - Steady Flow Model";
            this.Load += new System.EventHandler(this.FrmSteadyFlowModel_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabParameters.ResumeLayout(false);
            this.TabParameters.PerformLayout();
            this.TabFlow.ResumeLayout(false);
            this.TabFlow.PerformLayout();
            this.TabGeometry.ResumeLayout(false);
            this.TabGeometry.PerformLayout();
            this.TabCritical.ResumeLayout(false);
            this.TabCritical.PerformLayout();
            this.TabDiscritization.ResumeLayout(false);
            this.TabDiscritization.PerformLayout();
            this.TabInitial.ResumeLayout(false);
            this.TabInitial.PerformLayout();
            this.TabBoundary.ResumeLayout(false);
            this.TabBoundary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCritical;
        private System.Windows.Forms.TextBox TxtUCStar;
        private System.Windows.Forms.Label LblThetaR;
        private System.Windows.Forms.Label LblThetaS;
        private System.Windows.Forms.TextBox TxtTauCStar;
        private System.Windows.Forms.TabPage TabGeometry;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblL;
        private System.Windows.Forms.TextBox TxtL;
        private System.Windows.Forms.TabPage TabParameters;
        private System.Windows.Forms.TextBox TxtSoilDensity;
        private System.Windows.Forms.Label Lblbeta;
        private System.Windows.Forms.Label LblPhi;
        private System.Windows.Forms.TextBox TxtWaterDensity;
        private System.Windows.Forms.TextBox TxtParticleDiameter;
        private System.Windows.Forms.Label Lblgamma;
        private System.Windows.Forms.Label LblCDash;
        private System.Windows.Forms.TextBox TxtManning;
        private System.Windows.Forms.TabPage TabFlow;
        private System.Windows.Forms.TextBox TxtQ;
        private System.Windows.Forms.Label Lblz;
        private System.Windows.Forms.TabPage TabDiscritization;
        private System.Windows.Forms.TabPage TabInitial;
        private System.Windows.Forms.TabPage TabBoundary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPorosity;
        private System.Windows.Forms.TextBox TxtError;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TxtDelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDelT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtInitialh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtInitialz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBoudarySedimentq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoudaryWaterh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGridViewMusking;
        private System.Windows.Forms.Button BtnProfilePlot;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.Label LblNode;
        private System.Windows.Forms.TextBox TxtIntervalX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTotalTime;
        private System.Windows.Forms.Label LblTotalTime;
        private System.Windows.Forms.Label LblBedlevelBoundary;
        private System.Windows.Forms.TextBox TxtBoundaryZb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBedDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFr;
        private System.Windows.Forms.Button BtnSchematic;
        private System.Windows.Forms.TextBox TxtMsg;
        private System.Windows.Forms.Button BtnExportToExcel;
    }
}