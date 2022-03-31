
namespace test2
{
    partial class shotgunform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblPlayersShots = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblComputerShots = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(20, 372);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(163, 40);
            this.btnBlock.TabIndex = 0;
            this.btnBlock.Text = "Blocka";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(20, 326);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 40);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Ladda";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(20, 280);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(163, 40);
            this.btnShoot.TabIndex = 2;
            this.btnShoot.Text = "Skjuta";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(189, 372);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(163, 40);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 74);
            this.label1.TabIndex = 4;
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerChoice.Location = new System.Drawing.Point(550, 77);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(191, 74);
            this.lblComputerChoice.TabIndex = 5;
            this.lblComputerChoice.Text = "label2";
            // 
            // lblPlayersShots
            // 
            this.lblPlayersShots.AutoSize = true;
            this.lblPlayersShots.Location = new System.Drawing.Point(84, 187);
            this.lblPlayersShots.Name = "lblPlayersShots";
            this.lblPlayersShots.Size = new System.Drawing.Size(22, 25);
            this.lblPlayersShots.TabIndex = 6;
            this.lblPlayersShots.Text = "0";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(331, 244);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(85, 25);
            this.lblresult.TabIndex = 7;
            this.lblresult.Text = "Händelse";
            // 
            // lblComputerShots
            // 
            this.lblComputerShots.AutoSize = true;
            this.lblComputerShots.Location = new System.Drawing.Point(613, 187);
            this.lblComputerShots.Name = "lblComputerShots";
            this.lblComputerShots.Size = new System.Drawing.Size(22, 25);
            this.lblComputerShots.TabIndex = 8;
            this.lblComputerShots.Text = "0";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerChoice.Location = new System.Drawing.Point(37, 77);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(191, 74);
            this.lblPlayerChoice.TabIndex = 10;
            this.lblPlayerChoice.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(582, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Datorn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Skott:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Skott:";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(613, 372);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(163, 40);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Spela igen";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // shotgunform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblComputerShots);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblPlayersShots);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBlock);
            this.Name = "shotgunform";
            this.Text = "Shotgun Spel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblPlayersShots;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblComputerShots;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestart;
    }
}

