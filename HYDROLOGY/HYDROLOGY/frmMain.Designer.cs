namespace HYDROLOGY
{
    partial class frm_main
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
            this.pannel_left = new System.Windows.Forms.Panel();
            this.Btn_WIH = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.Btn_proceed = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_hydrology = new System.Windows.Forms.Button();
            this.ComboBoxMethod = new System.Windows.Forms.ComboBox();
            this.Lblcaption2 = new System.Windows.Forms.Label();
            this.ComboBoxMain = new System.Windows.Forms.ComboBox();
            this.Lblcaption1 = new System.Windows.Forms.Label();
            this.pannel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannel_left
            // 
            this.pannel_left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pannel_left.BackColor = System.Drawing.Color.Black;
            this.pannel_left.Controls.Add(this.Btn_WIH);
            this.pannel_left.Controls.Add(this.BtnAbout);
            this.pannel_left.Controls.Add(this.Btn_proceed);
            this.pannel_left.Controls.Add(this.Btn_exit);
            this.pannel_left.Controls.Add(this.Btn_hydrology);
            this.pannel_left.Location = new System.Drawing.Point(-1, -1);
            this.pannel_left.Name = "pannel_left";
            this.pannel_left.Size = new System.Drawing.Size(214, 453);
            this.pannel_left.TabIndex = 0;
            // 
            // Btn_WIH
            // 
            this.Btn_WIH.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_WIH.FlatAppearance.BorderSize = 0;
            this.Btn_WIH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_WIH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_WIH.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_WIH.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_WIH.Location = new System.Drawing.Point(0, 155);
            this.Btn_WIH.Name = "Btn_WIH";
            this.Btn_WIH.Size = new System.Drawing.Size(214, 33);
            this.Btn_WIH.TabIndex = 5;
            this.Btn_WIH.Text = "HAZARD";
            this.Btn_WIH.UseVisualStyleBackColor = true;
            this.Btn_WIH.Click += new System.EventHandler(this.Btn_WIH_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnAbout.Location = new System.Drawing.Point(0, 350);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(214, 33);
            this.BtnAbout.TabIndex = 4;
            this.BtnAbout.Text = "ABOUT";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // Btn_proceed
            // 
            this.Btn_proceed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_proceed.FlatAppearance.BorderSize = 0;
            this.Btn_proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_proceed.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_proceed.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_proceed.Location = new System.Drawing.Point(0, 291);
            this.Btn_proceed.Name = "Btn_proceed";
            this.Btn_proceed.Size = new System.Drawing.Size(214, 33);
            this.Btn_proceed.TabIndex = 3;
            this.Btn_proceed.Text = "PROCEED";
            this.Btn_proceed.UseVisualStyleBackColor = true;
            this.Btn_proceed.Click += new System.EventHandler(this.Btn_proceed_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_exit.FlatAppearance.BorderSize = 0;
            this.Btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.SystemColors.Window;
            this.Btn_exit.Location = new System.Drawing.Point(0, 408);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(214, 33);
            this.Btn_exit.TabIndex = 2;
            this.Btn_exit.Text = "EXIT";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Btn_hydrology
            // 
            this.Btn_hydrology.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Btn_hydrology.FlatAppearance.BorderSize = 0;
            this.Btn_hydrology.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_hydrology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_hydrology.Font = new System.Drawing.Font("BankGothic Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_hydrology.ForeColor = System.Drawing.Color.White;
            this.Btn_hydrology.Location = new System.Drawing.Point(0, 98);
            this.Btn_hydrology.Name = "Btn_hydrology";
            this.Btn_hydrology.Size = new System.Drawing.Size(214, 33);
            this.Btn_hydrology.TabIndex = 1;
            this.Btn_hydrology.Text = "HYDROLOGY";
            this.Btn_hydrology.UseVisualStyleBackColor = true;
            this.Btn_hydrology.Click += new System.EventHandler(this.btn_hydrology_Click);
            // 
            // ComboBoxMethod
            // 
            this.ComboBoxMethod.BackColor = System.Drawing.Color.White;
            this.ComboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMethod.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMethod.ForeColor = System.Drawing.Color.Blue;
            this.ComboBoxMethod.FormattingEnabled = true;
            this.ComboBoxMethod.Location = new System.Drawing.Point(368, 261);
            this.ComboBoxMethod.Name = "ComboBoxMethod";
            this.ComboBoxMethod.Size = new System.Drawing.Size(378, 37);
            this.ComboBoxMethod.Sorted = true;
            this.ComboBoxMethod.TabIndex = 1;
            // 
            // Lblcaption2
            // 
            this.Lblcaption2.AutoSize = true;
            this.Lblcaption2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcaption2.ForeColor = System.Drawing.Color.Red;
            this.Lblcaption2.Location = new System.Drawing.Point(362, 206);
            this.Lblcaption2.Name = "Lblcaption2";
            this.Lblcaption2.Size = new System.Drawing.Size(143, 33);
            this.Lblcaption2.TabIndex = 2;
            this.Lblcaption2.Text = "Description";
            // 
            // ComboBoxMain
            // 
            this.ComboBoxMain.AllowDrop = true;
            this.ComboBoxMain.BackColor = System.Drawing.Color.White;
            this.ComboBoxMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMain.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMain.ForeColor = System.Drawing.Color.Blue;
            this.ComboBoxMain.FormattingEnabled = true;
            this.ComboBoxMain.Location = new System.Drawing.Point(368, 124);
            this.ComboBoxMain.Name = "ComboBoxMain";
            this.ComboBoxMain.Size = new System.Drawing.Size(378, 37);
            this.ComboBoxMain.Sorted = true;
            this.ComboBoxMain.TabIndex = 3;
            this.ComboBoxMain.SelectedValueChanged += new System.EventHandler(this.comboBoxMain_SelectedValueChanged);
            // 
            // Lblcaption1
            // 
            this.Lblcaption1.AutoSize = true;
            this.Lblcaption1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcaption1.ForeColor = System.Drawing.Color.Red;
            this.Lblcaption1.Location = new System.Drawing.Point(362, 69);
            this.Lblcaption1.Name = "Lblcaption1";
            this.Lblcaption1.Size = new System.Drawing.Size(143, 33);
            this.Lblcaption1.TabIndex = 4;
            this.Lblcaption1.Text = "Description";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 452);
            this.Controls.Add(this.Lblcaption1);
            this.Controls.Add(this.ComboBoxMain);
            this.Controls.Add(this.Lblcaption2);
            this.Controls.Add(this.ComboBoxMethod);
            this.Controls.Add(this.pannel_left);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.Text = "CSAY HYDROLOGY-HOME PAGE";
            this.pannel_left.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pannel_left;
        private System.Windows.Forms.Button Btn_hydrology;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.ComboBox ComboBoxMethod;
        private System.Windows.Forms.Label Lblcaption2;
        private System.Windows.Forms.Button Btn_proceed;
        private System.Windows.Forms.ComboBox ComboBoxMain;
        private System.Windows.Forms.Label Lblcaption1;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button Btn_WIH;
    }
}

