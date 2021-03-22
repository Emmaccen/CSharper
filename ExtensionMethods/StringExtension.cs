using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.ExtensionMethods
{
    public static class StringExtension
    {
        public static void RunExtensions()
        {
            string blogPost = "This is a really long long long word in the blog";
            Console.WriteLine(blogPost.shortenWords(6));
        }
        public static String shortenWords (this String words, int numberOfWords)
        {
            String[] list = words.Split(' ');
            StringBuilder summary = new StringBuilder();
            if (numberOfWords <1)
            {
                return "";
            }else if (list.Length <= numberOfWords)
            {
                /*numberOfWords = list.Length;
                return shorten();*/
                return words;
            }
            else
            {
                shorten();
                return summary.Append("...").ToString();
            }
            string shorten()
            {
                for (int i = 0; i < numberOfWords; i++)
                {
                    summary.Append(list[i] + " ");
                }
                return summary.ToString();
            }
        }
    }
}
