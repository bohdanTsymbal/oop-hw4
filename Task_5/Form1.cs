namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 11;

            dataGridView1.Columns[0].Name = "Ціна";
            dataGridView1.Columns[1].Name = "Країна походження";
            dataGridView1.Columns[2].Name = "Назва";
            dataGridView1.Columns[3].Name = "Дата пакування";
            dataGridView1.Columns[4].Name = "Опис";
            dataGridView1.Columns[5].Name = "Термін придатності";
            dataGridView1.Columns[6].Name = "Кількість";
            dataGridView1.Columns[7].Name = "Одиниця виміру";
            dataGridView1.Columns[8].Name = "Кількість сторінок";
            dataGridView1.Columns[9].Name = "Видавництво";
            dataGridView1.Columns[10].Name = "Перелік авторів";
        }

        private void PopulateDataGridView()
        {
            List<Good> goods = new List<Good>()
            {
                new Product(95.50, "England", "Cheese", "27-10-2022", "Parmesan", "03-11-2022", 4.5, "kg"),
                new Book(101, "Ukraine", "Kobzar", "25-10-2022", "Katerina, etc.", 234, "Svitanok", "Taras Shevchenko"),
                new Product(55, "USA", "Potatoes", "19-10-2022", "Sweet", "01-10-2023", 123, "kg"),
            };


            foreach (var good in goods)
            {
                if (good is Product product) dataGridView1.Rows.Add(FormatDataGridViewRow(product));
                else if (good is Book book) dataGridView1.Rows.Add(FormatDataGridViewRow(book));
                else dataGridView1.Rows.Add(FormatDataGridViewRow(good));
            }
        }

        private string[] FormatDataGridViewRow(Good good)
        {
            return new string[] { good.Price.ToString(), good.OriginCountry, good.Name, good.PackingDate, good.Description };
        }

        private string[] FormatDataGridViewRow(Product good)
        {
            return FormatDataGridViewRow((Good)good).Concat(new string[] {
            good.ExpiryDate, good.Quantity.ToString(), good.MeasurementUnit, "-", "-", "-" }).ToArray();
        }

        private string[] FormatDataGridViewRow(Book good)
        {
            return FormatDataGridViewRow((Good)good).Concat(new string[] {
                "-", "-", "-", good.PagesNumber.ToString(), good.Publisher, good.Authors }).ToArray();
        }

        private void ClearProductInputs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void ClearBookInputs()
        {
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            if (dataGridView1.Rows.Count == 0) button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages[0])
                {
                    Product newProduct = new(double.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text,
                        textBox5.Text, textBox11.Text, double.Parse(textBox12.Text), textBox13.Text);
                    dataGridView1.Rows.Add(FormatDataGridViewRow(newProduct));

                    ClearProductInputs();
                }

                if (tabControl1.SelectedTab == tabControl1.TabPages[1])
                {
                    Book newBook = new(double.Parse(textBox10.Text), textBox9.Text, textBox8.Text, textBox7.Text,
                        textBox6.Text, int.Parse(textBox16.Text), textBox15.Text, textBox14.Text);
                    dataGridView1.Rows.Add(FormatDataGridViewRow(newBook));

                    ClearBookInputs();
                }

                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}