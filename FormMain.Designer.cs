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
            labelSoups = new Label();
            labelDessert = new Label();
            labelMainCourse = new Label();
            labelHotAppetizers = new Label();
            labelColdAppetizers = new Label();
            pictureBoxLogo = new PictureBox();
            labelTotalPriceNumber = new Label();
            labelTotalPrice = new Label();
            buttonOrder = new Button();
            flowLayoutPanelMain = new FlowLayoutPanel();
            flowLayoutPanelOrder = new FlowLayoutPanel();
            label10 = new Label();
            panelOrderTItle = new Panel();
            panelOrderPrice = new Panel();
            labelTax = new Label();
            labelPrice = new Label();
            labelPriceNumber = new Label();
            labelTaxNumber = new Label();
            panelOrder = new Panel();
            panelOrderDetails = new Panel();
            comboBoxPaymentMethod = new ComboBox();
            buttonOrderFinal = new Button();
            textBoxAdrress = new TextBox();
            labelPaymentMethod = new Label();
            labelAdrress = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            textBoxSurename = new TextBox();
            labelSurename = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            labelOrderDetails = new Label();
            pictureBoxLogoBig = new PictureBox();
            panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelOrderTItle.SuspendLayout();
            panelOrderPrice.SuspendLayout();
            panelOrder.SuspendLayout();
            panelOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoBig).BeginInit();
            SuspendLayout();
            // 
            // panelNavigation
            // 
            panelNavigation.BackColor = Color.FromArgb(18, 18, 18);
            panelNavigation.Controls.Add(labelSoups);
            panelNavigation.Controls.Add(labelDessert);
            panelNavigation.Controls.Add(labelMainCourse);
            panelNavigation.Controls.Add(labelHotAppetizers);
            panelNavigation.Controls.Add(labelColdAppetizers);
            panelNavigation.Controls.Add(pictureBoxLogo);
            panelNavigation.Dock = DockStyle.Left;
            panelNavigation.Location = new Point(0, 0);
            panelNavigation.Name = "panelNavigation";
            panelNavigation.Size = new Size(200, 611);
            panelNavigation.TabIndex = 1;
            // 
            // labelSoups
            // 
            labelSoups.AutoSize = true;
            labelSoups.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSoups.ForeColor = Color.FromArgb(248, 248, 248);
            labelSoups.Location = new Point(33, 203);
            labelSoups.Name = "labelSoups";
            labelSoups.Size = new Size(45, 21);
            labelSoups.TabIndex = 5;
            labelSoups.Tag = "Soup";
            labelSoups.Text = "Juhe";
            // 
            // labelDessert
            // 
            labelDessert.AutoSize = true;
            labelDessert.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelDessert.ForeColor = Color.FromArgb(248, 248, 248);
            labelDessert.Location = new Point(33, 336);
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
            labelMainCourse.Location = new Point(33, 292);
            labelMainCourse.Name = "labelMainCourse";
            labelMainCourse.Size = new Size(93, 21);
            labelMainCourse.TabIndex = 3;
            labelMainCourse.Tag = "MainCourse";
            labelMainCourse.Text = "Glavna jela";
            // 
            // labelHotAppetizers
            // 
            labelHotAppetizers.AutoSize = true;
            labelHotAppetizers.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelHotAppetizers.ForeColor = Color.FromArgb(248, 248, 248);
            labelHotAppetizers.Location = new Point(33, 249);
            labelHotAppetizers.Name = "labelHotAppetizers";
            labelHotAppetizers.Size = new Size(118, 21);
            labelHotAppetizers.TabIndex = 2;
            labelHotAppetizers.Tag = "HotAppetizer";
            labelHotAppetizers.Text = "Topla Predjela";
            // 
            // labelColdAppetizers
            // 
            labelColdAppetizers.AutoSize = true;
            labelColdAppetizers.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelColdAppetizers.ForeColor = Color.FromArgb(248, 248, 248);
            labelColdAppetizers.Location = new Point(33, 157);
            labelColdAppetizers.Name = "labelColdAppetizers";
            labelColdAppetizers.Size = new Size(130, 21);
            labelColdAppetizers.TabIndex = 2;
            labelColdAppetizers.Tag = "ColdAppetizer";
            labelColdAppetizers.Text = "Hladna Predjela";
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
            buttonOrder.Size = new Size(284, 40);
            buttonOrder.TabIndex = 1;
            buttonOrder.Text = "Naruči";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.AutoScroll = true;
            flowLayoutPanelMain.BackColor = Color.FromArgb(28, 28, 28);
            flowLayoutPanelMain.Location = new Point(200, 0);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Padding = new Padding(0, 20, 0, 0);
            flowLayoutPanelMain.Size = new Size(772, 611);
            flowLayoutPanelMain.TabIndex = 4;
            // 
            // flowLayoutPanelOrder
            // 
            flowLayoutPanelOrder.BackColor = Color.FromArgb(18, 18, 18);
            flowLayoutPanelOrder.Location = new Point(933, 54);
            flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            flowLayoutPanelOrder.Size = new Size(284, 398);
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
            // panelOrderTItle
            // 
            panelOrderTItle.BackColor = Color.FromArgb(18, 18, 18);
            panelOrderTItle.Controls.Add(label10);
            panelOrderTItle.Location = new Point(933, 0);
            panelOrderTItle.Name = "panelOrderTItle";
            panelOrderTItle.Size = new Size(284, 56);
            panelOrderTItle.TabIndex = 5;
            // 
            // panelOrderPrice
            // 
            panelOrderPrice.BackColor = Color.FromArgb(18, 18, 18);
            panelOrderPrice.Controls.Add(labelTax);
            panelOrderPrice.Controls.Add(labelPrice);
            panelOrderPrice.Controls.Add(buttonOrder);
            panelOrderPrice.Controls.Add(labelTotalPrice);
            panelOrderPrice.Controls.Add(labelPriceNumber);
            panelOrderPrice.Controls.Add(labelTaxNumber);
            panelOrderPrice.Controls.Add(labelTotalPriceNumber);
            panelOrderPrice.Location = new Point(933, 447);
            panelOrderPrice.Name = "panelOrderPrice";
            panelOrderPrice.Size = new Size(284, 164);
            panelOrderPrice.TabIndex = 6;
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
            labelPrice.Size = new Size(66, 19);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Osnovica";
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
            // panelOrder
            // 
            panelOrder.BackColor = Color.FromArgb(28, 28, 28);
            panelOrder.Controls.Add(panelOrderDetails);
            panelOrder.Controls.Add(pictureBoxLogoBig);
            panelOrder.Location = new Point(0, 0);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(1217, 611);
            panelOrder.TabIndex = 7;
            // 
            // panelOrderDetails
            // 
            panelOrderDetails.BackColor = Color.FromArgb(18, 18, 18);
            panelOrderDetails.Controls.Add(comboBoxPaymentMethod);
            panelOrderDetails.Controls.Add(buttonOrderFinal);
            panelOrderDetails.Controls.Add(textBoxAdrress);
            panelOrderDetails.Controls.Add(labelPaymentMethod);
            panelOrderDetails.Controls.Add(labelAdrress);
            panelOrderDetails.Controls.Add(textBoxPhoneNumber);
            panelOrderDetails.Controls.Add(labelPhoneNumber);
            panelOrderDetails.Controls.Add(textBoxSurename);
            panelOrderDetails.Controls.Add(labelSurename);
            panelOrderDetails.Controls.Add(textBoxName);
            panelOrderDetails.Controls.Add(labelName);
            panelOrderDetails.Controls.Add(labelOrderDetails);
            panelOrderDetails.Dock = DockStyle.Left;
            panelOrderDetails.Location = new Point(0, 0);
            panelOrderDetails.Name = "panelOrderDetails";
            panelOrderDetails.Size = new Size(437, 611);
            panelOrderDetails.TabIndex = 2;
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(53, 396);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(261, 23);
            comboBoxPaymentMethod.TabIndex = 7;
            // 
            // buttonOrderFinal
            // 
            buttonOrderFinal.BackColor = Color.FromArgb(0, 168, 107);
            buttonOrderFinal.Dock = DockStyle.Bottom;
            buttonOrderFinal.FlatAppearance.BorderColor = Color.FromArgb(18, 18, 18);
            buttonOrderFinal.FlatAppearance.BorderSize = 0;
            buttonOrderFinal.FlatStyle = FlatStyle.Flat;
            buttonOrderFinal.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            buttonOrderFinal.ForeColor = Color.FromArgb(248, 248, 248);
            buttonOrderFinal.Location = new Point(0, 571);
            buttonOrderFinal.Name = "buttonOrderFinal";
            buttonOrderFinal.Size = new Size(437, 40);
            buttonOrderFinal.TabIndex = 6;
            buttonOrderFinal.Text = "Naruči";
            buttonOrderFinal.UseVisualStyleBackColor = false;
            buttonOrderFinal.Click += buttonOrderFinal_Click;
            // 
            // textBoxAdrress
            // 
            textBoxAdrress.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAdrress.Location = new Point(53, 316);
            textBoxAdrress.Name = "textBoxAdrress";
            textBoxAdrress.Size = new Size(261, 24);
            textBoxAdrress.TabIndex = 5;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.AutoSize = true;
            labelPaymentMethod.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPaymentMethod.ForeColor = Color.FromArgb(248, 248, 248);
            labelPaymentMethod.Location = new Point(53, 374);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(99, 19);
            labelPaymentMethod.TabIndex = 4;
            labelPaymentMethod.Text = "Način plaćanja";
            // 
            // labelAdrress
            // 
            labelAdrress.AutoSize = true;
            labelAdrress.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelAdrress.ForeColor = Color.FromArgb(248, 248, 248);
            labelAdrress.Location = new Point(53, 294);
            labelAdrress.Name = "labelAdrress";
            labelAdrress.Size = new Size(121, 19);
            labelAdrress.TabIndex = 4;
            labelAdrress.Text = "Adresa stanovanja";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhoneNumber.Location = new Point(53, 246);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(261, 24);
            textBoxPhoneNumber.TabIndex = 5;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelPhoneNumber.ForeColor = Color.FromArgb(248, 248, 248);
            labelPhoneNumber.Location = new Point(53, 224);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(90, 19);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Broj mobitela";
            // 
            // textBoxSurename
            // 
            textBoxSurename.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSurename.Location = new Point(53, 176);
            textBoxSurename.Name = "textBoxSurename";
            textBoxSurename.Size = new Size(261, 24);
            textBoxSurename.TabIndex = 5;
            // 
            // labelSurename
            // 
            labelSurename.AutoSize = true;
            labelSurename.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelSurename.ForeColor = Color.FromArgb(248, 248, 248);
            labelSurename.Location = new Point(53, 154);
            labelSurename.Name = "labelSurename";
            labelSurename.Size = new Size(57, 19);
            labelSurename.TabIndex = 4;
            labelSurename.Text = "Prezime";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(53, 111);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(261, 24);
            textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelName.ForeColor = Color.FromArgb(248, 248, 248);
            labelName.Location = new Point(53, 89);
            labelName.Name = "labelName";
            labelName.Size = new Size(32, 19);
            labelName.TabIndex = 4;
            labelName.Text = "Ime";
            // 
            // labelOrderDetails
            // 
            labelOrderDetails.AutoSize = true;
            labelOrderDetails.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelOrderDetails.ForeColor = Color.FromArgb(248, 248, 248);
            labelOrderDetails.Location = new Point(33, 31);
            labelOrderDetails.Name = "labelOrderDetails";
            labelOrderDetails.Size = new Size(174, 25);
            labelOrderDetails.TabIndex = 4;
            labelOrderDetails.Text = "Detalji o narudžbi";
            // 
            // pictureBoxLogoBig
            // 
            pictureBoxLogoBig.Image = (Image)resources.GetObject("pictureBoxLogoBig.Image");
            pictureBoxLogoBig.Location = new Point(634, 203);
            pictureBoxLogoBig.Name = "pictureBoxLogoBig";
            pictureBoxLogoBig.Size = new Size(413, 158);
            pictureBoxLogoBig.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoBig.TabIndex = 1;
            pictureBoxLogoBig.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 611);
            Controls.Add(panelOrder);
            Controls.Add(panelOrderPrice);
            Controls.Add(panelOrderTItle);
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
            panelOrderTItle.ResumeLayout(false);
            panelOrderTItle.PerformLayout();
            panelOrderPrice.ResumeLayout(false);
            panelOrderPrice.PerformLayout();
            panelOrder.ResumeLayout(false);
            panelOrderDetails.ResumeLayout(false);
            panelOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoBig).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNavigation;
        private PictureBox pictureBoxLogo;
        private Label labelDessert;
        private Label labelMainCourse;
        private Label labelColdAppetizers;
        private Label labelSoups;
        private Label labelTotalPriceNumber;
        private Label labelTotalPrice;
        private Button buttonOrder;
        private FlowLayoutPanel flowLayoutPanelMain;
        private FlowLayoutPanel flowLayoutPanelOrder;
        private Label label10;
        private Panel panelOrderTItle;
        private Panel panelOrderPrice;
        private Label labelTax;
        private Label labelPrice;
        private Label labelPriceNumber;
        private Label labelTaxNumber;
        private Label labelHotAppetizers;
        private Panel panelOrder;
        private Panel panelOrderDetails;
        private PictureBox pictureBoxLogoBig;
        private Label labelOrderDetails;
        private TextBox textBoxName;
        private Button buttonOrderFinal;
        private ComboBox comboBoxPaymentMethod;
        private TextBox textBoxAdrress;
        private Label labelPaymentMethod;
        private Label labelAdrress;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private TextBox textBoxSurename;
        private Label labelSurename;
        private Label labelName;
    }
}
