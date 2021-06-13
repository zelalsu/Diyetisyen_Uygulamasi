
namespace DiyetisyenUygulamasi.Forms
{
    partial class RaporSecimFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporSecimFrm));
            this.raporSecim_label = new System.Windows.Forms.Label();
            this.hd_btn = new System.Windows.Forms.Button();
            this.dh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raporSecim_label
            // 
            this.raporSecim_label.AutoSize = true;
            this.raporSecim_label.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporSecim_label.Location = new System.Drawing.Point(33, 38);
            this.raporSecim_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raporSecim_label.Name = "raporSecim_label";
            this.raporSecim_label.Size = new System.Drawing.Size(321, 19);
            this.raporSecim_label.TabIndex = 1;
            this.raporSecim_label.Text = "Lütfen çıkarmak istediğiniz rapor stilini seçiniz.";
            // 
            // hd_btn
            // 
            this.hd_btn.BackColor = System.Drawing.Color.Bisque;
            this.hd_btn.Location = new System.Drawing.Point(37, 91);
            this.hd_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hd_btn.Name = "hd_btn";
            this.hd_btn.Size = new System.Drawing.Size(135, 65);
            this.hd_btn.TabIndex = 4;
            this.hd_btn.Text = "1) Hasta Bilgileri \r\n2) Diyet Bilgileri";
            this.hd_btn.UseVisualStyleBackColor = false;
            this.hd_btn.Click += new System.EventHandler(this.hd_btn_Click);
            // 
            // dh_btn
            // 
            this.dh_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.dh_btn.Location = new System.Drawing.Point(204, 91);
            this.dh_btn.Margin = new System.Windows.Forms.Padding(2);
            this.dh_btn.Name = "dh_btn";
            this.dh_btn.Size = new System.Drawing.Size(136, 65);
            this.dh_btn.TabIndex = 5;
            this.dh_btn.Text = "1)Diyet Bilgileri \r\n 2)Hasta Bilgileri";
            this.dh_btn.UseVisualStyleBackColor = false;
            this.dh_btn.Click += new System.EventHandler(this.dh_btn_Click);
            // 
            // RaporSecimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 196);
            this.Controls.Add(this.dh_btn);
            this.Controls.Add(this.hd_btn);
            this.Controls.Add(this.raporSecim_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RaporSecimFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporSecimFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label raporSecim_label;
        private System.Windows.Forms.Button hd_btn;
        private System.Windows.Forms.Button dh_btn;
    }
}