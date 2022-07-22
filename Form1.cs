using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LostArkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //AP=[square root (Dex * Weapon /6)]
            double Dex = int.Parse(txtDex.Text);
            double DexAfter = int.Parse(txtDex.Text) + int.Parse(txtDex2.Text);
            double weapon = int.Parse(txtWEP.Text);
            double weaponAfter = int.Parse(txtWEP.Text) + int.Parse(txtWEP2.Text);
            double AttackCalc = Math.Sqrt(Dex * weapon / 6);
            double AtkEnhance = Math.Sqrt(DexAfter * weaponAfter / 6);
            Double PercentGain = ((AtkEnhance / AttackCalc) - 1) * 100;

            Math.Round(PercentGain, 2);
            Math.Round(AttackCalc, 2);
            Math.Round(AtkEnhance, 2);


            lblGain.Text = Convert.ToString(PercentGain);
            lblGain.Text = lblGain.Text + "%";
            AttackFinal.Text = Convert.ToString(AttackCalc);
            AtkUpgrade.Text = Convert.ToString(AtkEnhance);
        }
    }
}
