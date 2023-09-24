namespace Population_Calculator
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
            this.startPopSizeLabel = new System.Windows.Forms.Label();
            this.startPopSizeTextBox = new System.Windows.Forms.TextBox();
            this.yearlyIncreaseLabel = new System.Windows.Forms.Label();
            this.yearlyIncreaseTextBox = new System.Windows.Forms.TextBox();
            this.numberofYearsLabel = new System.Windows.Forms.Label();
            this.numberofYearsTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startPopSizeLabel
            // 
            this.startPopSizeLabel.AutoSize = true;
            this.startPopSizeLabel.Location = new System.Drawing.Point(179, 74);
            this.startPopSizeLabel.Name = "startPopSizeLabel";
            this.startPopSizeLabel.Size = new System.Drawing.Size(175, 20);
            this.startPopSizeLabel.TabIndex = 0;
            this.startPopSizeLabel.Text = "Starting population size";
            // 
            // startPopSizeTextBox
            // 
            this.startPopSizeTextBox.Location = new System.Drawing.Point(404, 68);
            this.startPopSizeTextBox.Name = "startPopSizeTextBox";
            this.startPopSizeTextBox.Size = new System.Drawing.Size(100, 26);
            this.startPopSizeTextBox.TabIndex = 1;
            // 
            // yearlyIncreaseLabel
            // 
            this.yearlyIncreaseLabel.AutoSize = true;
            this.yearlyIncreaseLabel.Location = new System.Drawing.Point(179, 122);
            this.yearlyIncreaseLabel.Name = "yearlyIncreaseLabel";
            this.yearlyIncreaseLabel.Size = new System.Drawing.Size(117, 20);
            this.yearlyIncreaseLabel.TabIndex = 2;
            this.yearlyIncreaseLabel.Text = "Yearly increase";
            // 
            // yearlyIncreaseTextBox
            // 
            this.yearlyIncreaseTextBox.Location = new System.Drawing.Point(404, 122);
            this.yearlyIncreaseTextBox.Name = "yearlyIncreaseTextBox";
            this.yearlyIncreaseTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearlyIncreaseTextBox.TabIndex = 3;
            // 
            // numberofYearsLabel
            // 
            this.numberofYearsLabel.AutoSize = true;
            this.numberofYearsLabel.Location = new System.Drawing.Point(179, 171);
            this.numberofYearsLabel.Name = "numberofYearsLabel";
            this.numberofYearsLabel.Size = new System.Drawing.Size(125, 20);
            this.numberofYearsLabel.TabIndex = 4;
            this.numberofYearsLabel.Text = "Number of years";
            // 
            // numberofYearsTextBox
            // 
            this.numberofYearsTextBox.Location = new System.Drawing.Point(404, 168);
            this.numberofYearsTextBox.Name = "numberofYearsTextBox";
            this.numberofYearsTextBox.Size = new System.Drawing.Size(100, 26);
            this.numberofYearsTextBox.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(183, 220);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 164);
            this.listBox1.TabIndex = 6;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(229, 403);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 35);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(404, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numberofYearsTextBox);
            this.Controls.Add(this.numberofYearsLabel);
            this.Controls.Add(this.yearlyIncreaseTextBox);
            this.Controls.Add(this.yearlyIncreaseLabel);
            this.Controls.Add(this.startPopSizeTextBox);
            this.Controls.Add(this.startPopSizeLabel);
            this.Name = "Form1";
            this.Text = "Population Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startPopSizeLabel;
        private System.Windows.Forms.TextBox startPopSizeTextBox;
        private System.Windows.Forms.Label yearlyIncreaseLabel;
        private System.Windows.Forms.TextBox yearlyIncreaseTextBox;
        private System.Windows.Forms.Label numberofYearsLabel;
        private System.Windows.Forms.TextBox numberofYearsTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

