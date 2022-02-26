namespace ImagenForms
{
    partial class FormModoPresentacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModoPresentacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmpezarPresentación = new System.Windows.Forms.Button();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.EscogerCarpeta = new System.Windows.Forms.Button();
            this.btnReiniciarPresentacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreimagen = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 48);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Modo Presentación";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(987, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(12, 65);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(582, 397);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(635, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Segundos entre imagen y imagen:";
            // 
            // btnEmpezarPresentación
            // 
            this.btnEmpezarPresentación.BackColor = System.Drawing.Color.White;
            this.btnEmpezarPresentación.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpezarPresentación.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezarPresentación.Location = new System.Drawing.Point(691, 412);
            this.btnEmpezarPresentación.Name = "btnEmpezarPresentación";
            this.btnEmpezarPresentación.Size = new System.Drawing.Size(232, 66);
            this.btnEmpezarPresentación.TabIndex = 6;
            this.btnEmpezarPresentación.Text = "EMPEZAR PRESENTACIÓN";
            this.btnEmpezarPresentación.UseVisualStyleBackColor = false;
            this.btnEmpezarPresentación.Click += new System.EventHandler(this.btnEmpezarPresentacion_Click);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxInterval.Location = new System.Drawing.Point(751, 222);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(100, 31);
            this.textBoxInterval.TabIndex = 7;
            // 
            // EscogerCarpeta
            // 
            this.EscogerCarpeta.BackColor = System.Drawing.Color.White;
            this.EscogerCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EscogerCarpeta.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EscogerCarpeta.Location = new System.Drawing.Point(691, 77);
            this.EscogerCarpeta.Name = "EscogerCarpeta";
            this.EscogerCarpeta.Size = new System.Drawing.Size(232, 66);
            this.EscogerCarpeta.TabIndex = 9;
            this.EscogerCarpeta.Text = "Escoger Carpeta";
            this.EscogerCarpeta.UseVisualStyleBackColor = false;
            this.EscogerCarpeta.Click += new System.EventHandler(this.EscogerCarpeta_Click);
            // 
            // btnReiniciarPresentacion
            // 
            this.btnReiniciarPresentacion.BackColor = System.Drawing.Color.White;
            this.btnReiniciarPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciarPresentacion.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarPresentacion.Location = new System.Drawing.Point(691, 306);
            this.btnReiniciarPresentacion.Name = "btnReiniciarPresentacion";
            this.btnReiniciarPresentacion.Size = new System.Drawing.Size(232, 66);
            this.btnReiniciarPresentacion.TabIndex = 10;
            this.btnReiniciarPresentacion.Text = "REINICIAR PRESENTACIÓN";
            this.btnReiniciarPresentacion.UseVisualStyleBackColor = false;
            this.btnReiniciarPresentacion.Click += new System.EventHandler(this.btnReiniciarPresentacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre imagen:";
            // 
            // nombreimagen
            // 
            this.nombreimagen.AutoSize = true;
            this.nombreimagen.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.nombreimagen.ForeColor = System.Drawing.Color.White;
            this.nombreimagen.Location = new System.Drawing.Point(292, 477);
            this.nombreimagen.Name = "nombreimagen";
            this.nombreimagen.Size = new System.Drawing.Size(0, 24);
            this.nombreimagen.TabIndex = 12;
            // 
            // FormModoPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1020, 535);
            this.Controls.Add(this.nombreimagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReiniciarPresentacion);
            this.Controls.Add(this.EscogerCarpeta);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.btnEmpezarPresentación);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormModoPresentacion";
            this.Text = "FormModoPresentacion";
            this.Load += new System.EventHandler(this.FormModoPresentacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpezarPresentación;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Button EscogerCarpeta;
        private System.Windows.Forms.Button btnReiniciarPresentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombreimagen;
    }
}