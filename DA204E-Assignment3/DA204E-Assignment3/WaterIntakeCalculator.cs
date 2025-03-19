// Sixten Peterson (AQ9300) 2025-03-15
using DA204E_Assignment3.Enums;

namespace DA204E_Assignment3
{
    internal class WaterIntakeCalculator
    {
        private const int ML_PER_KG = 33; // 33ml per kg of body weight

        // A bunch of different multipliers below
        private const double FEMALE_MULTIPLIER = 0.9;
        private const double MALE_MULTIPLIER = 1.1;

        private const double UNDER_30_MULTIPLIER = 1.1;
        private const double BETWEEN_AGES_MULTIPLIER = 1.0;
        private const double OVER_55_MULTIPLIER = 0.9;

        private const double TALLER_THAN_175_MULTIPLIER = 1.05;
        private const double BETWEEN_HEIGHT_MULTIPLIER = 1.0;
        private const double SHORTER_THAN_160_MULTIPLIER = 0.95;

        private const double LOW_ACTIVITY_MULTIPLIER = 1.0;
        private const double MEDIUM_ACTIVITY_MULTIPLIER = 1.2;
        private const double HIGH_ACTIVITY_MULTIPLIER = 1.5;

        private const int AGE_30 = 30;
        private const int AGE_55 = 55;

        private const int HEIGHT_175 = 175;
        private const int HEIGHT_160 = 160;

        private Person person = new Person();

        /// <summary>
        /// Constructor, accept a person object which is then set to the field.
        /// </summary>
        /// <param name="person">the person object containing all relevant data</param>
        public WaterIntakeCalculator(Person person)
        {
            this.person = person;
        }

        /// <summary>
        /// Gets the gender factor based on the gender specified in the field
        /// </summary>
        /// <returns>gender factor</returns>
        public double GenderFactor()
        {
            switch (this.person.GetGender()) {
                case Gender.Male:
                    return MALE_MULTIPLIER;
                case Gender.Female:
                    return FEMALE_MULTIPLIER;
                default:
                    return -1; // Something went wrong. Should not be possible since the enum should default to a gender.
            }
        }

        /// <summary>
        /// Gets the age factor based on the age specified in the field
        /// </summary>
        /// <returns>the age factor</returns>
        public double AgeFactor()
        {
            int age = this.person.CalculateAge();

            if (age < AGE_30)
            {
                return UNDER_30_MULTIPLIER;
            } else if (age > AGE_55) {
                return OVER_55_MULTIPLIER;
            } else
            {
                return BETWEEN_AGES_MULTIPLIER;
            }
        }

        /// <summary>
        /// Gets the height factor based on the height specified in the field
        /// </summary>
        /// <returns>the height factor</returns>
        public double HeightFactor()
        {
            double heightCM = this.person.GetHeightCM();
            if (heightCM < HEIGHT_160)
            {
                return SHORTER_THAN_160_MULTIPLIER;
            } else if (heightCM > HEIGHT_175)
            {
                return TALLER_THAN_175_MULTIPLIER;
            } else
            {
                return BETWEEN_HEIGHT_MULTIPLIER;
            }
        }

        /// <summary>
        /// Gets the activity factor
        /// </summary>
        /// <returns>the activity factor</returns>
        public double ActivityFactor()
        {
            switch(this.person.GetActivityLevel()) {
                case ActivityLevel.Low:
                    return LOW_ACTIVITY_MULTIPLIER;
                case ActivityLevel.Medium:
                    return MEDIUM_ACTIVITY_MULTIPLIER;
                case ActivityLevel.High:
                    return HIGH_ACTIVITY_MULTIPLIER;
                default:
                    return -1; // Same reasoning as for the GenderFactor
            }
        }

        /// <summary>
        /// Performs the calculation of recommended water intake
        /// </summary>
        /// <returns>the recommended daily water intake</returns>
        public double RecommendedWaterIntake()
        {
            double genderFactor = GenderFactor();
            double activityFactor = ActivityFactor();

            if (genderFactor == -1 || activityFactor == -1)
            {
                return -1; // Indicating something went wrong
            }

            double baseIntake = ML_PER_KG * this.person.GetWeightKG(); // the base intake
            double factors = genderFactor * AgeFactor() * HeightFactor() * activityFactor; // all the factors combines

            return (baseIntake * factors); // calculation
        }
    }
}
