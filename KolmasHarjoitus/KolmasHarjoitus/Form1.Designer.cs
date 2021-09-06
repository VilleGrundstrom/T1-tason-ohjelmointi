
namespace KolmasHarjoitus
{
    partial class laskeBT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LukuyksiTB = new System.Windows.Forms.TextBox();
            this.LukukaksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LukuyksiTB
            // 
            this.LukuyksiTB.Location = new System.Drawing.Point(283, 128);
            this.LukuyksiTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LukuyksiTB.Name = "LukuyksiTB";
            this.LukuyksiTB.Size = new System.Drawing.Size(146, 35);
            this.LukuyksiTB.TabIndex = 0;
            // 
            // LukukaksiTB
            // 
            this.LukukaksiTB.Location = new System.Drawing.Point(494, 128);
            this.LukukaksiTB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LukukaksiTB.Name = "LukukaksiTB";
            this.LukukaksiTB.Size = new System.Drawing.Size(146, 35);
            this.LukukaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            this.LaskutoimitusCB.FormattingEnabled = true;
            this.LaskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.LaskutoimitusCB.Location = new System.Drawing.Point(442, 128);
            this.LaskutoimitusCB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LaskutoimitusCB.Name = "LaskutoimitusCB";
            this.LaskutoimitusCB.Size = new System.Drawing.Size(38, 38);
            this.LaskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(687, 133);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(23, 30);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "x";
            this.VastausLB.Visible = false;
            this.VastausLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Laske";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // laskeBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaskutoimitusCB);
            this.Controls.Add(this.LukukaksiTB);
            this.Controls.Add(this.LukuyksiTB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "laskeBT";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LukuyksiTB;
        private System.Windows.Forms.TextBox LukukaksiTB;
        private System.Windows.Forms.ComboBox LaskutoimitusCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button button1;
    }
}

