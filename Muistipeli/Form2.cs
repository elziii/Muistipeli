using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form2 : Form
    {
        bool pelaaja1 = true, pelaaja2 = false;
        string vaikeustaso, pelaajamäärä,aihealue;
        int koko;
        Button ensimmainen = null;
        Button toinen = null;
        Random rand = new Random();
        int random;
        int parit = 0, p2parit = 0;
        Form1 menu;

        List<Bitmap> kuvat = new List<Bitmap>();
        List<PictureBox> pictureBox = new List<PictureBox>();
        List<Button> napit = new List<Button>();

        public Form2(string vaikeus, string pelaajat, string aihe, Form1 f1)
        {
            InitializeComponent();
            vaikeustaso = vaikeus;
            pelaajamäärä = pelaajat;
            aihealue = aihe;
            menu = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (vaikeustaso == "Helppo")
            {
                koko = 4;
            }
            else if (vaikeustaso == "Vaikea")
            {
                koko = 6;
            }

            if (pelaajamäärä == "Kaksi")
            {
                pVuoro.Text = "Pelaaja 1";
                p1Parit.Text = "Pelaaja 1: 0";
                p2Parit.Text = "Pelaaja 2: 0";
            }

            Kuvat();
            AsetaKuvat();
        }

        private void AsetaKuvat()
        {
            for (int a = 0; a < koko; a++)
            {
                for(int b = 0; b < 4; b++)
                {
                    PictureBox kuva = new PictureBox();
                    kuva.Size = new Size(80, 80);
                    kuva.Location = new Point(a * 85, b * 85);
                    pictureBox.Add(kuva);
                    this.Controls.Add(kuva);
                }
            }

            foreach (PictureBox kuva in pictureBox)
            {
                random = rand.Next(kuvat.Count);
                kuva.Image = kuvat[random];
                kuva.SizeMode = PictureBoxSizeMode.StretchImage;

                Button nappi = new Button();
                nappi.Size = kuva.Size;
                nappi.Location = kuva.Location;
                nappi.Text = "?";
                nappi.Font = new Font("Arial", 50);
                nappi.Click += new EventHandler(this.NappulaClick);
                nappi.Tag = kuva.Image.Tag;
                nappi.TabStop = false;
                napit.Add(nappi);
                this.Controls.Add(nappi);
                nappi.BringToFront();
                kuvat.RemoveAt(random);
            }
        }

        private void NappulaClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Visible = false;

            if(ensimmainen == null)
            {
                ensimmainen = btn;
            }
            else
            {
                toinen = btn;
                Odota(500);
            }

            if (ensimmainen != null && toinen != null)
            {
                if (pelaajamäärä == "Yksi")
                {
                    YksinpeliCheck();
                }
                else
                {
                    KaksinpeliCheck();
                }
            }
        }

        private void Kuvat()
        {
            int i = 1;
            #region eläinkuvat
            //ResourceSet koe = Properties.Resources. .ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            //foreach (DictionaryEntry kuva in koe)
            //{
            //    Bitmap uusiKuva = kuva.Value as Bitmap;

            //    uusiKuva.Tag = i;
            //    kuvat.Add(uusiKuva);
            //    i++;
            //}
            Bitmap kuva1 = Properties.Resources.apina;
            Bitmap kuva2 = Properties.Resources.hevonen;
            Bitmap kuva3 = Properties.Resources.kala1;
            Bitmap kuva4 = Properties.Resources.kala2;
            Bitmap kuva5 = Properties.Resources.karhu;
            Bitmap kuva6 = Properties.Resources.kilppari;
            Bitmap kuva7 = Properties.Resources.kissa;
            Bitmap kuva8 = Properties.Resources.koira;
            Bitmap kuva9 = Properties.Resources.lammas;
            Bitmap kuva10 = Properties.Resources.lintu1;
            Bitmap kuva11 = Properties.Resources.lintu2;
            Bitmap kuva12 = Properties.Resources.norsu;

            kuva1.Tag = 1;
            kuva2.Tag = 2;
            kuva3.Tag = 3;
            kuva4.Tag = 4;
            kuva5.Tag = 5;
            kuva6.Tag = 6;
            kuva7.Tag = 7;
            kuva8.Tag = 8;
            kuva9.Tag = 9;
            kuva10.Tag = 10;
            kuva11.Tag = 11;
            kuva12.Tag = 12;

            if (aihealue == "Eläimet")
            {
                kuvat.Add(kuva1);
                kuvat.Add(kuva1);
                kuvat.Add(kuva2);
                kuvat.Add(kuva2);
                kuvat.Add(kuva3);
                kuvat.Add(kuva3);
                kuvat.Add(kuva4);
                kuvat.Add(kuva4);
                kuvat.Add(kuva5);
                kuvat.Add(kuva5);
                kuvat.Add(kuva6);
                kuvat.Add(kuva6);
                kuvat.Add(kuva7);
                kuvat.Add(kuva7);
                kuvat.Add(kuva8);
                kuvat.Add(kuva8);
                if (vaikeustaso == "Vaikea")
                {

                    kuvat.Add(kuva9);
                    kuvat.Add(kuva9);
                    kuvat.Add(kuva10);
                    kuvat.Add(kuva10);
                    kuvat.Add(kuva11);
                    kuvat.Add(kuva11);
                    kuvat.Add(kuva12);
                    kuvat.Add(kuva12);
                }
            }
            #endregion
            #region runet
            Bitmap kuva13 = Properties.Resources.air;
            Bitmap kuva14= Properties.Resources.astral;
            Bitmap kuva15= Properties.Resources.blood;
            Bitmap kuva16= Properties.Resources.chaos;
            Bitmap kuva17= Properties.Resources.cosmic;
            Bitmap kuva18= Properties.Resources.death;
            Bitmap kuva19= Properties.Resources.earth;
            Bitmap kuva20= Properties.Resources.fire;
            Bitmap kuva21= Properties.Resources.law;
            Bitmap kuva22 = Properties.Resources.nature;
            Bitmap kuva23 = Properties.Resources.soul;
            Bitmap kuva24 = Properties.Resources.water;

            kuva13.Tag = 13;
            kuva14.Tag = 14;
            kuva15.Tag = 15;
            kuva16.Tag = 16;
            kuva17.Tag = 17;
            kuva18.Tag = 18;
            kuva19.Tag = 19;
            kuva20.Tag = 20;
            kuva21.Tag = 21;
            kuva22.Tag = 22;
            kuva23.Tag = 23;
            kuva24.Tag = 24;

            if (aihealue == "Runet")
            {
                kuvat.Add(kuva13);
                kuvat.Add(kuva13);
                kuvat.Add(kuva14);
                kuvat.Add(kuva14);
                kuvat.Add(kuva15);
                kuvat.Add(kuva15);
                kuvat.Add(kuva16);
                kuvat.Add(kuva16);
                kuvat.Add(kuva17);
                kuvat.Add(kuva17);
                kuvat.Add(kuva18);
                kuvat.Add(kuva18);
                kuvat.Add(kuva19);
                kuvat.Add(kuva19);
                kuvat.Add(kuva20);
                kuvat.Add(kuva20);
                if (vaikeustaso == "Vaikea")
                {

                    kuvat.Add(kuva21);
                    kuvat.Add(kuva21);
                    kuvat.Add(kuva22);
                    kuvat.Add(kuva22);
                    kuvat.Add(kuva23);
                    kuvat.Add(kuva23);
                    kuvat.Add(kuva24);
                    kuvat.Add(kuva24);
                }
            }
            #endregion
        }

        private void YksinpeliCheck()
        {
            if (ensimmainen.Tag == toinen.Tag)
            {
                parit++;
                p1Parit.Text = "Parit: " + parit;
                labelPari.Text = "Sait parin!";
                napit.Remove(ensimmainen);
                napit.Remove(toinen);
                ensimmainen = null;
                toinen = null;
            }
            else
            {
                labelPari.Text = "Ei paria";
                ensimmainen.Visible = true;
                toinen.Visible = true;
                ensimmainen = null;
                toinen = null;
            }
            PeliLoppuuYP();
        }

        private void KaksinpeliCheck()
        {
            if (ensimmainen.Tag == toinen.Tag)
            {
                if(pelaaja1 == true)
                {
                    parit++;
                    p1Parit.Text = "Pelaaja 1: " + parit;
                    labelPari.Text = "Pelaaja 1 sai parin!";
                    napit.Remove(ensimmainen);
                    napit.Remove(toinen);
                    ensimmainen = null;
                    toinen = null;
                }
                else if (pelaaja2 == true)
                {
                    p2parit++;
                    p2Parit.Text = "Pelaaja 2: " + p2parit;
                    labelPari.Text = "Pelaaja 2 sai parin!";
                    napit.Remove(ensimmainen);
                    napit.Remove(toinen);
                    ensimmainen = null;
                    toinen = null;
                }
            }
            else
            {
                PeliVuoro();
                labelPari.Text = "Ei paria";
                ensimmainen.Visible = true;
                toinen.Visible = true;
                ensimmainen = null;
                toinen = null;
            }
            PeliLoppuuKP();
        }

        private void PeliVuoro()
        {
            if (pelaaja1 == true)
            {
                pelaaja1 = false;
                pelaaja2 = true;
                pVuoro.Text = "Pelaaja 2";
            }
            else if (pelaaja2 == true)
            {
                pelaaja2 = false;
                pelaaja1 = true;
                pVuoro.Text = "Pelaaja 1";
            }
        }

        private void PeliLoppuuYP()
        {
            if (napit.Count == 0)
            {
                menu.ypParit = menu.ypParit + parit;
                labelPari.Text = "Peli loppui. Palataan valikkoon";
                Odota(1500);
                this.Close();
            }
        }

        private void PeliLoppuuKP()
        {
            if (napit.Count == 0)
            {
                labelPari.Text = "Peli loppui. Palataan valikkoon";
                if (pelaajamäärä == "Kaksi")
                {
                    if (parit > p2parit)
                    {
                        labelPari.Text = "Pelaaja 1 voitti. Palataan valikkoon";
                        menu.p1Voitot++;
                    }
                    if (parit < p2parit)
                    {
                        labelPari.Text = "Pelaaja 2 voitti. Palataan valikkoon";
                        menu.p2Voitot++;
                    }
                }
                Odota(2500);
                this.Close();
            }
        }

        private void Odota(int ms)
        {
            Timer timer1 = new Timer();
            timer1.Interval = ms;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
                foreach(Button btn in napit)
                {
                    btn.Enabled = false;
                }
            }
            foreach (Button btn in napit)
            {
                btn.Enabled = true;
            }
        }


    }
}
