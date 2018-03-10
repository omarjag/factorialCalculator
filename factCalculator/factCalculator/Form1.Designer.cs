namespace factCalculator
{
	partial class Form1
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
			this.enterLbl = new System.Windows.Forms.Label();
			this.resultLbl = new System.Windows.Forms.Label();
			this.enterTxtBox = new System.Windows.Forms.TextBox();
			this.resultTxtBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// enterLbl
			// 
			this.enterLbl.AutoSize = true;
			this.enterLbl.Location = new System.Drawing.Point(41, 58);
			this.enterLbl.Name = "enterLbl";
			this.enterLbl.Size = new System.Drawing.Size(72, 13);
			this.enterLbl.TabIndex = 0;
			this.enterLbl.Text = "Enter Number";
			// 
			// resultLbl
			// 
			this.resultLbl.AutoSize = true;
			this.resultLbl.Location = new System.Drawing.Point(88, 126);
			this.resultLbl.Name = "resultLbl";
			this.resultLbl.Size = new System.Drawing.Size(25, 13);
			this.resultLbl.TabIndex = 1;
			this.resultLbl.Text = "n! =";
			// 
			// enterTxtBox
			// 
			this.enterTxtBox.Location = new System.Drawing.Point(119, 55);
			this.enterTxtBox.Name = "enterTxtBox";
			this.enterTxtBox.Size = new System.Drawing.Size(127, 20);
			this.enterTxtBox.TabIndex = 2;
			this.enterTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// resultTxtBox
			// 
			this.resultTxtBox.Location = new System.Drawing.Point(119, 119);
			this.resultTxtBox.Name = "resultTxtBox";
			this.resultTxtBox.Size = new System.Drawing.Size(127, 20);
			this.resultTxtBox.TabIndex = 3;
			this.resultTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(183, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Calculate";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.button2;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.resultTxtBox);
			this.Controls.Add(this.enterTxtBox);
			this.Controls.Add(this.resultLbl);
			this.Controls.Add(this.enterLbl);
			this.Name = "Form1";
			this.Text = "Factorial Calculator n!";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label enterLbl;
		private System.Windows.Forms.Label resultLbl;
		private System.Windows.Forms.TextBox enterTxtBox;
		private System.Windows.Forms.TextBox resultTxtBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

