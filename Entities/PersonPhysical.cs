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
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthSpending * 0.5;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthSpending * 0.5;
            }
        }
    }
}
