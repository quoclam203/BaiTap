using System;

namespace Facade.RealWorld
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        private Bank bank = new Bank();
        private Loan loan = new Loan();
        private Credit credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
                cust.Name, amount);

            bool eligible = true;

            // Check creditworthiness of applicant
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
