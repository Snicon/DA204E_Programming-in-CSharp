// Sixten Peterson (AQ9300) 2025-03-18
namespace DA204E_Assignment3
{
    /// <summary>
    /// This class is responsible for keeping track of the required data for calculating retirement savings
    /// </summary>
    internal class RetirementSavings
    {
        double balance;             // The balance of the savings
        double initialBalance;      // The initial balance of the account (current savings + first monthly savings)
        double interest;            // The annual interest rate
        double monthlySavings;      // The monthly savings being put in to the retirement savings
        int periodInYears;          // The amount of years until retirement
        double totalInterestEarned; // The total amount of interest earned from the retirement savings

        /// <summary>
        /// Initzializing all the fields in the constructor
        /// </summary>
        public RetirementSavings()
        {
            balance = 0;
            initialBalance = 0;
            interest = 0;
            monthlySavings = 0;
            periodInYears = 0;
            totalInterestEarned = 0;
        }

        /// <summary>
        /// Performs the actual calculations and stores them in the relevant fields
        /// </summary>
        /// <param name="person">an instance of person containing personal data needed for calculations</param>
        /// <param name="retirementAge">the age at which the person wishes to retire at</param>
        /// <returns>True if successfull, false if unsuccessfull</returns>
        public bool Calculate(Person person, int retirementAge)
        {
            // Setting the period based on the selection and the age of the person.
            this.periodInYears = retirementAge - person.CalculateAge();

            if (this.periodInYears < 0)
            {
                return false; // Not enough years to perform any calculations
            }

            int months = periodInYears * 12; // The amount of months until retirement
            double monthlyInterestRate = (this.interest / 100) / 12; // annual interest rate => monthly interest rate
            this.balance = this.initialBalance + this.monthlySavings;

            for (int i = 1; i <= months; i++) // Goes through each month until retirement and updates the balance and total interest earned
            {
                double monthInterest = this.balance * monthlyInterestRate;
                this.balance += monthInterest + this.monthlySavings;
                this.totalInterestEarned += monthInterest;
            }

            return true; // Successful calculation
        }

        /// <summary>
        /// Calculates the growth rate
        /// </summary>
        /// <returns>the growth rate in percentage without a precent sign</returns>
        public double GetGrowthRate()
        {
            // The balance has not grown
            if (balance < 0)
            {
                return 0;
            }

            return (totalInterestEarned / balance) * 100; // Calculates and returns
        }

        /// <summary>
        /// Gets the years until retirement
        /// </summary>
        /// <returns>amount of year until retirement</returns>
        public double GetPeriodInYears()
        {
            return periodInYears;
        }

        /// <summary>
        /// Gets the total amount / balance
        /// </summary>
        /// <returns>the balance</returns>
        public double GetTotalAmount()
        {
            return this.balance;
        }

        /// <summary>
        /// Gets the total deposit (all money that has been put into the retirement savings which excludes interest)
        /// </summary>
        /// <returns>The total deposit</returns>
        public double GetTotalDeposit()
        {
            return this.initialBalance + (this.periodInYears * 12 * this.monthlySavings);
        }

        /// <summary>
        /// Gets the total interest earned
        /// </summary>
        /// <returns>the total interest earned</returns>
        public double GetTotalInterestEarned()
        {
            return this.totalInterestEarned;
        }

        /// <summary>
        /// Sets the initial balance (current savings)
        /// </summary>
        /// <param name="initialBalance">the current savings</param>
        public void SetInitBalance(double initialBalance)
        {
            if (initialBalance >= 0) // Negative balance is not allowed
            {
                this.initialBalance = initialBalance;
            }
        }

        /// <summary>
        /// Sets the annual interest rate
        /// </summary>
        /// <param name="interestRate">the annual interest rate</param>
        public void SetInterestRate(double interestRate)
        {
            if (interestRate >= 0) // We cant have a negative interesr rate
            {
                this.interest = interestRate;
            }
        }

        /// <summary>
        /// Sets the monthly savings
        /// </summary>
        /// <param name="monthlySaving">the monthly savings</param>
        public void SetMonthlySaving(double monthlySaving)
        {
            if(monthlySaving >= 1) // It's not much of a saving if we aren't saving any money every month...
            {
                this.monthlySavings = monthlySaving;
            }
        }
    }
}
