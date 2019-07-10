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

namespace BankAccountManager_GUI
{
    /**********************************************
     * 
     *  Alan Van Art
     *  
     *  Create a program that allows a user to view,
     *  edit, or enter new bank account information
     *  
     *  A client should allow the user to edit any
     *  piece of this information, as well as display
     *  the balance based on the summed values of
     *  the transactions
     *  
     *  ability to output data for all Transactions per account
     *  
     *  ability to display all BankAccount information within
     *  a Label or other GUI control for output
     * 
     * 
     * ********************************************/

    enum State
    {
        AL, AK, AR, AZ, CA, CO, CT, DC, DE, FL,
        GA, HI, IA, ID, IL, IN, KS, KY, LA, MA,
        MD, ME, MI, MN, MO, MS, MT, NC, ND, NE,
        NH, NJ, NM, NV, NY, OK, OH, OR, PA, RI,
        SC, SD, TN, TX, UT, VA, VT, WA, WI, WV, WY
    } // end State enum

    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
            balanceOutput.Text = "";
            clearAccountData();

            //initialize state drop-down
            foreach (State item in Enum.GetValues(typeof(State)))
            {
                stateInput.Items.Add(item);
            }

            toolStripStatusLabel1.Text = "";
            
           
        }

        // button for saving user-entered account details
        private void saveAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNewAccount = false;
                bool isDuplicateAccountId = false;

                // is this a new or existing account?
                if (bankAccountList.SelectedIndex < 0)
                {
                    isNewAccount = true;
                }

                //does the accountId already exist?
                if (bankAccountList.Items.Contains(accountIdInput.Text))
                {
                    isDuplicateAccountId = true;
                }

                // new local BankAccount object
                BankAccount ba1 = new BankAccount();
                int temp = ba1.getTransactions().Count;
                // if no BankAccount is selected, initialize a new one, otherwise
                // assign the currently selected BankAccount to the local BankAccount object
                if (isNewAccount)
                {
                    if (!isDuplicateAccountId)
                    {
                        DateTime dateAccountOpened = DateTime.Parse(dateAccountOpenedInput.Text);

                        // instantiate new account with the Account ID
                        ba1 = new BankAccount(accountIdInput.Text, dateAccountOpened);
                        bankAccounts.Add(ba1); // add object ba1 to global BankAccounts list
                    }

                }
                else
                {
                    // assign currently selected BankAccount to local BankAccount object ba1
                    // so the account data can be saved
                    ba1 = bankAccounts[bankAccountList.SelectedIndex];

                    // if the accountId has not been changed
                    // then allow editing existing account
                    if (ba1.getAccountId() == accountIdInput.Text)
                    {
                        isDuplicateAccountId = false;
                    }
                }

                // check to make sure we aren't duplicating the Account ID
                // but allow modifications to existing Accounts
                if (!isDuplicateAccountId)
                {
                    // once account data is successfully saved to local BankAccount object ba1
                    // then add it to the global BankAccounts list and BankAccount ComboBox
                    if (saveAccountData(ba1))
                    {
                        // clear BankAccount ComboBox list items and reload from the BankAcounts list
                        bankAccountList.Items.Clear();
                        foreach (BankAccount ba in bankAccounts)
                        {
                            bankAccountList.Items.Add(ba.getAccountId());
                        }

                        // set ComboBox selection to reflect current BankAccount
                        bankAccountList.SelectedIndex =
                            bankAccountList.Items.IndexOf(ba1.getAccountId());

                        updateTransactionDisplay(ba1);// refresh the transaction list
                        balanceOutput.Text = string.Format("{0:C2}", ba1.getAccountBalance());
                    }
                    else if (isNewAccount)
                    {
                        bankAccounts.Remove(ba1);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "That Account ID already exists.\n\nPlease enter a different one.",
                        "Duplicate Account ID");
                    accountIdInput.Focus();
                    accountIdInput.SelectAll();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + 
                    "\n\nPlease Enter a valid Date Opened.", "Invalid Entry");
                dateAccountOpenedInput.Focus();
                dateAccountOpenedInput.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +
                    "\n\nTask Failed Successfully.", "Unknown Error");

            }

        }

        // button for saving a new transaction
        private void saveTransactionButton_Click(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex >= 0) // only if a BankAccount is selected
            {
                // get object for selected account
                BankAccount ba = bankAccounts[bankAccountList.SelectedIndex];

                // if saving the transaction data was successful
                // then update the transaction list & clear the input boxes
                if (saveTransaction(ba)) 
                {
                    updateTransactionDisplay(ba);
                    clearTransactionData();
                    transactionIdInput.Text = ba.getNextTransactionId().ToString();
                    transactionDateInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Cannot save Transaction.\n\nNo account selected.",
                    "No Current Account");
                firstNameInput.Focus();
            }
        }

        // prepare for entering a new transaction
        private void clearTransactionButton_Click(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex > -1)
            {
                DialogResult okToClearScreen = MessageBox.Show(
                "This action will clear the current transaction data." +
                "\nMake sure all changes have been saved." +
                "\n\nOK to Proceed?", "New Transaction Confirmation", MessageBoxButtons.OKCancel);

                if (okToClearScreen == DialogResult.OK)
                {
                    // clear Transaction section text boxes
                    clearTransactionData();

                    // clear TransactionList selection
                    transactionOutput.ClearSelected();
                    // set Transaction ID input box to value of the next available transactionId
                    transactionIdInput.Text = bankAccounts[bankAccountList.SelectedIndex].
                        getNextTransactionId().ToString();
                    
                }
            }
            // shift focus to Transaction Date
            transactionDateInput.Focus();

        }

        // selecting a different bank account from the drop-down list
        private void bankAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex >= 0)
            {
                BankAccount ba = bankAccounts[bankAccountList.SelectedIndex];

                clearTransactionData();
                balanceOutput.Text = ba.getAccountBalance().ToString();
                displayAccountData(ba);
                updateTransactionDisplay(ba);
            }

        }

        // selecting a Transaction from the Transaction list
        // loads that transaction into the Transaction text
        // boxes for editing
        private void transactionOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex > -1)
            {
                clearTransactionData();// clear transaction text boxes

                // get current BankAccount object
                BankAccount ba = bankAccounts[bankAccountList.SelectedIndex];

                if (transactionOutput.SelectedIndex >= 1)// if a transaction is selected
                {
                    Transaction selectedTransaction = 
                        ba.getTransactions()[transactionOutput.SelectedIndex - 1];

                    transactionIdInput.Text =
                        selectedTransaction.getTransactionId().ToString();

                    transactionDateInput.Text =
                        selectedTransaction.getDateOfTransaction().ToShortDateString();

                    transactionAmountInput.Text =
                        selectedTransaction.getAmount().ToString();

                }
            }

        }

        // clear text boxes for adding a new empty account
        private void clearAccountButton_Click(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex > -1)
            {
                DialogResult okToClearScreen = MessageBox.Show(
                    "This action will clear the current account data." +
                    "\nMake sure all changes have been saved." +
                    "\n\nOK to Proceed?", "New Account Confirmation", MessageBoxButtons.OKCancel);

                if (okToClearScreen == DialogResult.OK)
                {
                    clearAccountData();
                    clearTransactionData();
                    bankAccountList.SelectedIndex = -1;
                    transactionOutput.Items.Clear();
                }
            }
            firstNameInput.Focus();
        }

        private void printAccountButton_Click(object sender, EventArgs e)
        {
            if (bankAccountList.SelectedIndex > -1)
            {
                BankAccount ba = bankAccounts[bankAccountList.SelectedIndex];

                MessageBox.Show(ba.ToString());
            }
        }

        // parse birthDate & accountId input
        // save user entered values to a bank account
        private bool saveAccountData(BankAccount ba)
        {
            bool successfulSave = false;

            try
            {
                if (accountIdInput.Text.Length > 0)
                {
                    DateTime birthDate = DateTime.Parse(birthDateInput.Text);

                    Person accountHolder = ba.getAccountHolder();

                    accountHolder.setFirstName(firstNameInput.Text);
                    accountHolder.setLastName(lastNameInput.Text);
                    accountHolder.setDateOfBirth(birthDate);
                    accountHolder.getHomeAddress().setStreetAddress(streetAddressInput.Text);
                    accountHolder.getHomeAddress().setCity(cityInput.Text);
                    accountHolder.getHomeAddress().setState(stateInput.Text);
                    accountHolder.getHomeAddress().setZip(zipCodeInput.Text);
                    accountHolder.setSsn(ssnInput.Text);
                    ba.setAccountId(accountIdInput.Text);

                    successfulSave = true;
                }
                else
                {
                    MessageBox.Show("Critical Information Missing:\n\nPlease Enter an Account ID",
                        "Missing Information");
                    accountIdInput.Focus();
                }
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message +
                    "\n\nPlease Enter a valid Birth Date.", "Invalid Entry");
                birthDateInput.Focus();
                birthDateInput.SelectAll();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message +
                   "\n\nTask Failed Successfully.", "Unknown Error");
            }
            
            return successfulSave;
        }

        // fill text boxes with data from BankAccount object
        private void displayAccountData(BankAccount ba)
        {
            Person accountAddress = ba.getAccountHolder();

            firstNameInput.Text = accountAddress.getFirstName();
            lastNameInput.Text = accountAddress.getLastName();
            birthDateInput.Text = accountAddress.getDateOfBirth().ToShortDateString();
            streetAddressInput.Text = accountAddress.getHomeAddress().getStreetAddress();
            cityInput.Text = accountAddress.getHomeAddress().getCity();
            stateInput.Text = accountAddress.getHomeAddress().getState();
            zipCodeInput.Text = accountAddress.getHomeAddress().getZip();
            ssnInput.Text = accountAddress.getSsn();
            accountIdInput.Text = ba.getAccountId();
            dateAccountOpenedInput.Text = ba.getDateAccountOpened().ToShortDateString();
        }

        // clear BankAccount data from form text boxes
        private void clearAccountData()
        {
            firstNameInput.Text = "";
            lastNameInput.Text = "";
            birthDateInput.Text = "";
            streetAddressInput.Text = "";
            cityInput.Text = "";
            stateInput.Text = "";
            zipCodeInput.Text = "";
            ssnInput.Text = "";
            accountIdInput.Text = "";
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = "";
            toolStripStatusLabel4.Text = "";
            dateAccountOpenedInput.Text = DateTime.Now.ToShortDateString();
        }

        // add user entered transaction data to new BankAccount Transaction
        // parse dateTransacted & amountTransacted
        private bool saveTransaction(BankAccount ba)
        {
            bool successfulSave = false;
            bool successfulDate = false;

            try
            {
                DateTime dateTransacted = DateTime.Parse(transactionDateInput.Text);
                successfulDate = true;

                decimal amountTransacted = Convert.ToDecimal(transactionAmountInput.Text);

                // no transaction selected - add new one
                if (transactionOutput.SelectedIndex < 0)
                {
                    ba.addTransaction(dateTransacted, amountTransacted);
                    successfulSave = true;
                }
                else // transaction selected - edit it
                {
                    long transactionId = Convert.ToInt64(transactionIdInput.Text);

                    ba.getTransactions()[transactionOutput.SelectedIndex - 1].
                        setTransactionId(transactionId);

                    ba.getTransactions()[transactionOutput.SelectedIndex - 1].
                        setDateOfTransaction(dateTransacted);

                    ba.getTransactions()[transactionOutput.SelectedIndex - 1].
                        setAmount(amountTransacted);

                    successfulSave = true;
                }
            }
            catch (FormatException e)
            {
                if (successfulDate)
                {
                    MessageBox.Show(e.Message +
                        "\n\nPlease Enter a valid Transaction Amount.", "Invalid Entry");
                    transactionAmountInput.Focus();
                    transactionAmountInput.SelectAll();
                }
                else
                {
                    MessageBox.Show(e.Message +
                        "\n\nPlease Enter a valid Transaction Date.", "Invalid Entry");
                    transactionDateInput.Focus();
                    transactionDateInput.SelectAll();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message +
                   "\n\nTask Failed Successfully.", "Unknown Error");
            }

            return successfulSave;
        }


        // clear Transaction data from form text boxes
        private void clearTransactionData()
        {
            transactionIdInput.Text = "";
            transactionAmountInput.Text = "";
            transactionDateInput.Text = "";
        }

        // update Transaction display list
        private void updateTransactionDisplay(BankAccount ba)
        {
            transactionOutput.Items.Clear();

            transactionOutput.Items.Add(string.Format("{0,5}{1,15}{2,20}","ID","Date","Amount"));

            foreach (Transaction item in ba.getTransactions())
            {
                transactionOutput.Items.Add(item.ToString());
            }

            balanceOutput.Text = string.Format("{0:C2}", ba.getAccountBalance());
            transactionIdInput.Text = ba.getNextTransactionId().ToString();
            transactionDateInput.Focus();
            updateStatusBar(ba);
        }

        // update text values diaplayed in the status bar
        // account holder name, account ID, date account opened, and account balance
        private void updateStatusBar(BankAccount ba)
        {
            toolStripStatusLabel3.Text =
                string.Format("{0} {1}",
                ba.getAccountHolder().getFirstName(),
                ba.getAccountHolder().getLastName());

            toolStripStatusLabel2.Text =
                string.Format("Account: {0}", ba.getAccountId());

            toolStripStatusLabel1.Text = 
                string.Format("Balance: {0:C2}", ba.getAccountBalance());

            toolStripStatusLabel4.Text = 
                string.Format("Opened: {0:d}", ba.getDateAccountOpened());
        }
        
    } // end Form1 partial class


} // end BankAccountManager_GUI namespace
