using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AHPyöntemi_algoritma
{
    public partial class Form1 : Form
    {
        
        Dictionary<int, string> konum = new Dictionary<int, string>();
        Dictionary<int, string> kriter = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
           

        }
        int[] dizi = new int[5];
        public void button1_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(textBox1.Text);
            int ulaşım = Convert.ToInt32(textBox3.Text);
            int oda = Convert.ToInt32(textBox4.Text);
            int kat = Convert.ToInt32(textBox5.Text);
            int ısıtma = Convert.ToInt32(textBox6.Text);
            kriter.Add(fiyat, "fiyat");
            kriter.Add(ulaşım, "ulaşım");
            kriter.Add(ısıtma, "ısıtma");
            kriter.Add(kat, "kat");
            kriter.Add(oda, "oda");
           
            if (konum[1] == "çankaya")
            {
                for(int i = 1; i < 6; i++)
                {
                    if (kriter[i] == kriter[fiyat])
                    {
                        kriter[1] = 0.38.ToString();
                    }
                    else if (kriter[i] == kriter[ulaşım])
                    {
                        kriter[2] = 0.316.ToString();
                    }
                    else if (kriter[i] == kriter[oda])
                    {
                        kriter[3] = 0.38.ToString();
                    }
                    else if (kriter[i] == kriter[kat])
                    {
                        kriter[4] = 0.38.ToString();
                    }
                    else if (kriter[i] == kriter[ısıtma])
                    {
                        kriter[5] = 0.25.ToString();
                    }

                }
               
                if ( textBox1.Text == 1.ToString()) //BU KISIM FİYAT İÇİN
                {
                 fiyat = Convert.ToInt32(kriter[fiyat]);
                 double önem1fiyat = fiyat * 0.4195;
                }
                else if (textBox1.Text == 2.ToString())
                {
                 fiyat = Convert.ToInt32(kriter[fiyat]);
                 double önem2fiyat = fiyat * 0.216;
                }
                else if (textBox1.Text == 3.ToString())
                {
                    fiyat = Convert.ToInt32(kriter[fiyat]);
                    double önem3fiyat = fiyat * 0.112;
                }
                else if (textBox1.Text == 4.ToString())
                {
                    fiyat = Convert.ToInt32(kriter[fiyat]);
                    double önem4fiyat = fiyat * 0.056;
                }
                else if (textBox1.Text == 5.ToString())
                {
                    fiyat = Convert.ToInt32(kriter[fiyat]);
                    double önem5fiyat = fiyat * 0.028;
                }



                if (textBox3.Text == 1.ToString()) //BU KISIM ULAŞIM İÇİN
                {
                    ulaşım = Convert.ToInt32(kriter[ulaşım]);
                    double önem1ulaşım = ulaşım * 0.4195;
                }
                else if (textBox3.Text == 2.ToString())
                {
                    ulaşım = Convert.ToInt32(kriter[ulaşım]);
                    double önem2ulaşım = ulaşım * 0.216;
                }
                else if (textBox3.Text == 3.ToString())
                {
                    ulaşım = Convert.ToInt32(kriter[ulaşım]);
                    double önem3ulaşım = ulaşım * 0.112;
                }
                else if (textBox3.Text == 4.ToString())
                {
                    ulaşım = Convert.ToInt32(kriter[ulaşım]);
                    double önem4ulaşım = ulaşım * 0.056;
                }
                else if (textBox3.Text == 5.ToString())
                {
                    ulaşım = Convert.ToInt32(kriter[ulaşım]);
                    double önem5ulaşım = ulaşım * 0.0028;
                }



                if (textBox4.Text == 1.ToString()) //BU KISIM ODA İÇİN
                {
                    oda = Convert.ToInt32(kriter[oda]);
                    double önem1oda = oda * 0.4195;
                }
                else if (textBox4.Text == 2.ToString())
                {
                    oda = Convert.ToInt32(kriter[oda]);
                    double önem2oda = oda * 0.216;
                }
                else if (textBox4.Text == 3.ToString())
                {
                    oda = Convert.ToInt32(kriter[oda]);
                    double önem3oda = oda * 0.112;
                }
                else if (textBox4.Text == 4.ToString())
                {
                    oda = Convert.ToInt32(kriter[oda]);
                    double önem4oda = oda * 0.056;
                }
                else if (textBox4.Text == 5.ToString())
                {
                    oda = Convert.ToInt32(kriter[oda]);
                    double önem5oda = oda * 0.028;
                }


                if (textBox5.Text == 1.ToString()) //BU KISIM KAT İÇİN
                {
                    kat = Convert.ToInt32(kriter[kat]);
                    double önem1kat = oda * 0.4195;
                }
                else if (textBox5.Text == 2.ToString())
                {
                    kat = Convert.ToInt32(kriter[kat]);
                    double önem2kat = oda * 0.216;
                }
                else if (textBox5.Text == 3.ToString())
                {
                    kat = Convert.ToInt32(kriter[kat]);
                    double önem3kat=kat * 0.112;
                }
                else if (textBox5.Text == 4.ToString())
                {
                    oda = Convert.ToInt32(kriter[kat]);
                    double önem4kat= kat * 0.056;
                }
                else if (textBox5.Text == 5.ToString())
                {
                    oda = Convert.ToInt32(kriter[kat]);
                    double önem5kat = kat * 0.028;
                }


                if (textBox4.Text == 1.ToString()) //BU KISIM ISITMA İÇİN
                {
                    ısıtma = Convert.ToInt32(kriter[ısıtma]);
                    double önem1ısıtma = ısıtma * 0.4195;
                }
                else if (textBox4.Text == 2.ToString())
                {
                    ısıtma = Convert.ToInt32(kriter[ısıtma]);
                    double önem2ısıtma = ısıtma * 0.216;
                }
                else if (textBox4.Text == 3.ToString())
                {
                    ısıtma = Convert.ToInt32(kriter[ısıtma]);
                    double önem3ısıtma = ısıtma * 0.112;
                }
                else if (textBox4.Text == 4.ToString())
                {
                    ısıtma = Convert.ToInt32(kriter[ısıtma]);
                    double önem4ısıtma = ısıtma * 0.056;
                }
                else if (textBox4.Text == 5.ToString())
                {
                    ısıtma = Convert.ToInt32(kriter[ısıtma]);
                    double önem5ısıtma = ısıtma * 0.028;
                }



            }

            private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            int çankaya = Convert.ToInt32(textBox2.Text);
            int keçiören = Convert.ToInt32(textBox7.Text);
            konum.Add(çankaya, "çankaya");
            konum.Add(keçiören, "keçiören");
            
        }
       
        public void button3_Click(object sender, EventArgs e)
        {
           
        }

    }
}
