using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class shotgunform : Form
    {
        private Player humanPlayer;
        private Player computerPlayer;

        public shotgunform()
        {
            InitializeComponent();
            humanPlayer = new Player();
            computerPlayer = new Player();
            btnRestart.Visible = false;

            RestartGame();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
           
            humanPlayer.Shoot();
            lblPlayersShots.Text = humanPlayer.ShotCount.ToString();
            lblPlayerChoice.Text = "Skjut";

            if(humanPlayer.ShotCount == 0)
            {
                btnShoot.Enabled = false;
            }
            ComputerAction();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            humanPlayer.Load();
            lblPlayerChoice.Text = "Ladda";
            lblPlayersShots.Text = humanPlayer.ShotCount.ToString();
            btnShoot.Enabled = true;

            if(humanPlayer.ShotCount == 3)
            {
                btnShotgun.Enabled = true;
                btnShoot.Enabled = false;
                btnBlock.Enabled = false;
                btnLoad.Enabled = false;
            }
            ComputerAction();


        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            humanPlayer.Block();
            lblPlayerChoice.Text = "Blocka";
            ComputerAction();

        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            humanPlayer.Shotgun();
            lblPlayerChoice.Text = "SHOTGUN";
            ComputerAction();
                

        }
    
        private void ComputerAction() //Metod för Datorns val
        {
            //0:Shoot, 1:load 2:Block 3: shotgun
            var random = new Random();
            int computerAction = 0;

            if(computerPlayer.ShotCount == 0)
            {
                computerAction = random.Next(1, 2);
                    
            }
            else if(computerPlayer.ShotCount == 3)
            {
                computerAction = 3;
            }
            else
            {
                computerAction = random.Next(0,2);
            }

            switch (computerAction)
            {
                case 0:
                    computerPlayer.Shoot();
                    lblComputerShots.Text = computerPlayer.ShotCount.ToString();
                    lblComputerChoice.Text = "Skjut";
                    break;
                case 1:
                    computerPlayer.Load();
                    lblComputerShots.Text = computerPlayer.ShotCount.ToString();
                    lblComputerChoice.Text = "Ladda";
                    break;
                case 2:
                    computerPlayer.Block();
                    lblComputerShots.Text = computerPlayer.ShotCount.ToString();
                    lblComputerChoice.Text = "Blocka";
                    break;
                case 3:
                    computerPlayer.Shotgun();
                    lblComputerShots.Text = computerPlayer.ShotCount.ToString();
                    lblComputerChoice.Text = "Shotgun";
                    break;

            }
            CheckWinner();
        }

        public void CheckWinner() //Metod för vem so vinner
        {
            if(humanPlayer.Choice == playerChoice.Load && computerPlayer.Choice == playerChoice.Load)
            {
                lblresult.Text = "Båda får skott!";
            }
            else if (humanPlayer.Choice == playerChoice.Load && computerPlayer.Choice == playerChoice.Block)
            {
                lblresult.Text = "Spelaren får skott";
            }
            else if (humanPlayer.Choice == playerChoice.Block && computerPlayer.Choice == playerChoice.Load)
            {
                lblresult.Text = "Datorn får skott";
            }
            else if(humanPlayer.Choice == playerChoice.Block && computerPlayer.Choice == playerChoice.Block)
            {
                lblresult.Text = " Inget händer";
            }
            else if (humanPlayer.Choice == playerChoice.Shoot && computerPlayer.Choice == playerChoice.Block)
            {
                lblresult.Text = "Spelaren förlorar ett skott";
            }
            else if (humanPlayer.Choice == playerChoice.Block && computerPlayer.Choice == playerChoice.Shoot)
            {
                lblresult.Text = "Datorn förlorar ett skott";
            }
            else if (humanPlayer.Choice == playerChoice.Shoot && computerPlayer.Choice == playerChoice.Shoot)
            {
                lblresult.Text = "Båda förlorar skott";
            }
            else if(humanPlayer.Choice == playerChoice.Shoot && computerPlayer.Choice == playerChoice.Load)
            {
                lblresult.Text = "Spelaren vinner";
                btnRestart.Visible = true;

                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else if (humanPlayer.Choice == playerChoice.Load && computerPlayer.Choice == playerChoice.Shoot)
            {
                lblresult.Text = "Datorn vinner";
                btnRestart.Visible = true;

                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else if (humanPlayer.Choice == playerChoice.Shotgun && computerPlayer.Choice == playerChoice.Shotgun)
            {
                lblresult.Text = "Båda vinner";
                btnRestart.Visible = true;

                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else if (humanPlayer.Choice == playerChoice.Shotgun)
            {
                lblresult.Text = "Spelaren vinner";
                btnRestart.Visible = true;

                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
                btnShotgun.Enabled = false;
            }
            else if (computerPlayer.Choice == playerChoice.Shotgun)
            {
                lblresult.Text = "Datorn vinner";
                btnRestart.Visible = true;

                btnShoot.Enabled = false;
                btnLoad.Enabled = false;
                btnBlock.Enabled = false;
                btnShotgun.Enabled = false;
            }
        }

        public void RestartGame()
        {
            humanPlayer.ShotCount = 0;
            computerPlayer.ShotCount = 0;
            
            lblPlayersShots.Text = "0";
            lblComputerShots.Text = "0";
            lblPlayerChoice.Text = "";
            lblComputerChoice.Text = "";
            lblresult.Text = "";

            btnShoot.Enabled = false;
            btnLoad.Enabled = true;
            btnBlock.Enabled = true;
            btnShotgun.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }

}
