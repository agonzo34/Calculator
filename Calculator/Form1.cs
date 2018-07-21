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
        public Form1() {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e) {
            resultBox.Text = "1";
        }

        private void number2_Click(object sender, EventArgs e) {
            resultBox.Text = "2";
        }

        private void number3_Click(object sender, EventArgs e) {
            resultBox.Text = "3";
        }

        private void number4_Click(object sender, EventArgs e) {
            resultBox.Text = "4";
        }

        private void number5_Click(object sender, EventArgs e) {
            resultBox.Text = "5";
        }

        private void number6_Click(object sender, EventArgs e) {
            resultBox.Text = "6";
        }

        private void number7_Click(object sender, EventArgs e) {
            resultBox.Text = "7";
        }

        private void number8_Click(object sender, EventArgs e) {
            resultBox.Text = "8";
        }

        private void number9_Click(object sender, EventArgs e) {
            resultBox.Text = "9";
        }

        private void number0_Click(object sender, EventArgs e) {
            resultBox.Text = "0";
        }

        private void addButton_Click(object sender, EventArgs e) {

        }

        private void subButton_Click(object sender, EventArgs e) {

        }

        private void multiplyButton_Click(object sender, EventArgs e) {

        }

        private void divisionButton_Click(object sender, EventArgs e) {

        }

        private void calculateButton_Click(object sender, EventArgs e) {

        }

    }
}
