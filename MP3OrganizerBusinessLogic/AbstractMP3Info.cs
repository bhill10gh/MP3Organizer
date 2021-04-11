using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public abstract class AbstractMP3Info
    {
        public bool IsLoaded { get; protected set; }

        public MP3FileDataType MP3FileData { get; set; }

        public abstract void LoadMp3File(string fileNameAndPath, ref OperationResult op);

        protected abstract void ConvertFileNameToMP3Info(string fileNameAndPath, ref OperationResult op);

        public string GetAllArtist()
        {
            string allArtists = string.Empty;

            foreach (string s in this.MP3FileData.Artists)
            {
                allArtists += s + ";";
            }

            if(allArtists.EndsWith(";"))
            {
                allArtists = allArtists.Substring(0, allArtists.Length - 1);
            }

            return allArtists;
        }




    }
}
