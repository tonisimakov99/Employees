using System.Windows.Forms;
namespace EmployeeAccounting
{
    partial class AddNewEmployeeForm
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
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameInput = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositionInput = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(102, 42);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(200, 20);
            this.NameInput.TabIndex = 0;
            this.NameInput.TextChanged += new System.EventHandler(this.NameChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 42);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(11, 12);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Surname";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(101, 12);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(200, 20);
            this.SurnameInput.TabIndex = 2;
            this.SurnameInput.TextChanged += new System.EventHandler(this.SurnameChanged);
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(11, 71);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(66, 13);
            this.MiddleNameLabel.TabIndex = 5;
            this.MiddleNameLabel.Text = "MiddleName";
            // 
            // MiddleNameInput
            // 
            this.MiddleNameInput.Location = new System.Drawing.Point(102, 71);
            this.MiddleNameInput.Name = "MiddleNameInput";
            this.MiddleNameInput.Size = new System.Drawing.Size(200, 20);
            this.MiddleNameInput.TabIndex = 4;
            this.MiddleNameInput.TextChanged += new System.EventHandler(this.PatronymicChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(11, 100);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 7;
            this.PositionLabel.Text = "Position";
            // 
            // PositionInput
            // 
            this.PositionInput.Location = new System.Drawing.Point(101, 100);
            this.PositionInput.Name = "PositionInput";
            this.PositionInput.Size = new System.Drawing.Size(200, 20);
            this.PositionInput.TabIndex = 6;
            this.PositionInput.TextChanged += new System.EventHandler(this.PositionChanged);
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.Location = new System.Drawing.Point(227, 156);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salary";
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(102, 130);
            this.SalaryNumericUpDown.Maximum = decimal.MaxValue;
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.SalaryNumericUpDown.TabIndex = 15;
            this.SalaryNumericUpDown.ValueChanged += new System.EventHandler(this.SalaryNumericUpDownValueChanged);
            // 
            // AddNewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 191);
            this.Controls.Add(this.SalaryNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.PositionInput);
            this.Controls.Add(this.MiddleNameLabel);
            this.Controls.Add(this.MiddleNameInput);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SurnameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameInput);
            this.MaximumSize = new System.Drawing.Size(330, 230);
            this.MinimumSize = new System.Drawing.Size(330, 230);
            this.Name = "AddNewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox MiddleNameInput;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox PositionInput;
        private System.Windows.Forms.Button Add;
        private Label label1;
        private NumericUpDown SalaryNumericUpDown;
    }
}