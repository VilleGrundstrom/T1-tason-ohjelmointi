
namespace Sekunttikello
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.aikaLB = new System.Windows.Forms.Label();
            this.kaynnistaBT = new System.Windows.Forms.Button();
            this.lopetaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.ajanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(96, 39);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(557, 109);
            this.aikaLB.TabIndex = 0;
            this.aikaLB.Text = "00:00:00.000";
            // 
            // kaynnistaBT
            // 
            this.kaynnistaBT.Location = new System.Drawing.Point(96, 187);
            this.kaynnistaBT.Name = "kaynnistaBT";
            this.kaynnistaBT.Size = new System.Drawing.Size(145, 48);
            this.kaynnistaBT.TabIndex = 1;
            this.kaynnistaBT.Text = "Käynnistä";
            this.kaynnistaBT.UseVisualStyleBackColor = true;
            this.kaynnistaBT.Click += new System.EventHandler(this.kaynnistaBT_Click);
            // 
            // lopetaBT
            // 
            this.lopetaBT.Location = new System.Drawing.Point(302, 187);
            this.lopetaBT.Name = "lopetaBT";
            this.lopetaBT.Size = new System.Drawing.Size(145, 48);
            this.lopetaBT.TabIndex = 2;
            this.lopetaBT.Text = "Lopeta";
            this.lopetaBT.UseVisualStyleBackColor = true;
            this.lopetaBT.Click += new System.EventHandler(this.lopetaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(508, 187);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(145, 48);
            this.tyhjennaBT.TabIndex = 3;
            this.tyhjennaBT.Text = "tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // ajanottoTM
            // 
            this.ajanottoTM.Enabled = true;
            this.ajanottoTM.Tick += new System.EventHandler(this.ajanottoTM_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 402);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.lopetaBT);
            this.Controls.Add(this.kaynnistaBT);
            this.Controls.Add(this.aikaLB);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SekkariForm";
            this.Text = "ajastin";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aikaLB;
        private System.Windows.Forms.Button kaynnistaBT;
        private System.Windows.Forms.Button lopetaBT;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Timer ajanottoTM;
    }
}

