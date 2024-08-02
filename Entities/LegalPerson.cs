namespace BankAccount.Entities
{
   class LegalPerson : Person
    {
        public int NumberOfEmployees { get; private set; }

        public LegalPerson(int numberOfEmployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10) 
            {
                return AnnualIncome * 0.14;
            } 
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
