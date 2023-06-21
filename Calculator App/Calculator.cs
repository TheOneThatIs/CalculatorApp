using System.Diagnostics.Eventing.Reader;

namespace Calculator_App {
	public partial class Calculator : Form {

		Double prevValue = 0;
		Double currentValue = 0;
		String lastOperator = "";
		bool isNegative = false;

		public Calculator() {
			InitializeComponent();
			previousOperationsLabel.Text = "0";
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void numberButton_Click(object sender, EventArgs e) {
			Button button = (Button)sender;

			if(button.Text != ".") {
				textBox.Text += button.Text;
				currentValue = Double.Parse(textBox.Text);
			} else {
				if(textBox.Text == "") {
					textBox.Text += "0" + button.Text;
					currentValue = Double.Parse("0" + textBox.Text);
				}
			}
		}

		private void operatorButton_Click(object sender, EventArgs e) {
			Button button = (Button)sender;

			if(textBox.Text != "") {
				if(lastOperator != "") {
					switch(lastOperator) {
						case "+":
							prevValue += currentValue;
							break;
						case "-":
							prevValue -= currentValue;
							break;
						case "*":
							prevValue *= currentValue;
							break;
						case "÷":
							prevValue /= currentValue;
							break;
						case "%":
							prevValue %= currentValue;
							break;
					}
				} else prevValue = currentValue;
			}
			lastOperator = button.Text;
			previousOperationsLabel.Text = prevValue.ToString() + lastOperator;

			textBox.Text = "";
		}

		private void equalsButton_Click(object sender, EventArgs e) {
			Button button = (Button)sender;

			switch(lastOperator) {
				case "+":
					prevValue += currentValue;
					break;
				case "-":
					prevValue -= currentValue;
					break;
				case "*":
					prevValue *= currentValue;
					break;
				case "÷":
					prevValue /= currentValue;
					break;
				case "%":
					prevValue %= currentValue;
					break;
			}
			previousOperationsLabel.Text = prevValue.ToString();
			textBox.Text = "";
		}

		private void clearButton_Click(object sender, EventArgs e) {
			textBox.Text = "";
			currentValue = 0;
			prevValue = 0;
			previousOperationsLabel.Text = "0";
		}

		private void clearEntryButton_Click(object sender, EventArgs e) {
			textBox.Text = "";
		}

		private void plusMinusButton_Click(object sender, EventArgs e) {
			if(textBox.Text != "") {
				if(!isNegative) {
					textBox.Text = "-" + textBox.Text;
				} else {
					textBox.Text = textBox.Text.Substring(0);
				}
				currentValue = Double.Parse(textBox.Text);
				isNegative = !isNegative;
			}
		}
	}
}