using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Field
    {
        private int currentValue;
        private int index;
        private int bannedCounter;

        private int[] bannedValues;
        private int[] permanenrlyBanned=new int[9];
        private int permanentlyBannedCounter;

        private bool isEditable;

        public bool _isEditable { get { return isEditable; } }
        public int _currentValue { get { return currentValue; } }


        public Field(string stringValue,int index)
        {
            int value;
            this.index = index;
            if (stringValue == "")
            {
                stringValue = "0";
            }

            int.TryParse(stringValue,out value);

            if (value > 0 && value < 10) {
                this.currentValue = value;
                this.isEditable = false;
            }
            else
            {
                this.currentValue = 0;
                this.isEditable = true;
            }          
        }

        public bool setValue(bool isForward)
        {
            if (isForward)
            {
                for(int i = 1; i < 10; i++)
                {
                    if (!bannedValues.Contains(i))
                    {
                        if (!permanenrlyBanned.Contains(i))
                        {
                            currentValue = i;
                            permanenrlyBanned[permanentlyBannedCounter] = i;
                            permanentlyBannedCounter++;
                            return true;
                        }
                    }
                }
                currentValue = 0;
                permanentlyBannedCounter = 0;
                permanenrlyBanned = new int[9];
                return false;
            }
            else
            {
                bannedValues[bannedCounter] = currentValue;
                for (int i = 1; i < 10; i++)
                {
                    if (!bannedValues.Contains(i))
                    {
                        if (!permanenrlyBanned.Contains(i))
                        {
                            currentValue = i;
                            permanenrlyBanned[permanentlyBannedCounter] = i;
                            permanentlyBannedCounter++;
                            return true;
                        }
                    }
                }
                currentValue = 0;
                permanentlyBannedCounter = 0;
                permanenrlyBanned = new int[9];
                return false;
            }
        }

        public void findBannedValues(Field[] fields)
        {
            int row = (int)Math.Floor((decimal)index / 9);
            int column = index % 9;

            int counter = 0;
            

            int[] bannedList = new int[10];

            for(int i = row*9; i < row*9 + 9; i++)
            {
                if (!bannedList.Contains(fields[i].currentValue))
                {
                    bannedList[counter] = fields[i].currentValue;
                    counter++;
                }
                
            }

            for(int i = column; i < 81; i=i + 9)
            {
                if (!bannedList.Contains(fields[i].currentValue))
                {
                    bannedList[counter] = fields[i].currentValue;
                    counter++;
                }
            }

            //0-left;1-centre;2-right
            int leftRightCentre = column % 3;

            //0-top;1-mid;2-bot
            int topMidBot = row % 3;

                for (int i = (-1) * topMidBot; i < 3 - topMidBot; i++)
                {
                    for (int j = index + 9 * i-leftRightCentre; j < index + 9 * i + 3-leftRightCentre; j++)
                    {
                        if (!bannedList.Contains(fields[j].currentValue))
                        {
                            bannedList[counter] = fields[j].currentValue;
                            counter++;
                        }
                    }
                }

            bannedCounter = counter;

        bannedValues = bannedList;
        }
    }
}
