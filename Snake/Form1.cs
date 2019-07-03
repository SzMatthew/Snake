using Snake.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeForm : Form
    {
        private List<Rectangle> Snake = new List<Rectangle>();
        private Rectangle bait = new Rectangle();

        public SnakeForm()
        {
            InitializeComponent();

            //Set defaults settings
            new Settings();

            //Set game speed and start timer
            game_timer.Interval = 1000 / Settings.Speed;
            game_timer.Tick += UpdateScreen;
            game_timer.Start();

            //Start new game
            StartGme();
        }

        private void StartGme()
        {
            lblGameOver.Visible = false;
            lblHighestScore.Text = System.IO.File.ReadAllText("..\\HighestScore.txt");

            //Set default settings
            new Settings();

            //Create new snake
            Snake.Clear();
            Rectangle head = new Rectangle();
            head.posX = 0;
            head.posY = 0;
            Snake.Add(head);

            current_score.Text = Settings.Score.ToString();

            //First bait
            GenerateBait();
        }

        //Put a bait on to the screen
        private void GenerateBait()
        {
            int maxX = pbCanvas.Size.Width / Settings.Width;
            int maxY = pbCanvas.Size.Height / Settings.Heigth;

            Random rand = new Random();
            bait = new Rectangle();
            bait.posX = rand.Next(0, maxX);
            bait.posY = rand.Next(0, maxY);
        }

        //Update the screen
        private void UpdateScreen (object sender, EventArgs e)
        {
            //Check if game is over
            if (Settings.GameOver == true)
            {
                //Chech if enter is pressed
                if (Input.KeyPressDetect(Keys.Enter))
                {
                    StartGme();
                }
            }
            else
            {
                if (Input.KeyPressDetect(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if(Input.KeyPressDetect(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressDetect(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressDetect(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                Brush snakeColour;

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Draw head
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else //Rest of the body
                    {
                        snakeColour = Brushes.Green;
                        if (i % 2 == 0)  
                            snakeColour = Brushes.Green;   
                        else
                            snakeColour = Brushes.Gray
                                ;
                    }
                    //Draw snake
                    canvas.FillRectangle(snakeColour, new RectangleF(Snake[i].posX * Settings.Width, Snake[i].posY * Settings.Heigth, Settings.Width, Settings.Heigth));

                    //Draw Bait
                    canvas.FillRectangle(Brushes.Red, new RectangleF(bait.posX * Settings.Width, bait.posY * Settings.Heigth, Settings.Width, Settings.Heigth));
                }
            }
            else
            {
                string gameOver = "Game over \nYour final score is: " + Settings.Score + "\nPress ENTER to start a new game";
                if (Settings.Score > Int32.Parse(System.IO.File.ReadAllText("..\\HighestScore.txt"))) 
                    System.IO.File.WriteAllText("..\\HighestScore.txt", Settings.Score.ToString());
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
                lblHighestScore.Text = System.IO.File.ReadAllText("..\\HighestScore.txt");
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count-1; i>=0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].posX++;
                            break;
                        case Direction.Left:
                            Snake[i].posX--;
                            break;
                        case Direction.Up:
                            Snake[i].posY--;
                            break;
                        case Direction.Down:
                            Snake[i].posY++;
                            break;
                    }

                    //Get maximum X and Y Position
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Heigth;

                    //Collosion with borders
                    if (Snake[i].posX < 0 || Snake[i].posY < 0 || Snake[i].posX >= maxXPos || Snake[i].posY >= maxYPos)
                    {
                        Die();
                    }

                    //Detect collosion with body
                    for (int j=1; j< Snake.Count; j++)
                    {
                        if (Snake[i].posX == Snake[j].posX && Snake[i].posY == Snake[j].posY) {
                            Die();
                        }
                    }

                    //Detect collosion with bait
                    if (Snake[0].posX == bait.posX && Snake[0].posY == bait.posY)
                    {
                        Eat();
                    }
                    
                }
                else
                {
                    //Move body
                    Snake[i].posX = Snake[i-1].posX;
                    Snake[i].posY = Snake[i - 1].posY;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat ()
        {
            //Add rectangle to body
            Rectangle bait = new Rectangle();
            bait.posX = Snake[Snake.Count - 1].posX;
            bait.posY = Snake[Snake.Count - 1].posY;

            Snake.Add(bait);

            //Update score
            Settings.Score += 100;
            current_score.Text = Settings.Score.ToString();

            GenerateBait();
        }
    }
}
