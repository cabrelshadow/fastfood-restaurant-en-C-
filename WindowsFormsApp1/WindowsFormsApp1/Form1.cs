using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string dateJour = DateTime.Now.ToString();
            Datejour.Text = dateJour;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Form1_Load(object sender, EventArgs e)
        {
            DateLb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //methode pour afficher le muniteur
            DateLb.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            //activons la checkbox
            if (FriesCb.Checked==true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BergerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked==true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTb.Enabled = false;
                SaladTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {

            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void CheeseCb_CheckedChanged(object sender, EventArgs e)
        {

            if (CheeseCb.Checked == true)
            {
                CheeseTb.Enabled = true;
            }
            if (CheeseCb.Checked == false)
            {
                CheeseTb.Enabled = false;
                CheeseTb.Text = "0";
            }
        }

        private void FishCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FishCb.Checked == true)
            {
                FishTb.Enabled = true;
            }
            if (FishCb.Checked == false)
            {
                FishTb.Enabled = false;
                FishTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void CocaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCb.Checked == true)
            {
                CocaTb.Enabled = true;
            }
            if (CocaCb.Checked == false)
            {
                CocaTb.Enabled = false;
                CocaTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void PanacakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PanacakesCb.Checked == true)
            {
                PanacakesTb.Enabled = true;
            }
            if (PanacakesCb.Checked == false)
            {
                PanacakesTb.Enabled = false;
                PanacakesTb.Text = "0";
            }
        }

        private void AnanasCb_CheckedChanged(object sender, EventArgs e)
        {
            if (AnanasCb.Checked == true)
            {
                AnanasTb.Enabled = true;
            }
            if (AnanasCb.Checked == false)
            {
                AnanasTb.Enabled = false;
                AnanasTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        // declaration des prix pour chaque plat et dinné
        double friesup = 1000, burgerup = 3000, saladup = 4500, sandwichup = 2000, cheeseup = 4000, fishup = 5000,ananasup=1500,chikenup=7000;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("         "+ReceiptTb.Text + "Total à payer: " + SubtileLb.Text + "" + ""  , new Font("Centuty Gothic", 15, FontStyle.Regular),Brushes.Blue, new Point(10));
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        /// <summary>
        /// pour tout mettre les champs de saisi a 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            CheeseCb.Checked = false;
            TeaCb.Checked = false;
            CocaCb.Checked = false;
            WaterCb.Checked = false;
            OrangeCb.Checked = false;
            AnanasCb.Checked = false;
            FishCb.Checked = false;
            PanacakesCb.Checked = false;
            ChocolateCb.Checked = false;
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        double waterup = 800, teaup = 1000, cocaup = 700, chocolateup = 1300, pancakesup = 1000, orangeup = 500;
        // declaration des variables pour recuperer le total pour chaque pat ou boisson
        double friestp, burgertp, saladtp, fishtp, sandwichtp, cheesetp, watertp,chikentp, teatp, cocatp, chocolatetp, pancakestp, orangetp, ananastp;
        double subtotal = 0;

        private void Add_Click(object sender, EventArgs e)
        {
            //multiplcation des quantés  par le pris en convertisant en reel les prix saisi
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            cheesetp = cheeseup * Convert.ToDouble(CheeseTb.Text);
            fishtp = fishup * Convert.ToDouble(FishTb.Text);
            chikentp = chikenup * Convert.ToDouble(ChickenTb.Text);

                //meme chose pour les boisson et les desserts
                watertp = waterup * Convert.ToDouble(WaterTb.Text);
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            cocatp = cocaup * Convert.ToDouble(CocaTb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocolateTb.Text);
            pancakestp = pancakesup * Convert.ToDouble(PanacakesTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            ananastp = ananasup * Convert.ToDouble(AnanasTb.Text);
            //afficher du text dans  la parti rection des prix
            ReceiptTb.Clear();
            double subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            string dateJour = DateTime.Now.ToString();
            ReceiptTb.AppendText("\t\t\t          FAST FOOD RESTAURANT LA JOIE\t\t"+ dateJour + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t*****************************************************************************" +Environment.NewLine);

            
            // pour chaque repat et boisson on fait un AppendText sur chaque variable ReceipTb
            
            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tFries:\t" + friestp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + friestp;
                SubtileLb.Text = "" + subtotal;
              }

                if (BurgerCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t\t\tBurger:\t" + burgertp + "FcFa" + Environment.NewLine);
                    subtotal = subtotal + burgertp;
                    SubtileLb.Text = "" + subtotal;
                }

                if (SaladCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t\t\tSalade:\t" + saladtp + "FcFa" + Environment.NewLine);
                    subtotal = subtotal + saladtp;
                    SubtileLb.Text = "" + subtotal;
                }

                if (SandwichCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t\t\tSandwich:\t" + sandwichtp + "FcFa" + Environment.NewLine);
                    subtotal = subtotal + sandwichtp;
                    SubtileLb.Text = "" + subtotal;
               }

                if (CheeseCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t\t\tCheese:\t" + cheesetp + "FcFa" + Environment.NewLine);
                    subtotal = subtotal + cheesetp;
                    SubtileLb.Text = "" + subtotal;
                }

                if (FishCb.Checked == true)
                {
                    ReceiptTb.AppendText("\t\t\tFish:\t" + fishtp + "FcFa" + Environment.NewLine);
                    subtotal = subtotal + fishtp;
                    SubtileLb.Text = "" + subtotal;

               }

            if (ChickenCb.Checked == true)
              {
                ReceiptTb.AppendText("\t\t\tChiken:\t" + chikentp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + chikentp;
                SubtileLb.Text = "" + subtotal;

              }
            // pour chaque boisson on fait un AppendText sur chaque variable ReceipTb
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tTea:\t" + teatp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + teatp;
                SubtileLb.Text = "" + subtotal;

            }
            if (WaterCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tWater:\t" + watertp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + watertp;
                SubtileLb.Text = "" + subtotal;

            }
            if (CocaCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tCocacola:\t" + cocatp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + cocatp;
                SubtileLb.Text = "" + subtotal;

            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tChocolate:\t" + chocolatetp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + chocolatetp;
                SubtileLb.Text = "" + subtotal;

            }
            if (PanacakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tPanackes:\t" + pancakestp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + pancakestp;
                SubtileLb.Text = "" + subtotal;
                
            }
            if (OrangeCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tOrange:\t" + orangetp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + orangetp;
                SubtileLb.Text = "" + subtotal;
                
            }
            if (AnanasCb.Checked == true)
            {
                ReceiptTb.AppendText("\t\t\tAnanas:\t" + ananastp + "FcFa" + Environment.NewLine);
                subtotal = subtotal + ananastp;
                SubtileLb.Text = "" + subtotal ;

            }
          
        }


        

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
