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
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();


            tournament = tournamentModel;
            
            tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void Tournament_OnTournamentComplete(object sender, DateTime e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropDown.DataSource = rounds;

            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }
        

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();

                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {
                            selectedMatchups.Add(m); 
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            teamOneNameLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreTextbox.Visible = isVisible;

            teamTwoNameLabel.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreTextbox.Visible = isVisible;

            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreTextbox.Text = m.Entries[0].Score.ToString();

                        teamTwoNameLabel.Text = "<Nepostojeci Tim>";
                        teamTwoScoreTextbox.Text = "0";
                    }
                    else
                    {
                        teamOneNameLabel.Text = "Not Yet Set";
                        teamOneScoreTextbox.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoNameLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        teamTwoScoreTextbox.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoNameLabel.Text = "Not Yet Set";
                        teamTwoScoreTextbox.Text = "";
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundDropDown.SelectedItem);
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreTextbox.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreTextbox.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "Rezultat 1 nije validan broj.";
            }

            else if (!scoreTwoValid)
            {
                output = "Rezultata 2 nije validan broj.";
            }

            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "Morate unijeti rezultat za makar jedan tim.";
            }

            else if (teamOneScore == teamTwoScore)
            {
                output = "Utakmica ne moze biti nerjesena!";
            }

            return output;
        }

        private void    scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Desila se sledeca greska: { errorMessage }");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamOneScoreTextbox.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Unesite pravilno polje rezultata tima 1!");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(teamTwoScoreTextbox.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Unesite pravilno polje rezultata tima 2!");
                            return;
                        }
                    } 
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desila se sledeca greska: { ex.Message }");
                return;
            }

            LoadMatchups((int)roundDropDown.SelectedItem);
        }
    }
}
