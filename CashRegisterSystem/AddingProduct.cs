using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegisterSystem
{
    public static class AddingProduct
    {
        public static String InputInformation()
        {
            Form1 productInformation = new Form1()
            {
                Width = 600,
                Height = 270,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Information",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label Name_textLabel = new Label() { Left = 50, Top = 20, Text = "Product name:" };
            TextBox Name_textBox = new TextBox() { Left = 50, Top = 50, Width = 500 };
            
            Label Price_textLabel = new Label() { Left = 50, Top = 70, Text = "Product price (EUR):" };
            TextBox Price_textBox = new TextBox() { Left = 50, Top = 100, Width = 300};

            Label Amount_textLabel = new Label() { Left = 50, Top = 120, Text = "Amount:" };
            TextBox Amount_textBox = new TextBox() { Left = 50, Top = 150, Width = 300 };

            Button confirmation = new Button() { Text = "Okey", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { productInformation.Close(); };

            productInformation.Controls.Add(Name_textBox);
            productInformation.Controls.Add(Name_textLabel);
            
            productInformation.Controls.Add(Price_textBox);
            productInformation.Controls.Add(Price_textLabel);

            productInformation.Controls.Add(Amount_textBox);
            productInformation.Controls.Add(Amount_textLabel);

            productInformation.Controls.Add(confirmation);

            return productInformation.ShowDialog() == DialogResult.OK ? (Name_textBox.Text + '|' + Price_textBox.Text + '|' + Amount_textBox.Text) : "";
        }
    }
}
