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
        public ResultsForm(StartData data)
        {
            InitializeComponent();
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

            // Приход теплоты
            double Qobsh = SetData(TextBox_Qobsh1, data.Qnr);

            // Расход теплоты
            double Q1 = SetData(TextBox_Q1, CalculateQ1(data, w1c, w2c, startAvgMassTemp, finalAvgMassTemp));
            double q2 = SetData(TextBox_Q2_1, Calculateq2(data, xv));
            double q3 = SetData(TextBox_Q3_1, Calculateq3(data));
            double Q5trp = SetData(TextBox_Q5trp, CalculateQ5trp(data));
            double Q5ttop = SetData(TextBox_Q5ttop_1, CalculateQ5ttop(data.Qnr));

            // Раход топлива
            double B = CalculateB(data.Qnr, Q1, q2, q3, Q5trp, Q5ttop);
            SetData(TextBox_B, B * 100);

            // Теплота с учётом расхода топлива
            SetData(TextBox_Qobsh, Qobsh * B);
            SetData(TextBox_Q2, q2 * B);
            SetData(TextBox_Q3, q3 * B);
            SetData(TextBox_Q5ttop, Q5ttop * B);

            SetData(TextBox_KPD, CalculateKPD(Q1, B, data.Qnr) * 100);
            SetData(TextBox_KIT, CalculateKIT(Q1, Q5ttop, data.Qnr) * 100);
            double Gvl = SetData(TextBox_Gvl, CalculateGvl(data.Gm, w1c, w2c));
            SetData(TextBox_Qisp, CalculateQisp(B, data.Qnr, Gvl));
        }

        private static double SetData(TextBox tb, double value)
        {
            tb.Text = Math.Round(value, 3).ToString();
            return value;
        }

        private void Button_Close_Click(object sender, EventArgs e)
            => Close();
    }
}
