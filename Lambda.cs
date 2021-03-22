using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
    class Lambda
    {
        public static Func<int , int> square = number => number * number;
        public static Func< string> name = () => "Hello world";
    }
}
