using BarabanPechFormulas;
using System.Reflection;
using System.Text;

namespace BarabanSushilPech
{
    public partial class InitialDataForm : Form
    {
        public InitialDataForm()
        {
            InitializeComponent();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is not TextBox textbox)
                return;

            bool result = double.TryParse(textbox.Text, out double value) && Formulas.ValidateInput(value);
            if (!result)
            {
                textbox.Text = "1";
                ShowError();
            }
        }

        private void Button_Begin_Click(object sender, EventArgs e)
        {
            StartData data = new();

            /*
             * я не хочу писать много одинакового кода, поэтому € использую рефлексию
             * и с помощью неЄ € беру все свойства объекта с входными данными, ищу
             * им соответствующие пол€ дл€ ввода из данного класса формы, конвертирую
             * текст из данных полей в число и сохран€ю в объект с входными данными через
             * найденные с рефлексией свойства.
             */
            foreach (var a in typeof(StartData).GetProperties())
            {
                if (GetType().GetField("TextBox_" + a.Name)?.GetValue(this) is not TextBox tb)
                {
                    MessageBox.Show($"Something is wrong: TextBox_{a.Name} not found");
                    continue;
                }

                double value = double.Parse(tb.Text);
                if (!Formulas.ValidateInput(value))
                {
                    tb.Text = "1";
                    ShowError();
                    return;
                }
                a.SetValue(data, value);
            }

            var form = new ResultsForm(data);
            form.ShowDialog();
        }

        private static void ShowError()
            => MessageBox.Show(Formulas.ARGUMENT_ERROR_MESSAGE, "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
