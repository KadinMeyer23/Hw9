﻿//Kadin Meyer
//4/22/2025

public class Solution
{
    public bool IsHappy(int n)
    {
        var map = new HashSet<int>();

        while (!map.Contains(n))
        {
            map.Add(n);
            var newValue = 0;
            while (n > 0)
            {
                var digit = n % 10;
                newValue += digit * digit;
                n /= 10;
            }

            if (newValue == 1) return true;
            {
                n = newValue;
            }
        }

        return false;
    }
}