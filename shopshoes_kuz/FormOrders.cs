using Microsoft.EntityFrameworkCore;
using shopshoes_kuz.Models;
using shopshoes_kuz.Properties;

namespace shopshoes_kuz
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 80;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDateDelivery = new DataGridViewTextBoxColumn();
            colDateDelivery.Name = "colDateDelivery";
            colDateDelivery.FillWeight = 20;
            colDateDelivery.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange(
            [
                colInfo, colDateDelivery
            ]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(i => i.ProductsOrders)
                        .ThenInclude(i => i.Product)
                        .Include(i => i.Status)
                        .Include(i => i.DeliveryPoint)
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colInfo"].Value = FormatOrderInfo(order);
                        row.Cells["colDateDelivery"].Value = $"{order.DeliveryDate}";
                        row.Cells["colDateDelivery"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string FormatOrderInfo(Order order)
        {
            var articleNumber = order.ProductsOrders
                .Select(s => s.Product.Art)
                .ToArray();
            string articleString = string.Join(", ", articleNumber);

            return $"Артикул: {articleString}" + Environment.NewLine +
                $"Статус заказа: {order.Status.StatusName}" + Environment.NewLine +
                $"Адрес пункта выдачи: {order.DeliveryPoint.DeliveryAddress}";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
