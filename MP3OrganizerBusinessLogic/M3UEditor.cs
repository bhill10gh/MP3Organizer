using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using BCHFramework;

namespace MP3OrganizerBusinessLogic
{
    public class M3UEditor
    {
        public string M3UPath { get; private set; }

        public string M3UFileName { get; private set; }

        public string M3UFileNameAndPath { get; private set; }

        public List<string> M3USongList { get; private set; }

        private bool _isSet = false;
        public bool IsSet
        {
            get
            {
                return _isSet;
            }

            private set
            {
                _isSet = value;
            }
        }

        public void SetM3U(string fileNameAndPath, List<string> list, bool isNew, ref OperationResult op)
        {
            try
            {
                if (!isNew && !File.Exists(fileNameAndPath))
                {
                    op.AddError("The File: " + fileNameAndPath + " deos not exist!");
                    return;
                }

                if (Directory.Exists(Path.GetFullPath(fileNameAndPath)))
                {
                    op.AddError("The Path: " + Path.GetFullPath(fileNameAndPath) + " deos not exist!");
                    return;
                }

                if (!isNew)
                {
                    List<string> fileContents = BCHFileIO.ReadFullFile(fileNameAndPath, ref op);
                    fileContents =
                        (
                            from line in fileContents
                            where
                                !line.Trim().StartsWith("#")
                            &&
                                line.Trim().Length > 1
                            select line
                        ).ToList<string>();

                    if (!op.Success)
                    {
                        return;
                    }

                    this.M3USongList = fileContents;
                }
                else
                {
                    this.M3USongList = new List<string>();
                    this.M3USongList.AddRange(list);
                }
                this.M3UFileNameAndPath = fileNameAndPath;
                this.M3UFileName = Path.GetFileName(fileNameAndPath);
                this.M3UPath = Path.GetFullPath(fileNameAndPath);

                _isSet = true;
                                
            }
            catch (Exception ex)
            {
                op.AddException(ex);
                return;
            }
        }

        public void CreateM3U(ref OperationResult op)
        {
            if (!IsSet)
            {
                op.AddError("M3U object not set.  You must call the \"SetM3U(string fileNameAndPath, " + 
                        "ref OperationResult op)\" successfully before you can create an M3U file");
                return;
            }

            if (this.M3USongList.Count < 1)
            {
                op.AddError("There are no songs in the M3U list.  You must call the \"SetM3USongs(List<string> list, bool" + 
                        "addOrReplace, ref OperationResult op)\" successfully before you can create an M3U file");
                return;
            }

            List<string> mList = new List<string>();

            //mList.Add("#EXTM3U - Created by Barry Hill's M3U Editor");
            //mList.Add("#EXTINF - ");

            mList.AddRange(this.M3USongList);

            string fname = this.M3UFileNameAndPath;
            if(!fname.EndsWith(".m3u",StringComparison.CurrentCultureIgnoreCase))
                fname = fname + ".m3u";

            BCHFileIO.WriteFullFile(fname, mList, ref op);

            if (!op.Success)
            {
                return;
            }

            op.AddInformation("M3U file created successfully.");
        }

        public void SetM3USongs(List<string> list, bool addOrReplace, ref OperationResult op)
        {
            if (!IsSet)
            {
                op.AddError("M3U object not set.  You must call the \"SetM3U(string fileNameAndPath, " +
                        "ref OperationResult op)\" successfully before you can create an M3U file");
                return;
            }

            if (addOrReplace)
                this.M3USongList.AddRange(list);
            else
                this.M3USongList = list;
        }
    }
}
