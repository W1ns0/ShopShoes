using shopshoes_kuz.Models;

namespace shopshoes_kuz
{
    public partial class FormMenu : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormMenu(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            using (var formProducts = new FormProducts(CurrentUser, IsGuest))
            {
                formProducts.ShowDialog();
            }
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            using (var formOrders = new FormOrders(CurrentUser, IsGuest))
            {
                formOrders.ShowDialog();
            }
        }
    }
}
