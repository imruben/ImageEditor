namespace ImagenForms
{
    partial class FormRecortar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecortar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxP1x = new System.Windows.Forms.TextBox();
            this.textBoxP2x = new System.Windows.Forms.TextBox();
            this.textBoxP1y = new System.Windows.Forms.TextBox();
            this.textBoxP2y = new System.Windows.Forms.TextBox();
            this.btnRecortar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labeldimension = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(763, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(311, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "RECORTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Recortar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(606, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Escribe los dos puntos del rectangulo que quieres recortar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(186, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Punto 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(500, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Punto 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(142, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(466, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(142, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(466, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Y";
            // 
            // textBoxP1x
            // 
            this.textBoxP1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxP1x.Location = new System.Drawing.Point(190, 198);
            this.textBoxP1x.Name = "textBoxP1x";
            this.textBoxP1x.Size = new System.Drawing.Size(83, 31);
            this.textBoxP1x.TabIndex = 24;
            // 
            // textBoxP2x
            // 
            this.textBoxP2x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxP2x.Location = new System.Drawing.Point(504, 198);
            this.textBoxP2x.Name = "textBoxP2x";
            this.textBoxP2x.Size = new System.Drawing.Size(83, 31);
            this.textBoxP2x.TabIndex = 25;
            // 
            // textBoxP1y
            // 
            this.textBoxP1y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxP1y.Location = new System.Drawing.Point(190, 245);
            this.textBoxP1y.Name = "textBoxP1y";
            this.textBoxP1y.Size = new System.Drawing.Size(83, 31);
            this.textBoxP1y.TabIndex = 26;
            // 
            // textBoxP2y
            // 
            this.textBoxP2y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxP2y.Location = new System.Drawing.Point(504, 245);
            this.textBoxP2y.Name = "textBoxP2y";
            this.textBoxP2y.Size = new System.Drawing.Size(83, 31);
            this.textBoxP2y.TabIndex = 27;
            // 
            // btnRecortar
            // 
            this.btnRecortar.BackColor = System.Drawing.Color.White;
            this.btnRecortar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecortar.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecortar.Location = new System.Drawing.Point(257, 363);
            this.btnRecortar.Name = "btnRecortar";
            this.btnRecortar.Size = new System.Drawing.Size(232, 47);
            this.btnRecortar.TabIndex = 28;
            this.btnRecortar.Text = "Recortar";
            this.btnRecortar.UseVisualStyleBackColor = false;
            this.btnRecortar.Click += new System.EventHandler(this.btnRecortar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(186, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Dimensiones: ";
            // 
            // labeldimension
            // 
            this.labeldimension.AutoSize = true;
            this.labeldimension.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labeldimension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeldimension.Location = new System.Drawing.Point(341, 313);
            this.labeldimension.Name = "labeldimension";
            this.labeldimension.Size = new System.Drawing.Size(22, 24);
            this.labeldimension.TabIndex = 30;
            this.labeldimension.Text = "0";
            // 
            // FormRecortar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeldimension);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRecortar);
            this.Controls.Add(this.textBoxP2y);
            this.Controls.Add(this.textBoxP1y);
            this.Controls.Add(this.textBoxP2x);
            this.Controls.Add(this.textBoxP1x);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRecortar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormRecortar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxP1x;
        private System.Windows.Forms.TextBox textBoxP2x;
        private System.Windows.Forms.TextBox textBoxP1y;
        private System.Windows.Forms.TextBox textBoxP2y;
        private System.Windows.Forms.Button btnRecortar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labeldimension;
    }
}