namespace BarabanSushilPech
{
    partial class ResultsForm
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
            label20 = new Label();
            label1 = new Label();
            TextBox_Xv = new TextBox();
            TextBox_W1c = new TextBox();
            label4 = new Label();
            TextBox_W2c = new TextBox();
            label5 = new Label();
            TextBox_Tm1 = new TextBox();
            label6 = new Label();
            TextBox_Tm2 = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            DataGridView_Table = new DataGridView();
            CalculationName = new DataGridViewTextBoxColumn();
            DataKilojoules = new DataGridViewTextBoxColumn();
            DataPercent = new DataGridViewTextBoxColumn();
            label28 = new Label();
            label29 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            TextBox_Qisp = new TextBox();
            TextBox_KIT = new TextBox();
            TextBox_KPD = new TextBox();
            TextBox_Gvl = new TextBox();
            TextBox_B = new TextBox();
            Button_Close = new Button();
            Button_Save = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Table).BeginInit();
            SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(12, 9);
            label20.Name = "label20";
            label20.Size = new Size(543, 28);
            label20.TabIndex = 42;
            label20.Text = "Расчёт барабанной сушильной печи - Результаты расчёта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 55);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 43;
            label1.Text = "Количество воздуха хв, м3/м3";
            // 
            // TextBox_Xv
            // 
            TextBox_Xv.Location = new Point(439, 52);
            TextBox_Xv.Name = "TextBox_Xv";
            TextBox_Xv.ReadOnly = true;
            TextBox_Xv.Size = new Size(125, 27);
            TextBox_Xv.TabIndex = 44;
            // 
            // TextBox_W1c
            // 
            TextBox_W1c.Location = new Point(644, 52);
            TextBox_W1c.Name = "TextBox_W1c";
            TextBox_W1c.ReadOnly = true;
            TextBox_W1c.Size = new Size(125, 27);
            TextBox_W1c.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 55);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 45;
            label4.Text = "W1c =";
            // 
            // TextBox_W2c
            // 
            TextBox_W2c.Location = new Point(644, 85);
            TextBox_W2c.Name = "TextBox_W2c";
            TextBox_W2c.ReadOnly = true;
            TextBox_W2c.Size = new Size(125, 27);
            TextBox_W2c.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(588, 88);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 45;
            label5.Text = "W2c =";
            // 
            // TextBox_Tm1
            // 
            TextBox_Tm1.Location = new Point(439, 85);
            TextBox_Tm1.Name = "TextBox_Tm1";
            TextBox_Tm1.ReadOnly = true;
            TextBox_Tm1.Size = new Size(125, 27);
            TextBox_Tm1.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 88);
            label6.Name = "label6";
            label6.Size = new Size(420, 20);
            label6.TabIndex = 45;
            label6.Text = "Начальная среднемассовая температура материала tм1, C";
            // 
            // TextBox_Tm2
            // 
            TextBox_Tm2.Location = new Point(439, 118);
            TextBox_Tm2.Name = "TextBox_Tm2";
            TextBox_Tm2.ReadOnly = true;
            TextBox_Tm2.Size = new Size(125, 27);
            TextBox_Tm2.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 121);
            label7.Name = "label7";
            label7.Size = new Size(412, 20);
            label7.TabIndex = 45;
            label7.Text = "Конечная среднемассовая температура материала tм2, C";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataGridView_Table);
            groupBox1.Controls.Add(label28);
            groupBox1.Controls.Add(label29);
            groupBox1.Controls.Add(label27);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(TextBox_Qisp);
            groupBox1.Controls.Add(TextBox_KIT);
            groupBox1.Controls.Add(TextBox_KPD);
            groupBox1.Controls.Add(TextBox_Gvl);
            groupBox1.Controls.Add(TextBox_B);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 570);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Расчёт теплового баланса";
            // 
            // DataGridView_Table
            // 
            DataGridView_Table.AllowUserToAddRows = false;
            DataGridView_Table.AllowUserToDeleteRows = false;
            DataGridView_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_Table.Columns.AddRange(new DataGridViewColumn[] { CalculationName, DataKilojoules, DataPercent });
            DataGridView_Table.Location = new Point(6, 26);
            DataGridView_Table.Name = "DataGridView_Table";
            DataGridView_Table.ReadOnly = true;
            DataGridView_Table.RowHeadersWidth = 51;
            DataGridView_Table.Size = new Size(763, 346);
            DataGridView_Table.TabIndex = 47;
            // 
            // CalculationName
            // 
            CalculationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CalculationName.HeaderText = "Наименование статьи";
            CalculationName.MinimumWidth = 6;
            CalculationName.Name = "CalculationName";
            CalculationName.ReadOnly = true;
            CalculationName.Width = 176;
            // 
            // DataKilojoules
            // 
            DataKilojoules.HeaderText = "Значение статьи, кДж";
            DataKilojoules.MinimumWidth = 6;
            DataKilojoules.Name = "DataKilojoules";
            DataKilojoules.ReadOnly = true;
            DataKilojoules.Width = 150;
            // 
            // DataPercent
            // 
            DataPercent.HeaderText = "Значение статьи, %";
            DataPercent.MinimumWidth = 6;
            DataPercent.Name = "DataPercent";
            DataPercent.ReadOnly = true;
            DataPercent.Width = 150;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(162, 506);
            label28.Name = "label28";
            label28.Size = new Size(56, 20);
            label28.TabIndex = 45;
            label28.Text = "кДж/кг";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(6, 533);
            label29.Name = "label29";
            label29.Size = new Size(317, 20);
            label29.TabIndex = 45;
            label29.Text = "Масса испарённой из изделий влаги Gвл, кг";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 480);
            label27.Name = "label27";
            label27.Size = new Size(648, 20);
            label27.TabIndex = 45;
            label27.Text = "Количество теплоты, затраченной на испарение 1 кг влаги из просушиваемого материала:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 453);
            label26.Name = "label26";
            label26.Size = new Size(296, 20);
            label26.TabIndex = 45;
            label26.Text = "Коэффициент использования теплоты, %";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 420);
            label25.Name = "label25";
            label25.Size = new Size(268, 20);
            label25.TabIndex = 45;
            label25.Text = "Коэффициент полезного действия, %";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(6, 387);
            label24.Name = "label24";
            label24.Size = new Size(149, 20);
            label24.TabIndex = 45;
            label24.Text = "Расход топлива В, %";
            // 
            // TextBox_Qisp
            // 
            TextBox_Qisp.Location = new Point(6, 503);
            TextBox_Qisp.Name = "TextBox_Qisp";
            TextBox_Qisp.ReadOnly = true;
            TextBox_Qisp.Size = new Size(150, 27);
            TextBox_Qisp.TabIndex = 46;
            // 
            // TextBox_KIT
            // 
            TextBox_KIT.Location = new Point(329, 450);
            TextBox_KIT.Name = "TextBox_KIT";
            TextBox_KIT.ReadOnly = true;
            TextBox_KIT.Size = new Size(150, 27);
            TextBox_KIT.TabIndex = 46;
            // 
            // TextBox_KPD
            // 
            TextBox_KPD.Location = new Point(329, 417);
            TextBox_KPD.Name = "TextBox_KPD";
            TextBox_KPD.ReadOnly = true;
            TextBox_KPD.Size = new Size(150, 27);
            TextBox_KPD.TabIndex = 46;
            // 
            // TextBox_Gvl
            // 
            TextBox_Gvl.Location = new Point(329, 530);
            TextBox_Gvl.Name = "TextBox_Gvl";
            TextBox_Gvl.ReadOnly = true;
            TextBox_Gvl.Size = new Size(150, 27);
            TextBox_Gvl.TabIndex = 46;
            // 
            // TextBox_B
            // 
            TextBox_B.Location = new Point(329, 384);
            TextBox_B.Name = "TextBox_B";
            TextBox_B.ReadOnly = true;
            TextBox_B.Size = new Size(150, 27);
            TextBox_B.TabIndex = 46;
            // 
            // Button_Close
            // 
            Button_Close.Location = new Point(401, 727);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new Size(250, 29);
            Button_Close.TabIndex = 48;
            Button_Close.Text = "Закрыть окно результатов";
            Button_Close.UseVisualStyleBackColor = true;
            Button_Close.Click += Button_Close_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(145, 727);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(250, 29);
            Button_Save.TabIndex = 48;
            Button_Save.Text = "Сохранить отчёт в файле Excel";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 761);
            Controls.Add(Button_Save);
            Controls.Add(Button_Close);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TextBox_Tm2);
            Controls.Add(TextBox_Tm1);
            Controls.Add(TextBox_W2c);
            Controls.Add(TextBox_W1c);
            Controls.Add(label1);
            Controls.Add(TextBox_Xv);
            Controls.Add(label20);
            Name = "ResultsForm";
            Text = "Расчёт барабанной сушильной печи - Результаты расчёта";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_Close;
        private DataGridViewTextBoxColumn CalculationName;
        private DataGridViewTextBoxColumn DataKilojoules;
        private DataGridViewTextBoxColumn DataPercent;
        public Label label20;
        public Label label1;
        public TextBox TextBox_Xv;
        public TextBox TextBox_W1c;
        public Label label4;
        public TextBox TextBox_W2c;
        public Label label5;
        public TextBox TextBox_Tm1;
        public Label label6;
        public TextBox TextBox_Tm2;
        public Label label7;
        public GroupBox groupBox1;
        public Label label26;
        public Label label25;
        public Label label24;
        public TextBox TextBox_KIT;
        public TextBox TextBox_KPD;
        public TextBox TextBox_B;
        public Label label28;
        public Label label29;
        public Label label27;
        public TextBox TextBox_Qisp;
        public TextBox TextBox_Gvl;
        public DataGridView DataGridView_Table;
        private Button Button_Save;
    }
}