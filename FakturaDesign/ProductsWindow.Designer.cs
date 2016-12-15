namespace FakturaDesign
{
    partial class ProducstFrame
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
            this.Barkod = new System.Windows.Forms.TextBox();
            this.productProcentegeDDS = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.searchProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Barkod
            // 
            this.Barkod.Location = new System.Drawing.Point(189, 234);
            this.Barkod.Name = "Barkod";
            this.Barkod.Size = new System.Drawing.Size(115, 20);
            this.Barkod.TabIndex = 21;
            // 
            // productProcentegeDDS
            // 
            this.productProcentegeDDS.Location = new System.Drawing.Point(189, 192);
            this.productProcentegeDDS.Name = "productProcentegeDDS";
            this.productProcentegeDDS.Size = new System.Drawing.Size(115, 20);
            this.productProcentegeDDS.TabIndex = 20;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(189, 149);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(115, 20);
            this.productPrice.TabIndex = 19;
            // 
            // productName
            // 
            this.productName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productName.Location = new System.Drawing.Point(189, 108);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(115, 20);
            this.productName.TabIndex = 18;
            this.productName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Баркод:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "% ДДС:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Стойност без ДДС:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Име на продукт:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(203, 296);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(101, 37);
            this.delBtn.TabIndex = 13;
            this.delBtn.Text = "Премахни";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(50, 296);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(101, 37);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Добави/Запази";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // searchProduct
            // 
            this.searchProduct.Location = new System.Drawing.Point(122, 61);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(144, 20);
            this.searchProduct.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(128, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "Справка на продукт чрез баркод";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProducstFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 390);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.Barkod);
            this.Controls.Add(this.productProcentegeDDS);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "ProducstFrame";
            this.Text = "Добавяне/Премахване/Търсене на продукт";
            this.Load += new System.EventHandler(this.ProducstFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Barkod;
        private System.Windows.Forms.TextBox productProcentegeDDS;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox searchProduct;
        private System.Windows.Forms.Label label5;
    }
}