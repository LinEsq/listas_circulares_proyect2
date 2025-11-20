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
            this.btnSiguient = new System.Windows.Forms.Button();
            this.btnReinicia = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(125, 11);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(707, 391);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lblNombreCa
            // 
            this.lblNombreCa.AutoSize = true;
            this.lblNombreCa.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreCa.Location = new System.Drawing.Point(164, 448);
            this.lblNombreCa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCa.Name = "lblNombreCa";
            this.lblNombreCa.Size = new System.Drawing.Size(0, 19);
            this.lblNombreCa.TabIndex = 1;
            // 
            // btnSiguient
            // 
            this.btnSiguient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSiguient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiguient.Location = new System.Drawing.Point(278, 448);
            this.btnSiguient.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguient.Name = "btnSiguient";
            this.btnSiguient.Size = new System.Drawing.Size(80, 30);
            this.btnSiguient.TabIndex = 3;
            this.btnSiguient.Text = "Siguiente";
            this.btnSiguient.UseVisualStyleBackColor = false;
            this.btnSiguient.Click += new System.EventHandler(this.btnSiguient_Click_1);
            // 
            // btnReinicia
            // 
            this.btnReinicia.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReinicia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReinicia.Location = new System.Drawing.Point(418, 448);
            this.btnReinicia.Margin = new System.Windows.Forms.Padding(2);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(80, 30);
            this.btnReinicia.TabIndex = 4;
            this.btnReinicia.Text = "Reiniciar";
            this.btnReinicia.UseVisualStyleBackColor = false;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnterior.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnterior.Location = new System.Drawing.Point(564, 448);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 30);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(940, 510);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnReinicia);
            this.Controls.Add(this.btnSiguient);
            this.Controls.Add(this.lblNombreCa);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblNombreCa;
        private System.Windows.Forms.Button btnSiguient;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.Button btnAnterior;
    }
}

