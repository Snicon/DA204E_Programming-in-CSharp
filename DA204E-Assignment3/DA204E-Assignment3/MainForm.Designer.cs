namespace DA204E_Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDailyWaterIntake = new GroupBox();
            grpRecommendedWater = new GroupBox();
            lblWaterResultGlasses = new Label();
            lblWaterResult1 = new Label();
            lblDailyWaterIntake = new Label();
            grpUnit = new GroupBox();
            rbtnImperial = new RadioButton();
            rbtnMetric = new RadioButton();
            btnCalculateWater = new Button();
            grpPersonalInfo = new GroupBox();
            pnlMetric = new Panel();
            txtWeightKG = new TextBox();
            lblHeightCm = new Label();
            txtHeightCm = new TextBox();
            lblWeightKG = new Label();
            pnlImperial = new Panel();
            lblHeightFtInch = new Label();
            lblWeightLbs = new Label();
            txtWeightlbs = new TextBox();
            txtHeightFt = new TextBox();
            txtHeightIn = new TextBox();
            groupBox1 = new GroupBox();
            cmbActivityLevel = new ComboBox();
            txtBirthYear = new TextBox();
            lblBirthYear = new Label();
            lblActivityLevel = new Label();
            grpGender = new GroupBox();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            txtName = new TextBox();
            lblName = new Label();
            grpRetiermentSaving = new GroupBox();
            btnCalculateRetirement = new Button();
            grpFutureValues = new GroupBox();
            lblGrowthResult = new Label();
            lblGrowth = new Label();
            lblTotalInvestmentResult = new Label();
            lblTotalInvestment = new Label();
            lblTotalInterestResult = new Label();
            lblTotalInterest = new Label();
            lblTotalFutureAmountResult = new Label();
            lblYearsToRetirementResult = new Label();
            lblTotalFutureAmount = new Label();
            lblYearsToRetirement = new Label();
            grpInvestment = new GroupBox();
            txtAnnualInterest = new TextBox();
            lblAunnualInterest = new Label();
            txtMonthlySaving = new TextBox();
            lblMonthlySaving = new Label();
            txtCurrentSavings = new TextBox();
            lblCurrentSavings = new Label();
            grpRetirementData = new GroupBox();
            cmbRetirementAge = new ComboBox();
            lblRetirementAge = new Label();
            grpDailyWaterIntake.SuspendLayout();
            grpRecommendedWater.SuspendLayout();
            grpUnit.SuspendLayout();
            grpPersonalInfo.SuspendLayout();
            pnlMetric.SuspendLayout();
            pnlImperial.SuspendLayout();
            groupBox1.SuspendLayout();
            grpGender.SuspendLayout();
            grpRetiermentSaving.SuspendLayout();
            grpFutureValues.SuspendLayout();
            grpInvestment.SuspendLayout();
            grpRetirementData.SuspendLayout();
            SuspendLayout();
            // 
            // grpDailyWaterIntake
            // 
            grpDailyWaterIntake.Controls.Add(grpRecommendedWater);
            grpDailyWaterIntake.Controls.Add(grpUnit);
            grpDailyWaterIntake.Controls.Add(btnCalculateWater);
            grpDailyWaterIntake.Controls.Add(grpPersonalInfo);
            grpDailyWaterIntake.Location = new Point(12, 12);
            grpDailyWaterIntake.Name = "grpDailyWaterIntake";
            grpDailyWaterIntake.Size = new Size(776, 288);
            grpDailyWaterIntake.TabIndex = 0;
            grpDailyWaterIntake.TabStop = false;
            grpDailyWaterIntake.Text = "Daily Water Intake";
            // 
            // grpRecommendedWater
            // 
            grpRecommendedWater.Controls.Add(lblWaterResultGlasses);
            grpRecommendedWater.Controls.Add(lblWaterResult1);
            grpRecommendedWater.Controls.Add(lblDailyWaterIntake);
            grpRecommendedWater.Location = new Point(6, 225);
            grpRecommendedWater.Name = "grpRecommendedWater";
            grpRecommendedWater.Size = new Size(764, 54);
            grpRecommendedWater.TabIndex = 3;
            grpRecommendedWater.TabStop = false;
            grpRecommendedWater.Text = "Recommended daily water consumption";
            // 
            // lblWaterResultGlasses
            // 
            lblWaterResultGlasses.AutoSize = true;
            lblWaterResultGlasses.BorderStyle = BorderStyle.Fixed3D;
            lblWaterResultGlasses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterResultGlasses.ForeColor = Color.CornflowerBlue;
            lblWaterResultGlasses.Location = new Point(444, 17);
            lblWaterResultGlasses.Name = "lblWaterResultGlasses";
            lblWaterResultGlasses.Size = new Size(107, 17);
            lblWaterResultGlasses.TabIndex = 2;
            lblWaterResultGlasses.Text = "To be calculated...";
            // 
            // lblWaterResult1
            // 
            lblWaterResult1.AutoSize = true;
            lblWaterResult1.BorderStyle = BorderStyle.Fixed3D;
            lblWaterResult1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterResult1.ForeColor = Color.CornflowerBlue;
            lblWaterResult1.Location = new Point(266, 19);
            lblWaterResult1.Name = "lblWaterResult1";
            lblWaterResult1.Size = new Size(107, 17);
            lblWaterResult1.TabIndex = 1;
            lblWaterResult1.Text = "To be calculated...";
            // 
            // lblDailyWaterIntake
            // 
            lblDailyWaterIntake.AutoSize = true;
            lblDailyWaterIntake.Location = new Point(6, 19);
            lblDailyWaterIntake.Name = "lblDailyWaterIntake";
            lblDailyWaterIntake.Size = new Size(100, 15);
            lblDailyWaterIntake.TabIndex = 0;
            lblDailyWaterIntake.Text = "Daily water intake";
            // 
            // grpUnit
            // 
            grpUnit.Controls.Add(rbtnImperial);
            grpUnit.Controls.Add(rbtnMetric);
            grpUnit.Location = new Point(6, 150);
            grpUnit.Name = "grpUnit";
            grpUnit.Size = new Size(234, 54);
            grpUnit.TabIndex = 2;
            grpUnit.TabStop = false;
            grpUnit.Text = "Unit";
            // 
            // rbtnImperial
            // 
            rbtnImperial.AutoSize = true;
            rbtnImperial.Location = new Point(118, 22);
            rbtnImperial.Name = "rbtnImperial";
            rbtnImperial.Size = new Size(108, 19);
            rbtnImperial.TabIndex = 2;
            rbtnImperial.Text = "Imperial (ft, lbs)";
            rbtnImperial.UseVisualStyleBackColor = true;
            // 
            // rbtnMetric
            // 
            rbtnMetric.AutoSize = true;
            rbtnMetric.Checked = true;
            rbtnMetric.Location = new Point(6, 22);
            rbtnMetric.Name = "rbtnMetric";
            rbtnMetric.Size = new Size(106, 19);
            rbtnMetric.TabIndex = 1;
            rbtnMetric.TabStop = true;
            rbtnMetric.Text = "Metric (cm, kg)";
            rbtnMetric.UseVisualStyleBackColor = true;
            rbtnMetric.CheckedChanged += rbtnMetric_CheckedChanged;
            // 
            // btnCalculateWater
            // 
            btnCalculateWater.Location = new Point(261, 154);
            btnCalculateWater.Name = "btnCalculateWater";
            btnCalculateWater.Size = new Size(509, 54);
            btnCalculateWater.TabIndex = 1;
            btnCalculateWater.Text = "Calculate";
            btnCalculateWater.UseVisualStyleBackColor = true;
            btnCalculateWater.Click += btnWaterCalculate_Click;
            // 
            // grpPersonalInfo
            // 
            grpPersonalInfo.Controls.Add(pnlMetric);
            grpPersonalInfo.Controls.Add(pnlImperial);
            grpPersonalInfo.Controls.Add(groupBox1);
            grpPersonalInfo.Controls.Add(grpGender);
            grpPersonalInfo.Controls.Add(txtName);
            grpPersonalInfo.Controls.Add(lblName);
            grpPersonalInfo.Location = new Point(6, 22);
            grpPersonalInfo.Name = "grpPersonalInfo";
            grpPersonalInfo.Size = new Size(764, 122);
            grpPersonalInfo.TabIndex = 0;
            grpPersonalInfo.TabStop = false;
            grpPersonalInfo.Text = "Personal Information";
            // 
            // pnlMetric
            // 
            pnlMetric.Controls.Add(txtWeightKG);
            pnlMetric.Controls.Add(lblHeightCm);
            pnlMetric.Controls.Add(txtHeightCm);
            pnlMetric.Controls.Add(lblWeightKG);
            pnlMetric.Location = new Point(6, 44);
            pnlMetric.Name = "pnlMetric";
            pnlMetric.Size = new Size(311, 55);
            pnlMetric.TabIndex = 1;
            // 
            // txtWeightKG
            // 
            txtWeightKG.Location = new Point(134, 29);
            txtWeightKG.Name = "txtWeightKG";
            txtWeightKG.Size = new Size(80, 23);
            txtWeightKG.TabIndex = 7;
            // 
            // lblHeightCm
            // 
            lblHeightCm.AutoSize = true;
            lblHeightCm.Location = new Point(0, 0);
            lblHeightCm.Name = "lblHeightCm";
            lblHeightCm.Size = new Size(71, 15);
            lblHeightCm.TabIndex = 3;
            lblHeightCm.Text = "Height (cm)";
            // 
            // txtHeightCm
            // 
            txtHeightCm.Location = new Point(134, -3);
            txtHeightCm.Name = "txtHeightCm";
            txtHeightCm.Size = new Size(80, 23);
            txtHeightCm.TabIndex = 4;
            // 
            // lblWeightKG
            // 
            lblWeightKG.AutoSize = true;
            lblWeightKG.Location = new Point(0, 32);
            lblWeightKG.Name = "lblWeightKG";
            lblWeightKG.Size = new Size(69, 15);
            lblWeightKG.TabIndex = 6;
            lblWeightKG.Text = "Weight (kg)";
            // 
            // pnlImperial
            // 
            pnlImperial.Controls.Add(lblHeightFtInch);
            pnlImperial.Controls.Add(lblWeightLbs);
            pnlImperial.Controls.Add(txtWeightlbs);
            pnlImperial.Controls.Add(txtHeightFt);
            pnlImperial.Controls.Add(txtHeightIn);
            pnlImperial.Location = new Point(6, 45);
            pnlImperial.Name = "pnlImperial";
            pnlImperial.Size = new Size(311, 55);
            pnlImperial.TabIndex = 2;
            pnlImperial.Visible = false;
            // 
            // lblHeightFtInch
            // 
            lblHeightFtInch.AutoSize = true;
            lblHeightFtInch.Location = new Point(0, 1);
            lblHeightFtInch.Name = "lblHeightFtInch";
            lblHeightFtInch.Size = new Size(98, 15);
            lblHeightFtInch.TabIndex = 2;
            lblHeightFtInch.Text = "Height (ft and in)";
            // 
            // lblWeightLbs
            // 
            lblWeightLbs.AutoSize = true;
            lblWeightLbs.Location = new Point(0, 32);
            lblWeightLbs.Name = "lblWeightLbs";
            lblWeightLbs.Size = new Size(71, 15);
            lblWeightLbs.TabIndex = 5;
            lblWeightLbs.Text = "Weight (lbs)";
            // 
            // txtWeightlbs
            // 
            txtWeightlbs.Location = new Point(134, 29);
            txtWeightlbs.Name = "txtWeightlbs";
            txtWeightlbs.Size = new Size(80, 23);
            txtWeightlbs.TabIndex = 6;
            // 
            // txtHeightFt
            // 
            txtHeightFt.Location = new Point(134, -3);
            txtHeightFt.Name = "txtHeightFt";
            txtHeightFt.Size = new Size(80, 23);
            txtHeightFt.TabIndex = 3;
            // 
            // txtHeightIn
            // 
            txtHeightIn.Location = new Point(231, -3);
            txtHeightIn.Name = "txtHeightIn";
            txtHeightIn.Size = new Size(80, 23);
            txtHeightIn.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbActivityLevel);
            groupBox1.Controls.Add(txtBirthYear);
            groupBox1.Controls.Add(lblBirthYear);
            groupBox1.Controls.Add(lblActivityLevel);
            groupBox1.Location = new Point(512, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Other Data";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(110, 16);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(121, 23);
            cmbActivityLevel.TabIndex = 9;
            // 
            // txtBirthYear
            // 
            txtBirthYear.Location = new Point(110, 46);
            txtBirthYear.Name = "txtBirthYear";
            txtBirthYear.Size = new Size(121, 23);
            txtBirthYear.TabIndex = 7;
            // 
            // lblBirthYear
            // 
            lblBirthYear.AutoSize = true;
            lblBirthYear.Location = new Point(6, 47);
            lblBirthYear.Name = "lblBirthYear";
            lblBirthYear.Size = new Size(57, 15);
            lblBirthYear.TabIndex = 8;
            lblBirthYear.Text = "Birth year";
            // 
            // lblActivityLevel
            // 
            lblActivityLevel.AutoSize = true;
            lblActivityLevel.Location = new Point(6, 19);
            lblActivityLevel.Name = "lblActivityLevel";
            lblActivityLevel.Size = new Size(74, 15);
            lblActivityLevel.TabIndex = 7;
            lblActivityLevel.Text = "Activity level";
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbtnMale);
            grpGender.Controls.Add(rbtnFemale);
            grpGender.Location = new Point(356, 22);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(121, 78);
            grpGender.TabIndex = 1;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(6, 47);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(51, 19);
            rbtnMale.TabIndex = 1;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Checked = true;
            rbtnFemale.Location = new Point(6, 22);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(63, 19);
            rbtnFemale.TabIndex = 0;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // grpRetiermentSaving
            // 
            grpRetiermentSaving.Controls.Add(btnCalculateRetirement);
            grpRetiermentSaving.Controls.Add(grpFutureValues);
            grpRetiermentSaving.Controls.Add(grpInvestment);
            grpRetiermentSaving.Controls.Add(grpRetirementData);
            grpRetiermentSaving.Location = new Point(12, 306);
            grpRetiermentSaving.Name = "grpRetiermentSaving";
            grpRetiermentSaving.Size = new Size(776, 227);
            grpRetiermentSaving.TabIndex = 1;
            grpRetiermentSaving.TabStop = false;
            grpRetiermentSaving.Text = "Retirement Saving";
            // 
            // btnCalculateRetirement
            // 
            btnCalculateRetirement.Location = new Point(493, 22);
            btnCalculateRetirement.Name = "btnCalculateRetirement";
            btnCalculateRetirement.Size = new Size(277, 112);
            btnCalculateRetirement.TabIndex = 3;
            btnCalculateRetirement.Text = "Calculate";
            btnCalculateRetirement.UseVisualStyleBackColor = true;
            btnCalculateRetirement.Click += btnCalculateRetirement_Click;
            // 
            // grpFutureValues
            // 
            grpFutureValues.Controls.Add(lblGrowthResult);
            grpFutureValues.Controls.Add(lblGrowth);
            grpFutureValues.Controls.Add(lblTotalInvestmentResult);
            grpFutureValues.Controls.Add(lblTotalInvestment);
            grpFutureValues.Controls.Add(lblTotalInterestResult);
            grpFutureValues.Controls.Add(lblTotalInterest);
            grpFutureValues.Controls.Add(lblTotalFutureAmountResult);
            grpFutureValues.Controls.Add(lblYearsToRetirementResult);
            grpFutureValues.Controls.Add(lblTotalFutureAmount);
            grpFutureValues.Controls.Add(lblYearsToRetirement);
            grpFutureValues.Location = new Point(6, 140);
            grpFutureValues.Name = "grpFutureValues";
            grpFutureValues.Size = new Size(764, 79);
            grpFutureValues.TabIndex = 2;
            grpFutureValues.TabStop = false;
            grpFutureValues.Text = "Future values";
            // 
            // lblGrowthResult
            // 
            lblGrowthResult.AutoSize = true;
            lblGrowthResult.BorderStyle = BorderStyle.Fixed3D;
            lblGrowthResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrowthResult.ForeColor = Color.CornflowerBlue;
            lblGrowthResult.Location = new Point(395, 50);
            lblGrowthResult.Name = "lblGrowthResult";
            lblGrowthResult.Size = new Size(107, 17);
            lblGrowthResult.TabIndex = 10;
            lblGrowthResult.Text = "To be calculated...";
            // 
            // lblGrowth
            // 
            lblGrowth.AutoSize = true;
            lblGrowth.Location = new Point(277, 50);
            lblGrowth.Name = "lblGrowth";
            lblGrowth.Size = new Size(67, 15);
            lblGrowth.TabIndex = 9;
            lblGrowth.Text = "Growth (%)";
            // 
            // lblTotalInvestmentResult
            // 
            lblTotalInvestmentResult.AutoSize = true;
            lblTotalInvestmentResult.BorderStyle = BorderStyle.Fixed3D;
            lblTotalInvestmentResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInvestmentResult.ForeColor = Color.CornflowerBlue;
            lblTotalInvestmentResult.Location = new Point(118, 50);
            lblTotalInvestmentResult.Name = "lblTotalInvestmentResult";
            lblTotalInvestmentResult.Size = new Size(107, 17);
            lblTotalInvestmentResult.TabIndex = 8;
            lblTotalInvestmentResult.Text = "To be calculated...";
            // 
            // lblTotalInvestment
            // 
            lblTotalInvestment.AutoSize = true;
            lblTotalInvestment.Location = new Point(6, 50);
            lblTotalInvestment.Name = "lblTotalInvestment";
            lblTotalInvestment.Size = new Size(94, 15);
            lblTotalInvestment.TabIndex = 7;
            lblTotalInvestment.Text = "Total investment";
            // 
            // lblTotalInterestResult
            // 
            lblTotalInterestResult.AutoSize = true;
            lblTotalInterestResult.BorderStyle = BorderStyle.Fixed3D;
            lblTotalInterestResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInterestResult.ForeColor = Color.CornflowerBlue;
            lblTotalInterestResult.Location = new Point(651, 17);
            lblTotalInterestResult.Name = "lblTotalInterestResult";
            lblTotalInterestResult.Size = new Size(107, 17);
            lblTotalInterestResult.TabIndex = 6;
            lblTotalInterestResult.Text = "To be calculated...";
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            lblTotalInterest.Location = new Point(571, 17);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new Size(74, 15);
            lblTotalInterest.TabIndex = 5;
            lblTotalInterest.Text = "Total interest";
            // 
            // lblTotalFutureAmountResult
            // 
            lblTotalFutureAmountResult.AutoSize = true;
            lblTotalFutureAmountResult.BorderStyle = BorderStyle.Fixed3D;
            lblTotalFutureAmountResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFutureAmountResult.ForeColor = Color.CornflowerBlue;
            lblTotalFutureAmountResult.Location = new Point(395, 15);
            lblTotalFutureAmountResult.Name = "lblTotalFutureAmountResult";
            lblTotalFutureAmountResult.Size = new Size(107, 17);
            lblTotalFutureAmountResult.TabIndex = 4;
            lblTotalFutureAmountResult.Text = "To be calculated...";
            // 
            // lblYearsToRetirementResult
            // 
            lblYearsToRetirementResult.AutoSize = true;
            lblYearsToRetirementResult.BorderStyle = BorderStyle.Fixed3D;
            lblYearsToRetirementResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearsToRetirementResult.ForeColor = Color.CornflowerBlue;
            lblYearsToRetirementResult.Location = new Point(118, 19);
            lblYearsToRetirementResult.Name = "lblYearsToRetirementResult";
            lblYearsToRetirementResult.Size = new Size(107, 17);
            lblYearsToRetirementResult.TabIndex = 3;
            lblYearsToRetirementResult.Text = "To be calculated...";
            // 
            // lblTotalFutureAmount
            // 
            lblTotalFutureAmount.AutoSize = true;
            lblTotalFutureAmount.Location = new Point(277, 17);
            lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            lblTotalFutureAmount.Size = new Size(112, 15);
            lblTotalFutureAmount.TabIndex = 2;
            lblTotalFutureAmount.Text = "Total future amount";
            // 
            // lblYearsToRetirement
            // 
            lblYearsToRetirement.AutoSize = true;
            lblYearsToRetirement.Location = new Point(6, 19);
            lblYearsToRetirement.Name = "lblYearsToRetirement";
            lblYearsToRetirement.Size = new Size(106, 15);
            lblYearsToRetirement.TabIndex = 0;
            lblYearsToRetirement.Text = "Years to retirement";
            // 
            // grpInvestment
            // 
            grpInvestment.Controls.Add(txtAnnualInterest);
            grpInvestment.Controls.Add(lblAunnualInterest);
            grpInvestment.Controls.Add(txtMonthlySaving);
            grpInvestment.Controls.Add(lblMonthlySaving);
            grpInvestment.Controls.Add(txtCurrentSavings);
            grpInvestment.Controls.Add(lblCurrentSavings);
            grpInvestment.Location = new Point(237, 22);
            grpInvestment.Name = "grpInvestment";
            grpInvestment.Size = new Size(237, 112);
            grpInvestment.TabIndex = 1;
            grpInvestment.TabStop = false;
            grpInvestment.Text = "Investment";
            // 
            // txtAnnualInterest
            // 
            txtAnnualInterest.Location = new Point(131, 78);
            txtAnnualInterest.Name = "txtAnnualInterest";
            txtAnnualInterest.Size = new Size(100, 23);
            txtAnnualInterest.TabIndex = 5;
            // 
            // lblAunnualInterest
            // 
            lblAunnualInterest.AutoSize = true;
            lblAunnualInterest.Location = new Point(6, 81);
            lblAunnualInterest.Name = "lblAunnualInterest";
            lblAunnualInterest.Size = new Size(108, 15);
            lblAunnualInterest.TabIndex = 4;
            lblAunnualInterest.Text = "Annual interest (%)";
            // 
            // txtMonthlySaving
            // 
            txtMonthlySaving.Location = new Point(131, 47);
            txtMonthlySaving.Name = "txtMonthlySaving";
            txtMonthlySaving.Size = new Size(100, 23);
            txtMonthlySaving.TabIndex = 3;
            // 
            // lblMonthlySaving
            // 
            lblMonthlySaving.AutoSize = true;
            lblMonthlySaving.Location = new Point(6, 50);
            lblMonthlySaving.Name = "lblMonthlySaving";
            lblMonthlySaving.Size = new Size(89, 15);
            lblMonthlySaving.TabIndex = 2;
            lblMonthlySaving.Text = "Monthly saving";
            // 
            // txtCurrentSavings
            // 
            txtCurrentSavings.Location = new Point(131, 16);
            txtCurrentSavings.Name = "txtCurrentSavings";
            txtCurrentSavings.Size = new Size(100, 23);
            txtCurrentSavings.TabIndex = 1;
            // 
            // lblCurrentSavings
            // 
            lblCurrentSavings.AutoSize = true;
            lblCurrentSavings.Location = new Point(6, 19);
            lblCurrentSavings.Name = "lblCurrentSavings";
            lblCurrentSavings.Size = new Size(89, 15);
            lblCurrentSavings.TabIndex = 0;
            lblCurrentSavings.Text = "Current savings";
            // 
            // grpRetirementData
            // 
            grpRetirementData.Controls.Add(cmbRetirementAge);
            grpRetirementData.Controls.Add(lblRetirementAge);
            grpRetirementData.Location = new Point(6, 22);
            grpRetirementData.Name = "grpRetirementData";
            grpRetirementData.Size = new Size(200, 112);
            grpRetirementData.TabIndex = 0;
            grpRetirementData.TabStop = false;
            grpRetirementData.Text = "Retirement Data";
            // 
            // cmbRetirementAge
            // 
            cmbRetirementAge.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRetirementAge.FormattingEnabled = true;
            cmbRetirementAge.Location = new Point(118, 16);
            cmbRetirementAge.Name = "cmbRetirementAge";
            cmbRetirementAge.Size = new Size(75, 23);
            cmbRetirementAge.TabIndex = 1;
            // 
            // lblRetirementAge
            // 
            lblRetirementAge.AutoSize = true;
            lblRetirementAge.Location = new Point(6, 19);
            lblRetirementAge.Name = "lblRetirementAge";
            lblRetirementAge.Size = new Size(87, 15);
            lblRetirementAge.TabIndex = 0;
            lblRetirementAge.Text = "Retirement age";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 545);
            Controls.Add(grpRetiermentSaving);
            Controls.Add(grpDailyWaterIntake);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Calculator V2 by Sixten Peterson";
            grpDailyWaterIntake.ResumeLayout(false);
            grpRecommendedWater.ResumeLayout(false);
            grpRecommendedWater.PerformLayout();
            grpUnit.ResumeLayout(false);
            grpUnit.PerformLayout();
            grpPersonalInfo.ResumeLayout(false);
            grpPersonalInfo.PerformLayout();
            pnlMetric.ResumeLayout(false);
            pnlMetric.PerformLayout();
            pnlImperial.ResumeLayout(false);
            pnlImperial.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpRetiermentSaving.ResumeLayout(false);
            grpFutureValues.ResumeLayout(false);
            grpFutureValues.PerformLayout();
            grpInvestment.ResumeLayout(false);
            grpInvestment.PerformLayout();
            grpRetirementData.ResumeLayout(false);
            grpRetirementData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDailyWaterIntake;
        private GroupBox grpPersonalInfo;
        private Label lblName;
        private TextBox txtName;
        private Label lblHeightFtInch;
        private TextBox txtHeightFt;
        private Label lblWeightLbs;
        private TextBox txtHeightIn;
        private TextBox txtWeightlbs;
        private GroupBox grpGender;
        private RadioButton rbtnMale;
        private RadioButton rbtnFemale;
        private GroupBox groupBox1;
        private Label lblActivityLevel;
        private Label lblBirthYear;
        private ComboBox cmbActivityLevel;
        private TextBox txtBirthYear;
        private GroupBox grpUnit;
        private RadioButton rbtnImperial;
        private RadioButton rbtnMetric;
        private Button btnCalculateWater;
        private GroupBox grpRecommendedWater;
        private Label lblDailyWaterIntake;
        private TextBox txtHeightCm;
        private Label lblHeightCm;
        private Label lblWeightKG;
        private TextBox txtWeightKG;
        private Label lblWaterResult1;
        private Panel pnlMetric;
        private Panel pnlImperial;
        private Label lblWaterResultGlasses;
        private GroupBox grpRetiermentSaving;
        private GroupBox grpRetirementData;
        private Label lblRetirementAge;
        private ComboBox cmbRetirementAge;
        private GroupBox grpInvestment;
        private Label lblCurrentSavings;
        private TextBox txtMonthlySaving;
        private Label lblMonthlySaving;
        private TextBox txtCurrentSavings;
        private TextBox txtAnnualInterest;
        private Label lblAunnualInterest;
        private GroupBox grpFutureValues;
        private Label lblTotalFutureAmount;
        private Label lblYearsToRetirement;
        private Label lblYearsToRetirementResult;
        private Label lblTotalFutureAmountResult;
        private Label lblTotalInterest;
        private Label lblTotalInterestResult;
        private Label lblTotalInvestment;
        private Label lblTotalInvestmentResult;
        private Label lblGrowthResult;
        private Label lblGrowth;
        private Button btnCalculateRetirement;
    }
}
