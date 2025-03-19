// Sixten Peterson (AQ9300) 2025-03-17
namespace DA204E_Assignment3
{
    /// <summary>
    /// Static class for handling conversions as there is no need to store any state
    /// </summary>
    internal static class UnitSystemConversion
    {
        private const double WEIGHT_CONVERSION = 0.453592; // Constant for weight conversion between imperial and metric
        private const double HEIGHT_CONVERSION = 2.54;     // Constant for height conversion between imperial and metric
        private const double FEET_INCHES_CONVERSION = 12;  // Constant for converting inches + feet to inches and vice-versa
        private const double ML_OZ_CONVERSION = 0.033814;  // Constant for conversion between milliliters and ounces
        private const int ML_GLASSES_CONVERSION = 240;     // Constant for conversion between milliliters and glasses (240ml is considered one glass)


        /**
         * Helper methods for converting weight
         */

        /// <summary>
        /// Converting imperial weight (lbs) to metric weight (kg)
        /// </summary>
        /// <param name="weightLBS">weight in lbs</param>
        /// <returns>weight in kg</returns>
        public static double ImperialToMetricWeight(double weightLBS)
        {
            return weightLBS * WEIGHT_CONVERSION; // returns the weight in KG
        }

        /// <summary>
        /// Converting metric weight (kg) to imperial weight (lbs)
        /// </summary>
        /// <param name="weightKG">weight in kg</param>
        /// <returns>weight in lbs</returns>
        public static double MetricToImperialWeight(double weightKG)
        {
            return weightKG / WEIGHT_CONVERSION;
        }


        /**
         * Helper methods for converting height
         */

        /// <summary>
        /// Converts inches to centimeters
        /// </summary>
        /// <param name="heightInches">inches</param>
        /// <returns>inches in centimeters</returns>
        public static double InchesToCM(double heightInches)
        {
            return heightInches * HEIGHT_CONVERSION;
        }

        /// <summary>
        /// Converts centimeters to inches
        /// </summary>
        /// <param name="heightCM">centimeters</param>
        /// <returns>centimeters in inches</returns>
        public static double CMToInches(double heightCM)
        {
            return heightCM / HEIGHT_CONVERSION;
        }

        /// <summary>
        /// Converts inches to feet and inches
        /// </summary>
        /// <param name="heightInches">the height in inches</param>
        /// <returns>the height in feet and inches</returns>
        public static (double feet, double inches) InchesToFeetAndInches(double heightInches)
        {
            double feet = Math.Floor(heightInches / FEET_INCHES_CONVERSION);
            double inches = heightInches % FEET_INCHES_CONVERSION;

            return (feet, inches);
        }

        /// <summary>
        /// Converts feet and inches into inches only
        /// </summary>
        /// <param name="heightFeet">feet</param>
        /// <param name="heightInch">inches</param>
        /// <returns>total inches</returns>
        public static double ImperialToInches(double heightFeet, double heightInch)
        {
            return heightFeet * FEET_INCHES_CONVERSION + heightInch;
        }


        /**
         * Fluid conversions
         */

        /// <summary>
        /// Converts metric milliliters into imperial liquid ounces (oz)
        /// </summary>
        /// <param name="fluidMilliliters">milliliters</param>
        /// <returns>liquiz ounces (oz)</returns>
        public static double MetricToImperialFluid(double fluidMilliliters)
        {
            return fluidMilliliters * ML_OZ_CONVERSION;
        }

        /// <summary>
        /// Convets milliliters into amount of glasses
        /// </summary>
        /// <param name="fluidMilliliters">milliliters</param>
        /// <returns>amount of glasses</returns>
        public static double MetricToGlassesFluid(double fluidMilliliters) 
        {
            return fluidMilliliters / ML_GLASSES_CONVERSION;
        }
    }
}
