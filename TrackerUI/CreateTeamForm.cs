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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private ITeamRequester callingForm;
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            
            callingForm = caller;

           // CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Nikola", LastName = "Vukovic" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Marko", LastName = "Markovic" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jovan", LastName = "Jovanovic" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Petar", LastName = "Petrovic" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameTextbox.Text;
                p.LastName = lastNameTextbox.Text;
                p.EmailAddress = emailTextbox.Text;
                p.CellphoneNumber = cellphoneNumberTextbox.Text;

                GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameTextbox.Text = "";
                lastNameTextbox.Text = "";
                emailTextbox.Text = "";
                cellphoneNumberTextbox.Text = "";  
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields!");
            }
        }

        private bool ValidateForm()
        {
            if(firstNameTextbox.Text.Length == 0)
            {
                return false;
            }

            if(lastNameTextbox.Text.Length == 0)
            {
                return false;
            }

            if(emailTextbox.Text.Length == 0)
            {
                return false;
            }

            if(cellphoneNumberTextbox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextbox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            //TODO - Ako ne zatvorimo ovu formu nakon sto je tim kreiran, restartuj datu formu.

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
