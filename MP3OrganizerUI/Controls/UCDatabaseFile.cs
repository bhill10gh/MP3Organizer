using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Specialized;

using BCHControls;
using BCHFramework;
using MP3OrganizerBusinessLogic;

namespace MP3OrganizerUI.Controls
{
    public partial class UCDatabaseFile : UserControl
    {
        #region Members

        public string MP3DBFileName 
        {
            get
            {
                return tbMP3DBFile.Text;
            }

            set
            {
                tbMP3DBFile.Text = value;
            }
        }

        public bool MP3DBExists { get; set; }

        #endregion

        #region Events
        
        private void btnGetMP3DBFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose an Access 2000 to 2003 version database (mdb) file.";
            openFileDialog1.ShowDialog();
            this.MP3DBFileName = openFileDialog1.FileName;
            if (File.Exists(MP3DBFileName) && MP3DBFileName.ToUpper().EndsWith(".MDB"))
            {
                this.MP3DBExists = true;
            }
            else
            {
                this.MP3DBExists = false;
                MessageBox.Show("The databse you chose is not valid!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbMP3DBFile.Text = this.MP3DBFileName;
        }

        #endregion

        #region Methods

        public UCDatabaseFile()
        {
            InitializeComponent();           
        }

        public void SetControl()
        {
            string dbFile = BCHUtilities.GetConfigValue("MP3DBFile", 0, ".MDB", 1, true, false);

            this.MP3DBExists = File.Exists(dbFile);

            this.MP3DBFileName = MP3DBExists ? dbFile : string.Empty;
        }


        #endregion

    }
}
