namespace BankAccountManager_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stateInput = new System.Windows.Forms.ComboBox();
            this.saveAccountButton = new System.Windows.Forms.Button();
            this.streetAddressInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearAccountButton = new System.Windows.Forms.Button();
            this.dateAccountOpenedInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.accountIdInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ssnInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.zipCodeInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDateInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearTransactionButton = new System.Windows.Forms.Button();
            this.saveTransactionButton = new System.Windows.Forms.Button();
            this.transactionAmountInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transactionIdInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.transactionDateInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.balanceOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.transactionOutput = new System.Windows.Forms.ListBox();
            this.bankAccountList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printAccountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stateInput);
            this.groupBox1.Controls.Add(this.saveAccountButton);
            this.groupBox1.Controls.Add(this.streetAddressInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clearAccountButton);
            this.groupBox1.Controls.Add(this.dateAccountOpenedInput);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.accountIdInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ssnInput);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.zipCodeInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cityInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.birthDateInput);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lastNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstNameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // stateInput
            // 
            this.stateInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stateInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateInput.FormattingEnabled = true;
            this.stateInput.Location = new System.Drawing.Point(120, 169);
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(63, 24);
            this.stateInput.TabIndex = 6;
            // 
            // saveAccountButton
            // 
            this.saveAccountButton.Location = new System.Drawing.Point(54, 315);
            this.saveAccountButton.Name = "saveAccountButton";
            this.saveAccountButton.Size = new System.Drawing.Size(102, 23);
            this.saveAccountButton.TabIndex = 11;
            this.saveAccountButton.Text = "Save Account";
            this.saveAccountButton.UseVisualStyleBackColor = true;
            this.saveAccountButton.Click += new System.EventHandler(this.saveAccountButton_Click);
            // 
            // streetAddressInput
            // 
            this.streetAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressInput.Location = new System.Drawing.Point(120, 113);
            this.streetAddressInput.Name = "streetAddressInput";
            this.streetAddressInput.Size = new System.Drawing.Size(172, 22);
            this.streetAddressInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Street Address:";
            // 
            // clearAccountButton
            // 
            this.clearAccountButton.Location = new System.Drawing.Point(162, 315);
            this.clearAccountButton.Name = "clearAccountButton";
            this.clearAccountButton.Size = new System.Drawing.Size(118, 23);
            this.clearAccountButton.TabIndex = 12;
            this.clearAccountButton.TabStop = false;
            this.clearAccountButton.Text = "Create New Account";
            this.clearAccountButton.UseVisualStyleBackColor = true;
            this.clearAccountButton.Click += new System.EventHandler(this.clearAccountButton_Click);
            // 
            // dateAccountOpenedInput
            // 
            this.dateAccountOpenedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAccountOpenedInput.Location = new System.Drawing.Point(120, 281);
            this.dateAccountOpenedInput.Name = "dateAccountOpenedInput";
            this.dateAccountOpenedInput.Size = new System.Drawing.Size(100, 22);
            this.dateAccountOpenedInput.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Date Opened:";
            // 
            // accountIdInput
            // 
            this.accountIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIdInput.Location = new System.Drawing.Point(120, 253);
            this.accountIdInput.Name = "accountIdInput";
            this.accountIdInput.Size = new System.Drawing.Size(100, 22);
            this.accountIdInput.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account ID:";
            // 
            // ssnInput
            // 
            this.ssnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnInput.Location = new System.Drawing.Point(120, 225);
            this.ssnInput.Name = "ssnInput";
            this.ssnInput.Size = new System.Drawing.Size(100, 22);
            this.ssnInput.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "SSN:";
            // 
            // zipCodeInput
            // 
            this.zipCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeInput.Location = new System.Drawing.Point(120, 197);
            this.zipCodeInput.Name = "zipCodeInput";
            this.zipCodeInput.Size = new System.Drawing.Size(100, 22);
            this.zipCodeInput.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Zip Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "State:";
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityInput.Location = new System.Drawing.Point(120, 141);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(150, 22);
            this.cityInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "City:";
            // 
            // birthDateInput
            // 
            this.birthDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateInput.Location = new System.Drawing.Point(120, 85);
            this.birthDateInput.Name = "birthDateInput";
            this.birthDateInput.Size = new System.Drawing.Size(100, 22);
            this.birthDateInput.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date of Birth:";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(120, 57);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 22);
            this.lastNameInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // firstNameInput
            // 
            this.firstNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameInput.Location = new System.Drawing.Point(120, 29);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 22);
            this.firstNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearTransactionButton);
            this.groupBox2.Controls.Add(this.saveTransactionButton);
            this.groupBox2.Controls.Add(this.transactionAmountInput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.transactionIdInput);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.transactionDateInput);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(346, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Details";
            // 
            // clearTransactionButton
            // 
            this.clearTransactionButton.Location = new System.Drawing.Point(152, 107);
            this.clearTransactionButton.Name = "clearTransactionButton";
            this.clearTransactionButton.Size = new System.Drawing.Size(152, 23);
            this.clearTransactionButton.TabIndex = 4;
            this.clearTransactionButton.Text = "Create New Transaction";
            this.clearTransactionButton.UseVisualStyleBackColor = true;
            this.clearTransactionButton.Click += new System.EventHandler(this.clearTransactionButton_Click);
            // 
            // saveTransactionButton
            // 
            this.saveTransactionButton.Location = new System.Drawing.Point(44, 107);
            this.saveTransactionButton.Name = "saveTransactionButton";
            this.saveTransactionButton.Size = new System.Drawing.Size(102, 23);
            this.saveTransactionButton.TabIndex = 3;
            this.saveTransactionButton.Text = "Save Transaction";
            this.saveTransactionButton.UseVisualStyleBackColor = true;
            this.saveTransactionButton.Click += new System.EventHandler(this.saveTransactionButton_Click);
            // 
            // transactionAmountInput
            // 
            this.transactionAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAmountInput.Location = new System.Drawing.Point(152, 73);
            this.transactionAmountInput.Name = "transactionAmountInput";
            this.transactionAmountInput.Size = new System.Drawing.Size(100, 22);
            this.transactionAmountInput.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Transaction Amount:";
            // 
            // transactionIdInput
            // 
            this.transactionIdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIdInput.Location = new System.Drawing.Point(152, 17);
            this.transactionIdInput.Name = "transactionIdInput";
            this.transactionIdInput.ReadOnly = true;
            this.transactionIdInput.Size = new System.Drawing.Size(100, 22);
            this.transactionIdInput.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Transaction ID:";
            // 
            // transactionDateInput
            // 
            this.transactionDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateInput.Location = new System.Drawing.Point(152, 45);
            this.transactionDateInput.Name = "transactionDateInput";
            this.transactionDateInput.Size = new System.Drawing.Size(100, 22);
            this.transactionDateInput.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Transaction Date:";
            // 
            // balanceOutput
            // 
            this.balanceOutput.AutoSize = true;
            this.balanceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceOutput.Location = new System.Drawing.Point(435, 227);
            this.balanceOutput.Name = "balanceOutput";
            this.balanceOutput.Size = new System.Drawing.Size(57, 16);
            this.balanceOutput.TabIndex = 0;
            this.balanceOutput.Text = "balance";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Balance: ";
            // 
            // transactionOutput
            // 
            this.transactionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionOutput.FormattingEnabled = true;
            this.transactionOutput.ItemHeight = 16;
            this.transactionOutput.Location = new System.Drawing.Point(346, 28);
            this.transactionOutput.Name = "transactionOutput";
            this.transactionOutput.Size = new System.Drawing.Size(310, 196);
            this.transactionOutput.TabIndex = 3;
            this.transactionOutput.TabStop = false;
            this.transactionOutput.SelectedIndexChanged += new System.EventHandler(this.transactionOutput_SelectedIndexChanged);
            // 
            // bankAccountList
            // 
            this.bankAccountList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bankAccountList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bankAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankAccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankAccountList.FormattingEnabled = true;
            this.bankAccountList.Location = new System.Drawing.Point(110, 10);
            this.bankAccountList.Name = "bankAccountList";
            this.bankAccountList.Size = new System.Drawing.Size(122, 24);
            this.bankAccountList.TabIndex = 7;
            this.bankAccountList.SelectedIndexChanged += new System.EventHandler(this.bankAccountList_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Select Account:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Transaction List";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(672, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "Balance:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // printAccountButton
            // 
            this.printAccountButton.Location = new System.Drawing.Point(238, 10);
            this.printAccountButton.Name = "printAccountButton";
            this.printAccountButton.Size = new System.Drawing.Size(85, 23);
            this.printAccountButton.TabIndex = 12;
            this.printAccountButton.Text = "Print Account";
            this.printAccountButton.UseVisualStyleBackColor = true;
            this.printAccountButton.Click += new System.EventHandler(this.printAccountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 425);
            this.Controls.Add(this.printAccountButton);
            this.Controls.Add(this.balanceOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bankAccountList);
            this.Controls.Add(this.transactionOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 464);
            this.MinimumSize = new System.Drawing.Size(688, 464);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveAccountButton;
        private System.Windows.Forms.TextBox streetAddressInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountIdInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zipCodeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox transactionAmountInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox transactionDateInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button saveTransactionButton;
        private System.Windows.Forms.ListBox transactionOutput;
        private System.Windows.Forms.TextBox ssnInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox birthDateInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox stateInput;
        private System.Windows.Forms.TextBox transactionIdInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox bankAccountList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label balanceOutput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clearAccountButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button clearTransactionButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.TextBox dateAccountOpenedInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button printAccountButton;
    }
}

