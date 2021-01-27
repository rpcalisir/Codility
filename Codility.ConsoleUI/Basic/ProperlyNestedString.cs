using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
    //  S is empty;
    //  S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
    //  S has the form "VW" where V and W are properly nested strings.
    //  For example, the string "{[()()]}" is properly nested but "([)()]" is not.
    //  Write a function:
    //  class Solution { public int solution(string S); }
    //    that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
    //    For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0
    // as explained above.
    /// </summary>
    public class ProperlyNestedString
    {
        public static int Solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Stack<char> characters = new Stack<char>();
            if (S.Length == 0)
                return 1;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '{' || S[i] == '[' || S[i] == '(')
                {
                    characters.Push(S[i]);
                }
                else
                {
                    //If string doesn't start with {,[ or (
                    if (characters.Count == 0)
                        return 0;

                    if (S[i] == ')')
                    {
                        if (characters.Peek() == '(')
                            characters.Pop();
                        else
                            return 0;
                    }
                    if (S[i] == ']')
                    {
                        if (characters.Peek() == '[')
                            characters.Pop();
                        else
                            return 0;
                    }
                    if (S[i] == '}')
                    {
                        if (characters.Peek() == '{')
                            characters.Pop();
                        else
                            return 0;
                    }
                }
            }

            return characters.Count == 0 ? 1 : 0;
        }
    }
}
