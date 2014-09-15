using System;

namespace CSharpSixFeatures
{
    public class Numberparser
    {
	    public int ParseString(string parseStr)
        {
            int.TryParse(parseStr, out var number);
            return number;
        }
    }
}