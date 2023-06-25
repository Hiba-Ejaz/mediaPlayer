using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.Domain
{
    public abstract class MediaFile
    {
        public MediaFile(int mediaId,string title,string duration,string genre){
       MediaId =mediaId;
       Title=title;
        Duration=duration;
       Genre=genre;
        }
 
        public int MediaId { get; set; }
        public string Title { get; set; }
        public string Filetype { get; set; }
        public string Duration { get; set; }
        public string status { get; set; }
        public string Genre { get; set; }

    }
}