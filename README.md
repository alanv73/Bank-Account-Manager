# Bank-Account-Manager
<h3>IT100 Intermediate Programming</h3>

    Final Project: Bank Account Manager

Create a program that allows a user to view, edit, or enter new bank account information.

A client should allow the user to edit any piece of this information, as well as display the balance based on the summed values of the transactions.

Classes used in a fully-featured project:

<strong>class BankAccount</strong>
- owner of the account (Person instance)
- list of Transactions up to 100 (can be implemented as an array)
- id
- date opened
        	
<strong>class Person</strong>
- first name
- last name
- ssn
- date of birth
- Address

or combine Person and Address into a Person class, and include the data members from Address
 
<strong>class Address</strong>
- street address
- city
- state
- zip
 
<strong>class Transaction</strong>
- amount
- date
- id

should also contain ability to add one to the id for each new Transaction per account

General Guidelines

-	Create an easy to use GUI interface
-	Use object-oriented programming
-	try-catch for handling user errors 
(you can use any level of Exception that you like, as long as any potential error messages to the user are descriptive)
-	Create at least one non-default constructor for each class you create
-	The user should be able to break out of subloops, such as when the user is given a choice to keep entering data or not 
(N/A for GUI projects, generally speaking)
-	be sure to instantiate all objects in order to avoid nullPointerExceptions


Features to implement:
-	At least one BankAccount object
-	an array of Transactions, and the ability to output data for all Transactions per account
-	ability to display all BankAccount information within a Label or other GUI control for output

Extra Features:
-	An array of BankAccount objects
-	A separate Address class for each Person

![Bank Account Manager](https://alanv73.github.io/img/bankmanager.png)
