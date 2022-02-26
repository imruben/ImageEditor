namespace ImagenForms
{
    partial class FormMarco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarco));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGrosorMarco = new System.Windows.Forms.TextBox();
            this.btnAñadirMarco2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarMarco = new System.Windows.Forms.PictureBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMarco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(252, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "AÑADIR MARCO";
            // 
            // textBoxGrosorMarco
            // 
            this.textBoxGrosorMarco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxGrosorMarco.Location = new System.Drawing.Point(421, 258);
            this.textBoxGrosorMarco.Name = "textBoxGrosorMarco";
            this.textBoxGrosorMarco.Size = new System.Drawing.Size(92, 31);
            this.textBoxGrosorMarco.TabIndex = 4;
            // 
            // btnAñadirMarco2
            // 
            this.btnAñadirMarco2.BackColor = System.Drawing.Color.White;
            this.btnAñadirMarco2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirMarco2.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirMarco2.Location = new System.Drawing.Point(263, 349);
            this.btnAñadirMarco2.Name = "btnAñadirMarco2";
            this.btnAñadirMarco2.Size = new System.Drawing.Size(232, 47);
            this.btnAñadirMarco2.TabIndex = 5;
            this.btnAñadirMarco2.Text = "AÑADIR MARCO";
            this.btnAñadirMarco2.UseVisualStyleBackColor = false;
            this.btnAñadirMarco2.Click += new System.EventHandler(this.buttonAñadirMarco_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCerrarMarco);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 40);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Añadir Marco";
            // 
            // btnCerrarMarco
            // 
            this.btnCerrarMarco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarMarco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMarco.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMarco.Image")));
            this.btnCerrarMarco.Location = new System.Drawing.Point(731, 7);
            this.btnCerrarMarco.Name = "btnCerrarMarco";
            this.btnCerrarMarco.Size = new System.Drawing.Size(25, 25);
            this.btnCerrarMarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarMarco.TabIndex = 13;
            this.btnCerrarMarco.TabStop = false;
            this.btnCerrarMarco.Click += new System.EventHandler(this.btnCerrarMarco_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRojo.FlatAppearance.BorderSize = 0;
            this.btnRojo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.ForeColor = System.Drawing.Color.White;
            this.btnRojo.Location = new System.Drawing.Point(104, 188);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(127, 30);
            this.btnRojo.TabIndex = 9;
            this.btnRojo.Text = "ROJO";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzul.FlatAppearance.BorderSize = 0;
            this.btnAzul.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzul.ForeColor = System.Drawing.Color.White;
            this.btnAzul.Location = new System.Drawing.Point(263, 188);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(127, 30);
            this.btnAzul.TabIndex = 10;
            this.btnAzul.Text = "AZUL";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerde.FlatAppearance.BorderSize = 0;
            this.btnVerde.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.White;
            this.btnVerde.Location = new System.Drawing.Point(421, 188);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(127, 30);
            this.btnVerde.TabIndex = 11;
            this.btnVerde.Text = "VERDE";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Color del marco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grosor del marco (entre 1 y 500):";
            // 
            // FormMarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAñadirMarco2);
            this.Controls.Add(this.textBoxGrosorMarco);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarco";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMarco_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarMarco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGrosorMarco;
        private System.Windows.Forms.Button btnAñadirMarco2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrarMarco;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}