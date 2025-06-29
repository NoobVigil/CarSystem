namespace CarSystem
{
    partial class GoodsWindow
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            DeleteButton_Click = new Guna.UI2.WinForms.Guna2Button();
            Update = new Guna.UI2.WinForms.Guna2Button();
            Id = new TextBox();
            panel1 = new Panel();
            Column = new ComboBox();
            SearchButton = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            Search = new TextBox();
            CloseButton = new Label();
            dataGridView1 = new DataGridView();
            AddButton = new Guna.UI2.WinForms.Guna2Button();
            EditButton = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(AddButton);
            panel2.Controls.Add(DeleteButton_Click);
            panel2.Controls.Add(Update);
            panel2.Controls.Add(Id);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 588);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 109);
            panel2.TabIndex = 15;
            // 
            // DeleteButton_Click
            // 
            DeleteButton_Click.BorderRadius = 20;
            DeleteButton_Click.CustomizableEdges = customizableEdges5;
            DeleteButton_Click.DisabledState.BorderColor = Color.DarkGray;
            DeleteButton_Click.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteButton_Click.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteButton_Click.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteButton_Click.FillColor = Color.DarkTurquoise;
            DeleteButton_Click.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton_Click.ForeColor = Color.White;
            DeleteButton_Click.Location = new Point(483, 22);
            DeleteButton_Click.Name = "DeleteButton_Click";
            DeleteButton_Click.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DeleteButton_Click.Size = new Size(181, 64);
            DeleteButton_Click.TabIndex = 26;
            DeleteButton_Click.Text = "Удалить";
            DeleteButton_Click.Click += DeleteButton_Click_Click;
            // 
            // Update
            // 
            Update.BorderRadius = 20;
            Update.CustomizableEdges = customizableEdges7;
            Update.DisabledState.BorderColor = Color.DarkGray;
            Update.DisabledState.CustomBorderColor = Color.DarkGray;
            Update.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Update.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Update.FillColor = Color.DarkTurquoise;
            Update.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Update.ForeColor = Color.White;
            Update.Location = new Point(689, 22);
            Update.Name = "Update";
            Update.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Update.Size = new Size(181, 64);
            Update.TabIndex = 25;
            Update.Text = "Обновить";
            // 
            // Id
            // 
            Id.BackColor = Color.SteelBlue;
            Id.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Id.ForeColor = Color.YellowGreen;
            Id.Location = new Point(892, 194);
            Id.Margin = new Padding(35);
            Id.Name = "Id";
            Id.Size = new Size(10, 29);
            Id.TabIndex = 24;
            Id.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(Column);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 87);
            panel1.TabIndex = 13;
            // 
            // Column
            // 
            Column.FormattingEnabled = true;
            Column.Location = new Point(533, 32);
            Column.Name = "Column";
            Column.Size = new Size(121, 23);
            Column.TabIndex = 23;
            // 
            // SearchButton
            // 
            SearchButton.BorderRadius = 20;
            SearchButton.CustomizableEdges = customizableEdges9;
            SearchButton.DisabledState.BorderColor = Color.DarkGray;
            SearchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SearchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SearchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SearchButton.FillColor = Color.DarkTurquoise;
            SearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(393, 27);
            SearchButton.Name = "SearchButton";
            SearchButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            SearchButton.Size = new Size(134, 34);
            SearchButton.TabIndex = 22;
            SearchButton.Text = "Поиск";
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 12;
            label1.Text = "Просмотр выездов";
            // 
            // Search
            // 
            Search.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Search.Location = new Point(670, 28);
            Search.Margin = new Padding(35);
            Search.Name = "Search";
            Search.Size = new Size(216, 29);
            Search.TabIndex = 11;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.BackColor = Color.SteelBlue;
            CloseButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(878, 9);
            CloseButton.Margin = new Padding(4, 0, 4, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(20, 20);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(864, 475);
            dataGridView1.TabIndex = 16;
            // 
            // AddButton
            // 
            AddButton.BorderRadius = 20;
            AddButton.CustomizableEdges = customizableEdges3;
            AddButton.DisabledState.BorderColor = Color.DarkGray;
            AddButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddButton.FillColor = Color.DarkTurquoise;
            AddButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.ForeColor = Color.White;
            AddButton.Location = new Point(277, 22);
            AddButton.Name = "AddButton";
            AddButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddButton.Size = new Size(181, 64);
            AddButton.TabIndex = 27;
            AddButton.Text = "Добавить";
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.BorderRadius = 20;
            EditButton.CustomizableEdges = customizableEdges1;
            EditButton.DisabledState.BorderColor = Color.DarkGray;
            EditButton.DisabledState.CustomBorderColor = Color.DarkGray;
            EditButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditButton.FillColor = Color.DarkTurquoise;
            EditButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(62, 22);
            EditButton.Name = "EditButton";
            EditButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EditButton.Size = new Size(181, 64);
            EditButton.TabIndex = 28;
            EditButton.Text = "Изменить";
            EditButton.Click += EditButton_Click;
            // 
            // GoodsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(902, 697);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GoodsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GoodsWindow";
            Load += GoodsWindow_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox Id;
        private Panel panel1;
        private ComboBox Column;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private Label label1;
        private TextBox Search;
        private Label CloseButton;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button Update;
        private Guna.UI2.WinForms.Guna2Button DeleteButton_Click;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
    }
}