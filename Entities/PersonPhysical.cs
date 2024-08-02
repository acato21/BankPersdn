namespace BankAccount.Entities
{
    class PersonPhysical : Person
    {
        public double HealthSpending { get; private set; }

        public PersonPhysical(double healthSpending, string name, double anualIncome) 
            : base(name, anualIncome) 
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double tax = 0;

            if(AnnualIncome < 20000.00)
            {
                tax =  
            } 

            return tax;
        }
    }
}
