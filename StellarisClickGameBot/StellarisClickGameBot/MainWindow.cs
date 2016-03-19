using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarisClickGameBot
{
    public partial class MainWindow : Form
    {

        private bool startButtonPressed = false;
        private Thread enteredPswdButtonAnimThread;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!startButtonPressed)
            {
                showStartButtonAsPressed();
                startButtonPressed = true;
                
                // disable all buttons except for bot mode selection
                enterPasswordButton.Enabled = false;
                manualPswdButton.Enabled = false;
                startButton.Enabled = false;

                Program.startBotThread();                
            }

            if (Program.manualPasswordEntry)
            {
                enteredPswdButton.Enabled = true;
                enteredPswdButtonAnimThread = new Thread(new ThreadStart(animateEnteredPswdButton));
                enteredPswdButtonAnimThread.Start();
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.shutDownBot();
        }

        private void clicksModeButton_Click(object sender, EventArgs e)
        {
            showClicksModeButtonAsPressed();
            Program.botMode = BotMode.ClickMode;
        }

        private void defaultModeButton_Click(object sender, EventArgs e)
        {
            showDefaultModeButtonnAsPressed();
            Program.botMode = BotMode.DefaultMode;
        }

        private void manualPswdButton_Click(object sender, EventArgs e)
        {
            showManualPswdButtonAsPressed();
            Program.manualPasswordEntry = true;
        }

        private void enterPasswordButton_Click(object sender, EventArgs e)
        {
            showEnterPasswordAsPressed();
            Program.manualPasswordEntry = false;
        }

        private void enteredPswdButton_Click(object sender, EventArgs e)
        {
            if (startButtonPressed)
            {
                enteredPswdButton.Enabled = false;
                Program.enteredPswd = true;
                enteredPswdButtonAnimThread.Abort();
            }
        }
    }
}
