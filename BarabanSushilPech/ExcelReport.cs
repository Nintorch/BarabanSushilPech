using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace BarabanSushilPech
{
    public class ExcelReport
    {
        ExcelPackage package = new ExcelPackage();
        ExcelWorksheet sheet;
        ResultsForm results;

        private ExcelReport(ResultsForm results)
        {
            this.results = results;
            sheet = package.Workbook.Worksheets.Add("Отчет о расчёте барабанной сушильной печи");
            BuildTable();
        }

        private ExcelRange Cells => sheet.Cells;

        private void BuildTable()
        {
            int row = BuildHeader();
            row = BuildParameters1(row);
            row = BuildHeatBalance(row);
            BuildParameters2(row);

            for (int i = 1; i <= 5; i++)
                sheet.Column(i).AutoFit();
        }

        private int BuildHeader()
        {
            var cell = Cells[1, 1];
            cell.Value = results.label20.Text;
            SetBold(cell);
            return 3;
        }

        private int BuildParameters1(int row)
        {
            PutResultValue(row++, results.label1.Text, results.TextBox_Xv.Text);
            PutResultValue(row++, results.label6.Text, results.TextBox_Tm1.Text);
            PutResultValue(row++, results.label7.Text, results.TextBox_Tm2.Text);
            PutResultValue(row++, results.label4.Text, results.TextBox_W1c.Text);
            PutResultValue(row++, results.label5.Text, results.TextBox_W2c.Text);
            return row + 1;
        }

        private void PutResultValue(int row, string name, string value)
        {
            Cells[row, 1].Value = name;
            Cells[row, 2].Value = double.Parse(value);
            SetBorder(Cells[row, 1, row, 2]);
        }

        private int BuildHeatBalance(int row)
        {
            DataGridView data = results.DataGridView_Table;

            for (int i = 0; i < data.Columns.Count; i++)
            {
                Cells[row, i + 1].Value = data.Columns[i].HeaderText;
            }

            SetBorder(Cells[row, 1, row, data.Columns.Count]);
            SetBold(Cells[row, 1, row, data.Columns.Count]);

            row++;

            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    Cells[row, j + 1].Value = data.Rows[i].Cells[j].Value;
                }
                SetBorder(Cells[row, 1, row, data.Columns.Count]);
                row++;
            }

            return row + 1;
        }

        private void BuildParameters2(int row)
        {
            PutResultValue(row++, results.label24.Text, results.TextBox_B.Text);
            PutResultValue(row++, results.label25.Text, results.TextBox_KPD.Text);
            PutResultValue(row++, results.label26.Text, results.TextBox_KIT.Text);
            PutResultValue(row, results.label27.Text, results.TextBox_Qisp.Text);
            Cells[row++, 3].Value = results.label28.Text;
            PutResultValue(row, results.label29.Text, results.TextBox_Gvl.Text);
        }

        private static void SetBorder(ExcelRange range)
        {
            var style = ExcelBorderStyle.Thin;
            var border = range.Style.Border;
            border.Top.Style = style;
            border.Bottom.Style = style;
            border.Left.Style = style;
            border.Right.Style = style;
        }

        private static void SetBold(ExcelRange range)
            => range.Style.Font.Bold = true;

        public static void GenerateReport(ResultsForm resuls)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "Сохранение отчёта";
            fileDialog.Filter = "Файл Excel|*.xlsx";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var report = new ExcelReport(resuls);
                    File.WriteAllBytes(fileDialog.FileName, report.package.GetAsByteArray());
                    MessageBox.Show("Отчёт о расчёте барабанной сушильной печи был успешно сохранён в файл "
                        + fileDialog.FileName, "Успешно");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Произошла ошибка при сохранении отчёта: " + e.Message, "Ошибка");
                }
            }
        }
    }
}
