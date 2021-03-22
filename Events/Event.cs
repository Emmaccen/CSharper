using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Csharp.Events
{
    class Event
    {
        public void Run()
        {
            var video = new Video("Battle Ship");
            VidoeEncoder encoder = new VidoeEncoder();
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();
            encoder.VideoEncoded += mailService.OnVideoEncodingDone;
            encoder.VideoEncoded += messageService.OnVideoEncodingDone;
            encoder.Encode(video);
        }
    }
    
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }

    class Video
    {
        public string Name { get; set; }
        public Video(string name)
        {
            Name = name;
        }
    }
    class VidoeEncoder
    {
        //declearing own EventHandler

       // public delegate void VideoEncodedEventHandler(Object sender, VideoEventArgs args);
       // public event VideoEncodedEventHandler VideoEncoded;


        //using predefined EventHandler
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.Write("{0}{1}", "Encoding: ", video.Name);
            for(int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            OnVideoEncoded(video);

        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video});
        }
    }
    class MailService
    {
        public void OnVideoEncodingDone(object encoder, VideoEventArgs args)
        {
            Console.WriteLine("{0}{1}",args.Video.Name + " Encoded ", " Sending Mail...");
        }
    }
    class MessageService
    {
        public void OnVideoEncodingDone(Object encoder, VideoEventArgs args)
        {
            Console.WriteLine("{0}{1}", args.Video.Name + " Encoded ","Sending SMS...");
        }
    }
}
