﻿class Program
{
    private static void Main()
    {
        AdressBook adressBook = new(new FakeDataManager());

        AdressBookMenu menu = new(adressBook);
        menu.Show();

        static void MM()
        {
            Console.WriteLine("Hej");
        }
    }




}