
namespace _07_Ingılızce_Kelime_Ogren_Projesi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(186, 53);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(226, 26);
            this.txtIngilizce.TabIndex = 10;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(186, 101);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(226, 26);
            this.txtTurkce.TabIndex = 1;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(663, 61);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(27, 18);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Süre:";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(663, 101);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(18, 18);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kelime:";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(490, 173);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(62, 18);
            this.lblDogru.TabIndex = 8;
            this.lblDogru.Text = "Kelime:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 247);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Timer timer1;
    }
}

