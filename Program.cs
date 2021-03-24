using System;

namespace Csharp
{
    partial class Program
    {

        static void Main(string[] args)
        {
            GenericDictionary<string, int> dictionary = new GenericDictionary<string, int>();
            dictionary.Add("one", 1);

            Console.WriteLine(new Utilities().GetMax(2,5));
            Console.WriteLine(Lambda.square(7));

            // Delegates
            var delegates = new Delegates.Delegates();
            delegates.Run();
            //Events and Delegates
            var eventMaker = new Events.Event();
            eventMaker.Run();
            // Extension Methods
            ExtensionMethods.StringExtension.RunExtensions();

            //LINQS
            LINQ.Linq.Run();

            // NULLABLE
            Nullable.Nullable.Run();

            // DYNAMIC
            Dynamic.DynamicTypes.Run();

            // EXCEPTION
            try
            {
                 ExceptionHandler.ExceptionHandler.Run();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            // ASYNC AWAIT

            AsyncAwait.Asynchronos.Run();
        }
    }

    public class GenericList<T>
    {
        public void Add (T custom)
        {
            
        }
    }
    public class GenericDictionary<TKey, TValue>
    {
        public void Add (TKey key, TValue value)
        {
            Console.WriteLine(key);
        }
    }
}