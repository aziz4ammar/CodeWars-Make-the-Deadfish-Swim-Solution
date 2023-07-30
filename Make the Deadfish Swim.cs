using System;
using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        List<int> result = new List<int>();
        int value = 0;

        foreach (char command in data)
        {
            if (command == 'i')
            {
                value++;
            }
            else if (command == 'd')
            {
                value--;
            }
            else if (command == 's')
            {
                value *= value;
            }
            else if (command == 'o')
            {
                result.Add(value);
            }
        }

        return result.ToArray();
    }
}
