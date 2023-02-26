
namespace BanCosta
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAP = new System.Windows.Forms.TextBox();
            this.tbAM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dtp = new System.Windows.Forms.Label();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.mt_NIP = new System.Windows.Forms.MaskedTextBox();
            this.lbl_NIP = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mtCorr = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtTel = new System.Windows.Forms.MaskedTextBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.cbEdo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(18, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nombre";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.DarkGray;
            this.tbNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNom.Location = new System.Drawing.Point(21, 30);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(114, 20);
            this.tbNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(172, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido Paterno";
            // 
            // tbAP
            // 
            this.tbAP.BackColor = System.Drawing.Color.DarkGray;
            this.tbAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAP.Location = new System.Drawing.Point(175, 30);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(110, 20);
            this.tbAP.TabIndex = 3;
            // 
            // tbAM
            // 
            this.tbAM.BackColor = System.Drawing.Color.DarkGray;
            this.tbAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAM.Location = new System.Drawing.Point(21, 81);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(114, 20);
            this.tbAM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Materno";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_dtp);
            this.panel1.Controls.Add(this.dtp_nacimiento);
            this.panel1.Controls.Add(this.mt_NIP);
            this.panel1.Controls.Add(this.lbl_NIP);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mtCorr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mtTel);
            this.panel1.Controls.Add(this.tbDir);
            this.panel1.Controls.Add(this.cbEdo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.tbAP);
            this.panel1.Controls.Add(this.tbAM);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 424);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_dtp
            // 
            this.lbl_dtp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dtp.Location = new System.Drawing.Point(18, 445);
            this.lbl_dtp.Name = "lbl_dtp";
            this.lbl_dtp.Size = new System.Drawing.Size(267, 23);
            this.lbl_dtp.TabIndex = 29;
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.Location = new System.Drawing.Point(21, 258);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(264, 20);
            this.dtp_nacimiento.TabIndex = 28;
            this.dtp_nacimiento.ValueChanged += new System.EventHandler(this.dtp_nacimiento_ValueChanged);
            // 
            // mt_NIP
            // 
            this.mt_NIP.BackColor = System.Drawing.Color.DarkGray;
            this.mt_NIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mt_NIP.Location = new System.Drawing.Point(21, 315);
            this.mt_NIP.Mask = "9999";
            this.mt_NIP.Name = "mt_NIP";
            this.mt_NIP.Size = new System.Drawing.Size(264, 20);
            this.mt_NIP.TabIndex = 27;
            this.mt_NIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mt_NIP.ValidatingType = typeof(int);
            // 
            // lbl_NIP
            // 
            this.lbl_NIP.AutoSize = true;
            this.lbl_NIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NIP.Location = new System.Drawing.Point(18, 298);
            this.lbl_NIP.Name = "lbl_NIP";
            this.lbl_NIP.Size = new System.Drawing.Size(78, 13);
            this.lbl_NIP.TabIndex = 26;
            this.lbl_NIP.Text = "Ingrese un NIP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(21, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(175, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Correo";
            // 
            // mtCorr
            // 
            this.mtCorr.BackColor = System.Drawing.Color.DarkGray;
            this.mtCorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtCorr.Location = new System.Drawing.Point(175, 183);
            this.mtCorr.Name = "mtCorr";
            this.mtCorr.Size = new System.Drawing.Size(110, 20);
            this.mtCorr.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // mtTel
            // 
            this.mtTel.BackColor = System.Drawing.Color.DarkGray;
            this.mtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtTel.Location = new System.Drawing.Point(21, 184);
            this.mtTel.Mask = "(999)000-0000";
            this.mtTel.Name = "mtTel";
            this.mtTel.Size = new System.Drawing.Size(114, 20);
            this.mtTel.TabIndex = 13;
            // 
            // tbDir
            // 
            this.tbDir.BackColor = System.Drawing.Color.DarkGray;
            this.tbDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDir.Location = new System.Drawing.Point(175, 137);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(110, 20);
            this.tbDir.TabIndex = 12;
            // 
            // cbEdo
            // 
            this.cbEdo.BackColor = System.Drawing.Color.DarkGray;
            this.cbEdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbEdo.FormattingEnabled = true;
            this.cbEdo.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.cbEdo.Location = new System.Drawing.Point(21, 136);
            this.cbEdo.Name = "cbEdo";
            this.cbEdo.Size = new System.Drawing.Size(114, 21);
            this.cbEdo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(175, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado de procedencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(175, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.DarkGray;
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cbSexo.Location = new System.Drawing.Point(175, 81);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(110, 21);
            this.cbSexo.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::BanCosta.Properties.Resources.BanCosta1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 57);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(334, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registro_FormClosed);
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAP;
        private System.Windows.Forms.TextBox tbAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.ComboBox cbEdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtCorr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mt_NIP;
        private System.Windows.Forms.Label lbl_NIP;
        private System.Windows.Forms.DateTimePicker dtp_nacimiento;
        private System.Windows.Forms.Label lbl_dtp;
    }
}