﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookCollectionsDay23
{
    internal class AddressBook
    {
        Contact tempContact = new Contact();
        public Dictionary<string, Contact> contacts;

        public AddressBook()
        {
            contacts = new Dictionary<string, Contact>();
        }

        public void CreateContact()
        {
            Contact tempContact = new Contact();
            tempContact.UserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
            }
            else
            {
                Console.WriteLine("erorr");
            }
        }
        //Method Used To Add Contacts
        public void AddContacts()
        {
            tempContact.UserInfo();
            string name = tempContact.GetName();
            if (contacts.ContainsKey(name) is false)
            {
                contacts.Add(name, tempContact);
                Console.WriteLine("Successfully Added A New Contact!!!");
            }
            else
            {
                Console.WriteLine("erorr");
            }

        }

        
                

        public void Display()
        {
            foreach (string name in contacts.Keys)
                contacts[name].Display();
        }
    }
}
