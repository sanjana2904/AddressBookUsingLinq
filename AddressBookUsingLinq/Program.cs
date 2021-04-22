using System;
using System.Collections.Generic;

namespace AddressBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            List<AddressBook> AddressBookList = new List<AddressBook>()
        {
new AddressBook () {firstName = "sanjana", lastName = "k", address = "Shiva nagar", city = "Bangalore", state= "Karnataka", zip = 635001, phoneNumber = "9988776655", email = "aaa123gmail.com"},
new AddressBook () {firstName = "Arthi", lastName = "A", address = "raman nagar", city = "Hosur", state= "Tamilnadu", zip = 635002, phoneNumber = "1122334455", email = "bbb123gmail.com"},
new AddressBook () {firstName = "Priya", lastName = "s", address = "lakshmi nagar", city = "chennai", state= "Tamilnadu", zip = 635006, phoneNumber = "7722334455", email = "ccc123gmail.com"},
            };
            ManageAddressBook manage = new ManageAddressBook();
            manage.TopRecords(AddressBookList);
            Console.WriteLine();

        }
    } 
}
