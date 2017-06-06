// Filip Andersson Vestman  29/10-17
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{

    public partial class MainForm : Form
    {
        private FuelCalculator _carMileage = new FuelCalculator();
        private BodyMassIndex _bmiCalc = new BodyMassIndex();
        private CalorieCalculator _bmrCalc = new CalorieCalculator();
        private string _name = "NoName";

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Clears labels
        /// </summary>
        /// <param name="ctrlCollection">Controls with labels</param>
        private void ClearLabels(params Control[] ctrlCollection)
        {
            foreach (var c in ctrlCollection)
            {
                foreach (var lbl in c.Controls.OfType<Label>())
                    lbl.Text = string.Empty;
            }

        }

        /// <summary>
        /// Clears textboxes
        /// </summary>
        /// <param name="ctrlCollection">Controls with textboxes</param>
        private void ClearTextBoxes(params Control[] ctrlCollection)
        {
            foreach (var c in ctrlCollection)
            {
                foreach (var txt in c.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
            }

        }

        /// <summary>
        /// Initializes radio buttons
        /// </summary>
        private void InitializeGUI()
        {
            rdoBmiMetric.Checked = true;
            rdoBmrFemale.Checked = true;
            rdoBmrSedentary.Checked = true;
        }

        /// <summary>
        /// Updates the result for Fuel
        /// </summary>
        private void UpdateGUIFuel()
        {
            lblFuelResultKmPerLit.Text = _carMileage.CalcConsumptionKilometerPerLiter().ToString("0.00");
            lblFuelResultLitPerKm.Text = _carMileage.CalcFuelConsumptionPerKm().ToString("0.00");
            lblFuelResultLitPerMetricMile.Text = _carMileage.CalcConsumptionPerMetricMile().ToString("0.00");
            lblFuelResultLitPerSweMil.Text = _carMileage.CalcFuelConsumptionPerSweMil().ToString("0.00");
            lblFuelResultCostPerKm.Text = _carMileage.CalcCostPerKm().ToString("0.00");
        }

        /// <summary>
        /// Makes sure all the input is correct and can be converted to double
        /// </summary>
        /// <returns>True if values are valid, false otherwise</returns>
        private bool ReadInputFuel() //Gör den här metoden för mycket?
        {
            if (double.TryParse(txtFuelCurrent.Text, out var curr) &&
                double.TryParse(txtFuelPrevious.Text, out var prev) &&
                double.TryParse(txtFuelAmount.Text, out var amount) &&
                double.TryParse(txtFuelPricePerLiter.Text, out var price))
            {
                _carMileage.CurrReading = curr;
                _carMileage.PrevReading = prev;
                _carMileage.FuelAmount = amount;
                _carMileage.UnitPrice = price;
                if (_carMileage.GetValidateOdometerValues())
                    return true;
            }
            MessageBox.Show("Error: Invalid input in Fuel calculator", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearTextBoxes(grpFuel);
            return false;
        }

        /// <summary>
        /// Converts value in textfields to unit
        /// </summary>
        /// <param name="unit">Unit to convert to</param>
        private void ConvertWeightAndHeightTo(Unit unit)
        {
            if (unit == Unit.Metric)
            {
                try
                {
                    txtBmiHeight.Text = (Convert.ToDouble(txtBmiHeight.Text) * 2.54).ToString("0");
                    txtBmiWeight.Text = (Convert.ToDouble(txtBmiWeight.Text) / 2.2046226218).ToString("0");
                }
                catch (Exception)
                {
                    ClearTextBoxes(grpBmi);
                }
            }
            else
            {
                try
                {
                    txtBmiHeight.Text = (Convert.ToDouble(txtBmiHeight.Text) / 2.54).ToString("0.00");
                    txtBmiWeight.Text = (Convert.ToDouble(txtBmiWeight.Text) * 2.2046226218).ToString("0.00");
                }
                catch (Exception)
                {
                    ClearTextBoxes(grpBmi);
                }
            }

        }

        /// <summary>
        /// Makes sure height and weight are both correct
        /// </summary>
        /// <returns>True if values are valid, false otherwise</returns>
        private bool ReadHeightAndWeight()
        {
            if (double.TryParse(txtBmiHeight.Text, out var height) &&
                double.TryParse(txtBmiWeight.Text, out var weight))
            {
                if (height > 0 && weight > 0)
                {
                    _bmiCalc.Height = height;
                    _bmiCalc.Weight = weight;
                    return true;
                }

            }
            MessageBox.Show("Error: Invalid input in BMI calculator", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearTextBoxes(grpBmi);
            return false;
        }

        /// <summary>
        /// Updates _name if textbox isn't empty
        /// </summary>
        /// <returns>True</returns>
        private bool ReadName()
        {
            if (txtBmiName.Text == string.Empty)
                return true;
            _name = txtBmiName.Text;
            return true;

        }

        /// <summary>
        /// Makes sure the input is correct, otherwise show error box
        /// </summary>
        /// <returns>True if valid input, false otherwise</returns>
        private bool InputBMR()
        {
            if (int.TryParse(txtBmrAge.Text, out var age) &&
                double.TryParse(txtBmiHeight.Text, out var height) &&
                double.TryParse(txtBmiWeight.Text, out var weight))
            {
                if (age > 0 && height > 0 && weight > 0)
                {
                    _bmrCalc.Age = age;
                    _bmrCalc.Height = height;
                    _bmrCalc.Weight = weight;
                    return true;
                }

            }
            MessageBox.Show("Error: Invalid input in BMR calculator", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ClearTextBoxes(grpBmr, grpBmi);
            return false;
        }

        /// <summary>
        /// Updates GUI for BMR Calculator
        /// </summary>
        private void UpdateGUIBMR()
        {
            lstBmr.DataSource = _bmrCalc.BuildOutput(_name, _bmrCalc.CalculateBMR());
        }

        /// <summary>
        /// Updates GUI for BMI Calculator
        /// </summary>
        private void UpdateGUIBMI()
        {
            grpBmiResult.Text = $"Results for {_name}";
            lblBmiResultBmi.Text = _bmiCalc.CalculateBMI().ToString("0.00");
            lblBmiResultCategory.Text = _bmiCalc.CalculateCategory();
            lblBmiResultInfo.Text = _bmiCalc.InfoMessage();
        }

        /// <summary>
        /// Updates the accept button
        /// </summary>
        /// <param name="button">New accept button</param>
        private void UpdateAcceptButton(Button button)
        {
            AcceptButton = button;
        }

        /// <summary>
        /// Clears old result, reads input and updates gui if valid
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnFuelCalculate_Click(object sender, EventArgs e)
        {
            ClearLabels(pnlFuelResult);
            if (ReadInputFuel())
                UpdateGUIFuel();

        }

        /// <summary>
        /// Clears old result, reads input and updates gui if valid
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnBmiCalculate_Click(object sender, EventArgs e)
        {
            grpBmiResult.Text = "Results";
            ClearLabels(pnlBmiResult);
            if (ReadHeightAndWeight() && ReadName())
                UpdateGUIBMI();
        }

        /// <summary>
        /// Updates Unit for BMI calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoMetric_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                lblBmiHeight.Text = "Height (cm)";
                lblBmiWeight.Text = "Weight (kg)";
                _bmiCalc.Unit = Unit.Metric;
                _bmrCalc.Unit = Unit.Metric;
                ConvertWeightAndHeightTo(Unit.Metric);
            }
        }

        /// <summary>
        /// Updates Unit for BMI calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoUs_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                lblBmiHeight.Text = "Height (inch)";
                lblBmiWeight.Text = "Weight (lb)";
                _bmiCalc.Unit = Unit.Us;
                _bmrCalc.Unit = Unit.Us;
                ConvertWeightAndHeightTo(Unit.Us);
            }
        }

        /// <summary>
        /// Reads input and updates GUI for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnBmrCalculate_Click(object sender, EventArgs e)
        {
            if (InputBMR())
            {
                ReadName();
                UpdateGUIBMR();
                lstBmr.ClearSelected();
            }

        }

        /// <summary>
        /// Updates Activity for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrSedentary_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Activity = Activity.Sedentary;
        }

        /// <summary>
        /// Updates Activity for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrLightly_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Activity = Activity.Lightly;
        }

        /// <summary>
        /// Updates Activity for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrModerately_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Activity = Activity.Moderately;
        }

        /// <summary>
        /// Updates Activity for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrVery_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Activity = Activity.Very;
        }

        /// <summary>
        /// Updates Activity for BMR calculator
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrExtra_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Activity = Activity.Extra;
        }

        /// <summary>
        /// Clears selection from listbox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void btnBmrUnselect_Click(object sender, EventArgs e)
        {
            lstBmr.ClearSelected();
        }

        /// <summary>
        /// Updates label according to selection index
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void lstBmr_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = lstBmr.SelectedIndex;
            if (selected >= 0)
                lblBmrIndex.Text = $"Selected item: {selected.ToString()}";
            else
                lblBmrIndex.Text = selected.ToString();
        }

        /// <summary>
        /// Updates gender to female if checked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrFemale_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Gender = Gender.Female;
        }

        /// <summary>
        /// Updates gender to male if checked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void rdoBmrMale_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                _bmrCalc.Gender = Gender.Male;
        }

        /// <summary>
        /// Updates to right accept button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void grpBmr_Enter(object sender, EventArgs e)
        {
            UpdateAcceptButton(btnBmrCalculate);
        }

        /// <summary>
        /// Updates to right accept button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void grpBmi_Enter(object sender, EventArgs e)
        {
            UpdateAcceptButton(btnBmiCalculate);
        }

        /// <summary>
        /// Updates to right accept button
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void grpFuel_Enter(object sender, EventArgs e)
        {
            UpdateAcceptButton(btnFuelCalculate);
        }
    }
}
