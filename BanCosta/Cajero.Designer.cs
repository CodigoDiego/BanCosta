
namespace BanCosta
{
    partial class Cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
            this.pnl_mnl = new System.Windows.Forms.Panel();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_hist = new System.Windows.Forms.Button();
            this.btn_retiro = new System.Windows.Forms.Button();
            this.btn_dep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_bienv = new System.Windows.Forms.Label();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_mnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_mnl
            // 
            this.pnl_mnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_mnl.Controls.Add(this.lbl_saldo);
            this.pnl_mnl.Controls.Add(this.button2);
            this.pnl_mnl.Controls.Add(this.btn_hist);
            this.pnl_mnl.Controls.Add(this.btn_retiro);
            this.pnl_mnl.Controls.Add(this.btn_dep);
            this.pnl_mnl.Controls.Add(this.panel2);
            this.pnl_mnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_mnl.Location = new System.Drawing.Point(0, 0);
            this.pnl_mnl.Name = "pnl_mnl";
            this.pnl_mnl.Size = new System.Drawing.Size(220, 585);
            this.pnl_mnl.TabIndex = 0;
            this.pnl_mnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_mnl_Paint);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_saldo.Location = new System.Drawing.Point(12, 503);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(85, 20);
            this.lbl_saldo.TabIndex = 6;
            this.lbl_saldo.Text = "Saldo: $0";
            this.lbl_saldo.Click += new System.EventHandler(this.lbl_saldo_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 540);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.button2.Size = new System.Drawing.Size(220, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_hist
            // 
            this.btn_hist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hist.ForeColor = System.Drawing.Color.White;
            this.btn_hist.Image = ((System.Drawing.Image)(resources.GetObject("btn_hist.Image")));
            this.btn_hist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hist.Location = new System.Drawing.Point(0, 189);
            this.btn_hist.Name = "btn_hist";
            this.btn_hist.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_hist.Size = new System.Drawing.Size(220, 57);
            this.btn_hist.TabIndex = 3;
            this.btn_hist.Text = "   Movimientos";
            this.btn_hist.UseVisualStyleBackColor = true;
            this.btn_hist.Click += new System.EventHandler(this.btn_hist_Click);
            // 
            // btn_retiro
            // 
            this.btn_retiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_retiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_retiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retiro.ForeColor = System.Drawing.Color.White;
            this.btn_retiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_retiro.Image")));
            this.btn_retiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retiro.Location = new System.Drawing.Point(0, 132);
            this.btn_retiro.Name = "btn_retiro";
            this.btn_retiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_retiro.Size = new System.Drawing.Size(220, 57);
            this.btn_retiro.TabIndex = 2;
            this.btn_retiro.Text = "Retiro      ";
            this.btn_retiro.UseVisualStyleBackColor = true;
            this.btn_retiro.Click += new System.EventHandler(this.btn_retiro_Click);
            // 
            // btn_dep
            // 
            this.btn_dep.BackColor = System.Drawing.Color.Transparent;
            this.btn_dep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.ForeColor = System.Drawing.Color.White;
            this.btn_dep.Image = ((System.Drawing.Image)(resources.GetObject("btn_dep.Image")));
            this.btn_dep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dep.Location = new System.Drawing.Point(0, 75);
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_dep.Size = new System.Drawing.Size(220, 57);
            this.btn_dep.TabIndex = 1;
            this.btn_dep.Text = "Depósitos";
            this.btn_dep.UseVisualStyleBackColor = false;
            this.btn_dep.Click += new System.EventHandler(this.btn_dep_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_bienv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel2.Size = new System.Drawing.Size(220, 75);
            this.panel2.TabIndex = 0;
            // 
            // lbl_bienv
            // 
            this.lbl_bienv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_bienv.Location = new System.Drawing.Point(0, 0);
            this.lbl_bienv.Name = "lbl_bienv";
            this.lbl_bienv.Size = new System.Drawing.Size(220, 75);
            this.lbl_bienv.TabIndex = 0;
            this.lbl_bienv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChild
            // 
            this.pnlChild.Controls.Add(this.panel1);
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(220, 0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(741, 585);
            this.pnlChild.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 585);
            this.panel1.TabIndex = 0;
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(961, 585);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.pnl_mnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cajero_FormClosed);
            this.Load += new System.EventHandler(this.Cajero_Load);
            this.pnl_mnl.ResumeLayout(false);
            this.pnl_mnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlChild.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_mnl;
        private System.Windows.Forms.Button btn_hist;
        private System.Windows.Forms.Button btn_retiro;
        private System.Windows.Forms.Button btn_dep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlChild;
        public System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_bienv;
        private System.Windows.Forms.Panel panel1;
    }
}