namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextbox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreTextbox = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(11, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(155, 65);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Turnir:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(270, 9);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(352, 65);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<Naziv Turnira>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(15, 99);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(114, 45);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Runda";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(139, 99);
            this.roundDropDown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(325, 45);
            this.roundDropDown.TabIndex = 3;
            this.roundDropDown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(139, 168);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(291, 49);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Samo Neodigrani";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckbox_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(23, 224);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(441, 337);
            this.matchupListBox.TabIndex = 5;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneNameLabel.Location = new System.Drawing.Point(536, 224);
            this.teamOneNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(181, 45);
            this.teamOneNameLabel.TabIndex = 6;
            this.teamOneNameLabel.Text = "<Prvi Tim>";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoNameLabel.Location = new System.Drawing.Point(536, 437);
            this.teamTwoNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(208, 45);
            this.teamTwoNameLabel.TabIndex = 7;
            this.teamTwoNameLabel.Text = "<Drugi Tim>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneScoreLabel.Location = new System.Drawing.Point(536, 294);
            this.teamOneScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(144, 45);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Rezultat:";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(536, 515);
            this.teamTwoScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(144, 45);
            this.teamTwoScoreLabel.TabIndex = 9;
            this.teamTwoScoreLabel.Text = "Rezultat:";
            // 
            // teamOneScoreTextbox
            // 
            this.teamOneScoreTextbox.Location = new System.Drawing.Point(677, 297);
            this.teamOneScoreTextbox.Name = "teamOneScoreTextbox";
            this.teamOneScoreTextbox.Size = new System.Drawing.Size(100, 43);
            this.teamOneScoreTextbox.TabIndex = 10;
            // 
            // teamTwoScoreTextbox
            // 
            this.teamTwoScoreTextbox.Location = new System.Drawing.Point(677, 515);
            this.teamTwoScoreTextbox.Name = "teamTwoScoreTextbox";
            this.teamTwoScoreTextbox.Size = new System.Drawing.Size(100, 43);
            this.teamTwoScoreTextbox.TabIndex = 11;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versusLabel.Location = new System.Drawing.Point(602, 375);
            this.versusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(85, 45);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.scoreButton.Location = new System.Drawing.Point(831, 375);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(136, 46);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Rezultat";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 587);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreTextbox);
            this.Controls.Add(this.teamOneScoreTextbox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Pregled Turnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreTextbox;
        private System.Windows.Forms.TextBox teamTwoScoreTextbox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

