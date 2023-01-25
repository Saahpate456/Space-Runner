using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Space_Runner
{
    public partial class Form1 : Form
    {
        //rocket
        Rectangle rocket = new Rectangle(200, 250, 20, 20);
        int rocketspeed = 2;
        int acceleration = 0;

        //Asteroid
        List<Rectangle> asteroidsRight = new List<Rectangle>();
        int asteroidSpeeds = 5;
        int asteroidSize = 15;

        //Fuel
        List<Rectangle> fuel = new List<Rectangle>();
        int fuelSpeed = 5;
        ///int fuelSize = 15;

        int fuelAmount = 100;

        //Ability
        List<Rectangle> shotAbility = new List<Rectangle>();
        int shotSpeeds = 5;
        ///int shotSize = 15;

        int shotAmount = 2;

        //suprise
        List<Rectangle> suprise = new List<Rectangle>();
        int supriseSpeeds = 10;

        //random
        Random randGen = new Random();

        //movement
        bool wDown = false;
        bool sDown = false;

        //ability
        Rectangle blaster = new Rectangle(0, 0, 20, 20);
        bool ability = false;

        //screen items
        int score = 0;
        string gameState = "waiting";


        //paint
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush goldBrush = new SolidBrush(Color.Gold);
        public Form1()
        {
            InitializeComponent();
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
                case Keys.F:
                    ability = false;
                    break;
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        GameSetup();
                    }
                    break;
                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        this.Close();
                    }
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
                case Keys.F:
                    ability = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "waiting")
            {
                scoreLabel.Text = "";
                gameoverLabel.Text = "";

                titleLabel.Text = "Space Runner";
                subtitleLabel.Text = "Press Space to Start or Esc to Exit";
                abilityLabel.Text = "";
                fuelLabel.Text = "";
            }
            else if (gameState == "running")
            {
                //update labels
                scoreLabel.Text = $"Score: {score}";

                titleLabel.Text = "";
                subtitleLabel.Text = "";

                e.Graphics.FillRectangle(whiteBrush, rocket);

                for (int i = 0; i < asteroidsRight.Count; i++)
                {
                    e.Graphics.FillRectangle(grayBrush, asteroidsRight[i]);
                }
                for (int i = 0; i < shotAbility.Count; i++)
                {
                    e.Graphics.FillRectangle(redBrush, shotAbility[i]);
                }
                for (int i = 0; i < fuel.Count; i++)
                {
                    e.Graphics.FillRectangle(blueBrush, fuel[i]);
                }
            }
            else if (gameState == "over")
            {
                scoreLabel.Text = "";

                titleLabel.Text = "Game Over";
                subtitleLabel.Text = "Press Space to Start or Esc to Exit";
                gameoverLabel.Text = $"Your score is {score}";
                abilityLabel.Text = "";
                fuelLabel.Text = "";
            }
        }
        public void GameSetup()
        {
            gameState = "running";
            
            fuelAmount = 100;

            titleLabel.Text = "";
            gameoverLabel.Text = "";
            abilityLabel.Text = $"Shots: {shotAmount}";
            fuelLabel.Text = $"Fuel: {fuelAmount}";

            gameLoop.Enabled = true;
            score = 0;
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
            int rand2Value = randGen.Next(1, 550);
            int rand3Value = randGen.Next(1, 550);
            int asteroidsizeValue = randGen.Next(1, 15);
            int fuelsize2Value = randGen.Next(1, 15);
            int shotsize3Value = randGen.Next(1, 15);
            int chance = randGen.Next(1, 500);
            if (chance < 35)
            {
                asteroidsRight.Add(new Rectangle(this.Width, randValue, asteroidsizeValue, asteroidsizeValue));
                fuel.Add(new Rectangle(this.Width, rand2Value, fuelsize2Value, fuelsize2Value));
                shotAbility.Add(new Rectangle(this.Width, rand3Value, shotsize3Value, shotsize3Value));
            }

            //move asteroid objects from right
            for (int i = 0; i < asteroidsRight.Count; i++)
            {
                int x = asteroidsRight[i].X - asteroidSpeeds;
                asteroidsRight[i] = new Rectangle(x, asteroidsRight[i].Y, asteroidsizeValue, asteroidsizeValue);
            }

            //move fuel
            for (int i = 0; i < fuel.Count; i++)
            {
                int x = fuel[i].X - fuelSpeed;
                fuel[i] = new Rectangle(x, fuel[i].Y, fuelsize2Value, fuelsize2Value);
            }

            //move ability
            for (int i = 0; i < shotAbility.Count; i++)
            {
                int x = shotAbility[i].X - shotSpeeds;
                shotAbility[i] = new Rectangle(x, shotAbility[i].Y, shotsize3Value, shotsize3Value);
            }

            //remove asteroidRight if it goes off the screen
            for (int i = 0; i < asteroidsRight.Count; i++)
            {
                if (asteroidsRight[i].X <= 0)
                {
                    asteroidsRight.RemoveAt(i);
                }
            }

            collisionCode();
           
            //Game updates
            score++;
            fuelAmount--;

            Refresh();
        }
        void collisionCode()
        {
            //Collision code
            for (int i = 0; i < asteroidsRight.Count; i++)
            {
                if (rocket.IntersectsWith(asteroidsRight[i]))
                {
                    asteroidsRight.RemoveAt(i);
                    rocket.X = 200;
                    rocket.Y = 250;
                }
            }
            for (int i = 0; i < fuel.Count; i++)
            {
                if (rocket.IntersectsWith(fuel[i]))
                {
                    fuel.RemoveAt(i);
                    fuelAmount = fuelAmount + 15;
                    
                }
            }
            for (int i = 0; i < shotAbility.Count; i++)
            {
                if (rocket.IntersectsWith(shotAbility[i]))
                {
                    shotAbility.RemoveAt(i);
                    shotAmount++;
                    if(shotAmount > 3)
                    {
                        shotAmount = 3;
                    }
                }
            }
        }
        void Ability()
        {
            Rectangle blaster = new Rectangle(1000, 1000, 20, 20);

            blaster.X = rocket.X;
            blaster.Y = rocket.Y;

            if (ability == false)
            {

            }
        }
    }
}
