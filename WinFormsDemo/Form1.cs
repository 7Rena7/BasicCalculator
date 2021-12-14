using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsDemo
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Loader

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Operator Functions
        /// <summary>
        /// Inserts a foward slash (dividing symbol) in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void divideButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("/");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a multiply symbol in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("*");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a minus symbol in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void minusButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("-");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a plus symbol in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void addingButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("+");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts the result of the equation located in the textbox into the user label (calculationResultText)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalsButton_Click(object sender, EventArgs e)
        {
            this.CalculateEquation();
        }

        #endregion

        #region Number Functions
        /// <summary>
        /// Inserts a zero in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void zeroButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("0");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a one in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void oneButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("1");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a two in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void twoButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("2");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a three in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void threeButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("3");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a four in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fourButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("4");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a five in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void fiveButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("5");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a six in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sixButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("6");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a seven in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void sevenButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("7");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a eight in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void eightButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("8");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a nine in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void nineButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText("9");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Changes the sign of the value inserted
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void plusMinusButton_Click(object sender, EventArgs e)
        {


            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        /// <summary>
        /// Inserts a coma in the focused position of the textbox text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void comaButton_Click(object sender, EventArgs e)
        {
            this.InsertStringInText(",");

            //Focus the user input text
            this.FocusPointerOnInputText();
        }
        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input textbox
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //Clears the text drom the user input text box
            this.userInputText.Text = string.Empty;

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        private void CButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Deletes a character from the textbox text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.DeleteCharacterinFront();

            //Focus the user input text
            this.FocusPointerOnInputText();
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusPointerOnInputText()
        {
            this.userInputText.Focus();
        }

        /// <summary>
        /// Inserts the value into the textbox text
        /// </summary>
        /// <param name="pString">The value to insert</param>
        private void InsertStringInText(string pValue)
        {
            //Remember selection start
            var selectionStart = this.userInputText.SelectionStart;

            //Set new text
            this.userInputText.Text = this.userInputText.Text.Insert(this.userInputText.SelectionStart, pValue);

            //Restore the selection start
            this.userInputText.SelectionStart = selectionStart + pValue.Length;

            // Set selection length to 0
            this.userInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Removes a character from the textbox text
        /// </summary>
        /// <returns>A new string with the character removed</returns>
        private void DeleteCharacterinFront()
        {
            //Check if there is a character in front of the focused position to delete
            if (this.userInputText.Text.Length < this.userInputText.SelectionStart + 1)
                return;

            //Remember selection start
            var selectionStart = this.userInputText.SelectionStart;

            //Set new text
            this.userInputText.Text = this.userInputText.Text.Remove(this.userInputText.SelectionStart, 1);

            //Restore the selection start
            this.userInputText.SelectionStart = selectionStart;

            // Set selection length to 0
            this.userInputText.SelectionLength = 0;
        }

        #endregion

        #region Calculating Result

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label (calculationResultText)
        /// </summary>
        private void CalculateEquation()
        {

            this.calculationResultText.Text = ParseOperation();



            //Focus the user input text
            this.FocusPointerOnInputText();

        }

        /// <summary>
        /// Parses the users equation and caluclates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the users equation input
                var input = this.userInputText.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();

                // Variable that dictates if we are working
                // on the left side of the equation
                var leftSide = true;

                // Loop through each character of the input
                // strating form the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    // Example: 4 + 5 * 3
                    // It should calculate 5 * 3 first, then 4 + the result (so 4 + 15)

                    // Define the valid characters of our calculator
                    var validChar = "0123456789.";

                    // Check if the current character is a number
                    if (validChar.Any(c => input[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        }
                    }


                }
                



                return string.Empty;

            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Atempt to add a new character to the current number, checking of invalid character as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="currentChar">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newChar)
        {
            //Check if there is already a . in the currentNumber
            if (newChar == '.' && currentNumber.Contains("."))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newChar;
        }

        #endregion
    }
}
