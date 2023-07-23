namespace CalculatorGravitatieSpace_sl
{
    partial class CalculatorGravitatieSpace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeClient = new System.Windows.Forms.TextBox();
            this.textGreutate = new System.Windows.Forms.TextBox();
            this.panelAfisareRezultat = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnSterge);
            this.panel1.Controls.Add(this.btnCalculeaza);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textNumeClient);
            this.panel1.Controls.Add(this.textGreutate);
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 411);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Location = new System.Drawing.Point(596, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 261);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculatorGravitatieSpace_sl.Properties.Resources.islam;
            this.pictureBox1.Location = new System.Drawing.Point(263, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(96, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Greutate Space Luna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(150, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume Client";
            // 
            // textNumeClient
            // 
            this.textNumeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textNumeClient.Location = new System.Drawing.Point(263, 217);
            this.textNumeClient.Name = "textNumeClient";
            this.textNumeClient.Size = new System.Drawing.Size(182, 27);
            this.textNumeClient.TabIndex = 1;
            this.textNumeClient.TextChanged += new System.EventHandler(this.textNumeClient_TextChanged);
            // 
            // textGreutate
            // 
            this.textGreutate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textGreutate.Location = new System.Drawing.Point(263, 258);
            this.textGreutate.Name = "textGreutate";
            this.textGreutate.Size = new System.Drawing.Size(87, 27);
            this.textGreutate.TabIndex = 0;
            this.textGreutate.TextChanged += new System.EventHandler(this.textGreutate_TextChanged);
            // 
            // panelAfisareRezultat
            // 
            this.panelAfisareRezultat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelAfisareRezultat.Location = new System.Drawing.Point(590, 62);
            this.panelAfisareRezultat.Name = "panelAfisareRezultat";
            this.panelAfisareRezultat.Size = new System.Drawing.Size(238, 241);
            this.panelAfisareRezultat.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalculatorGravitatieSpace_sl.Properties.Resources.astronaut_g098e29555_1280;
            this.pictureBox2.Location = new System.Drawing.Point(590, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculeaza.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCalculeaza.Location = new System.Drawing.Point(263, 324);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(94, 29);
            this.btnCalculeaza.TabIndex = 5;
            this.btnCalculeaza.Text = "Calculeaza";
            this.btnCalculeaza.UseVisualStyleBackColor = false;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.Red;
            this.btnSterge.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSterge.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSterge.Location = new System.Drawing.Point(401, 324);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(94, 29);
            this.btnSterge.TabIndex = 6;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // CalculatorGravitatieSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelAfisareRezultat);
            this.Controls.Add(this.panel1);
            this.Name = "CalculatorGravitatieSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorGravitatieSpace";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textNumeClient;
        private TextBox textGreutate;
        private Panel panel2;
        private Panel panelAfisareRezultat;
        private PictureBox pictureBox2;
        private Button btnSterge;
        private Button btnCalculeaza;
    }
}