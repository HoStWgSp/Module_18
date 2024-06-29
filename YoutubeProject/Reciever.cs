using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YoutubeProject
{
    internal class Reciever
    {
        YoutubeClient youtubeClient = new YoutubeClient();
        public void Info(string videoUri)
        {
            string ddd = youtubeClient.Videos.GetAsync(videoUri).Result.ToString();
            Console.WriteLine(ddd);
        }
        public async Task Load(string videoURL)
        {
            var client = new YoutubeClient();
            var streamManifest = await client.Videos.Streams.GetManifestAsync(videoURL);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            await client.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
        
    }
}
