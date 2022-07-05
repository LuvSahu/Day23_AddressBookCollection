namespace AddressBookCollectionsDay23
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("===================Welcome To Address Book===================");
            AddressBook address = new AddressBook();
            address.CreateContact();
            address.Display();
            Console.ReadKey();
        }
    }
}