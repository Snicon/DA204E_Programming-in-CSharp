// Sixten Peterson (AQ9300) 2025-03-15
using DA204E_Assignment3.Enums;

namespace DA204E_Assignment3
{
    /// <summary>
    /// Keeps track personal infromation which can be used for calculating the recommended daily water intake or aid the calculation of retirement savings
    /// </summary>
    internal class Person
    {
        private String name;                 // The name of the person
        private double heightCM;             // The height in CM of the person
        private double weightKG;             // The weight in KG of the person
        private Gender gender;               // The gender of the perosn
        private ActivityLevel activityLevel; // The activity level of the person
        private DateTime birthYear;          // The birth year of the person (formatted as DateTime set to year-01-01 but is only meant to determine birth year)

        /// <summary>
        /// Gets the name of the perosn
        /// </summary>
        /// <returns>the name</returns>
        public String GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Sets the name of the person
        /// </summary>
        /// <param name="name">the name</param>
        public void SetName(String name)
        {
            this.name = name; // Allows empty strings as the application works without a name
        }

        /// <summary>
        /// Gets the height of the person in centimeters
        /// </summary>
        /// <returns>the height in cm</returns>
        public double GetHeightCM()
        {
            return this.heightCM;
        }

        /// <summary>
        /// Sets the height of the person in centimeters
        /// </summary>
        /// <param name="heightCM">the height in cm</param>
        public void SetHeightCM(double heightCM)
        {
            if(heightCM >= 40) // validation before setting
            {
                this.heightCM = heightCM;
            }
        }

        /// <summary>
        /// Gets the weight of the person in kilograms
        /// </summary>
        /// <returns>the weight in kg</returns>
        public double GetWeightKG()
        {
            return this.weightKG;
        }

        /// <summary>
        /// Sets the weight of the person in kilograms
        /// </summary>
        /// <param name="weightKG">the weight in kg</param>
        public void SetWeightKG(double weightKG)
        {
            if (weightKG >= 10) // validating before setting
            {
                this.weightKG = weightKG;
            }
        }

        /// <summary>
        /// Gets the gender of the person
        /// </summary>
        /// <returns>the gender</returns>
        public Gender GetGender()
        {
            return this.gender;
        }

        /// <summary>
        /// Sets the gender of the person
        /// </summary>
        /// <param name="gender">the gender</param>
        public void SetGender(Gender gender)
        {
            this.gender = gender; // Enums should suffice for validation
        }

        /// <summary>
        /// Gets the activity level of the person
        /// </summary>
        /// <returns>the activity level</returns>
        public ActivityLevel GetActivityLevel()
        {
            return this.activityLevel;
        }

        /// <summary>
        /// Sets the activity level of the person
        /// </summary>
        /// <param name="activityLevel">the activity level</param>
        public void SetActivityLevel(ActivityLevel activityLevel)
        {
            this.activityLevel = activityLevel; // Enums should suffice for validation
        }

        /// <summary>
        /// Gets the birth year of the person (as DateTime, only year is accurate information)
        /// </summary>
        /// <returns>DateTime containing the year of birth (ignore month and day, they are inaccurate)</returns>
        public DateTime GetBirthYear()
        {
            return this.birthYear;
        }

        /// <summary>
        /// Sets the birthyear by passing in a DateTime month and day are ignored and shall not be used for anything
        /// </summary>
        /// <param name="birthYear">the DateTime containing the year of birth</param>
        public void setBirthYear(DateTime birthYear)
        {
            if(birthYear.Year > 1900) // Validating before setting
            {
                this.birthYear = birthYear;
            }
        }

        /// <summary>
        /// Calculates/guesstimates the age based on the birth year and the current year
        /// </summary>
        /// <returns>the approximate age of the person</returns>
        public int CalculateAge()
        {
            int currentYear = DateTime.Today.Year; // Gets today's date.
            return currentYear - birthYear.Year; // Calculate age by subtracting birthYear from the year of today.
        }
    }
}
