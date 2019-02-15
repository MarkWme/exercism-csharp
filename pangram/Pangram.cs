using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        input = input.ToUpper();
        int count = 0;
        bool returnValue = false;
        for(int check = 65; check <= 90; check++) {
            if(input.Contains((char)check)) {
                count++;
            }
        }
        if(count>=26) returnValue = true;
        return(returnValue);
    }
}
