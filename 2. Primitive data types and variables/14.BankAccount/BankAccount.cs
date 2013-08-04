using System;
    class BankAccount
    {
        static void Main()
        {
            string firstName = "Gabriella";
            string middleName = "Garcia";
            string lastName = "Marquez";
            string name;
            name = firstName + " " + middleName + " " + lastName;
            decimal balance = 326.67M;
            string bankName = "First Investment Bank";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            string BIC = "FINVBGSF";
            ulong creditCard1 = 378282246310005;
            ulong creditCard2 = 5610591081018250;
            ulong creditCard3 = 76009244561;
            Console.WriteLine("This is the bank account of {0}, whose money balance is {1}$.\nThis account is in {2} bank.\nThe user has IBAN number: {3}, BIC: {4} and tree credit cards with the following numbers: {5}, {6} and {7}.", name, balance, bankName, IBAN, BIC, creditCard1, creditCard2, creditCard3);

        }
    }