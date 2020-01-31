using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public int v;

        public VehicleUi()
        {
            v = 0;
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();
        List<double> speed = new List<double>();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(vehicleNameTextBox.Text))
            {
                MessageBox.Show("Vehicle name cannot be empty!");
                return;
            }

            if (String.IsNullOrEmpty(regNoTextBox.Text))
            {
                MessageBox.Show("Reg No cannot be empty!");
                return;
            }

            v++;
            vehicle.VehicleName = vehicleNameTextBox.Text;
            vehicle.RegNo = regNoTextBox.Text;

            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(v >= 1)
            {
                if (String.IsNullOrEmpty(speedTextBox.Text))
                {
                    MessageBox.Show("Speed cannot be empty!");
                    return;
                }

                vehicle.AddSpeed(Convert.ToDouble(speedTextBox.Text));

                speedTextBox.Clear();
            }
            else
                MessageBox.Show("Create a vehicle First");
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (v >= 1)
            {
                minSpeedTextBox.Text = vehicle.MinSpeed().ToString();
                maxSpeedTextBox.Text = vehicle.MaxSpeed().ToString();
                averageSpeedTextBox.Text = vehicle.AverageSpeed().ToString();
                minSpeedTextBox.ReadOnly = true;
                maxSpeedTextBox.ReadOnly = true;
                averageSpeedTextBox.ReadOnly = true;
            }
            else
                MessageBox.Show("Create a Vehicle First");
        }
    }
}
