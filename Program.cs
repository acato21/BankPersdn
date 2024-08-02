using System.Globalization;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> accounts = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                string typeAccount = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeAccount == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    accounts.Add(new PersonPhysical(healthExpenditures, name, anualIncome));
                } else if (typeAccount == "c") 
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployess = int.Parse(Console.ReadLine());

                    accounts.Add(new LegalPerson(numberOfEmployess, name, anualIncome));
                }
            }

            double sum = 0;
            Console.WriteLine(" ");
            Console.WriteLine("TAXES PAID:");
            foreach(Person person in accounts)
            {
                Console.WriteLine($"{person.Name}: $ {person.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += person.Tax();
            }

            Console.WriteLine(" ");
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}