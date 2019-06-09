namespace HangmanGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNewWord = new System.Windows.Forms.Button();
            this.textWord = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewWord
            // 
            this.buttonNewWord.BackColor = System.Drawing.Color.White;
            this.buttonNewWord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNewWord.Location = new System.Drawing.Point(250, 26);
            this.buttonNewWord.Name = "buttonNewWord";
            this.buttonNewWord.Size = new System.Drawing.Size(136, 36);
            this.buttonNewWord.TabIndex = 0;
            this.buttonNewWord.Text = "New Word";
            this.buttonNewWord.UseVisualStyleBackColor = false;
            this.buttonNewWord.Click += new System.EventHandler(this.buttonNewWord_Click);
            // 
            // textWord
            // 
            this.textWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWord.Location = new System.Drawing.Point(217, 91);
            this.textWord.Multiline = true;
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(207, 39);
            this.textWord.TabIndex = 1;
            this.textWord.Text = "*********";
            this.textWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonA.ForeColor = System.Drawing.Color.Black;
            this.buttonA.Location = new System.Drawing.Point(72, 163);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(54, 48);
            this.buttonA.TabIndex = 2;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonB.ForeColor = System.Drawing.Color.Black;
            this.buttonB.Location = new System.Drawing.Point(148, 163);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(54, 48);
            this.buttonB.TabIndex = 3;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonC.ForeColor = System.Drawing.Color.Black;
            this.buttonC.Location = new System.Drawing.Point(226, 163);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(54, 48);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonE.ForeColor = System.Drawing.Color.Black;
            this.buttonE.Location = new System.Drawing.Point(386, 163);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(54, 48);
            this.buttonE.TabIndex = 5;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonD.ForeColor = System.Drawing.Color.Black;
            this.buttonD.Location = new System.Drawing.Point(305, 163);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(54, 48);
            this.buttonD.TabIndex = 6;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonG.ForeColor = System.Drawing.Color.Black;
            this.buttonG.Location = new System.Drawing.Point(540, 163);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(54, 48);
            this.buttonG.TabIndex = 7;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonF.ForeColor = System.Drawing.Color.Black;
            this.buttonF.Location = new System.Drawing.Point(460, 163);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(54, 48);
            this.buttonF.TabIndex = 8;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // buttonM
            // 
            this.buttonM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonM.ForeColor = System.Drawing.Color.Black;
            this.buttonM.Location = new System.Drawing.Point(460, 235);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(54, 48);
            this.buttonM.TabIndex = 15;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = false;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonN
            // 
            this.buttonN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonN.ForeColor = System.Drawing.Color.Black;
            this.buttonN.Location = new System.Drawing.Point(540, 235);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(54, 48);
            this.buttonN.TabIndex = 14;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = false;
            this.buttonN.Click += new System.EventHandler(this.buttonN_Click);
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonK.ForeColor = System.Drawing.Color.Black;
            this.buttonK.Location = new System.Drawing.Point(305, 235);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(54, 48);
            this.buttonK.TabIndex = 13;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = false;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // buttonL
            // 
            this.buttonL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonL.ForeColor = System.Drawing.Color.Black;
            this.buttonL.Location = new System.Drawing.Point(386, 235);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(54, 48);
            this.buttonL.TabIndex = 12;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = false;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonJ
            // 
            this.buttonJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonJ.ForeColor = System.Drawing.Color.Black;
            this.buttonJ.Location = new System.Drawing.Point(226, 235);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(54, 48);
            this.buttonJ.TabIndex = 11;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = false;
            this.buttonJ.Click += new System.EventHandler(this.buttonJ_Click);
            // 
            // buttonI
            // 
            this.buttonI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonI.ForeColor = System.Drawing.Color.Black;
            this.buttonI.Location = new System.Drawing.Point(148, 235);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(54, 48);
            this.buttonI.TabIndex = 10;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = false;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonH
            // 
            this.buttonH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonH.ForeColor = System.Drawing.Color.Black;
            this.buttonH.Location = new System.Drawing.Point(72, 235);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(54, 48);
            this.buttonH.TabIndex = 9;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = false;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonT.ForeColor = System.Drawing.Color.Black;
            this.buttonT.Location = new System.Drawing.Point(460, 303);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(54, 48);
            this.buttonT.TabIndex = 22;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonU
            // 
            this.buttonU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonU.ForeColor = System.Drawing.Color.Black;
            this.buttonU.Location = new System.Drawing.Point(540, 303);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(54, 48);
            this.buttonU.TabIndex = 21;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = false;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonR.ForeColor = System.Drawing.Color.Black;
            this.buttonR.Location = new System.Drawing.Point(305, 303);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(54, 48);
            this.buttonR.TabIndex = 20;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonS.ForeColor = System.Drawing.Color.Black;
            this.buttonS.Location = new System.Drawing.Point(386, 303);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(54, 48);
            this.buttonS.TabIndex = 19;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonQ
            // 
            this.buttonQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonQ.ForeColor = System.Drawing.Color.Black;
            this.buttonQ.Location = new System.Drawing.Point(226, 303);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(54, 48);
            this.buttonQ.TabIndex = 18;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = false;
            this.buttonQ.Click += new System.EventHandler(this.buttonQ_Click);
            // 
            // buttonP
            // 
            this.buttonP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonP.ForeColor = System.Drawing.Color.Black;
            this.buttonP.Location = new System.Drawing.Point(148, 303);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(54, 48);
            this.buttonP.TabIndex = 17;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = false;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonO
            // 
            this.buttonO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonO.ForeColor = System.Drawing.Color.Black;
            this.buttonO.Location = new System.Drawing.Point(72, 303);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(54, 48);
            this.buttonO.TabIndex = 16;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = false;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // buttonZ
            // 
            this.buttonZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZ.ForeColor = System.Drawing.Color.Black;
            this.buttonZ.Location = new System.Drawing.Point(460, 373);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(54, 48);
            this.buttonZ.TabIndex = 29;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = false;
            this.buttonZ.Click += new System.EventHandler(this.buttonZ_Click);
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonX.ForeColor = System.Drawing.Color.Black;
            this.buttonX.Location = new System.Drawing.Point(305, 373);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(54, 48);
            this.buttonX.TabIndex = 27;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonY
            // 
            this.buttonY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonY.ForeColor = System.Drawing.Color.Black;
            this.buttonY.Location = new System.Drawing.Point(386, 373);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(54, 48);
            this.buttonY.TabIndex = 26;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = false;
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonW
            // 
            this.buttonW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonW.ForeColor = System.Drawing.Color.Black;
            this.buttonW.Location = new System.Drawing.Point(226, 373);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(54, 48);
            this.buttonW.TabIndex = 25;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = false;
            this.buttonW.Click += new System.EventHandler(this.buttonW_Click);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonV.ForeColor = System.Drawing.Color.Black;
            this.buttonV.Location = new System.Drawing.Point(148, 373);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(54, 48);
            this.buttonV.TabIndex = 24;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Number of Guesses Remaining :";
            // 
            // labelGuesses
            // 
            this.labelGuesses.AutoSize = true;
            this.labelGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuesses.Location = new System.Drawing.Point(365, 456);
            this.labelGuesses.Name = "labelGuesses";
            this.labelGuesses.Size = new System.Drawing.Size(21, 24);
            this.labelGuesses.TabIndex = 31;
            this.labelGuesses.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(645, 496);
            this.Controls.Add(this.labelGuesses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.textWord);
            this.Controls.Add(this.buttonNewWord);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewWord;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGuesses;
    }
}

