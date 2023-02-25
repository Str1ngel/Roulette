using Microsoft.VisualBasic.Logging;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ObjectiveC;

namespace GUI
{
    public partial class Form1 : Form
    {
        string dataLocation = "../../../data/french_layout.txt";
        Size buttonSize = new(70, 60);
        public int betAmount = 500;
        Point lastButtonLocation = new(0,0);
        Random rnd = new Random();

        public struct mapData
        {
            public mapData(char Color, int Number)
            {
                this.color = Color;
                this.number = Number;
            }
            public char color { get; set; }
            public int number { get; set; }
        }
        mapData[,] dataStructs = new mapData[12,3];
        public Form1()
        {
            InitializeComponent();
        }

        void OnLoad(object sender, EventArgs e)
        {
            using
            (StreamReader sr = new(dataLocation))
            {
                _ = sr.ReadLine();

                for (int i = 0; i < dataStructs.GetLength(0); i++)
                {

                    string[] data = sr.ReadLine().Split(';');
                    for (int j = 0; j < dataStructs.GetLength(1); j++)
                    {

                        dataStructs[i, j].color = data[j].First();
                        dataStructs[i, j].number = Convert.ToInt16(data[j].Remove(0, 1));

                    }
                }
            }
            Generation();
        }
        public void BetPlaceing(object sender, EventArgs args)
        {
            if (betAmount <= 0 || betAmount > Convert.ToInt64(userMoney.Text.Split(' ')[1].Remove(userMoney.Text.Split(' ')[1].Length-2, 2)))
            {
                MessageBox.Show("Kérlek érvényes tétel értéket adjon meg!", "Probléma!");
                return;
            }

            if (sender is Label)
                BetAmountAdder(sender as Label);

            if (sender is not Button)
                return;

            Label existLabel = Controls.Find($"{(sender as Button).Text}label", true).FirstOrDefault() as Label;

            if (existLabel is not null)
                BetAmountAdder(existLabel);
            else
                ClickEventButton(sender as Button);
        }
        void BetAmountAdder(Label sender)
        {
            userMoney.Text = $"Pénz: {Convert.ToInt64(userMoney.Text.Split(' ')[1].Remove(userMoney.Text.Split(' ')[1].Length - 2, 2)) - betAmount}Ft";
            sender.Text = (Convert.ToInt64(sender.Text.Remove(sender.Text.Length -2 , 2)) + betAmount + "Ft").ToString();
        }
        void ClickEventButton(Button sender)
        {
            Label currentBet = new();
            currentBet.Tag = sender.Name;
            currentBet.Parent = sender;
            currentBet.Size = new(sender.Width - 20, 17);
            currentBet.Location = new Point(sender.Location.X + 10, sender.Location.Y + sender.Height - 27);
            currentBet.Text = $"{betAmount}Ft";
            currentBet.Visible = true;
            currentBet.Name = $"{sender.Text}label";
            currentBet.TextAlign = ContentAlignment.BottomCenter;
            currentBet.Click += BetPlaceing;
            currentBet.BackColor = sender.BackColor;
            currentBet.AutoSize = true;

            Controls.Add(currentBet);

            currentBet.BringToFront();
            userMoney.Text = $"Pénz: {Convert.ToInt64(userMoney.Text.Split(' ')[1].Remove(userMoney.Text.Split(' ')[1].Length - 2, 2)) - betAmount}Ft";

        }
        void Generation()
        {
            Point startPosition = new((this.Size.Width / 2) - (buttonSize.Width / 2) - buttonSize.Width, 5);

            selectedValueLabel.AutoSize = true;

            betValueRichTextBox.MaxLength = 9;

            RulletButtonGeneration(
                new(buttonSize.Width*3, 
                buttonSize.Height), 
                new Point(startPosition.X, startPosition.Y), 
                "0", 
                Color.Green, 
                BetPlaceing);

            for (int i = 0; i < dataStructs.GetLength(0); i++)
            {
                for (int j = 0; j < dataStructs.GetLength(1); j++)
                {
                    RulletButtonGeneration(
                        buttonSize,
                        new Point(
                        startPosition.X + (j * buttonSize.Width),
                        startPosition.Y + (i + 1) * buttonSize.Width),
                        Convert.ToString(dataStructs[i, j].number),
                        (dataStructs[i, j].color == 'R')
                            ? Color.Red
                            : Color.Blue,
                        BetPlaceing);
                    lastButtonLocation = new(startPosition.X + (j * buttonSize.Width), startPosition.Y + (i + 1) * buttonSize.Width);
                }

            }

            Label betLabel = new();

            betLabel.AutoSize = true;
            betLabel.Location = new(startPosition.X + (betLabel.Size.Width / 2), lastButtonLocation.Y + buttonSize.Height );
            //System.Diagnostics.Debug.WriteLine(betLabel.Location.X);
            //System.Diagnostics.Debug.WriteLine(betLabel.Location.Y);
            betLabel.Text = "Tét Választása:";
            betLabel.Name = "betLabel";
            betLabel.BackColor = BackColor;
            betLabel.BringToFront();

            Controls.Add(betLabel);


            Button placeBetButton = new();

            placeBetButton.Location = new(startPosition.X + (buttonSize.Width / 2), betLabel.Location.Y + betLabel.Size.Height);
            placeBetButton.Size = new(buttonSize.Width * 2, buttonSize.Height);
            placeBetButton.Text = "Tét Megrakása!";
            placeBetButton.BackColor = Color.White;
            placeBetButton.Name = "placeBetButton";
            placeBetButton.Click += PlaceBet_OnClick;

            Controls.Add(placeBetButton);
        }
        void RulletButtonGeneration(Size buttonSize, Point buttonLocation, string buttonText, Color buttonColor, EventHandler buttonClickState = null)
        {
            Button button = new();

            button.Name = $"button{Text}";
            button.Size = buttonSize;
            button.Location = buttonLocation;
            button.Text = buttonText;
            button.TextAlign = ContentAlignment.TopCenter;
            button.BackColor = buttonColor;
            button.Click += buttonClickState;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.MouseOverBackColor = buttonColor;
            button.FlatAppearance.MouseDownBackColor = buttonColor;
            Controls.Add(button);
        }
        void PlaceBet_OnClick(object sender, EventArgs e)
        {
            ChangeingBet(sender, e);
            
            int randomWinner = rnd.Next(0, 37);
            bool redEnable = true;
            bool blueEnable = false;

        }

        void ChangeingBet(object sender, EventArgs e)
        {
            if (sender is RichTextBox)
            {
                int.TryParse(betValueRichTextBox.Text, out betAmount);
                selectedValueLabel.Text = $"Kiválasztott Tétel: {betAmount}Ft";
            }
        }
    }
}