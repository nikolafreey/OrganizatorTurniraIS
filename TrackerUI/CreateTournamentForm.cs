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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avaliableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }
        
        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = avaliableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";


            tournamentPlayersListBox.DataSource = null;
            tournamentPlayersListBox.DataSource = selectedTeams;
            tournamentPlayersListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if(t != null)
            {
                avaliableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Pozivanje CreatePrizeForm forme

            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            //Dobijemo povratnu informaciju od PrizeModelForm-e koja vraca PrizeModel
            //Uzmemo dati PrizeModel i unesemo ga u listu iz koje biramo nagrade        

            selectedPrizes.Add(model);
            WireUpLists();    
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentPlayersListBox.SelectedItem;

            if(t != null)
            {
                selectedTeams.Remove(t);
                avaliableTeams.Add(t);

                WireUpLists();
            }

        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            //Provjera podataka
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(entryFeeTextbox.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("Unesite validan iznos uloga!",
                    "Netacan iznos uloga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //Napravi CreateTournament Unos

            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameTextbox.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // Spoji meceve sa bazom
            // Promjesaj listu sa timova
            // Provjerimo da li imamo dovoljan broj timova za kompletnu rundu.
            // 2*2*2*2 = 2^4 => 2^n gdje je n broj rundi datog turnira.
            // Kreiramo za pocetak prvu rundu jer ce da se razlikuje od svih ostalih jer u njoj imamo "prazne" timove.
            // Kreiramo sve ostale runde po sablonu

            TournamentLogic.CreateRounds(tm);

            //Napravi unos za sve nagrade
            //Napravi unos za sve timove
            //Napraviti parove ( Ko sa kim igra)
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();
            
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
            this.Close();
        }
    }
}
