using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BubbleBreaker
{
    public partial class Form1 : Form
    {
        int gamemode;   //0 - normal, 1 - megashifter
        int gamesize; 
        int width = 10;
        int height = 10;
        int size ;//= width * height;
        int startx = 37;
        int starty = 306;
        int[] leftary;
        int leftcount;
        int[] rightary;
        int rightcount;
        int[] uparray;
        int upcount;
        int[] downarray;
        int downcount;
        int[] cell;
        int[] filled;
        int[] backupcell;
        int[] backupfilled;
        int backupscore;
        int score;
        int totalscore;
        int pen;

        public Form1()
        {
            InitializeComponent();
            gamemode = 0;
            gamesize = 0;  //0 -> small, 1 -> large
            score = 0;
            totalscore = 0;
            size = width * height;
            pen = 0;

            cell = new int[size];
            filled = new int[size];
            backupcell = new int[size];
            backupfilled = new int[size];
            leftary = new int[width];
            rightary = new int[width - 1];
            uparray = new int[size];
            downarray = new int[size];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemode = 0;
            label2.Text = "Normal";
            normalToolStripMenuItem.Checked = true;
            shifterToolStripMenuItem.Checked = false;
            megashifterToolStripMenuItem.Checked = false;
        }

        private void shifterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemode = 1;
            label2.Text = "Shifter";
            normalToolStripMenuItem.Checked = false;
            shifterToolStripMenuItem.Checked = true;
            megashifterToolStripMenuItem.Checked = false;
        }

        private void megashifterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamemode = 2;
            label2.Text = "Megashifter";
            normalToolStripMenuItem.Checked = false;
            shifterToolStripMenuItem.Checked = false;
            megashifterToolStripMenuItem.Checked = true;
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int q = 0; q < size; q++)
            {
                filled[q] = backupfilled[q];
                cell[q] = backupcell[q];
            }
            totalscore = backupscore;

            changenormal();
            label5.Text = "0";
            label4.Text = totalscore.ToString();
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            for (int x = 0; x < 120; x++)
            {
                string temp = "pictureBox" + Convert.ToString(x + 1);
                Control[] c = this.Controls.Find(temp, true);

                PictureBox p = (PictureBox)c[0];
                p.Visible = false;
                p.Enabled = false;
            }

            Random num = new Random();
            int rows;
            int col = 0;
            label4.Text = "0";
            label5.Text = "0";
            score = 0;
            totalscore = 0;

            if (gamesize == 1)
            {
                width = 5;
                height = 10;
                size = width * height;

                startx = 50;
                starty = 342;
            }
            else if (gamesize == 0)
            {
                size = width * height;

                startx = 37;
                starty = 306;
            }

            for (int q = 0; q < size; q++)
            {
                cell[q] = num.Next(5);
                string temp = "pictureBox" + Convert.ToString(q + 1);
                Control[] c = this.Controls.Find(temp, true);

                PictureBox p = (PictureBox)c[0];
                p.Visible = true;
                p.Enabled = true;

                rows = q / width;
                col = q % width;

                if (gamesize == 1)
                {
                    if (p.Width == 20)
                    {
                        p.Width += 10;
                        p.Height += 10;
                    }

                    p.Location = new Point(startx + col * 30, starty - rows * 30);

                    if (cell[q] == 0)
                        p.ImageLocation = "Red.jpg";
                    else if (cell[q] == 1)
                        p.ImageLocation = "Green.jpg";
                    else if (cell[q] == 2)
                        p.ImageLocation = "Blue.jpg";
                    else if (cell[q] == 3)
                        p.ImageLocation = "Yellow.jpg";
                    else if ((cell[q] == 4))
                        p.ImageLocation = "Purple.jpg";
                }
                else if (gamesize == 0)
                {
                    if (p.Width == 30)
                    {
                        p.Width -= 10;
                        p.Height -= 10;
                    }

                    p.Location = new Point(startx + col * 20, starty - rows * 20);

                    if (cell[q] == 0)
                        p.ImageLocation = "RedSmall.jpg";
                    else if (cell[q] == 1)
                        p.ImageLocation = "GreenSmall.jpg";
                    else if (cell[q] == 2)
                        p.ImageLocation = "BlueSmall.jpg";
                    else if (cell[q] == 3)
                        p.ImageLocation = "YellowSmall.jpg";
                    else if ((cell[q] == 4))
                        p.ImageLocation = "PurpleSmall.jpg";
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Text = "0";
            changenormal();
        }

        /*bubble breaker code */
        private void coloredgrpup(int start, int colorval)
        {
            if (start < (width * (height - 1) + 1))
            {
                //down search
                int up = start + width;
                if (up > (width * height))
                {
                    if (cell[up - 1] == colorval)
                    {
                        uparray[upcount] = up;
                        upcount++;

                        if (filled[up - 1] == 0)
                            filled[up - 1] = 1;
                    }
                }
                else
                {
                    if (cell[up - 1] == colorval)
                    {
                        uparray[upcount] = up;
                        upcount++;
                        coloredgrpup(up, colorval);

                        if (filled[up - 1] == 0)
                            filled[up - 1] = 1;
                    }
                }
            }
        }

        private void coloredgrpdown(int start, int colorval)
        {
            if (start > width) //!= 1 && start != 2 && start != 3 && start != 4 && start != 5)
            {
                //down search
                int down = start - width;
                if (down == 1 || down == 2 || down == 3 || down == 4 || down == 5)
                {
                    if (cell[down - 1] == colorval)
                    {
                        downarray[downcount] = down;
                        downcount++;

                        if (filled[down - 1] == 0)
                            filled[down - 1] = 1;
                    }
                }
                else
                {
                    if (cell[down - 1] == colorval)
                    {
                        downarray[downcount] = down;
                        downcount++;
                        coloredgrpdown(down, colorval);

                        if (filled[down - 1] == 0)
                            filled[down - 1] = 1;
                    }
                }
            }
        }

        private void coloredgrpright(int start, int colorval)
        {
            if (start % width != 0)//(start != 5 && start != 10 && start != 15 && start != 20 && start != 25 && start != 30)
            {
                //rightside scoring
                int right = start + 1;
                if (right % width == 0)//right == 5 || right == 10 || right == 15 || right == 20 || right == 25 || right == 30)
                {
                    if (cell[right - 1] == colorval)
                    {
                        rightary[rightcount] = right;
                        rightcount++;

                        if (filled[right - 1] == 0)
                            filled[right - 1] = 1;
                    }
                }
                else
                {
                    if (cell[right - 1] == colorval)
                    {
                        rightary[rightcount] = right;
                        rightcount++;
                        coloredgrpright(right, colorval);

                        if (filled[right - 1] == 0)
                            filled[right - 1] = 1;
                    }
                }
            }
        }

        private void coloredgrpleft(int start, int colorval)
        {
            if (start % width != 1)//start != 1 && start != 6 && start != 11 && start != 16 && start != 21 && start != 26)
            {
                int left = start - 1;
                //left side scoring
                if (left % width == 1)//left == 1 || left == 6 || left == 11 || left == 16 || left == 21 || left == 26)
                {
                    if (cell[left - 1] == colorval)
                    {
                        leftary[leftcount] = left;
                        leftcount++;

                        if (filled[left - 1] == 0)
                        {
                            filled[left - 1] = 1;
                            //leftary[leftcount] = left;
                            //leftcount++;
                        }
                    }
                }
                else
                {
                    if (cell[left - 1] == colorval)
                    {
                        if (filled[left - 1] == 0)
                        {
                            filled[left - 1] = 1;
                            //leftary[leftcount] = left;
                            //leftcount++;
                        }

                        leftary[leftcount] = left;
                        leftcount++;
                        coloredgrpleft(left, colorval);
                    }
                }
            }
        }

        private void totallen(int getval)
        {
            //determine how many are grouped
            leftcount = 1;
            leftary[0] = getval;
            filled[getval - 1] = 1;
            coloredgrpleft(getval, cell[getval - 1]);

            rightcount = 0;
            coloredgrpright(getval, cell[getval - 1]);

            //calc. up , down cells

            upcount = 0;
            downcount = 0;

            //left side
            for (int q = 0; q < leftcount; q++)
            {
                coloredgrpup(leftary[q], cell[getval - 1]);
                coloredgrpdown(leftary[q], cell[getval - 1]);
            }

            //right side
            for (int w = 0; w < rightcount; w++)
            {
                coloredgrpup(rightary[w], cell[getval - 1]);
                coloredgrpdown(rightary[w], cell[getval - 1]);
            }
        }

        private void startwhnclicked(int getval)
        {
            for (int u = 0; u < size; u++)
                filled[u] = 0;

            totallen(getval);

            while (upcount != 0)
            {
                int cup = upcount;
                int[] cuparray = uparray;

                for (int h = 0; h < cup; h++)
                    totallen(cuparray[h]);
            }

            while (downcount != 0)
            {
                int cdown = downcount;
                int[] cdownarray = downarray;

                for (int d = 0; d < cdown; d++)
                    totallen(cdownarray[d]);
            }

            changecolor();
        }

        private void clicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pen==0)
            {
                pen = 1;
                //changenormal();
                label5.Text = "0";
                int getval = 0;

                //gettin name from "object sender"
                string temp = (((Control)sender).Name).ToString();

                //determining which picbox was clicked
                string t1 = null;
                for (int a = 0; a < (temp.Length - 10); a++)
                    t1 += Convert.ToString(temp[10 + a]);
                getval = Convert.ToInt32(t1.ToString());

                startwhnclicked(getval);
            }
            else if (pen == 1)
            {
                pen = 0;
                changenormal();
                label5.Text = "0";
            }
        }

        private void changenormal()
        {
            for (int q = 1; q <= size; q++)
            {
                string temp = "pictureBox" + Convert.ToString(q);
                Control[] c = this.Controls.Find(temp, true);

                PictureBox p = (PictureBox)c[0];

                if (gamesize==0)
                {
                    if (cell[q - 1] == 0)
                        p.ImageLocation = "RedSmall.jpg";
                    else if (cell[q - 1] == 1)
                        p.ImageLocation = "GreenSmall.jpg";
                    else if (cell[q - 1] == 2)
                        p.ImageLocation = "BlueSmall.jpg";
                    else if (cell[q - 1] == 3)
                        p.ImageLocation = "YellowSmall.jpg";
                    else if ((cell[q - 1] == 4))
                        p.ImageLocation = "PurpleSmall.jpg";
                    else if ((cell[q - 1] == -1))
                        p.ImageLocation = "";
                }
                else
                {
                    if (cell[q - 1] == 0)
                        p.ImageLocation = "Red.jpg";
                    else if (cell[q - 1] == 1)
                        p.ImageLocation = "Green.jpg";
                    else if (cell[q - 1] == 2)
                        p.ImageLocation = "Blue.jpg";
                    else if (cell[q - 1] == 3)
                        p.ImageLocation = "Yellow.jpg";
                    else if ((cell[q - 1] == 4))
                        p.ImageLocation = "Purple.jpg";
                    else if ((cell[q - 1] == -1))
                        p.ImageLocation = "";
                }
            }
        }

        private void changecolor()
        {
            //change balls color
            int balls = 0;

            for (int s = 0; s < size; s++)
            {
                string temp2 = "pictureBox" + Convert.ToString(s + 1);
                Control[] c = this.Controls.Find(temp2, true);

                PictureBox p = (PictureBox)c[0];

                if (filled[s] == 1 && cell[s] >= 0)
                {
                    if (gamesize == 0)
                        p.ImageLocation = "BlackSmall.jpg";
                    else
                        p.ImageLocation = "Black.jpg";

                    balls++;
                }
            }

            score = balls * (balls - 1);
            if (score >= 2)
                label5.Text = score.ToString();
        }

        private void removecolmn()
        {
            for (int w = 0; w < width; w++)
            {
                for (int t = 0; t < height; t++)
                {
                    if (cell[w + (t * width)] == -2)
                    {
                        cell[w + (t * width)] = -1;

                        //push down elements from above
                        for (int r = t; r < (height - 1); r++)
                        {
                            int temp = cell[w + (r * width)];
                            cell[w + (r * width)] = cell[w + ((r + 1) * width)];
                            cell[w + ((r + 1) * width)] = temp;
                        }
                    }
                }
            }
        }

        private void forshifter()
        {
            //shift colors to right
            for (int i = 0; i < height; i++)
            {
                for (int q = (i * width); q < ((i + 1) * width); q++)
                {
                    for (int y = (q + 1); y < ((i + 1) * width); y++)
                    {
                        if (cell[y] < 0)
                        {
                            //cell[y] = -1;

                            for (int k = (y); k > (i * width); k--)
                            {
                                int temp = cell[k];
                                cell[k] = cell[k - 1];
                                cell[k - 1] = temp;
                            }
                        }
                    }
                }
            }
        }

        private void formegashift()
        {
            //add new random rows
            Random num = new Random();

            //determine no of colmns to add
            int count = 0;
            for (int q = 0; q < width; q++)
            {
                if (cell[q] < 0)
                    count++;
            }

            //add "count" number of colmns
            for (int w = 0; w < count; w++)
            {
                //length of array to be added
                int cols = num.Next(1, height);
                //colors in the array
                int[] colorarray = new int[cols];
                Random clr = new Random();
                for (int a = 0; a < cols; a++)
                    colorarray[a] = clr.Next(5);

                //now adding colmns to cell
                int startrow = cols - 1;

                for (int y = startrow; y >= 0; y--)
                {
                    //find min -1 pos in "yth" row
                    int minpos = y * width;
                    for (int r = (y * width); r < ((y + 1) * width); r++)
                    {
                        if (cell[r] < 0)
                            minpos = r;
                    }

                    cell[minpos] = colorarray[(cols-1) - y];
                }
            }
        }

        private bool chckcells()
        {
            int counter = 1;

            for (int d = 0; d < size; d++)
            {
                if (cell[d] == -2)
                    counter = 0;
            }

            if (counter == 1)
                return true;
            else
                return false;
        }

        private void chckexit()
        {
            int flag = 0;
            int noflag = 0;

            for (int q = 0; q < size; q++)
            {
                int balls = 0;
                if (cell[q] > -1)
                {
                    noflag = 1;

                    for (int u = 0; u < size; u++)
                        filled[u] = 0;

                    totallen(q+1);
                    
                    while (upcount != 0)
                    {
                        int cup = upcount;
                        int[] cuparray = uparray;

                        for (int h = 0; h < cup; h++)
                            totallen(cuparray[h]);
                    }

                    while (downcount != 0)
                    {
                        int cdown = downcount;
                        int[] cdownarray = downarray;

                        for (int d = 0; d < cdown; d++)
                            totallen(cdownarray[d]);
                    }
                    
                    for (int s = 0; s < size; s++)
                    {
                        if (filled[s] == 1)
                            balls++;
                    }
                }
                score = balls * (balls-1);
                if ( score >= 2)
                    flag += score;
            }

            if (flag == 0 || noflag == 0)
            {
                MessageBox.Show("Game Over");
                chckhighscore();
            }
        }

        private void chckhighscore()
        {
            BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter a = new BubbleBreaker.BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter();
            int score = 0;
            string name = null;

            if (gamemode == 0)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("NS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("NS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("NL");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("NL"));
                }
            }
            else if (gamemode == 1)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("SS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("SS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("SL");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("SL"));
                }
            }
            else if(gamemode == 2)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("MS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("MS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("ML");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("ML"));
                }
            }

            if (totalscore > score)
            {
                MessageBox.Show("New High Score !!!");
                textBox1.Visible = true;
                button1.Visible = true;
            }
        }

        private void doubleclicked(object sender, MouseEventArgs e)
        {
            for (int w = 0; w < size; w++)
            {
                backupcell[w] = cell[w];
                backupfilled[w] = filled[w];
            }
            backupscore = totalscore;

            clicked(sender, e);

            //event handler for double click

            if (score >= 2)
            {
                totalscore += score;
                label4.Text = totalscore.ToString();

                for (int q = 0; q < size; q++)
                {
                    //remove balls
                    if (filled[q] == 1)
                        cell[q] = -2;
                }

                bool val = chckcells();

                if (val != true)
                {
                    while (val != true)
                    {
                        removecolmn();
                        val = chckcells();
                    }
                }

                if (gamemode == 1)
                    forshifter();
                else if (gamemode == 2)
                {
                    forshifter();
                    formegashift();
                }

                changenormal();
                chckexit();
            }
        }

        private void clerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter a = new BubbleBreaker.BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter();

            if (gamemode == 0)
            {
                if (gamesize == 0)
                {
                    a.ClearHighScore("NS");
                    a.InsertHighScore("None", "0", "NS");
                }
                else
                {
                    a.ClearHighScore("NL");
                    a.InsertHighScore("None", "0", "NL");
                }
            }
            else if (gamemode == 1)
            {
                if (gamesize == 0)
                {
                    a.ClearHighScore("SS");
                    a.InsertHighScore("None", "0", "SS");
                }
                else
                {
                    a.ClearHighScore("SL");
                    a.InsertHighScore("None", "0", "SL");
                }
            }
            else if(gamemode == 2)
            {
                if (gamesize == 0)
                {
                    a.ClearHighScore("MS");
                    a.InsertHighScore("None", "0", "MS");
                }
                else
                {
                    a.ClearHighScore("ML");
                    a.InsertHighScore("None", "0", "ML");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter a = new BubbleBreaker.BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter();
            if (gamemode == 0)
            {
                if (gamesize == 0)
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "NS");
                else
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "NL");
            }
            else if (gamemode == 1)
            {
                if (gamesize == 0)
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "SS");
                else
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "SL");
            }
            else if(gamemode == 2)
            {
                if (gamesize == 0)
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "MS");
                else
                    a.SetHighScore(textBox1.Text, Convert.ToString(totalscore), "ML");
            }

            MessageBox.Show("High Score Set !!");
            textBox1.Visible = false;
            button1.Visible = false;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter a = new BubbleBreaker.BubbleBreakerDataSet1TableAdapters.HighscoreTableAdapter();
            string name = null;
            int score = 0;

            if (gamemode == 0)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("NS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("NS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("NL");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("NL"));
                }
            }
            else if (gamemode == 1)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("SS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("SS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("SL");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("SL"));
                }
            }
            else if(gamemode == 2)
            {
                if (gamesize == 0)
                {
                    name = (string)a.GetNameHighscore("MS");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("MS"));
                }
                else
                {
                    name = (string)a.GetNameHighscore("ML");
                    score = Convert.ToInt16((string)a.GetScoreHighscore("ML"));
                }
            }

            if (gamemode == 0)
            {
                if (gamesize == 0)
                    MessageBox.Show("   Mode : Normal(Small)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
                else
                    MessageBox.Show("   Mode : Normal(Large)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
            }
            else if (gamemode == 1)
            {
                if (gamesize == 0)
                    MessageBox.Show("   Mode : Shifter(Small)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
                else
                    MessageBox.Show("   Mode : Shifter(Large)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
            }
            else if(gamemode == 2)
            {
                if (gamesize == 0)
                    MessageBox.Show("   Mode : Megashifter(Small)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
                else
                    MessageBox.Show("   Mode : Megashifter(Large)\n\nHighscore By : " + name + "\nHighscore Of : " + score.ToString());
            }
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamesize = 0;
            smallToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamesize = 1;
            smallToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = true;
        }
    }
}