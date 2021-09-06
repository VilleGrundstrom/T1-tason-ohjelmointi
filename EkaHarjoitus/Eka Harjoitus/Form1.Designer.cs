
namespace Eka_Harjoitus
{
    partial class form1
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.vaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Location = new System.Drawing.Point(101, 94);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(82, 30);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Otsikko";
            // 
            // vaihdaBT
            // 
            this.vaihdaBT.Location = new System.Drawing.Point(101, 127);
            this.vaihdaBT.Name = "vaihdaBT";
            this.vaihdaBT.Size = new System.Drawing.Size(171, 41);
            this.vaihdaBT.TabIndex = 1;
            this.vaihdaBT.Text = "vaihda teksti";
            this.vaihdaBT.UseVisualStyleBackColor = true;
            this.vaihdaBT.Click += new System.EventHandler(this.vaihdaBT_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 900);
            this.Controls.Add(this.vaihdaBT);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Button vaihdaBT;
    }
}

