using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManager_GUI
{
    /********************************
     * 
     *  Alan Van Art
     *  class Address
     *  
     *  street address
     *  city
     *  state
     *  zip
     * 
     * *****************************/

    class Address
    {
        // data members
        private string streetAddress;
        private string city;
        private string state;
        private string zip;

        // constructors
        public Address() : this("not set", "not set", "not set", "00000") { }

        public Address(string streetAddress, string city, string state, string zip)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        // member accessors/mutators
        public void setStreetAddress(string streetAddress)
        {
            this.streetAddress = streetAddress;
        }

        public string getStreetAddress()
        {
            return streetAddress;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getCity()
        {
            return city;
        }

        public void setState(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }

        public void setZip(string zip)
        {
            this.zip = zip;
        }

        public string getZip()
        {
            return zip;
        }

        // methods
        public string ToString()
        {
            return streetAddress + 
                "\n" + city + ",  " + state +
                "  " + zip;
        }

    } // end Address class
}
