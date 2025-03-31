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
            panel1 = new Panel();
            labelHeader = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            labelAppetizers = new Label();
            panelIstarskaPlata = new Panel();
            pictureBox2 = new PictureBox();
            buttonAdd = new Button();
            labelPricePlata = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panelIstarskaPlata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 52, 88);
            panel1.Controls.Add(labelHeader);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.FromArgb(241, 239, 236);
            labelHeader.Location = new Point(107, 22);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(218, 36);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Konoba Perkat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(712, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 52, 88);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 373);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(241, 239, 236);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(labelAppetizers);
            panel3.Controls.Add(panelIstarskaPlata);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(107, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(693, 373);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(3, 3, 3);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.FromArgb(3, 3, 3);
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(636, 3);
            label2.TabIndex = 2;
            // 
            // labelAppetizers
            // 
            labelAppetizers.AutoSize = true;
            labelAppetizers.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelAppetizers.ForeColor = Color.FromArgb(3, 3, 3);
            labelAppetizers.Location = new Point(16, 14);
            labelAppetizers.Name = "labelAppetizers";
            labelAppetizers.Size = new Size(76, 22);
            labelAppetizers.TabIndex = 1;
            labelAppetizers.Text = "Predjela";
            // 
            // panelIstarskaPlata
            // 
            panelIstarskaPlata.BackColor = Color.FromArgb(212, 201, 190);
            panelIstarskaPlata.Controls.Add(pictureBox2);
            panelIstarskaPlata.Controls.Add(buttonAdd);
            panelIstarskaPlata.Controls.Add(labelPricePlata);
            panelIstarskaPlata.Controls.Add(label1);
            panelIstarskaPlata.Location = new Point(16, 53);
            panelIstarskaPlata.Name = "panelIstarskaPlata";
            panelIstarskaPlata.Size = new Size(183, 161);
            panelIstarskaPlata.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(18, 52, 88);
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonAdd.ForeColor = Color.FromArgb(241, 239, 236);
            buttonAdd.Location = new Point(3, 132);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 26);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Naruči";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelPricePlata
            // 
            labelPricePlata.AutoSize = true;
            labelPricePlata.BackColor = Color.FromArgb(18, 52, 88);
            labelPricePlata.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelPricePlata.ForeColor = Color.FromArgb(241, 239, 236);
            labelPricePlata.Location = new Point(128, 96);
            labelPricePlata.Name = "labelPricePlata";
            labelPricePlata.Size = new Size(51, 28);
            labelPricePlata.TabIndex = 1;
            labelPricePlata.Text = "50€";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(3, 3, 3);
            label1.Location = new Point(3, 96);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 0;
            label1.Text = "Istarska Plata";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Restourant";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelIstarskaPlata.ResumeLayout(false);
            panelIstarskaPlata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelHeader;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panelIstarskaPlata;
        private Label label1;
        private Label labelPricePlata;
        private Button buttonAdd;
        private PictureBox pictureBox2;
        private Label labelAppetizers;
        private Label label2;
    }
}
