using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CashRegisterSystem
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private const string productsStorage = "../../Product_storage.txt";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            string name = NameText.Text;
            float price = float.Parse(NamePrice.Text);
            int amount = Convert.ToInt32(AmountText.Text);
            
            File.AppendAllText(productsStorage, name + "|" + price + "|" + amount + Environment.NewLine);

            this.Close();
        }
    }
}
