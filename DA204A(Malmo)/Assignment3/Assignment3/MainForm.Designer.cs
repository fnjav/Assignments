namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFuel = new System.Windows.Forms.GroupBox();
            this.btnFuelCalculate = new System.Windows.Forms.Button();
            this.txtFuelPricePerLiter = new System.Windows.Forms.TextBox();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.txtFuelPrevious = new System.Windows.Forms.TextBox();
            this.txtFuelCurrent = new System.Windows.Forms.TextBox();
            this.lblFuel4 = new System.Windows.Forms.Label();
            this.lblFuel3 = new System.Windows.Forms.Label();
            this.lblFuel2 = new System.Windows.Forms.Label();
            this.lblFuel1 = new System.Windows.Forms.Label();
            this.grpFuelResult = new System.Windows.Forms.GroupBox();
            this.pnlFuelResult = new System.Windows.Forms.Panel();
            this.lblFuelResultKmPerLit = new System.Windows.Forms.Label();
            this.lblFuelResultLitPerKm = new System.Windows.Forms.Label();
            this.lblFuelResultLitPerMetricMile = new System.Windows.Forms.Label();
            this.lblFuelResultLitPerSweMil = new System.Windows.Forms.Label();
            this.lblFuelResultCostPerKm = new System.Windows.Forms.Label();
            this.lblFuelResult5 = new System.Windows.Forms.Label();
            this.lblFuelResult4 = new System.Windows.Forms.Label();
            this.lblFuelResult3 = new System.Windows.Forms.Label();
            this.lblFuelResult2 = new System.Windows.Forms.Label();
            this.lblFuelResult1 = new System.Windows.Forms.Label();
            this.grpBmi = new System.Windows.Forms.GroupBox();
            this.btnBmiCalculate = new System.Windows.Forms.Button();
            this.grpBmiResult = new System.Windows.Forms.GroupBox();
            this.pnlBmiResult = new System.Windows.Forms.Panel();
            this.lblBmiResultInfo = new System.Windows.Forms.Label();
            this.lblBmiResultCategory = new System.Windows.Forms.Label();
            this.lblBmiResultBmi = new System.Windows.Forms.Label();
            this.lblBmiResult2 = new System.Windows.Forms.Label();
            this.lblBmiResult1 = new System.Windows.Forms.Label();
            this.rdoBmiUs = new System.Windows.Forms.RadioButton();
            this.rdoBmiMetric = new System.Windows.Forms.RadioButton();
            this.txtBmiWeight = new System.Windows.Forms.TextBox();
            this.txtBmiHeight = new System.Windows.Forms.TextBox();
            this.txtBmiName = new System.Windows.Forms.TextBox();
            this.lblBmiWeight = new System.Windows.Forms.Label();
            this.lblBmiHeight = new System.Windows.Forms.Label();
            this.lblBmiName = new System.Windows.Forms.Label();
            this.grpBmr = new System.Windows.Forms.GroupBox();
            this.lblBmrIndex = new System.Windows.Forms.Label();
            this.btnBmrUnselect = new System.Windows.Forms.Button();
            this.lstBmr = new System.Windows.Forms.ListBox();
            this.btnBmrCalculate = new System.Windows.Forms.Button();
            this.txtBmrAge = new System.Windows.Forms.TextBox();
            this.grpBmrActivity = new System.Windows.Forms.GroupBox();
            this.rdoBmrExtra = new System.Windows.Forms.RadioButton();
            this.rdoBmrVery = new System.Windows.Forms.RadioButton();
            this.rdoBmrModerately = new System.Windows.Forms.RadioButton();
            this.rdoBmrLightly = new System.Windows.Forms.RadioButton();
            this.rdoBmrSedentary = new System.Windows.Forms.RadioButton();
            this.lblBmrAge = new System.Windows.Forms.Label();
            this.rdoBmrMale = new System.Windows.Forms.RadioButton();
            this.rdoBmrFemale = new System.Windows.Forms.RadioButton();
            this.grpFuel.SuspendLayout();
            this.grpFuelResult.SuspendLayout();
            this.pnlFuelResult.SuspendLayout();
            this.grpBmi.SuspendLayout();
            this.grpBmiResult.SuspendLayout();
            this.pnlBmiResult.SuspendLayout();
            this.grpBmr.SuspendLayout();
            this.grpBmrActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuel
            // 
            this.grpFuel.Controls.Add(this.btnFuelCalculate);
            this.grpFuel.Controls.Add(this.txtFuelPricePerLiter);
            this.grpFuel.Controls.Add(this.txtFuelAmount);
            this.grpFuel.Controls.Add(this.txtFuelPrevious);
            this.grpFuel.Controls.Add(this.txtFuelCurrent);
            this.grpFuel.Controls.Add(this.lblFuel4);
            this.grpFuel.Controls.Add(this.lblFuel3);
            this.grpFuel.Controls.Add(this.lblFuel2);
            this.grpFuel.Controls.Add(this.lblFuel1);
            this.grpFuel.Controls.Add(this.grpFuelResult);
            this.grpFuel.ForeColor = System.Drawing.Color.Blue;
            this.grpFuel.Location = new System.Drawing.Point(12, 12);
            this.grpFuel.Name = "grpFuel";
            this.grpFuel.Size = new System.Drawing.Size(291, 317);
            this.grpFuel.TabIndex = 0;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Fuel";
            this.grpFuel.Enter += new System.EventHandler(this.grpFuel_Enter);
            // 
            // btnFuelCalculate
            // 
            this.btnFuelCalculate.Location = new System.Drawing.Point(73, 121);
            this.btnFuelCalculate.Name = "btnFuelCalculate";
            this.btnFuelCalculate.Size = new System.Drawing.Size(120, 25);
            this.btnFuelCalculate.TabIndex = 9;
            this.btnFuelCalculate.Text = "Calculate";
            this.btnFuelCalculate.UseVisualStyleBackColor = true;
            this.btnFuelCalculate.Click += new System.EventHandler(this.btnFuelCalculate_Click);
            // 
            // txtFuelPricePerLiter
            // 
            this.txtFuelPricePerLiter.Location = new System.Drawing.Point(201, 91);
            this.txtFuelPricePerLiter.Name = "txtFuelPricePerLiter";
            this.txtFuelPricePerLiter.Size = new System.Drawing.Size(77, 20);
            this.txtFuelPricePerLiter.TabIndex = 8;
            this.txtFuelPricePerLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFuelAmount
            // 
            this.txtFuelAmount.Location = new System.Drawing.Point(201, 66);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(77, 20);
            this.txtFuelAmount.TabIndex = 7;
            this.txtFuelAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFuelPrevious
            // 
            this.txtFuelPrevious.Location = new System.Drawing.Point(178, 43);
            this.txtFuelPrevious.Name = "txtFuelPrevious";
            this.txtFuelPrevious.Size = new System.Drawing.Size(100, 20);
            this.txtFuelPrevious.TabIndex = 6;
            this.txtFuelPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFuelCurrent
            // 
            this.txtFuelCurrent.Location = new System.Drawing.Point(178, 18);
            this.txtFuelCurrent.Name = "txtFuelCurrent";
            this.txtFuelCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCurrent.TabIndex = 5;
            this.txtFuelCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFuel4
            // 
            this.lblFuel4.AutoSize = true;
            this.lblFuel4.ForeColor = System.Drawing.Color.Green;
            this.lblFuel4.Location = new System.Drawing.Point(7, 94);
            this.lblFuel4.Name = "lblFuel4";
            this.lblFuel4.Size = new System.Drawing.Size(68, 13);
            this.lblFuel4.TabIndex = 4;
            this.lblFuel4.Text = "Price per liter";
            // 
            // lblFuel3
            // 
            this.lblFuel3.AutoSize = true;
            this.lblFuel3.ForeColor = System.Drawing.Color.Green;
            this.lblFuel3.Location = new System.Drawing.Point(7, 69);
            this.lblFuel3.Name = "lblFuel3";
            this.lblFuel3.Size = new System.Drawing.Size(177, 13);
            this.lblFuel3.TabIndex = 3;
            this.lblFuel3.Text = "Current amount of fuel tanked (liters)";
            // 
            // lblFuel2
            // 
            this.lblFuel2.AutoSize = true;
            this.lblFuel2.ForeColor = System.Drawing.Color.Green;
            this.lblFuel2.Location = new System.Drawing.Point(7, 46);
            this.lblFuel2.Name = "lblFuel2";
            this.lblFuel2.Size = new System.Drawing.Size(156, 13);
            this.lblFuel2.TabIndex = 2;
            this.lblFuel2.Text = "Previous odometer reading (km)";
            // 
            // lblFuel1
            // 
            this.lblFuel1.AutoSize = true;
            this.lblFuel1.ForeColor = System.Drawing.Color.Green;
            this.lblFuel1.Location = new System.Drawing.Point(7, 21);
            this.lblFuel1.Name = "lblFuel1";
            this.lblFuel1.Size = new System.Drawing.Size(149, 13);
            this.lblFuel1.TabIndex = 1;
            this.lblFuel1.Text = "Current odometer reading (km)";
            // 
            // grpFuelResult
            // 
            this.grpFuelResult.Controls.Add(this.pnlFuelResult);
            this.grpFuelResult.Controls.Add(this.lblFuelResult5);
            this.grpFuelResult.Controls.Add(this.lblFuelResult4);
            this.grpFuelResult.Controls.Add(this.lblFuelResult3);
            this.grpFuelResult.Controls.Add(this.lblFuelResult2);
            this.grpFuelResult.Controls.Add(this.lblFuelResult1);
            this.grpFuelResult.Location = new System.Drawing.Point(6, 152);
            this.grpFuelResult.Name = "grpFuelResult";
            this.grpFuelResult.Size = new System.Drawing.Size(272, 156);
            this.grpFuelResult.TabIndex = 0;
            this.grpFuelResult.TabStop = false;
            this.grpFuelResult.Text = "Results";
            // 
            // pnlFuelResult
            // 
            this.pnlFuelResult.Controls.Add(this.lblFuelResultKmPerLit);
            this.pnlFuelResult.Controls.Add(this.lblFuelResultLitPerKm);
            this.pnlFuelResult.Controls.Add(this.lblFuelResultLitPerMetricMile);
            this.pnlFuelResult.Controls.Add(this.lblFuelResultLitPerSweMil);
            this.pnlFuelResult.Controls.Add(this.lblFuelResultCostPerKm);
            this.pnlFuelResult.Location = new System.Drawing.Point(203, 20);
            this.pnlFuelResult.Name = "pnlFuelResult";
            this.pnlFuelResult.Size = new System.Drawing.Size(63, 118);
            this.pnlFuelResult.TabIndex = 1;
            // 
            // lblFuelResultKmPerLit
            // 
            this.lblFuelResultKmPerLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResultKmPerLit.ForeColor = System.Drawing.Color.Blue;
            this.lblFuelResultKmPerLit.Location = new System.Drawing.Point(6, 0);
            this.lblFuelResultKmPerLit.Name = "lblFuelResultKmPerLit";
            this.lblFuelResultKmPerLit.Size = new System.Drawing.Size(50, 20);
            this.lblFuelResultKmPerLit.TabIndex = 5;
            this.lblFuelResultKmPerLit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelResultLitPerKm
            // 
            this.lblFuelResultLitPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResultLitPerKm.ForeColor = System.Drawing.Color.Blue;
            this.lblFuelResultLitPerKm.Location = new System.Drawing.Point(6, 24);
            this.lblFuelResultLitPerKm.Name = "lblFuelResultLitPerKm";
            this.lblFuelResultLitPerKm.Size = new System.Drawing.Size(50, 20);
            this.lblFuelResultLitPerKm.TabIndex = 6;
            this.lblFuelResultLitPerKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelResultLitPerMetricMile
            // 
            this.lblFuelResultLitPerMetricMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResultLitPerMetricMile.ForeColor = System.Drawing.Color.Blue;
            this.lblFuelResultLitPerMetricMile.Location = new System.Drawing.Point(6, 49);
            this.lblFuelResultLitPerMetricMile.Name = "lblFuelResultLitPerMetricMile";
            this.lblFuelResultLitPerMetricMile.Size = new System.Drawing.Size(50, 20);
            this.lblFuelResultLitPerMetricMile.TabIndex = 7;
            this.lblFuelResultLitPerMetricMile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelResultLitPerSweMil
            // 
            this.lblFuelResultLitPerSweMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResultLitPerSweMil.ForeColor = System.Drawing.Color.Blue;
            this.lblFuelResultLitPerSweMil.Location = new System.Drawing.Point(6, 73);
            this.lblFuelResultLitPerSweMil.Name = "lblFuelResultLitPerSweMil";
            this.lblFuelResultLitPerSweMil.Size = new System.Drawing.Size(50, 20);
            this.lblFuelResultLitPerSweMil.TabIndex = 8;
            this.lblFuelResultLitPerSweMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelResultCostPerKm
            // 
            this.lblFuelResultCostPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResultCostPerKm.ForeColor = System.Drawing.Color.Blue;
            this.lblFuelResultCostPerKm.Location = new System.Drawing.Point(6, 98);
            this.lblFuelResultCostPerKm.Name = "lblFuelResultCostPerKm";
            this.lblFuelResultCostPerKm.Size = new System.Drawing.Size(50, 20);
            this.lblFuelResultCostPerKm.TabIndex = 9;
            this.lblFuelResultCostPerKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFuelResult5
            // 
            this.lblFuelResult5.AutoSize = true;
            this.lblFuelResult5.ForeColor = System.Drawing.Color.Green;
            this.lblFuelResult5.Location = new System.Drawing.Point(7, 118);
            this.lblFuelResult5.Name = "lblFuelResult5";
            this.lblFuelResult5.Size = new System.Drawing.Size(91, 13);
            this.lblFuelResult5.TabIndex = 4;
            this.lblFuelResult5.Text = "Cost per kilometer";
            // 
            // lblFuelResult4
            // 
            this.lblFuelResult4.AutoSize = true;
            this.lblFuelResult4.ForeColor = System.Drawing.Color.Green;
            this.lblFuelResult4.Location = new System.Drawing.Point(7, 93);
            this.lblFuelResult4.Name = "lblFuelResult4";
            this.lblFuelResult4.Size = new System.Drawing.Size(150, 13);
            this.lblFuelResult4.TabIndex = 3;
            this.lblFuelResult4.Text = "Fuel consumption (lit/Swe mil )";
            // 
            // lblFuelResult3
            // 
            this.lblFuelResult3.AutoSize = true;
            this.lblFuelResult3.ForeColor = System.Drawing.Color.Green;
            this.lblFuelResult3.Location = new System.Drawing.Point(7, 69);
            this.lblFuelResult3.Name = "lblFuelResult3";
            this.lblFuelResult3.Size = new System.Drawing.Size(160, 13);
            this.lblFuelResult3.TabIndex = 2;
            this.lblFuelResult3.Text = "Fuel consumption (lit/metric mile)";
            // 
            // lblFuelResult2
            // 
            this.lblFuelResult2.AutoSize = true;
            this.lblFuelResult2.ForeColor = System.Drawing.Color.Green;
            this.lblFuelResult2.Location = new System.Drawing.Point(7, 44);
            this.lblFuelResult2.Name = "lblFuelResult2";
            this.lblFuelResult2.Size = new System.Drawing.Size(125, 13);
            this.lblFuelResult2.TabIndex = 1;
            this.lblFuelResult2.Text = "Fuel consumption (lit/km)";
            // 
            // lblFuelResult1
            // 
            this.lblFuelResult1.AutoSize = true;
            this.lblFuelResult1.ForeColor = System.Drawing.Color.Green;
            this.lblFuelResult1.Location = new System.Drawing.Point(7, 20);
            this.lblFuelResult1.Name = "lblFuelResult1";
            this.lblFuelResult1.Size = new System.Drawing.Size(125, 13);
            this.lblFuelResult1.TabIndex = 0;
            this.lblFuelResult1.Text = "Fuel consumption (km/lit)";
            // 
            // grpBmi
            // 
            this.grpBmi.Controls.Add(this.btnBmiCalculate);
            this.grpBmi.Controls.Add(this.grpBmiResult);
            this.grpBmi.Controls.Add(this.rdoBmiUs);
            this.grpBmi.Controls.Add(this.rdoBmiMetric);
            this.grpBmi.Controls.Add(this.txtBmiWeight);
            this.grpBmi.Controls.Add(this.txtBmiHeight);
            this.grpBmi.Controls.Add(this.txtBmiName);
            this.grpBmi.Controls.Add(this.lblBmiWeight);
            this.grpBmi.Controls.Add(this.lblBmiHeight);
            this.grpBmi.Controls.Add(this.lblBmiName);
            this.grpBmi.ForeColor = System.Drawing.Color.Blue;
            this.grpBmi.Location = new System.Drawing.Point(333, 12);
            this.grpBmi.Name = "grpBmi";
            this.grpBmi.Size = new System.Drawing.Size(346, 317);
            this.grpBmi.TabIndex = 1;
            this.grpBmi.TabStop = false;
            this.grpBmi.Text = "BMI";
            this.grpBmi.Enter += new System.EventHandler(this.grpBmi_Enter);
            // 
            // btnBmiCalculate
            // 
            this.btnBmiCalculate.Location = new System.Drawing.Point(132, 121);
            this.btnBmiCalculate.Name = "btnBmiCalculate";
            this.btnBmiCalculate.Size = new System.Drawing.Size(120, 25);
            this.btnBmiCalculate.TabIndex = 9;
            this.btnBmiCalculate.Text = "Calculate";
            this.btnBmiCalculate.UseVisualStyleBackColor = true;
            this.btnBmiCalculate.Click += new System.EventHandler(this.btnBmiCalculate_Click);
            // 
            // grpBmiResult
            // 
            this.grpBmiResult.Controls.Add(this.pnlBmiResult);
            this.grpBmiResult.Controls.Add(this.lblBmiResult2);
            this.grpBmiResult.Controls.Add(this.lblBmiResult1);
            this.grpBmiResult.Location = new System.Drawing.Point(6, 152);
            this.grpBmiResult.Name = "grpBmiResult";
            this.grpBmiResult.Size = new System.Drawing.Size(334, 156);
            this.grpBmiResult.TabIndex = 8;
            this.grpBmiResult.TabStop = false;
            this.grpBmiResult.Text = "Results";
            // 
            // pnlBmiResult
            // 
            this.pnlBmiResult.Controls.Add(this.lblBmiResultInfo);
            this.pnlBmiResult.Controls.Add(this.lblBmiResultCategory);
            this.pnlBmiResult.Controls.Add(this.lblBmiResultBmi);
            this.pnlBmiResult.Location = new System.Drawing.Point(115, 20);
            this.pnlBmiResult.Name = "pnlBmiResult";
            this.pnlBmiResult.Size = new System.Drawing.Size(206, 118);
            this.pnlBmiResult.TabIndex = 2;
            // 
            // lblBmiResultInfo
            // 
            this.lblBmiResultInfo.Location = new System.Drawing.Point(8, 88);
            this.lblBmiResultInfo.Name = "lblBmiResultInfo";
            this.lblBmiResultInfo.Size = new System.Drawing.Size(195, 23);
            this.lblBmiResultInfo.TabIndex = 2;
            this.lblBmiResultInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBmiResultCategory
            // 
            this.lblBmiResultCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResultCategory.Location = new System.Drawing.Point(80, 30);
            this.lblBmiResultCategory.Name = "lblBmiResultCategory";
            this.lblBmiResultCategory.Size = new System.Drawing.Size(112, 20);
            this.lblBmiResultCategory.TabIndex = 1;
            this.lblBmiResultCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiResultBmi
            // 
            this.lblBmiResultBmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResultBmi.Location = new System.Drawing.Point(142, 2);
            this.lblBmiResultBmi.Name = "lblBmiResultBmi";
            this.lblBmiResultBmi.Size = new System.Drawing.Size(50, 20);
            this.lblBmiResultBmi.TabIndex = 0;
            this.lblBmiResultBmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiResult2
            // 
            this.lblBmiResult2.AutoSize = true;
            this.lblBmiResult2.ForeColor = System.Drawing.Color.Green;
            this.lblBmiResult2.Location = new System.Drawing.Point(23, 54);
            this.lblBmiResult2.Name = "lblBmiResult2";
            this.lblBmiResult2.Size = new System.Drawing.Size(86, 13);
            this.lblBmiResult2.TabIndex = 1;
            this.lblBmiResult2.Text = "Weight Category";
            // 
            // lblBmiResult1
            // 
            this.lblBmiResult1.AutoSize = true;
            this.lblBmiResult1.ForeColor = System.Drawing.Color.Green;
            this.lblBmiResult1.Location = new System.Drawing.Point(23, 26);
            this.lblBmiResult1.Name = "lblBmiResult1";
            this.lblBmiResult1.Size = new System.Drawing.Size(51, 13);
            this.lblBmiResult1.TabIndex = 0;
            this.lblBmiResult1.Text = "Your BMI";
            // 
            // rdoBmiUs
            // 
            this.rdoBmiUs.AutoSize = true;
            this.rdoBmiUs.ForeColor = System.Drawing.Color.Green;
            this.rdoBmiUs.Location = new System.Drawing.Point(223, 67);
            this.rdoBmiUs.Name = "rdoBmiUs";
            this.rdoBmiUs.Size = new System.Drawing.Size(105, 17);
            this.rdoBmiUs.TabIndex = 7;
            this.rdoBmiUs.Text = "US Unit (lb, inch)";
            this.rdoBmiUs.UseVisualStyleBackColor = true;
            this.rdoBmiUs.CheckedChanged += new System.EventHandler(this.rdoUs_CheckedChanged);
            // 
            // rdoBmiMetric
            // 
            this.rdoBmiMetric.AutoSize = true;
            this.rdoBmiMetric.ForeColor = System.Drawing.Color.Green;
            this.rdoBmiMetric.Location = new System.Drawing.Point(223, 44);
            this.rdoBmiMetric.Name = "rdoBmiMetric";
            this.rdoBmiMetric.Size = new System.Drawing.Size(117, 17);
            this.rdoBmiMetric.TabIndex = 6;
            this.rdoBmiMetric.Text = "Metric Unit (kg, cm)";
            this.rdoBmiMetric.UseVisualStyleBackColor = true;
            this.rdoBmiMetric.CheckedChanged += new System.EventHandler(this.rdoMetric_CheckedChanged);
            // 
            // txtBmiWeight
            // 
            this.txtBmiWeight.Location = new System.Drawing.Point(104, 66);
            this.txtBmiWeight.Name = "txtBmiWeight";
            this.txtBmiWeight.Size = new System.Drawing.Size(59, 20);
            this.txtBmiWeight.TabIndex = 5;
            // 
            // txtBmiHeight
            // 
            this.txtBmiHeight.Location = new System.Drawing.Point(104, 43);
            this.txtBmiHeight.Name = "txtBmiHeight";
            this.txtBmiHeight.Size = new System.Drawing.Size(59, 20);
            this.txtBmiHeight.TabIndex = 4;
            // 
            // txtBmiName
            // 
            this.txtBmiName.Location = new System.Drawing.Point(104, 18);
            this.txtBmiName.Name = "txtBmiName";
            this.txtBmiName.Size = new System.Drawing.Size(236, 20);
            this.txtBmiName.TabIndex = 3;
            // 
            // lblBmiWeight
            // 
            this.lblBmiWeight.AutoSize = true;
            this.lblBmiWeight.ForeColor = System.Drawing.Color.Green;
            this.lblBmiWeight.Location = new System.Drawing.Point(26, 69);
            this.lblBmiWeight.Name = "lblBmiWeight";
            this.lblBmiWeight.Size = new System.Drawing.Size(62, 13);
            this.lblBmiWeight.TabIndex = 2;
            this.lblBmiWeight.Text = "Weight (kg)";
            // 
            // lblBmiHeight
            // 
            this.lblBmiHeight.AutoSize = true;
            this.lblBmiHeight.ForeColor = System.Drawing.Color.Green;
            this.lblBmiHeight.Location = new System.Drawing.Point(26, 46);
            this.lblBmiHeight.Name = "lblBmiHeight";
            this.lblBmiHeight.Size = new System.Drawing.Size(61, 13);
            this.lblBmiHeight.TabIndex = 1;
            this.lblBmiHeight.Text = "Height (cm)";
            // 
            // lblBmiName
            // 
            this.lblBmiName.AutoSize = true;
            this.lblBmiName.ForeColor = System.Drawing.Color.Green;
            this.lblBmiName.Location = new System.Drawing.Point(26, 21);
            this.lblBmiName.Name = "lblBmiName";
            this.lblBmiName.Size = new System.Drawing.Size(58, 13);
            this.lblBmiName.TabIndex = 0;
            this.lblBmiName.Text = "Your name";
            // 
            // grpBmr
            // 
            this.grpBmr.Controls.Add(this.lblBmrIndex);
            this.grpBmr.Controls.Add(this.btnBmrUnselect);
            this.grpBmr.Controls.Add(this.lstBmr);
            this.grpBmr.Controls.Add(this.btnBmrCalculate);
            this.grpBmr.Controls.Add(this.txtBmrAge);
            this.grpBmr.Controls.Add(this.grpBmrActivity);
            this.grpBmr.Controls.Add(this.lblBmrAge);
            this.grpBmr.Controls.Add(this.rdoBmrMale);
            this.grpBmr.Controls.Add(this.rdoBmrFemale);
            this.grpBmr.ForeColor = System.Drawing.Color.Blue;
            this.grpBmr.Location = new System.Drawing.Point(12, 336);
            this.grpBmr.Name = "grpBmr";
            this.grpBmr.Size = new System.Drawing.Size(667, 264);
            this.grpBmr.TabIndex = 2;
            this.grpBmr.TabStop = false;
            this.grpBmr.Text = "BMR";
            this.grpBmr.Enter += new System.EventHandler(this.grpBmr_Enter);
            // 
            // lblBmrIndex
            // 
            this.lblBmrIndex.AutoSize = true;
            this.lblBmrIndex.Location = new System.Drawing.Point(278, 216);
            this.lblBmrIndex.Name = "lblBmrIndex";
            this.lblBmrIndex.Size = new System.Drawing.Size(0, 13);
            this.lblBmrIndex.TabIndex = 13;
            // 
            // btnBmrUnselect
            // 
            this.btnBmrUnselect.Location = new System.Drawing.Point(559, 217);
            this.btnBmrUnselect.Name = "btnBmrUnselect";
            this.btnBmrUnselect.Size = new System.Drawing.Size(75, 23);
            this.btnBmrUnselect.TabIndex = 12;
            this.btnBmrUnselect.Text = "Unselect";
            this.btnBmrUnselect.UseVisualStyleBackColor = true;
            this.btnBmrUnselect.Click += new System.EventHandler(this.btnBmrUnselect_Click);
            // 
            // lstBmr
            // 
            this.lstBmr.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBmr.ForeColor = System.Drawing.Color.Blue;
            this.lstBmr.FormattingEnabled = true;
            this.lstBmr.Location = new System.Drawing.Point(271, 20);
            this.lstBmr.Name = "lstBmr";
            this.lstBmr.Size = new System.Drawing.Size(378, 186);
            this.lstBmr.TabIndex = 11;
            this.lstBmr.SelectedIndexChanged += new System.EventHandler(this.lstBmr_SelectedIndexChanged);
            // 
            // btnBmrCalculate
            // 
            this.btnBmrCalculate.Location = new System.Drawing.Point(73, 216);
            this.btnBmrCalculate.Name = "btnBmrCalculate";
            this.btnBmrCalculate.Size = new System.Drawing.Size(120, 25);
            this.btnBmrCalculate.TabIndex = 10;
            this.btnBmrCalculate.Text = "Calculate";
            this.btnBmrCalculate.UseVisualStyleBackColor = true;
            this.btnBmrCalculate.Click += new System.EventHandler(this.btnBmrCalculate_Click);
            // 
            // txtBmrAge
            // 
            this.txtBmrAge.Location = new System.Drawing.Point(233, 41);
            this.txtBmrAge.Name = "txtBmrAge";
            this.txtBmrAge.Size = new System.Drawing.Size(32, 20);
            this.txtBmrAge.TabIndex = 4;
            // 
            // grpBmrActivity
            // 
            this.grpBmrActivity.Controls.Add(this.rdoBmrExtra);
            this.grpBmrActivity.Controls.Add(this.rdoBmrVery);
            this.grpBmrActivity.Controls.Add(this.rdoBmrModerately);
            this.grpBmrActivity.Controls.Add(this.rdoBmrLightly);
            this.grpBmrActivity.Controls.Add(this.rdoBmrSedentary);
            this.grpBmrActivity.Location = new System.Drawing.Point(19, 71);
            this.grpBmrActivity.Name = "grpBmrActivity";
            this.grpBmrActivity.Size = new System.Drawing.Size(246, 139);
            this.grpBmrActivity.TabIndex = 3;
            this.grpBmrActivity.TabStop = false;
            this.grpBmrActivity.Text = "Activity level per week";
            // 
            // rdoBmrExtra
            // 
            this.rdoBmrExtra.AutoSize = true;
            this.rdoBmrExtra.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrExtra.Location = new System.Drawing.Point(7, 112);
            this.rdoBmrExtra.Name = "rdoBmrExtra";
            this.rdoBmrExtra.Size = new System.Drawing.Size(184, 17);
            this.rdoBmrExtra.TabIndex = 4;
            this.rdoBmrExtra.TabStop = true;
            this.rdoBmrExtra.Text = "Extra active, hard exercises or job";
            this.rdoBmrExtra.UseVisualStyleBackColor = true;
            this.rdoBmrExtra.CheckedChanged += new System.EventHandler(this.rdoBmrExtra_CheckedChanged);
            // 
            // rdoBmrVery
            // 
            this.rdoBmrVery.AutoSize = true;
            this.rdoBmrVery.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrVery.Location = new System.Drawing.Point(7, 89);
            this.rdoBmrVery.Name = "rdoBmrVery";
            this.rdoBmrVery.Size = new System.Drawing.Size(136, 17);
            this.rdoBmrVery.TabIndex = 3;
            this.rdoBmrVery.TabStop = true;
            this.rdoBmrVery.Text = "Very active (6 to 7 time)";
            this.rdoBmrVery.UseVisualStyleBackColor = true;
            this.rdoBmrVery.CheckedChanged += new System.EventHandler(this.rdoBmrVery_CheckedChanged);
            // 
            // rdoBmrModerately
            // 
            this.rdoBmrModerately.AutoSize = true;
            this.rdoBmrModerately.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrModerately.Location = new System.Drawing.Point(7, 66);
            this.rdoBmrModerately.Name = "rdoBmrModerately";
            this.rdoBmrModerately.Size = new System.Drawing.Size(167, 17);
            this.rdoBmrModerately.TabIndex = 2;
            this.rdoBmrModerately.TabStop = true;
            this.rdoBmrModerately.Text = "Moderately active (3 to 5 time)";
            this.rdoBmrModerately.UseVisualStyleBackColor = true;
            this.rdoBmrModerately.CheckedChanged += new System.EventHandler(this.rdoBmrModerately_CheckedChanged);
            // 
            // rdoBmrLightly
            // 
            this.rdoBmrLightly.AutoSize = true;
            this.rdoBmrLightly.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrLightly.Location = new System.Drawing.Point(7, 43);
            this.rdoBmrLightly.Name = "rdoBmrLightly";
            this.rdoBmrLightly.Size = new System.Drawing.Size(145, 17);
            this.rdoBmrLightly.TabIndex = 1;
            this.rdoBmrLightly.TabStop = true;
            this.rdoBmrLightly.Text = "Lightly active (1 to 3 time)";
            this.rdoBmrLightly.UseVisualStyleBackColor = true;
            this.rdoBmrLightly.CheckedChanged += new System.EventHandler(this.rdoBmrLightly_CheckedChanged);
            // 
            // rdoBmrSedentary
            // 
            this.rdoBmrSedentary.AutoSize = true;
            this.rdoBmrSedentary.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrSedentary.Location = new System.Drawing.Point(7, 20);
            this.rdoBmrSedentary.Name = "rdoBmrSedentary";
            this.rdoBmrSedentary.Size = new System.Drawing.Size(169, 17);
            this.rdoBmrSedentary.TabIndex = 0;
            this.rdoBmrSedentary.TabStop = true;
            this.rdoBmrSedentary.Text = "Sedentary (little or no exercise)";
            this.rdoBmrSedentary.UseVisualStyleBackColor = true;
            this.rdoBmrSedentary.CheckedChanged += new System.EventHandler(this.rdoBmrSedentary_CheckedChanged);
            // 
            // lblBmrAge
            // 
            this.lblBmrAge.AutoSize = true;
            this.lblBmrAge.ForeColor = System.Drawing.Color.Green;
            this.lblBmrAge.Location = new System.Drawing.Point(16, 44);
            this.lblBmrAge.Name = "lblBmrAge";
            this.lblBmrAge.Size = new System.Drawing.Size(26, 13);
            this.lblBmrAge.TabIndex = 2;
            this.lblBmrAge.Text = "Age";
            // 
            // rdoBmrMale
            // 
            this.rdoBmrMale.AutoSize = true;
            this.rdoBmrMale.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrMale.Location = new System.Drawing.Point(108, 20);
            this.rdoBmrMale.Name = "rdoBmrMale";
            this.rdoBmrMale.Size = new System.Drawing.Size(48, 17);
            this.rdoBmrMale.TabIndex = 1;
            this.rdoBmrMale.TabStop = true;
            this.rdoBmrMale.Text = "Male";
            this.rdoBmrMale.UseVisualStyleBackColor = true;
            this.rdoBmrMale.CheckedChanged += new System.EventHandler(this.rdoBmrMale_CheckedChanged);
            // 
            // rdoBmrFemale
            // 
            this.rdoBmrFemale.AutoSize = true;
            this.rdoBmrFemale.ForeColor = System.Drawing.Color.Green;
            this.rdoBmrFemale.Location = new System.Drawing.Point(16, 20);
            this.rdoBmrFemale.Name = "rdoBmrFemale";
            this.rdoBmrFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoBmrFemale.TabIndex = 0;
            this.rdoBmrFemale.TabStop = true;
            this.rdoBmrFemale.Text = "Female";
            this.rdoBmrFemale.UseVisualStyleBackColor = true;
            this.rdoBmrFemale.CheckedChanged += new System.EventHandler(this.rdoBmrFemale_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 612);
            this.Controls.Add(this.grpBmr);
            this.Controls.Add(this.grpBmi);
            this.Controls.Add(this.grpFuel);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "MainForm";
            this.Text = "Universal calculator";
            this.grpFuel.ResumeLayout(false);
            this.grpFuel.PerformLayout();
            this.grpFuelResult.ResumeLayout(false);
            this.grpFuelResult.PerformLayout();
            this.pnlFuelResult.ResumeLayout(false);
            this.grpBmi.ResumeLayout(false);
            this.grpBmi.PerformLayout();
            this.grpBmiResult.ResumeLayout(false);
            this.grpBmiResult.PerformLayout();
            this.pnlBmiResult.ResumeLayout(false);
            this.grpBmr.ResumeLayout(false);
            this.grpBmr.PerformLayout();
            this.grpBmrActivity.ResumeLayout(false);
            this.grpBmrActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuel;
        private System.Windows.Forms.GroupBox grpFuelResult;
        private System.Windows.Forms.Label lblFuel1;
        private System.Windows.Forms.Label lblFuel4;
        private System.Windows.Forms.Label lblFuel3;
        private System.Windows.Forms.Label lblFuel2;
        private System.Windows.Forms.Label lblFuelResultCostPerKm;
        private System.Windows.Forms.Label lblFuelResultLitPerSweMil;
        private System.Windows.Forms.Label lblFuelResultLitPerMetricMile;
        private System.Windows.Forms.Label lblFuelResultLitPerKm;
        private System.Windows.Forms.Label lblFuelResult5;
        private System.Windows.Forms.Label lblFuelResult4;
        private System.Windows.Forms.Label lblFuelResult3;
        private System.Windows.Forms.Label lblFuelResult2;
        private System.Windows.Forms.Label lblFuelResult1;
        private System.Windows.Forms.TextBox txtFuelPricePerLiter;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.TextBox txtFuelPrevious;
        private System.Windows.Forms.TextBox txtFuelCurrent;
        private System.Windows.Forms.Label lblFuelResultKmPerLit;
        private System.Windows.Forms.Button btnFuelCalculate;
        private System.Windows.Forms.Panel pnlFuelResult;
        private System.Windows.Forms.GroupBox grpBmi;
        private System.Windows.Forms.GroupBox grpBmiResult;
        private System.Windows.Forms.RadioButton rdoBmiUs;
        private System.Windows.Forms.RadioButton rdoBmiMetric;
        private System.Windows.Forms.TextBox txtBmiWeight;
        private System.Windows.Forms.TextBox txtBmiHeight;
        private System.Windows.Forms.TextBox txtBmiName;
        private System.Windows.Forms.Label lblBmiWeight;
        private System.Windows.Forms.Label lblBmiHeight;
        private System.Windows.Forms.Label lblBmiName;
        private System.Windows.Forms.Panel pnlBmiResult;
        private System.Windows.Forms.Label lblBmiResult2;
        private System.Windows.Forms.Label lblBmiResult1;
        private System.Windows.Forms.Label lblBmiResultCategory;
        private System.Windows.Forms.Label lblBmiResultBmi;
        private System.Windows.Forms.Label lblBmiResultInfo;
        private System.Windows.Forms.Button btnBmiCalculate;
        private System.Windows.Forms.GroupBox grpBmr;
        private System.Windows.Forms.RadioButton rdoBmrMale;
        private System.Windows.Forms.RadioButton rdoBmrFemale;
        private System.Windows.Forms.TextBox txtBmrAge;
        private System.Windows.Forms.GroupBox grpBmrActivity;
        private System.Windows.Forms.RadioButton rdoBmrExtra;
        private System.Windows.Forms.RadioButton rdoBmrVery;
        private System.Windows.Forms.RadioButton rdoBmrModerately;
        private System.Windows.Forms.RadioButton rdoBmrLightly;
        private System.Windows.Forms.RadioButton rdoBmrSedentary;
        private System.Windows.Forms.Label lblBmrAge;
        private System.Windows.Forms.Button btnBmrCalculate;
        private System.Windows.Forms.ListBox lstBmr;
        private System.Windows.Forms.Button btnBmrUnselect;
        private System.Windows.Forms.Label lblBmrIndex;
    }
}

