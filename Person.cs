using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager_GUI
{
    /**********************************
     * 
     *  Alan Van Art
     *  class Person
     *  
     *  first name
     *  last name
     *  ssn
     *  date of birth
     *  Address - or combine Person and Address into
     *  a Person class, and include the data members
     *  from Address
     * 
     * 
     * *******************************/

    class Person
    {
        private string firstName;
        private string lastName;
        private Address homeAddress;
        private string ssn;
        private DateTime dateOfBirth;

        // constructors
        public Person()
            : this("not set", "not set", "not set",
                  new DateTime(1900, 1, 1, 0, 0, 0))
        { }

        public Person(string firstName, string lastName,
            string ssn, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.dateOfBirth = dateOfBirth;
            homeAddress = new Address();
        }

        // member accessors/mutators
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setSsn(string ssn)
        {
            this.ssn = ssn;
        }

        public string getSsn()
        {
            return ssn;
        }

        public void setDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public DateTime getDateOfBirth()
        {
            return dateOfBirth;
        }

        // returns Address object containing address
        // of account owner
        public Address getHomeAddress()
        {
            return homeAddress;
        }

        // methods
        public string ToString()
        {
            return firstName + " " + lastName +
                "\n" + homeAddress.ToString() +
                "\nSSN: " + ssn +
                "\nDOB: " + dateOfBirth.ToShortDateString();
        }

    } // end Person class
}
