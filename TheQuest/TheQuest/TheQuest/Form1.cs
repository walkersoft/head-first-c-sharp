using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(120, 90, 640, 230));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            //Update player position and stats
            playerIcon.Location = game.PlayerLocation;
            playerHP.Text = game.PlayerHitPoints.ToString();
            playerIcon.Visible = true;

            //Update enemies position and stats
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batIcon.Location = enemy.Location;
                    batHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                    if (showBat)
                    {
                        batIcon.Visible = true;
                        batLabel.Visible = true;
                        batHP.Visible = true;
                    }
                    else
                    {
                        batIcon.Visible = false;
                        batLabel.Visible = false;
                        batHP.Visible = false;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostIcon.Location = enemy.Location;
                    ghostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                    if (showGhost)
                    {
                        ghostIcon.Visible = true;
                        ghostLabel.Visible = true;
                        ghostHP.Visible = true;
                    }
                    else
                    {
                        ghostIcon.Visible = false;
                        ghostLabel.Visible = false;
                        ghostHP.Visible = false;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulIcon.Location = enemy.Location;
                    ghoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                    if (showGhoul)
                    {
                        ghoulIcon.Visible = true;
                        ghoulLabel.Visible = true;
                        ghoulHP.Visible = true;
                    }
                    else
                    {
                        ghoulIcon.Visible = false;
                        ghoulLabel.Visible = false;
                        ghoulHP.Visible = false;
                    }
                }
            }

            //Update pictureboxes for weapons
            swordIcon.Visible = false;
            bowIcon.Visible = false;
            maceIcon.Visible = false;
            bluePotionIcon.Visible = false;
            redPotionIcon.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordIcon;
                    break;
                case "Bow":
                    weaponControl = bowIcon;
                    break;
                case "Mace":
                    weaponControl = maceIcon;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotionIcon;
                    break;
                case "Red Potion":
                    weaponControl = redPotionIcon;
                    break;
            }
            weaponControl.Visible = true;

            //Set visibility for inventory options
            if (game.CheckPlayerInventory("Sword")) 
            { 
                weaponSword.Visible = true; 
            }
            else
            {
                weaponSword.Visible = false;
            }
            if (game.CheckPlayerInventory("Bow")) 
            { 
                weaponBow.Visible = true; 
            }
            else
            {
                weaponBow.Visible = false;
            }
            if (game.CheckPlayerInventory("Mace")) 
            { 
                weaponMace.Visible = true; 
            }
            else
            {
                weaponMace.Visible = false;
            }
            if (game.CheckPlayerInventory("Blue Potion")) 
            { 
                weaponBluePotion.Visible = true; 
            }
            else
            {
                weaponBluePotion.Visible = false;
            }
            if (game.CheckPlayerInventory("Red Potion")) 
            { 
                weaponRedPotion.Visible = true;
            }
            else
            {
                weaponRedPotion.Visible = false;
            }

            //See if player picked up weapon
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            //Did player die?
            if (game.PlayerHitPoints <= 0) 
            {
                MessageBox.Show("You died!");
                Application.Exit();
            }

            //Did player defeat enemies?
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated your enemies! Get ready for the next level!");
                bool next = game.NewLevel(random);
                if(!next)
                {
                    Application.Exit();
                }
                else
                {
                    UpdateCharacters();
                }
            }
        }

        private void weaponSword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                weaponSword.BorderStyle = BorderStyle.FixedSingle;
                weaponBow.BorderStyle = BorderStyle.None;
                weaponMace.BorderStyle = BorderStyle.None;
                weaponBluePotion.BorderStyle = BorderStyle.None;
                weaponRedPotion.BorderStyle = BorderStyle.None;

                //Change other attack buttons back in case potion was equipped
                attackUp.Text = "↑";
                attackButtons.Text = "Attack";
                //Show the other attack buttons
                attackRight.Visible = true;
                attackDown.Visible = true;
                attackLeft.Visible = true;
            }
        }

        private void weaponBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                weaponSword.BorderStyle = BorderStyle.None;
                weaponBow.BorderStyle = BorderStyle.FixedSingle;
                weaponMace.BorderStyle = BorderStyle.None;
                weaponBluePotion.BorderStyle = BorderStyle.None;
                weaponRedPotion.BorderStyle = BorderStyle.None;

                //Change other attack buttons back in case potion was equipped
                attackUp.Text = "↑";
                attackButtons.Text = "Attack";
                //Show the other attack buttons
                attackRight.Visible = true;
                attackDown.Visible = true;
                attackLeft.Visible = true;
            }
        }

        private void weaponMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                weaponSword.BorderStyle = BorderStyle.None;
                weaponBow.BorderStyle = BorderStyle.None;
                weaponMace.BorderStyle = BorderStyle.FixedSingle;
                weaponBluePotion.BorderStyle = BorderStyle.None;
                weaponRedPotion.BorderStyle = BorderStyle.None;

                //Change other attack buttons back in case potion was equipped
                attackUp.Text = "↑";
                attackButtons.Text = "Attack";
                //Show the other attack buttons
                attackRight.Visible = true;
                attackDown.Visible = true;
                attackLeft.Visible = true;
            }
        }

        private void weaponBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                weaponSword.BorderStyle = BorderStyle.None;
                weaponBow.BorderStyle = BorderStyle.None;
                weaponMace.BorderStyle = BorderStyle.None;
                weaponBluePotion.BorderStyle = BorderStyle.FixedSingle;
                weaponRedPotion.BorderStyle = BorderStyle.None;

                //Change attack button to drink button.
                attackUp.Text = "Drink";
                attackButtons.Text = "Potion Equipped";
                //Hide other attack buttons
                attackRight.Visible = false;
                attackDown.Visible = false;
                attackLeft.Visible = false;
            }
        }

        private void weaponRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                weaponSword.BorderStyle = BorderStyle.None;
                weaponBow.BorderStyle = BorderStyle.None;
                weaponMace.BorderStyle = BorderStyle.None;
                weaponBluePotion.BorderStyle = BorderStyle.None;
                weaponRedPotion.BorderStyle = BorderStyle.FixedSingle;

                //Change attack button to drink button.
                attackUp.Text = "Drink";
                attackButtons.Text = "Potion Equipped";
                //Hide other attack buttons
                attackRight.Visible = false;
                attackDown.Visible = false;
                attackLeft.Visible = false;
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }


    }
}
