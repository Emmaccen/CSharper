namespace Csharp
{
    partial class Program
    {
        // common constrainsts
        /*
         * Where T : IComparable
         * Where T : yourCustomClass
         * Where T : class
         * Where T : new() which means an object with a default constructor
         * Where T : struct
         */
        class Utilities
        {
            public T GetMax<T>(T a, T b) where T : System.IComparable, new()
            {
                return a.CompareTo(b) > 0 ? a : b;
            }
        }
    }
}
