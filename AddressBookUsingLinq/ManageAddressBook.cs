using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookUsingLinq
{
    class ManageAddressBook
    {
        public readonly DataTable dataTable = new DataTable();
        //private object listaddressBook;

        public void TopRecords(List<AddressBook> addressBook)
        {
            var updateData = (from AddressBook in listaddressBook
                              where (AddressBook.name == "sanjana")
                              select AddressBook);
            foreach(var name in updateData)
            {
                Console.WriteLine("the first name is :" + name.firstName);

            }
        }
        public void RetrieveCount(List<AddressBook> listaddressBook)
        {
            var updateData = listaddressBook.GroupBy(x => x.firstName).Select(x => new { firstName = x.key, Count = x.Count() });
        foreach(var names in updateData)
            {
                Console.WriteLine(AddressBookTable.firstName);
            }
        }
        public void RetrieveNames(List<AddressBook> listaddressBook)
        {
            var updateData = (from AddressBook in listaddressBook
                              orderby AddressBook.firstName.Length
                              select AddressBook);
            foreach(var names in updateData)
            {
                Console.WriteLine(AddressBookTable.firstName);
            }
        }
               
    }
}
