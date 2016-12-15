namespace FakturaDesign
{
    partial class FirmsFrame
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
            this.addFirmBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firmName = new System.Windows.Forms.TextBox();
            this.firmBulstat = new System.Windows.Forms.TextBox();
            this.firmAdress = new System.Windows.Forms.TextBox();
            this.firmMol = new System.Windows.Forms.TextBox();
            this.firmOwned = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addFirmBtn
            // 
            this.addFirmBtn.Location = new System.Drawing.Point(50, 231);
            this.addFirmBtn.Name = "addFirmBtn";
            this.addFirmBtn.Size = new System.Drawing.Size(101, 37);
            this.addFirmBtn.TabIndex = 1;
            this.addFirmBtn.Text = "Добави/Запази";
            this.addFirmBtn.UseVisualStyleBackColor = true;
            this.addFirmBtn.Click += new System.EventHandler(this.AddFirmBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(203, 231);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(101, 37);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Премахни";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "БУЛСТАТ:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "МОЛ:";
            // 
            // firmName
            // 
            this.firmName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.firmName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.firmName.Location = new System.Drawing.Point(189, 40);
            this.firmName.Name = "firmName";
            this.firmName.Size = new System.Drawing.Size(115, 20);
            this.firmName.TabIndex = 8;
            this.firmName.TextChanged += new System.EventHandler(this.FirmName_TextChanged);
            // 
            // firmBulstat
            // 
            this.firmBulstat.Location = new System.Drawing.Point(189, 84);
            this.firmBulstat.Name = "firmBulstat";
            this.firmBulstat.Size = new System.Drawing.Size(115, 20);
            this.firmBulstat.TabIndex = 9;
            // 
            // firmAdress
            // 
            this.firmAdress.Location = new System.Drawing.Point(189, 127);
            this.firmAdress.Name = "firmAdress";
            this.firmAdress.Size = new System.Drawing.Size(115, 20);
            this.firmAdress.TabIndex = 10;
            // 
            // firmMol
            // 
            this.firmMol.Location = new System.Drawing.Point(189, 169);
            this.firmMol.Name = "firmMol";
            this.firmMol.Size = new System.Drawing.Size(115, 20);
            this.firmMol.TabIndex = 11;
            // 
            // firmOwned
            // 
            this.firmOwned.AutoSize = true;
            this.firmOwned.Location = new System.Drawing.Point(189, 208);
            this.firmOwned.Name = "firmOwned";
            this.firmOwned.Size = new System.Drawing.Size(100, 17);
            this.firmOwned.TabIndex = 12;
            this.firmOwned.Text = "This firm is mine";
            this.firmOwned.UseVisualStyleBackColor = true;
            // 
            // FirmsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 300);
            this.Controls.Add(this.firmOwned);
            this.Controls.Add(this.firmMol);
            this.Controls.Add(this.firmAdress);
            this.Controls.Add(this.firmBulstat);
            this.Controls.Add(this.firmName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addFirmBtn);
            this.Name = "FirmsFrame";
            this.Text = "Добавяне/Променяне/Премахване на Фирма";
            this.Load += new System.EventHandler(this.FirmFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFirmBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firmName;
        private System.Windows.Forms.TextBox firmBulstat;
        private System.Windows.Forms.TextBox firmAdress;
        private System.Windows.Forms.TextBox firmMol;
        private System.Windows.Forms.CheckBox firmOwned;
    }
}