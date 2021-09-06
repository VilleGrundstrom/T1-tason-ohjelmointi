
namespace ToinenHarjoitus
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
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.tulostaTB = new System.Windows.Forms.TextBox();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna Tulostettava Teksti:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(65, 123);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(61, 29);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "xxxx";
            this.vastausLB.Visible = false;
            // 
            // tulostaTB
            // 
            this.tulostaTB.Location = new System.Drawing.Point(353, 42);
            this.tulostaTB.Name = "tulostaTB";
            this.tulostaTB.Size = new System.Drawing.Size(220, 37);
            this.tulostaTB.TabIndex = 2;
            // 
            // tulostaBT
            // 
            this.tulostaBT.Location = new System.Drawing.Point(355, 109);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(217, 43);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "button1";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1486, 870);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.tulostaTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "tekstin tulostus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.TextBox tulostaTB;
        private System.Windows.Forms.Button tulostaBT;
    }
}

