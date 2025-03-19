// Sixten Peterson (AQ9300) 2025-03-18
using DA204E_Assignment3.Enums;

namespace DA204E_Assignment3
{
    /// <summary>
    /// The MainForm or main window of the application housing a lot of logic for the GUI and GUI updates etc
    /// </summary>
    public partial class MainForm : Form
    {
        private const int MINIMUM_RETIREMENT_AGE = 62;
        private const int MAXIUM_RETIREMENT_AGE = 70;

        private const string DEFAULT_RESULT_VALUE = "To be calculated...";

        private Person person = new Person(); // An object of person to set the fields of which will then be used for calculations etc
        private WaterIntakeCalculator waterIntakeCalculator; // An instance of the water intake calculator, here for the same reason as the person instance though it handles another responsibility
        private RetirementSavings retirementSavings = new RetirementSavings(); // Again an object/instace but for the retirementSavings class
        private UnitSystem unitSystem = UnitSystem.Metric; // Defaults to metric, will changes via interaction with the UI. This field keeps track off the active unit system used by the user.

        public enum UnitSystem // Closley coupled enum that is used only within the MainForm class. Basically the unit system UI can have two states, its either metric or imperial hence the existence of the enum and why its not de-coupled.
        {
            Metric,
            Imperial
        }

        public MainForm() // The constructor of the MainForm. All we do here is the initzilsation of the comopnents and GUI. Oh, and also we create the instance for the waterIntakeCalculator
        {
            InitializeComponent();
            InitializeGUI();

            waterIntakeCalculator = new WaterIntakeCalculator(person); // This is here so we can provide the class with the person, I decided doing it this way because the two clases are very close to each other rather than just passing it in to the final calculation method like in the next part of the assignment. If there is a reason not to do it like this I'd love to hear it in the comments of the handed in assignmen :)
        }

        private void InitializeGUI() // Most of the initial stuff with the GUI is already made in the design phase of the GUI. The only real responsibility here is to populate the comboboxes with the different alternatives.
        {
            PopulateActivityLevels(); // Populate ActivityLevel
            PopulateRetirementAge(); // Populate the retirement age combobox
        }

        /// <summary>
        /// Populates the activity level comobox with the values from the ActivityLevel enum.
        /// </summary>
        private void PopulateActivityLevels()
        {
            string[] activityLevels = Enum.GetNames(typeof(ActivityLevel)); // Get all the enum names and store them in an array.
            cmbActivityLevel.Items.AddRange(activityLevels);                // Populate the combobox with the help of the array.
            cmbActivityLevel.SelectedIndex = (int)ActivityLevel.Low;        // Select a default value for better UX.
        }

        /// <summary>
        /// Populates the retirement age combobox by looping from the minimum retirement age to the maximum retirementage in a for loop.
        /// </summary>
        private void PopulateRetirementAge()
        {
            for (int i = MINIMUM_RETIREMENT_AGE; i <= MAXIUM_RETIREMENT_AGE; i++) // Loops from minimum retirement age to maximum retirement age
            {
                cmbRetirementAge.Items.Add(i.ToString()); // Since the index goes from the minimum age we can easily just convert the index int to a string and set it as an item in the combobox.
            }

            cmbRetirementAge.SelectedIndex = 0; // Default to the first item in the combobox
        }

        /// <summary>
        /// This method is responsible for swapping (converting) between the two unit systems for the height text boxes. For improved UX this method converts between the different unit systems for the height (give it a try, I think its is very hand at lest:).
        /// </summary>
        private void SwapUnitSystemHeight()
        {
            switch (this.unitSystem) // From my testing and understanding it's impossible to get anything except for metric or imperial in this use case hence there is no need for a default case. Please do tell if I've misunderstood this in the handed in assignment comment section along with other feedback if you are able to:)
            {
                case UnitSystem.Metric: // The metric system has ben choosen therefor we need to convert form imperial to metric if there are valid imperial units
                    double heightFeet = 0; // This variable and the variable below will be changed by the TryParses below if successful.
                    double heightInch = 0;

                    if (double.TryParse(txtHeightFt.Text, out heightFeet)) // Trying to parse the value/text from the heightFT textbox if its successful it will go on with the inch textbox if one of them fails to parse no conversion is made as both values are needed for conversion to cm
                    {
                        if (double.TryParse(txtHeightIn.Text, out heightInch))
                        {
                            double inches = UnitSystemConversion.ImperialToInches(heightFeet, heightInch); // Converting feet and inches to only inches (no feet)
                            double centimeters = UnitSystemConversion.InchesToCM(inches); // Converting the total inches to centimeters
                            txtHeightCm.Text = centimeters.ToString("F2"); // Formatting the converted value to two decimals
                        }
                    }
                    break;
                case UnitSystem.Imperial: // vice-versa meaning we are swapping from metric to imperial.
                    double heightCM = 0;

                    if (double.TryParse(txtHeightCm.Text, out heightCM))
                    {
                        double heightInches = UnitSystemConversion.CMToInches(heightCM); // Total lenght in inches
                        (double feet, double inches) = UnitSystemConversion.InchesToFeetAndInches(heightInches); // Length in feet and inches. I've decided to try using tuples for this as it makes the process much easier for getting the values, I hope that is alright for this course even though we have not covered it yet... sigh for the imperial system / Average European

                        // Setting the values based on the conversion from centimeters for better UX
                        txtHeightFt.Text = feet.ToString("F2");
                        txtHeightIn.Text = inches.ToString("F2");
                    }
                    break;
            }

        }

        /// <summary>
        /// This method is responsible for swapping (converting) between the two unit systems for the weight text boxes. For improved UX this method converts between the different unit systems for the weight (give it a try, I think its is very hand at lest:).
        /// </summary>
        private void SwapUnitSystemWeight()
        {
            switch (this.unitSystem) // for further comments the same idea applies here as for the swapping of unit system related to height, please refer to those
            {
                case UnitSystem.Metric: // The metric system has ben choosen therefor we need to convert form imperial to metric if there are valid imperial units
                    double weightLBS = 0;

                    if (double.TryParse(txtWeightlbs.Text, out weightLBS))
                    {
                        double convertedWeightKG = UnitSystemConversion.ImperialToMetricWeight(weightLBS);
                        txtWeightKG.Text = convertedWeightKG.ToString("F2");
                    }

                    break;
                case UnitSystem.Imperial: // vice-versa meaning we are swapping from metric to imperial.
                    double weightKG = 0;

                    if (double.TryParse(txtWeightKG.Text, out weightKG))
                    {
                        double convertedWeightLBS = UnitSystemConversion.MetricToImperialWeight(weightKG);
                        txtWeightlbs.Text = convertedWeightLBS.ToString("F2");
                    }

                    break;
            }
        }

        /// <summary>
        /// This method is responsible for setting the unit system field of the class. This data is then used to decide on which unit system is in active use.
        /// </summary>
        /// <param name="unitSystem"></param>
        private void SetUnitSystem(UnitSystem unitSystem)
        {
            this.unitSystem = unitSystem; // Sets the unit system field so I dont have to pass the unit system into the different methods where needed, less code and keeps the state in one place. So far this has avoided some hair pulling on my end.

            // these methods would run in both cases, therefor I run them here rather than duplicating the code.
            SwapUnitSystemHeight();
            SwapUnitSystemWeight();

            switch (this.unitSystem) // All this switch case does is toggle the visibility
            {
                case UnitSystem.Metric:
                    pnlImperial.Visible = false;
                    pnlMetric.Visible = true;
                    break;
                case UnitSystem.Imperial:
                    pnlImperial.Visible = true;
                    pnlMetric.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Reads the name input/txtbox, trims the text and then sets it as the name in the person object. Also shows a popup if no name is provided.
        /// </summary>
        private void ReadNameInput()
        {
            string textValue = txtName.Text.Trim(); // Trims the text to assure nice format
            person.SetName(textValue); // Sets the name of the person

            const String RECOMMENDED_TEXT = "Recommended daily water consumption"; // improve varaible name

            if (String.IsNullOrEmpty(person.GetName())) // Empty or null -> show the groupBox text without "for <NAME HERE>)"
            {
                grpRecommendedWater.Text = RECOMMENDED_TEXT;
                MessageBox.Show("While the program works without specifing a name it would be nice to see one. :)", "Info");
            }
            else // Not empty or null -> show the groupBox text with the name of the, personal and polite:)
            {
                grpRecommendedWater.Text = RECOMMENDED_TEXT + " for " + person.GetName();
            }
        }

        /// <summary>
        /// Event handler for change of checked rbtn. If rbtnMetric changes we can then check which one between rbtnMetric and rbtnImperial is checked and set the unit system in used accordingly.
        /// </summary>
        /// <param name="sender">The source of the event, typically the radio button that triggered the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMetric.Checked)
            {
                SetUnitSystem(UnitSystem.Metric);
            }
            else if (rbtnImperial.Checked)
            {
                SetUnitSystem(UnitSystem.Imperial);
            }
        }

        /// <summary>
        /// Reads the weight provided by the user, it decides which text boxes to read based on the unit system in use.
        /// </summary>
        /// <returns>a boolean indicating if the text box passed the validation or not. True if valid, false if invalid.</returns>
        private bool ReadWeightInput()
        {
            string weightInput = "";
            bool weightParsed = false;
            double weightKG = 0;

            if (unitSystem == UnitSystem.Metric)
            {
                weightInput = txtWeightKG.Text.Trim();
                weightParsed = double.TryParse(weightInput, out weightKG);
            }
            else
            {
                double weightLBS = 0; // Used for temporary storage of weight in lbs before conversion

                weightInput = txtWeightlbs.Text.Trim();
                weightParsed = double.TryParse(weightInput, out weightLBS);
                weightKG = UnitSystemConversion.ImperialToMetricWeight(weightLBS);
            }

            if (weightParsed && weightKG > 10)
            {
                this.person.SetWeightKG(weightKG); // Sets the weight of the person in KG for further calculations later
                return true;
            }
            else
            {
                WarnUser("Invalid weight! You must specify a weight of at least 10 KG or 22,1 pounds.");
                return false;
            }
        }

        /// <summary>
        /// Reads the height provided by the user, it decides which text boxes to read based on the unit system in use.
        /// </summary>
        /// <returns>a boolean indicating if the text box passed the validation or not. True if valid, false if invalid.</returns>
        private bool ReadHeightInput()
        {
            // Grabbing the text from all the text boxes and trimming them
            string heightCMInput = txtHeightCm.Text.Trim();
            string heightFeetInput = txtHeightFt.Text.Trim();
            string heightInchesInput = txtHeightIn.Text.Trim();

            bool heightParsed = false; // if the height has been parsed successfully or not
            double heightCM = 0; // The height in cm parsed from the textbox.

            if (unitSystem == UnitSystem.Metric) // Nice and simple metric system, no conversions needed
            {
                heightParsed = double.TryParse(heightCMInput, out heightCM);
            }
            else // Freedom units (imperial system) used, we therefor have to make a bunch of conversions before finally setting the height in CM.
            {
                double heightFeet = 0;
                double heightInches = 0;

                bool heightFeetParsed = double.TryParse(heightFeetInput, out heightFeet);
                bool heightInchesParsed = double.TryParse(heightInchesInput, out heightInches);

                if (heightFeetParsed && heightInchesParsed)
                {
                    heightParsed = true;

                    double inchesTotal = UnitSystemConversion.ImperialToInches(heightFeet, heightInches);
                    heightCM = UnitSystemConversion.InchesToCM(inchesTotal);
                }
            }

            if (heightParsed && heightCM > 40) // A valid height has been provided
            {
                this.person.SetHeightCM(heightCM); // setting the valid height
                return true;
            }
            else // Invalid height has been provided
            {
                WarnUser("Invalid height! The height must be at least 40 cm or 1,32 feet"); // warns the user
                return false;
            }
        }

        /// <summary>
        /// Small helper method for warning the user of invalid input by using an annoying popup.
        /// </summary>
        /// <param name="message">The message to show the user, typically something along the lines of "invalid input, (why it is invalid and what a valid input could be)"</param>
        private void WarnUser(string message)
        {
            MessageBox.Show(message, "Error");
        }

        /// <summary>
        /// Reads the selected gender and sets it in the person object.
        /// </summary>
        private void ReadGenderInput()
        {
            if (rbtnFemale.Checked)
            {
                this.person.SetGender(Gender.Female);
            }
            else
            {
                this.person.SetGender(Gender.Male);
            }
        }

        /// <summary>
        /// Reads the selected activity level and sets it in the person object.
        /// </summary>
        private void ReadActivityLevel()
        {
            ActivityLevel activityLevel = (ActivityLevel)cmbActivityLevel.SelectedIndex; // Converting from the enum index to the actual enum value.
            this.person.SetActivityLevel(activityLevel);
        }

        /// <summary>
        /// Reads the birth year provided by the user and validates it.
        /// </summary>
        /// <returns>true if valid, false if invalid</returns>
        private bool ReadBirthYear()
        {
            int birthYear = 0;
            string birthYearInput = txtBirthYear.Text.Trim();
            bool birthYearParsed = false;

            birthYearParsed = int.TryParse(birthYearInput, out birthYear);

            if (birthYearParsed && birthYear > 1900)
            {
                DateTime birthYearDateTime = new DateTime(birthYear, 1, 1); // Might as well use DateTime as I will be needing it for calculation later. Just setting the month and day of the date to 1 as it doesnt matter and wont be used.
                this.person.setBirthYear(birthYearDateTime);
                return true;
            }
            else
            {
                WarnUser("Invalid birth year! You can't leave it empty, oh and also mummies dont need to drink water... (Anything over 1900 is fair game)");
                return false;
            }
        }

        /// <summary>
        /// Calls all the methods reading and validating the different inputs form the user in the text box.
        /// </summary>
        /// <returns>A boolean representing if all neccesary inputs are valid or not. True if valid, false if invalid.</returns>
        private bool ReadWaterInput()
        {
            ReadNameInput();
            bool validHeight = ReadHeightInput();
            bool validWeight = ReadWeightInput();
            ReadGenderInput();
            ReadActivityLevel();
            bool validBirthYear = ReadBirthYear();

            return validHeight && validWeight && validBirthYear;
        }

        /// <summary>
        /// Handles the calculation for water consumption and then shows the results in the GUI.
        /// </summary>
        private void HandleWaterCalculation()
        {
            string name = this.person.GetName();

            double recommendedWaterIntake = this.waterIntakeCalculator.RecommendedWaterIntake(); // this is ml
            double recommendedWaterIntakeGlasses = UnitSystemConversion.MetricToGlassesFluid(recommendedWaterIntake); // a glass is always as big no matter the unit so its alwasy the same amount of glasses

            string result = "";
            string resultGlasses = recommendedWaterIntakeGlasses.ToString("F0") + " glasses";

            if (unitSystem == UnitSystem.Metric) // appends the correct units
            {
                result = recommendedWaterIntake.ToString("F2") + " ml"; // oh and also the recommended water intake
                resultGlasses += " (240ml)";
            }
            else // appends the correct units
            {
                result = UnitSystemConversion.MetricToImperialFluid(recommendedWaterIntake).ToString("F2") + " oz"; // Converts metric fluids (ml) to imperial (oz)
                resultGlasses = recommendedWaterIntakeGlasses.ToString("F0") + " glasses (8.1 oz)";
            }

            // Updates the results in the GUI
            lblWaterResult1.Text = result;
            lblWaterResultGlasses.Text = resultGlasses;
        }

        /// <summary>
        /// Clears the results and sets them to the default value.
        /// </summary>
        private void ClearWaterResults()
        {
            lblWaterResult1.Text = DEFAULT_RESULT_VALUE;
            lblWaterResultGlasses.Text = DEFAULT_RESULT_VALUE;
        }

        /// <summary>
        /// The event handler for clickling the calculate button in the water intake part of the application.
        /// </summary>
        /// <param name="sender">The source of the event, typically the radio button that triggered the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnWaterCalculate_Click(object sender, EventArgs e)
        {
            ClearWaterResults(); // Clears the previous results

            bool validInput = ReadWaterInput(); // Seets all the properties of Person based on the input
            if (validInput) HandleWaterCalculation(); // Performs the calculation if all the input was valid
        }

        /// <summary>
        /// Reads all input in the retirement savings part of the application except for the age/birthyear.
        /// </summary>
        /// <returns>True if everything is valid, false if something is invalid.</returns>
        private bool ReadRetirementInput()
        {
            bool validBirthYear = ReadBirthYear(); // Needed for calculations
            bool validCurrentSavings = ReadCurrentSavings();
            bool validMonthlySaving = ReadMonthlySaving();
            bool validAnnualInterest = ReadAnnualInterest();

            // Change this to reflect the status of the input fields
            return validBirthYear && validCurrentSavings && validMonthlySaving && validAnnualInterest;
        }

        /// <summary>
        /// Reads the retirement age and validates it.
        /// </summary>
        /// <returns>Returns the selected age as long as it is > 0 otherwise -1 indicating osmething went wrong</returns>
        private int ReadRetirementAge()
        {
            string selectedAgeString = "";
            int selectedAge = 0;

            if (cmbRetirementAge.SelectedItem != null)
            {
                selectedAgeString = cmbRetirementAge.SelectedItem.ToString();
            }

            bool validatedAge = int.TryParse(selectedAgeString, out selectedAge);

            if (validatedAge && selectedAge > 0) // Basically if the age is bigger than zero there has been a valid age assigned. Otherwise we return -1 indicating an error occured.
            {
                return selectedAge;
            }
            else
            {
                this.WarnUser("Invalid age, make sure that you have provided a valid birth year in the water intake part of the application.");
                return -1;
            }
        }

        /// <summary>
        /// Reads and sets the current savings textbox and validates it.
        /// </summary>
        /// <returns>true if valid, false if invalid</returns>
        private bool ReadCurrentSavings()
        {
            string currentSavingsString = txtCurrentSavings.Text.Trim();
            double currentSavings = 0;

            bool validInput = Double.TryParse(currentSavingsString, out currentSavings);
            
            if (validInput && currentSavings >= 0)
            {
                this.retirementSavings.SetInitBalance(currentSavings);
                return true;
            } 
            else
            {
                this.WarnUser("Invalid input, you need to enter a positive number detailing your current savings.");
                return false;
            }
        }

        /// <summary>
        /// Reads and sets the monthly savings and validates it.
        /// </summary>
        /// <returns>True if valid, false if invalid</returns>
        private bool ReadMonthlySaving()
        {
            string monthlySavingString = txtMonthlySaving.Text.Trim();
            double monthlySaving = 0;

            bool validInput = Double.TryParse(monthlySavingString, out monthlySaving);

            if (validInput && monthlySaving >= 1)
            {
                this.retirementSavings.SetMonthlySaving(monthlySaving);
                return true;
            } 
            else
            {
                this.WarnUser("Invalid input, you must enter a positive number of at least 1 reflecting your monthly savings.");
                return false;
            }
        }

        /// <summary>
        /// Reads ands the annual intrest rate if valid.
        /// </summary>
        /// <returns>True if valid, false if invalid</returns>
        private bool ReadAnnualInterest()
        {
            string annualInterestString = txtAnnualInterest.Text.Trim();
            double annualInterest = 0;

            bool validInput = Double.TryParse(annualInterestString, out annualInterest);

            if (validInput && annualInterest >= 0)
            {
                this.retirementSavings.SetInterestRate(annualInterest);
                return true;
            }
            else 
            {
                this.WarnUser("Invalid input, your annual interest rate must be a positive number starting from 0.");
                return false;
            }
        }

        /// <summary>
        /// Calculates the retirement savings and updates the GUI with the results
        /// </summary>
        /// <param name="retirementAge"></param>
        private void HandleRetirementCalculation(int retirementAge)
        {
            this.retirementSavings.Calculate(this.person, retirementAge);

            if (this.retirementSavings.GetPeriodInYears() < 1) // My girlfirend was very proud to break my application by putting in a year and retirement age that results in a negative number. Safe to say as the good boyfirend I am I of course immedialey went for revenge by fixing the bug. Now she is sad. Relationships are hard.
            {
                this.WarnUser("By our calculations you have either already retired, please overview the specified birth year and/or your desired retirement age.");
            } 
            else
            {
                lblYearsToRetirementResult.Text = this.retirementSavings.GetPeriodInYears().ToString();
                lblTotalInvestmentResult.Text = string.Format("{0:N2}", this.retirementSavings.GetTotalDeposit());
                lblTotalFutureAmountResult.Text = string.Format("{0:N2}", this.retirementSavings.GetTotalAmount());
                lblGrowthResult.Text = this.retirementSavings.GetGrowthRate().ToString("F2");
                lblTotalInterestResult.Text = string.Format("{0:N2}", this.retirementSavings.GetTotalInterestEarned());
            }
        }

        /// <summary>
        /// Clears the retirement savings results and sets them to the default value
        /// </summary>
        private void ClearRetirementResults()
        {
            this.lblYearsToRetirementResult.Text = DEFAULT_RESULT_VALUE;
            this.lblTotalInvestmentResult.Text = DEFAULT_RESULT_VALUE;
            this.lblTotalFutureAmountResult.Text = DEFAULT_RESULT_VALUE;
            this.lblGrowthResult.Text = DEFAULT_RESULT_VALUE;
            this.lblTotalInterestResult.Text = DEFAULT_RESULT_VALUE;
        }

        /// <summary>
        /// Event handler for clicking the calculate button in the retirement savings part of the application. If all inputs are valid it calls for the method to calculate and update the GUI.
        /// </summary>
        /// <param name="sender">The source of the event, typically the radio button that triggered the event. Not used for anything in this case.</param>
        /// <param name="e">An EventArgs object that contains the event data. Not used for anything in this case.</param>
        private void btnCalculateRetirement_Click(object sender, EventArgs e)
        {
            this.ClearRetirementResults(); // Clears the results to their default state
            int retirementAge = ReadRetirementAge(); // Gets the age which is required for calling the Calculate method inside of HandlreRetirementCalculation()

            if (this.ReadRetirementInput()) HandleRetirementCalculation(retirementAge); // If all inputs are valid perform the calculation
        }
    }
}
