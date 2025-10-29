using System;
using System.Globalization;
using System.Windows.Forms;

namespace For_Loop_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Part II requirement: each conversion method returns the converted value.
        // These methods are simple, single-expression methods that apply the given formulas.
        private double InchesToCm(double inches) => inches * 2.54;
        private double FeetToCm(double feet) => feet * 30.48;
        private double YardsToMetres(double yards) => yards * 0.91;
        private double MilesToKm(double miles) => miles * 1.6;

        /// <summary>
        /// Click handler for Convert button.
        /// Validates input, determines which conversion is selected,
        /// calls the appropriate conversion method, and displays the result
        /// formatted to two decimal places.
        /// </summary>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Clear previous result
            lblResult.Text = string.Empty;

            // Validate that something was entered
            if (string.IsNullOrWhiteSpace(txtValue.Text))
            {
                MessageBox.Show("Please enter a value to convert.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
                return;
            }

            // Parse input as double using invariant culture to accept dot as decimal separator
            if (!double.TryParse(txtValue.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double inputValue))
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValue.Focus();
                return;
            }

            // Variables to hold conversion result and units for display
            double converted;
            string inputUnit;
            string outputUnit;

            // Determine which radio button is checked and call the corresponding method
            if (rbInches.Checked)
            {
                converted = InchesToCm(inputValue); // call InchesToCm with parameter
                inputUnit = "inches";
                outputUnit = "centimetres";
            }
            else if (rbFeet.Checked)
            {
                converted = FeetToCm(inputValue); // call FeetToCm with parameter
                inputUnit = "feet";
                outputUnit = "centimetres";
            }
            else if (rbYards.Checked)
            {
                converted = YardsToMetres(inputValue); // call YardsToMetres with parameter
                inputUnit = "yards";
                outputUnit = "metres";
            }
            else if (rbMiles.Checked)
            {
                converted = MilesToKm(inputValue); // call MilesToKm with parameter
                inputUnit = "miles";
                outputUnit = "kilometres";
            }
            else
            {
                // No choice selected: show message and exit handler
                MessageBox.Show("Please select a conversion type.", "Choice Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display the formatted result to two decimal places as required
            lblResult.Text = $"{inputValue:0.00} {inputUnit} = {converted:0.00} {outputUnit}";
        }

        /// <summary>
        /// Click handler for Clear button.
        /// Resets input, result label and radio button selection.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = string.Empty;     // clear the input textbox
            lblResult.Text = string.Empty;    // clear the result label
            rbInches.Checked = true;          // reset selection to a sensible default
            txtValue.Focus();                 // focus the input for quick re-entry
        }
    }
}