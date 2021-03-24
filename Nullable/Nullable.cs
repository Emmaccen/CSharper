using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Nullable
{
    class Nullable
    {
        
        public static void Run()
        {
            Nullable<DateTime> birthDate = null;
            Console.WriteLine(birthDate == null);
            Console.WriteLine(birthDate.GetValueOrDefault());
            Console.WriteLine(birthDate.HasValue);
            //Console.WriteLine(birthDate.Value);

            string? gender = "prefer not to say";
            //gender = "Male";
            Console.WriteLine(gender);

            string answer = gender ?? "None";
        }

    }
}
