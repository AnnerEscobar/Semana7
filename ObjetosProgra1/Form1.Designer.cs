
namespace PlayerPrueba
{
    partial class velocidad
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(velocidad));
            this.buttonCrear = new System.Windows.Forms.Button();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.labelEncender = new System.Windows.Forms.Label();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelAcelerar = new System.Windows.Forms.Label();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.labelFrenar = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelApagar = new System.Windows.Forms.Label();
            this.buttonClaxon = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonReproducir = new System.Windows.Forms.Button();
            this.buttonParar = new System.Windows.Forms.Button();
            this.buttonPausar = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrear
            // 
            this.buttonCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCrear.CausesValidation = false;
            this.buttonCrear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonCrear.Location = new System.Drawing.Point(32, 86);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(128, 23);
            this.buttonCrear.TabIndex = 0;
            this.buttonCrear.Text = "Crear Automovil";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMarca.Location = new System.Drawing.Point(132, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(32, 13);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "xxxxx";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelColor.Location = new System.Drawing.Point(215, 15);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(32, 13);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "xxxxx";
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(32, 115);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(127, 23);
            this.buttonEncender.TabIndex = 3;
            this.buttonEncender.Text = "Encender Automovil";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // labelEncender
            // 
            this.labelEncender.AutoSize = true;
            this.labelEncender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEncender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEncender.Location = new System.Drawing.Point(3, 111);
            this.labelEncender.Name = "labelEncender";
            this.labelEncender.Size = new System.Drawing.Size(32, 13);
            this.labelEncender.TabIndex = 4;
            this.labelEncender.Text = "xxxxx";
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(248, 269);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(127, 23);
            this.buttonAcelerar.TabIndex = 5;
            this.buttonAcelerar.Text = "Acelerar Auto";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelAcelerar
            // 
            this.labelAcelerar.AutoSize = true;
            this.labelAcelerar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAcelerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAcelerar.Location = new System.Drawing.Point(78, 141);
            this.labelAcelerar.Name = "labelAcelerar";
            this.labelAcelerar.Size = new System.Drawing.Size(32, 13);
            this.labelAcelerar.TabIndex = 6;
            this.labelAcelerar.Text = "xxxxx";
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.Location = new System.Drawing.Point(411, 269);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(127, 23);
            this.buttonFrenar.TabIndex = 7;
            this.buttonFrenar.Text = "Frenar Auto";
            this.buttonFrenar.UseVisualStyleBackColor = true;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // labelFrenar
            // 
            this.labelFrenar.AutoSize = true;
            this.labelFrenar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFrenar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelFrenar.Location = new System.Drawing.Point(215, 141);
            this.labelFrenar.Name = "labelFrenar";
            this.labelFrenar.Size = new System.Drawing.Size(32, 13);
            this.labelFrenar.TabIndex = 8;
            this.labelFrenar.Text = "xxxxx";
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(31, 150);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(128, 23);
            this.buttonApagar.TabIndex = 9;
            this.buttonApagar.Text = "Apagar Auto";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelApagar
            // 
            this.labelApagar.AutoSize = true;
            this.labelApagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelApagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelApagar.Location = new System.Drawing.Point(3, 185);
            this.labelApagar.Name = "labelApagar";
            this.labelApagar.Size = new System.Drawing.Size(32, 13);
            this.labelApagar.TabIndex = 10;
            this.labelApagar.Text = "xxxxx";
            // 
            // buttonClaxon
            // 
            this.buttonClaxon.Location = new System.Drawing.Point(31, 194);
            this.buttonClaxon.Name = "buttonClaxon";
            this.buttonClaxon.Size = new System.Drawing.Size(56, 23);
            this.buttonClaxon.TabIndex = 11;
            this.buttonClaxon.Text = "Claxon";
            this.buttonClaxon.UseVisualStyleBackColor = true;
            this.buttonClaxon.Click += new System.EventHandler(this.buttonClaxon_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(595, 86);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(193, 102);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // buttonReproducir
            // 
            this.buttonReproducir.Location = new System.Drawing.Point(721, 194);
            this.buttonReproducir.Name = "buttonReproducir";
            this.buttonReproducir.Size = new System.Drawing.Size(67, 23);
            this.buttonReproducir.TabIndex = 14;
            this.buttonReproducir.Text = "Reproducir";
            this.buttonReproducir.UseVisualStyleBackColor = true;
            this.buttonReproducir.Click += new System.EventHandler(this.buttonReproducir_Click);
            // 
            // buttonParar
            // 
            this.buttonParar.Location = new System.Drawing.Point(595, 194);
            this.buttonParar.Name = "buttonParar";
            this.buttonParar.Size = new System.Drawing.Size(59, 23);
            this.buttonParar.TabIndex = 15;
            this.buttonParar.Text = "Apagar";
            this.buttonParar.UseVisualStyleBackColor = true;
            this.buttonParar.Click += new System.EventHandler(this.buttonParar_Click);
            // 
            // buttonPausar
            // 
            this.buttonPausar.Location = new System.Drawing.Point(660, 194);
            this.buttonPausar.Name = "buttonPausar";
            this.buttonPausar.Size = new System.Drawing.Size(55, 23);
            this.buttonPausar.TabIndex = 16;
            this.buttonPausar.Text = "Pausar";
            this.buttonPausar.UseVisualStyleBackColor = true;
            this.buttonPausar.Click += new System.EventHandler(this.buttonPausar_Click);
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hora.Location = new System.Drawing.Point(117, 41);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(154, 37);
            this.hora.TabIndex = 17;
            this.hora.Text = "xxxxx";
            this.hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fecha.Location = new System.Drawing.Point(130, 78);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(117, 20);
            this.fecha.TabIndex = 18;
            this.fecha.Text = "xxxxx";
            this.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.labelEncender);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.labelMarca);
            this.panel1.Controls.Add(this.labelApagar);
            this.panel1.Controls.Add(this.labelAcelerar);
            this.panel1.Controls.Add(this.labelFrenar);
            this.panel1.Location = new System.Drawing.Point(210, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 228);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // velocidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPausar);
            this.Controls.Add(this.buttonClaxon);
            this.Controls.Add(this.buttonParar);
            this.Controls.Add(this.buttonReproducir);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonAcelerar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "velocidad";
            this.Load += new System.EventHandler(this.velocidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Label labelEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelAcelerar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Label labelFrenar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelApagar;
        private System.Windows.Forms.Button buttonClaxon;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonReproducir;
        private System.Windows.Forms.Button buttonParar;
        private System.Windows.Forms.Button buttonPausar;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

