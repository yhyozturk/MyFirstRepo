using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // my first project for school
        double IslemYapilacakSayi;
        bool IlkSayiMi=true;
        int hangiIslem;

        #region SayiButonlari
        private void btnSifir_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 0;
            }
        }

        private void btnBir_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 1;
            }
            else
            {
                txtIslemEkrani.Text = "1";
            }
        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 2;
            }
            else
            {
                txtIslemEkrani.Text = "2";
            }
        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 3;
            }
            else
            {
                txtIslemEkrani.Text = "3";
            }
        }

        private void btnDort_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 4;
            }
            else
            {
                txtIslemEkrani.Text = "4";
            }
        }

        private void btnBes_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 5;
            }
            else
            {
                txtIslemEkrani.Text = "5";
            }
        }

        private void btnAlti_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 6;
            }
            else
            {
                txtIslemEkrani.Text = "6";
            }
        }

        private void btnYedi_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 7;
            }
            else
            {
                txtIslemEkrani.Text = "7";
            }
        }

        private void btnSekiz_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 8;
            }
            else
            {
                txtIslemEkrani.Text = "8";
            }
        }

        private void btnDokuz_Click(object sender, EventArgs e)
        {
            if (txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text += 9;
            }
            else
            {
                txtIslemEkrani.Text = "9";
            }
        }
#endregion

        private void btnACall_Click(object sender, EventArgs e)
        {
           
            txtIslemEkrani.Text = "0";
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (!txtIslemEkrani.Text.Contains(","))
            {
                txtIslemEkrani.Text += ",";
            }
        }

        private void btnIsaretDegistir_Click(object sender, EventArgs e)
        {
            string isaretKontrol = txtIslemEkrani.Text.Substring(0,1);

            if (isaretKontrol == "-")
            {
                txtIslemEkrani.Text = txtIslemEkrani.Text.Remove(0, 1);
            }
            else if(txtIslemEkrani.Text != "0")
            {
                txtIslemEkrani.Text = "-" + txtIslemEkrani.Text;
            }

        }

        private void btnYuzeBol_Click(object sender, EventArgs e)
        {
            IslemYapilacakSayi = Convert.ToDouble(txtIslemEkrani.Text);
            IslemYapilacakSayi /= 100;
            txtIslemEkrani.Text = IslemYapilacakSayi.ToString();
            lblSonucGoster.Text = txtIslemEkrani.Text;
        }

        private void btnBolmeIslemi_Click(object sender, EventArgs e)
        {
            hangiIslem = ButonRenkleri(0);

            if (lblSonucGoster.Text == "0" && IlkSayiMi)
            {
                IslemYapilacakSayi = Convert.ToDouble(txtIslemEkrani.Text);
                txtIslemEkrani.Text = "";
                IlkSayiMi = false;
            }
            else if (lblSonucGoster.Text == "0" && IlkSayiMi == false && txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (IslemYapilacakSayi / Convert.ToDouble(txtIslemEkrani.Text)).ToString();
                txtIslemEkrani.Text = "";
            }
            else if(txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (Convert.ToDouble(lblSonucGoster.Text) / Convert.ToDouble(txtIslemEkrani.Text)).ToString();
            }
            else
            {
                MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!" , "Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            

            
            
        }

        public int ButonRenkleri(int indexNo)
        {
            Button[] butonlarim = { btnBolmeIslemi, btnCarpmaIslemi, btnCikarmaIslemi, btnToplamaIslemi, btnEsittir };

            for (int i = 0; i < butonlarim.Length; i++)
            {
                butonlarim[i].BackColor = SystemColors.Control;
            }
            butonlarim[indexNo].BackColor = Color.Orange;

            return indexNo;
        }

        private void btnCarpmaIslemi_Click(object sender, EventArgs e)
        {
           hangiIslem = ButonRenkleri(1);

            if (lblSonucGoster.Text == "0" && IlkSayiMi)
            {
                IslemYapilacakSayi = Convert.ToDouble(txtIslemEkrani.Text);
                txtIslemEkrani.Text = "";
                IlkSayiMi = false;
            }
            else if (lblSonucGoster.Text == "0" && IlkSayiMi == false && txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (IslemYapilacakSayi * Convert.ToDouble(txtIslemEkrani.Text)).ToString();
                txtIslemEkrani.Text = "";
            }
            else if (txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (Convert.ToDouble(lblSonucGoster.Text) * Convert.ToDouble(txtIslemEkrani.Text)).ToString();
            }
            else
            {
                MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCikarmaIslemi_Click(object sender, EventArgs e)
        {
           hangiIslem = ButonRenkleri(2);

            if (lblSonucGoster.Text == "0" && IlkSayiMi)
            {
                IslemYapilacakSayi = Convert.ToDouble(txtIslemEkrani.Text);
                txtIslemEkrani.Text = "";
                IlkSayiMi = false;
            }
            else if (lblSonucGoster.Text == "0" && IlkSayiMi == false && txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (IslemYapilacakSayi - Convert.ToDouble(txtIslemEkrani.Text)).ToString();
                txtIslemEkrani.Text = "";
            }
            else if (txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (Convert.ToDouble(lblSonucGoster.Text) - Convert.ToDouble(txtIslemEkrani.Text)).ToString();
            }
            else
            {
                MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToplamaIslemi_Click(object sender, EventArgs e)
        {
           hangiIslem = ButonRenkleri(3);

            if (lblSonucGoster.Text == "0" && IlkSayiMi)
            {
                IslemYapilacakSayi = Convert.ToDouble(txtIslemEkrani.Text);
                txtIslemEkrani.Text = "";
                IlkSayiMi = false;
            }
            else if (lblSonucGoster.Text == "0" && IlkSayiMi == false && txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (IslemYapilacakSayi + Convert.ToDouble(txtIslemEkrani.Text)).ToString();
                txtIslemEkrani.Text = "";
            }
            else if (txtIslemEkrani.Text != "")
            {
                lblSonucGoster.Text =
                    (Convert.ToDouble(lblSonucGoster.Text) + Convert.ToDouble(txtIslemEkrani.Text)).ToString();
            }
            else
            {
                MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {

            if (lblSonucGoster.Text != "0" && txtIslemEkrani.Text !="")
            {
                switch (hangiIslem)
                {
                    case 0:
                        lblSonucGoster.Text =
                            (Convert.ToDouble(lblSonucGoster.Text) / Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                       
                        break;
                    case 1:
                        lblSonucGoster.Text =
                            (Convert.ToDouble(lblSonucGoster.Text) * Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                        
                        break;
                    case 2:
                        lblSonucGoster.Text =
                            (Convert.ToDouble(lblSonucGoster.Text) - Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();

                        break;
                    case 3:
                        lblSonucGoster.Text =
                            (Convert.ToDouble(lblSonucGoster.Text) + Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                       
                        break;
                    default:
                        MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblSonucGoster.Text = "0";
                        break;
                }
            }
            else if(lblSonucGoster.Text == "0" && txtIslemEkrani.Text != "")
            {
                switch (hangiIslem)
                {
                    case 0:
                        lblSonucGoster.Text =
                            (IslemYapilacakSayi / Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                        break;
                    case 1:
                        lblSonucGoster.Text =
                            (IslemYapilacakSayi * Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                        break;
                    case 2:
                        lblSonucGoster.Text =
                            (IslemYapilacakSayi - Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                        break;
                    case 3:
                        lblSonucGoster.Text =
                            (IslemYapilacakSayi + Convert.ToDouble(txtIslemEkrani.Text))
                            .ToString();
                        break;
                    default:
                        MessageBox.Show("İşlem Yapabilmek İçin Veri Girmeniz Gerekmektedir!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lblSonucGoster.Text = "0";
                        break;
                }
            }
            
            
                
            
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            lblSonucGoster.Text = "0";
            txtIslemEkrani.Text = "0";
            IlkSayiMi = true;
            hangiIslem = 6;
            IslemYapilacakSayi = 0;

            btnToplamaIslemi.BackColor = Color.White;
            btnCikarmaIslemi.BackColor = Color.White;
            btnCarpmaIslemi.BackColor = Color.White;
            btnBolmeIslemi.BackColor = Color.White;
        }
    }
}
