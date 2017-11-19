namespace SirRogue_alpha_v1._01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.HeroBox = new System.Windows.Forms.GroupBox();
            this.MoneyBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.EquippedBox = new System.Windows.Forms.GroupBox();
            this.EquippedTable = new System.Windows.Forms.TableLayoutPanel();
            this.StatsBox = new System.Windows.Forms.GroupBox();
            this.StatsTable = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryBox = new System.Windows.Forms.GroupBox();
            this.InventoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.MapBox = new System.Windows.Forms.GroupBox();
            this.NWButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.SWButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.SEButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.NEButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.MapPicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TavernButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShopButton = new System.Windows.Forms.Button();
            this.Journal = new System.Windows.Forms.GroupBox();
            this.CompletedQuests = new System.Windows.Forms.ListBox();
            this.CurrentQuest = new System.Windows.Forms.TextBox();
            this.PlayerBox.SuspendLayout();
            this.HeroBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EquippedBox.SuspendLayout();
            this.StatsBox.SuspendLayout();
            this.InventoryBox.SuspendLayout();
            this.MapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Journal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerBox
            // 
            this.PlayerBox.Controls.Add(this.HeroBox);
            this.PlayerBox.Controls.Add(this.EquippedBox);
            this.PlayerBox.Controls.Add(this.StatsBox);
            this.PlayerBox.Controls.Add(this.InventoryBox);
            this.PlayerBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayerBox.Location = new System.Drawing.Point(0, 0);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(350, 610);
            this.PlayerBox.TabIndex = 0;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Player";
            // 
            // HeroBox
            // 
            this.HeroBox.Controls.Add(this.MoneyBox);
            this.HeroBox.Controls.Add(this.pictureBox1);
            this.HeroBox.Controls.Add(this.PlayerNameTextBox);
            this.HeroBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroBox.Location = new System.Drawing.Point(3, 21);
            this.HeroBox.Name = "HeroBox";
            this.HeroBox.Size = new System.Drawing.Size(344, 136);
            this.HeroBox.TabIndex = 0;
            this.HeroBox.TabStop = false;
            this.HeroBox.Text = "Hero";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoneyBox.Location = new System.Drawing.Point(3, 46);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.ReadOnly = true;
            this.MoneyBox.Size = new System.Drawing.Size(338, 25);
            this.MoneyBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerNameTextBox
            // 
            this.PlayerNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerNameTextBox.Location = new System.Drawing.Point(3, 21);
            this.PlayerNameTextBox.Name = "PlayerNameTextBox";
            this.PlayerNameTextBox.ReadOnly = true;
            this.PlayerNameTextBox.Size = new System.Drawing.Size(338, 25);
            this.PlayerNameTextBox.TabIndex = 0;
            // 
            // EquippedBox
            // 
            this.EquippedBox.Controls.Add(this.EquippedTable);
            this.EquippedBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EquippedBox.Location = new System.Drawing.Point(3, 157);
            this.EquippedBox.Name = "EquippedBox";
            this.EquippedBox.Size = new System.Drawing.Size(344, 150);
            this.EquippedBox.TabIndex = 1;
            this.EquippedBox.TabStop = false;
            this.EquippedBox.Text = "Equipped";
            // 
            // EquippedTable
            // 
            this.EquippedTable.ColumnCount = 2;
            this.EquippedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.EquippedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.EquippedTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquippedTable.Location = new System.Drawing.Point(3, 21);
            this.EquippedTable.Name = "EquippedTable";
            this.EquippedTable.RowCount = 4;
            this.EquippedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EquippedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EquippedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.EquippedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.EquippedTable.Size = new System.Drawing.Size(338, 126);
            this.EquippedTable.TabIndex = 0;
            // 
            // StatsBox
            // 
            this.StatsBox.Controls.Add(this.StatsTable);
            this.StatsBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatsBox.Location = new System.Drawing.Point(3, 307);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(344, 150);
            this.StatsBox.TabIndex = 1;
            this.StatsBox.TabStop = false;
            this.StatsBox.Text = "Stats";
            // 
            // StatsTable
            // 
            this.StatsTable.ColumnCount = 2;
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.StatsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.StatsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsTable.Location = new System.Drawing.Point(3, 21);
            this.StatsTable.Name = "StatsTable";
            this.StatsTable.RowCount = 4;
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.StatsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.StatsTable.Size = new System.Drawing.Size(338, 126);
            this.StatsTable.TabIndex = 1;
            // 
            // InventoryBox
            // 
            this.InventoryBox.Controls.Add(this.InventoryTable);
            this.InventoryBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InventoryBox.Location = new System.Drawing.Point(3, 457);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(344, 150);
            this.InventoryBox.TabIndex = 1;
            this.InventoryBox.TabStop = false;
            this.InventoryBox.Text = "Inventory";
            // 
            // InventoryTable
            // 
            this.InventoryTable.ColumnCount = 4;
            this.InventoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InventoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InventoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.InventoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.InventoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryTable.Location = new System.Drawing.Point(3, 21);
            this.InventoryTable.Name = "InventoryTable";
            this.InventoryTable.RowCount = 4;
            this.InventoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.InventoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.InventoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.InventoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InventoryTable.Size = new System.Drawing.Size(338, 126);
            this.InventoryTable.TabIndex = 1;
            // 
            // MapBox
            // 
            this.MapBox.Controls.Add(this.NWButton);
            this.MapBox.Controls.Add(this.WButton);
            this.MapBox.Controls.Add(this.SWButton);
            this.MapBox.Controls.Add(this.SButton);
            this.MapBox.Controls.Add(this.SEButton);
            this.MapBox.Controls.Add(this.EButton);
            this.MapBox.Controls.Add(this.NEButton);
            this.MapBox.Controls.Add(this.NButton);
            this.MapBox.Controls.Add(this.MapPicture);
            this.MapBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapBox.Location = new System.Drawing.Point(350, 0);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(264, 510);
            this.MapBox.TabIndex = 1;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // NWButton
            // 
            this.NWButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NWButton.Enabled = false;
            this.NWButton.Location = new System.Drawing.Point(39, 175);
            this.NWButton.Name = "NWButton";
            this.NWButton.Size = new System.Drawing.Size(40, 40);
            this.NWButton.TabIndex = 8;
            this.NWButton.Text = "NW";
            this.NWButton.UseVisualStyleBackColor = true;
            // 
            // WButton
            // 
            this.WButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WButton.Enabled = false;
            this.WButton.Location = new System.Drawing.Point(4, 240);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(40, 40);
            this.WButton.TabIndex = 7;
            this.WButton.Text = "W";
            this.WButton.UseVisualStyleBackColor = true;
            // 
            // SWButton
            // 
            this.SWButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SWButton.Enabled = false;
            this.SWButton.Location = new System.Drawing.Point(39, 310);
            this.SWButton.Name = "SWButton";
            this.SWButton.Size = new System.Drawing.Size(40, 40);
            this.SWButton.TabIndex = 6;
            this.SWButton.Text = "SW";
            this.SWButton.UseVisualStyleBackColor = true;
            // 
            // SButton
            // 
            this.SButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SButton.Enabled = false;
            this.SButton.Location = new System.Drawing.Point(114, 340);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(40, 40);
            this.SButton.TabIndex = 5;
            this.SButton.Text = "S";
            this.SButton.UseVisualStyleBackColor = true;
            // 
            // SEButton
            // 
            this.SEButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SEButton.Enabled = false;
            this.SEButton.Location = new System.Drawing.Point(189, 310);
            this.SEButton.Name = "SEButton";
            this.SEButton.Size = new System.Drawing.Size(40, 40);
            this.SEButton.TabIndex = 4;
            this.SEButton.Text = "SE";
            this.SEButton.UseVisualStyleBackColor = true;
            // 
            // EButton
            // 
            this.EButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EButton.Enabled = false;
            this.EButton.Location = new System.Drawing.Point(214, 240);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(40, 40);
            this.EButton.TabIndex = 3;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = true;
            // 
            // NEButton
            // 
            this.NEButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NEButton.Enabled = false;
            this.NEButton.Location = new System.Drawing.Point(189, 175);
            this.NEButton.Name = "NEButton";
            this.NEButton.Size = new System.Drawing.Size(40, 40);
            this.NEButton.TabIndex = 2;
            this.NEButton.Text = "NE";
            this.NEButton.UseVisualStyleBackColor = true;
            // 
            // NButton
            // 
            this.NButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NButton.Enabled = false;
            this.NButton.Location = new System.Drawing.Point(114, 140);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(40, 40);
            this.NButton.TabIndex = 1;
            this.NButton.Text = "N";
            this.NButton.UseVisualStyleBackColor = true;
            // 
            // MapPicture
            // 
            this.MapPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapPicture.Image = ((System.Drawing.Image)(resources.GetObject("MapPicture.Image")));
            this.MapPicture.Location = new System.Drawing.Point(3, 21);
            this.MapPicture.Name = "MapPicture";
            this.MapPicture.Size = new System.Drawing.Size(258, 486);
            this.MapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MapPicture.TabIndex = 0;
            this.MapPicture.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(350, 510);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TavernButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(91, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tavern";
            // 
            // TavernButton
            // 
            this.TavernButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TavernButton.Location = new System.Drawing.Point(3, 50);
            this.TavernButton.Name = "TavernButton";
            this.TavernButton.Size = new System.Drawing.Size(164, 23);
            this.TavernButton.TabIndex = 1;
            this.TavernButton.Text = "Visit Tavern";
            this.TavernButton.UseVisualStyleBackColor = true;
            this.TavernButton.Click += new System.EventHandler(this.TavernButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShopButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // ShopButton
            // 
            this.ShopButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShopButton.Location = new System.Drawing.Point(3, 50);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(156, 23);
            this.ShopButton.TabIndex = 0;
            this.ShopButton.Text = "Visit Shop";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // Journal
            // 
            this.Journal.Controls.Add(this.CompletedQuests);
            this.Journal.Controls.Add(this.CurrentQuest);
            this.Journal.Dock = System.Windows.Forms.DockStyle.Right;
            this.Journal.Location = new System.Drawing.Point(614, 0);
            this.Journal.Name = "Journal";
            this.Journal.Size = new System.Drawing.Size(350, 610);
            this.Journal.TabIndex = 4;
            this.Journal.TabStop = false;
            this.Journal.Text = "Journal";
            // 
            // CompletedQuests
            // 
            this.CompletedQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedQuests.FormattingEnabled = true;
            this.CompletedQuests.ItemHeight = 15;
            this.CompletedQuests.Location = new System.Drawing.Point(3, 132);
            this.CompletedQuests.Name = "CompletedQuests";
            this.CompletedQuests.Size = new System.Drawing.Size(344, 475);
            this.CompletedQuests.TabIndex = 1;
            // 
            // CurrentQuest
            // 
            this.CurrentQuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentQuest.Location = new System.Drawing.Point(3, 21);
            this.CurrentQuest.Multiline = true;
            this.CurrentQuest.Name = "CurrentQuest";
            this.CurrentQuest.ReadOnly = true;
            this.CurrentQuest.Size = new System.Drawing.Size(344, 111);
            this.CurrentQuest.TabIndex = 0;
            this.CurrentQuest.Text = "Current Quest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 610);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Journal);
            this.Controls.Add(this.PlayerBox);
            this.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "SirRogue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PlayerBox.ResumeLayout(false);
            this.HeroBox.ResumeLayout(false);
            this.HeroBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EquippedBox.ResumeLayout(false);
            this.StatsBox.ResumeLayout(false);
            this.InventoryBox.ResumeLayout(false);
            this.MapBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Journal.ResumeLayout(false);
            this.Journal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.GroupBox MapBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox Journal;
        private System.Windows.Forms.PictureBox MapPicture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TavernButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button NWButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button SWButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button SEButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button NEButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.GroupBox EquippedBox;
        private System.Windows.Forms.GroupBox StatsBox;
        private System.Windows.Forms.GroupBox InventoryBox;
        private System.Windows.Forms.GroupBox HeroBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PlayerNameTextBox;
        private System.Windows.Forms.TableLayoutPanel EquippedTable;
        private System.Windows.Forms.TableLayoutPanel StatsTable;
        private System.Windows.Forms.TableLayoutPanel InventoryTable;
        private System.Windows.Forms.MaskedTextBox MoneyBox;
        private System.Windows.Forms.ListBox CompletedQuests;
        private System.Windows.Forms.TextBox CurrentQuest;
    }
}

