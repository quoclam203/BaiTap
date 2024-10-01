using System;

namespace Facade.RealWorld
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true; // Simplified for example
        }
    }
}
