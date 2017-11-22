using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirRogue_alpha_v1._01.Shop;

namespace SirRogue_alpha_v1._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           //ONE handler for all
            NButton.Click += DirectionButtonClick;
            NEButton.Click += DirectionButtonClick;
            EButton.Click += DirectionButtonClick;
            SEButton.Click += DirectionButtonClick;
            SButton.Click += DirectionButtonClick;
            SWButton.Click += DirectionButtonClick;
            WButton.Click += DirectionButtonClick;
            NWButton.Click += DirectionButtonClick;

        }


        private void ShopButton_Click(object sender, EventArgs e)
        {
            //Open ShopForm
            //Send PlayersMoney To ShopForm
            ShopUI shopForm = new ShopUI();
            shopForm.ShowDialog();
        }

        private void TavernButton_Click(object sender, EventArgs e)
        {
            //Open TavernForm
        }

        void DirectionButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            
            MessageBox.Show($"Clicked on {button.Text}");

        }

    }
}
