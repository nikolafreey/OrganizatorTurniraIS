using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void firstNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
             if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameTextbox.Text, 
                    placeNumberTextbox.Text, 
                    prizeAmountTextbox.Text, 
                    prizePercentageTextbox.Text);


                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //Clearing out the from previous inputs.Reseting the form every time we make a successfull input.
                //placeNameTextbox.Text = "";
                //placeNumberTextbox.Text = "";
                //prizeAmountTextbox.Text = "0";
                //prizePercentageTextbox.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information! Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberTextbox.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextbox.Text.Length == 0)
            {
                output = false;
            }

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextbox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextbox.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void placeNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prizeAmountTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
