namespace RestourantApp
{
    public partial class FormMain : Form
    {
        List<Article> articles = new List<Article>
        {
            new Article { Name = "ISTARSKA PLATA", Price = 1 },
            new Article { Name = "NGA", Price = 0 },
            new Article { Name = "BO", Price = 100 },
            new Article { Name = "GOON", Price = 100 },
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Panel CreateItem(string? name, decimal price)
            {
                Panel item = new Panel();
                item.Size = new Size(225, 200);
                item.BackColor = Color.FromArgb(248, 248, 248);
                item.Margin = new Padding(10);

                Label labelName = new Label();
                labelName.Text = name;
                labelName.TextAlign = ContentAlignment.MiddleLeft;
                labelName.Size = new Size(200, 20);
                labelName.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                labelName.Location = new Point(15, 135);

                Label labelPrice = new Label();
                labelPrice.Text = $"{price}€";
                labelPrice.TextAlign = ContentAlignment.MiddleCenter;
                labelPrice.Size = new Size(85, 30);
                labelPrice.Font = new Font("Microsoft YaHei UI", 16, FontStyle.Bold);
                labelPrice.Location = new Point(18, 160);
                labelPrice.BackColor = Color.FromArgb(0, 168, 107);

                Button buttonAdd = new Button();
                buttonAdd.Image = Image.FromFile("ic_add.png");
                buttonAdd.Size = new Size(25, 25);
                buttonAdd.Font = new Font("Microsoft YaHei UI", 16, FontStyle.Bold);
                buttonAdd.BackColor = Color.Transparent;
                buttonAdd.Location = new Point(180, 160);
                buttonAdd.Tag = (name, price);
                buttonAdd.FlatStyle = FlatStyle.Flat;
                buttonAdd.FlatAppearance.BorderSize = 0;
                buttonAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
                buttonAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
                buttonAdd.Cursor = Cursors.Hand;
                buttonAdd.Click += (sender, e) =>
                {
                    var button = (Button)sender;
                    var data = ((string name, decimal price))button.Tag;

                    Panel CreateOrderItem(string name, decimal price)
                    {
                        Panel panel = new Panel();
                        panel.Size = new Size(255, 80);
                        panel.BackColor = Color.FromArgb(18, 18, 18);

                        Label labelName = new Label();
                        labelName.Text = name;
                        labelName.Size = new Size(200, 20);
                        labelName.Font = new Font("Microsoft YaHei UI", 12);
                        labelName.ForeColor = Color.FromArgb(248, 248, 248);
                        labelName.Location = new Point(12, 15);
                        labelName.TextAlign = ContentAlignment.MiddleLeft;

                        Label labelPrice = new Label();
                        labelPrice.Text = $"{price}€";
                        labelPrice.Size = new Size(65, 25);
                        labelPrice.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
                        labelPrice.ForeColor = Color.FromArgb(248, 248, 248);
                        labelPrice.Location = new Point(15, 45);
                        labelPrice.TextAlign = ContentAlignment.MiddleCenter;
                        labelPrice.BackColor = Color.FromArgb(0, 168, 107);
                        labelPrice.Tag = price;

                        Label labelIncrementQuantity = new Label();
                        labelIncrementQuantity.Text = "+";
                        labelIncrementQuantity.Size = new Size(20, 20);
                        labelIncrementQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelIncrementQuantity.ForeColor = Color.FromArgb(248, 248, 248);
                        labelIncrementQuantity.Location = new Point(178, 50);
                        labelIncrementQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelIncrementQuantity.BackColor = Color.FromArgb(0, 168, 107);
                        labelIncrementQuantity.Cursor = Cursors.Hand;

                        Label labelQuantity = new Label();
                        labelQuantity.Text = "";
                        labelQuantity.Size = new Size(20, 20);
                        labelQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelQuantity.ForeColor = Color.FromArgb(0, 168, 107);
                        labelQuantity.Location = new Point(198, 50);
                        labelQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelQuantity.BackColor = Color.FromArgb(248, 248, 248);

                        Label labelDecrementQuantity = new Label();
                        labelDecrementQuantity.Text = "-";
                        labelDecrementQuantity.Size = new Size(20, 20);
                        labelDecrementQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelDecrementQuantity.ForeColor = Color.FromArgb(248, 248, 248);
                        labelDecrementQuantity.Location = new Point(218, 50);
                        labelDecrementQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelDecrementQuantity.BackColor = Color.FromArgb(0, 168, 107);
                        labelDecrementQuantity.Cursor = Cursors.Hand;

                        panel.Controls.Add(labelName);
                        panel.Controls.Add(labelPrice);
                        panel.Controls.Add(labelIncrementQuantity);
                        panel.Controls.Add(labelQuantity);
                        panel.Controls.Add(labelDecrementQuantity);

                        return panel;
                    }

                    Panel item = CreateOrderItem(data.name, data.price);
                    flowLayoutPanelOrder.Controls.Add(item);
                };

                item.Controls.Add(labelName);
                item.Controls.Add(labelPrice);
                item.Controls.Add(buttonAdd);

                return item;
            }

            foreach (var article in articles)
            {
                var item = CreateItem(article.Name, article.Price);
                flowLayoutPanelMain.Controls.Add(item);
            }
        }
    }
}
