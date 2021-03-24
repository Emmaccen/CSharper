using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Dynamic
{
    class DynamicTypes
    {
        public static void Run()
        {
            dynamic data = "hello world";
            data = 2;
            Console.WriteLine(data);
        }
    }
}
