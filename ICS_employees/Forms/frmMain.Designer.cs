namespace ICS_employees.Forms
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.Position_txtBox = new System.Windows.Forms.TextBox();
            this.Name_txtBox = new System.Windows.Forms.TextBox();
            this.Surname_txtBox = new System.Windows.Forms.TextBox();
            this.Salary_txtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Birthday_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.Filter_txtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.txtName,
            this.Surname,
            this.Position,
            this.YearOfBirth,
            this.Salary});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(9, 64);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidth = 52;
            this.dataGridView.RowTemplate.Height = 50;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(802, 421);
            this.dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.HeaderText = "Name";
            this.txtName.MinimumWidth = 8;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 8;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 8;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.HeaderText = "Year of birth";
            this.YearOfBirth.MinimumWidth = 8;
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary($)";
            this.Salary.MinimumWidth = 8;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.Position_txtBox);
            this.panel1.Controls.Add(this.Name_txtBox);
            this.panel1.Controls.Add(this.Surname_txtBox);
            this.panel1.Controls.Add(this.Salary_txtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Birthday_txtBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(803, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 683);
            this.panel1.TabIndex = 1;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(28, 497);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.AutoRoundedCorners = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 24;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.DisabledState.Parent = this.AddButton;
            this.AddButton.FillColor = System.Drawing.Color.Blue;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Location = new System.Drawing.Point(33, 402);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.BorderRadius = 26;
            this.AddButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.AddButton.ShadowDecoration.Enabled = true;
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(118, 51);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Position_txtBox
            // 
            this.Position_txtBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Position_txtBox.Location = new System.Drawing.Point(194, 222);
            this.Position_txtBox.Multiline = true;
            this.Position_txtBox.Name = "Position_txtBox";
            this.Position_txtBox.Size = new System.Drawing.Size(284, 36);
            this.Position_txtBox.TabIndex = 12;
            // 
            // Name_txtBox
            // 
            this.Name_txtBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_txtBox.Location = new System.Drawing.Point(194, 102);
            this.Name_txtBox.Multiline = true;
            this.Name_txtBox.Name = "Name_txtBox";
            this.Name_txtBox.Size = new System.Drawing.Size(284, 36);
            this.Name_txtBox.TabIndex = 11;
            // 
            // Surname_txtBox
            // 
            this.Surname_txtBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname_txtBox.Location = new System.Drawing.Point(194, 162);
            this.Surname_txtBox.Multiline = true;
            this.Surname_txtBox.Name = "Surname_txtBox";
            this.Surname_txtBox.Size = new System.Drawing.Size(284, 36);
            this.Surname_txtBox.TabIndex = 10;
            // 
            // Salary_txtBox
            // 
            this.Salary_txtBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary_txtBox.Location = new System.Drawing.Point(194, 342);
            this.Salary_txtBox.Multiline = true;
            this.Salary_txtBox.Name = "Salary_txtBox";
            this.Salary_txtBox.Size = new System.Drawing.Size(284, 36);
            this.Salary_txtBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(28, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Salary:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(28, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surame:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(28, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add an employee";
            // 
            // Birthday_txtBox
            // 
            this.Birthday_txtBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday_txtBox.Location = new System.Drawing.Point(194, 282);
            this.Birthday_txtBox.Multiline = true;
            this.Birthday_txtBox.Name = "Birthday_txtBox";
            this.Birthday_txtBox.Size = new System.Drawing.Size(284, 36);
            this.Birthday_txtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees: ";
            // 
            // ReportButton
            // 
            this.ReportButton.AutoRoundedCorners = true;
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.BorderRadius = 24;
            this.ReportButton.CheckedState.Parent = this.ReportButton;
            this.ReportButton.CustomImages.Parent = this.ReportButton;
            this.ReportButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportButton.DisabledState.Parent = this.ReportButton;
            this.ReportButton.FillColor = System.Drawing.Color.Blue;
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.HoverState.Parent = this.ReportButton;
            this.ReportButton.Location = new System.Drawing.Point(9, 620);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.ShadowDecoration.BorderRadius = 26;
            this.ReportButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ReportButton.ShadowDecoration.Enabled = true;
            this.ReportButton.ShadowDecoration.Parent = this.ReportButton;
            this.ReportButton.Size = new System.Drawing.Size(118, 51);
            this.ReportButton.TabIndex = 13;
            this.ReportButton.Text = "Report";
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Man.png");
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoRoundedCorners = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderRadius = 24;
            this.DeleteButton.CheckedState.Parent = this.DeleteButton;
            this.DeleteButton.CustomImages.Parent = this.DeleteButton;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.DisabledState.Parent = this.DeleteButton;
            this.DeleteButton.FillColor = System.Drawing.Color.Blue;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HoverState.Parent = this.DeleteButton;
            this.DeleteButton.Location = new System.Drawing.Point(146, 620);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShadowDecoration.BorderRadius = 26;
            this.DeleteButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.DeleteButton.ShadowDecoration.Enabled = true;
            this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
            this.DeleteButton.Size = new System.Drawing.Size(118, 51);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Filter_txtBox
            // 
            this.Filter_txtBox.BorderColor = System.Drawing.Color.DarkMagenta;
            this.Filter_txtBox.BorderRadius = 15;
            this.Filter_txtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Filter_txtBox.DefaultText = "Filter by position";
            this.Filter_txtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Filter_txtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Filter_txtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Filter_txtBox.DisabledState.Parent = this.Filter_txtBox;
            this.Filter_txtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Filter_txtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.Filter_txtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_txtBox.FocusedState.Parent = this.Filter_txtBox;
            this.Filter_txtBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_txtBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Filter_txtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_txtBox.HoverState.Parent = this.Filter_txtBox;
            this.Filter_txtBox.Location = new System.Drawing.Point(568, 12);
            this.Filter_txtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Filter_txtBox.Name = "Filter_txtBox";
            this.Filter_txtBox.PasswordChar = '\0';
            this.Filter_txtBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.Filter_txtBox.PlaceholderText = "";
            this.Filter_txtBox.SelectedText = "";
            this.Filter_txtBox.SelectionStart = 18;
            this.Filter_txtBox.ShadowDecoration.Parent = this.Filter_txtBox;
            this.Filter_txtBox.Size = new System.Drawing.Size(217, 40);
            this.Filter_txtBox.TabIndex = 15;
            this.Filter_txtBox.TextChanged += new System.EventHandler(this.Filter_txtBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.CustomImages.Parent = this.SearchButton;
            this.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchButton.DisabledState.Parent = this.SearchButton;
            this.SearchButton.FillColor = System.Drawing.Color.Magenta;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.HoverState.Parent = this.SearchButton;
            this.SearchButton.Image = global::ICS_employees.Properties.Resources.lupa7_removebg_preview;
            this.SearchButton.Location = new System.Drawing.Point(517, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SearchButton.ShadowDecoration.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(44, 44);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(59)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1300, 683);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Filter_txtBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Position_txtBox;
        private System.Windows.Forms.TextBox Name_txtBox;
        private System.Windows.Forms.TextBox Surname_txtBox;
        private System.Windows.Forms.TextBox Salary_txtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Birthday_txtBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label ErrorLabel;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private Guna.UI2.WinForms.Guna2TextBox Filter_txtBox;
        private Guna.UI2.WinForms.Guna2CircleButton SearchButton;
    }
}