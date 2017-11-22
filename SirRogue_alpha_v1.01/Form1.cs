using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirRogue_alpha_v1._01
{
    public partial class Form1 : Form
    {
        List<Button> DirectionButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            DirectionButtons.Add(NButton);
            DirectionButtons.Add(NEButton);
            DirectionButtons.Add(EButton);
            DirectionButtons.Add(SEButton);
            DirectionButtons.Add(SButton);
            DirectionButtons.Add(SWButton);
            DirectionButtons.Add(WButton);
            DirectionButtons.Add(NWButton);

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
        public void JournalUpdate(Quest q)//called twice - when first accepted and when accomplished
        {
            if(q.Completed)
            {
                CompletedQuests.Items.Add(q.Title);
                return;
            }
            else
            {
                if(CurrentQuest.Text != null)//This one sucks
                {
                    MessageBox.Show("Already have quest!");
                    return;
                }
                else
                {
                    CurrentQuest.Text = q.Text;

                    //make every button.enabled == False
                    foreach (var b in DirectionButtons)
                    {
                        if (b.Enabled)
                        {
                            b.Enabled = false;
                        }
                    }

                    switch (q.Direction)
                    {
                        case "W": WButton.Enabled = true;
                            break;
                        case "N":
                            NButton.Enabled = true;
                            break;
                        case "NE":
                            NEButton.Enabled = true;
                            break;
                        case "NW":
                            NWButton.Enabled = true;
                            break;
                        case "SE":
                            SEButton.Enabled = true;
                            break;
                        case "SW":
                            SWButton.Enabled = true;
                            break;
                        case "S":
                            SButton.Enabled = true;
                            break;
                        case "E":
                            EButton.Enabled = true;
                            break;

                    }
                }
            }
        }

    }
}
