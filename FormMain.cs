using System.Runtime.CompilerServices;
using System.Text;

namespace RestourantApp
{
    public partial class FormMain : Form
    {
        private decimal totalPrice = 0;

        private Label? activeLabel = null;

        List<Article> articles = new List<Article>
        {
            new Article { Name = "ISTARSKA PLATA", Price = 1, Category = Category.Appetizer },
            new Article { Name = "NGA", Price = 0, Category = Category.Pasta },
            new Article { Name = "BO", Price = 100, Category = Category.Dessert },
            new Article { Name = "GOON", Price = 100, Category = Category.MainCourse },
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Panel CreateItem(string? name, decimal price, Category category)
            {
                Panel item = new Panel();
                item.Size = new Size(225, 200);
                item.BackColor = Color.FromArgb(248, 248, 248);
                item.Margin = new Padding(10);
                item.Tag = category;

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
                    Panel CreateOrderItem(string? name, decimal price)
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

                        Label labelQuantity = new Label();
                        labelQuantity.Text = "0";
                        labelQuantity.Size = new Size(30, 20);
                        labelQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelQuantity.ForeColor = Color.FromArgb(0, 168, 107);
                        labelQuantity.Location = new Point(188, 50);
                        labelQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelQuantity.BackColor = Color.FromArgb(248, 248, 248);

                        Label labelIncrementQuantity = new Label();
                        labelIncrementQuantity.Text = "+";
                        labelIncrementQuantity.Size = new Size(20, 20);
                        labelIncrementQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelIncrementQuantity.ForeColor = Color.FromArgb(248, 248, 248);
                        labelIncrementQuantity.Location = new Point(168, 50);
                        labelIncrementQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelIncrementQuantity.BackColor = Color.FromArgb(0, 168, 107);
                        labelIncrementQuantity.Cursor = Cursors.Hand;
                        labelIncrementQuantity.Click += (sender, e) =>
                        {
                            var quantity = int.Parse(labelQuantity.Text);

                            quantity++;
                            labelQuantity.Text = quantity.ToString();

                            labelPrice.Text = $"{price * quantity}€";
                            totalPrice += price;
                            var tax = totalPrice * .25m;
                            var priceOrder = totalPrice - tax;
                            labelTotalPriceNumber.Text = $"{totalPrice}€";
                            labelPriceNumber.Text = $"{priceOrder}€";
                            labelTaxNumber.Text = $"{tax}€";
                        };

                        Label labelDecrementQuantity = new Label();
                        labelDecrementQuantity.Text = "-";
                        labelDecrementQuantity.Size = new Size(20, 20);
                        labelDecrementQuantity.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                        labelDecrementQuantity.ForeColor = Color.FromArgb(248, 248, 248);
                        labelDecrementQuantity.Location = new Point(218, 50);
                        labelDecrementQuantity.TextAlign = ContentAlignment.MiddleCenter;
                        labelDecrementQuantity.BackColor = Color.FromArgb(0, 168, 107);
                        labelDecrementQuantity.Cursor = Cursors.Hand;
                        labelDecrementQuantity.Click += (sender, e) =>
                        {
                            var quantity = int.Parse(labelQuantity.Text);

                            if (quantity is not 0)
                            {
                                quantity--;
                                labelQuantity.Text = quantity.ToString();

                                labelPrice.Text = $"{price * quantity}€";
                                totalPrice -= price;
                                var tax = totalPrice * .25m;
                                var priceOrder = totalPrice - tax;
                                labelTotalPriceNumber.Text = $"{totalPrice}€";
                                labelPriceNumber.Text = $"{priceOrder}€";
                                labelTaxNumber.Text = $"{tax}€";
                            }
                        };

                        panel.Controls.Add(labelName);
                        panel.Controls.Add(labelPrice);
                        panel.Controls.Add(labelIncrementQuantity);
                        panel.Controls.Add(labelQuantity);
                        panel.Controls.Add(labelDecrementQuantity);

                        return panel;
                    }

                    Panel item = CreateOrderItem(name, price);
                    flowLayoutPanelOrder.Controls.Add(item);
                };

                item.Controls.Add(labelName);
                item.Controls.Add(labelPrice);
                item.Controls.Add(buttonAdd);

                return item;
            }

            foreach (var article in articles)
            {
                var item = CreateItem(article.Name, article.Price, article.Category);
                flowLayoutPanelMain.Controls.Add(item);
            }

            foreach (var control in panelNavigation.Controls)
            {
                if (control is Label label)
                {
                    label.Click += (sender, e) =>
                    {
                        if (label.Tag is string tag && Enum.TryParse<Category>(tag, out var category))
                        {
                            if (activeLabel == label)
                            {
                                foreach (Control control in panelNavigation.Controls)
                                {
                                    if (control is Label label)
                                    {
                                        label.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Regular);
                                    }
                                }

                                foreach (Control control in flowLayoutPanelMain.Controls)
                                {
                                    control.Visible = true;
                                }

                                activeLabel = null;
                                return;
                            }

                            foreach (Control control in panelNavigation.Controls)
                            {
                                if (control is Label label)
                                {
                                    label.Font = new Font("Microsoft YaHei UI", 12, FontStyle.Regular);
                                }
                            }

                            label.Font = new Font("Microsoft YaHei UI", 14, FontStyle.Bold);
                            activeLabel = label;

                            foreach (Control control in flowLayoutPanelMain.Controls)
                            {
                                if (control is Panel panel && panel.Tag is Category panelCategory)
                                {
                                    panel.Visible = panelCategory == category;
                                }
                            }
                        }
                    };
                }
            }
        }
    }
}
