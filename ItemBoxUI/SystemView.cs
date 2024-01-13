using ItemLibraray;
using ItemLibraray.Models;
using System.Windows.Forms;

namespace ItemBoxUI
{
    public partial class SystemView : Form, IItemRequester
    {

        private List<ItemModel> items = new List<ItemModel>();
        private BindingSource bindingSource = new BindingSource();
        private SystemModel model;
        public SystemView(SystemModel systemModel)
        {
            InitializeComponent();
            this.model = systemModel;

            // Update System Name Label
            SystemNameLabel.Text = model.Name;

            LoadItemModels();

            HookUpItemList();
        }

        private void LoadItemModels()
        {
            items = GlobalConfig.Connection.GetItems_BySystemId(model.ID);
        }

        private void HookUpItemList()
        {
            bindingSource.DataSource = items;
            ItemListBox.DataSource = bindingSource;
            ItemListBox.DisplayMember = "Name";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SystemView_Load(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            CreateItemUI frm = new CreateItemUI(this, model.ID);
            frm.ShowDialog();
            //bindingSource.ResetBindings(false);
        }

        public void ItemComplete(ItemModel model)
        {
            items.Add(model);
            bindingSource.ResetBindings(false);
        }
    }
}
