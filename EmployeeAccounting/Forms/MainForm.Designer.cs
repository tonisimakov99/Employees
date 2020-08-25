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
            this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
            this.EmployeesDataGrid.RowContextMenuStripNeeded += GridContextMenuCall;

            this.dismissToolStripMenuItem.Click += Dissmiss;
            this.recruiteToolStripMenuItem.Click += Recruite;

            this.SaveToXMLButton.Click += SaveToXMLButtonClick;
            this.OpenFromXMLButton.Click += OpenFromXMLButtonClick;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 513);
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
    }
}