namespace XMLData
{
    partial class XMLDataForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ToppingComboBox = new System.Windows.Forms.ComboBox();
            this.CandyNameTextBox = new System.Windows.Forms.TextBox();
            this.MassNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomizeButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.CandyNameLabel = new System.Windows.Forms.Label();
            this.SugarLabel = new System.Windows.Forms.Label();
            this.ToppingLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ClearAllbutton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SugarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MassLabel = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MassNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Caramel",
            "ChocoCandy",
            "Grilling",
            "NutCandy",
            "Waffles"});
            this.TypeComboBox.Location = new System.Drawing.Point(78, 25);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(123, 21);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.Text = "Caramel";
            // 
            // ToppingComboBox
            // 
            this.ToppingComboBox.FormattingEnabled = true;
            this.ToppingComboBox.Items.AddRange(new object[] {
            "Chocolate",
            "Jam",
            "Fruity",
            "Likert",
            "Marmalade"});
            this.ToppingComboBox.Location = new System.Drawing.Point(78, 79);
            this.ToppingComboBox.Name = "ToppingComboBox";
            this.ToppingComboBox.Size = new System.Drawing.Size(123, 21);
            this.ToppingComboBox.TabIndex = 0;
            this.ToppingComboBox.Text = "Chocolate";
            // 
            // CandyNameTextBox
            // 
            this.CandyNameTextBox.Location = new System.Drawing.Point(78, 52);
            this.CandyNameTextBox.Name = "CandyNameTextBox";
            this.CandyNameTextBox.Size = new System.Drawing.Size(123, 20);
            this.CandyNameTextBox.TabIndex = 1;
            // 
            // MassNumericUpDown
            // 
            this.MassNumericUpDown.Location = new System.Drawing.Point(78, 135);
            this.MassNumericUpDown.Name = "MassNumericUpDown";
            this.MassNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.MassNumericUpDown.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(78, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomizeButton
            // 
            this.CustomizeButton.Location = new System.Drawing.Point(78, 205);
            this.CustomizeButton.Name = "CustomizeButton";
            this.CustomizeButton.Size = new System.Drawing.Size(123, 23);
            this.CustomizeButton.TabIndex = 3;
            this.CustomizeButton.Text = "Customize";
            this.CustomizeButton.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(4, 28);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type";
            this.TypeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CandyNameLabel
            // 
            this.CandyNameLabel.AutoSize = true;
            this.CandyNameLabel.Location = new System.Drawing.Point(4, 55);
            this.CandyNameLabel.Name = "CandyNameLabel";
            this.CandyNameLabel.Size = new System.Drawing.Size(68, 13);
            this.CandyNameLabel.TabIndex = 4;
            this.CandyNameLabel.Text = "Candy Name";
            this.CandyNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SugarLabel
            // 
            this.SugarLabel.AutoSize = true;
            this.SugarLabel.Location = new System.Drawing.Point(4, 109);
            this.SugarLabel.Name = "SugarLabel";
            this.SugarLabel.Size = new System.Drawing.Size(47, 13);
            this.SugarLabel.TabIndex = 4;
            this.SugarLabel.Text = "Sugar, g";
            this.SugarLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToppingLabel
            // 
            this.ToppingLabel.AutoSize = true;
            this.ToppingLabel.Location = new System.Drawing.Point(4, 82);
            this.ToppingLabel.Name = "ToppingLabel";
            this.ToppingLabel.Size = new System.Drawing.Size(46, 13);
            this.ToppingLabel.TabIndex = 4;
            this.ToppingLabel.Text = "Topping";
            this.ToppingLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(78, 234);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(78, 263);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save XML";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(78, 292);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(123, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load XML";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // ClearAllbutton
            // 
            this.ClearAllbutton.Location = new System.Drawing.Point(78, 321);
            this.ClearAllbutton.Name = "ClearAllbutton";
            this.ClearAllbutton.Size = new System.Drawing.Size(123, 23);
            this.ClearAllbutton.TabIndex = 3;
            this.ClearAllbutton.Text = "Clear All";
            this.ClearAllbutton.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.CandyName,
            this.Topping,
            this.Sugar,
            this.Mass});
            this.DataGridView.Location = new System.Drawing.Point(222, 25);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(544, 319);
            this.DataGridView.TabIndex = 5;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // SugarNumericUpDown
            // 
            this.SugarNumericUpDown.Location = new System.Drawing.Point(78, 107);
            this.SugarNumericUpDown.Name = "SugarNumericUpDown";
            this.SugarNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.SugarNumericUpDown.TabIndex = 6;
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(4, 137);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(44, 13);
            this.MassLabel.TabIndex = 7;
            this.MassLabel.Text = "Mass, g";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // CandyName
            // 
            this.CandyName.HeaderText = "Candy Name";
            this.CandyName.Name = "CandyName";
            this.CandyName.ReadOnly = true;
            // 
            // Topping
            // 
            this.Topping.HeaderText = "Topping";
            this.Topping.Name = "Topping";
            this.Topping.ReadOnly = true;
            // 
            // Sugar
            // 
            this.Sugar.HeaderText = "Sugar, g";
            this.Sugar.Name = "Sugar";
            this.Sugar.ReadOnly = true;
            // 
            // Mass
            // 
            this.Mass.HeaderText = "Mass, g";
            this.Mass.Name = "Mass";
            this.Mass.ReadOnly = true;
            // 
            // XMLDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 361);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.SugarNumericUpDown);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.SugarLabel);
            this.Controls.Add(this.ToppingLabel);
            this.Controls.Add(this.CandyNameLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ClearAllbutton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CustomizeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MassNumericUpDown);
            this.Controls.Add(this.CandyNameTextBox);
            this.Controls.Add(this.ToppingComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "XMLDataForm";
            this.Text = "Candy Gift";
            this.Load += new System.EventHandler(this.XMLDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MassNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox ToppingComboBox;
        private System.Windows.Forms.TextBox CandyNameTextBox;
        private System.Windows.Forms.NumericUpDown MassNumericUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CustomizeButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label CandyNameLabel;
        private System.Windows.Forms.Label SugarLabel;
        private System.Windows.Forms.Label ToppingLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ClearAllbutton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.NumericUpDown SugarNumericUpDown;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mass;
    }
}

