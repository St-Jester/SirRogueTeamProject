using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirRogue_alpha_v1._01.Shop.DataStub;

namespace SirRogue_alpha_v1._01.Shop
{
    public partial class ShopUI : Form
    {
        DataManagerStub dms;

        public ShopUI()
        {
            InitializeComponent();

            dms = new DataManagerStub();
            storeLstBox.DataSource = dms.Store.GetStringList();
        }

        private void storeLstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstBox = sender as ListBox;
            Item item = dms.Store.Items[lstBox.SelectedIndex];

            this.nameLbl.Text = item.Name;
            this.typeLbl.Text = item.Type.ToString();
            this.modifierLbl.Text = item.Modifier.ToString();
            this.roleLbl.Text = item.Role.ToString();
            this.priceLbl.Text = item.Price.ToString();

            SetBuyButtonEnabledProperty();
        }

        private void SetBuyButtonEnabledProperty()
        {
            Item item = dms.Store.Items[storeLstBox.SelectedIndex];
            if (item.Price > dms.Wallet.Money)
                this.buyBtn.Enabled = false;
            else
                this.buyBtn.Enabled = true;
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            Item item = dms.Store.Items[storeLstBox.SelectedIndex];
            dms.Wallet.Money -= item.Price;
            dms.Inventory.Items.Add(item);
            SetBuyButtonEnabledProperty();

            // for buyButton working demonstration only
            ShowDebuggingInfo();
        }

        // for buyButton working demonstration only
        private void ShowDebuggingInfo()
        {
            string info = $"Info: Wallet.Money equals {dms.Wallet.Money.ToString()} now.\n\r";
            info += $"Buyed item added to inventory.\n\r";
            info += $"\n\r";
            info += $"Inventory list:\n\r";
            foreach (Item item in dms.Inventory.Items)
                info += $"{item.Name}\n\r";

            MessageBox.Show(info);
        }
    }
}
