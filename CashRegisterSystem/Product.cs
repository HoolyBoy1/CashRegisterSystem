using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterSystem
{
    class Product
    {
        public string _name;
        public float _price;
        public int _amount;
        //public bool _availability;

        public Product(string name = "", float price = 0, int amount = 1)
        {
            _name = name;
            _price = price;
            _amount = amount;
            //_availability = true;
        }

        //public Product(string name, float price)
        //{
        //    _name = name;
        //    _price = price;
        //    _amount = 1;
        //    //_availability = true;
        //}

        //public Product()
        //{
        //    _name = "";
        //    _price = 0;
        //    _amount = 1;
        //    //_availability = true;               // Or FALSE (Need to be discused)
        //}

        
        // method to convert a special type string in Product
         
        public void stringToProduct(string input)   
        {
            string[] words = new string[3];
            words = input.Split('|');

            this._name = words[0];
            this._price = float.Parse(words[1]);
            this._amount = Convert.ToInt32(words[2]);
        }

        //public void Change()
        //{
        //    if(this._amount > 0)
        //    {
        //        this._availability = true;
        //    }
        //    else
        //    {
        //        this._availability = false;
        //    }
        //}
    }
}
