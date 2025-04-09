namespace BarabanSushilPech
{
    partial class InitialDataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBox_Gm = new TextBox();
            TextBox_W1B = new TextBox();
            label2 = new Label();
            TextBox_W2B = new TextBox();
            label3 = new Label();
            TextBox_Qnr = new TextBox();
            label4 = new Label();
            TextBox_Va = new TextBox();
            label5 = new Label();
            TextBox_T1 = new TextBox();
            label6 = new Label();
            TextBox_T2 = new TextBox();
            label7 = new Label();
            TextBox_Tv = new TextBox();
            label8 = new Label();
            TextBox_Tst2 = new TextBox();
            label9 = new Label();
            TextBox_Nedozhog = new TextBox();
            label10 = new Label();
            TextBox_Av = new TextBox();
            label11 = new Label();
            TextBox_D = new TextBox();
            label12 = new Label();
            TextBox_L = new TextBox();
            label13 = new Label();
            TextBox_If = new TextBox();
            label14 = new Label();
            TextBox_I0 = new TextBox();
            label15 = new Label();
            TextBox_Iv = new TextBox();
            label16 = new Label();
            TextBox_I2 = new TextBox();
            label17 = new Label();
            TextBox_I1vl = new TextBox();
            label18 = new Label();
            TextBox_I2v = new TextBox();
            label19 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Button_Begin = new Button();
            label20 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 0;
            label1.Text = "Производительность, Gm, кг/ч";
            // 
            // TextBox_Gm
            // 
            TextBox_Gm.Location = new Point(441, 26);
            TextBox_Gm.Name = "TextBox_Gm";
            TextBox_Gm.Size = new Size(125, 27);
            TextBox_Gm.TabIndex = 1;
            TextBox_Gm.Text = "1,75";
            TextBox_Gm.Leave += TextBox_Leave;
            // 
            // TextBox_W1B
            // 
            TextBox_W1B.Location = new Point(441, 59);
            TextBox_W1B.Name = "TextBox_W1B";
            TextBox_W1B.Size = new Size(125, 27);
            TextBox_W1B.TabIndex = 3;
            TextBox_W1B.Text = "10";
            TextBox_W1B.Leave += TextBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(299, 20);
            label2.TabIndex = 2;
            label2.Text = "Начальная влажность материала, W1B, %";
            // 
            // TextBox_W2B
            // 
            TextBox_W2B.Location = new Point(441, 92);
            TextBox_W2B.Name = "TextBox_W2B";
            TextBox_W2B.Size = new Size(125, 27);
            TextBox_W2B.TabIndex = 5;
            TextBox_W2B.Text = "0,5";
            TextBox_W2B.Leave += TextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(291, 20);
            label3.TabIndex = 4;
            label3.Text = "Конечная влажность материала, W2B, %";
            // 
            // TextBox_Qnr
            // 
            TextBox_Qnr.Location = new Point(441, 125);
            TextBox_Qnr.Name = "TextBox_Qnr";
            TextBox_Qnr.Size = new Size(125, 27);
            TextBox_Qnr.TabIndex = 7;
            TextBox_Qnr.Text = "40184";
            TextBox_Qnr.Leave += TextBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(282, 20);
            label4.TabIndex = 6;
            label4.Text = "Теплота сгорания топлива Qнр, кДж/кг";
            // 
            // TextBox_Va
            // 
            TextBox_Va.Location = new Point(441, 158);
            TextBox_Va.Name = "TextBox_Va";
            TextBox_Va.Size = new Size(125, 27);
            TextBox_Va.TabIndex = 9;
            TextBox_Va.Text = "13,178";
            TextBox_Va.Leave += TextBox_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 161);
            label5.Name = "label5";
            label5.Size = new Size(265, 20);
            label5.TabIndex = 8;
            label5.Text = "Выход продуктов сгорания Vα, м3/кг";
            // 
            // TextBox_T1
            // 
            TextBox_T1.Location = new Point(441, 191);
            TextBox_T1.Name = "TextBox_T1";
            TextBox_T1.Size = new Size(125, 27);
            TextBox_T1.TabIndex = 11;
            TextBox_T1.Text = "850";
            TextBox_T1.Leave += TextBox_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 194);
            label6.Name = "label6";
            label6.Size = new Size(290, 20);
            label6.TabIndex = 10;
            label6.Text = "Максимальная температура газов, t1, °С";
            // 
            // TextBox_T2
            // 
            TextBox_T2.Location = new Point(441, 224);
            TextBox_T2.Name = "TextBox_T2";
            TextBox_T2.Size = new Size(125, 27);
            TextBox_T2.TabIndex = 13;
            TextBox_T2.Text = "350";
            TextBox_T2.Leave += TextBox_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 227);
            label7.Name = "label7";
            label7.Size = new Size(286, 20);
            label7.TabIndex = 12;
            label7.Text = "Минимальная температура газов, t2, °С";
            // 
            // TextBox_Tv
            // 
            TextBox_Tv.Location = new Point(441, 257);
            TextBox_Tv.Name = "TextBox_Tv";
            TextBox_Tv.Size = new Size(125, 27);
            TextBox_Tv.TabIndex = 15;
            TextBox_Tv.Text = "20";
            TextBox_Tv.Leave += TextBox_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 260);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 14;
            label8.Text = "Температура воздуха, tв, °С";
            // 
            // TextBox_Tst2
            // 
            TextBox_Tst2.Location = new Point(441, 290);
            TextBox_Tst2.Name = "TextBox_Tst2";
            TextBox_Tst2.Size = new Size(125, 27);
            TextBox_Tst2.TabIndex = 17;
            TextBox_Tst2.Text = "360";
            TextBox_Tst2.Leave += TextBox_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 293);
            label9.Name = "label9";
            label9.Size = new Size(374, 20);
            label9.TabIndex = 16;
            label9.Text = "Температура наружной поверхности стенок, tст2, °С";
            // 
            // TextBox_Nedozhog
            // 
            TextBox_Nedozhog.Location = new Point(441, 323);
            TextBox_Nedozhog.Name = "TextBox_Nedozhog";
            TextBox_Nedozhog.Size = new Size(125, 27);
            TextBox_Nedozhog.TabIndex = 19;
            TextBox_Nedozhog.Text = "0,02";
            TextBox_Nedozhog.Leave += TextBox_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 326);
            label10.Name = "label10";
            label10.Size = new Size(265, 20);
            label10.TabIndex = 18;
            label10.Text = "Недожог, q3/Qнр*100% (по таблице)";
            // 
            // TextBox_Av
            // 
            TextBox_Av.Location = new Point(441, 356);
            TextBox_Av.Name = "TextBox_Av";
            TextBox_Av.Size = new Size(125, 27);
            TextBox_Av.TabIndex = 21;
            TextBox_Av.Text = "29,6";
            TextBox_Av.Leave += TextBox_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 359);
            label11.Name = "label11";
            label11.Size = new Size(429, 20);
            label11.TabIndex = 20;
            label11.Text = "Коэффициент теплоотдачи от стенки к воздуху, αв, Вт/(м2*К)";
            // 
            // TextBox_D
            // 
            TextBox_D.Location = new Point(441, 389);
            TextBox_D.Name = "TextBox_D";
            TextBox_D.Size = new Size(125, 27);
            TextBox_D.TabIndex = 23;
            TextBox_D.Text = "1,2";
            TextBox_D.Leave += TextBox_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 392);
            label12.Name = "label12";
            label12.Size = new Size(178, 20);
            label12.TabIndex = 22;
            label12.Text = "Диаметр барабана, D, м";
            // 
            // TextBox_L
            // 
            TextBox_L.Location = new Point(441, 422);
            TextBox_L.Name = "TextBox_L";
            TextBox_L.Size = new Size(125, 27);
            TextBox_L.TabIndex = 25;
            TextBox_L.Text = "6";
            TextBox_L.Leave += TextBox_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 425);
            label13.Name = "label13";
            label13.Size = new Size(157, 20);
            label13.TabIndex = 24;
            label13.Text = "Длина барабана, L, м";
            // 
            // TextBox_If
            // 
            TextBox_If.Location = new Point(358, 26);
            TextBox_If.Name = "TextBox_If";
            TextBox_If.Size = new Size(125, 27);
            TextBox_If.TabIndex = 27;
            TextBox_If.Text = "2716";
            TextBox_If.Leave += TextBox_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 30);
            label14.Name = "label14";
            label14.Size = new Size(217, 20);
            label14.TabIndex = 26;
            label14.Text = "Энтальпия факела, iф, кДж/м3";
            // 
            // TextBox_I0
            // 
            TextBox_I0.Location = new Point(358, 59);
            TextBox_I0.Name = "TextBox_I0";
            TextBox_I0.Size = new Size(125, 27);
            TextBox_I0.TabIndex = 29;
            TextBox_I0.Text = "1281";
            TextBox_I0.Leave += TextBox_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 63);
            label15.Name = "label15";
            label15.Size = new Size(307, 20);
            label15.TabIndex = 28;
            label15.Text = "Энтальпия продуктов сгорания, i0, кДж/м3";
            // 
            // TextBox_Iv
            // 
            TextBox_Iv.Location = new Point(358, 92);
            TextBox_Iv.Name = "TextBox_Iv";
            TextBox_Iv.Size = new Size(125, 27);
            TextBox_Iv.TabIndex = 31;
            TextBox_Iv.Text = "26";
            TextBox_Iv.Leave += TextBox_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 96);
            label16.Name = "label16";
            label16.Size = new Size(220, 20);
            label16.TabIndex = 30;
            label16.Text = "Энтальпия воздуха, iв, кДж/м3";
            // 
            // TextBox_I2
            // 
            TextBox_I2.Location = new Point(358, 125);
            TextBox_I2.Name = "TextBox_I2";
            TextBox_I2.Size = new Size(125, 27);
            TextBox_I2.TabIndex = 33;
            TextBox_I2.Text = "508";
            TextBox_I2.Leave += TextBox_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 129);
            label17.Name = "label17";
            label17.Size = new Size(273, 20);
            label17.TabIndex = 32;
            label17.Text = "Энтальпия дымовых газов, i2, кДж/м3";
            // 
            // TextBox_I1vl
            // 
            TextBox_I1vl.Location = new Point(358, 158);
            TextBox_I1vl.Name = "TextBox_I1vl";
            TextBox_I1vl.Size = new Size(125, 27);
            TextBox_I1vl.TabIndex = 35;
            TextBox_I1vl.Text = "83,8";
            TextBox_I1vl.Leave += TextBox_Leave;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 162);
            label18.Name = "label18";
            label18.Size = new Size(296, 20);
            label18.TabIndex = 34;
            label18.Text = "Начальная энтальпия воды, i1вл, кДж/м3";
            // 
            // TextBox_I2v
            // 
            TextBox_I2v.Location = new Point(358, 224);
            TextBox_I2v.Name = "TextBox_I2v";
            TextBox_I2v.Size = new Size(125, 27);
            TextBox_I2v.TabIndex = 37;
            TextBox_I2v.Text = "463";
            TextBox_I2v.Leave += TextBox_Leave;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 195);
            label19.Name = "label19";
            label19.Size = new Size(313, 60);
            label19.TabIndex = 36;
            label19.Text = "Энтальпия воздуха, находимая\r\nпри температуре t2 и содержании воздуха\r\nв продуктах сгорания VL=100%, i2в, кДж/м3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TextBox_Gm);
            groupBox1.Controls.Add(TextBox_W1B);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBox_W2B);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TextBox_Qnr);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TextBox_Va);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TextBox_T1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(TextBox_L);
            groupBox1.Controls.Add(TextBox_T2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(TextBox_Tv);
            groupBox1.Controls.Add(TextBox_D);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TextBox_Av);
            groupBox1.Controls.Add(TextBox_Tst2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(TextBox_Nedozhog);
            groupBox1.Location = new Point(11, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 460);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Входные данные";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TextBox_If);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(TextBox_I2v);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(TextBox_I0);
            groupBox2.Controls.Add(TextBox_I1vl);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(TextBox_Iv);
            groupBox2.Controls.Add(TextBox_I2);
            groupBox2.Controls.Add(label17);
            groupBox2.Location = new Point(594, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 262);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Энтальпия";
            // 
            // Button_Begin
            // 
            Button_Begin.Location = new Point(939, 470);
            Button_Begin.Name = "Button_Begin";
            Button_Begin.Size = new Size(150, 50);
            Button_Begin.TabIndex = 40;
            Button_Begin.Text = "Начать расчёт";
            Button_Begin.UseVisualStyleBackColor = true;
            Button_Begin.Click += Button_Begin_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(369, 18);
            label20.Name = "label20";
            label20.Size = new Size(349, 28);
            label20.TabIndex = 41;
            label20.Text = "Расчёт барабанной сушильной печи";
            // 
            // InitialDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 529);
            Controls.Add(label20);
            Controls.Add(Button_Begin);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "InitialDataForm";
            Text = "Расчёт барабанной сушильной печи - Входные данные";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button Button_Begin;
        private Label label20;
        public TextBox TextBox_Gm;
        public TextBox TextBox_W1B;
        public TextBox TextBox_W2B;
        public TextBox TextBox_Qnr;
        public TextBox TextBox_Va;
        public TextBox TextBox_T1;
        public TextBox TextBox_T2;
        public TextBox TextBox_Tv;
        public TextBox TextBox_Tst2;
        public TextBox TextBox_Nedozhog;
        public TextBox TextBox_Av;
        public TextBox TextBox_D;
        public TextBox TextBox_L;
        public TextBox TextBox_If;
        public TextBox TextBox_I0;
        public TextBox TextBox_Iv;
        public TextBox TextBox_I2;
        public TextBox TextBox_I1vl;
        public TextBox TextBox_I2v;
    }
}
