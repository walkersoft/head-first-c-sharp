using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        public Location CurrentLocation;
        public Room DiningRoom;
        public Room Stairs;
        public RoomWithDoor LivingRoom;
        public OutsideWithDoor FrontYard;
        public OutsideWithDoor BackYard;
        public OutsideWithHidingPlace Driveway;
        public OutsideWithHidingPlace Garden;
        public RoomWithHidingPlaceAndDoor Kitchen;
        public RoomWithHidingPlace Bathroom;
        public RoomWithHidingPlace MasterBedroom;
        public RoomWithHidingPlace SecondBedroom;
        public RoomWithHidingPlace UpstairsHallway;
        public Opponent opponent;
        public int Moves;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            ResetGame();
        }

        public void CreateObjects()
        {
            DiningRoom = new Room("Dining Room", "a glass chandelier");
            Stairs = new Room("Second Story Stairs", "a wooden banister");
            LivingRoom = new RoomWithDoor("Living Room", "an antique carpet", "a wooden door with an old brass knob");
            FrontYard = new OutsideWithDoor("Front Yard", "a wooden door", false);
            BackYard = new OutsideWithDoor("Back Yard", "a screen door", true);
            Kitchen = new RoomWithHidingPlaceAndDoor("Kitchen", "a complete cabinet set", " a glass door", "in a cabinet");
            Bathroom = new RoomWithHidingPlace("Bathroom", " a sink and a toilet", "in the shower");
            MasterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the large bed");
            SecondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the small bed");
            UpstairsHallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the hall closet");
            Driveway = new OutsideWithHidingPlace("Driveway", false, "in the garage");
            Garden = new OutsideWithHidingPlace("Garden", false, "in a shed");

            DiningRoom.Exits = new Location[2] { LivingRoom, Kitchen };
            Stairs.Exits = new Location[2] { LivingRoom, UpstairsHallway };
            LivingRoom.Exits = new Location[2] { DiningRoom, Stairs };
            FrontYard.Exits = new Location[3] { Garden, BackYard, Driveway };
            BackYard.Exits = new Location[3] { Garden, FrontYard, Driveway };
            Kitchen.Exits = new Location[1] { DiningRoom };
            Bathroom.Exits = new Location[1] { UpstairsHallway };
            MasterBedroom.Exits = new Location[1] { UpstairsHallway };
            SecondBedroom.Exits = new Location[1] { UpstairsHallway };
            UpstairsHallway.Exits = new Location[4] { Stairs, MasterBedroom, SecondBedroom, Bathroom };
            Driveway.Exits = new Location[2] { FrontYard, BackYard };
            Garden.Exits = new Location[2] { FrontYard, BackYard };

            LivingRoom.DoorLocation = FrontYard;
            FrontYard.DoorLocation = LivingRoom;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;
        }

        private bool InGame { get; set; }

        private void MoveToLocation(Location location)
        {
            CurrentLocation = location;
            roomSelect.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length; i++)
                roomSelect.Items.Add(CurrentLocation.Exits[i].Name);
            roomSelect.SelectedIndex = 0;
            roomDescription.Text = CurrentLocation.Description;
            RedrawForm();
        }

        private void RedrawForm()
        {
            //Show room movement
            goToRoom.Visible = true;
            roomSelect.Visible = true;

            //Show or hide door button
            if (CurrentLocation is IHasExteriorDoor)
                goThroughDoor.Visible = true;
            else
                goThroughDoor.Visible = false;
            
            //Show or hide check button
            if (CurrentLocation is IHidingPlace)
                checkButton.Visible = true;
            else
                checkButton.Visible = false;

            Application.DoEvents();
        }

        private void ResetGame()
        {
            InGame = false;
            goThroughDoor.Visible = false;
            goToRoom.Visible = false;
            roomSelect.Visible = false;
            checkButton.Visible = false;
            hideButton.Visible = true;
            Moves = 0;
            opponent = null;
            opponent = new Opponent(FrontYard);
        }

        private void goToRoom_Click(object sender, EventArgs e)
        {
            MoveToLocation(CurrentLocation.Exits[roomSelect.SelectedIndex]);
            Moves++;
        }

        private void goThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = CurrentLocation as IHasExteriorDoor;
            MoveToLocation(hasDoor.DoorLocation);
            Moves++;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (opponent.Check(CurrentLocation))
            {
                string hidingText = "You found him in " + Moves + " turns!";
                IHidingPlace hidingPlace = CurrentLocation as IHidingPlace;
                hidingText += " He was hiding " + hidingPlace.HidingPlace + ".";
                MessageBox.Show(hidingText);
                Thread.Sleep(1000);
                ResetGame();
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            InGame = true;
            for (int i = 10; i != 0; i--)
            {
                roomDescription.Text = "Counting down from " + i;
                opponent.Move();
                Application.DoEvents();
                Thread.Sleep(350);
            }
            MoveToLocation(LivingRoom);
            RedrawForm();
            hideButton.Visible = false;
        }
    }
}
