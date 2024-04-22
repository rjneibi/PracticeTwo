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
    public partial class RentalsPage : Form
    {
        public RentalsPage()
        {
            InitializeComponent();
        }

        private void RentalsPage_Load(object sender, EventArgs e)
        {
            using (var db = new WheelsAwayDBContext())
            {
                var cars = db.Cars.Where(car => !car.Rentals.
                Any(rental=>rental.StartDate <= DateTime.Now && rental.EndDate >= DateTime.Now)).
                Select(car=> new {CarId = car.Id, Name = car.Brand + " " + car.Model}).
                ToList();

                var users = db.Users.
                    Select(user => new {fullName = user.FirstName + " " + user.LastName, USerId = user.Id})
                    .ToList();

                cb_selectCar.DataSource = cars;
                cb_selectCar.ValueMember = "CarId";
                cb_selectCar.DisplayMember = "Name";

                cb_selectCustomer.DataSource = users;
                cb_selectCustomer.ValueMember = "USerId";
                cb_selectCustomer.DisplayMember = "fullName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedStartDate = dateTimePicker1.Value;
            var selectedEndDate = dateTimePicker2.Value;

            if (selectedStartDate < selectedEndDate)
            {
                MessageBox.Show("The end date cannot be shorter than the start date. ");
                return;
            }

            if (selectedStartDate < DateTime.Now) 
            {
                MessageBox.Show("Date cannot be in the past.");
                return;
            }

            using (var db = new WheelsAwayDBContext())
            {
                var selectedCar = db.Cars.Find(cb_selectCar.SelectedValue);

                var totalDays = selectedStartDate.Day - selectedEndDate.Day;

                Rental rental = new Rental();
                rental.StartDate = selectedStartDate;
                rental.EndDate = selectedEndDate;
                rental.CarId = selectedCar.Id;
                rental.UserId = (int)cb_selectCustomer.SelectedValue;
                rental.Cost = selectedCar.HourPrice * 24 * totalDays;

                var isAvailable = db.Rentals.Any(rented => rented.CarId == selectedCar.Id && selectedStartDate <= rented.EndDate && selectedEndDate >= rented.StartDate);

                if (isAvailable)
                {
                    MessageBox.Show("Car is not availabe in the time period selected. ");
                }else
                {
                    db.Rentals.Add(rental);
                    db.SaveChanges();
                    this.Close();
                }
            }
        } 
    }
}
