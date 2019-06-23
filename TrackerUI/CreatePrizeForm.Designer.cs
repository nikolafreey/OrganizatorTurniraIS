namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.placeNumberTextbox = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameTextbox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountTextbox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.prizePercentageTextbox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(343, 65);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Kreiraj Nagradu";
            // 
            // placeNumberTextbox
            // 
            this.placeNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeNumberTextbox.Location = new System.Drawing.Point(272, 101);
            this.placeNumberTextbox.Name = "placeNumberTextbox";
            this.placeNumberTextbox.Size = new System.Drawing.Size(211, 43);
            this.placeNumberTextbox.TabIndex = 14;
            this.placeNumberTextbox.TextChanged += new System.EventHandler(this.firstNameTextbox_TextChanged);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNumberLabel.Location = new System.Drawing.Point(16, 101);
            this.placeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(183, 45);
            this.placeNumberLabel.TabIndex = 13;
            this.placeNumberLabel.Text = "Broj Mjesta";
            // 
            // placeNameTextbox
            // 
            this.placeNameTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeNameTextbox.Location = new System.Drawing.Point(272, 176);
            this.placeNameTextbox.Name = "placeNameTextbox";
            this.placeNameTextbox.Size = new System.Drawing.Size(211, 43);
            this.placeNameTextbox.TabIndex = 16;
            this.placeNameTextbox.TextChanged += new System.EventHandler(this.placeNameTextbox_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.placeNameLabel.Location = new System.Drawing.Point(16, 176);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(180, 45);
            this.placeNameLabel.TabIndex = 15;
            this.placeNameLabel.Text = "Ime Mjesta";
            // 
            // prizeAmountTextbox
            // 
            this.prizeAmountTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeAmountTextbox.Location = new System.Drawing.Point(272, 251);
            this.prizeAmountTextbox.Name = "prizeAmountTextbox";
            this.prizeAmountTextbox.Size = new System.Drawing.Size(211, 43);
            this.prizeAmountTextbox.TabIndex = 18;
            this.prizeAmountTextbox.Text = "0";
            this.prizeAmountTextbox.TextChanged += new System.EventHandler(this.prizeAmountTextbox_TextChanged);
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeAmountLabel.Location = new System.Drawing.Point(16, 251);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(230, 45);
            this.prizeAmountLabel.TabIndex = 17;
            this.prizeAmountLabel.Text = "Iznos Nagrade";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLabel.Location = new System.Drawing.Point(198, 324);
            this.orLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(70, 45);
            this.orLabel.TabIndex = 19;
            this.orLabel.Text = "-ili-";
            // 
            // prizePercentageTextbox
            // 
            this.prizePercentageTextbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizePercentageTextbox.Location = new System.Drawing.Point(272, 404);
            this.prizePercentageTextbox.Name = "prizePercentageTextbox";
            this.prizePercentageTextbox.Size = new System.Drawing.Size(211, 43);
            this.prizePercentageTextbox.TabIndex = 22;
            this.prizePercentageTextbox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizePercentageLabel.Location = new System.Drawing.Point(16, 404);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(264, 45);
            this.prizePercentageLabel.TabIndex = 21;
            this.prizePercentageLabel.Text = "Procent Nagrade";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(179, 536);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(304, 86);
            this.createPrizeButton.TabIndex = 28;
            this.createPrizeButton.Text = "Kreiraj Nagradu";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 720);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageTextbox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizeAmountTextbox);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameTextbox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberTextbox);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Kreiraj Nagradu";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox placeNumberTextbox;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNameTextbox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountTextbox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TextBox prizePercentageTextbox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}