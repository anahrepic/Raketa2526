namespace Raketa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaBodovi = new System.Windows.Forms.Label();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.brod = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.labelaBodovi1 = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaBodovi
            // 
            this.labelaBodovi.AutoSize = true;
            this.labelaBodovi.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi.ForeColor = System.Drawing.SystemColors.Window;
            this.labelaBodovi.Location = new System.Drawing.Point(12, 502);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(168, 39);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
            // 
            // prepreka1
            // 
            this.prepreka1.Image = global::Raketa.Properties.Resources.prepreka;
            this.prepreka1.Location = new System.Drawing.Point(12, 277);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(222, 43);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Image = global::Raketa.Properties.Resources.brod;
            this.brod.Location = new System.Drawing.Point(217, 434);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(64, 107);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.Image = global::Raketa.Properties.Resources.prepreka;
            this.prepreka2.Location = new System.Drawing.Point(298, 22);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(222, 43);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // labelaBodovi1
            // 
            this.labelaBodovi1.AutoSize = true;
            this.labelaBodovi1.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi1.ForeColor = System.Drawing.SystemColors.Window;
            this.labelaBodovi1.Location = new System.Drawing.Point(12, 449);
            this.labelaBodovi1.Name = "labelaBodovi1";
            this.labelaBodovi1.Size = new System.Drawing.Size(168, 39);
            this.labelaBodovi1.TabIndex = 4;
            this.labelaBodovi1.Text = "Bodovi: 0";
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.Yellow;
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaRestartPoruka.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelaRestartPoruka.Location = new System.Drawing.Point(140, 235);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(250, 85);
            this.labelaRestartPoruka.TabIndex = 5;
            this.labelaRestartPoruka.Text = "Pritisnite R za ponovnu igru.";
            this.labelaRestartPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Red;
            this.labelaPauza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPauza.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelaPauza.Location = new System.Drawing.Point(120, 164);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(298, 39);
            this.labelaPauza.TabIndex = 6;
            this.labelaPauza.Text = "Igra je pauzirana!";
            this.labelaPauza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(208, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi1);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.brod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaBodovi;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaBodovi1;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

