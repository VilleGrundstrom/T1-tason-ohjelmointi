
namespace tehtava20
{
    partial class opiskelijaForm
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
            this.idLB = new System.Windows.Forms.Label();
            this.etunimiLB = new System.Windows.Forms.Label();
            this.sukunimiLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.opiskelijanroLB = new System.Windows.Forms.Label();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.opiskelijanroTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Location = new System.Drawing.Point(38, 23);
            this.idLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(33, 21);
            this.idLB.TabIndex = 1;
            this.idLB.Text = "ID:";
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Location = new System.Drawing.Point(38, 67);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(70, 21);
            this.etunimiLB.TabIndex = 2;
            this.etunimiLB.Text = "Etunimi:";
            // 
            // sukunimiLB
            // 
            this.sukunimiLB.AutoSize = true;
            this.sukunimiLB.Location = new System.Drawing.Point(38, 108);
            this.sukunimiLB.Name = "sukunimiLB";
            this.sukunimiLB.Size = new System.Drawing.Size(83, 21);
            this.sukunimiLB.TabIndex = 3;
            this.sukunimiLB.Text = "Sukunimi:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(264, 20);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(68, 21);
            this.puhelinLB.TabIndex = 4;
            this.puhelinLB.Text = "Puhelin:";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Location = new System.Drawing.Point(264, 67);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(98, 21);
            this.emailLB.TabIndex = 5;
            this.emailLB.Text = "Sähköposti:";
            // 
            // opiskelijanroLB
            // 
            this.opiskelijanroLB.AutoSize = true;
            this.opiskelijanroLB.Location = new System.Drawing.Point(264, 108);
            this.opiskelijanroLB.Name = "opiskelijanroLB";
            this.opiskelijanroLB.Size = new System.Drawing.Size(112, 21);
            this.opiskelijanroLB.TabIndex = 6;
            this.opiskelijanroLB.Text = "Opiskelijanro:";
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(10, 181);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(649, 310);
            this.TietotauluDG.TabIndex = 7;
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(33, 143);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(99, 28);
            this.tyhjennaBT.TabIndex = 8;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(157, 143);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(99, 28);
            this.tallennaBT.TabIndex = 9;
            this.tallennaBT.Text = "Tallenna";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(282, 143);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(99, 28);
            this.paivitaBT.TabIndex = 10;
            this.paivitaBT.Text = "Päivitä";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(402, 143);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(99, 28);
            this.poistaBT.TabIndex = 11;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(124, 20);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(122, 29);
            this.idTB.TabIndex = 12;
            // 
            // etunimiTB
            // 
            this.etunimiTB.Location = new System.Drawing.Point(124, 59);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(122, 29);
            this.etunimiTB.TabIndex = 13;
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.Location = new System.Drawing.Point(124, 105);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(122, 29);
            this.sukunimiTB.TabIndex = 14;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(379, 20);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(122, 29);
            this.puhelinTB.TabIndex = 15;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(379, 64);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(122, 29);
            this.emailTB.TabIndex = 16;
            // 
            // opiskelijanroTB
            // 
            this.opiskelijanroTB.Location = new System.Drawing.Point(379, 105);
            this.opiskelijanroTB.Name = "opiskelijanroTB";
            this.opiskelijanroTB.Size = new System.Drawing.Size(122, 29);
            this.opiskelijanroTB.TabIndex = 17;
            // 
            // opiskelijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 499);
            this.Controls.Add(this.opiskelijanroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.sukunimiTB);
            this.Controls.Add(this.etunimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.opiskelijanroLB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.sukunimiLB);
            this.Controls.Add(this.etunimiLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "opiskelijaForm";
            this.Text = "Opiskelijataulukko";
            this.Load += new System.EventHandler(this.opiskelijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Label sukunimiLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label emailLB;
        private System.Windows.Forms.Label opiskelijanroLB;
        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox etunimiTB;
        private System.Windows.Forms.TextBox sukunimiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox opiskelijanroTB;
    }
}

