using BarabanPechFormulas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static BarabanPechFormulas.Formulas;

namespace BarabanSushilPech
{
    public partial class ResultsForm : Form
    {
        private double fullEnergy;

        public ResultsForm(StartData data)
        {
            InitializeComponent();

            foreach (DataGridViewColumn column in DataGridView_Table.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            MakeCalculations(data);
        }

        private void MakeCalculations(StartData data)
        {
            // Не должно произойти, но оставлю, на всякий случай
            if (!data.CheckCorrectness())
                return;

            double xv = SetData(TextBox_Xv, CalculateAirAmount(data.If, data.I0, data.Iv));
            double startAvgMassTemp = SetData(TextBox_Tm1, data.Tv);
            double finalAvgMassTemp = SetData(TextBox_Tm2, CalculateFinalAvgMassTemperature(data.T1, data.T2));
            double w1c = SetData(TextBox_W1c, CalculateWc(data.W1B));
            double w2c = SetData(TextBox_W2c, CalculateWc(data.W2B));

            // Тепловой баланс

            double Q1 = CalculateQ1(data, w1c, w2c, startAvgMassTemp, finalAvgMassTemp);
            double q2 = Calculateq2(data, xv);
            double q3 = Calculateq3(data);
            double Q5trp = CalculateQ5trp(data);
            double q5ttop = Calculateq5ttop(data.Qnr);

            // Раход топлива
            double B = CalculateB(data.Qnr, Q1, q2, q3, Q5trp, q5ttop);
            SetData(TextBox_B, B * 100);

            SetData(TextBox_KPD, CalculateKPD(Q1, B, data.Qnr) * 100);
            SetData(TextBox_KIT, CalculateKIT(Q1, Q5trp, B, data.Qnr) * 100);
            double Gvl = SetData(TextBox_Gvl, CalculateGvl(data.Gm, w1c, w2c));
            SetData(TextBox_Qisp, CalculateQisp(B, data.Qnr, Gvl));

            fullEnergy = data.Qnr * B;

            // Приход теплоты
            AddCalculationSection("Приход теплоты:");
            AddCalculationRow("Химическая теплота топлива", fullEnergy);

            // Расход теплоты
            AddCalculationSection("Расход теплоты:");
            AddCalculationRow("Затраты теплоты на нагрев материала и испарение влаги", Q1);
            AddCalculationRow("Потери теплоты с отходящими газами", q2 * B);
            AddCalculationRow("Потери теплоты вследствие химического недожога", q3 * B);
            AddCalculationRow("Потери теплоты рабочим пространством и с приспособлениями", Q5trp);
            AddCalculationRow("Потери теплоты топкой", q5ttop * B);

            AddCalculationResult();
        }

        private static double SetData(TextBox tb, double value)
        {
            tb.Text = Math.Round(value, 3).ToString();
            return value;
        }

        private void AddCalculationSection(string name)
            => MakeBold(DataGridView_Table.Rows.Add(name));

        private double AddCalculationRow(string name, double value)
        {
            DataGridView_Table.Rows.Add(name, Math.Round(value, 3), Math.Round(value / fullEnergy * 100, 3));
            return value;
        }

        private void AddCalculationResult()
            => MakeBold(DataGridView_Table.Rows.Add("ИТОГО:", Math.Round(fullEnergy, 3), 100));

        private void MakeBold(int rowIdx)
            => DataGridView_Table.Rows[rowIdx].Cells[0].Style.Font = new Font(Font, FontStyle.Bold);

        private void Button_Close_Click(object sender, EventArgs e)
            => Close();

        private void Button_Save_Click(object sender, EventArgs e)
            => ExcelReport.GenerateReport(this);
    }
}
