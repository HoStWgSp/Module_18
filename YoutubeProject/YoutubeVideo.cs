using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    internal class YoutubeVideo : Video
    {
        Reciever reciever;
        string VideosUrl {  get; set; }

        public YoutubeVideo(Reciever reciever, string videoUrl)
        {
            this.reciever = reciever;
            VideosUrl = videoUrl;
        }

        public override void GetInfo()
        {
            reciever.Info(VideosUrl);
        }
        public override void Download()
        {
            reciever.Load(VideosUrl);
        }
    }
}
