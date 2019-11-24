using System;

namespace Bank
{
    class Customer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public char gender { get; set; }
        public string acc_number { get; set; }
        public string acc_type { get; set; }
        public string currency { get; set; }
        public double initial_balance { get; set; }
        public double balance { get; set; }

        public Customer()
        {
            Console.WriteLine("First Name: ");
            this.firstname = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.lastname = Console.ReadLine();
            Console.WriteLine("Gender: M|F");
            this.gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Account Number: ");
            this.acc_number = Console.ReadLine();
            Console.WriteLine("Account Type: ");
            this.acc_type = Console.ReadLine();
            Console.WriteLine("Choose Account Currency: RWF|USD|EUR");
            this.currency = Console.ReadLine();
            

            if (currency == "RWF")
            {
                this.initial_balance = 50000;
            }
            else if ((currency == "USD")|| (currency == "EURO"))
            {
                this.initial_balance = 50;
            }
            this.balance = 0;
        }

        public Customer(string firstname, string lastname, char gender, string acc_number, string acc_type, string currency, double initial_balance, double balance)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.acc_number = acc_number;
            this.acc_type = acc_type;
            this.currency = currency;
            this.initial_balance = initial_balance;
            this.balance = balance;
        }

        public string displayInfo()
        {
            return string.Format(
                "First Name: {0} \nLast Name: {1} \nGender: {2} \nAccount Number: {3} \nAccount Type: {4} \nAccoount Currency: {5} \nInitial Balance: {6}",
                firstname, lastname, gender, acc_number, acc_type, currency, initial_balance);
        }

        public double depositOperation(double depositAmount)
        {
            balance = initial_balance + depositAmount;
            return balance;
        }

        public double withdrawOperation(double withdrawAmount)
        {
            balance = initial_balance - withdrawAmount;
            return balance;
        }
        
        static void Main(string[] args)
        {
            Customer custom = new Customer();
            Console.WriteLine("Review Information: Yes|No ");
            string check = Console.ReadLine();
            if (check == "Yes")
            {
                Console.WriteLine(custom.displayInfo());
            }
            else
            {
                Console.WriteLine("con't");
            }
            Console.WriteLine("Perform Operation: 1->Deposit|2->Withdraw");
            string op = Console.ReadLine();
            if (op == "1")
            {
                Console.WriteLine("Amount to Deposit: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                custom.depositOperation(amt);
            }
            else if (op == "2")
            {
                Console.WriteLine("Amount to Withdraw: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                custom.withdrawOperation(amt);
            }

        }
    }
}
