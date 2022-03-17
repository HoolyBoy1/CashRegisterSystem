using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegisterSystem
{
    class Transaction
    {
        public DateTime _dateTime;
        //public int _amount;
        public Product _product;

        Transaction(Product product, DateTime dateTime)
        {
            _dateTime = dateTime;
            _product = product;
        }
        
        public bool possibleChangeAmount(Product product, int amount)
        {
            int temp = product._amount - amount;
            
            if(temp <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
