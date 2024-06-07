using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace IPOTracker
{
    public partial class DashboardForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string _currentUsername;
        private string apiKey = "Q6VXTHTOT4W2NGZ3";

        public DashboardForm(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
            LoadStockPricePerformanceChart("AAPL"); // Load default stock data for demonstration
        }

        private void SignOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthenticationService authService = new AuthenticationService();
            authService.SignOutUser(_currentUsername);
            //// Update the user status to signed out
            //UpdateUserStatusToSignedOut();

            // Close the dashboard form
            this.Close();

            // Show the main form (login form)
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private async void LoadStockPricePerformanceChart(string symbol)
        {
            // Fetch stock data
            var stockData = await FetchStockDataAsync(symbol);

            // Clear existing series
            StockPriceChart.Series.Clear();

            // Create a new series and set its properties
            Series series = new Series
            {
                Name = "StockPrice",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line
            };

            // Add data points to the series
            foreach (var dataPoint in stockData)
            {
                series.Points.AddXY(dataPoint.Date, dataPoint.Price);
            }

            // Add the series to the chart
            StockPriceChart.Series.Add(series);

            // Configure the chart area
            ChartArea chartArea = StockPriceChart.ChartAreas[0];
            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Stock Price ($)";
            chartArea.AxisX.LabelStyle.Format = "MMM dd";
        }

        private async Task<(DateTime Date, double Price)[]> FetchStockDataAsync(string symbol)
        {
            var url = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}";
            var response = await client.GetStringAsync(url);
            var data = JObject.Parse(response)["Time Series (Daily)"] as JObject;

            var result = new List<(DateTime Date, double Price)>();
            foreach (var item in data.Properties())
            {
                var date = DateTime.Parse(item.Name);
                var price = double.Parse(item.Value["4. close"].ToString());
                result.Add((date, price));
            }

            return result.ToArray();
        }

        private void UpdateUserStatusToSignedOut()
        {
            string username = GetCurrentUsername(); // Implement this method to get the current user's username

            using (var context = new FormDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Username == username);
                if (user != null)
                {
                    user.IsSignedIn = false; // Assuming you have an IsSignedIn field in your User class
                    context.SaveChanges();
                }
            }
        }

        private string GetCurrentUsername()
        {
            // Implement this method to retrieve the current logged-in user's username
            // For example, you might have stored the username in a static property or a session variable
            return "currentUsername"; // Replace with actual implementation
        }

    }
}
