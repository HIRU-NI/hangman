using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form1 : Form
    {

        int guesses = 3;
        String[] wordArray = { "ARGENTINA", "AUSTRALIA", "GREENLAND", "GUATEMALA","INDONESIA","LITHUANIA" };
        String newWord,currentWord,letter;
        int wordIndex = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disableLetters();
        }
        private void buttonNewWord_Click(object sender, EventArgs e)
        {
            if (wordIndex > 5)
                wordIndex = 0;
           
            newWord = wordArray[wordIndex];
            MessageBox.Show(newWord.ToLower());
            currentWord = newWord;
            //currentWord = newWord;
            enableLetters();
            buttonNewWord.Enabled = false;           
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            letter = "A";
            checkLetter();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            letter = "B";
            checkLetter();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            letter = "C";
            checkLetter();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            letter = "D";
            checkLetter();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            letter = "E";
            checkLetter();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            letter = "F";
            checkLetter();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            letter = "G";
            checkLetter();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            letter = "H";
            checkLetter();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            letter = "I";
            checkLetter();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            letter = "J";
            checkLetter();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            letter = "K";
            checkLetter();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            letter = "L";
            checkLetter();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            letter = "M";
            checkLetter();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            letter = "N";
            checkLetter();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            letter = "O";
            checkLetter();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            letter = "P";
            checkLetter();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            letter = "Q";
            checkLetter();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            letter = "R";
            checkLetter();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            letter = "S";
            checkLetter();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            letter = "T";
            checkLetter();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            letter = "U";
            checkLetter();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            letter = "V";
            checkLetter();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            letter = "W";
            checkLetter();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            letter = "X";
            checkLetter();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            letter = "Y";
            checkLetter();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            letter = "Z";
            checkLetter();
        }

        void checkLetter()
        {
            String text;
            int index;
            
            if(currentWord.Contains(letter))
            {
                text = textWord.Text;
                index = currentWord.IndexOf(letter);
                text = text.Remove(index,1);
                text = text.Insert(index, letter);
                currentWord = currentWord.Remove(index,1);
                currentWord = currentWord.Insert(index, "*");
               // MessageBox.Show(currentWord);
                textWord.Text = text;
                if(textWord.Text == newWord)
                {
                    MessageBox.Show("Well Done!!");
                    resetGame();
                }

            }
            else
            {
                guesses--;
                labelGuesses.Text = guesses.ToString();
                if (guesses == 0)
                {
                    disableLetters();
                    MessageBox.Show(string.Format("Sorry! You're out of guesses!!\n The Correct word was {0}",wordArray[wordIndex]));
                    resetGame();

                }
            }
        }

        void resetGame()
        {
            disableLetters();
            buttonNewWord.Enabled = true;
            wordIndex++;
            guesses = 3;
            textWord.Text = "*********";
            labelGuesses.Text = guesses.ToString();
        }

        void disableLetters()
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
            buttonG.Enabled = false;
            buttonH.Enabled = false;
            buttonI.Enabled = false;
            buttonJ.Enabled = false;
            buttonK.Enabled = false;
            buttonL.Enabled = false;
            buttonM.Enabled = false;
            buttonN.Enabled = false;
            buttonO.Enabled = false;
            buttonP.Enabled = false;
            buttonQ.Enabled = false;
            buttonR.Enabled = false;
            buttonS.Enabled = false;
            buttonT.Enabled = false;
            buttonU.Enabled = false;
            buttonV.Enabled = false;
            buttonW.Enabled = false;
            buttonX.Enabled = false;
            buttonY.Enabled = false;
            buttonZ.Enabled = false;
        }

        

        void enableLetters()
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
        }

    }
}
