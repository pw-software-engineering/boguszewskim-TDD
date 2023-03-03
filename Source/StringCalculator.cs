﻿namespace Source;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if(String.IsNullOrWhiteSpace(numbers))
            return 0;

        return numbers.Split(',').Select(int.Parse).Sum();
    }
}
