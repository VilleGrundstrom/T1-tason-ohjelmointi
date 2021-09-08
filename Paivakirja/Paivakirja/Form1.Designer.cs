
namespace Paivakirja
{
    partial class Form1
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
            this.syottoTB = new System.Windows.Forms.TextBox();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syottoTB
            // 
            this.syottoTB.Location = new System.Drawing.Point(14, 17);
            this.syottoTB.Multiline = true;
            this.syottoTB.Name = "syottoTB";
            this.syottoTB.Size = new System.Drawing.Size(816, 408);
            this.syottoTB.TabIndex = 0;
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(17, 447);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(812, 83);
            this.tallennaBT.TabIndex = 1;
            this.tallennaBT.Text = "Tallenna päiväkirjaan";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 536);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.syottoTB);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox syottoTB;
        private System.Windows.Forms.Button tallennaBT;
    }
}

