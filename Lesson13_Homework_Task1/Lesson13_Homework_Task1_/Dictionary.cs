using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Homework_Task1_
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] rValue = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; rValue[0] = "книжка";
            key[1] = "ручка"; value[1] = "pen"; rValue[1] = "ручка";
            key[2] = "сонце"; value[2] = "sun"; rValue[2] = "солнце";
            key[3] = "яблуко"; value[3] = "apple"; rValue[3] = "яблоко";
            key[4] = "стіл"; value[4] = "table"; rValue[4] = "стол";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index || value[i] == index || rValue[i] == index)
                    {
                        return key[i] + "-" + value[i] + "-" + rValue[i];
                    }
                }

                return string.Format("{0} - нема перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + "-" + value[index] + "-" + rValue[index];
                }
                else
                {
                    return "Спроба звернення за межі масиву.";
                }
            }
        }
    }
}
