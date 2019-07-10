using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager_GUI
{
    /***********************************
     * 
     *  Alan Van Art
     *  class Transaction
     *  
     *  amount
     *  date
     *  id
     *  
     *  should also contain ability to add one
     *  to the id for each new Transaction per account
     * 
     * *********************************/

    class Transaction
    {
        // data members
        private long transactionId;
        private decimal amount;
        private DateTime dateOfTransaction;

        // contructor
        public Transaction(DateTime dateOfTransaction, decimal amount, long transactionId)
        {
            this.transactionId = transactionId;
            this.dateOfTransaction = dateOfTransaction;
            this.amount = amount;
        }

        // member accessors/mutators
        public void setTransactionId(long transactionId)
        {
            this.transactionId = transactionId;
        }

        public long getTransactionId()
        {
            return transactionId;
        }

        public void setDateOfTransaction(DateTime dateOfTransaction)
        {
            this.dateOfTransaction = dateOfTransaction;
        }

        public DateTime getDateOfTransaction()
        {
            return dateOfTransaction;
        }

        public void setAmount(decimal amount)
        {
            this.amount = amount;
        }

        public decimal getAmount()
        {
            return amount;
        }

        // methods
        public string ToString()
        {
            return string.Format("{0,5}{1,15}{2,20:C2}",
                transactionId,dateOfTransaction.ToShortDateString(),amount);
        }
    } // end Transaction class
}
