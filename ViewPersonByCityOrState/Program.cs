using static AddressBookCollectionsDay23.AddressBook;

namespace AddressBookCollectionsDay23
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            AddressBookLibrary bookLibrary = new AddressBookLibrary();
            bookLibrary.AddressBookMenu();
            Console.ReadLine();
        }
    }
    
 }
