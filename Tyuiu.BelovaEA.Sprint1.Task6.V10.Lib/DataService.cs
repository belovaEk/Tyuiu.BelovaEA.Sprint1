using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BelovaEA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string answer = "";

            string[] words = value.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; ++i)
            {
                string str = words[i];
                int l = str.Length;
                int ind = l / 2;

                if (l % 2 != 0 & l != 0)
                {

                    string new_str = str.Remove(ind, 1);
                    answer += new_str + ' ';
                }
                else
                {
                    answer += str + ' ';
                }
        
            }
            return answer.Trim(' ').Replace("  ", " ");
        }
    }
}
