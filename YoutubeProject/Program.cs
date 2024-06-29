
using YoutubeProject;

var sender = new Sender();
var reciever = new Reciever();
var youtubeVideo = new YoutubeVideo(reciever, "https://www.youtube.com/watch?v=3fjavsmk7zQ");
sender.SetCommand(youtubeVideo);
sender.GetInfo();
sender.Download();