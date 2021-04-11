using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using BCHFramework;

using ID3;

namespace MP3OrganizerBusinessLogic
{
    public delegate void BatchMP3EditorManagerProgressUpdateHandler(int mp3Indx);

    public class BatchMP3EditorManager
    {
        public event BatchMP3EditorManagerProgressUpdateHandler ProgressUpdate;

        public List<string> EditMP3Tags(List<string> mp3Files, string mp3MusicRootPath, bool useFileInfo, ref OperationResult op)
        {
            OperationResult _op = new OperationResult();
            int cnt = 0;
            bool badfile = false;
            List<string> badMp3List = new List<string>();

            foreach (string mp3File in mp3Files)
            {
                badfile = false;
                cnt++;
                if (ProgressUpdate != null)
                {
                    ProgressUpdate(cnt);
                }
                try
                {
                    MP3FileDataType mp3 = BCHMP3Utilities.ConvertFileNameToMP3InfoBCHFrmtWithDirInfo(mp3File,
                        mp3MusicRootPath, ref _op);
                    if (!_op.Success)
                    {
                        badMp3List.Add(mp3File);
                        badfile = true;
                    }

                    if (_op.Success)
                    {
                        SaveMp3IdInfo(mp3, ref _op);
                    }

                    if (!_op.Success && !badfile )
                    {
                        badfile = true;
                        badMp3List.Add(mp3File);
                    }
                }
                catch (Exception ex)
                {

                    _op.AddException(ex);
                    if (!badfile)
                    {
                        badfile = true;
                        badMp3List.Add(mp3File);
                    }
                }

            }

            op.AddOperationResult(ref _op);

            return badMp3List;
        }

        private void SaveMp3IdInfo(MP3FileDataType mp3, ref OperationResult op)
        {
            try
            {
                ID3Info id3 = new ID3Info(mp3.FileNamePath, true);

                string track = mp3.Track != null ? mp3.Track.ToString() : "1";
                string title = !string.IsNullOrEmpty(mp3.SongTitleAndNumeration) ? GetMaxLen(mp3.SongTitleAndNumeration, 30) : string.Empty;
                string artists = !string.IsNullOrEmpty(mp3.ArtistsStrList) ? GetMaxLen(mp3.ArtistsStrList, 30) : string.Empty;
                string album = !string.IsNullOrEmpty(mp3.Album) ? GetMaxLen(mp3.Album, 30) : string.Empty;
                string comments = !string.IsNullOrEmpty(mp3.Comments) ? GetMaxLen(mp3.Comments, 28) : string.Empty;
                List<string> GenreList = BCHMP3Utilities.GetGenre();
                int genreIndx = GenreList.Contains(mp3.Genre, StringComparer.CurrentCultureIgnoreCase)
                                    ?
                                        GenreList.FindIndex(
                                            s =>
                                            s.Trim().Equals(mp3.Genre.Trim(), StringComparison.CurrentCultureIgnoreCase))
                                    :
                                        GenreList.FindIndex(
                                            s =>
                                            s.Trim().Equals("Other", StringComparison.CurrentCultureIgnoreCase));

                id3.ID3v1Info.TrackNumber = byte.Parse(track);
                id3.ID3v1Info.Title = title;
                id3.ID3v1Info.Artist = artists;
                id3.ID3v1Info.Album = album;
                id3.ID3v1Info.Comment = comments;
                id3.ID3v1Info.Genre = Convert.ToByte(genreIndx);


                id3.ID3v2Info.SetTextFrame("TRCK", track);
                id3.ID3v2Info.SetTextFrame("TIT2", title);
                id3.ID3v2Info.SetTextFrame("TPE1", artists);
                id3.ID3v2Info.SetTextFrame("TALB", album);
                id3.ID3v2Info.SetTextFrame("WCOM", comments);
                id3.ID3v2Info.SetTextFrame("TCON", GenreList[genreIndx]);

                id3.ID3v2Info.HaveTag = true;

                id3.Save();
            }
            catch (Exception ex)
            {

                op.AddException(ex);
            }
        }

        private string GetMaxLen(string str, int maxLen)
        {
            string str2 = str.Trim();
            int strLen = str2.Length;
            return strLen > maxLen ? str2.Substring(0, maxLen) : str2;
        }
    }
}
