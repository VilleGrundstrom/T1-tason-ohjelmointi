
namespace _8harjoitus
{
    partial class Roomalaisiksiform
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
            this.label2 = new System.Windows.Forms.Label();
            this.numeroTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roomalaiset Numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna Numero välillä 1-3999 niin muutan sen roomalaiseksi";
            // 
            // numeroTB
            // 
            this.numeroTB.Location = new System.Drawing.Point(640, 100);
            this.numeroTB.Name = "numeroTB";
            this.numeroTB.Size = new System.Drawing.Size(98, 37);
            this.numeroTB.TabIndex = 2;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(25, 143);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(92, 30);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // muutaBT
            // 
            this.muutaBT.Location = new System.Drawing.Point(640, 143);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(98, 42);
            this.muutaBT.TabIndex = 4;
            this.muutaBT.Text = "Muuta";
            this.muutaBT.UseVisualStyleBackColor = true;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click);
            // 
            // Roomalaisiksiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 463);
            this.Controls.Add(this.muutaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.numeroTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Roomalaisiksiform";
            this.Text = "arabialaisten numeroiden muuntaminen roomalaisiksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeroTB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.Button muutaBT;
    }
}

