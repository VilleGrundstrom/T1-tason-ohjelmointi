namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.oidTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.onroTB = new System.Windows.Forms.TextBox();
            this.tyhjennaTB = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tieatotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tieatotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etunimi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puhelin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sähköposti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opiskelijanro:";
            // 
            // oidTB
            // 
            this.oidTB.Location = new System.Drawing.Point(104, 29);
            this.oidTB.Name = "oidTB";
            this.oidTB.Size = new System.Drawing.Size(97, 26);
            this.oidTB.TabIndex = 6;
            // 
            // etunimiTB
            // 
            this.etunimiTB.Location = new System.Drawing.Point(104, 64);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(97, 26);
            this.etunimiTB.TabIndex = 7;
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.Location = new System.Drawing.Point(104, 98);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(97, 26);
            this.sukunimiTB.TabIndex = 8;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(330, 29);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(97, 26);
            this.puhelinTB.TabIndex = 9;
            this.puhelinTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(330, 61);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(97, 26);
            this.emailTB.TabIndex = 10;
            // 
            // onroTB
            // 
            this.onroTB.Location = new System.Drawing.Point(330, 101);
            this.onroTB.Name = "onroTB";
            this.onroTB.Size = new System.Drawing.Size(97, 26);
            this.onroTB.TabIndex = 11;
            // 
            // tyhjennaTB
            // 
            this.tyhjennaTB.Location = new System.Drawing.Point(16, 139);
            this.tyhjennaTB.Name = "tyhjennaTB";
            this.tyhjennaTB.Size = new System.Drawing.Size(87, 30);
            this.tyhjennaTB.TabIndex = 12;
            this.tyhjennaTB.Text = "Tyhjennä";
            this.tyhjennaTB.UseVisualStyleBackColor = true;
            this.tyhjennaTB.Click += new System.EventHandler(this.tyhjennaTB_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(114, 139);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(87, 30);
            this.tallennaBT.TabIndex = 13;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(213, 139);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(87, 30);
            this.paivitaBT.TabIndex = 14;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(317, 139);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(87, 30);
            this.poistaBT.TabIndex = 15;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // tieatotauluDG
            // 
            this.tieatotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tieatotauluDG.Location = new System.Drawing.Point(10, 178);
            this.tieatotauluDG.Name = "tieatotauluDG";
            this.tieatotauluDG.Size = new System.Drawing.Size(507, 169);
            this.tieatotauluDG.TabIndex = 16;
            this.tieatotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tieatotauluDG_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.tieatotauluDG);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaTB);
            this.Controls.Add(this.onroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.sukunimiTB);
            this.Controls.Add(this.etunimiTB);
            this.Controls.Add(this.oidTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tieatotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox oidTB;
        private System.Windows.Forms.TextBox etunimiTB;
        private System.Windows.Forms.TextBox sukunimiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox onroTB;
        private System.Windows.Forms.Button tyhjennaTB;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.DataGridView tieatotauluDG;
    }
}

