using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raketa
{
    public partial class StartForm : Form
    {
        Image pozadina = Properties.Resources.pozadina;
        float sirina, visina;
        float težina;
        bool detaljnaRaketa;
        public StartForm()
        {
            InitializeComponent();
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            težina = 1f;
            detaljnaRaketa = false;
        }

        public StartForm(float težinaIzbor, bool raketaIzbor) 
        {
            InitializeComponent();
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            težina = težinaIzbor;
            detaljnaRaketa = raketaIzbor;
        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbPokreni_Click(object sender, EventArgs e)
        {
            Form1 formaZaIgru = new Form1(težina, detaljnaRaketa);
            Visible = false;
            formaZaIgru.ShowDialog();
            Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            težina = 1f;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            težina = 1.25f;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            težina = 1.5f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            detaljnaRaketa = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            detaljnaRaketa = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void gumbPostavke_Click(object sender, EventArgs e)
        {
            Postavke novePostavke = new Postavke();
            Visible = false;
            novePostavke.ShowDialog();
            Close();
        }

        private void StartForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pozadina, 0, 0, sirina, visina);
        }
    }
}
