
namespace SeitsemasHarjoitus
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
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.vakuutuksetTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.polttoTB = new System.Windows.Forms.TextBox();
            this.pesutTB = new System.Windows.Forms.TextBox();
            this.huollotTB = new System.Windows.Forms.TextBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.kilometriCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(174, 50);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(106, 23);
            this.lainaTB.TabIndex = 0;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(174, 79);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(106, 23);
            this.NesteetTB.TabIndex = 1;
            // 
            // vakuutuksetTB
            // 
            this.vakuutuksetTB.Location = new System.Drawing.Point(174, 108);
            this.vakuutuksetTB.Name = "vakuutuksetTB";
            this.vakuutuksetTB.Size = new System.Drawing.Size(106, 23);
            this.vakuutuksetTB.TabIndex = 2;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(174, 137);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(106, 23);
            this.muutTB.TabIndex = 3;
            // 
            // polttoTB
            // 
            this.polttoTB.Location = new System.Drawing.Point(174, 166);
            this.polttoTB.Name = "polttoTB";
            this.polttoTB.Size = new System.Drawing.Size(106, 23);
            this.polttoTB.TabIndex = 4;
            // 
            // pesutTB
            // 
            this.pesutTB.Location = new System.Drawing.Point(415, 53);
            this.pesutTB.Name = "pesutTB";
            this.pesutTB.Size = new System.Drawing.Size(106, 23);
            this.pesutTB.TabIndex = 5;
            this.pesutTB.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // huollotTB
            // 
            this.huollotTB.Location = new System.Drawing.Point(415, 82);
            this.huollotTB.Name = "huollotTB";
            this.huollotTB.Size = new System.Drawing.Size(106, 23);
            this.huollotTB.TabIndex = 6;
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(415, 111);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(106, 23);
            this.renkaatTB.TabIndex = 7;
            // 
            // kilometriCB
            // 
            this.kilometriCB.FormattingEnabled = true;
            this.kilometriCB.Items.AddRange(new object[] {
            "100",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "11000",
            "12000",
            "13000",
            "14000",
            "15000",
            "16000",
            "17000",
            "18000",
            "19000",
            "20000",
            "21000",
            "22000",
            "23000",
            "24000",
            "25000",
            "26000",
            "27000",
            "28000",
            "29000",
            "30000"});
            this.kilometriCB.Location = new System.Drawing.Point(416, 145);
            this.kilometriCB.Name = "kilometriCB";
            this.kilometriCB.Size = new System.Drawing.Size(105, 23);
            this.kilometriCB.TabIndex = 8;
            this.kilometriCB.SelectedIndexChanged += new System.EventHandler(this.kilometriCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lainan Lyhennys korkoineen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lisättävät nesteet";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vakuutusmaksut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Muut Kulut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Polttoneste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pesut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Huollot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Renkaat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "kilometrit/vuosi";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(12, 224);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(193, 15);
            this.vastausLB.TabIndex = 18;
            this.vastausLB.Text = "Kustannukset kilometriä kohti ovat:";
            this.vastausLB.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilometriCB);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.huollotTB);
            this.Controls.Add(this.pesutTB);
            this.Controls.Add(this.polttoTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox vakuutuksetTB;
        private System.Windows.Forms.TextBox muutTB;
        private System.Windows.Forms.TextBox polttoTB;
        private System.Windows.Forms.TextBox pesutTB;
        private System.Windows.Forms.TextBox huollotTB;
        private System.Windows.Forms.TextBox renkaatTB;
        private System.Windows.Forms.ComboBox kilometriCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label vastausLB;
    }
}

