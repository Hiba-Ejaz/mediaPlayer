using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class MediaFile
    {
        private int _mediaId;
        private string _title;
        private string _filetype;
        private string _duration;
        private string _genre;

        public int MediaId { get; set; }
        public string Title { get; set; }
        public string Filetype { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }

    }
}