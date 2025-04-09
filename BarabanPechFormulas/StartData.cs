using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarabanPechFormulas
{
    public class StartData
    {
        /// <summary>
        /// Производительность, кг/ч
        /// </summary>
        public double Gm { get; set; }
        /// <summary>
        /// Начальная влажность материала, %
        /// </summary>
        public double W1B { get; set; }
        /// <summary>
        /// Конечная влажность материала, %
        /// </summary>
        public double W2B { get; set; }
        /// <summary>
        /// Теплота сгорания топлива, кДж/кг
        /// </summary>
        public double Qnr { get; set; }
        /// <summary>
        /// Выход продуктов сгорания, м3/кг
        /// </summary>
        public double Va { get; set; }
        /// <summary>
        /// Максимальная температура газов, °С
        /// </summary>
        public double T1 { get; set; }
        /// <summary>
        /// Минимальная температура газов, °С
        /// </summary>
        public double T2 { get; set; }
        /// <summary>
        /// Температура воздуха, °С
        /// </summary>
        public double Tv { get; set; }
        /// <summary>
        /// Температура наружной поверхности стенок, °С
        /// </summary>
        public double Tst2 { get; set; }
        /// <summary>
        /// Недожог, q3/Qнр*100% (по таблице)
        /// </summary>
        public double Nedozhog { get; set; }
        /// <summary>
        /// Коэффициент теплоотдачи от стенки к воздуху, Вт/(м2*К)
        /// </summary>
        public double Av { get; set; }
        /// <summary>
        /// Диаметр барабана, м
        /// </summary>
        public double D { get; set; }
        /// <summary>
        /// Длина барабана, м
        /// </summary>
        public double L { get; set; }

        /* Энтальпия, кДж/м3 */

        /// <summary>
        /// Энтальпия факела
        /// </summary>
        public double If { get; set; }
        /// <summary>
        /// Энтальпия продуктов сгорания
        /// </summary>
        public double I0 { get; set; }
        /// <summary>
        /// Энтальпия воздуха
        /// </summary>
        public double Iv { get; set; }
        /// <summary>
        /// Энтальпия дымовых газов
        /// </summary>
        public double I2 { get; set; }
        /// <summary>
        /// Начальная энтальпия воды
        /// </summary>
        public double I1vl { get; set; }
        /// <summary>
        /// Энтальпия воздуха, находимая при температуре t2
        /// и содержании воздуха в продуктах сгорания VL=100%
        /// </summary>
        public double I2v { get; set; }

        public bool CheckCorrectness()
        {
            List<double> values = [
                Gm, W1B, W2B, Qnr, Va, T1, T2, Tv, Tst2, Nedozhog, Av, D, L,
                If, I0, Iv, I2, I1vl, I2v
                ];

            return values.All(Formulas.ValidateInput);
        }
    }
}
