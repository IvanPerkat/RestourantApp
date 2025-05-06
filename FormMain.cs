using System.Security.Cryptography.X509Certificates;

namespace RestourantApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<Article> articles = new List<Article>
            {
                new Article { Name = "ISTARSKA PLATA", Price = "10€" },
                new Article { Name = "VALENTINOVA MUDA", Price = "0€" },
                new Article { Name = "MARKOVA MUDA", Price = "100€" }
            };

            Panel Item(string name, string price)
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
                labelPrice.Text = price;
                labelPrice.TextAlign = ContentAlignment.MiddleCenter;
                labelPrice.Size = new Size(70, 30);
                labelPrice.Font = new Font("Microsoft YaHei UI", 16, FontStyle.Bold);
                labelPrice.Location = new Point(18, 160);
                labelPrice.BackColor = Color.FromArgb(0, 168, 107);

                item.Controls.Add(labelName);
                item.Controls.Add(labelPrice);

                return item;
            }

            foreach (var article in articles)
            {
                var item = Item(article.Name, article.Price);
                flowLayoutPanelMain.Controls.Add(item);
            }
        }
    }
}
