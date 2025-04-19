namespace BarabanPechFormulas
{
    public static class Formulas
    {
        public const string ARGUMENT_ERROR_MESSAGE = "Все параметры формул должны быть положительными числами.";

        private static double CheckedCalculation(Func<double> func, params double[] values)
        {
            foreach (var value in values)
            {
                if (!ValidateInput(value))
                    throw new ArgumentException(ARGUMENT_ERROR_MESSAGE);
            }
            return func();
        }

        private static double CheckedCalculation(Func<double> func, StartData data, params double[] values)
        {
            if (!data.CheckCorrectness())
                throw new ArgumentException(ARGUMENT_ERROR_MESSAGE);
            return CheckedCalculation(func, values);
        }

        public static bool ValidateInput(double input) => input > 0;

        // i это энтальпия
        public static double CalculateAirAmount(double If, double I0, double Iv)
            => CheckedCalculation(() => (If - I0) / (I0 - Iv), If, I0, Iv);

        public static double CalculateWc(double wetnessPercent)
            => CheckedCalculation(() => wetnessPercent / (1 - 0.01 * wetnessPercent), wetnessPercent);

        public static double CalculateFinalAvgMassTemperature(double tempGasesMin, double tempGasesMax)
            => CheckedCalculation(() => (tempGasesMin + tempGasesMax) / 2 - 100, tempGasesMin, tempGasesMax);

        public static double CalculateQ1(StartData data, double w1c, double w2c, double startAvgMassTemp, double finalAvgMassTemp)
            => CheckedCalculation(
        () => ((0.84 + 0.01 * w2c * 4.19) * (finalAvgMassTemp - startAvgMassTemp) + 0.01 * (w1c - w2c) * (2675 - data.I1vl + 2.09 * (data.T2 - 100))) * data.Gm,
            data, w1c, w2c, startAvgMassTemp, finalAvgMassTemp);

        public static double Calculateq2(StartData data, double airAmount)
            => CheckedCalculation(() => (data.I2 + airAmount * (data.I2v - data.Iv)) * data.Va, data, airAmount);

        public static double Calculateq3(StartData data)
            => CheckedCalculation(() => data.Qnr * data.Nedozhog, data);

        public static double CalculateQ5trp(StartData data)
            => CheckedCalculation(() => data.Av * (data.Tst2 - data.Tv) * Math.PI * data.D * data.L * 0.001, data);

        public static double Calculateq5ttop(double qnr)
            => CheckedCalculation(() => 0.1 * qnr, qnr);

        public static double CalculateB(double qnr, double Q1, double q2, double q3, double Q5trp, double q5ttop)
            => CheckedCalculation(() => (Q1 + Q5trp) / (qnr - q2 - q3 - q5ttop), qnr, Q1, q2, q3, Q5trp, q5ttop);

        public static double CalculateKPD(double Q1, double B, double qnr)
            => CheckedCalculation(() => Q1 / B / qnr, Q1, B, qnr);

        public static double CalculateKIT(double Q1, double Q5trp, double B, double qnr)
            => CheckedCalculation(() => (Q1 + Q5trp) / B / qnr, Q1, Q5trp, B, qnr);

        public static double CalculateQisp(double B, double qnr, double Gvl)
            => CheckedCalculation(() => B * qnr / Gvl, B, qnr, Gvl);

        public static double CalculateGvl(double Gm, double w1c, double w2c)
            => CheckedCalculation(() => Gm * (w1c - w2c) * 0.01, Gm, w1c, w2c);
    }
}
