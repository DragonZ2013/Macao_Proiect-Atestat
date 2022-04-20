using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Macao
{
    public partial class Form1 : Form
    {
        int ResX, ResY, Fullscr;
        
        void getSettings()
        {
            int k = 0;
            foreach (string line in File.ReadLines("Options.txt"))
            {if (k == 0)
                    ResX = Convert.ToInt32(line);
                if (k == 1)
                    ResY = Convert.ToInt32(line);
                if (k == 2)
                    Fullscr = Convert.ToInt32(line);
                k++;
            }
        }
        public Form1()
        {
            InitializeComponent();
            getSettings();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSettings();
            Form2 FormGame = new Form2(ResX, ResY, Fullscr);
            FormGame.Owner= this;
            FormGame.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult valRes = MessageBox.Show("Are you sure you want to exit?", "Exit confirmation", MessageBoxButtons.YesNo);
            if (valRes == DialogResult.Yes)
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Scopul jocului: trebuie sa joci toate cartile pe care le ai in mana pana le termini
Cartile pot fi jucate pe carti de acelasi simbol sau cu acelasi numar
Daca un jucator are perechi acesta le poate juca intr-o singura tura
Carti speciale:
7 - Poate schimba culoarea in alta decat cea a cartii
2,3,Joker - Obliga oponentul sa joace o carte de acest tip sau sa ia din pachet 2,3 respectiv 5 carti (care se adauga daca sunt jucate mai multe carti)
Dupa ce o carte de acest tip este jucata oricare din cartile cu interactiuni similare pot fi adaugate peste
As - Obliga oponentul sa joace o carte de acest tip sau sa astepte 1 tura (care se adauga daca sunt jucate mai multe carti)
4 - Opreste obligatiile de orice tip

");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getSettings();
            Form3 FormOptions = new Form3(ResX, ResY, Fullscr);
            FormOptions.Owner = this;
            FormOptions.Show();
            this.Hide();
        }
    }
}
