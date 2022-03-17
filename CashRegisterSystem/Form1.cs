using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegisterSystem
{
    public partial class Form1 : Form
    {
        private const string pathToStorage = "../../Product_storage.txt";
        private const string pathToTransactions = "../../Transactions";
        private List<Product> products = new List<Product>();
       


        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists(pathToTransactions))
            {
                Directory.CreateDirectory(pathToTransactions);
            }

            Update_Click(this, EventArgs.Empty);
        }

        private void readFile()
        {
            var words = File.ReadAllLines(pathToStorage);
            Product product = new Product();
            foreach(var word in words)
            {
                product.stringToProduct(word);
                products.Add(product);
            }
            Console.WriteLine(products[0]._name);
        }
        
        private void changeColor()
        {
            //for(int i = 0; i < listView1.Items.Count; i++)
            //{

            //    if(products[i]._amount > 0)
            //    {
            //        listView1.Items[i].BackColor = System.Drawing.Color.LightGreen;
            //        continue;
            //    }
                
            //    listView1.Items[i].BackColor = System.Drawing.Color.Red;
                
            //}

            foreach(ListViewItem item in listView1.Items)
            {
                //Console.WriteLine(Convert.ToInt32(item.SubItems[2].Text));
                int amount = Convert.ToInt32(item.SubItems[2].Text);
                if(amount > 0)
                {
                    item.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    item.SubItems[2].BackColor = Color.Red;
                    item.UseItemStyleForSubItems = false;
                }
            }

        }

        private void update()
        {
            var product = new Product();
            var information = File.ReadAllLines(pathToStorage);

            listView1.Items.Clear();

            foreach (var line in information)
            {
                product.stringToProduct(line);

                ListViewItem lvi = new ListViewItem(
                    new[] { product._name, product._price.ToString(), product._amount.ToString() });

                listView1.Items.Add(lvi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Price (EUR)", 70);
            listView1.Columns.Add("Amount", 60);           
        }


        private void button1_Click(object sender, EventArgs e) // New Product Button
        {
            NewProductButt.Enabled = false;

            var newProduct = new NewProduct();
            newProduct.Show();

            update();
            readFile();
            changeColor();

            NewProductButt.Enabled = true;
        }

        private void TransactButt_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

            //Update.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            Update.Enabled = false;

            //var product = new Product();
            //var information = File.ReadAllLines(pathToStorage);

            //listView1.Items.Clear();

            //foreach (var line in information)
            //{
            //    product.stringToProduct(line);

            //    ListViewItem lvi = new ListViewItem(
            //        new[] { product._name, product._price.ToString(), product._amount.ToString() });

            //    listView1.Items.Add(lvi);
            //}
            update();
            readFile();
            changeColor();

            Update.Enabled = true;
        }
    }
}
