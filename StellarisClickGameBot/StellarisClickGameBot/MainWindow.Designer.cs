using System.Threading;

namespace StellarisClickGameBot
{
    partial class MainWindow
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

        

        public void showStartButtonAsPressed() {
            startButton.BackColor = System.Drawing.Color.LawnGreen;
        }

        public void showClicksModeButtonAsPressed() {
            clicksModeButton.BackColor = System.Drawing.Color.LawnGreen;
            defaultModeButton.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        public void showDefaultModeButtonnAsPressed() {
            defaultModeButton.BackColor = System.Drawing.Color.LawnGreen;
            clicksModeButton.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        public void showManualPswdButtonAsPressed() {
            manualPswdButton.BackColor = System.Drawing.Color.LawnGreen;
            enterPasswordButton.BackColor = System.Drawing.Color.LightSkyBlue; ;
        }

        public void showEnterPasswordAsPressed() {
            enterPasswordButton.BackColor = System.Drawing.Color.LawnGreen;
            manualPswdButton.BackColor = System.Drawing.Color.LightSkyBlue;
        }

        public string getUsername() {
            return usernameTxtBox.Text;
        }

        public string getPassword()
        {
            return pswdTextBox.Text;
        }

        public void animateEnteredPswdButton() {
            while (true)
            {
                enteredPswdButton.BackColor = System.Drawing.Color.Moccasin;
                Thread.Sleep(250);
                enteredPswdButton.BackColor = System.Drawing.Color.Orange;
                Thread.Sleep(250);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.title = new System.Windows.Forms.Label();
            this.clicksModeButton = new System.Windows.Forms.Button();
            this.defaultModeButton = new System.Windows.Forms.Button();
            this.manualPswdButton = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.modeSelectLabel = new System.Windows.Forms.Label();
            this.pswdMethodLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.enterPasswordButton = new System.Windows.Forms.Button();
            this.enteredPswdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Azure;
            this.title.Location = new System.Drawing.Point(224, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Stellaris Clicker Game Bot";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clicksModeButton
            // 
            this.clicksModeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clicksModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clicksModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clicksModeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clicksModeButton.Location = new System.Drawing.Point(322, 182);
            this.clicksModeButton.Name = "clicksModeButton";
            this.clicksModeButton.Size = new System.Drawing.Size(151, 56);
            this.clicksModeButton.TabIndex = 1;
            this.clicksModeButton.Text = "Clicks only mode";
            this.clicksModeButton.UseVisualStyleBackColor = false;
            this.clicksModeButton.Click += new System.EventHandler(this.clicksModeButton_Click);
            // 
            // defaultModeButton
            // 
            this.defaultModeButton.BackColor = System.Drawing.Color.LawnGreen;
            this.defaultModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultModeButton.Location = new System.Drawing.Point(505, 182);
            this.defaultModeButton.Name = "defaultModeButton";
            this.defaultModeButton.Size = new System.Drawing.Size(151, 56);
            this.defaultModeButton.TabIndex = 2;
            this.defaultModeButton.Text = "Default mode";
            this.defaultModeButton.UseVisualStyleBackColor = false;
            this.defaultModeButton.Click += new System.EventHandler(this.defaultModeButton_Click);
            // 
            // manualPswdButton
            // 
            this.manualPswdButton.BackColor = System.Drawing.Color.LawnGreen;
            this.manualPswdButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.manualPswdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualPswdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualPswdButton.Location = new System.Drawing.Point(262, 337);
            this.manualPswdButton.Name = "manualPswdButton";
            this.manualPswdButton.Size = new System.Drawing.Size(200, 64);
            this.manualPswdButton.TabIndex = 3;
            this.manualPswdButton.Text = "I will enter the login when prompted";
            this.manualPswdButton.UseVisualStyleBackColor = false;
            this.manualPswdButton.Click += new System.EventHandler(this.manualPswdButton_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(521, 407);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(237, 20);
            this.usernameTxtBox.TabIndex = 4;
            this.usernameTxtBox.Text = "Enter Mail here";
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.Location = new System.Drawing.Point(521, 433);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(237, 20);
            this.pswdTextBox.TabIndex = 5;
            this.pswdTextBox.Text = "Enter Password here";
            // 
            // modeSelectLabel
            // 
            this.modeSelectLabel.AutoSize = true;
            this.modeSelectLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.modeSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeSelectLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.modeSelectLabel.Location = new System.Drawing.Point(315, 119);
            this.modeSelectLabel.Name = "modeSelectLabel";
            this.modeSelectLabel.Size = new System.Drawing.Size(355, 37);
            this.modeSelectLabel.TabIndex = 7;
            this.modeSelectLabel.Text = "Step 1: Select bot mode";
            this.modeSelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pswdMethodLabel
            // 
            this.pswdMethodLabel.AutoSize = true;
            this.pswdMethodLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.pswdMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdMethodLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pswdMethodLabel.Location = new System.Drawing.Point(226, 272);
            this.pswdMethodLabel.Name = "pswdMethodLabel";
            this.pswdMethodLabel.Size = new System.Drawing.Size(579, 37);
            this.pswdMethodLabel.TabIndex = 8;
            this.pswdMethodLabel.Text = "Step 2: Choose password entry method";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(365, 494);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(291, 94);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Clicking !";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // enterPasswordButton
            // 
            this.enterPasswordButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.enterPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPasswordButton.Location = new System.Drawing.Point(521, 337);
            this.enterPasswordButton.Name = "enterPasswordButton";
            this.enterPasswordButton.Size = new System.Drawing.Size(237, 53);
            this.enterPasswordButton.TabIndex = 9;
            this.enterPasswordButton.Text = "I will enter my login now";
            this.enterPasswordButton.UseVisualStyleBackColor = false;
            this.enterPasswordButton.Click += new System.EventHandler(this.enterPasswordButton_Click);
            // 
            // enteredPswdButton
            // 
            this.enteredPswdButton.BackColor = System.Drawing.Color.Orange;
            this.enteredPswdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enteredPswdButton.Enabled = false;
            this.enteredPswdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enteredPswdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteredPswdButton.Location = new System.Drawing.Point(262, 407);
            this.enteredPswdButton.Name = "enteredPswdButton";
            this.enteredPswdButton.Size = new System.Drawing.Size(200, 72);
            this.enteredPswdButton.TabIndex = 10;
            this.enteredPswdButton.Text = "Press here once you entered your login";
            this.enteredPswdButton.UseVisualStyleBackColor = false;
            this.enteredPswdButton.Click += new System.EventHandler(this.enteredPswdButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 205);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::StellarisClickGameBot.Properties.Resources.stellarisBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enteredPswdButton);
            this.Controls.Add(this.enterPasswordButton);
            this.Controls.Add(this.pswdMethodLabel);
            this.Controls.Add(this.modeSelectLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.manualPswdButton);
            this.Controls.Add(this.defaultModeButton);
            this.Controls.Add(this.clicksModeButton);
            this.Controls.Add(this.title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button clicksModeButton;
        private System.Windows.Forms.Button defaultModeButton;
        private System.Windows.Forms.Button manualPswdButton;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.Label modeSelectLabel;
        private System.Windows.Forms.Label pswdMethodLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button enterPasswordButton;
        private System.Windows.Forms.Button enteredPswdButton;
        private System.Windows.Forms.Label label1;
    }
}