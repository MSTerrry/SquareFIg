
namespace Square
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.AddPointButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputPoint = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PointNumber = new System.Windows.Forms.Label();
            this.RemovePointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(222, 112);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 34);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(222, 72);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(125, 34);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // AddPointButton
            // 
            this.AddPointButton.Location = new System.Drawing.Point(222, 152);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(125, 34);
            this.AddPointButton.TabIndex = 2;
            this.AddPointButton.Text = "Add point";
            this.AddPointButton.UseVisualStyleBackColor = true;
            this.AddPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(25, 7);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(85, 20);
            this.InputLabel.TabIndex = 4;
            this.InputLabel.Text = "Input point";
            // 
            // InputPoint
            // 
            this.InputPoint.Location = new System.Drawing.Point(29, 30);
            this.InputPoint.Name = "InputPoint";
            this.InputPoint.Size = new System.Drawing.Size(150, 26);
            this.InputPoint.TabIndex = 5;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(222, 30);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(164, 26);
            this.ResultTextbox.TabIndex = 6;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(218, 7);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(55, 20);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result";
            // 
            // PointNumber
            // 
            this.PointNumber.AutoSize = true;
            this.PointNumber.Location = new System.Drawing.Point(1, 33);
            this.PointNumber.Name = "PointNumber";
            this.PointNumber.Size = new System.Drawing.Size(22, 20);
            this.PointNumber.TabIndex = 8;
            this.PointNumber.Text = "1.";
            // 
            // RemovePointButton
            // 
            this.RemovePointButton.Location = new System.Drawing.Point(222, 192);
            this.RemovePointButton.Name = "RemovePointButton";
            this.RemovePointButton.Size = new System.Drawing.Size(125, 34);
            this.RemovePointButton.TabIndex = 9;
            this.RemovePointButton.Text = "Remove Point";
            this.RemovePointButton.UseVisualStyleBackColor = true;
            this.RemovePointButton.Click += new System.EventHandler(this.RemovePointButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 359);
            this.Controls.Add(this.RemovePointButton);
            this.Controls.Add(this.PointNumber);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.InputPoint);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.AddPointButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ClearButton);
            this.Name = "Form1";
            this.Text = "SquareCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button AddPointButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox InputPoint;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label PointNumber;
        private System.Windows.Forms.Button RemovePointButton;
    }
}

