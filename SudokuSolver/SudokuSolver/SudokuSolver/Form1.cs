using System;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class Form1 : Form
    {

        private Field[] fields=new Field[81];

        public Form1()
        {
            InitializeComponent();
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            fields[0] = new SudokuSolver.Field(textBox1.Text,0);
            fields[1] = new SudokuSolver.Field(textBox2.Text,1);
            fields[2] = new SudokuSolver.Field(textBox3.Text,2);
            fields[3] = new SudokuSolver.Field(textBox4.Text,3);
            fields[4] = new SudokuSolver.Field(textBox5.Text,4);
            fields[5] = new SudokuSolver.Field(textBox6.Text,5);
            fields[6] = new SudokuSolver.Field(textBox7.Text,6);
            fields[7] = new SudokuSolver.Field(textBox8.Text,7);
            fields[8] = new SudokuSolver.Field(textBox9.Text,8);
            fields[9] = new SudokuSolver.Field(textBox10.Text,9);
            fields[10] = new SudokuSolver.Field(textBox11.Text,10);
            fields[11] = new SudokuSolver.Field(textBox12.Text,11);
            fields[12] = new SudokuSolver.Field(textBox13.Text,12);
            fields[13] = new SudokuSolver.Field(textBox14.Text,13);
            fields[14] = new SudokuSolver.Field(textBox15.Text,14);
            fields[15] = new SudokuSolver.Field(textBox16.Text,15);
            fields[16] = new SudokuSolver.Field(textBox17.Text,16);
            fields[17] = new SudokuSolver.Field(textBox18.Text,17);
            fields[18] = new SudokuSolver.Field(textBox19.Text,18);
            fields[19] = new SudokuSolver.Field(textBox20.Text,19);
            fields[20] = new SudokuSolver.Field(textBox21.Text,20);
            fields[21] = new SudokuSolver.Field(textBox22.Text,21);
            fields[22] = new SudokuSolver.Field(textBox23.Text,22);
            fields[23] = new SudokuSolver.Field(textBox24.Text,23);
            fields[24] = new SudokuSolver.Field(textBox25.Text,24);
            fields[25] = new SudokuSolver.Field(textBox26.Text,25);
            fields[26] = new SudokuSolver.Field(textBox27.Text,26);
            fields[27] = new SudokuSolver.Field(textBox28.Text,27);
            fields[28] = new SudokuSolver.Field(textBox29.Text,28);
            fields[29] = new SudokuSolver.Field(textBox30.Text,29);
            fields[30] = new SudokuSolver.Field(textBox31.Text,30);
            fields[31] = new SudokuSolver.Field(textBox32.Text,31);
            fields[32] = new SudokuSolver.Field(textBox33.Text,32);
            fields[33] = new SudokuSolver.Field(textBox34.Text,33);
            fields[34] = new SudokuSolver.Field(textBox35.Text,34);
            fields[35] = new SudokuSolver.Field(textBox36.Text,35);
            fields[36] = new SudokuSolver.Field(textBox37.Text,36);
            fields[37] = new SudokuSolver.Field(textBox38.Text,37);
            fields[38] = new SudokuSolver.Field(textBox39.Text,38);
            fields[39] = new SudokuSolver.Field(textBox40.Text,39);
            fields[40] = new SudokuSolver.Field(textBox41.Text,40);
            fields[41] = new SudokuSolver.Field(textBox42.Text,41);
            fields[42] = new SudokuSolver.Field(textBox43.Text,42);
            fields[43] = new SudokuSolver.Field(textBox44.Text,43);
            fields[44] = new SudokuSolver.Field(textBox45.Text,44);
            fields[45] = new SudokuSolver.Field(textBox46.Text,45);
            fields[46] = new SudokuSolver.Field(textBox47.Text,46);
            fields[47] = new SudokuSolver.Field(textBox48.Text,47);
            fields[48] = new SudokuSolver.Field(textBox49.Text,48);
            fields[49] = new SudokuSolver.Field(textBox50.Text,49);
            fields[50] = new SudokuSolver.Field(textBox51.Text,50);
            fields[51] = new SudokuSolver.Field(textBox52.Text,51);
            fields[52] = new SudokuSolver.Field(textBox53.Text,52);
            fields[53] = new SudokuSolver.Field(textBox54.Text,53);
            fields[54] = new SudokuSolver.Field(textBox55.Text,54);
            fields[55] = new SudokuSolver.Field(textBox56.Text,55);
            fields[56] = new SudokuSolver.Field(textBox57.Text,56);
            fields[57] = new SudokuSolver.Field(textBox58.Text,57);
            fields[58] = new SudokuSolver.Field(textBox59.Text,58);
            fields[59] = new SudokuSolver.Field(textBox60.Text,59);
            fields[60] = new SudokuSolver.Field(textBox61.Text,60);
            fields[61] = new SudokuSolver.Field(textBox62.Text,61);
            fields[62] = new SudokuSolver.Field(textBox63.Text,62);
            fields[63] = new SudokuSolver.Field(textBox64.Text,63);
            fields[64] = new SudokuSolver.Field(textBox65.Text,64);
            fields[65] = new SudokuSolver.Field(textBox66.Text,65);
            fields[66] = new SudokuSolver.Field(textBox67.Text,66);
            fields[67] = new SudokuSolver.Field(textBox68.Text,67);
            fields[68] = new SudokuSolver.Field(textBox69.Text,68);
            fields[69] = new SudokuSolver.Field(textBox70.Text,69);
            fields[70] = new SudokuSolver.Field(textBox71.Text,70);
            fields[71] = new SudokuSolver.Field(textBox72.Text,71);
            fields[72] = new SudokuSolver.Field(textBox73.Text,72);
            fields[73] = new SudokuSolver.Field(textBox74.Text,73);
            fields[74] = new SudokuSolver.Field(textBox75.Text,74);
            fields[75] = new SudokuSolver.Field(textBox76.Text,75);
            fields[76] = new SudokuSolver.Field(textBox77.Text,76);
            fields[77] = new SudokuSolver.Field(textBox78.Text,77);
            fields[78] = new SudokuSolver.Field(textBox79.Text,78);
            fields[79] = new SudokuSolver.Field(textBox80.Text,79);
            fields[80] = new SudokuSolver.Field(textBox81.Text,80);

            int counter = 0;
            bool isForward = true;

            while (counter < 81) {
                if (counter == 9)
                {
                    int temp = 7;
                }
                if (fields[counter]._isEditable) {
                    fields[counter].findBannedValues(fields);
                    if (fields[counter].setValue(isForward))
                    {
                        counter++;
                        isForward = true;
                    }
                    else
                    {
                        counter--;
                        isForward = false;
                    }
                }
                else
                {
                    if (isForward)
                    {
                        counter++;
                    }
                    else
                    {
                        counter--;
                    }
                }
            }

            textBox1.Text = fields[0]._currentValue.ToString();
            textBox2.Text = fields[1]._currentValue.ToString();
            textBox3.Text = fields[2]._currentValue.ToString();
            textBox4.Text = fields[3]._currentValue.ToString();
            textBox5.Text = fields[4]._currentValue.ToString();
            textBox6.Text = fields[5]._currentValue.ToString();
            textBox7.Text = fields[6]._currentValue.ToString();
            textBox8.Text = fields[7]._currentValue.ToString();
            textBox9.Text = fields[8]._currentValue.ToString();
            textBox10.Text = fields[9]._currentValue.ToString();
            textBox11.Text = fields[10]._currentValue.ToString();
            textBox12.Text = fields[11]._currentValue.ToString();
            textBox13.Text = fields[12]._currentValue.ToString();
            textBox14.Text = fields[13]._currentValue.ToString();
            textBox15.Text = fields[14]._currentValue.ToString();
            textBox16.Text = fields[15]._currentValue.ToString();
            textBox17.Text = fields[16]._currentValue.ToString();
            textBox18.Text = fields[17]._currentValue.ToString();
            textBox19.Text = fields[18]._currentValue.ToString();
            textBox20.Text = fields[19]._currentValue.ToString();
            textBox21.Text = fields[20]._currentValue.ToString();
            textBox22.Text = fields[21]._currentValue.ToString();
            textBox23.Text = fields[22]._currentValue.ToString();
            textBox24.Text = fields[23]._currentValue.ToString();
            textBox25.Text = fields[24]._currentValue.ToString();
            textBox26.Text = fields[25]._currentValue.ToString();
            textBox27.Text = fields[26]._currentValue.ToString();
            textBox28.Text = fields[27]._currentValue.ToString();
            textBox29.Text = fields[28]._currentValue.ToString();
            textBox30.Text = fields[29]._currentValue.ToString();
            textBox31.Text = fields[30]._currentValue.ToString();
            textBox32.Text = fields[31]._currentValue.ToString();
            textBox33.Text = fields[32]._currentValue.ToString();
            textBox34.Text = fields[33]._currentValue.ToString();
            textBox35.Text = fields[34]._currentValue.ToString();
            textBox36.Text = fields[35]._currentValue.ToString();
            textBox37.Text = fields[36]._currentValue.ToString();
            textBox38.Text = fields[37]._currentValue.ToString();
            textBox39.Text = fields[38]._currentValue.ToString();
            textBox40.Text = fields[39]._currentValue.ToString();
            textBox41.Text = fields[40]._currentValue.ToString();
            textBox42.Text = fields[41]._currentValue.ToString();
            textBox43.Text = fields[42]._currentValue.ToString();
            textBox44.Text = fields[43]._currentValue.ToString();
            textBox45.Text = fields[44]._currentValue.ToString();
            textBox46.Text = fields[45]._currentValue.ToString();
            textBox47.Text = fields[46]._currentValue.ToString();
            textBox48.Text = fields[47]._currentValue.ToString();
            textBox49.Text = fields[48]._currentValue.ToString();
            textBox50.Text = fields[49]._currentValue.ToString();
            textBox51.Text = fields[50]._currentValue.ToString();
            textBox52.Text = fields[51]._currentValue.ToString();
            textBox53.Text = fields[52]._currentValue.ToString();
            textBox54.Text = fields[53]._currentValue.ToString();
            textBox55.Text = fields[54]._currentValue.ToString();
            textBox56.Text = fields[55]._currentValue.ToString();
            textBox57.Text = fields[56]._currentValue.ToString();
            textBox58.Text = fields[57]._currentValue.ToString();
            textBox59.Text = fields[58]._currentValue.ToString();
            textBox60.Text = fields[59]._currentValue.ToString();
            textBox61.Text = fields[60]._currentValue.ToString();
            textBox62.Text = fields[61]._currentValue.ToString();
            textBox63.Text = fields[62]._currentValue.ToString();
            textBox64.Text = fields[63]._currentValue.ToString();
            textBox65.Text = fields[64]._currentValue.ToString();
            textBox66.Text = fields[65]._currentValue.ToString();
            textBox67.Text = fields[66]._currentValue.ToString();
            textBox68.Text = fields[67]._currentValue.ToString();
            textBox69.Text = fields[68]._currentValue.ToString();
            textBox70.Text = fields[69]._currentValue.ToString();
            textBox71.Text = fields[70]._currentValue.ToString();
            textBox72.Text = fields[71]._currentValue.ToString();
            textBox73.Text = fields[72]._currentValue.ToString();
            textBox74.Text = fields[73]._currentValue.ToString();
            textBox75.Text = fields[74]._currentValue.ToString();
            textBox76.Text = fields[75]._currentValue.ToString();
            textBox77.Text = fields[76]._currentValue.ToString();
            textBox78.Text = fields[77]._currentValue.ToString();
            textBox79.Text = fields[78]._currentValue.ToString();
            textBox80.Text = fields[79]._currentValue.ToString();
            textBox81.Text = fields[80]._currentValue.ToString();


        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
            textBox55.Text = "";
            textBox56.Text = "";
            textBox57.Text = "";
            textBox58.Text = "";
            textBox59.Text = "";
            textBox60.Text = "";
            textBox61.Text = "";
            textBox62.Text = "";
            textBox63.Text = "";
            textBox64.Text = "";
            textBox65.Text = "";
            textBox66.Text = "";
            textBox67.Text = "";
            textBox68.Text = "";
            textBox69.Text = "";
            textBox70.Text = "";
            textBox71.Text = "";
            textBox72.Text = "";
            textBox73.Text = "";
            textBox74.Text = "";
            textBox75.Text = "";
            textBox76.Text = "";
            textBox77.Text = "";
            textBox78.Text = "";
            textBox79.Text = "";
            textBox80.Text = "";
            textBox81.Text = "";
        }
    }
}
