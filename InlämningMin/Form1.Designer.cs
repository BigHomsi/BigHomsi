namespace InlämningMin
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ta_bort = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.multiplikation = new System.Windows.Forms.Button();
            this.n_sex = new System.Windows.Forms.Button();
            this.n_fem = new System.Windows.Forms.Button();
            this.n_fyra = new System.Windows.Forms.Button();
            this.n_nio = new System.Windows.Forms.Button();
            this.n_åtta = new System.Windows.Forms.Button();
            this.roten_ur = new System.Windows.Forms.Button();
            this.n_sju = new System.Windows.Forms.Button();
            this.minus_tecken = new System.Windows.Forms.Button();
            this.ta_bort_allt_i_minne = new System.Windows.Forms.Button();
            this.ta_bort_en_rad = new System.Windows.Forms.Button();
            this.n_tre = new System.Windows.Forms.Button();
            this.n_två = new System.Windows.Forms.Button();
            this.n_ett = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.n_noll = new System.Windows.Forms.Button();
            this.komma = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 62);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ta_bort
            // 
            this.ta_bort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ta_bort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_bort.Location = new System.Drawing.Point(12, 79);
            this.ta_bort.Name = "ta_bort";
            this.ta_bort.Size = new System.Drawing.Size(33, 36);
            this.ta_bort.TabIndex = 1;
            this.ta_bort.Text = "<--";
            this.ta_bort.UseVisualStyleBackColor = false;
            this.ta_bort.Click += new System.EventHandler(this.Ta_bort_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Lime;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(129, 121);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(33, 36);
            this.division.TabIndex = 2;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.Division_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(168, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Prosent_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(168, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // multiplikation
            // 
            this.multiplikation.BackColor = System.Drawing.Color.Lime;
            this.multiplikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplikation.Location = new System.Drawing.Point(129, 163);
            this.multiplikation.Name = "multiplikation";
            this.multiplikation.Size = new System.Drawing.Size(33, 36);
            this.multiplikation.TabIndex = 5;
            this.multiplikation.Text = "*";
            this.multiplikation.UseVisualStyleBackColor = false;
            this.multiplikation.Click += new System.EventHandler(this.Multiplikation_Click);
            // 
            // n_sex
            // 
            this.n_sex.BackColor = System.Drawing.Color.Lime;
            this.n_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_sex.Location = new System.Drawing.Point(90, 163);
            this.n_sex.Name = "n_sex";
            this.n_sex.Size = new System.Drawing.Size(33, 36);
            this.n_sex.TabIndex = 6;
            this.n_sex.Text = "6";
            this.n_sex.UseVisualStyleBackColor = false;
            this.n_sex.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_fem
            // 
            this.n_fem.BackColor = System.Drawing.Color.Lime;
            this.n_fem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_fem.Location = new System.Drawing.Point(51, 163);
            this.n_fem.Name = "n_fem";
            this.n_fem.Size = new System.Drawing.Size(33, 36);
            this.n_fem.TabIndex = 7;
            this.n_fem.Text = "5";
            this.n_fem.UseVisualStyleBackColor = false;
            this.n_fem.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_fyra
            // 
            this.n_fyra.BackColor = System.Drawing.Color.Lime;
            this.n_fyra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_fyra.Location = new System.Drawing.Point(12, 163);
            this.n_fyra.Name = "n_fyra";
            this.n_fyra.Size = new System.Drawing.Size(33, 36);
            this.n_fyra.TabIndex = 8;
            this.n_fyra.Text = "4";
            this.n_fyra.UseVisualStyleBackColor = false;
            this.n_fyra.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_nio
            // 
            this.n_nio.BackColor = System.Drawing.Color.Lime;
            this.n_nio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_nio.Location = new System.Drawing.Point(90, 121);
            this.n_nio.Name = "n_nio";
            this.n_nio.Size = new System.Drawing.Size(33, 36);
            this.n_nio.TabIndex = 9;
            this.n_nio.Text = "9";
            this.n_nio.UseVisualStyleBackColor = false;
            this.n_nio.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_åtta
            // 
            this.n_åtta.BackColor = System.Drawing.Color.Lime;
            this.n_åtta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_åtta.Location = new System.Drawing.Point(51, 121);
            this.n_åtta.Name = "n_åtta";
            this.n_åtta.Size = new System.Drawing.Size(33, 36);
            this.n_åtta.TabIndex = 10;
            this.n_åtta.Text = "8";
            this.n_åtta.UseVisualStyleBackColor = false;
            this.n_åtta.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // roten_ur
            // 
            this.roten_ur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roten_ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roten_ur.Location = new System.Drawing.Point(168, 79);
            this.roten_ur.Name = "roten_ur";
            this.roten_ur.Size = new System.Drawing.Size(33, 36);
            this.roten_ur.TabIndex = 11;
            this.roten_ur.Text = "√";
            this.roten_ur.UseVisualStyleBackColor = false;
            this.roten_ur.Click += new System.EventHandler(this.Roten_ur_Click);
            // 
            // n_sju
            // 
            this.n_sju.BackColor = System.Drawing.Color.Lime;
            this.n_sju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_sju.Location = new System.Drawing.Point(12, 121);
            this.n_sju.Name = "n_sju";
            this.n_sju.Size = new System.Drawing.Size(33, 36);
            this.n_sju.TabIndex = 12;
            this.n_sju.Text = "7";
            this.n_sju.UseVisualStyleBackColor = false;
            this.n_sju.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // minus_tecken
            // 
            this.minus_tecken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minus_tecken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_tecken.Location = new System.Drawing.Point(129, 79);
            this.minus_tecken.Name = "minus_tecken";
            this.minus_tecken.Size = new System.Drawing.Size(33, 36);
            this.minus_tecken.TabIndex = 13;
            this.minus_tecken.Text = "±";
            this.minus_tecken.UseVisualStyleBackColor = false;
            this.minus_tecken.Click += new System.EventHandler(this.Minus_tecken_Click);
            // 
            // ta_bort_allt_i_minne
            // 
            this.ta_bort_allt_i_minne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ta_bort_allt_i_minne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_bort_allt_i_minne.Location = new System.Drawing.Point(90, 79);
            this.ta_bort_allt_i_minne.Name = "ta_bort_allt_i_minne";
            this.ta_bort_allt_i_minne.Size = new System.Drawing.Size(33, 36);
            this.ta_bort_allt_i_minne.TabIndex = 14;
            this.ta_bort_allt_i_minne.Text = "C";
            this.ta_bort_allt_i_minne.UseVisualStyleBackColor = false;
            this.ta_bort_allt_i_minne.Click += new System.EventHandler(this.Ta_bort_allt_i_minne_Click);
            // 
            // ta_bort_en_rad
            // 
            this.ta_bort_en_rad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ta_bort_en_rad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_bort_en_rad.Location = new System.Drawing.Point(51, 79);
            this.ta_bort_en_rad.Name = "ta_bort_en_rad";
            this.ta_bort_en_rad.Size = new System.Drawing.Size(33, 36);
            this.ta_bort_en_rad.TabIndex = 15;
            this.ta_bort_en_rad.Text = "CE";
            this.ta_bort_en_rad.UseVisualStyleBackColor = false;
            this.ta_bort_en_rad.Click += new System.EventHandler(this.Ta_bort_en_rad_Click);
            // 
            // n_tre
            // 
            this.n_tre.BackColor = System.Drawing.Color.Lime;
            this.n_tre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_tre.Location = new System.Drawing.Point(90, 205);
            this.n_tre.Name = "n_tre";
            this.n_tre.Size = new System.Drawing.Size(33, 36);
            this.n_tre.TabIndex = 16;
            this.n_tre.Text = "3";
            this.n_tre.UseVisualStyleBackColor = false;
            this.n_tre.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_två
            // 
            this.n_två.BackColor = System.Drawing.Color.Lime;
            this.n_två.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_två.Location = new System.Drawing.Point(51, 205);
            this.n_två.Name = "n_två";
            this.n_två.Size = new System.Drawing.Size(33, 36);
            this.n_två.TabIndex = 17;
            this.n_två.Text = "2";
            this.n_två.UseVisualStyleBackColor = false;
            this.n_två.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // n_ett
            // 
            this.n_ett.BackColor = System.Drawing.Color.Lime;
            this.n_ett.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_ett.Location = new System.Drawing.Point(12, 205);
            this.n_ett.Name = "n_ett";
            this.n_ett.Size = new System.Drawing.Size(33, 36);
            this.n_ett.TabIndex = 18;
            this.n_ett.Text = "1";
            this.n_ett.UseVisualStyleBackColor = false;
            this.n_ett.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Lime;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(129, 205);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(33, 36);
            this.minus.TabIndex = 21;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Lime;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(168, 206);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(33, 77);
            this.button25.TabIndex = 25;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.LikaMed_Click);
            // 
            // n_noll
            // 
            this.n_noll.BackColor = System.Drawing.Color.Lime;
            this.n_noll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_noll.Location = new System.Drawing.Point(12, 248);
            this.n_noll.Name = "n_noll";
            this.n_noll.Size = new System.Drawing.Size(72, 35);
            this.n_noll.TabIndex = 26;
            this.n_noll.Text = "0";
            this.n_noll.UseVisualStyleBackColor = false;
            this.n_noll.Click += new System.EventHandler(this.Siffra_Click);
            // 
            // komma
            // 
            this.komma.BackColor = System.Drawing.Color.Lime;
            this.komma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.komma.Location = new System.Drawing.Point(90, 247);
            this.komma.Name = "komma";
            this.komma.Size = new System.Drawing.Size(33, 36);
            this.komma.TabIndex = 27;
            this.komma.Text = ",";
            this.komma.UseVisualStyleBackColor = false;
            this.komma.Click += new System.EventHandler(this.Komma_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Lime;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(129, 247);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(33, 36);
            this.plus.TabIndex = 28;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 304);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.komma);
            this.Controls.Add(this.n_noll);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.n_ett);
            this.Controls.Add(this.n_två);
            this.Controls.Add(this.n_tre);
            this.Controls.Add(this.ta_bort_en_rad);
            this.Controls.Add(this.ta_bort_allt_i_minne);
            this.Controls.Add(this.minus_tecken);
            this.Controls.Add(this.n_sju);
            this.Controls.Add(this.roten_ur);
            this.Controls.Add(this.n_åtta);
            this.Controls.Add(this.n_nio);
            this.Controls.Add(this.n_fyra);
            this.Controls.Add(this.n_fem);
            this.Controls.Add(this.n_sex);
            this.Controls.Add(this.multiplikation);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.division);
            this.Controls.Add(this.ta_bort);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ta_bort;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button multiplikation;
        private System.Windows.Forms.Button n_sex;
        private System.Windows.Forms.Button n_fem;
        private System.Windows.Forms.Button n_fyra;
        private System.Windows.Forms.Button n_nio;
        private System.Windows.Forms.Button n_åtta;
        private System.Windows.Forms.Button roten_ur;
        private System.Windows.Forms.Button n_sju;
        private System.Windows.Forms.Button minus_tecken;
        private System.Windows.Forms.Button ta_bort_allt_i_minne;
        private System.Windows.Forms.Button ta_bort_en_rad;
        private System.Windows.Forms.Button n_tre;
        private System.Windows.Forms.Button n_två;
        private System.Windows.Forms.Button n_ett;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button n_noll;
        private System.Windows.Forms.Button komma;
        private System.Windows.Forms.Button plus;
    }
}

