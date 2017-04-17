namespace Demostration
{
    partial class DemostrationForm
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
            this.SugarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ClearAllbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SugarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.ToppingComboBox.Location = new System.Drawing.Point(78, 104);
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
            // SugarNumericUpDown
            // 
            this.SugarNumericUpDown.Location = new System.Drawing.Point(78, 78);
            this.SugarNumericUpDown.Name = "SugarNumericUpDown";
            this.SugarNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.SugarNumericUpDown.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(78, 140);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomizeButton
            // 
            this.CustomizeButton.Location = new System.Drawing.Point(78, 169);
            this.CustomizeButton.Name = "CustomizeButton";
            this.CustomizeButton.Size = new System.Drawing.Size(123, 23);
            this.CustomizeButton.TabIndex = 3;
            this.CustomizeButton.Text = "Customize";
            this.CustomizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Candy Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sugar, g";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Topping";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(78, 198);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(78, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save XML";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(78, 256);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(123, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load XML";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // ClearAllbutton
            // 
            this.ClearAllbutton.Location = new System.Drawing.Point(78, 285);
            this.ClearAllbutton.Name = "ClearAllbutton";
            this.ClearAllbutton.Size = new System.Drawing.Size(123, 23);
            this.ClearAllbutton.TabIndex = 3;
            this.ClearAllbutton.Text = "Clear All";
            this.ClearAllbutton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.CandyName,
            this.Sugar,
            this.Topping});
            this.dataGridView1.Location = new System.Drawing.Point(222, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 283);
            this.dataGridView1.TabIndex = 5;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // CandyName
            // 
            this.CandyName.HeaderText = "Candy Name";
            this.CandyName.Name = "CandyName";
            // 
            // Sugar
            // 
            this.Sugar.HeaderText = "Sugar, g";
            this.Sugar.Name = "Sugar";
            // 
            // Topping
            // 
            this.Topping.HeaderText = "Topping";
            this.Topping.Name = "Topping";
            // 
            // DemostrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAllbutton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CustomizeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SugarNumericUpDown);
            this.Controls.Add(this.CandyNameTextBox);
            this.Controls.Add(this.ToppingComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "DemostrationForm";
            this.Text = "Candy Gift";
            ((System.ComponentModel.ISupportInitialize)(this.SugarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.ComboBox ToppingComboBox;
        private System.Windows.Forms.TextBox CandyNameTextBox;
        private System.Windows.Forms.NumericUpDown SugarNumericUpDown;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CustomizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ClearAllbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topping;
    }
}

