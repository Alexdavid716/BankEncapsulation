namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                
                BankAccount account = new BankAccount();

               
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Deposit money");
                    Console.WriteLine("2. Check balance");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice: ");

                    
                    string choice = Console.ReadLine();

                    
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter the amount to deposit: ");
                            double depositAmount;
                            if (double.TryParse(Console.ReadLine(), out depositAmount))
                            {
                                account.Deposit(depositAmount);
                                Console.WriteLine("Deposit successful.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;

                        case "2":
                            Console.WriteLine($"Your balance: {account.GetBalance()}");
                            break;

                        case "3":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose a valid option.");
                            break;
                    }

                    Console.WriteLine(); 
                }

                Console.WriteLine("Thank you for banking with us!");
            }
        }

        public class BankAccount
        {
            private double balance = 0;

            public void Deposit(double amount)
            {
                balance += amount;
            }

            public double GetBalance()
            {
                return balance;
            }
        }
    }
    }

