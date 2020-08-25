using System.Windows.Forms;

namespace EmployeeAccounting
{
    partial class MainForm
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

        private void CustomInitializeComponent()
        {
            //this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
            this.EmployeesDataGrid.RowContextMenuStripNeeded += GridContextMenuCall;

            this.dismissToolStripMenuItem.Click += DismissMenuItemClick;
            this.recruiteToolStripMenuItem.Click += RecruiteMenuItemClick;

            this.SaveToXMLButton.Click += SaveToXmlButtonClick;
            this.OpenFromXMLButton.Click += OpenFromXmlButtonClick;
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.RowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dismissToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFromXMLButton = new System.Windows.Forms.Button();
            this.AddNewEmployeeButton = new System.Windows.Forms.Button();
            this.SearchInputStr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveToXMLButton = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dismissalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DismissedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.RowContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AllowUserToDeleteRows = false;
            this.EmployeesDataGrid.AllowUserToResizeColumns = false;
            this.EmployeesDataGrid.AllowUserToResizeRows = false;
            this.EmployeesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.ContextMenuStrip = this.RowContextMenu;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.EmployeesDataGrid.MultiSelect = false;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            this.EmployeesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.EmployeesDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(772, 434);
            this.EmployeesDataGrid.TabIndex = 0;
            // 
            // RowContextMenu
            // 
            this.RowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dismissToolStripMenuItem,
            this.recruiteToolStripMenuItem});
            this.RowContextMenu.Name = "RowContextMenu";
            this.RowContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // dismissToolStripMenuItem
            // 
            this.dismissToolStripMenuItem.Name = "dismissToolStripMenuItem";
            this.dismissToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dismissToolStripMenuItem.Text = "Dismiss";
            // 
            // recruiteToolStripMenuItem
            // 
            this.recruiteToolStripMenuItem.Name = "recruiteToolStripMenuItem";
            this.recruiteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.recruiteToolStripMenuItem.Text = "Recruite";
            // 
            // OpenFromXMLButton
            // 
            this.OpenFromXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFromXMLButton.Location = new System.Drawing.Point(588, 452);
            this.OpenFromXMLButton.Name = "OpenFromXMLButton";
            this.OpenFromXMLButton.Size = new System.Drawing.Size(95, 25);
            this.OpenFromXMLButton.TabIndex = 1;
            this.OpenFromXMLButton.Text = "Open from XML";
            this.OpenFromXMLButton.UseVisualStyleBackColor = true;
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(12, 450);
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(110, 25);
            this.AddNewEmployeeButton.TabIndex = 2;
            this.AddNewEmployeeButton.Text = "Add new employee";
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButtonClick);
            // 
            // SearchInputStr
            // 
            this.SearchInputStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchInputStr.Location = new System.Drawing.Point(12, 481);
            this.SearchInputStr.Name = "SearchInputStr";
            this.SearchInputStr.Size = new System.Drawing.Size(172, 20);
            this.SearchInputStr.TabIndex = 3;
            this.SearchInputStr.TextChanged += new System.EventHandler(this.SearchInputStrTextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::EmployeeAccounting.Properties.Resources.magnifier;
            this.pictureBox1.Location = new System.Drawing.Point(192, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SaveToXMLButton
            // 
            this.SaveToXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToXMLButton.Location = new System.Drawing.Point(689, 452);
            this.SaveToXMLButton.Name = "SaveToXMLButton";
            this.SaveToXMLButton.Size = new System.Drawing.Size(95, 25);
            this.SaveToXMLButton.TabIndex = 5;
            this.SaveToXMLButton.Text = "Save to XML";
            this.SaveToXMLButton.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // employmentDateDataGridViewTextBoxColumn
            // 
            this.employmentDateDataGridViewTextBoxColumn.Name = "employmentDateDataGridViewTextBoxColumn";
            // 
            // dismissalDateDataGridViewTextBoxColumn
            // 
            this.dismissalDateDataGridViewTextBoxColumn.Name = "dismissalDateDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total";
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(284, 453);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalLabel.TabIndex = 7;
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Location = new System.Drawing.Point(284, 466);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentLabel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current";
            // 
            // DismissedLabel
            // 
            this.DismissedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DismissedLabel.AutoSize = true;
            this.DismissedLabel.Location = new System.Drawing.Point(283, 479);
            this.DismissedLabel.Name = "DismissedLabel";
            this.DismissedLabel.Size = new System.Drawing.Size(0, 13);
            this.DismissedLabel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dismissed";
            // 
            // MaxLabel
            // 
            this.MaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(387, 453);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(0, 13);
            this.MaxLabel.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Max";
            // 
            // AverageLabel
            // 
            this.AverageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(387, 467);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(0, 13);
            this.AverageLabel.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Average";
            // 
            // MinLabel
            // 
            this.MinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(387, 479);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(0, 13);
            this.MinLabel.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(345, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Min";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DismissedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveToXMLButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchInputStr);
            this.Controls.Add(this.AddNewEmployeeButton);
            this.Controls.Add(this.OpenFromXMLButton);
            this.Controls.Add(this.EmployeesDataGrid);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.RowContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.Button OpenFromXMLButton;
        private System.Windows.Forms.Button AddNewEmployeeButton;
        private System.Windows.Forms.TextBox SearchInputStr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SaveToXMLButton;
        private System.Windows.Forms.ContextMenuStrip RowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem dismissToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruiteToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dismissalDateDataGridViewTextBoxColumn;
        private Label label1;
        private Label TotalLabel;
        private Label CurrentLabel;
        private Label label4;
        private Label DismissedLabel;
        private Label label6;
        private Label MaxLabel;
        private Label label8;
        private Label AverageLabel;
        private Label label10;
        private Label MinLabel;
        private Label label12;
    }
}