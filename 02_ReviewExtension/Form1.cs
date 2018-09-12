using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ReviewExtension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //***************** Exercise 1 *****************//
        //Write a program which will simulate the tossing of 4 fair coins, 50 times. 
        //Display the results of each toss of four on a
        //separate line.If exactly 3 heads occur on a give toss, 
        //follow the line with an asterisk (*). 

        private void BtnExercise1_Click(object sender, EventArgs e)
        {
            LstView.Clear();
            int dice = 0;
            string sumOfDice = "";
            int countThreeH = 0;

            RollDice(dice, sumOfDice, countThreeH);
        }

        private void RollDice(int dice, string sumOfDice, int countThreeH)
        {
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                int countH = 0;
                sumOfDice = "";
                for (int x = 0; x < 4; x++)
                {
                    dice = r.Next(1, 3);
                    if (dice == 1)
                    {
                        sumOfDice += "H";
                        countH++;
                    }
                    else
                    {
                        sumOfDice += "T";
                    }
                    
                }
                if (countH == 3)
                {
                    countThreeH++;
                    sumOfDice += "*";
                }

                LstView.Items.Add(sumOfDice);
            }
            LstView.Items.Add("there were " + countThreeH + " toss with 3 H");
        }
    }
}
