using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa
{
    public partial class Form1 : Form
    {
        public Form1(float težina, bool detaljnaRaketa)
        {
            InitializeComponent();
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            PocetnePostavke(težina, detaljnaRaketa);
            timer1.Start();
            DoubleBuffered = true;
            labelaBodovi.Parent = prepreka1;
            labelaBodovi1.Parent = prepreka2;
            labelaBodovi.Location = new Point(20, 0);
            labelaBodovi1.Location = new Point(20, 0);
            
         
        }

        Image pozadina = Properties.Resources.pozadina;
        Image zid = Properties.Resources.zid;
        float sirina, visina;
        float brzinaPozadine, brzinaZida, brzinaBroda;
        float[] koordPozadina, koordZid;
        bool kretanje;
        bool lijevo, desno;
        bool krajIgre;
        bool pauzirano;
        bool preprekaUnutra;

        Random generator = new Random();

        float težina;
        int bodovi;
        bool raketa;

        // za živote
        int brojŽivota;
        bool sudarProšliTick;

        // za bonus stvari
        bool oblak1prikazan;
        bool oblak2prikazan;

        // ovo nam treba za easy mode
        bool parni;
       

        void povecajBodove(int dobiveniBodovi)
        {
            bodovi += dobiveniBodovi;
            labelaBodovi.Text = "Bodovi: " + bodovi;
            labelaBodovi1.Text = "Bodovi: " + bodovi;
            switch (Math.Floor(Math.Log10(bodovi) + 1)) 
            {
                case 1:
                    labelaDno.Text = "Bodovi: 00" + bodovi;
                    break;
                case 2:
                    labelaDno.Text = "Bodovi: 0" + bodovi;
                    break;
                case 3:
                    labelaDno.Text = "Bodovi: " + bodovi;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pauzirano == false) 
            {
                if (e.KeyCode == Keys.Up && !kretanje)
                    kretanje = true;
                if (e.KeyCode == Keys.Left)
                    lijevo = true;
                if (e.KeyCode == Keys.Right)
                    desno = true;
            }
            if (e.KeyCode == Keys.P) 
            {
                pauzirano = pauzirano == true ? pauzirano = false : pauzirano = true;
                labelaPauza.Visible = labelaPauza.Visible == true ? false : true;
            }
               
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (pauzirano == false) 
            {
                if (e.KeyCode == Keys.Up && kretanje)
                    kretanje = false;
                if (e.KeyCode == Keys.Left)
                    lijevo = false;
                if (e.KeyCode == Keys.Right)
                    desno = false;
            }
            if(e.KeyCode == Keys.R && krajIgre)
            {
                PocetnePostavke(težina, raketa);
                timer1.Start();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if(!krajIgre)
            {
                labelaPauza.Visible = false;
                timer1.Start();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if(!krajIgre)
            {
                timer1.Stop();
                if(kretanje || lijevo || desno)
                    kretanje = lijevo = desno = false;
                labelaPauza.Visible = true;
            }
        }

        private void brod_Click(object sender, EventArgs e)
        {

        }

        private void prepreka1_Click(object sender, EventArgs e)
        {

        }

        private void labelaBodovi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelaRestartPoruka_Click(object sender, EventArgs e)
        {

        }

        private void PocetnePostavke(float težina, bool detaljnaRaketa)
        {
            // za izbore u početnom meniju
            this.težina = težina;
            this.raketa = detaljnaRaketa;

            // životi
            switch (težina) 
            {
                case 1f:
                    brojŽivota = 3;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    break;
                case 1.25f:
                    brojŽivota = 2;
                    pictureBox1.Visible = true; 
                    pictureBox2.Visible=true;
                    pictureBox3.Visible=false;
                    break;
                case 1.5f:
                    brojŽivota = 1;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    break;
            }
            /*brojŽivota = 3;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            sudarProšliTick = false;*/

            oblak1prikazan = false;
            oblak1.Visible = false;
            oblak2prikazan = false;
            oblak2.Visible = false;

            // stavi oblake negdje gore

            /*oblak1.Location = new Point(generator.Next((int)(0.2f * sirina),
                                               (int)(0.8 * sirina - oblak1.Width)),
                                -oblak1.Height);
            oblak2.Location = new Point(generator.Next((int)(0.2f * sirina),
                                                       (int)(0.8f * sirina - oblak2.Width)),
                                        -oblak2.Height);*/

            if (detaljnaRaketa) 
            {
                brod.Image = Properties.Resources.raketa1;
            }
            else 
            {
                brod.Image = Properties.Resources.brod;
            }

            progressBar1.Value = 1000;
            labelaPauza.Visible = false;
            krajIgre = false;
            labelaRestartPoruka.Visible = false;
            prepreka1.Location = new Point(10, 205);
            prepreka2.Location = new Point(205,10);
            oblak1.Location = new Point(10, 230);
            oblak2.Location = new Point(230, 45);

            bodovi = 0;
            povecajBodove(0);
            kretanje = false;
            lijevo = desno = false;
            parni = true;
            pauzirano = false;
            preprekaUnutra = true;
            brzinaPozadine = 0.5f * težina;
            brzinaZida = 4 * težina;
            brzinaBroda = 5 * težina;
            //koordPozadina = 0;
            //koordZid = 0;
            koordPozadina = new float[] { -visina, 0 };
            koordZid = new float[] { -visina, 0 };
        
            brod.Location = new Point(
                (int)sirina / 2 - brod.Size.Width / 2,
                (int)visina - brod.Size.Height - 40);
        }
        private void PomakniPozadinu()
        {
            for(int i = 0; i < 2; i++)
            {
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                if (koordZid[i] > visina)
                    koordZid[i] -= 2 * visina;
               
                if (kretanje)
                {
                    koordPozadina[i] += brzinaPozadine;
                    koordZid[i] += brzinaZida;
                    
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // ako je igra pauzirana, ne radi ništa!
            if (pauzirano) 
            {
                labelaPauza.Visible = true;
                return;
            }

            // promijeni parnost
            parni = parni == true ? false : true;
           
            PomakniPozadinu();
            if (lijevo && !desno &&
                brod.Left - brzinaBroda >= 0.1 * sirina)
                    brod.Left -= (int)brzinaBroda;
            if (desno && !lijevo &&
                brod.Right + brzinaBroda <= 0.9 * sirina)
                    brod.Left += (int)brzinaBroda;
            if (preprekaUnutra)
            {
                prepreka1.Left += 5;
                prepreka2.Left -= 5;
                if (prepreka1.Left >= 550 / 2 && prepreka2.Left <= 550 / 2)
                {
                    preprekaUnutra = false;
                }
            }
            else 
            {
                prepreka1.Left -= 5;
                prepreka2.Left += 5;
                if (prepreka1.Left <= 100 && prepreka2.Left >= 300) 
                {
                    preprekaUnutra = true;
                }
            }
            if (kretanje)
            {
                prepreka1.Top += (int)brzinaZida;
                prepreka2.Top += (int)brzinaZida;
                if (prepreka1.Top > visina)
                {
                    povecajBodove(1);
                    prepreka1.Top = -prepreka1.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }
                if (prepreka2.Top > visina)
                {
                    povecajBodove(1);
                    prepreka2.Top = -prepreka2.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }

                // i sad analogno za oblake
                if (oblak1prikazan)
                {
                    oblak1.Top += (int)brzinaZida;
                    if (oblak1.Top > visina)
                    {
                        oblak1.Visible = false;
                        oblak1prikazan = false;

                    }


                }
                if (oblak2prikazan)
                {
                    oblak2.Top += (int)brzinaZida;
                    if (oblak2.Top > visina)
                    {
                        oblak2.Visible = false;
                        oblak2prikazan = false;
                    }

                }

            }
            switch (težina)
            {
                case 1f:
                    if (parni)
                    progressBar1.Value -= 1;
                    break;
                case 1.25f:
                    progressBar1.Value -= 1;
                    break;
                case 1.5f:
                    progressBar1.Value -= 2;
                    break;
            }

            


            Invalidate();
            if (brod.Bounds.IntersectsWith(prepreka1.Bounds)
                || brod.Bounds.IntersectsWith(prepreka2.Bounds)
                ) 
            
            {
                if (!sudarProšliTick)
                {
                    switch (brojŽivota)
                    {
                        case 3:
                            brojŽivota = 2;
                            pictureBox3.Visible = false;
                            if (bodovi >= 5)
                                povecajBodove(-5);
                            break;
                        case 2:
                            brojŽivota = 1;
                            pictureBox2.Visible = false;
                            if (bodovi >= 5)
                                povecajBodove(-5);
                            break;
                        case 1:
                            pictureBox1.Visible = false;
                            GameOver();
                            break;
                    }


                }

                sudarProšliTick = true;
                
            }

            else
            {
                sudarProšliTick = false;
            }

            if (progressBar1.Value == 0)
                GameOver();
                   

            // provjera sudara s oblacicima

            if (brod.Bounds.IntersectsWith(oblak1.Bounds) && oblak1prikazan) 
            {
                povecajBodove(3);
                oblak1prikazan = false;
                oblak1.Visible = false;

            }

            if (brod.Bounds.IntersectsWith(oblak2.Bounds) && oblak2prikazan) 
            {
                povecajBodove(3);
                oblak2prikazan = false;
                oblak2.Visible = false;
            }

            int broj = generator.Next(0, 5000);
            if (broj % 13 == 0) 
            {
                
                if (broj % 2 == 0 && !oblak1prikazan)
                {
                    oblak1prikazan = true;
                    oblak1.Visible = true;
            
                    oblak1.Top = -oblak1.Height;
                    // stavi ga negdje između izdova
                    oblak1.Left = generator.Next((int)(0.2f * sirina),
                                                 (int)(0.8f * sirina - oblak1.Width));
                    // da se ne preklapaju
                    while (oblak2prikazan && oblak1.Bounds.IntersectsWith(oblak2.Bounds)) 
                    {
                        oblak1.Left = generator.Next((int)(0.2f * sirina),
                                                (int)(0.8f * sirina - oblak1.Width));
                    }
                }
                else if (!oblak2prikazan)
                {
                    oblak2prikazan = true;
                    oblak2.Visible = true;
                   
                    oblak2.Top = -oblak2.Height;
             
                    oblak2.Left = generator.Next((int)(0.2f * sirina),
                                                 (int)(0.8f * sirina - oblak2.Width));
                    while (oblak1prikazan && oblak2.Bounds.IntersectsWith(oblak1.Bounds)) 
                    {
                        oblak2.Left = generator.Next((int)(0.2f * sirina),
                                                 (int)(0.8f * sirina - oblak2.Width));
                    }
                }
            }
           
        }

        private void GameOver()
        {
            timer1.Stop();
            krajIgre = true;
            labelaRestartPoruka.Visible = true;
            MessageBox.Show("Osvojeni bodovi: " + bodovi,
                "Igra je završila!");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i], sirina, visina);
            }
            for (int i = 0; i < 2; i++)
            {
                e.Graphics.DrawImage(zid, 0, koordZid[i], 0.1f * sirina, visina);
                e.Graphics.DrawImage(zid, 0.9f * sirina, koordZid[i],
                    0.1f * sirina, visina);
            }
        }
    }
}
