namespace IPOTracker
{
    partial class AddStockForm
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.AddStockLabel = new System.Windows.Forms.Label();
            this.IndustryLabel = new System.Windows.Forms.Label();
            this.txtIndustry = new System.Windows.Forms.TextBox();
            this.TickerLabel = new System.Windows.Forms.Label();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.ListingPriceLabel = new System.Windows.Forms.Label();
            this.txtListingPrice = new System.Windows.Forms.TextBox();
            this.LastPriceLabel = new System.Windows.Forms.Label();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.dtpListingDate = new System.Windows.Forms.DateTimePicker();
            this.ListingDateLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(242, 102);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(132, 35);
            this.txtCompanyName.TabIndex = 5;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(29, 105);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(168, 30);
            this.CompanyNameLabel.TabIndex = 7;
            this.CompanyNameLabel.Text = "Company Name:";
            // 
            // AddStockLabel
            // 
            this.AddStockLabel.AutoSize = true;
            this.AddStockLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockLabel.Location = new System.Drawing.Point(111, 34);
            this.AddStockLabel.Name = "AddStockLabel";
            this.AddStockLabel.Size = new System.Drawing.Size(183, 37);
            this.AddStockLabel.TabIndex = 6;
            this.AddStockLabel.Text = "Stock Details";
            // 
            // IndustryLabel
            // 
            this.IndustryLabel.AutoSize = true;
            this.IndustryLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndustryLabel.Location = new System.Drawing.Point(29, 159);
            this.IndustryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.IndustryLabel.Name = "IndustryLabel";
            this.IndustryLabel.Size = new System.Drawing.Size(93, 30);
            this.IndustryLabel.TabIndex = 9;
            this.IndustryLabel.Text = "Industry:";
            // 
            // txtIndustry
            // 
            this.txtIndustry.Location = new System.Drawing.Point(242, 156);
            this.txtIndustry.Name = "txtIndustry";
            this.txtIndustry.Size = new System.Drawing.Size(132, 35);
            this.txtIndustry.TabIndex = 8;
            // 
            // TickerLabel
            // 
            this.TickerLabel.AutoSize = true;
            this.TickerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickerLabel.Location = new System.Drawing.Point(29, 217);
            this.TickerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TickerLabel.Name = "TickerLabel";
            this.TickerLabel.Size = new System.Drawing.Size(72, 30);
            this.TickerLabel.TabIndex = 11;
            this.TickerLabel.Text = "Ticker:";
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(242, 214);
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.Size = new System.Drawing.Size(132, 35);
            this.txtTicker.TabIndex = 10;
            // 
            // ListingPriceLabel
            // 
            this.ListingPriceLabel.AutoSize = true;
            this.ListingPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListingPriceLabel.Location = new System.Drawing.Point(29, 274);
            this.ListingPriceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ListingPriceLabel.Name = "ListingPriceLabel";
            this.ListingPriceLabel.Size = new System.Drawing.Size(129, 30);
            this.ListingPriceLabel.TabIndex = 13;
            this.ListingPriceLabel.Text = "Listing Price:";
            // 
            // txtListingPrice
            // 
            this.txtListingPrice.Location = new System.Drawing.Point(242, 271);
            this.txtListingPrice.Name = "txtListingPrice";
            this.txtListingPrice.Size = new System.Drawing.Size(132, 35);
            this.txtListingPrice.TabIndex = 12;
            // 
            // LastPriceLabel
            // 
            this.LastPriceLabel.AutoSize = true;
            this.LastPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPriceLabel.Location = new System.Drawing.Point(29, 330);
            this.LastPriceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.LastPriceLabel.Name = "LastPriceLabel";
            this.LastPriceLabel.Size = new System.Drawing.Size(106, 30);
            this.LastPriceLabel.TabIndex = 15;
            this.LastPriceLabel.Text = "Last Price:";
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Location = new System.Drawing.Point(242, 327);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.Size = new System.Drawing.Size(132, 35);
            this.txtLastPrice.TabIndex = 14;
            // 
            // dtpListingDate
            // 
            this.dtpListingDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpListingDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpListingDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpListingDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpListingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpListingDate.Location = new System.Drawing.Point(242, 384);
            this.dtpListingDate.Name = "dtpListingDate";
            this.dtpListingDate.Size = new System.Drawing.Size(132, 33);
            this.dtpListingDate.TabIndex = 16;
            // 
            // ListingDateLabel
            // 
            this.ListingDateLabel.AutoSize = true;
            this.ListingDateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListingDateLabel.Location = new System.Drawing.Point(29, 386);
            this.ListingDateLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ListingDateLabel.Name = "ListingDateLabel";
            this.ListingDateLabel.Size = new System.Drawing.Size(128, 30);
            this.ListingDateLabel.TabIndex = 17;
            this.ListingDateLabel.Text = "Listing Date:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(143, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 51);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 522);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ListingDateLabel);
            this.Controls.Add(this.dtpListingDate);
            this.Controls.Add(this.LastPriceLabel);
            this.Controls.Add(this.txtLastPrice);
            this.Controls.Add(this.ListingPriceLabel);
            this.Controls.Add(this.txtListingPrice);
            this.Controls.Add(this.TickerLabel);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.IndustryLabel);
            this.Controls.Add(this.txtIndustry);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.AddStockLabel);
            this.Controls.Add(this.txtCompanyName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddStockForm";
            this.Text = "IPO Tracker | Add Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label AddStockLabel;
        private System.Windows.Forms.Label IndustryLabel;
        private System.Windows.Forms.TextBox txtIndustry;
        private System.Windows.Forms.Label TickerLabel;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label ListingPriceLabel;
        private System.Windows.Forms.TextBox txtListingPrice;
        private System.Windows.Forms.Label LastPriceLabel;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.DateTimePicker dtpListingDate;
        private System.Windows.Forms.Label ListingDateLabel;
        private System.Windows.Forms.Button btnAdd;
    }
}