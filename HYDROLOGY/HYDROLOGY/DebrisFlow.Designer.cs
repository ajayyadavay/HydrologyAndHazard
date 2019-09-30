namespace HYDROLOGY
{
    partial class FrmDebrisFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabParameters = new System.Windows.Forms.TabPage();
            this.TxtCstar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSoilDensity = new System.Windows.Forms.TextBox();
            this.Lblsoildensity = new System.Windows.Forms.Label();
            this.Lblwaterdensity = new System.Windows.Forms.Label();
            this.TxtWaterDensity = new System.Windows.Forms.TextBox();
            this.TxtParticleDiameter = new System.Windows.Forms.TextBox();
            this.Lblgamma = new System.Windows.Forms.Label();
            this.TabGeometry = new System.Windows.Forms.TabPage();
            this.LblD = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.LblL = new System.Windows.Forms.Label();
            this.TxtL = new System.Windows.Forms.TextBox();
            this.Tabtauyfparameter = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.Txtphi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Txtalpha = new System.Windows.Forms.TextBox();
            this.Txtkf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtkg = new System.Windows.Forms.TextBox();
            this.Txte = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.TabInitials = new System.Windows.Forms.TabPage();
            this.BtnImportInitials = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColNode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInitialM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInitialh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInitialZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInitialC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabBoundaries = new System.Windows.Forms.TabPage();
            this.BtnImportBoundaries = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColBoundaryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBoundaryM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBoundaryh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBoundaryZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBoundaryC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMusking = new System.Windows.Forms.DataGridView();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBedDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnExportToExcel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabParameters.SuspendLayout();
            this.TabGeometry.SuspendLayout();
            this.Tabtauyfparameter.SuspendLayout();
            this.TabDiscritization.SuspendLayout();
            this.TabInitials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabBoundaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTitle.Location = new System.Drawing.Point(390, 22);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(392, 26);
            this.LblTitle.TabIndex = 38;
            this.LblTitle.Text = "Debris Flow Simulation - Leap Frog Scheme";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabParameters);
            this.tabControl1.Controls.Add(this.TabGeometry);
            this.tabControl1.Controls.Add(this.Tabtauyfparameter);
            this.tabControl1.Controls.Add(this.TabDiscritization);
            this.tabControl1.Controls.Add(this.TabInitials);
            this.tabControl1.Controls.Add(this.TabBoundaries);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 252);
            this.tabControl1.TabIndex = 39;
            // 
            // TabParameters
            // 
            this.TabParameters.Controls.Add(this.TxtCstar);
            this.TabParameters.Controls.Add(this.label10);
            this.TabParameters.Controls.Add(this.TxtSoilDensity);
            this.TabParameters.Controls.Add(this.Lblsoildensity);
            this.TabParameters.Controls.Add(this.Lblwaterdensity);
            this.TabParameters.Controls.Add(this.TxtWaterDensity);
            this.TabParameters.Controls.Add(this.TxtParticleDiameter);
            this.TabParameters.Controls.Add(this.Lblgamma);
            this.TabParameters.Location = new System.Drawing.Point(4, 29);
            this.TabParameters.Name = "TabParameters";
            this.TabParameters.Size = new System.Drawing.Size(772, 219);
            this.TabParameters.TabIndex = 2;
            this.TabParameters.Text = "Parameters";
            this.TabParameters.UseVisualStyleBackColor = true;
            // 
            // TxtCstar
            // 
            this.TxtCstar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCstar.Location = new System.Drawing.Point(658, 124);
            this.TxtCstar.Name = "TxtCstar";
            this.TxtCstar.Size = new System.Drawing.Size(89, 30);
            this.TxtCstar.TabIndex = 44;
            this.TxtCstar.Text = "0.24";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(583, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 26);
            this.label10.TabIndex = 43;
            this.label10.Text = "C*";
            // 
            // TxtSoilDensity
            // 
            this.TxtSoilDensity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoilDensity.Location = new System.Drawing.Point(285, 121);
            this.TxtSoilDensity.Name = "TxtSoilDensity";
            this.TxtSoilDensity.Size = new System.Drawing.Size(102, 30);
            this.TxtSoilDensity.TabIndex = 42;
            this.TxtSoilDensity.Text = "2650";
            // 
            // Lblsoildensity
            // 
            this.Lblsoildensity.AutoSize = true;
            this.Lblsoildensity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsoildensity.ForeColor = System.Drawing.Color.Black;
            this.Lblsoildensity.Location = new System.Drawing.Point(30, 125);
            this.Lblsoildensity.Name = "Lblsoildensity";
            this.Lblsoildensity.Size = new System.Drawing.Size(227, 26);
            this.Lblsoildensity.TabIndex = 41;
            this.Lblsoildensity.Text = "Densit of soil, σ (Kg/m3)";
            // 
            // Lblwaterdensity
            // 
            this.Lblwaterdensity.AutoSize = true;
            this.Lblwaterdensity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblwaterdensity.ForeColor = System.Drawing.Color.Black;
            this.Lblwaterdensity.Location = new System.Drawing.Point(26, 38);
            this.Lblwaterdensity.Name = "Lblwaterdensity";
            this.Lblwaterdensity.Size = new System.Drawing.Size(244, 26);
            this.Lblwaterdensity.TabIndex = 40;
            this.Lblwaterdensity.Text = "Density of Water (Kg/m3)";
            // 
            // TxtWaterDensity
            // 
            this.TxtWaterDensity.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWaterDensity.Location = new System.Drawing.Point(285, 38);
            this.TxtWaterDensity.Name = "TxtWaterDensity";
            this.TxtWaterDensity.Size = new System.Drawing.Size(102, 30);
            this.TxtWaterDensity.TabIndex = 39;
            this.TxtWaterDensity.Text = "1000";
            // 
            // TxtParticleDiameter
            // 
            this.TxtParticleDiameter.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParticleDiameter.Location = new System.Drawing.Point(658, 38);
            this.TxtParticleDiameter.Name = "TxtParticleDiameter";
            this.TxtParticleDiameter.Size = new System.Drawing.Size(89, 30);
            this.TxtParticleDiameter.TabIndex = 38;
            this.TxtParticleDiameter.Text = "0.1";
            // 
            // Lblgamma
            // 
            this.Lblgamma.AutoSize = true;
            this.Lblgamma.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblgamma.ForeColor = System.Drawing.Color.Black;
            this.Lblgamma.Location = new System.Drawing.Point(403, 42);
            this.Lblgamma.Name = "Lblgamma";
            this.Lblgamma.Size = new System.Drawing.Size(223, 26);
            this.Lblgamma.TabIndex = 37;
            this.Lblgamma.Text = "Soil Particle\'s Dia, d (m)";
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
            this.TabGeometry.Size = new System.Drawing.Size(772, 219);
            this.TabGeometry.TabIndex = 1;
            this.TabGeometry.Text = "Geometry";
            this.TabGeometry.UseVisualStyleBackColor = true;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblD.ForeColor = System.Drawing.Color.Black;
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
            // 
            // LblL
            // 
            this.LblL.AutoSize = true;
            this.LblL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblL.ForeColor = System.Drawing.Color.Black;
            this.LblL.Location = new System.Drawing.Point(46, 75);
            this.LblL.Name = "LblL";
            this.LblL.Size = new System.Drawing.Size(210, 26);
            this.LblL.TabIndex = 28;
            this.LblL.Text = "Lenght of Reach, L (m)";
            // 
            // TxtL
            // 
            this.TxtL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtL.Location = new System.Drawing.Point(382, 75);
            this.TxtL.Name = "TxtL";
            this.TxtL.Size = new System.Drawing.Size(210, 30);
            this.TxtL.TabIndex = 27;
            this.TxtL.Text = "125";
            this.TxtL.TextChanged += new System.EventHandler(this.TxtL_TextChanged);
            // 
            // Tabtauyfparameter
            // 
            this.Tabtauyfparameter.Controls.Add(this.label21);
            this.Tabtauyfparameter.Controls.Add(this.Txtphi);
            this.Tabtauyfparameter.Controls.Add(this.label19);
            this.Tabtauyfparameter.Controls.Add(this.Txtalpha);
            this.Tabtauyfparameter.Controls.Add(this.Txtkf);
            this.Tabtauyfparameter.Controls.Add(this.label4);
            this.Tabtauyfparameter.Controls.Add(this.label9);
            this.Tabtauyfparameter.Controls.Add(this.Txtkg);
            this.Tabtauyfparameter.Controls.Add(this.Txte);
            this.Tabtauyfparameter.Controls.Add(this.label18);
            this.Tabtauyfparameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabtauyfparameter.ForeColor = System.Drawing.Color.Blue;
            this.Tabtauyfparameter.Location = new System.Drawing.Point(4, 29);
            this.Tabtauyfparameter.Name = "Tabtauyfparameter";
            this.Tabtauyfparameter.Padding = new System.Windows.Forms.Padding(3);
            this.Tabtauyfparameter.Size = new System.Drawing.Size(772, 219);
            this.Tabtauyfparameter.TabIndex = 0;
            this.Tabtauyfparameter.Text = "τy_f parameters";
            this.Tabtauyfparameter.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(358, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 26);
            this.label21.TabIndex = 54;
            this.label21.Text = "φ (degree)";
            // 
            // Txtphi
            // 
            this.Txtphi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtphi.Location = new System.Drawing.Point(487, 78);
            this.Txtphi.Name = "Txtphi";
            this.Txtphi.Size = new System.Drawing.Size(223, 30);
            this.Txtphi.TabIndex = 53;
            this.Txtphi.Text = "20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(359, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 26);
            this.label19.TabIndex = 50;
            this.label19.Text = "α";
            // 
            // Txtalpha
            // 
            this.Txtalpha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtalpha.Location = new System.Drawing.Point(487, 24);
            this.Txtalpha.Name = "Txtalpha";
            this.Txtalpha.Size = new System.Drawing.Size(223, 30);
            this.Txtalpha.TabIndex = 49;
            this.Txtalpha.Text = "0.1";
            // 
            // Txtkf
            // 
            this.Txtkf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtkf.Location = new System.Drawing.Point(157, 78);
            this.Txtkf.Name = "Txtkf";
            this.Txtkf.Size = new System.Drawing.Size(155, 30);
            this.Txtkf.TabIndex = 48;
            this.Txtkf.Text = "0.16";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "kf";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 26);
            this.label9.TabIndex = 46;
            this.label9.Text = "kg";
            // 
            // Txtkg
            // 
            this.Txtkg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtkg.Location = new System.Drawing.Point(157, 24);
            this.Txtkg.Name = "Txtkg";
            this.Txtkg.Size = new System.Drawing.Size(155, 30);
            this.Txtkg.TabIndex = 45;
            this.Txtkg.Text = "0.0828";
            // 
            // Txte
            // 
            this.Txte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txte.Location = new System.Drawing.Point(157, 135);
            this.Txte.Name = "Txte";
            this.Txte.Size = new System.Drawing.Size(155, 30);
            this.Txte.TabIndex = 44;
            this.Txte.Text = "0.8";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(29, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 26);
            this.label18.TabIndex = 43;
            this.label18.Text = "e";
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
            this.TabDiscritization.Size = new System.Drawing.Size(772, 219);
            this.TabDiscritization.TabIndex = 5;
            this.TabDiscritization.Text = "Discretization";
            this.TabDiscritization.UseVisualStyleBackColor = true;
            // 
            // TxtSection
            // 
            this.TxtSection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSection.ForeColor = System.Drawing.Color.Green;
            this.TxtSection.Location = new System.Drawing.Point(581, 151);
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.ReadOnly = true;
            this.TxtSection.Size = new System.Drawing.Size(95, 30);
            this.TxtSection.TabIndex = 60;
            this.TxtSection.Text = "10";
            // 
            // LblNode
            // 
            this.LblNode.AutoSize = true;
            this.LblNode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNode.ForeColor = System.Drawing.Color.Black;
            this.LblNode.Location = new System.Drawing.Point(341, 151);
            this.LblNode.Name = "LblNode";
            this.LblNode.Size = new System.Drawing.Size(213, 26);
            this.LblNode.TabIndex = 59;
            this.LblNode.Text = "Sections run from 0 to";
            // 
            // TxtIntervalX
            // 
            this.TxtIntervalX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalX.ForeColor = System.Drawing.Color.Green;
            this.TxtIntervalX.Location = new System.Drawing.Point(581, 94);
            this.TxtIntervalX.Name = "TxtIntervalX";
            this.TxtIntervalX.ReadOnly = true;
            this.TxtIntervalX.Size = new System.Drawing.Size(95, 30);
            this.TxtIntervalX.TabIndex = 58;
            this.TxtIntervalX.Text = "10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(341, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = "Total Interval (qΔx), q =";
            // 
            // TxtTotalTime
            // 
            this.TxtTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalTime.Location = new System.Drawing.Point(581, 35);
            this.TxtTotalTime.Name = "TxtTotalTime";
            this.TxtTotalTime.Size = new System.Drawing.Size(95, 30);
            this.TxtTotalTime.TabIndex = 56;
            this.TxtTotalTime.Text = "2";
            this.TxtTotalTime.TextChanged += new System.EventHandler(this.TxtTotalTime_TextChanged);
            // 
            // LblTotalTime
            // 
            this.LblTotalTime.AutoSize = true;
            this.LblTotalTime.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTime.ForeColor = System.Drawing.Color.Black;
            this.LblTotalTime.Location = new System.Drawing.Point(341, 39);
            this.LblTotalTime.Name = "LblTotalTime";
            this.LblTotalTime.Size = new System.Drawing.Size(196, 26);
            this.LblTotalTime.TabIndex = 55;
            this.LblTotalTime.Text = "Total Time (pΔt), p =";
            // 
            // TxtDelX
            // 
            this.TxtDelX.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDelX.Location = new System.Drawing.Point(132, 94);
            this.TxtDelX.Name = "TxtDelX";
            this.TxtDelX.Size = new System.Drawing.Size(168, 30);
            this.TxtDelX.TabIndex = 46;
            this.TxtDelX.Text = "25";
            this.TxtDelX.TextChanged += new System.EventHandler(this.TxtDelX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Δx (m)";
            // 
            // TxtDelT
            // 
            this.TxtDelT.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDelT.Location = new System.Drawing.Point(132, 35);
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Δt (hr)";
            // 
            // TabInitials
            // 
            this.TabInitials.Controls.Add(this.BtnImportInitials);
            this.TabInitials.Controls.Add(this.dataGridView1);
            this.TabInitials.Location = new System.Drawing.Point(4, 29);
            this.TabInitials.Name = "TabInitials";
            this.TabInitials.Size = new System.Drawing.Size(772, 219);
            this.TabInitials.TabIndex = 8;
            this.TabInitials.Text = "Initials";
            this.TabInitials.UseVisualStyleBackColor = true;
            // 
            // BtnImportInitials
            // 
            this.BtnImportInitials.BackColor = System.Drawing.Color.White;
            this.BtnImportInitials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImportInitials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportInitials.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnImportInitials.Location = new System.Drawing.Point(18, 78);
            this.BtnImportInitials.Name = "BtnImportInitials";
            this.BtnImportInitials.Size = new System.Drawing.Size(145, 37);
            this.BtnImportInitials.TabIndex = 3;
            this.BtnImportInitials.Text = "Import Initials";
            this.BtnImportInitials.UseVisualStyleBackColor = false;
            this.BtnImportInitials.Click += new System.EventHandler(this.BtnImportInitials_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNode,
            this.ColInitialM,
            this.ColInitialh,
            this.ColInitialZ,
            this.ColInitialC});
            this.dataGridView1.Location = new System.Drawing.Point(197, 19);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(525, 183);
            this.dataGridView1.TabIndex = 34;
            // 
            // ColNode
            // 
            this.ColNode.HeaderText = "Node";
            this.ColNode.Name = "ColNode";
            this.ColNode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInitialM
            // 
            this.ColInitialM.HeaderText = "M at t=0";
            this.ColInitialM.Name = "ColInitialM";
            this.ColInitialM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInitialh
            // 
            this.ColInitialh.HeaderText = "h at t=1";
            this.ColInitialh.Name = "ColInitialh";
            this.ColInitialh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInitialZ
            // 
            this.ColInitialZ.HeaderText = "Z at t=1";
            this.ColInitialZ.Name = "ColInitialZ";
            this.ColInitialZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInitialC
            // 
            this.ColInitialC.HeaderText = "C at t=1";
            this.ColInitialC.Name = "ColInitialC";
            this.ColInitialC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TabBoundaries
            // 
            this.TabBoundaries.Controls.Add(this.BtnImportBoundaries);
            this.TabBoundaries.Controls.Add(this.dataGridView2);
            this.TabBoundaries.Location = new System.Drawing.Point(4, 29);
            this.TabBoundaries.Name = "TabBoundaries";
            this.TabBoundaries.Size = new System.Drawing.Size(772, 219);
            this.TabBoundaries.TabIndex = 9;
            this.TabBoundaries.Text = "Boundaries";
            this.TabBoundaries.UseVisualStyleBackColor = true;
            // 
            // BtnImportBoundaries
            // 
            this.BtnImportBoundaries.BackColor = System.Drawing.Color.White;
            this.BtnImportBoundaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImportBoundaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImportBoundaries.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnImportBoundaries.Location = new System.Drawing.Point(20, 75);
            this.BtnImportBoundaries.Name = "BtnImportBoundaries";
            this.BtnImportBoundaries.Size = new System.Drawing.Size(145, 56);
            this.BtnImportBoundaries.TabIndex = 36;
            this.BtnImportBoundaries.Text = "Import Boundaries";
            this.BtnImportBoundaries.UseVisualStyleBackColor = false;
            this.BtnImportBoundaries.Click += new System.EventHandler(this.BtnImportBoundaries_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBoundaryTime,
            this.ColBoundaryM,
            this.ColBoundaryh,
            this.ColBoundaryZ,
            this.ColBoundaryC});
            this.dataGridView2.Location = new System.Drawing.Point(206, 18);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(525, 183);
            this.dataGridView2.TabIndex = 35;
            // 
            // ColBoundaryTime
            // 
            this.ColBoundaryTime.HeaderText = "Time";
            this.ColBoundaryTime.Name = "ColBoundaryTime";
            this.ColBoundaryTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBoundaryM
            // 
            this.ColBoundaryM.HeaderText = "M at node=0";
            this.ColBoundaryM.Name = "ColBoundaryM";
            this.ColBoundaryM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBoundaryh
            // 
            this.ColBoundaryh.HeaderText = "h at node=1";
            this.ColBoundaryh.Name = "ColBoundaryh";
            this.ColBoundaryh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBoundaryZ
            // 
            this.ColBoundaryZ.HeaderText = "Z at node=1";
            this.ColBoundaryZ.Name = "ColBoundaryZ";
            this.ColBoundaryZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBoundaryC
            // 
            this.ColBoundaryC.HeaderText = "C at node=1";
            this.ColBoundaryC.Name = "ColBoundaryC";
            this.ColBoundaryC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewMusking
            // 
            this.dataGridViewMusking.AllowUserToResizeColumns = false;
            this.dataGridViewMusking.AllowUserToResizeRows = false;
            this.dataGridViewMusking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMusking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMusking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTime,
            this.ColSection,
            this.ColM,
            this.ColHeight,
            this.ColC,
            this.ColBedDepth});
            this.dataGridViewMusking.Location = new System.Drawing.Point(31, 325);
            this.dataGridViewMusking.Name = "dataGridViewMusking";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusking.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMusking.RowHeadersVisible = false;
            this.dataGridViewMusking.Size = new System.Drawing.Size(803, 383);
            this.dataGridViewMusking.TabIndex = 40;
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
            // ColM
            // 
            this.ColM.HeaderText = "M";
            this.ColM.Name = "ColM";
            this.ColM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColM.Width = 150;
            // 
            // ColHeight
            // 
            this.ColHeight.HeaderText = "Height (m)";
            this.ColHeight.Name = "ColHeight";
            this.ColHeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHeight.Width = 140;
            // 
            // ColC
            // 
            this.ColC.HeaderText = "C";
            this.ColC.Name = "ColC";
            this.ColC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColC.Width = 160;
            // 
            // ColBedDepth
            // 
            this.ColBedDepth.HeaderText = "Bed depth, z (m)";
            this.ColBedDepth.Name = "ColBedDepth";
            this.ColBedDepth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColBedDepth.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnExportToExcel);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(894, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 224);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.White;
            this.BtnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalculate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnCalculate.Location = new System.Drawing.Point(35, 51);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(232, 37);
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
            this.BtnExit.Location = new System.Drawing.Point(35, 168);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(232, 37);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnExportToExcel
            // 
            this.BtnExportToExcel.BackColor = System.Drawing.Color.White;
            this.BtnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportToExcel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnExportToExcel.Location = new System.Drawing.Point(35, 111);
            this.BtnExportToExcel.Name = "BtnExportToExcel";
            this.BtnExportToExcel.Size = new System.Drawing.Size(232, 37);
            this.BtnExportToExcel.TabIndex = 3;
            this.BtnExportToExcel.Text = "Export To Excel";
            this.BtnExportToExcel.UseVisualStyleBackColor = false;
            this.BtnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcel_Click);
            // 
            // FrmDebrisFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 746);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMusking);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblTitle);
            this.Name = "FrmDebrisFlow";
            this.Text = "DebrisFlow";
            this.Load += new System.EventHandler(this.FrmDebrisFlow_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabParameters.ResumeLayout(false);
            this.TabParameters.PerformLayout();
            this.TabGeometry.ResumeLayout(false);
            this.TabGeometry.PerformLayout();
            this.Tabtauyfparameter.ResumeLayout(false);
            this.Tabtauyfparameter.PerformLayout();
            this.TabDiscritization.ResumeLayout(false);
            this.TabDiscritization.PerformLayout();
            this.TabInitials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabBoundaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabParameters;
        private System.Windows.Forms.TabPage TabGeometry;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label LblL;
        private System.Windows.Forms.TextBox TxtL;
        private System.Windows.Forms.TabPage Tabtauyfparameter;
        private System.Windows.Forms.TabPage TabDiscritization;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.Label LblNode;
        private System.Windows.Forms.TextBox TxtIntervalX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalTime;
        private System.Windows.Forms.Label LblTotalTime;
        private System.Windows.Forms.TextBox TxtDelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDelT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMusking;
        private System.Windows.Forms.TextBox TxtSoilDensity;
        private System.Windows.Forms.Label Lblsoildensity;
        private System.Windows.Forms.Label Lblwaterdensity;
        private System.Windows.Forms.TextBox TxtWaterDensity;
        private System.Windows.Forms.TextBox TxtParticleDiameter;
        private System.Windows.Forms.Label Lblgamma;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Txtphi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Txtalpha;
        private System.Windows.Forms.TextBox Txtkf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txtkg;
        private System.Windows.Forms.TextBox Txte;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtCstar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBedDepth;
        private System.Windows.Forms.TabPage TabInitials;
        private System.Windows.Forms.TabPage TabBoundaries;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInitialC;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoundaryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoundaryM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoundaryh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoundaryZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBoundaryC;
        private System.Windows.Forms.Button BtnImportInitials;
        private System.Windows.Forms.Button BtnImportBoundaries;
        private System.Windows.Forms.Button BtnExportToExcel;
    }
}