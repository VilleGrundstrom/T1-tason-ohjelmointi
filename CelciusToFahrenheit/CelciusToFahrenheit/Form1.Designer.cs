
namespace CelciusToFahrenheit
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.celciusRB = new System.Windows.Forms.RadioButton();
            this.fahreinheitRB = new System.Windows.Forms.RadioButton();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna Asteet:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fahreinheitRB);
            this.groupBox1.Controls.Add(this.celciusRB);
            this.groupBox1.Location = new System.Drawing.Point(300, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miten Muunnat?";
            // 
            // celciusRB
            // 
            this.celciusRB.AutoSize = true;
            this.celciusRB.Location = new System.Drawing.Point(22, 44);
            this.celciusRB.Name = "celciusRB";
            this.celciusRB.Size = new System.Drawing.Size(99, 33);
            this.celciusRB.TabIndex = 0;
            this.celciusRB.TabStop = true;
            this.celciusRB.Text = "Celcius";
            this.celciusRB.UseVisualStyleBackColor = true;
            // 
            // fahreinheitRB
            // 
            this.fahreinheitRB.AutoSize = true;
            this.fahreinheitRB.Location = new System.Drawing.Point(22, 83);
            this.fahreinheitRB.Name = "fahreinheitRB";
            this.fahreinheitRB.Size = new System.Drawing.Size(136, 33);
            this.fahreinheitRB.TabIndex = 1;
            this.fahreinheitRB.TabStop = true;
            this.fahreinheitRB.Text = "Fahrenheit";
            this.fahreinheitRB.UseVisualStyleBackColor = true;
            // 
            // asteetTB
            // 
            this.asteetTB.Location = new System.Drawing.Point(198, 57);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(73, 37);
            this.asteetTB.TabIndex = 2;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(79, 224);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(86, 29);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "vastaus";
            this.vastausLB.Visible = false;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Location = new System.Drawing.Point(548, 74);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(137, 44);
            this.muunnaBT.TabIndex = 4;
            this.muunnaBT.Text = "muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 870);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "form1";
            this.Text = "CelciustoFahrenheit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fahreinheitRB;
        private System.Windows.Forms.RadioButton celciusRB;
        private System.Windows.Forms.TextBox asteetTB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.Button muunnaBT;
    }
}

