using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public class MP3InfoBCHFrmt : AbstractMP3Info
    {

        public override void LoadMp3File(string fileNameAndPath, ref OperationResult op)
        {
            ConvertFileNameToMP3Info(fileNameAndPath, ref op);
            if (op.Success)
            {
                IsLoaded = true;
            }
        }

        protected override void ConvertFileNameToMP3Info(string fileNameAndPath, ref OperationResult op)
        {
            this.MP3FileData = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmt(fileNameAndPath, ref op);
        }
    }
}
