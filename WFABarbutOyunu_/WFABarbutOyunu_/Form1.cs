using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WFABarbutOyunu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int maviOyuncuSkor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMaviOyuncuZarAt.Enabled = false;
        }

        private void btnKirmiziOyuncuZarAt_Click(object sender, EventArgs e)
        {
            int kirmiziOyuncuZar = rnd.Next(1, 7);
            lblKirmiziOyuncuZar.Text = kirmiziOyuncuZar.ToString();
            btnKirmiziOyuncuZarAt.Enabled = false;
            btnMaviOyuncuZarAt.Enabled = true;

            
            
        }

        private void btnMaviOyuncuZarAt_Click(object sender, EventArgs e)
        {
            int maviOyuncuZar = rnd.Next(1, 7);
            lblMaviOyuncuZar.Text = maviOyuncuZar.ToString();
            btnKirmiziOyuncuZarAt.Enabled = true;
            btnMaviOyuncuZarAt.Enabled = false;
            
            int MaviOyuncuZar = Convert.ToInt32(lblMaviOyuncuZar.Text);
            int KirmiziOyuncuZar = Convert.ToInt32(lblKirmiziOyuncuZar.Text);

            if ( KirmiziOyuncuZar == MaviOyuncuZar)
            {
                lblSonuc.Text = "Beraberlik";
            }
            else if ( KirmiziOyuncuZar > MaviOyuncuZar)
            {

                int KirmiziOyuncuSkor = Convert.ToInt32(lblKirmiziOyuncuSkor.Text);
                KirmiziOyuncuSkor++;
                lblKirmiziOyuncuSkor.Text = KirmiziOyuncuSkor.ToString();

                lblSonuc.Text = "Kırmızı Oyuncu Kazandı ";
            }
            else
            {
                maviOyuncuSkor++;
                lblMaviOyuncuSkor.Text = maviOyuncuSkor.ToString() ;
                lblSonuc.Text = "Mavi Oyuncu Kazandı";
            }

        }


    }

}
