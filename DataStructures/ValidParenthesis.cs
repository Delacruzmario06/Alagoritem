﻿namespace DataStructures;

public class ValidParenthesis
{
    public static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char c in s)
        {
            if (map.ContainsKey(c))
            {
                char topElement = stack.Count > 0 ? stack.Pop() : '#';
                if (topElement != map[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}