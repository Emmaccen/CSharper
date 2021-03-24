using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Csharp.ExceptionHandler
{
    class ExceptionHandler
    {
        public static void Run()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"D:\fileLog.txt"))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, something went wrong :(");
            }
            try
            {
                using (StreamReader reader2 = new StreamReader(@"D:\file.txt"))
                {
                    Console.WriteLine(reader2.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, something went wrong :(");
            }

            YoutubeApi youtubeApi = new YoutubeApi();
            youtubeApi.getVideos("How to kill a tiger");
        }
    }

    class YoutubeApi
    {
        List<String> videos = new List<string>() { "C# beginer", "C# advance", "C# double your coding speed"};
        List<string> searchResult = new List<string>();
        public void getVideos(string name)
        {
            try
            {
                foreach (var video in videos)
                {
                    if (video == name)
                        searchResult.Add(video);
                    else
                        throw new Exception("Low level Error");
                }

            }
            catch (Exception ex)
            {
               throw new CustomYoutubeException("Unable to get the videos requested, please try a different keyword", ex);
            }
        }
    }
    class CustomYoutubeException : System.Exception
    {
        public CustomYoutubeException(string message, System.Exception innerExeption) 
            : base(message, innerExeption)
        {

        }

    }
}
