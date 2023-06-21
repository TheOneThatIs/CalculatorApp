namespace Calculator_App {
	partial class Calculator {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			textBox=new TextBox();
			moduloButton=new Button();
			clearEntryButton=new Button();
			divideButton=new Button();
			multiplyButton=new Button();
			subtractButton=new Button();
			equalsButton=new Button();
			sevenButton=new Button();
			eightButton=new Button();
			nineButton=new Button();
			sixButton=new Button();
			fiveButton=new Button();
			fourButton=new Button();
			threeButton=new Button();
			twoButton=new Button();
			oneButton=new Button();
			decimalButton=new Button();
			zeroButton=new Button();
			plusMinusButton=new Button();
			nameLabel=new Label();
			additionButton=new Button();
			clearButton=new Button();
			previousOperationsLabel=new Label();
			SuspendLayout();
			// 
			// textBox
			// 
			textBox.BackColor=SystemColors.ControlLight;
			textBox.BorderStyle=BorderStyle.FixedSingle;
			textBox.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			textBox.Location=new Point(11, 54);
			textBox.Name="textBox";
			textBox.Size=new Size(430, 45);
			textBox.TabIndex=0;
			textBox.TextAlign=HorizontalAlignment.Right;
			// 
			// moduloButton
			// 
			moduloButton.BackColor=SystemColors.ControlDark;
			moduloButton.FlatStyle=FlatStyle.Popup;
			moduloButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			moduloButton.ForeColor=SystemColors.ControlLightLight;
			moduloButton.Location=new Point(231, 107);
			moduloButton.Name="moduloButton";
			moduloButton.Size=new Size(100, 100);
			moduloButton.TabIndex=3;
			moduloButton.Text="%";
			moduloButton.UseVisualStyleBackColor=false;
			moduloButton.Click+=operatorButton_Click;
			// 
			// clearEntryButton
			// 
			clearEntryButton.BackColor=SystemColors.ControlDark;
			clearEntryButton.FlatStyle=FlatStyle.Popup;
			clearEntryButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			clearEntryButton.ForeColor=SystemColors.ControlLightLight;
			clearEntryButton.Location=new Point(11, 107);
			clearEntryButton.Margin=new Padding(10);
			clearEntryButton.Name="clearEntryButton";
			clearEntryButton.Size=new Size(100, 100);
			clearEntryButton.TabIndex=5;
			clearEntryButton.Text="CE";
			clearEntryButton.UseVisualStyleBackColor=false;
			clearEntryButton.Click+=clearEntryButton_Click;
			// 
			// divideButton
			// 
			divideButton.BackColor=SystemColors.ControlDark;
			divideButton.FlatAppearance.BorderColor=Color.FromArgb(255, 192, 255);
			divideButton.FlatStyle=FlatStyle.Popup;
			divideButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			divideButton.ForeColor=SystemColors.ControlLightLight;
			divideButton.Location=new Point(341, 107);
			divideButton.Name="divideButton";
			divideButton.Size=new Size(100, 100);
			divideButton.TabIndex=6;
			divideButton.Text="÷";
			divideButton.UseVisualStyleBackColor=false;
			divideButton.Click+=operatorButton_Click;
			// 
			// multiplyButton
			// 
			multiplyButton.BackColor=SystemColors.ControlDark;
			multiplyButton.FlatStyle=FlatStyle.Popup;
			multiplyButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			multiplyButton.ForeColor=SystemColors.ControlLightLight;
			multiplyButton.Location=new Point(341, 217);
			multiplyButton.Name="multiplyButton";
			multiplyButton.Size=new Size(100, 100);
			multiplyButton.TabIndex=7;
			multiplyButton.Text="*";
			multiplyButton.UseVisualStyleBackColor=false;
			multiplyButton.Click+=operatorButton_Click;
			// 
			// subtractButton
			// 
			subtractButton.BackColor=SystemColors.ControlDark;
			subtractButton.FlatStyle=FlatStyle.Popup;
			subtractButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			subtractButton.ForeColor=SystemColors.ControlLightLight;
			subtractButton.Location=new Point(341, 327);
			subtractButton.Name="subtractButton";
			subtractButton.Size=new Size(100, 100);
			subtractButton.TabIndex=9;
			subtractButton.Text="-";
			subtractButton.UseVisualStyleBackColor=false;
			subtractButton.Click+=operatorButton_Click;
			// 
			// equalsButton
			// 
			equalsButton.BackColor=SystemColors.ControlLight;
			equalsButton.FlatStyle=FlatStyle.Popup;
			equalsButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			equalsButton.ForeColor=SystemColors.ActiveCaption;
			equalsButton.Location=new Point(341, 547);
			equalsButton.Name="equalsButton";
			equalsButton.Size=new Size(100, 100);
			equalsButton.TabIndex=10;
			equalsButton.Text="=";
			equalsButton.UseVisualStyleBackColor=false;
			equalsButton.Click+=equalsButton_Click;
			// 
			// sevenButton
			// 
			sevenButton.BackColor=SystemColors.ControlLight;
			sevenButton.FlatStyle=FlatStyle.Popup;
			sevenButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			sevenButton.ForeColor=SystemColors.ActiveCaptionText;
			sevenButton.Location=new Point(11, 217);
			sevenButton.Margin=new Padding(10);
			sevenButton.Name="sevenButton";
			sevenButton.Size=new Size(100, 100);
			sevenButton.TabIndex=11;
			sevenButton.Text="7";
			sevenButton.UseVisualStyleBackColor=false;
			sevenButton.Click+=numberButton_Click;
			// 
			// eightButton
			// 
			eightButton.BackColor=SystemColors.ControlLight;
			eightButton.FlatStyle=FlatStyle.Popup;
			eightButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			eightButton.ForeColor=SystemColors.ActiveCaptionText;
			eightButton.Location=new Point(121, 217);
			eightButton.Margin=new Padding(10);
			eightButton.Name="eightButton";
			eightButton.Size=new Size(100, 100);
			eightButton.TabIndex=12;
			eightButton.Text="8";
			eightButton.UseVisualStyleBackColor=false;
			eightButton.Click+=numberButton_Click;
			// 
			// nineButton
			// 
			nineButton.BackColor=SystemColors.ControlLight;
			nineButton.FlatStyle=FlatStyle.Popup;
			nineButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			nineButton.ForeColor=SystemColors.ActiveCaptionText;
			nineButton.Location=new Point(231, 217);
			nineButton.Margin=new Padding(10);
			nineButton.Name="nineButton";
			nineButton.Size=new Size(100, 100);
			nineButton.TabIndex=13;
			nineButton.Text="9";
			nineButton.UseVisualStyleBackColor=false;
			nineButton.Click+=numberButton_Click;
			// 
			// sixButton
			// 
			sixButton.BackColor=SystemColors.ControlLight;
			sixButton.FlatStyle=FlatStyle.Popup;
			sixButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			sixButton.ForeColor=SystemColors.ActiveCaptionText;
			sixButton.Location=new Point(231, 327);
			sixButton.Margin=new Padding(10);
			sixButton.Name="sixButton";
			sixButton.Size=new Size(100, 100);
			sixButton.TabIndex=16;
			sixButton.Text="6";
			sixButton.UseVisualStyleBackColor=false;
			sixButton.Click+=numberButton_Click;
			// 
			// fiveButton
			// 
			fiveButton.BackColor=SystemColors.ControlLight;
			fiveButton.FlatStyle=FlatStyle.Popup;
			fiveButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			fiveButton.ForeColor=SystemColors.ActiveCaptionText;
			fiveButton.Location=new Point(121, 327);
			fiveButton.Margin=new Padding(10);
			fiveButton.Name="fiveButton";
			fiveButton.Size=new Size(100, 100);
			fiveButton.TabIndex=15;
			fiveButton.Text="5";
			fiveButton.UseVisualStyleBackColor=false;
			fiveButton.Click+=numberButton_Click;
			// 
			// fourButton
			// 
			fourButton.BackColor=SystemColors.ControlLight;
			fourButton.FlatStyle=FlatStyle.Popup;
			fourButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			fourButton.ForeColor=SystemColors.ActiveCaptionText;
			fourButton.Location=new Point(11, 327);
			fourButton.Margin=new Padding(10);
			fourButton.Name="fourButton";
			fourButton.Size=new Size(100, 100);
			fourButton.TabIndex=14;
			fourButton.Text="4";
			fourButton.UseVisualStyleBackColor=false;
			fourButton.Click+=numberButton_Click;
			// 
			// threeButton
			// 
			threeButton.BackColor=SystemColors.ControlLight;
			threeButton.FlatStyle=FlatStyle.Popup;
			threeButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			threeButton.ForeColor=SystemColors.ActiveCaptionText;
			threeButton.Location=new Point(231, 437);
			threeButton.Margin=new Padding(10);
			threeButton.Name="threeButton";
			threeButton.Size=new Size(100, 100);
			threeButton.TabIndex=19;
			threeButton.Text="3";
			threeButton.UseVisualStyleBackColor=false;
			threeButton.Click+=numberButton_Click;
			// 
			// twoButton
			// 
			twoButton.BackColor=SystemColors.ControlLight;
			twoButton.FlatStyle=FlatStyle.Popup;
			twoButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			twoButton.ForeColor=SystemColors.ActiveCaptionText;
			twoButton.Location=new Point(121, 437);
			twoButton.Margin=new Padding(10);
			twoButton.Name="twoButton";
			twoButton.Size=new Size(100, 100);
			twoButton.TabIndex=18;
			twoButton.Text="2";
			twoButton.UseVisualStyleBackColor=false;
			twoButton.Click+=numberButton_Click;
			// 
			// oneButton
			// 
			oneButton.BackColor=SystemColors.ControlLight;
			oneButton.FlatStyle=FlatStyle.Popup;
			oneButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			oneButton.ForeColor=SystemColors.ActiveCaptionText;
			oneButton.Location=new Point(11, 437);
			oneButton.Margin=new Padding(10);
			oneButton.Name="oneButton";
			oneButton.Size=new Size(100, 100);
			oneButton.TabIndex=17;
			oneButton.Text="1";
			oneButton.UseVisualStyleBackColor=false;
			oneButton.Click+=numberButton_Click;
			// 
			// decimalButton
			// 
			decimalButton.BackColor=SystemColors.ControlLight;
			decimalButton.FlatStyle=FlatStyle.Popup;
			decimalButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			decimalButton.ForeColor=SystemColors.ActiveCaptionText;
			decimalButton.Location=new Point(231, 547);
			decimalButton.Margin=new Padding(10);
			decimalButton.Name="decimalButton";
			decimalButton.Size=new Size(100, 100);
			decimalButton.TabIndex=22;
			decimalButton.Text=".";
			decimalButton.UseVisualStyleBackColor=false;
			decimalButton.Click+=numberButton_Click;
			// 
			// zeroButton
			// 
			zeroButton.BackColor=SystemColors.ControlLight;
			zeroButton.FlatStyle=FlatStyle.Popup;
			zeroButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			zeroButton.ForeColor=SystemColors.ActiveCaptionText;
			zeroButton.Location=new Point(121, 547);
			zeroButton.Margin=new Padding(10);
			zeroButton.Name="zeroButton";
			zeroButton.Size=new Size(100, 100);
			zeroButton.TabIndex=21;
			zeroButton.Text="0";
			zeroButton.UseVisualStyleBackColor=false;
			zeroButton.Click+=numberButton_Click;
			// 
			// plusMinusButton
			// 
			plusMinusButton.BackColor=SystemColors.ControlLight;
			plusMinusButton.FlatStyle=FlatStyle.Popup;
			plusMinusButton.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			plusMinusButton.ForeColor=SystemColors.ActiveCaptionText;
			plusMinusButton.Location=new Point(11, 547);
			plusMinusButton.Margin=new Padding(10);
			plusMinusButton.Name="plusMinusButton";
			plusMinusButton.Size=new Size(100, 100);
			plusMinusButton.TabIndex=20;
			plusMinusButton.Text="+/-";
			plusMinusButton.UseVisualStyleBackColor=false;
			plusMinusButton.Click+=plusMinusButton_Click;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize=true;
			nameLabel.BackColor=SystemColors.WindowFrame;
			nameLabel.FlatStyle=FlatStyle.Flat;
			nameLabel.Font=new Font("Segoe Script", 14F, FontStyle.Regular, GraphicsUnit.Point);
			nameLabel.ForeColor=SystemColors.ActiveCaption;
			nameLabel.Location=new Point(1, 692);
			nameLabel.Name="nameLabel";
			nameLabel.Size=new Size(450, 44);
			nameLabel.TabIndex=23;
			nameLabel.Text="The Calculator-inator 9000!";
			// 
			// additionButton
			// 
			additionButton.BackColor=SystemColors.ControlDark;
			additionButton.FlatStyle=FlatStyle.Popup;
			additionButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			additionButton.ForeColor=SystemColors.ControlLightLight;
			additionButton.Location=new Point(341, 437);
			additionButton.Name="additionButton";
			additionButton.Size=new Size(100, 100);
			additionButton.TabIndex=8;
			additionButton.Text="+";
			additionButton.UseVisualStyleBackColor=false;
			additionButton.Click+=operatorButton_Click;
			// 
			// clearButton
			// 
			clearButton.BackColor=SystemColors.ControlDark;
			clearButton.FlatStyle=FlatStyle.Popup;
			clearButton.Font=new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			clearButton.ForeColor=SystemColors.ControlLightLight;
			clearButton.Location=new Point(121, 107);
			clearButton.Name="clearButton";
			clearButton.Size=new Size(100, 100);
			clearButton.TabIndex=1;
			clearButton.Text="C";
			clearButton.UseVisualStyleBackColor=false;
			clearButton.Click+=clearButton_Click;
			// 
			// previousOperationsLabel
			// 
			previousOperationsLabel.AutoSize=true;
			previousOperationsLabel.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
			previousOperationsLabel.Location=new Point(12, 9);
			previousOperationsLabel.Name="previousOperationsLabel";
			previousOperationsLabel.Size=new Size(0, 38);
			previousOperationsLabel.TabIndex=24;
			// 
			// Calculator
			// 
			AcceptButton=equalsButton;
			AutoScaleDimensions=new SizeF(10F, 25F);
			AutoScaleMode=AutoScaleMode.Font;
			BackColor=SystemColors.WindowFrame;
			CancelButton=clearEntryButton;
			ClientSize=new Size(451, 765);
			Controls.Add(previousOperationsLabel);
			Controls.Add(nameLabel);
			Controls.Add(decimalButton);
			Controls.Add(zeroButton);
			Controls.Add(plusMinusButton);
			Controls.Add(threeButton);
			Controls.Add(twoButton);
			Controls.Add(oneButton);
			Controls.Add(sixButton);
			Controls.Add(fiveButton);
			Controls.Add(fourButton);
			Controls.Add(nineButton);
			Controls.Add(eightButton);
			Controls.Add(sevenButton);
			Controls.Add(equalsButton);
			Controls.Add(subtractButton);
			Controls.Add(additionButton);
			Controls.Add(multiplyButton);
			Controls.Add(divideButton);
			Controls.Add(clearEntryButton);
			Controls.Add(moduloButton);
			Controls.Add(clearButton);
			Controls.Add(textBox);
			FormBorderStyle=FormBorderStyle.FixedDialog;
			MaximizeBox=false;
			Name="Calculator";
			StartPosition=FormStartPosition.CenterScreen;
			Text="Calculator";
			Load+=Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox;
		private Button moduloButton;
		private Button clearEntryButton;
		private Button divideButton;
		private Button multiplyButton;
		private Button subtractButton;
		private Button equalsButton;
		private Button sevenButton;
		private Button eightButton;
		private Button nineButton;
		private Button sixButton;
		private Button fiveButton;
		private Button fourButton;
		private Button threeButton;
		private Button twoButton;
		private Button oneButton;
		private Button decimalButton;
		private Button zeroButton;
		private Button plusMinusButton;
		private Label nameLabel;
		private Button additionButton;
		private Button clearButton;
		private Label previousOperationsLabel;
	}
}