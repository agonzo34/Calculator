using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {

        // Global variables for Calculator.
        Calculation calculation = new Calculation();

        public Form1() {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e) {
            if(calculation.isInputOne) {
                calculation.inputOne += "1";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "1";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number2_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "2";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "2";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number3_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "3";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "3";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number4_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "4";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "4";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number5_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "5";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "5";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number6_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "6";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "6";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number7_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "7";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "7";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number8_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "8";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "8";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number9_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "9";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "9";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void number0_Click(object sender, EventArgs e) {
            if (calculation.isInputOne) {
                calculation.inputOne += "0";
                resultBox.Text = calculation.inputOne;
            } else {
                calculation.inputTwo += "0";
                resultBox.Text = calculation.inputTwo;
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            calculation.operation.setAddition();
            calculation.isInputOne = false;
        }

        private void subButton_Click(object sender, EventArgs e) {
            calculation.operation.setSubtraction();
            calculation.isInputOne = false;
        }

        private void multiplyButton_Click(object sender, EventArgs e) {
            calculation.operation.setMultiplication();
            calculation.isInputOne = false;
        }

        private void divisionButton_Click(object sender, EventArgs e) {
            calculation.operation.setDivision();
            calculation.isInputOne = false;
        }

        private void calculateButton_Click(object sender, EventArgs e) {
            if(calculation.operation.isAddition) {
                int output = Convert.ToInt32(calculation.inputOne) + Convert.ToInt32(calculation.inputTwo);
                resultBox.Text = output.ToString();
            } else if (calculation.operation.isSubtraction) {
                int output = Convert.ToInt32(calculation.inputOne) - Convert.ToInt32(calculation.inputTwo);
                resultBox.Text = output.ToString();
            } else if (calculation.operation.isMultiplication) {
                int output = Convert.ToInt32(calculation.inputOne) * Convert.ToInt32(calculation.inputTwo);
                resultBox.Text = output.ToString();
            } else if (calculation.operation.isDivision) {
                int output = Convert.ToInt32(calculation.inputOne) / Convert.ToInt32(calculation.inputTwo);
                resultBox.Text = output.ToString();
            }
        }

    }
}
