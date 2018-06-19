using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPriceDiffrence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcPrice_btn_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(this.Amout_tb.Text);
            double benzine = double.Parse(this.Price_Benzine_tb.Text);
            double diesel = double.Parse(this.Price_Diesel_tb.Text);

            this.PriceBenzine_lbl.Text = (amount * benzine).ToString();
            this.PriceDiesel_lbl.Text = (amount * diesel).ToString();

            double diff = (Math.Max(diesel, benzine) - Math.Min(diesel, benzine));

            this.Diffrence_lbl.Text = (diff * amount).ToString();
        }
    }
}
