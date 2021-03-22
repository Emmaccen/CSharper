using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp.Delegates
{
    class Delegates
    {
        public void Run()
        {
        PhotoProcessor processor = new PhotoProcessor();
            var filters = new FilterHandler();
            //calling own delegate
            //PhotoProcessor.ImageProcessor filterHandler = filters.ApplyContrast;
            //calling predefined delegate
            Action<Photo> filterHandler = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            processor.Process("photo.jpg", filterHandler);

        }
    }

    class FilterHandler
    {
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing Photos");
        } 

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying Brightness");
        } 
        
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast");
        }
    }
    class PhotoProcessor
    {
        //declearing own delegate
        //public delegate void ImageProcessor(Photo photo);
        public void Process (String path, Action<Photo> imageProcessor)
        {
            var photo = Photo.Load(path);
            imageProcessor(photo);
        }
    }

    class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("saving photo...");
        }
    }
}
