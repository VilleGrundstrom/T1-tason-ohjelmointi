
namespace Nopanheitto
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
            this.noppa1PB = new System.Windows.Forms.PictureBox();
            this.noppa2PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeitäBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // noppa1PB
            // 
            this.noppa1PB.Image = global::Nopanheitto.Properties.Resources.dice01;
            this.noppa1PB.Location = new System.Drawing.Point(126, 106);
            this.noppa1PB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.noppa1PB.Name = "noppa1PB";
            this.noppa1PB.Size = new System.Drawing.Size(186, 200);
            this.noppa1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa1PB.TabIndex = 0;
            this.noppa1PB.TabStop = false;
            // 
            // noppa2PB
            // 
            this.noppa2PB.Image = global::Nopanheitto.Properties.Resources.dice01;
            this.noppa2PB.Location = new System.Drawing.Point(379, 106);
            this.noppa2PB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.noppa2PB.Name = "noppa2PB";
            this.noppa2PB.Size = new System.Drawing.Size(186, 200);
            this.noppa2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa2PB.TabIndex = 1;
            this.noppa2PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nopan Heitto!";
            // 
            // HeitäBT
            // 
            this.HeitäBT.Location = new System.Drawing.Point(218, 340);
            this.HeitäBT.Name = "HeitäBT";
            this.HeitäBT.Size = new System.Drawing.Size(254, 60);
            this.HeitäBT.TabIndex = 3;
            this.HeitäBT.Text = "Heitä";
            this.HeitäBT.UseVisualStyleBackColor = true;
            this.HeitäBT.Click += new System.EventHandler(this.HeitäBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 900);
            this.Controls.Add(this.HeitäBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noppa2PB);
            this.Controls.Add(this.noppa1PB);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Nopan Heitto";
            ((System.ComponentModel.ISupportInitialize)(this.noppa1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa2PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox noppa1PB;
        private System.Windows.Forms.PictureBox noppa2PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HeitäBT;
    }
}

