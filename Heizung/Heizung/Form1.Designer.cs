namespace Heizung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.trkB_1 = new System.Windows.Forms.TrackBar();
            this.txtb_min1 = new System.Windows.Forms.TextBox();
            this.txtb_max1 = new System.Windows.Forms.TextBox();
            this.txtB_max2 = new System.Windows.Forms.TextBox();
            this.txtB_min2 = new System.Windows.Forms.TextBox();
            this.trkB_2 = new System.Windows.Forms.TrackBar();
            this.txtB_max3 = new System.Windows.Forms.TextBox();
            this.txtB_min3 = new System.Windows.Forms.TextBox();
            this.trkB_3 = new System.Windows.Forms.TrackBar();
            this.lbl_heiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hei2 = new System.Windows.Forms.Label();
            this.lbl_hei1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_3)).BeginInit();
            this.SuspendLayout();
            // 
            // trkB_1
            // 
            this.trkB_1.LargeChange = 2;
            this.trkB_1.Location = new System.Drawing.Point(134, 12);
            this.trkB_1.Maximum = 35;
            this.trkB_1.Minimum = 15;
            this.trkB_1.Name = "trkB_1";
            this.trkB_1.Size = new System.Drawing.Size(275, 56);
            this.trkB_1.TabIndex = 0;
            this.trkB_1.Value = 22;
            this.trkB_1.Scroll += new System.EventHandler(this.trkB_1_Scroll);
            // 
            // txtb_min1
            // 
            this.txtb_min1.Location = new System.Drawing.Point(12, 12);
            this.txtb_min1.Name = "txtb_min1";
            this.txtb_min1.Size = new System.Drawing.Size(100, 22);
            this.txtb_min1.TabIndex = 1;
            // 
            // txtb_max1
            // 
            this.txtb_max1.Location = new System.Drawing.Point(415, 12);
            this.txtb_max1.Name = "txtb_max1";
            this.txtb_max1.Size = new System.Drawing.Size(100, 22);
            this.txtb_max1.TabIndex = 2;
            // 
            // txtB_max2
            // 
            this.txtB_max2.Location = new System.Drawing.Point(415, 152);
            this.txtB_max2.Name = "txtB_max2";
            this.txtB_max2.Size = new System.Drawing.Size(100, 22);
            this.txtB_max2.TabIndex = 5;
            // 
            // txtB_min2
            // 
            this.txtB_min2.Location = new System.Drawing.Point(12, 152);
            this.txtB_min2.Name = "txtB_min2";
            this.txtB_min2.Size = new System.Drawing.Size(100, 22);
            this.txtB_min2.TabIndex = 4;
            // 
            // trkB_2
            // 
            this.trkB_2.LargeChange = 2;
            this.trkB_2.Location = new System.Drawing.Point(134, 152);
            this.trkB_2.Maximum = 35;
            this.trkB_2.Minimum = 15;
            this.trkB_2.Name = "trkB_2";
            this.trkB_2.Size = new System.Drawing.Size(275, 56);
            this.trkB_2.TabIndex = 3;
            this.trkB_2.Value = 22;
            this.trkB_2.Scroll += new System.EventHandler(this.trkB_2_Scroll);
            // 
            // txtB_max3
            // 
            this.txtB_max3.Location = new System.Drawing.Point(415, 284);
            this.txtB_max3.Name = "txtB_max3";
            this.txtB_max3.Size = new System.Drawing.Size(100, 22);
            this.txtB_max3.TabIndex = 8;
            // 
            // txtB_min3
            // 
            this.txtB_min3.Location = new System.Drawing.Point(12, 284);
            this.txtB_min3.Name = "txtB_min3";
            this.txtB_min3.Size = new System.Drawing.Size(100, 22);
            this.txtB_min3.TabIndex = 7;
            // 
            // trkB_3
            // 
            this.trkB_3.LargeChange = 2;
            this.trkB_3.Location = new System.Drawing.Point(134, 284);
            this.trkB_3.Maximum = 35;
            this.trkB_3.Minimum = 15;
            this.trkB_3.Name = "trkB_3";
            this.trkB_3.Size = new System.Drawing.Size(275, 56);
            this.trkB_3.TabIndex = 6;
            this.trkB_3.Value = 22;
            this.trkB_3.Scroll += new System.EventHandler(this.trkB_3_Scroll);
            // 
            // lbl_heiz
            // 
            this.lbl_heiz.AutoSize = true;
            this.lbl_heiz.Location = new System.Drawing.Point(137, 387);
            this.lbl_heiz.Name = "lbl_heiz";
            this.lbl_heiz.Size = new System.Drawing.Size(170, 17);
            this.lbl_heiz.TabIndex = 9;
            this.lbl_heiz.Text = "Heizung ist ausgeschaltet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temperatur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temperatur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Temperatur";
            // 
            // lbl_hei2
            // 
            this.lbl_hei2.AutoSize = true;
            this.lbl_hei2.Location = new System.Drawing.Point(137, 243);
            this.lbl_hei2.Name = "lbl_hei2";
            this.lbl_hei2.Size = new System.Drawing.Size(170, 17);
            this.lbl_hei2.TabIndex = 13;
            this.lbl_hei2.Text = "Heizung ist ausgeschaltet";
            // 
            // lbl_hei1
            // 
            this.lbl_hei1.AutoSize = true;
            this.lbl_hei1.Location = new System.Drawing.Point(137, 88);
            this.lbl_hei1.Name = "lbl_hei1";
            this.lbl_hei1.Size = new System.Drawing.Size(170, 17);
            this.lbl_hei1.TabIndex = 14;
            this.lbl_hei1.Text = "Heizung ist ausgeschaltet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 413);
            this.Controls.Add(this.lbl_hei1);
            this.Controls.Add(this.lbl_hei2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_heiz);
            this.Controls.Add(this.txtB_max3);
            this.Controls.Add(this.txtB_min3);
            this.Controls.Add(this.trkB_3);
            this.Controls.Add(this.txtB_max2);
            this.Controls.Add(this.txtB_min2);
            this.Controls.Add(this.trkB_2);
            this.Controls.Add(this.txtb_max1);
            this.Controls.Add(this.txtb_min1);
            this.Controls.Add(this.trkB_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkB_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkB_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkB_1;
        private System.Windows.Forms.TextBox txtb_min1;
        private System.Windows.Forms.TextBox txtb_max1;
        private System.Windows.Forms.TextBox txtB_max2;
        private System.Windows.Forms.TextBox txtB_min2;
        private System.Windows.Forms.TrackBar trkB_2;
        private System.Windows.Forms.TextBox txtB_max3;
        private System.Windows.Forms.TextBox txtB_min3;
        private System.Windows.Forms.TrackBar trkB_3;
        private System.Windows.Forms.Label lbl_heiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hei2;
        private System.Windows.Forms.Label lbl_hei1;
    }
}

