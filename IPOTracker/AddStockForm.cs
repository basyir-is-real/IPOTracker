using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTracker
{
    public partial class AddStockForm : Form
    {
        public AddStockForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new FormDbContext())
            {
                var newStock = new Stock
                {
                    CompanyName = txtCompanyName.Text,
                    Industry = txtIndustry.Text,
                    Ticker = txtTicker.Text,
                    ListingPrice = decimal.Parse(txtListingPrice.Text),
                    LastPrice = decimal.Parse(txtLastPrice.Text),
                    ListingDate = dtpListingDate.Value
                };
                context.Stocks.Add(newStock);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
