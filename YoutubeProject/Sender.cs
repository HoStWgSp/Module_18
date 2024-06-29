using CliWrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    internal class Sender
    {
        Video video;

        public void SetCommand(Video video) {  this.video = video; }

        public void GetInfo() { video.GetInfo(); }
        public void Download() {  video.Download(); }
    }
}
