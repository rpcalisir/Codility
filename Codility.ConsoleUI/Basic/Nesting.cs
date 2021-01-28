using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A string S consisting of N characters is called properly nested if:
    //S is empty;
    //S has the form "(U)" where U is a properly nested string;
    //S has the form "VW" where V and W are properly nested strings.
    //For example, string "(()(())())" is properly nested but string "())" isn't.

    // Write a function:

    // class Solution { public int solution(string S); }

    //  that, given a string S consisting of N characters, returns 1 if string S is properly nested and 0 otherwise.

    // For example, given S = "(()(())())", the function should return 1 and given S = "())", the function should return 0, as explained above.
    /// </summary>
    public class Nesting
    {
        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (S.Length == 0)
                return 1;
                
            Stack<char> characters = new Stack<char>();

            for (int c = 0; c < S.Length; c++)
            {
                if (characters.Count == 0 && S[c] == ')') //boş stack'e ')' eklenmek istenirse.
                    return 0;

                if (S[c] == '(')
                {
                    characters.Push(S[c]);
                    continue;
                }

                if (S[c] == ')')
                {
                    if (characters.Peek() == '(') 
                    {
                        characters.Pop();
                    }
                    else return 0;
                }
            }
            return characters.Count == 0 ? 1 : 0; //String'in en sonunda ( eklenmişse diye kontrol etmek için.
        }
    }
}
