using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager_GUI
{
    /****************************************
     * 
     *  Alan Van Art
     *  class BankAccount
     *  
     *  owner of the account (Person instance)
     *  list of Transactions up to 100 (can be implemented as an array)
     *  id
     *  date opened
     * 
     * ***************************************/

    class BankAccount
    {
        private string accountId;
        private Person accountHolder;
        private DateTime dateAccountOpened;
        private List<Transaction> transactions;

        // contructors
        public BankAccount() : this(DateTime.Now.GetHashCode().ToString(), DateTime.Now) { }

        public BankAccount(string accountId, DateTime dateAccountOpened)
        {
            this.accountId = accountId;
            this.dateAccountOpened = dateAccountOpened;
            accountHolder = new Person();
            transactions = new List<Transaction>();
        }

        // member accessors/mutators
        public void setAccountId(string accountId)
        {
            if (accountId.Length > 0)
            {
                this.accountId = accountId;
            }
        }

        public string getAccountId()
        {
            return accountId;
        }

        public void setDateAccountOpened(DateTime dateAccountOpened)
        {
            this.dateAccountOpened = dateAccountOpened;
        }

        public DateTime getDateAccountOpened()
        {
            return dateAccountOpened;
        }

        public Person getAccountHolder()
        {
            return accountHolder;
        }

        public void addTransaction(
            DateTime dateOfTransaction, decimal amountOfTransaction)
        {
            long transactionId = this.getNextTransactionId();

            transactions.Add(
                new Transaction(dateOfTransaction, amountOfTransaction, transactionId));
        }

        public List<Transaction> getTransactions()
        {
            return transactions;
        }

        // methods
        public string ToString()
        {
            return "Date Account Opened: " + dateAccountOpened.ToShortDateString() +
                "\nAccount ID: " + accountId +
                "\n" + accountHolder.ToString() + "\nBalance: " + 
                string.Format("{0:C2}",getAccountBalance());
        }

        // method to return total account balance
        // sums all amount in transaction list
        public decimal getAccountBalance()
        {
            decimal accountBalance = 0;

            foreach (Transaction transaction in transactions)
            {
                accountBalance += transaction.getAmount();
            }

            return accountBalance;
        }

        // finds the maximum transaction id and increments
        public long getNextTransactionId()
        {
            long maxId = 0;

            foreach (Transaction transaction in transactions)
            {
                maxId = maxId > transaction.getTransactionId() ?
                    maxId : transaction.getTransactionId();
            }

            return maxId += 1;
        }

    } // end BankAccount class
}
