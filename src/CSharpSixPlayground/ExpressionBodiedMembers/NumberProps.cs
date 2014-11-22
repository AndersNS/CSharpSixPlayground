using System;

namespace CSharpSixPlayground.ExpressionBodiedMembers
{
    public class NumberProps
    {
        private int _x = 3;
        private int _y = 5;
        public int Size => _x * _y;
    }
}