using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin = "";
        int sifre = 0;
        string sifrelenmisMetin = "";
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sifrelenmisMetin = "";
            try
            {
                sifre = Convert.ToInt32(nudSifrelemeSayi.Value);
                metin = rchTxtMetin.Text;
                char[] karakterler = metin.ToCharArray();
                foreach (var element in karakterler)
                {
                    sifrelenmisMetin += Convert.ToChar(element + sifre).ToString();
                }
                rchTxtSifre.Text = sifrelenmisMetin;
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metin = "";
            try
            {
                sifre = Convert.ToInt32(nudSifrelemeSayi.Value);
                sifrelenmisMetin = rchTxtSifre.Text;
                char[] karakterler = sifrelenmisMetin.ToCharArray();
                foreach (var element in karakterler)
                {
                    metin += Convert.ToChar(element - sifre).ToString();
                }
                rchTxtMetin.Text = metin;
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rchTxtMetin.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rchTxtSifre.Clear();
        }
    }
}
