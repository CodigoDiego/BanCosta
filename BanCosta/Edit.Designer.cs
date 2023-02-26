
namespace BanCosta
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.dtp_nacimiento_edit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mtCorr_edit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtTel_edit = new System.Windows.Forms.MaskedTextBox();
            this.tbDir_edit = new System.Windows.Forms.TextBox();
            this.cbEdo_edit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSexo_edit = new System.Windows.Forms.ComboBox();
            this.tbAP_edit = new System.Windows.Forms.TextBox();
            this.tbAM_edit = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_usrs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_dtp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNom_edit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_nacimiento_edit
            // 
            this.dtp_nacimiento_edit.Location = new System.Drawing.Point(21, 298);
            this.dtp_nacimiento_edit.Name = "dtp_nacimiento_edit";
            this.dtp_nacimiento_edit.Size = new System.Drawing.Size(264, 20);
            this.dtp_nacimiento_edit.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(18, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Orange;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_edit.Location = new System.Drawing.Point(21, 335);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(264, 48);
            this.btn_edit.TabIndex = 18;
            this.btn_edit.Text = "Guardar";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(175, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Correo";
            // 
            // mtCorr_edit
            // 
            this.mtCorr_edit.BackColor = System.Drawing.Color.DarkGray;
            this.mtCorr_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtCorr_edit.Location = new System.Drawing.Point(175, 247);
            this.mtCorr_edit.Name = "mtCorr_edit";
            this.mtCorr_edit.Size = new System.Drawing.Size(110, 20);
            this.mtCorr_edit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(21, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono";
            // 
            // mtTel_edit
            // 
            this.mtTel_edit.BackColor = System.Drawing.Color.DarkGray;
            this.mtTel_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtTel_edit.Location = new System.Drawing.Point(21, 248);
            this.mtTel_edit.Mask = "(999)000-0000";
            this.mtTel_edit.Name = "mtTel_edit";
            this.mtTel_edit.Size = new System.Drawing.Size(114, 20);
            this.mtTel_edit.TabIndex = 13;
            // 
            // tbDir_edit
            // 
            this.tbDir_edit.BackColor = System.Drawing.Color.DarkGray;
            this.tbDir_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDir_edit.Location = new System.Drawing.Point(175, 201);
            this.tbDir_edit.Name = "tbDir_edit";
            this.tbDir_edit.Size = new System.Drawing.Size(110, 20);
            this.tbDir_edit.TabIndex = 12;
            // 
            // cbEdo_edit
            // 
            this.cbEdo_edit.BackColor = System.Drawing.Color.DarkGray;
            this.cbEdo_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdo_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbEdo_edit.FormattingEnabled = true;
            this.cbEdo_edit.Items.AddRange(new object[] {
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
            this.cbEdo_edit.Location = new System.Drawing.Point(21, 200);
            this.cbEdo_edit.Name = "cbEdo_edit";
            this.cbEdo_edit.Size = new System.Drawing.Size(114, 21);
            this.cbEdo_edit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(175, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(175, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sexo";
            // 
            // cbSexo_edit
            // 
            this.cbSexo_edit.BackColor = System.Drawing.Color.DarkGray;
            this.cbSexo_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo_edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSexo_edit.FormattingEnabled = true;
            this.cbSexo_edit.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cbSexo_edit.Location = new System.Drawing.Point(175, 145);
            this.cbSexo_edit.Name = "cbSexo_edit";
            this.cbSexo_edit.Size = new System.Drawing.Size(110, 21);
            this.cbSexo_edit.TabIndex = 6;
            // 
            // tbAP_edit
            // 
            this.tbAP_edit.BackColor = System.Drawing.Color.DarkGray;
            this.tbAP_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAP_edit.Location = new System.Drawing.Point(175, 94);
            this.tbAP_edit.Name = "tbAP_edit";
            this.tbAP_edit.Size = new System.Drawing.Size(110, 20);
            this.tbAP_edit.TabIndex = 3;
            // 
            // tbAM_edit
            // 
            this.tbAM_edit.BackColor = System.Drawing.Color.DarkGray;
            this.tbAM_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAM_edit.Location = new System.Drawing.Point(21, 145);
            this.tbAM_edit.Name = "tbAM_edit";
            this.tbAM_edit.Size = new System.Drawing.Size(114, 20);
            this.tbAM_edit.TabIndex = 5;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(18, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(172, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido Paterno";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cb_usrs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_dtp);
            this.panel1.Controls.Add(this.dtp_nacimiento_edit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mtCorr_edit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mtTel_edit);
            this.panel1.Controls.Add(this.tbDir_edit);
            this.panel1.Controls.Add(this.cbEdo_edit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSexo_edit);
            this.panel1.Controls.Add(this.tbAP_edit);
            this.panel1.Controls.Add(this.tbAM_edit);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNom_edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 445);
            this.panel1.TabIndex = 8;
            // 
            // cb_usrs
            // 
            this.cb_usrs.FormattingEnabled = true;
            this.cb_usrs.Location = new System.Drawing.Point(24, 20);
            this.cb_usrs.Name = "cb_usrs";
            this.cb_usrs.Size = new System.Drawing.Size(261, 21);
            this.cb_usrs.TabIndex = 34;
            this.cb_usrs.SelectionChangeCommitted += new System.EventHandler(this.cb_usrs_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(21, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 48);
            this.button1.TabIndex = 33;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(21, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Seleccione un usuario";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbl_dtp
            // 
            this.lbl_dtp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_dtp.Location = new System.Drawing.Point(18, 445);
            this.lbl_dtp.Name = "lbl_dtp";
            this.lbl_dtp.Size = new System.Drawing.Size(267, 23);
            this.lbl_dtp.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado de procedencia";
            // 
            // tbNom_edit
            // 
            this.tbNom_edit.BackColor = System.Drawing.Color.DarkGray;
            this.tbNom_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNom_edit.Location = new System.Drawing.Point(21, 94);
            this.tbNom_edit.Name = "tbNom_edit";
            this.tbNom_edit.Size = new System.Drawing.Size(114, 20);
            this.tbNom_edit.TabIndex = 1;
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
            this.panel2.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(334, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.Load += new System.EventHandler(this.Edit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_nacimiento_edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtCorr_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtTel_edit;
        private System.Windows.Forms.TextBox tbDir_edit;
        private System.Windows.Forms.ComboBox cbEdo_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSexo_edit;
        private System.Windows.Forms.TextBox tbAP_edit;
        private System.Windows.Forms.TextBox tbAM_edit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNom_edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_usrs;
    }
}