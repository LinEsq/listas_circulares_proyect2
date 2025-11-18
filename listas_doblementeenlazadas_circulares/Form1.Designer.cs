namespace listas_doblementeenlazadas_circulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblNombreCa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguient = new System.Windows.Forms.Button();
            this.btnReinicia = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(187, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(843, 444);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lblNombreCa
            // 
            this.lblNombreCa.AutoSize = true;
            this.lblNombreCa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreCa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreCa.Location = new System.Drawing.Point(826, 503);
            this.lblNombreCa.Name = "lblNombreCa";
            this.lblNombreCa.Size = new System.Drawing.Size(0, 16);
            this.lblNombreCa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(568, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "l";
            // 
            // btnSiguient
            // 
            this.btnSiguient.Location = new System.Drawing.Point(72, 480);
            this.btnSiguient.Name = "btnSiguient";
            this.btnSiguient.Size = new System.Drawing.Size(75, 23);
            this.btnSiguient.TabIndex = 3;
            this.btnSiguient.Text = "Siguiente";
            this.btnSiguient.UseVisualStyleBackColor = true;
            this.btnSiguient.Click += new System.EventHandler(this.btnSiguient_Click_1);
            // 
            // btnReinicia
            // 
            this.btnReinicia.Location = new System.Drawing.Point(205, 480);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(75, 23);
            this.btnReinicia.TabIndex = 4;
            this.btnReinicia.Text = "Reiniciar";
            this.btnReinicia.UseVisualStyleBackColor = true;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(356, 480);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 554);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnReinicia);
            this.Controls.Add(this.btnSiguient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreCa);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblNombreCanal;
        private System.Windows.Forms.Label lblNombreCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguient;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.Button btnAnterior;
    }
}

