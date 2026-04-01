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
    public partial class Postavke : Form
    {
        float težina;
        bool detaljnaRaketa;
        public Postavke()
        {
            InitializeComponent();
        }

        private void labelaTežina_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gumbZavrši_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                težina = 1f;
            }
            else if (radioButton2.Checked)
            {
                težina = 1.25f;
            }
            else
            {
                težina = 1.5f;
            }

            if(checkBox1.Checked)
                detaljnaRaketa = true;

            StartForm menu = new StartForm(težina, detaljnaRaketa);
            Visible = false;
            menu.ShowDialog();
            Close();
            
        }
    }
}
