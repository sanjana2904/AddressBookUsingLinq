using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookUsingLinq
{
    class AddressBookTable
    {
        public void AddToDataTableDemo(DataTable table)
        {
            table.Columns.Add("firstName");
            table.Columns.Add("lastName");
            table.Columns.Add("address");
            table.Columns.Add("city");
            table.Columns.Add("state");
            table.Columns.Add("zip");
            table.Columns.Add("phoneNumber");
            table.Columns.Add("email");

           
    table.Rows.Add("sanjana", "k", "Shiva nagar", "Bangalore", "karnataka", 635001, "9988776655", "aaa123@gmail.com");
    table.Rows.Add("Arthi", "A", "raman nagar", "Hosur", "Tamilnadu", 635002, "1122334455", "bbb123@gmail.com");
    table.Rows.Add("Priya", "s", "lakshmi nagar", "chennai", "Tamilnadu", 635006, "7722334455", "ccc123@gmail.com");
        }

        public void DisplayAddressBookFromTable(DataTable table)
        {
            var dataRow = (from addressBook in table.AsEnumerable()
                           select addressBook);

            Console.WriteLine(" The AddressBook shows ");
            foreach (DataRow row in dataRow)
            {
                Console.WriteLine(AddressBookTable.firstName);
            }
        }
    }
}

    

