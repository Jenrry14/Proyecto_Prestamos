namespace ProFin
{
    partial class Consultas_Form
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
            this.btnVerCli = new System.Windows.Forms.Button();
            this.BtnVerPag = new System.Windows.Forms.Button();
            this.btnVerPres = new System.Windows.Forms.Button();
            this.btnPendi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCli
            // 
            this.btnVerCli.Location = new System.Drawing.Point(351, 286);
            this.btnVerCli.Name = "btnVerCli";
            this.btnVerCli.Size = new System.Drawing.Size(160, 60);
            this.btnVerCli.TabIndex = 0;
            this.btnVerCli.Text = "Clientes";
            this.btnVerCli.UseVisualStyleBackColor = true;
            this.btnVerCli.Click += new System.EventHandler(this.btnVerCli_Click);
            // 
            // BtnVerPag
            // 
            this.BtnVerPag.Location = new System.Drawing.Point(351, 186);
            this.BtnVerPag.Name = "BtnVerPag";
            this.BtnVerPag.Size = new System.Drawing.Size(160, 60);
            this.BtnVerPag.TabIndex = 1;
            this.BtnVerPag.Text = "Pagos";
            this.BtnVerPag.UseVisualStyleBackColor = true;
            this.BtnVerPag.Click += new System.EventHandler(this.BtnVerPag_Click);
            // 
            // btnVerPres
            // 
            this.btnVerPres.Location = new System.Drawing.Point(119, 186);
            this.btnVerPres.Name = "btnVerPres";
            this.btnVerPres.Size = new System.Drawing.Size(160, 60);
            this.btnVerPres.TabIndex = 2;
            this.btnVerPres.Text = "Prestamos";
            this.btnVerPres.UseVisualStyleBackColor = true;
            this.btnVerPres.Click += new System.EventHandler(this.btnVerPres_Click);
            // 
            // btnPendi
            // 
            this.btnPendi.Location = new System.Drawing.Point(119, 286);
            this.btnPendi.Name = "btnPendi";
            this.btnPendi.Size = new System.Drawing.Size(160, 60);
            this.btnPendi.TabIndex = 3;
            this.btnPendi.Text = "Pago Pendiente";
            this.btnPendi.UseVisualStyleBackColor = true;
            this.btnPendi.Click += new System.EventHandler(this.btnPendi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProFin.Properties.Resources.p;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(382, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 112);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Consultas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProFin.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPendi);
            this.Controls.Add(this.btnVerPres);
            this.Controls.Add(this.BtnVerPag);
            this.Controls.Add(this.btnVerCli);
            this.Name = "Consultas_Form";
            this.Text = "Consultas_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerCli;
        private System.Windows.Forms.Button BtnVerPag;
        private System.Windows.Forms.Button btnVerPres;
        private System.Windows.Forms.Button btnPendi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}