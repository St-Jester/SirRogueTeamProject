namespace SirRogue_alpha_v1._01.Shop
{
    partial class ShopUI
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
            this.shopkeeperGrpBox = new System.Windows.Forms.GroupBox();
            this.storeGrpBox = new System.Windows.Forms.GroupBox();
            this.infoGrpBox = new System.Windows.Forms.GroupBox();
            this.storeLstBox = new System.Windows.Forms.ListBox();
            this.shopkeeperTxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.modifierLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shopkeeperGrpBox.SuspendLayout();
            this.storeGrpBox.SuspendLayout();
            this.infoGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopkeeperGrpBox
            // 
            this.shopkeeperGrpBox.Controls.Add(this.shopkeeperTxtBox);
            this.shopkeeperGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shopkeeperGrpBox.Location = new System.Drawing.Point(0, 380);
            this.shopkeeperGrpBox.Name = "shopkeeperGrpBox";
            this.shopkeeperGrpBox.Size = new System.Drawing.Size(839, 117);
            this.shopkeeperGrpBox.TabIndex = 0;
            this.shopkeeperGrpBox.TabStop = false;
            this.shopkeeperGrpBox.Text = "Shopkeeper";
            // 
            // storeGrpBox
            // 
            this.storeGrpBox.Controls.Add(this.storeLstBox);
            this.storeGrpBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.storeGrpBox.Location = new System.Drawing.Point(0, 0);
            this.storeGrpBox.Name = "storeGrpBox";
            this.storeGrpBox.Size = new System.Drawing.Size(286, 380);
            this.storeGrpBox.TabIndex = 1;
            this.storeGrpBox.TabStop = false;
            this.storeGrpBox.Text = "Store";
            // 
            // infoGrpBox
            // 
            this.infoGrpBox.Controls.Add(this.label4);
            this.infoGrpBox.Controls.Add(this.label3);
            this.infoGrpBox.Controls.Add(this.label2);
            this.infoGrpBox.Controls.Add(this.label1);
            this.infoGrpBox.Controls.Add(this.buyBtn);
            this.infoGrpBox.Controls.Add(this.goBackBtn);
            this.infoGrpBox.Controls.Add(this.priceLbl);
            this.infoGrpBox.Controls.Add(this.roleLbl);
            this.infoGrpBox.Controls.Add(this.modifierLbl);
            this.infoGrpBox.Controls.Add(this.typeLbl);
            this.infoGrpBox.Controls.Add(this.nameLbl);
            this.infoGrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoGrpBox.Location = new System.Drawing.Point(286, 0);
            this.infoGrpBox.Name = "infoGrpBox";
            this.infoGrpBox.Size = new System.Drawing.Size(553, 380);
            this.infoGrpBox.TabIndex = 2;
            this.infoGrpBox.TabStop = false;
            this.infoGrpBox.Text = "Info";
            // 
            // storeLstBox
            // 
            this.storeLstBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeLstBox.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLstBox.FormattingEnabled = true;
            this.storeLstBox.ItemHeight = 41;
            this.storeLstBox.Location = new System.Drawing.Point(3, 21);
            this.storeLstBox.Name = "storeLstBox";
            this.storeLstBox.Size = new System.Drawing.Size(280, 356);
            this.storeLstBox.TabIndex = 0;
            this.storeLstBox.SelectedIndexChanged += new System.EventHandler(this.storeLstBox_SelectedIndexChanged);
            // 
            // shopkeeperTxtBox
            // 
            this.shopkeeperTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shopkeeperTxtBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.shopkeeperTxtBox.Location = new System.Drawing.Point(143, 21);
            this.shopkeeperTxtBox.Multiline = true;
            this.shopkeeperTxtBox.Name = "shopkeeperTxtBox";
            this.shopkeeperTxtBox.Size = new System.Drawing.Size(693, 93);
            this.shopkeeperTxtBox.TabIndex = 0;
            // 
            // nameLbl
            // 
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLbl.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.nameLbl.Location = new System.Drawing.Point(3, 21);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(547, 50);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(162, 118);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(56, 21);
            this.typeLbl.TabIndex = 1;
            this.typeLbl.Text = "Type";
            // 
            // modifierLbl
            // 
            this.modifierLbl.AutoSize = true;
            this.modifierLbl.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierLbl.Location = new System.Drawing.Point(162, 150);
            this.modifierLbl.Name = "modifierLbl";
            this.modifierLbl.Size = new System.Drawing.Size(93, 21);
            this.modifierLbl.TabIndex = 2;
            this.modifierLbl.Text = "Modifier";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(162, 183);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(56, 21);
            this.roleLbl.TabIndex = 3;
            this.roleLbl.Text = "Role";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.priceLbl.Location = new System.Drawing.Point(275, 246);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(103, 35);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "Price";
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(281, 316);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(154, 48);
            this.goBackBtn.TabIndex = 5;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyBtn.ForeColor = System.Drawing.Color.White;
            this.buyBtn.Location = new System.Drawing.Point(117, 316);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(154, 48);
            this.buyBtn.TabIndex = 6;
            this.buyBtn.Text = "Buy";
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Increases on: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Role: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(151, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 497);
            this.Controls.Add(this.infoGrpBox);
            this.Controls.Add(this.storeGrpBox);
            this.Controls.Add(this.shopkeeperGrpBox);
            this.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShopUI";
            this.Text = "ShopUI";
            this.shopkeeperGrpBox.ResumeLayout(false);
            this.shopkeeperGrpBox.PerformLayout();
            this.storeGrpBox.ResumeLayout(false);
            this.infoGrpBox.ResumeLayout(false);
            this.infoGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shopkeeperGrpBox;
        private System.Windows.Forms.TextBox shopkeeperTxtBox;
        private System.Windows.Forms.GroupBox storeGrpBox;
        private System.Windows.Forms.ListBox storeLstBox;
        private System.Windows.Forms.GroupBox infoGrpBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label modifierLbl;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}