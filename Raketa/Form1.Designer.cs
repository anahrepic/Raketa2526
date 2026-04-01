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
            this.labelaBodovi1 = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelaDno = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.brod = new System.Windows.Forms.PictureBox();
            this.oblak2 = new System.Windows.Forms.PictureBox();
            this.oblak1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak1)).BeginInit();
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
            this.labelaBodovi.BackColor = System.Drawing.Color.Tomato;
            this.labelaBodovi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaBodovi.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi.ForeColor = System.Drawing.SystemColors.Window;
            this.labelaBodovi.Location = new System.Drawing.Point(362, 399);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(143, 39);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
            this.labelaBodovi.Click += new System.EventHandler(this.labelaBodovi_Click);
            // 
            // labelaBodovi1
            // 
            this.labelaBodovi1.AutoSize = true;
            this.labelaBodovi1.BackColor = System.Drawing.Color.Tomato;
            this.labelaBodovi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaBodovi1.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaBodovi1.ForeColor = System.Drawing.SystemColors.Window;
            this.labelaBodovi1.Location = new System.Drawing.Point(362, 351);
            this.labelaBodovi1.Name = "labelaBodovi1";
            this.labelaBodovi1.Size = new System.Drawing.Size(143, 39);
            this.labelaBodovi1.TabIndex = 4;
            this.labelaBodovi1.Text = "Bodovi: 0";
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.Tomato;
            this.labelaRestartPoruka.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaRestartPoruka.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelaRestartPoruka.Location = new System.Drawing.Point(140, 237);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(250, 100);
            this.labelaRestartPoruka.TabIndex = 5;
            this.labelaRestartPoruka.Text = "Pritisnite R za ponovnu igru.";
            this.labelaRestartPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelaRestartPoruka.Click += new System.EventHandler(this.labelaRestartPoruka_Click);
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Transparent;
            this.labelaPauza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelaPauza.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaPauza.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelaPauza.Location = new System.Drawing.Point(140, 173);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(243, 39);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.labelaDno);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 42);
            this.panel1.TabIndex = 11;
            // 
            // labelaDno
            // 
            this.labelaDno.AutoSize = true;
            this.labelaDno.BackColor = System.Drawing.Color.Transparent;
            this.labelaDno.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaDno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelaDno.Location = new System.Drawing.Point(357, 4);
            this.labelaDno.Name = "labelaDno";
            this.labelaDno.Size = new System.Drawing.Size(153, 31);
            this.labelaDno.TabIndex = 12;
            this.labelaDno.Text = "Bodovi: 000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Raketa.Properties.Resources.srce;
            this.pictureBox3.Location = new System.Drawing.Point(119, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Raketa.Properties.Resources.srce;
            this.pictureBox2.Location = new System.Drawing.Point(60, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Raketa.Properties.Resources.srce;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prepreka2
            // 
            this.prepreka2.Image = ((System.Drawing.Image)(resources.GetObject("prepreka2.Image")));
            this.prepreka2.Location = new System.Drawing.Point(298, 22);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(222, 43);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // prepreka1
            // 
            this.prepreka1.Image = ((System.Drawing.Image)(resources.GetObject("prepreka1.Image")));
            this.prepreka1.Location = new System.Drawing.Point(12, 277);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(222, 43);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            this.prepreka1.Click += new System.EventHandler(this.prepreka1_Click);
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Location = new System.Drawing.Point(233, 371);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(64, 107);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            this.brod.Click += new System.EventHandler(this.brod_Click);
            // 
            // oblak2
            // 
            this.oblak2.Image = ((System.Drawing.Image)(resources.GetObject("oblak2.Image")));
            this.oblak2.Location = new System.Drawing.Point(349, 88);
            this.oblak2.Name = "oblak2";
            this.oblak2.Size = new System.Drawing.Size(100, 74);
            this.oblak2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oblak2.TabIndex = 9;
            this.oblak2.TabStop = false;
            this.oblak2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // oblak1
            // 
            this.oblak1.Image = ((System.Drawing.Image)(resources.GetObject("oblak1.Image")));
            this.oblak1.Location = new System.Drawing.Point(127, 338);
            this.oblak1.Name = "oblak1";
            this.oblak1.Size = new System.Drawing.Size(100, 74);
            this.oblak1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oblak1.TabIndex = 10;
            this.oblak1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(532, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi1);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.brod);
            this.Controls.Add(this.oblak2);
            this.Controls.Add(this.oblak1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblak1)).EndInit();
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
        private System.Windows.Forms.PictureBox oblak2;
        private System.Windows.Forms.PictureBox oblak1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelaDno;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

