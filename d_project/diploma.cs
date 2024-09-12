using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using System.IO;
using System.Linq;
using System.Globalization;

namespace d_project
{
    public partial class Diploma : MaterialForm
    {
        private DatabaseHelper dbHelper;
        private DatabaseState previousState;

        public Diploma()
        {
            InitializeComponent();

            // Встановлення стартової позиції форми по центру екрану
            this.StartPosition = FormStartPosition.CenterScreen;

            // Застосовуємо до форми стиль MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE);
            
            dbHelper = new DatabaseHelper();

            customDataGridView2.DataError += customDataGridView2_DataError;
            customDataGridView2.CellEndEdit += customDataGridView2_CellEndEdit;
            this.FormClosing += Diploma_FormClosing;
        }

        // Метод для перевірки введеного числа у поле вартості
        private bool IsValidNumber(string input)
        {
            // Замінюємо коми на крапки для стандартного формату
            input = input.Replace(',', '.');

            // Перевірка, чи є вхідний рядок числом
            double number;
            bool isValid = double.TryParse(input, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out number);

            // Перевірка, чи введено лише одне десяткове розділення
            int dotCount = input.Count(c => c == '.');
            if (dotCount > 1)
            {
                return false;
            }
            return isValid;
        }

        private bool IsValidDate(string input)
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                return true;
            }
            return false;
        }

        private void materialButtonWrite_Click(object sender, EventArgs e)
        {
            // Перевірка, чи всі необхідні поля заповнені
            if (string.IsNullOrWhiteSpace(materialTextBoxModel.Text) ||
                string.IsNullOrWhiteSpace(materialTextBoxName.Text) ||
                string.IsNullOrWhiteSpace(materialTextBoxNumber.Text) ||
                string.IsNullOrWhiteSpace(materialTextBoxCost.Text) ||
                materialComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.");
                return;
            }

            // Отримуємо введений номер телефону
            string inputNumber = materialTextBoxNumber.Text;

            // Перевірка правильності введеного номеру
            if (!Regex.IsMatch(inputNumber, @"^0\d{9}$"))
            {
                MessageBox.Show("Будь ласка, введіть правильний номер телефону.");
                return;
            }

            // Перевірка правильності введеного числа в полі вартості
            string inputCost = materialTextBoxCost.Text;
            if (!IsValidNumber(inputCost))
            {
                MessageBox.Show("Будь ласка, введіть коректну вартість.");
                return;
            }

            // Замінюємо кому на крапку перед парсингом
            inputCost = inputCost.Replace(',', '.');

            // Логіка для збереження даних, якщо номер та вартість введено правильно
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            string model = materialTextBoxModel.Text;
            string clientName = materialTextBoxName.Text;
            string number = inputNumber;
            double cost = double.Parse(inputCost, CultureInfo.InvariantCulture); // Використання культури з крапкою як роздільником дробової частини
            string serviceType = materialComboBox1.SelectedItem.ToString();
            string receptionDate = customDatePicker1.Value.ToString("dd.MM.yyyy");
            bool prepayment = materialCheckbox1.Checked;

            // Додаємо заявку до бази даних
            dbHelper.InsertCurrentOrder(model, clientName, number, cost, serviceType, receptionDate, prepayment);

            // Очищаємо тексти введення
            materialTextBoxModel.Text = "";
            materialTextBoxName.Text = "";
            materialTextBoxNumber.Text = "";
            materialTextBoxCost.Text = "";
            materialComboBox1.SelectedIndex = 0; // Встановлення першого елементу в ComboBox
            customDatePicker1.Value = DateTime.Now; // Встановлення поточної дати
            materialCheckbox1.Checked = false; // Скидання чекбоксу

            // Оновлюємо дані у відповідних таблицях
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());
        }

        private void diploma_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());
        }

        private void LoadDataIntoDataGridView(DataGridView dataGridView, DataTable data)
        {
            try
            {
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = data;

                dataGridView.Columns[0].DataPropertyName = "Id";
                dataGridView.Columns[1].DataPropertyName = "Model";
                dataGridView.Columns[2].DataPropertyName = "ClientName";
                dataGridView.Columns[3].DataPropertyName = "Number";
                dataGridView.Columns[4].DataPropertyName = "ServiceType";
                dataGridView.Columns[5].DataPropertyName = "Cost";
                dataGridView.Columns[6].DataPropertyName = "ReceptionDate";
                dataGridView.Columns[7].DataPropertyName = "Prepayment";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних у {dataGridView.Name}: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            foreach (DataGridViewRow row in customDataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                int id = Convert.ToInt32(row.Cells["IdColumn"].Value);
                string model = row.Cells["ModelColumn"].Value?.ToString();
                string client = row.Cells["ClientColumn"].Value?.ToString();
                string number = row.Cells["NumberColumn"].Value?.ToString();
                string service = row.Cells["ServiceColumn"].Value?.ToString();
                string costStr = row.Cells["CostColumn"].Value?.ToString();
                string date = row.Cells["DateColumn"].Value?.ToString();
                bool prepayment = Convert.ToBoolean(row.Cells["PrepaymentColumn"].Value);

                // Перевірка заповнення обов'язкових полів
                if (string.IsNullOrWhiteSpace(model) ||
                    string.IsNullOrWhiteSpace(client) ||
                    string.IsNullOrWhiteSpace(number) ||
                    string.IsNullOrWhiteSpace(costStr) ||
                    string.IsNullOrWhiteSpace(date))
                {
                    MessageBox.Show($"Будь ласка, заповніть всі обов'язкові поля у рядку з ID {id}.");
                    return;
                }

                // Перевірка правильності введеного номеру телефону
                if (!Regex.IsMatch(number, @"^0\d{9}$"))
                {
                    MessageBox.Show($"Будь ласка, введіть правильний номер телефону у рядку з ID {id}.");
                    return;
                }

                // Перевірка правильності введеного числа в полі вартості
                if (!IsValidNumber(costStr))
                {
                    MessageBox.Show($"Будь ласка, введіть коректну вартість у рядку з ID {id}.");
                    return;
                }

                // Перетворення вартості
                try
                {
                    costStr = costStr.Replace(',', '.');
                    double cost = double.Parse(costStr, CultureInfo.InvariantCulture);

                    // Перевірка правильності формату дати та існування дати
                    if (!IsValidDate(date))
                    {
                        MessageBox.Show($"Будь ласка, введіть коректну дату прийому у форматі дд.мм.рррр у рядку з ID {id}.");
                        return;
                    }

                    // Оновлення заявки в базі даних
                    dbHelper.UpdateOrder(id, model, client, number, service, cost, date, prepayment);
                    hasUnsavedChanges = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show($"Будь ласка, введіть коректну вартість у рядку з ID {id}.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}", "Невідома помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Оновлюємо дані у відповідних таблицях
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());

            MessageBox.Show("Зміни успішно збережені!");
        }

        private void materialButtonDelete_Click(object sender, EventArgs e)
        {
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            if (customDataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(customDataGridView2.SelectedRows[0].Cells["IdColumn"].Value);
                dbHelper.DeleteOrder(selectedRowId);

                // Оновлення даних у таблиці після видалення
                LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
                LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());
                MessageBox.Show("Заявку успішно видалено!");
            }
            else
            {
                MessageBox.Show("Виберіть заявку для видалення!");
            }
        }

        private void materialButtonComplete_Click(object sender, EventArgs e)
        {
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            if (customDataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowId = Convert.ToInt32(customDataGridView2.SelectedRows[0].Cells["IdColumn"].Value);

                // Отримуємо дані про виділений запис
                DataGridViewRow selectedRow = customDataGridView2.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["IdColumn"].Value);
                string model = selectedRow.Cells["ModelColumn"].Value?.ToString();
                string client = selectedRow.Cells["ClientColumn"].Value?.ToString();
                string number = selectedRow.Cells["NumberColumn"].Value?.ToString();
                string service = selectedRow.Cells["ServiceColumn"].Value?.ToString();
                double cost = Convert.ToDouble(selectedRow.Cells["CostColumn"].Value);
                string date = selectedRow.Cells["DateColumn"].Value?.ToString();
                bool prepayment = Convert.ToBoolean(selectedRow.Cells["PrepaymentColumn"].Value);

                // Переносимо запис до CompletedOrders
                dbHelper.InsertCompletedOrder(id, model, client, number, service, cost, date, prepayment);

                // Видаляємо запис з CurrentOrders
                dbHelper.DeleteOrder(selectedRowId);

                // Оновлюємо дані у відповідних таблицях
                LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
                LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());

                MessageBox.Show("Заявку успішно переміщено до виконаних!");
            }
            else
            {
                MessageBox.Show("Виберіть заявку для переміщення!");
            }
        }

        private void скасуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (previousState != null)
            {
                dbHelper.RestoreBuff();
                LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
                LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());
                MessageBox.Show("Операцію скасовано!");
                previousState = null;
            }
            else
            {
                MessageBox.Show("Немає дій для скасування!");
            }
        }

        // Прапор для визначення,  відображаються поточні чи виконані заявки
        private bool CompletedOrNo = false;

        private void поточніЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Завантаження даних поточних заявок до обох DataGridView
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());

            // Включення кнопок збереження, видалення та виконання
            materialButtonSave.Enabled = true;
            materialButtonDelete.Enabled = true;
            materialButtonComplete.Enabled = true;

            // Встановлення прапора на поточні заявки
            CompletedOrNo = false;
        }

        private void виконаніЗаявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCompletedOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCompletedOrders());

            materialButtonSave.Enabled = false;
            materialButtonDelete.Enabled = false;
            materialButtonComplete.Enabled = false;

            CompletedOrNo = true;
        }

        private void textBoxSearch1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch1.Text;
            if (CompletedOrNo == false)
            {
                // Виклик методу для пошуку у базі даних
                DataTable searchResults = dbHelper.SearchOrders(searchQuery);

                // Відображення результатів пошуку у DataGridView
                LoadDataIntoDataGridView(customDataGridView1, searchResults);
            }
            else
            {
                // Виклик методу для пошуку у базі даних
                DataTable searchResults = dbHelper.SearchCompletedOrders(searchQuery);

                // Відображення результатів пошуку у DataGridView
                LoadDataIntoDataGridView(customDataGridView1, searchResults);
            }
        }

        private void textBoxSearch2_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch2.Text;
            if (CompletedOrNo == false)
            {
                DataTable searchResults = dbHelper.SearchOrders(searchQuery);

                LoadDataIntoDataGridView(customDataGridView2, searchResults);
            }
            else
            {
                DataTable searchResults = dbHelper.SearchCompletedOrders(searchQuery);

                LoadDataIntoDataGridView(customDataGridView2, searchResults);
            }
        }

        private void очиститиПоточніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            dbHelper.ClearCurrentOrders();

            // Оновлення відображення даних у таблиці після очищення
            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());

            MessageBox.Show("База даних успішно очищена!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void очиститиВиконаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            dbHelper.ClearCompletedOrders();

            LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCompletedOrders());
            LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCompletedOrders());

            MessageBox.Show("База даних успішно очищена!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void експортуватиПоточніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з бази даних Orders
            DataTable currentOrdersTable = dbHelper.GetCurrentOrders();

            // Перевіряємо, чи отримано дані
            if (currentOrdersTable != null && currentOrdersTable.Rows.Count > 0)
            {
                // Створюємо новий файл Excel з ClosedXML
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("CurrentOrders");

                    // Додаємо заголовки
                    for (int i = 0; i < currentOrdersTable.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = currentOrdersTable.Columns[i].ColumnName;
                    }

                    // Додаємо дані
                    for (int i = 0; i < currentOrdersTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < currentOrdersTable.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = currentOrdersTable.Rows[i][j].ToString();
                        }
                    }

                    // Зберігаємо файл Excel з іменем Orders.xlsx
                    workbook.SaveAs("Export/CurrentOrders.xlsx");
                }

                MessageBox.Show("Базу даних Orders успішно експортовано в файл CurrentOrders.xlsx!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Немає даних для експортування!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void експортуватиВиконаніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable completedOrdersTable = dbHelper.GetCompletedOrders();

            if (completedOrdersTable != null && completedOrdersTable.Rows.Count > 0)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("CompletedOrders");

                    for (int i = 0; i < completedOrdersTable.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = completedOrdersTable.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < completedOrdersTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < completedOrdersTable.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = completedOrdersTable.Rows[i][j].ToString();
                        }
                    }

                    workbook.SaveAs("Export/CompletedOrders.xlsx");
                }

                MessageBox.Show("Базу даних CompletedOrders успішно експортовано в файл CompletedOrders.xlsx!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Немає даних для експортування!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void створитиРезервнуКопіюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbHelper.CreateBackup();
            MessageBox.Show("Резервну копію успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр класу OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Встановлюємо фільтр файлів для відображення тільки файлів баз даних SQLite
            openFileDialog.Filter = "SQLite Database Files (*.db)|*.db|All files (*.*)|*.*";

            // Відображаємо діалогове вікно вибору файлу
            DialogResult result = openFileDialog.ShowDialog();

            // Перевіряємо, чи користувач вибрав файл та чи натиснув він кнопку "OK"
            if (result == DialogResult.OK)
            {
                // Отримуємо шлях до вибраного файлу
                string selectedFilePath = openFileDialog.FileName;

                // Шлях до папки проекту
                string projectFolder = AppDomain.CurrentDomain.BaseDirectory;

                // Шлях до файлу Orders в папці проекту
                string ordersDbPath = Path.Combine(projectFolder, "Orders.db");

                if (dbHelper.IsValidDatabase(selectedFilePath))
                {
                    try
                    {
                        // Копіюємо обраний файл до папки проекту та перейменовуємо його у Orders.db
                        File.Copy(selectedFilePath, ordersDbPath, true);

                        // Підключаємося до нової бази даних
                        dbHelper.ConnectToDatabase(ordersDbPath);

                        // Оновлюємо дані у DataGridView
                        LoadDataIntoDataGridView(customDataGridView1, dbHelper.GetCurrentOrders());
                        LoadDataIntoDataGridView(customDataGridView2, dbHelper.GetCurrentOrders());

                        hasUnsavedChanges = false;

                        MessageBox.Show("Файл бази даних успішно замінено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        materialTabControl1.SelectedIndex = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при відкритті файлу бази даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Оберіть інший файл", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void customDataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Перевірка, чи помилка стосується стовпця "CostColumn"
            if (customDataGridView2.Columns[e.ColumnIndex].Name == "CostColumn")
            {
                // Виведення власного повідомлення про помилку
                MessageBox.Show("Некоректне значення у стовпці 'Вартість'. Будь ласка, введіть значення у правильному форматі.");

                // Вказуємо, що помилка оброблена
                e.ThrowException = false;
            }
        }

        // прапори для перевірки наявності не збережних даних
        private bool hasUnsavedChanges = false;

        private bool HasUnsavedTextBoxChanges()
        {
            return !string.IsNullOrEmpty(materialTextBoxModel.Text) ||
                   !string.IsNullOrEmpty(materialTextBoxName.Text) ||
                   !string.IsNullOrEmpty(materialTextBoxNumber.Text) ||
                   !string.IsNullOrEmpty(materialTextBoxCost.Text);
        }

        private void customDataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Встановлення значення у true щоб позначити дані як не збережені
            hasUnsavedChanges = true;
        }

        // Метод для збереження змін у базі даних
        private void SaveChanges()
        {
            // Збереження попереднього стану бази даних та створення резервної копії
            previousState = dbHelper.SaveState();
            dbHelper.CreateBuff();

            // Проходження по кожному рядку в DataGridView2
            foreach (DataGridViewRow row in customDataGridView2.Rows)
            {
                // Якщо рядок є новим, переходимо до наступного рядка
                if (row.IsNewRow) continue;

                // Отримання значень рядка
                int id = Convert.ToInt32(row.Cells["IdColumn"].Value);
                string model = row.Cells["ModelColumn"].Value?.ToString();
                string client = row.Cells["ClientColumn"].Value?.ToString();
                string number = row.Cells["NumberColumn"].Value?.ToString();
                string service = row.Cells["ServiceColumn"].Value?.ToString();
                double cost = Convert.ToDouble(row.Cells["CostColumn"].Value);
                string date = row.Cells["DateColumn"].Value?.ToString();
                bool prepayment = Convert.ToBoolean(row.Cells["PrepaymentColumn"].Value);

                // Оновлення замовлення в базі даних за вказаним id
                dbHelper.UpdateOrder(id, model, client, number, service, cost, date, prepayment);
            }
        }

        private bool hasDisplayedMessageBox = false;
        private void Diploma_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool hasUnsavedDataGridViewChanges = hasUnsavedChanges;
            bool hasUnsavedTextBoxChanges = HasUnsavedTextBoxChanges();

            if (hasUnsavedDataGridViewChanges)
            {
                DialogResult result = MessageBox.Show("Ви маєте незбережені дані у таблиці на сторінці редагування. При виході з програми вони будуть втрачені. Зберегти дані?",
                                                       "Увага!",
                                                       MessageBoxButtons.YesNoCancel,
                                                       MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // зберегти зміни
                    SaveChanges();
                    hasUnsavedChanges = false; // Скинути прапор після зберігання
                }
                else if (result == DialogResult.No)
                {
                    hasUnsavedChanges = false;
                }
                else if (result == DialogResult.Cancel)
                {
                    // Скасувати закриття форми
                    e.Cancel = true;
                    return;
                }
            }

            if (hasUnsavedTextBoxChanges)
            {
                if (!hasDisplayedMessageBox)
                {
                    materialTabControl1.SelectedIndex = 0;
                    DialogResult result = MessageBox.Show("Ви маєте незбережені дані на сторінці додавання заявки. При виході з програми вони будуть втрачені. Повернутися до програми?",
                                                           "Увага!",
                                                           MessageBoxButtons.YesNoCancel,
                                                           MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Відкрити першу сторінку
                        e.Cancel = true;
                    }
                    else if (result == DialogResult.No)
                    {
                        hasDisplayedMessageBox = true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Скасувати закриття форми
                        e.Cancel = true;
                    }
                }
                return;
            }
        }
    }
}