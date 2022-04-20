using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Macao
{
    
    public partial class Form2 : Form
    {

        List<PictureBox> CardList = new List<PictureBox>();
        int currentPage = 1, pageCount = 1, playerWait = 0;
        bool ok=false,aiTurn=false,punish=false;
        //bool SpinUntil(ok);
        Color warn = Color.Firebrick, basecolor = Color.AliceBlue;
        Macao.Deck_Of_Cards Game = new Macao.Deck_Of_Cards();
        void UpdatePageCount()
        {
            int count = Game.handSize;
            pageCount = count / 6+1;
            if (count % 6 == 0)
                pageCount--;
            
        }
        bool CheckEnd()
        {
            if (Game.handSize == 0)
            {
                timer1.Enabled = false;
                timerAiRound.Enabled = false;
                MessageBox.Show("You win!");
                return true;
            }
            if (Game.aiSize == 0)
            {
                timer1.Enabled = false;
                timerAiRound.Enabled = false;
                MessageBox.Show("AI wins!");
                return true;
            }
            return false;
        }
        void UpdateHand(int x)
        { int q = 6 * (x - 1);
            int fin=q+6,j = q + 6;
            if (j > Game.handSize)
                j = Game.handSize;
            int i;
            for(i=q;i<j;i++)
                CardList[i%6].ImageLocation  = "Resources/" + Convert.ToString(Game.hand[i+1].Rank) + "_" + Convert.ToString(Game.hand[i+1].Suit) + ".jpg";
                
            for(int p=i;p<fin;p++)
                CardList[p % 6].ImageLocation = "Resources/Back.jpg";
        }
        string CardColor(int x)
        {
            if (x == 0)
                return "Hearts";
            if (x == 1)
                return "Diamonds";
            if (x == 2)
                return "Clubs";
            if (x == 3)
                return "Spades";
            else
                return "Any";
        }
        string CardNumber(int x)
        {
            if (x == 0)
                return "Any";
            if (x == 1)
                return "Ace";
            if (x == 11)
                return "Jack";
            if (x == 12)
                return "Queen";
            if (x == 13)
                return "King";
            else
                return Convert.ToString(x);
        }


        void CheckLims()
        {
            if (currentPage == 1)
                button2.Enabled = false;
            else
                button2.Enabled = true;
            if (currentPage == pageCount)
                button3.Enabled = false;
            else
                button3.Enabled = true;
        }

        public Form2(int ResX,int ResY,int Fullscr)
        {
            
            InitializeComponent();
            if (Fullscr == 1)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            this.Width = ResX;
            this.Height = ResY;
            //int SizeCardHeight = this.Height / 7, SizeCardWidth = SizeCardHeight;
            //pictureBoxTable.Width = SizeCardWidth;
            CardList.Add((PictureBox)Controls.Find("pictureBox1", true)[0]);
            CardList.Add((PictureBox)Controls.Find("pictureBox2", true)[0]);
            CardList.Add((PictureBox)Controls.Find("pictureBox3", true)[0]);
            CardList.Add((PictureBox)Controls.Find("pictureBox4", true)[0]);
            CardList.Add((PictureBox)Controls.Find("pictureBox5", true)[0]);
            CardList.Add((PictureBox)Controls.Find("pictureBox6", true)[0]);
            buttonMacao.BackColor = basecolor;

            Game.NewDeck();
            Game.TableDraw();
            Game.PlayerDraw(5);
            UpdatePageCount();
            labelPageTotal.Text = Convert.ToString(pageCount);
            UpdateHand(1);
            CheckLims();
            Game.AiDraw(5);
            pictureBoxTable.ImageLocation = "Resources/"+Convert.ToString(Game.rankTable)+"_"+Convert.ToString(Game.suitTable)+".jpg";
            labelColor.Text = CardColor(Game.suitTable);
            labelNr.Text = CardNumber(Game.rankTable);
            labelCartiAi.Text = Convert.ToString(Game.aiSize);
            labelCartiPlayer.Text = Convert.ToString(Game.handSize);
            labelDraw.Text = Convert.ToString(Game.drawTable);
            labelWait.Text = Convert.ToString(Game.waitTable);
            buttonMacao.Enabled = false;




        }



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult valRes = MessageBox.Show("Are you sure you want to return to the menu?", "Exit confirmation", MessageBoxButtons.YesNo);
            if (valRes == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            currentPage--;
            CheckLims();
            labelPageCurrent.Text = Convert.ToString(currentPage);
            UpdateHand(currentPage);
        }

        private void updateTable()
        {
            labelCartiAi.Text = Convert.ToString(Game.aiSize);
            pictureBoxTable.ImageLocation = "Resources/" + Convert.ToString(Game.rankTable) + "_" + Convert.ToString(Game.suitTable) + ".jpg";
            labelColor.Text = CardColor(Game.suitTable);
            labelNr.Text = CardNumber(Game.rankTable);
            labelDraw.Text = Convert.ToString(Game.drawTable);
            labelCartiPlayer.Text = Convert.ToString(Game.handSize);
            labelWait.Text = Convert.ToString(Game.waitTable);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 1]))
            {
                
                Game.PlayPlayer((currentPage - 1) * 6 + 1);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable();
                if (Game.rankTable == 7)
                    ok = true;
                
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;
                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1)
                {
                    timer1.Start();
                    punish = true;
                    buttonMacao.Enabled = true;
                    buttonMacao.BackColor = warn;
                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 2]))
            {
                Game.PlayPlayer((currentPage - 1) * 6 + 2);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable(); 
                if (Game.rankTable == 7)
                    ok = true;
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;
                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1)
                {
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    punish = true;
                    buttonMacao.BackColor = warn;

                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 3]))
            {
                Game.PlayPlayer((currentPage - 1) * 6 + 3);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable();
                if (Game.rankTable == 7)
                    ok = true;
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;

                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1)
                {
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    punish = true;
                    buttonMacao.BackColor = warn;
                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 4]))
            {
                Game.PlayPlayer((currentPage - 1) * 6 + 4);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable();
                if (Game.rankTable == 7)
                    ok = true;
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;
                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1 )
                {
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    punish = true;
                    buttonMacao.BackColor = warn;
                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 5]))
            {
                Game.PlayPlayer((currentPage - 1) * 6 + 5);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable();
                if (Game.rankTable == 7)
                    ok = true;
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;
                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1 )
                {
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    punish = true;
                    buttonMacao.BackColor = warn;
                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            if (Game.Playable(Game.hand[(currentPage - 1) * 6 + 6]))
            {
                Game.PlayPlayer((currentPage - 1) * 6 + 6);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                currentPage = 1;
                labelPageCurrent.Text = Convert.ToString(currentPage);
                updateTable();
                if (Game.rankTable == 7)
                    ok = true;
                if (ok == true)
                {
                    buttonPlay7_Clubs.Visible = true;
                    buttonPlay7_Hearts.Visible = true;
                    buttonPlay7_Spades.Visible = true;
                    buttonPlay7_Diamonds.Visible = true;
                }
                else
                {

                    timerAiRound.Enabled = true;
                    aiTurn = true;
                    label8.Visible = true;
                }
                UpdateHand(1);

                CheckLims();
                if (Game.handSize == 1)
                {
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    punish = true;
                    buttonMacao.BackColor = warn;
                }
                if (CheckEnd())
                    this.Close();
            }
            else
                MessageBox.Show("Can't play this card");
        }

        private void buttonPlay7_Hearts_Click(object sender, EventArgs e)
        {
            buttonPlay7_Clubs.Visible = false;
            buttonPlay7_Spades.Visible = false;
            buttonPlay7_Diamonds.Visible = false;
            buttonPlay7_Hearts.Visible = false;
            Game.suitTable = 0;
            labelColor.Text = CardColor(Game.suitTable);
            pictureBoxTable.ImageLocation = "Resources/7_0.jpg";
            ok = false;
            timerAiRound.Enabled = true;
        }

        private void buttonPlay7_Diamonds_Click(object sender, EventArgs e)
        {
            buttonPlay7_Clubs.Visible = false;
            buttonPlay7_Spades.Visible = false;
            buttonPlay7_Diamonds.Visible = false;
            buttonPlay7_Hearts.Visible = false;
            Game.suitTable = 1;
            labelColor.Text = CardColor(Game.suitTable);
            pictureBoxTable.ImageLocation = "Resources/7_1.jpg";
            ok = false;
            timerAiRound.Enabled = true;
        }

        private void buttonPlay7_Clubs_Click(object sender, EventArgs e)
        {
            buttonPlay7_Clubs.Visible = false;
            buttonPlay7_Spades.Visible = false;
            buttonPlay7_Diamonds.Visible = false;
            buttonPlay7_Hearts.Visible = false;
            Game.suitTable = 2;
            labelColor.Text = CardColor(Game.suitTable);
            pictureBoxTable.ImageLocation = "Resources/7_2.jpg";
            ok = false;
            timerAiRound.Enabled = true;
        }


        private void buttonPlay7_Spades_Click(object sender, EventArgs e)
        {
            buttonPlay7_Clubs.Visible = false;
            buttonPlay7_Spades.Visible = false;
            buttonPlay7_Diamonds.Visible = false;
            buttonPlay7_Hearts.Visible = false;
            Game.suitTable = 3;
            labelColor.Text = CardColor(Game.suitTable);
            pictureBoxTable.ImageLocation = "Resources/7_3.jpg";
            ok = false;
            timerAiRound.Enabled = true;
        }

        private void timerAiRound_Tick(object sender, EventArgs e)
        {


            if (Game.aiWait == 0)
            {
                label8.Visible = true;
                Game.AIRound();
                updateTable();
                if (Game.aiSize == 1)
                {
                    punish = false;
                    timer1.Start();
                    buttonMacao.Enabled = true;
                    buttonMacao.BackColor = warn;
                }
                aiTurn = false;
            }
            else
            { Game.aiWait--;
                aiTurn = false;
            }
            if (playerWait == 0)
            {
                label8.Visible = false;
                timerAiRound.Enabled = false;

            }
            else
            {
                playerWait--;
                aiTurn = true;
            }
            if (CheckEnd())
                this.Close();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (aiTurn == true)
                MessageBox.Show("Tura botului");
            else
            {
                
                if (Game.waitTable != 0)
                {
                    timerAiRound.Enabled = true;
                    playerWait = Game.waitTable-1;
                    Game.waitTable = 0;

                }
                else
                if (Game.drawTable == 0)
                    Game.PlayerDraw(1);

                else
                {
                    Game.PlayerDraw(Game.drawTable);
                    Game.drawTable = 0;
                }

                UpdatePageCount();
                updateTable();
                labelPageTotal.Text = Convert.ToString(pageCount);
                labelPageCurrent.Text = labelPageTotal.Text;
                currentPage = pageCount;
                UpdateHand(pageCount);
                timerAiRound.Enabled = true;
                aiTurn = true;
                label8.Visible = true;
                CheckLims();
                if (CheckEnd())
                    this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonMacao.Enabled = false;
            buttonMacao.BackColor = basecolor;
            if (punish == true)
            {
                Game.PlayerDraw(5);
                UpdatePageCount();
                labelPageTotal.Text = Convert.ToString(pageCount);
                labelPageCurrent.Text = labelPageTotal.Text;
                UpdateHand(pageCount);

            }

            }

        private void buttonMacao_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonMacao.Enabled = false;
            buttonMacao.BackColor = basecolor;
            if (punish==false)
            {
                Game.AiDraw(5);
                labelCartiAi.Text = Convert.ToString(Game.aiSize);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentPage ++;
            CheckLims();
            labelPageCurrent.Text = Convert.ToString(currentPage);
            
            UpdateHand(currentPage);
        }
    }
}
