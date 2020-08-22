namespace Employee
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.SaveToXML = new System.Windows.Forms.Button();
            this.AddNewEmployee = new System.Windows.Forms.Button();
            this.SearchInputStr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dismissToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RowContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.EmployeesDataGrid.MultiSelect = false;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.Size = new System.Drawing.Size(772, 422);
            this.EmployeesDataGrid.TabIndex = 0;
            this.EmployeesDataGrid.ContextMenuStrip = RowContextMenu;
            this.EmployeesDataGrid.DataSource = data.GetAllEmployees();
            this.EmployeesDataGrid.CellContextMenuStripNeeded += SelectEmployee;
            // 
            // SaveToXML
            // 
            this.SaveToXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveToXML.Location = new System.Drawing.Point(588, 452);
            this.SaveToXML.Name = "SaveToXML";
            this.SaveToXML.Size = new System.Drawing.Size(95, 25);
            this.SaveToXML.TabIndex = 1;
            this.SaveToXML.Text = "Open from XML";
            this.SaveToXML.UseVisualStyleBackColor = true;
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewEmployee.Location = new System.Drawing.Point(12, 450);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.Size = new System.Drawing.Size(110, 25);
            this.AddNewEmployee.TabIndex = 2;
            this.AddNewEmployee.Text = "Add new employee";
            this.AddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // SearchInputStr
            // 
            this.SearchInputStr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchInputStr.Location = new System.Drawing.Point(12, 481);
            this.SearchInputStr.Name = "SearchInputStr";
            this.SearchInputStr.Size = new System.Drawing.Size(172, 20);
            this.SearchInputStr.TabIndex = 3;
            this.SearchInputStr.TextChanged += ShowSearchResult;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Employee.Properties.Resources.magnifier;
            this.pictureBox1.Location = new System.Drawing.Point(192, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(689, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save to XML";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dismissToolStripMenuItem.Click += Dismiss;
            // 
            // recruiteToolStripMenuItem
            // 
            this.recruiteToolStripMenuItem.Name = "recruiteToolStripMenuItem";
            this.recruiteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.recruiteToolStripMenuItem.Text = "Recruite";
            this.recruiteToolStripMenuItem.Click += Recruite;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchInputStr);
            this.Controls.Add(this.AddNewEmployee);
            this.Controls.Add(this.SaveToXML);
            this.Controls.Add(this.EmployeesDataGrid);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RowContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.Button SaveToXML;
        private System.Windows.Forms.Button AddNewEmployee;
        private System.Windows.Forms.TextBox SearchInputStr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip RowContextMenu;
        private System.Windows.Forms.ToolStripMenuItem dismissToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruiteToolStripMenuItem;
    }
}