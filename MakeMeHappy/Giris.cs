using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeMeHappy
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form1 form = new Form1();
                char ayrac = ',';
                form.guzelSozler = (txtGuzel.Text.Split(ayrac));
                form.kotuSozler = (txtKotu.Text.Split(ayrac));
                form.Show();
        }
    }
}
