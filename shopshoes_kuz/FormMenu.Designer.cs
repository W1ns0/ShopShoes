namespace shopshoes_kuz
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblUserName = new Label();
            btnLogut = new Button();
            btnOrders = new Button();
            btnProducts = new Button();
            plMain = new Panel();
            panelTop.SuspendLayout();
            plMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogut);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(364, 40);
            panelTop.TabIndex = 2;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(169, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.BackColor = Color.MediumSpringGreen;
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(214, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(150, 30);
            btnLogut.TabIndex = 5;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogut_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Chartreuse;
            btnOrders.Dock = DockStyle.Bottom;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(10, 51);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(344, 30);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumSpringGreen;
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(10, 10);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(344, 30);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += BtnProducts_Click;
            // 
            // plMain
            // 
            plMain.Controls.Add(btnOrders);
            plMain.Controls.Add(btnProducts);
            plMain.Dock = DockStyle.Top;
            plMain.Location = new Point(10, 50);
            plMain.Name = "plMain";
            plMain.Padding = new Padding(10);
            plMain.Size = new Size(364, 91);
            plMain.TabIndex = 3;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 161);
            Controls.Add(plMain);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMenu";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            plMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Label lblUserName;
        private Button btnLogut;
        private Button btnOrders;
        private Button btnProducts;
        private Panel plMain;
    }
}