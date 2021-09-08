
namespace KahdestoistaHarjoitus
{
    partial class kysymysta
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TurhaRB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(87, 47);
            this.KysymysLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(270, 30);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(87, 212);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(88, 30);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(443, 93);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(46, 34);
            this.ARB.TabIndex = 2;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vastaa";
            // 
            // TurhaRB
            // 
            this.TurhaRB.AutoCheck = false;
            this.TurhaRB.AutoSize = true;
            this.TurhaRB.Location = new System.Drawing.Point(443, 93);
            this.TurhaRB.Name = "TurhaRB";
            this.TurhaRB.Size = new System.Drawing.Size(46, 34);
            this.TurhaRB.TabIndex = 4;
            this.TurhaRB.TabStop = true;
            this.TurhaRB.Text = "A";
            this.TurhaRB.UseVisualStyleBackColor = true;
            this.TurhaRB.Visible = false;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(445, 121);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(44, 34);
            this.BRB.TabIndex = 5;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(445, 151);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(44, 34);
            this.CRB.TabIndex = 6;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(445, 179);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(46, 34);
            this.DRB.TabIndex = 7;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // kysymysta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 900);
            this.Controls.Add(this.DRB);
            this.Controls.Add(this.CRB);
            this.Controls.Add(this.BRB);
            this.Controls.Add(this.TurhaRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ARB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "kysymysta";
            this.Text = "10kysymystä";
            this.Load += new System.EventHandler(this.kysymysta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.RadioButton ARB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton TurhaRB;
        private System.Windows.Forms.RadioButton BRB;
        private System.Windows.Forms.RadioButton CRB;
        private System.Windows.Forms.RadioButton DRB;
    }
}

