using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;
using static System.Net.Mime.MediaTypeNames;
namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }// false Insert, True : update

        public Car CarInfo { get; set; }
        //----------------------------------------------------------------
        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)//update mode
            {
                //Show car to perform updating
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }//end frmCarDetails_Load
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new car" : "Update a car");
            }
        }//end btnSave

        private void btnCancel_Click(object sender, EventArgs e) => Close();



    }//end form
}
