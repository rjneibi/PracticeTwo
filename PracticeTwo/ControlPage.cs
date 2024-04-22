using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTwo
{
    public partial class ControlPage : Form
    {
        public ControlPage()
        {
            InitializeComponent();
        }

        private void ControlPage_Load(object sender, EventArgs e)
        {
            using (var db = new WheelsAwayDBContext())
            {
                var cars = db.Cars.Where(car => car.Rentals.Count > 0).Select(car => new {name = car.Model, numOfrentals = car.Rentals.Count}).ToList();

                chart1.DataSource = cars;
                chart1.Series[0].XValueMember = "name";
                chart1.Series[0].YValueMembers = "numOfrentals";

            }
        }

        private void btn_rentals_Click(object sender, EventArgs e)
        {
            RentalsPage rentalsPage = new RentalsPage();    
            rentalsPage.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
