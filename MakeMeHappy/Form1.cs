using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace MakeMeHappy
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> iltifat = new Dictionary<string, string>();
        public string[] guzelSozler;
        public string[] kotuSozler;
        string[] guzelResimler = new string[5];
        string[] kotuResimler = new string[5];
        int no;
        public Form1()
        {
            InitializeComponent();
        }
        public void Doldur()
        {
            guzelResim();
            kotuResim();
            iltifat.Clear();
            string guzel, kotu;
            for(int i = 0; i < guzelSozler.Length; i++)
            {
                guzel = guzelResimGetir();
                kotu = kotuResimGetir();
                iltifat.Add(guzelSozler[i].ToString(),guzel);
                iltifat.Add(kotuSozler[i].ToString(),kotu);
            }
        }
        public void guzelResim()
        {
            guzelResimler[0] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\happy1.jpg";
            guzelResimler[1] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\happy2.jpg";
            guzelResimler[2] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\happy3.jpg";
            guzelResimler[3] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\happy4.jpg";
            guzelResimler[4] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\happy5.jpg";
        }
        public string guzelResimGetir()
        {
            Random rastgele = new Random();
            no = rastgele.Next(0, 5);
            return guzelResimler[no];
        }
        public void kotuResim()
        {
            kotuResimler[0] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\sad1.jpg";
            kotuResimler[1] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\sad2.jpg";
            kotuResimler[2] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\sad3.jpg";
            kotuResimler[3] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\sad4.jpg";
            kotuResimler[4] = AppDomain.CurrentDomain.BaseDirectory + "MakeMeHappy\\sad5.jpg";
        }
        public string kotuResimGetir()
        {
            Random rastgele = new Random();
            no = rastgele.Next(0, 5);
            return kotuResimler[no];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
            Dictionary<string, string>.KeyCollection AnahtarListesi = iltifat.Keys;
            foreach (string Anahtar in AnahtarListesi)
                cmbSozler.Items.Add(Anahtar);
        }

        private void cmbSozler_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, string> iltifatlar in iltifat) 
            {
                if(cmbSozler.SelectedItem.ToString() == iltifatlar.Key)
                {
                    pctResim.ImageLocation = iltifatlar.Value;
                }
            }
        }
    }
}
