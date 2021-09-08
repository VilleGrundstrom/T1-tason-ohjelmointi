
namespace NeljasHarjoitus
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
            this.ikaDTP = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuosinaLB = new System.Windows.Forms.Label();
            this.tunteinaLB = new System.Windows.Forms.Label();
            this.kuukausinaLB = new System.Windows.Forms.Label();
            this.minuutteinaLB = new System.Windows.Forms.Label();
            this.paivaLB = new System.Windows.Forms.Label();
            this.sekuntteinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ikaDTP
            // 
            this.ikaDTP.Location = new System.Drawing.Point(55, 35);
            this.ikaDTP.Name = "ikaDTP";
            this.ikaDTP.Size = new System.Drawing.Size(219, 23);
            this.ikaDTP.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(280, 33);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(104, 25);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Vaihda";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuosinaLB
            // 
            this.vuosinaLB.AutoSize = true;
            this.vuosinaLB.Location = new System.Drawing.Point(56, 75);
            this.vuosinaLB.Name = "vuosinaLB";
            this.vuosinaLB.Size = new System.Drawing.Size(42, 15);
            this.vuosinaLB.TabIndex = 2;
            this.vuosinaLB.Text = "Vuotta";
            // 
            // tunteinaLB
            // 
            this.tunteinaLB.AutoSize = true;
            this.tunteinaLB.Location = new System.Drawing.Point(176, 75);
            this.tunteinaLB.Name = "tunteinaLB";
            this.tunteinaLB.Size = new System.Drawing.Size(40, 15);
            this.tunteinaLB.TabIndex = 3;
            this.tunteinaLB.Text = "Tuntia";
            this.tunteinaLB.Visible = false;
            // 
            // kuukausinaLB
            // 
            this.kuukausinaLB.AutoSize = true;
            this.kuukausinaLB.Location = new System.Drawing.Point(56, 106);
            this.kuukausinaLB.Name = "kuukausinaLB";
            this.kuukausinaLB.Size = new System.Drawing.Size(61, 15);
            this.kuukausinaLB.TabIndex = 4;
            this.kuukausinaLB.Text = "Kuukautta";
            this.kuukausinaLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // minuutteinaLB
            // 
            this.minuutteinaLB.AutoSize = true;
            this.minuutteinaLB.Location = new System.Drawing.Point(176, 107);
            this.minuutteinaLB.Name = "minuutteinaLB";
            this.minuutteinaLB.Size = new System.Drawing.Size(59, 15);
            this.minuutteinaLB.TabIndex = 5;
            this.minuutteinaLB.Text = "Minuuttia";
            // 
            // paivaLB
            // 
            this.paivaLB.AutoSize = true;
            this.paivaLB.Location = new System.Drawing.Point(55, 135);
            this.paivaLB.Name = "paivaLB";
            this.paivaLB.Size = new System.Drawing.Size(41, 15);
            this.paivaLB.TabIndex = 6;
            this.paivaLB.Text = "Päivää";
            // 
            // sekuntteinaLB
            // 
            this.sekuntteinaLB.AutoSize = true;
            this.sekuntteinaLB.Location = new System.Drawing.Point(176, 135);
            this.sekuntteinaLB.Name = "sekuntteinaLB";
            this.sekuntteinaLB.Size = new System.Drawing.Size(52, 15);
            this.sekuntteinaLB.TabIndex = 7;
            this.sekuntteinaLB.Text = "Sekuntia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sekuntteinaLB);
            this.Controls.Add(this.paivaLB);
            this.Controls.Add(this.minuutteinaLB);
            this.Controls.Add(this.kuukausinaLB);
            this.Controls.Add(this.tunteinaLB);
            this.Controls.Add(this.vuosinaLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.ikaDTP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ikaDTP;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.Label vuosinaLB;
        private System.Windows.Forms.Label tunteinaLB;
        private System.Windows.Forms.Label kuukausinaLB;
        private System.Windows.Forms.Label minuutteinaLB;
        private System.Windows.Forms.Label paivaLB;
        private System.Windows.Forms.Label sekuntteinaLB;
    }
}

