using BCHFramework;
using MP3OrganizerUI.Models;
using SqliteDAL;
using SqliteDAL.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3OrganizerUI.MP3DbUtilities
{
    public partial class FrmYepYepUrlManager : Form
    {
        public FrmYepYepUrlManager()
        {
            InitializeComponent();
        }

        private List<YepYep> _yepRecords { get; set; }
        private YepYepRepository _yepYepRepository { get; set; }

        private void btnImportYYFile_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            var yyLines = BCHFileIO.ReadFullFile(ddtbYepYepUrlFile.ItemText, ref op);
            string prevLine = "";
            StringBuilder actors = new StringBuilder();

            YepYep yepYep = new YepYep
            { 
                Ethnicities = tbEthnicity.Text
            };

            List<YepYep> YepYeps = new List<YepYep>();

            foreach ( var line in yyLines )
            {
                if(line.Trim().StartsWith("https://"))
                {
                    yepYep = new YepYep
                    {
                        Ethnicities = tbEthnicity.Text,
                        Url = line.Trim()
                    };

                    actors = new StringBuilder();

                }
                else if(line.Length > 0)
                {
                    actors.Append(line.Trim() + ";");
                }
                else
                {
                    //if(!prevLine.Trim().StartsWith("https://"))
                    //{
                    //    YepYep.Actors = actors.ToString();
                    //}
                    yepYep.Actors = actors.ToString();
                    YepYeps.Add(yepYep);
                    
                }

                prevLine = line;
            }

            _yepRecords = YepYeps;
        }

        private void ddtbDbFile_Load(object sender, EventArgs e)
        {

        }

        private void btnAddYepYep_Click(object sender, EventArgs e)
        {
            OperationResult op = new OperationResult();
            _yepYepRepository = new YepYepRepository(ddtbDbFile.ItemText, ref op);
            rtErrors.Text = "";

            try
            {
                foreach (var YepYep in _yepRecords)
                {
                    _yepYepRepository.InsertYepYep(YepYep, ref op);
                }
            }
            catch (Exception ex)
            {

                rtErrors.Text = ex.Message;
            }
        }
    }
}
