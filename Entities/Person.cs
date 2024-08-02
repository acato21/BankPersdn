namespace BankAccount.Entities
{
    abstract class Person
    {
        public string Name { get; private set; }
        public double AnnualIncome { get; private set; }

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax() ;
    }
}
