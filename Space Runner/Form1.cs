using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Runner
{
    public partial class Form1 : Form
    {
        //rocket
        Rectangle rocket = new Rectangle(200, 250, 20, 20);
        int rocketspeed = 9;
        int acceleration = 0;

        //Asteroid
        List<Rectangle> asteroidsRight = new List<Rectangle>();
        int asteroidSpeeds = 5;
        int asteroidSize = 15;

        //random
        Random randGen = new Random();

        //movement
        bool wDown = false;
        bool sDown = false;

        //paint
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, rocket);
            
            for (int i = 0; i < asteroidsRight.Count; i++)
            {
                e.Graphics.FillRectangle(grayBrush, asteroidsRight[i]);
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //move rocket 
            if (wDown == true && rocket.Y > 0)
            {
                rocket.Y -= rocketspeed;
                acceleration++;
                rocket.Y -= acceleration;
            }
            if (sDown == true && rocket.Y < this.Height - rocket.Height)
            {
                rocket.Y += rocketspeed;
                acceleration--;
                rocket.Y -= acceleration;
            }
            if (wDown == false && sDown == false)
            {
                if (acceleration > 0)
                {
                    acceleration--;
                }
                else if (acceleration < 0)
                {
                    acceleration++;
                }
            }

            //Random asteroid
            int randValue = randGen.Next(1, 550);
            int chance = randGen.Next(1, 500);
            if (chance < 35)
            {
                asteroidsRight.Add(new Rectangle(this.Width, randValue, asteroidSize, asteroidSize));
            }

            //move asteroid objects from right
            for (int i = 0; i < asteroidsRight.Count; i++)
            {
                int x = asteroidsRight[i].X - asteroidSpeeds;
                asteroidsRight[i] = new Rectangle(x, asteroidsRight[i].Y, asteroidSize, asteroidSize);
            }

            Refresh();
        }
        private void gameoverLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
