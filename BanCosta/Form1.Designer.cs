
namespace BanCosta
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_adm = new System.Windows.Forms.LinkLabel();
            this.lbl_rgstr = new System.Windows.Forms.LinkLabel();
            this.lbl_txt_rgstr = new System.Windows.Forms.Label();
            this.btn_entr = new System.Windows.Forms.Button();
            this.mt_nCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nc = new System.Windows.Forms.Label();
            this.msk_tb_nip = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.lbl_adm);
            this.panel2.Controls.Add(this.lbl_rgstr);
            this.panel2.Controls.Add(this.lbl_txt_rgstr);
            this.panel2.Controls.Add(this.btn_entr);
            this.panel2.Controls.Add(this.mt_nCuenta);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_nc);
            this.panel2.Controls.Add(this.msk_tb_nip);
            this.panel2.Location = new System.Drawing.Point(10, 73);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(314, 225);
            this.panel2.TabIndex = 1;
            // 
            // lbl_adm
            // 
            this.lbl_adm.AutoSize = true;
            this.lbl_adm.LinkColor = System.Drawing.Color.Orange;
            this.lbl_adm.Location = new System.Drawing.Point(98, 204);
            this.lbl_adm.Name = "lbl_adm";
            this.lbl_adm.Size = new System.Drawing.Size(121, 13);
            this.lbl_adm.TabIndex = 5;
            this.lbl_adm.TabStop = true;
            this.lbl_adm.Text = "Control de Administrador";
            this.lbl_adm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_adm_LinkClicked);
            // 
            // lbl_rgstr
            // 
            this.lbl_rgstr.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lbl_rgstr.AutoSize = true;
            this.lbl_rgstr.LinkColor = System.Drawing.Color.Orange;
            this.lbl_rgstr.Location = new System.Drawing.Point(120, 187);
            this.lbl_rgstr.Name = "lbl_rgstr";
            this.lbl_rgstr.Size = new System.Drawing.Size(80, 13);
            this.lbl_rgstr.TabIndex = 4;
            this.lbl_rgstr.TabStop = true;
            this.lbl_rgstr.Text = "Registrate aquí";
            this.lbl_rgstr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_rgstr_LinkClicked);
            this.lbl_rgstr.Click += new System.EventHandler(this.lbl_rgstr_Click);
            // 
            // lbl_txt_rgstr
            // 
            this.lbl_txt_rgstr.AutoSize = true;
            this.lbl_txt_rgstr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_txt_rgstr.Location = new System.Drawing.Point(98, 174);
            this.lbl_txt_rgstr.Name = "lbl_txt_rgstr";
            this.lbl_txt_rgstr.Size = new System.Drawing.Size(120, 13);
            this.lbl_txt_rgstr.TabIndex = 7;
            this.lbl_txt_rgstr.Text = "¿Aún no tienes cuenta?";
            // 
            // btn_entr
            // 
            this.btn_entr.BackColor = System.Drawing.Color.Orange;
            this.btn_entr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entr.ForeColor = System.Drawing.Color.Transparent;
            this.btn_entr.Location = new System.Drawing.Point(71, 117);
            this.btn_entr.Name = "btn_entr";
            this.btn_entr.Size = new System.Drawing.Size(176, 39);
            this.btn_entr.TabIndex = 3;
            this.btn_entr.Text = "Entrar";
            this.btn_entr.UseVisualStyleBackColor = false;
            this.btn_entr.Click += new System.EventHandler(this.btn_entr_Click);
            // 
            // mt_nCuenta
            // 
            this.mt_nCuenta.BackColor = System.Drawing.Color.DarkGray;
            this.mt_nCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mt_nCuenta.Location = new System.Drawing.Point(71, 23);
            this.mt_nCuenta.Mask = "9999999999";
            this.mt_nCuenta.Name = "mt_nCuenta";
            this.mt_nCuenta.Size = new System.Drawing.Size(176, 20);
            this.mt_nCuenta.TabIndex = 1;
            this.mt_nCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mt_nCuenta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIP";
            // 
            // lbl_nc
            // 
            this.lbl_nc.AutoSize = true;
            this.lbl_nc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nc.Location = new System.Drawing.Point(68, 7);
            this.lbl_nc.Name = "lbl_nc";
            this.lbl_nc.Size = new System.Drawing.Size(95, 13);
            this.lbl_nc.TabIndex = 3;
            this.lbl_nc.Text = "Número de cuenta";
            // 
            // msk_tb_nip
            // 
            this.msk_tb_nip.BackColor = System.Drawing.Color.DarkGray;
            this.msk_tb_nip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_tb_nip.Location = new System.Drawing.Point(71, 76);
            this.msk_tb_nip.Mask = "9999";
            this.msk_tb_nip.Name = "msk_tb_nip";
            this.msk_tb_nip.PasswordChar = '*';
            this.msk_tb_nip.Size = new System.Drawing.Size(176, 20);
            this.msk_tb_nip.TabIndex = 2;
            this.msk_tb_nip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_tb_nip.ValidatingType = typeof(int);
            this.msk_tb_nip.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_tb_nip_MaskInputRejected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BanCosta.Properties.Resources.BanCosta1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(59, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox msk_tb_nip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nc;
        private System.Windows.Forms.Button btn_entr;
        private System.Windows.Forms.MaskedTextBox mt_nCuenta;
        private System.Windows.Forms.LinkLabel lbl_rgstr;
        private System.Windows.Forms.Label lbl_txt_rgstr;
        private System.Windows.Forms.LinkLabel lbl_adm;
    }
}

