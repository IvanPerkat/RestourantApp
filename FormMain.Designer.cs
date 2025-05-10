namespace RestourantApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelNavigation = new Panel();
            labelPasta = new Label();
            labelDessert = new Label();
            labelMainCourse = new Label();
            labelAppetizer = new Label();
            pictureBoxLogo = new PictureBox();
            labelTotalPriceNumber = new Label();
            labelTotalPrice = new Label();
            buttonOrder = new Button();
            flowLayoutPanelMain = new FlowLayoutPanel();
            flowLayoutPanelOrder = new FlowLayoutPanel();
            label10 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            labelTax = new Label();
            labelPrice = new Label();
            labelPriceNumber = new Label();
            labelTaxNumber = new Label();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(18, 18, 18);
            panelNavigation.Controls.Add(labelPasta);
            panelNavigation.Controls.Add(labelDessert);
            panelNavigation.Controls.Add(labelMainCourse);
            panelNavigation.Controls.Add(labelAppetizer);
            panelNavigation.Controls.Add(pictureBoxLogo);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(200, 611);
            panelNavigation.TabIndex = 1;
            // 
            // labelPasta
            // 
            labelPasta.AutoSize = true;
            labelPasta.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPasta.ForeColor = Color.FromArgb(248, 248, 248);
            labelPasta.Location = new Point(33, 203);
            labelPasta.Name = "labelPasta";
            labelPasta.Size = new Size(87, 21);
            labelPasta.TabIndex = 5;
            labelPasta.Tag = "Pasta";
            labelPasta.Text = "Tjestenine";
            // 
            // labelDessert
            // 
            labelDessert.AutoSize = true;
            labelDessert.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelDessert.ForeColor = Color.FromArgb(248, 248, 248);
            labelDessert.Location = new Point(33, 294);
            labelDessert.Name = "labelDessert";
            labelDessert.Size = new Size(63, 21);
            labelDessert.TabIndex = 4;
            labelDessert.Tag = "Dessert";
            labelDessert.Text = "Deserti";
            // 
            // labelMainCourse
            // 
            labelMainCourse.AutoSize = true;
            labelMainCourse.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelMainCourse.ForeColor = Color.FromArgb(248, 248, 248);
            labelMainCourse.Location = new Point(33, 250);
            labelMainCourse.Name = "labelMainCourse";
            labelMainCourse.Size = new Size(93, 21);
            labelMainCourse.TabIndex = 3;
            labelMainCourse.Tag = "MainCourse";
            labelMainCourse.Text = "Glavna jela";
            // 
            // labelAppetizer
            // 
            labelAppetizer.AutoSize = true;
            labelAppetizer.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelAppetizer.ForeColor = Color.FromArgb(248, 248, 248);
            labelAppetizer.Location = new Point(33, 157);
            labelAppetizer.Name = "labelAppetizer";
            labelAppetizer.Size = new Size(71, 21);
            labelAppetizer.TabIndex = 2;
            labelAppetizer.Tag = "Appetizer";
            labelAppetizer.Text = "Predjela";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(8, 15);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(194, 71);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // labelTotalPriceNumber
            // 
            labelTotalPriceNumber.AutoSize = true;
            labelTotalPriceNumber.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTotalPriceNumber.ForeColor = Color.FromArgb(0, 168, 107);
            labelTotalPriceNumber.Location = new Point(190, 87);
            labelTotalPriceNumber.Name = "labelTotalPriceNumber";
            labelTotalPriceNumber.Size = new Size(60, 21);
            labelTotalPriceNumber.TabIndex = 2;
            labelTotalPriceNumber.Text = "          ";
            labelTotalPriceNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTotalPrice.ForeColor = Color.FromArgb(0, 168, 107);
            labelTotalPrice.Location = new Point(18, 87);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(75, 21);
            labelTotalPrice.TabIndex = 1;
            labelTotalPrice.Text = "Ukupno:";
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.FromArgb(0, 168, 107);
            buttonOrder.Dock = DockStyle.Bottom;
            buttonOrder.FlatAppearance.BorderColor = Color.FromArgb(18, 18, 18);
            buttonOrder.FlatAppearance.BorderSize = 0;
            buttonOrder.FlatStyle = FlatStyle.Flat;
            buttonOrder.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonOrder.ForeColor = Color.FromArgb(248, 248, 248);
            buttonOrder.Location = new Point(0, 124);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(265, 40);
            buttonOrder.TabIndex = 1;
            buttonOrder.Text = "Naruči";
            buttonOrder.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.AutoScroll = true;
            flowLayoutPanelMain.BackColor = Color.FromArgb(28, 28, 28);
            flowLayoutPanelMain.Location = new Point(200, 0);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Padding = new Padding(0, 20, 0, 0);
            flowLayoutPanelMain.Size = new Size(737, 611);
            flowLayoutPanelMain.TabIndex = 4;
            // 
            // flowLayoutPanelOrder
            // 
            flowLayoutPanelOrder.BackColor = Color.FromArgb(18, 18, 18);
            flowLayoutPanelOrder.Location = new Point(937, 54);
            flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            flowLayoutPanelOrder.Size = new Size(262, 398);
            flowLayoutPanelOrder.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label10.ForeColor = Color.FromArgb(248, 248, 248);
            label10.Location = new Point(13, 15);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 4;
            label10.Text = "Narudžba";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(937, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 56);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 18, 18);
            panel3.Controls.Add(labelTax);
            panel3.Controls.Add(labelPrice);
            panel3.Controls.Add(buttonOrder);
            panel3.Controls.Add(labelTotalPrice);
            panel3.Controls.Add(labelPriceNumber);
            panel3.Controls.Add(labelTaxNumber);
            panel3.Controls.Add(labelTotalPriceNumber);
            panel3.Location = new Point(937, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 164);
            panel3.TabIndex = 6;
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelTax.ForeColor = Color.FromArgb(248, 248, 248);
            labelTax.Location = new Point(18, 46);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(36, 19);
            labelTax.TabIndex = 4;
            labelTax.Text = "PDV";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPrice.ForeColor = Color.FromArgb(248, 248, 248);
            labelPrice.Location = new Point(18, 15);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 19);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "CIjena";
            // 
            // labelPriceNumber
            // 
            labelPriceNumber.AutoSize = true;
            labelPriceNumber.Font = new Font("Microsoft YaHei UI", 9.75F);
            labelPriceNumber.ForeColor = Color.FromArgb(248, 248, 248);
            labelPriceNumber.Location = new Point(190, 15);
            labelPriceNumber.Name = "labelPriceNumber";
            labelPriceNumber.Size = new Size(49, 19);
            labelPriceNumber.TabIndex = 2;
            labelPriceNumber.Text = "          ";
            labelPriceNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTaxNumber
            // 
            labelTaxNumber.AutoSize = true;
            labelTaxNumber.Font = new Font("Microsoft YaHei UI", 9.75F);
            labelTaxNumber.ForeColor = Color.FromArgb(248, 248, 248);
            labelTaxNumber.Location = new Point(190, 46);
            labelTaxNumber.Name = "labelTaxNumber";
            labelTaxNumber.Size = new Size(49, 19);
            labelTaxNumber.TabIndex = 2;
            labelTaxNumber.Text = "          ";
            labelTaxNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 611);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanelOrder);
            Controls.Add(flowLayoutPanelMain);
            Controls.Add(panelNavigation);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Restourant";
            Load += FormMain_Load;
            panelNavigation.ResumeLayout(false);
            panelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNavigation;
        private PictureBox pictureBoxLogo;
        private Label labelDessert;
        private Label labelMainCourse;
        private Label labelAppetizer;
        private Label labelPasta;
        private Label labelTotalPriceNumber;
        private Label labelTotalPrice;
        private Button buttonOrder;
        private FlowLayoutPanel flowLayoutPanelMain;
        private FlowLayoutPanel flowLayoutPanelOrder;
        private Label label10;
        private Panel panel2;
        private Panel panel3;
        private Label labelTax;
        private Label labelPrice;
        private Label labelPriceNumber;
        private Label labelTaxNumber;
    }
}
