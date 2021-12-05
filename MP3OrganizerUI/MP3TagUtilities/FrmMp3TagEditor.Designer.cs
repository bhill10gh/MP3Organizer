namespace MP3OrganizerUI
{
    partial class FrmMp3TagEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb3v1 = new System.Windows.Forms.GroupBox();
            this.cbGenre3v1 = new ID3_Editor.GenreBox();
            this.btnCopyFrom3v2 = new System.Windows.Forms.Button();
            this.tbComment3v1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbYear3v1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAlbum3v1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArtist3v1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle3v1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTrack3v1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb3v2 = new System.Windows.Forms.GroupBox();
            this.cbGenre3v2 = new ID3_Editor.GenreBox();
            this.btnCopyFrom3v1 = new System.Windows.Forms.Button();
            this.tbComment3v2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbYear3v2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAlbum3v2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbArtist3v2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTitle3v2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTrack3v2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetMP3TagData = new System.Windows.Forms.Button();
            this.btnEditTag = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMP3InfoFromFileName = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbCalcTrack = new System.Windows.Forms.TextBox();
            this.ckbUseDirForInfo = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbcalcComment = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCalcArtists = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCalcTitle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCalcGenre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCalcAlbum = new System.Windows.Forms.TextBox();
            this.btnGetMusicInfo = new System.Windows.Forms.Button();
            this.btnPopWithNameInfo = new System.Windows.Forms.Button();
            this.dddtbGetRootDir = new BCHControls.UCDragDropDirTextBox();
            this.ddtbMp3File = new BCHControls.UCDragDropTextBox();
            this.gb3v1.SuspendLayout();
            this.gb3v2.SuspendLayout();
            this.gbMP3InfoFromFileName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb3v1
            // 
            this.gb3v1.Controls.Add(this.cbGenre3v1);
            this.gb3v1.Controls.Add(this.btnCopyFrom3v2);
            this.gb3v1.Controls.Add(this.tbComment3v1);
            this.gb3v1.Controls.Add(this.label7);
            this.gb3v1.Controls.Add(this.tbYear3v1);
            this.gb3v1.Controls.Add(this.label6);
            this.gb3v1.Controls.Add(this.label5);
            this.gb3v1.Controls.Add(this.tbAlbum3v1);
            this.gb3v1.Controls.Add(this.label4);
            this.gb3v1.Controls.Add(this.tbArtist3v1);
            this.gb3v1.Controls.Add(this.label3);
            this.gb3v1.Controls.Add(this.tbTitle3v1);
            this.gb3v1.Controls.Add(this.label2);
            this.gb3v1.Controls.Add(this.tbTrack3v1);
            this.gb3v1.Controls.Add(this.label1);
            this.gb3v1.Location = new System.Drawing.Point(13, 91);
            this.gb3v1.Name = "gb3v1";
            this.gb3v1.Size = new System.Drawing.Size(293, 260);
            this.gb3v1.TabIndex = 0;
            this.gb3v1.TabStop = false;
            this.gb3v1.Text = "ID3v1";
            // 
            // cbGenre3v1
            // 
            this.cbGenre3v1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre3v1.FormattingEnabled = true;
            this.cbGenre3v1.Genre = "";
            this.cbGenre3v1.GenreIndex = 255;
            this.cbGenre3v1.ID3Version = 1;
            this.cbGenre3v1.Location = new System.Drawing.Point(76, 142);
            this.cbGenre3v1.Name = "cbGenre3v1";
            this.cbGenre3v1.Size = new System.Drawing.Size(191, 21);
            this.cbGenre3v1.TabIndex = 16;
            // 
            // btnCopyFrom3v2
            // 
            this.btnCopyFrom3v2.Location = new System.Drawing.Point(18, 231);
            this.btnCopyFrom3v2.Name = "btnCopyFrom3v2";
            this.btnCopyFrom3v2.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFrom3v2.TabIndex = 15;
            this.btnCopyFrom3v2.Text = "Import 3v2";
            this.btnCopyFrom3v2.UseVisualStyleBackColor = true;
            this.btnCopyFrom3v2.Click += new System.EventHandler(this.btnCopyFrom3v2_Click);
            // 
            // tbComment3v1
            // 
            this.tbComment3v1.Location = new System.Drawing.Point(76, 194);
            this.tbComment3v1.Multiline = true;
            this.tbComment3v1.Name = "tbComment3v1";
            this.tbComment3v1.Size = new System.Drawing.Size(191, 34);
            this.tbComment3v1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Comment:";
            // 
            // tbYear3v1
            // 
            this.tbYear3v1.Location = new System.Drawing.Point(76, 168);
            this.tbYear3v1.Name = "tbYear3v1";
            this.tbYear3v1.Size = new System.Drawing.Size(191, 20);
            this.tbYear3v1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre:";
            // 
            // tbAlbum3v1
            // 
            this.tbAlbum3v1.Location = new System.Drawing.Point(76, 116);
            this.tbAlbum3v1.Name = "tbAlbum3v1";
            this.tbAlbum3v1.Size = new System.Drawing.Size(191, 20);
            this.tbAlbum3v1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Album:";
            // 
            // tbArtist3v1
            // 
            this.tbArtist3v1.Location = new System.Drawing.Point(76, 90);
            this.tbArtist3v1.Name = "tbArtist3v1";
            this.tbArtist3v1.Size = new System.Drawing.Size(191, 20);
            this.tbArtist3v1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Artist:";
            // 
            // tbTitle3v1
            // 
            this.tbTitle3v1.Location = new System.Drawing.Point(76, 55);
            this.tbTitle3v1.Name = "tbTitle3v1";
            this.tbTitle3v1.Size = new System.Drawing.Size(191, 20);
            this.tbTitle3v1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // tbTrack3v1
            // 
            this.tbTrack3v1.Location = new System.Drawing.Point(76, 29);
            this.tbTrack3v1.Name = "tbTrack3v1";
            this.tbTrack3v1.Size = new System.Drawing.Size(191, 20);
            this.tbTrack3v1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track:";
            // 
            // gb3v2
            // 
            this.gb3v2.Controls.Add(this.cbGenre3v2);
            this.gb3v2.Controls.Add(this.btnCopyFrom3v1);
            this.gb3v2.Controls.Add(this.tbComment3v2);
            this.gb3v2.Controls.Add(this.label8);
            this.gb3v2.Controls.Add(this.tbYear3v2);
            this.gb3v2.Controls.Add(this.label9);
            this.gb3v2.Controls.Add(this.label10);
            this.gb3v2.Controls.Add(this.tbAlbum3v2);
            this.gb3v2.Controls.Add(this.label11);
            this.gb3v2.Controls.Add(this.tbArtist3v2);
            this.gb3v2.Controls.Add(this.label12);
            this.gb3v2.Controls.Add(this.tbTitle3v2);
            this.gb3v2.Controls.Add(this.label13);
            this.gb3v2.Controls.Add(this.tbTrack3v2);
            this.gb3v2.Controls.Add(this.label14);
            this.gb3v2.Location = new System.Drawing.Point(319, 91);
            this.gb3v2.Name = "gb3v2";
            this.gb3v2.Size = new System.Drawing.Size(293, 260);
            this.gb3v2.TabIndex = 1;
            this.gb3v2.TabStop = false;
            this.gb3v2.Text = "ID3v2";
            // 
            // cbGenre3v2
            // 
            this.cbGenre3v2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre3v2.FormattingEnabled = true;
            this.cbGenre3v2.Genre = "";
            this.cbGenre3v2.GenreIndex = 255;
            this.cbGenre3v2.ID3Version = 1;
            this.cbGenre3v2.Location = new System.Drawing.Point(76, 142);
            this.cbGenre3v2.Name = "cbGenre3v2";
            this.cbGenre3v2.Size = new System.Drawing.Size(191, 21);
            this.cbGenre3v2.TabIndex = 17;
            // 
            // btnCopyFrom3v1
            // 
            this.btnCopyFrom3v1.Location = new System.Drawing.Point(8, 231);
            this.btnCopyFrom3v1.Name = "btnCopyFrom3v1";
            this.btnCopyFrom3v1.Size = new System.Drawing.Size(75, 23);
            this.btnCopyFrom3v1.TabIndex = 16;
            this.btnCopyFrom3v1.Text = "Import 3v1";
            this.btnCopyFrom3v1.UseVisualStyleBackColor = true;
            this.btnCopyFrom3v1.Click += new System.EventHandler(this.btnCopyFrom3v1_Click);
            // 
            // tbComment3v2
            // 
            this.tbComment3v2.Location = new System.Drawing.Point(76, 194);
            this.tbComment3v2.Multiline = true;
            this.tbComment3v2.Name = "tbComment3v2";
            this.tbComment3v2.Size = new System.Drawing.Size(191, 34);
            this.tbComment3v2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Comment:";
            // 
            // tbYear3v2
            // 
            this.tbYear3v2.Location = new System.Drawing.Point(76, 168);
            this.tbYear3v2.Name = "tbYear3v2";
            this.tbYear3v2.Size = new System.Drawing.Size(191, 20);
            this.tbYear3v2.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Year:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Genre:";
            // 
            // tbAlbum3v2
            // 
            this.tbAlbum3v2.Location = new System.Drawing.Point(76, 116);
            this.tbAlbum3v2.Name = "tbAlbum3v2";
            this.tbAlbum3v2.Size = new System.Drawing.Size(191, 20);
            this.tbAlbum3v2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Album:";
            // 
            // tbArtist3v2
            // 
            this.tbArtist3v2.Location = new System.Drawing.Point(76, 90);
            this.tbArtist3v2.Name = "tbArtist3v2";
            this.tbArtist3v2.Size = new System.Drawing.Size(191, 20);
            this.tbArtist3v2.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Artist:";
            // 
            // tbTitle3v2
            // 
            this.tbTitle3v2.Location = new System.Drawing.Point(76, 55);
            this.tbTitle3v2.Name = "tbTitle3v2";
            this.tbTitle3v2.Size = new System.Drawing.Size(191, 20);
            this.tbTitle3v2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Title:";
            // 
            // tbTrack3v2
            // 
            this.tbTrack3v2.Location = new System.Drawing.Point(76, 29);
            this.tbTrack3v2.Name = "tbTrack3v2";
            this.tbTrack3v2.Size = new System.Drawing.Size(191, 20);
            this.tbTrack3v2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Track:";
            // 
            // btnGetMP3TagData
            // 
            this.btnGetMP3TagData.Location = new System.Drawing.Point(19, 65);
            this.btnGetMP3TagData.Name = "btnGetMP3TagData";
            this.btnGetMP3TagData.Size = new System.Drawing.Size(110, 23);
            this.btnGetMP3TagData.TabIndex = 7;
            this.btnGetMP3TagData.Text = "Get MP3 Tag Data";
            this.btnGetMP3TagData.UseVisualStyleBackColor = true;
            this.btnGetMP3TagData.Click += new System.EventHandler(this.btnGetMP3TagData_Click);
            // 
            // btnEditTag
            // 
            this.btnEditTag.Location = new System.Drawing.Point(144, 65);
            this.btnEditTag.Name = "btnEditTag";
            this.btnEditTag.Size = new System.Drawing.Size(110, 23);
            this.btnEditTag.TabIndex = 8;
            this.btnEditTag.Text = "Edit Tag";
            this.btnEditTag.UseVisualStyleBackColor = true;
            this.btnEditTag.Click += new System.EventHandler(this.btnEditTag_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbMP3InfoFromFileName
            // 
            this.gbMP3InfoFromFileName.Controls.Add(this.label21);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbCalcTrack);
            this.gbMP3InfoFromFileName.Controls.Add(this.ckbUseDirForInfo);
            this.gbMP3InfoFromFileName.Controls.Add(this.label20);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbcalcComment);
            this.gbMP3InfoFromFileName.Controls.Add(this.label19);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbCalcArtists);
            this.gbMP3InfoFromFileName.Controls.Add(this.label18);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbCalcTitle);
            this.gbMP3InfoFromFileName.Controls.Add(this.label17);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbCalcGenre);
            this.gbMP3InfoFromFileName.Controls.Add(this.label16);
            this.gbMP3InfoFromFileName.Controls.Add(this.tbCalcAlbum);
            this.gbMP3InfoFromFileName.Controls.Add(this.btnGetMusicInfo);
            this.gbMP3InfoFromFileName.Controls.Add(this.btnPopWithNameInfo);
            this.gbMP3InfoFromFileName.Location = new System.Drawing.Point(13, 357);
            this.gbMP3InfoFromFileName.Name = "gbMP3InfoFromFileName";
            this.gbMP3InfoFromFileName.Size = new System.Drawing.Size(576, 148);
            this.gbMP3InfoFromFileName.TabIndex = 9;
            this.gbMP3InfoFromFileName.TabStop = false;
            this.gbMP3InfoFromFileName.Text = "MP3 Info From File Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(320, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Track";
            // 
            // tbCalcTrack
            // 
            this.tbCalcTrack.Location = new System.Drawing.Point(319, 40);
            this.tbCalcTrack.Multiline = true;
            this.tbCalcTrack.Name = "tbCalcTrack";
            this.tbCalcTrack.ReadOnly = true;
            this.tbCalcTrack.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcTrack.Size = new System.Drawing.Size(104, 33);
            this.tbCalcTrack.TabIndex = 26;
            // 
            // ckbUseDirForInfo
            // 
            this.ckbUseDirForInfo.AutoSize = true;
            this.ckbUseDirForInfo.Location = new System.Drawing.Point(6, 75);
            this.ckbUseDirForInfo.Name = "ckbUseDirForInfo";
            this.ckbUseDirForInfo.Size = new System.Drawing.Size(134, 17);
            this.ckbUseDirForInfo.TabIndex = 25;
            this.ckbUseDirForInfo.Text = "Use Path For MP3 Info";
            this.ckbUseDirForInfo.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(319, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Comment";
            // 
            // tbcalcComment
            // 
            this.tbcalcComment.Location = new System.Drawing.Point(319, 101);
            this.tbcalcComment.Multiline = true;
            this.tbcalcComment.Name = "tbcalcComment";
            this.tbcalcComment.ReadOnly = true;
            this.tbcalcComment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbcalcComment.Size = new System.Drawing.Size(104, 33);
            this.tbcalcComment.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(234, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Artists";
            // 
            // tbCalcArtists
            // 
            this.tbCalcArtists.Location = new System.Drawing.Point(429, 43);
            this.tbCalcArtists.Multiline = true;
            this.tbCalcArtists.Name = "tbCalcArtists";
            this.tbCalcArtists.ReadOnly = true;
            this.tbCalcArtists.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcArtists.Size = new System.Drawing.Size(104, 33);
            this.tbCalcArtists.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(426, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Title";
            // 
            // tbCalcTitle
            // 
            this.tbCalcTitle.Location = new System.Drawing.Point(209, 43);
            this.tbCalcTitle.Multiline = true;
            this.tbCalcTitle.Name = "tbCalcTitle";
            this.tbCalcTitle.ReadOnly = true;
            this.tbCalcTitle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcTitle.Size = new System.Drawing.Size(104, 33);
            this.tbCalcTitle.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(426, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Genre";
            // 
            // tbCalcGenre
            // 
            this.tbCalcGenre.Location = new System.Drawing.Point(429, 101);
            this.tbCalcGenre.Multiline = true;
            this.tbCalcGenre.Name = "tbCalcGenre";
            this.tbCalcGenre.ReadOnly = true;
            this.tbCalcGenre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcGenre.Size = new System.Drawing.Size(104, 33);
            this.tbCalcGenre.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Album";
            // 
            // tbCalcAlbum
            // 
            this.tbCalcAlbum.Location = new System.Drawing.Point(209, 100);
            this.tbCalcAlbum.Multiline = true;
            this.tbCalcAlbum.Name = "tbCalcAlbum";
            this.tbCalcAlbum.ReadOnly = true;
            this.tbCalcAlbum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbCalcAlbum.Size = new System.Drawing.Size(104, 33);
            this.tbCalcAlbum.TabIndex = 15;
            // 
            // btnGetMusicInfo
            // 
            this.btnGetMusicInfo.Location = new System.Drawing.Point(6, 34);
            this.btnGetMusicInfo.Name = "btnGetMusicInfo";
            this.btnGetMusicInfo.Size = new System.Drawing.Size(134, 23);
            this.btnGetMusicInfo.TabIndex = 12;
            this.btnGetMusicInfo.Text = "Get Music Info";
            this.btnGetMusicInfo.UseVisualStyleBackColor = true;
            this.btnGetMusicInfo.Click += new System.EventHandler(this.btnGetMusicInfo_Click);
            // 
            // btnPopWithNameInfo
            // 
            this.btnPopWithNameInfo.Location = new System.Drawing.Point(6, 98);
            this.btnPopWithNameInfo.Name = "btnPopWithNameInfo";
            this.btnPopWithNameInfo.Size = new System.Drawing.Size(131, 23);
            this.btnPopWithNameInfo.TabIndex = 0;
            this.btnPopWithNameInfo.Text = "Populate With File Info";
            this.btnPopWithNameInfo.UseVisualStyleBackColor = true;
            this.btnPopWithNameInfo.Click += new System.EventHandler(this.btnPopWithNameInfo_Click);
            // 
            // dddtbGetRootDir
            // 
            this.dddtbGetRootDir.AllowDrop = true;
            this.dddtbGetRootDir.ButtonText = "Get Root Dir";
            this.dddtbGetRootDir.FileDialogTitle = null;
            this.dddtbGetRootDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dddtbGetRootDir.ItemFilters = null;
            this.dddtbGetRootDir.ItemText = "";
            this.dddtbGetRootDir.LeftRight = 30;
            this.dddtbGetRootDir.Location = new System.Drawing.Point(10, 32);
            this.dddtbGetRootDir.Name = "dddtbGetRootDir";
            this.dddtbGetRootDir.Size = new System.Drawing.Size(598, 27);
            this.dddtbGetRootDir.TabIndex = 10;
            // 
            // ddtbMp3File
            // 
            this.ddtbMp3File.AllowDrop = true;
            this.ddtbMp3File.ButtonText = "Get MP3 File";
            this.ddtbMp3File.FileDialogTitle = null;
            this.ddtbMp3File.ItemFilters = "mp3";
            this.ddtbMp3File.ItemText = "";
            this.ddtbMp3File.LeftRight = 30;
            this.ddtbMp3File.Location = new System.Drawing.Point(17, 4);
            this.ddtbMp3File.Name = "ddtbMp3File";
            this.ddtbMp3File.Size = new System.Drawing.Size(592, 29);
            this.ddtbMp3File.TabIndex = 11;
            // 
            // FrmMp3TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 519);
            this.Controls.Add(this.ddtbMp3File);
            this.Controls.Add(this.dddtbGetRootDir);
            this.Controls.Add(this.gbMP3InfoFromFileName);
            this.Controls.Add(this.btnEditTag);
            this.Controls.Add(this.btnGetMP3TagData);
            this.Controls.Add(this.gb3v2);
            this.Controls.Add(this.gb3v1);
            this.Name = "FrmMp3TagEditor";
            this.Text = "FrmEditMP3Tag";
            this.gb3v1.ResumeLayout(false);
            this.gb3v1.PerformLayout();
            this.gb3v2.ResumeLayout(false);
            this.gb3v2.PerformLayout();
            this.gbMP3InfoFromFileName.ResumeLayout(false);
            this.gbMP3InfoFromFileName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb3v1;
        private System.Windows.Forms.TextBox tbComment3v1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbYear3v1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAlbum3v1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArtist3v1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle3v1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTrack3v1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb3v2;
        private System.Windows.Forms.TextBox tbComment3v2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbYear3v2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAlbum3v2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbArtist3v2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTitle3v2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTrack3v2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnGetMP3TagData;
        private System.Windows.Forms.Button btnEditTag;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCopyFrom3v2;
        private System.Windows.Forms.Button btnCopyFrom3v1;
        private ID3_Editor.GenreBox cbGenre3v1;
        private ID3_Editor.GenreBox cbGenre3v2;
        private System.Windows.Forms.GroupBox gbMP3InfoFromFileName;
        private System.Windows.Forms.Button btnPopWithNameInfo;
        private System.Windows.Forms.Button btnGetMusicInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCalcGenre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCalcAlbum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCalcArtists;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCalcTitle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbcalcComment;
        private System.Windows.Forms.CheckBox ckbUseDirForInfo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbCalcTrack;
        private BCHControls.UCDragDropDirTextBox dddtbGetRootDir;
        private BCHControls.UCDragDropTextBox ddtbMp3File;
    }
}