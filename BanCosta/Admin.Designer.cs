
namespace BanCosta
{
    partial class AdminCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit_usr = new System.Windows.Forms.Button();
            this.btn_add_usr = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BanCosta.Properties.Resources.BanCosta1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_edit_usr);
            this.panel2.Controls.Add(this.btn_add_usr);
            this.panel2.Location = new System.Drawing.Point(13, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 125);
            this.panel2.TabIndex = 1;
            // 
            // btn_edit_usr
            // 
            this.btn_edit_usr.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit_usr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_edit_usr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_usr.ForeColor = System.Drawing.Color.Transparent;
            this.btn_edit_usr.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit_usr.Image")));
            this.btn_edit_usr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_usr.Location = new System.Drawing.Point(0, 60);
            this.btn_edit_usr.Name = "btn_edit_usr";
            this.btn_edit_usr.Size = new System.Drawing.Size(358, 60);
            this.btn_edit_usr.TabIndex = 1;
            this.btn_edit_usr.Text = "Editar / Eliminar Usuario";
            this.btn_edit_usr.UseVisualStyleBackColor = false;
            this.btn_edit_usr.Click += new System.EventHandler(this.btn_edit_usr_Click);
            // 
            // btn_add_usr
            // 
            this.btn_add_usr.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_usr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_usr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_usr.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add_usr.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_usr.Image")));
            this.btn_add_usr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_usr.Location = new System.Drawing.Point(0, 0);
            this.btn_add_usr.Name = "btn_add_usr";
            this.btn_add_usr.Size = new System.Drawing.Size(358, 60);
            this.btn_add_usr.TabIndex = 0;
            this.btn_add_usr.Text = "Agregar Usuario";
            this.btn_add_usr.UseVisualStyleBackColor = false;
            this.btn_add_usr.Click += new System.EventHandler(this.btn_add_usr_Click);
            // 
            // AdminCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCon";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminCon_FormClosing);
            this.Load += new System.EventHandler(this.AdminCon_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_add_usr;
        private System.Windows.Forms.Button btn_edit_usr;
    }
}