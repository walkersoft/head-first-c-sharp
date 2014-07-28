using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        public Room DiningRoom;
        public RoomWithDoor LivingRoom;
        public RoomWithDoor Kitchen;
        public Outside Garden;
        public OutsideWithDoor FrontYard;
        public OutsideWithDoor BackYard;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        public void CreateObjects()
        {

        }
    }
}
