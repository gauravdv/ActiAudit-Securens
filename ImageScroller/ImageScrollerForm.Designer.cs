namespace ImageScroller
{
	partial class channelDisplayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(channelDisplayForm));
            this.playControlTable = new System.Windows.Forms.TableLayoutPanel();
            this.scrollPlay = new System.Windows.Forms.Button();
            this.scrollPause = new System.Windows.Forms.Button();
            this.imageScroller = new System.Windows.Forms.TrackBar();
            this.displayLabel = new System.Windows.Forms.Label();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.mainLayout_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.channelLayout_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.imageViewer1 = new System.Windows.Forms.PictureBox();
            this.imageViewer2 = new System.Windows.Forms.PictureBox();
            this.imageViewer3 = new System.Windows.Forms.PictureBox();
            this.imageViewer4 = new System.Windows.Forms.PictureBox();
            this.imageViewer5 = new System.Windows.Forms.PictureBox();
            this.imageViewer6 = new System.Windows.Forms.PictureBox();
            this.imageViewer7 = new System.Windows.Forms.PictureBox();
            this.imageViewer8 = new System.Windows.Forms.PictureBox();
            this.optionLayout_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.channels_grp = new System.Windows.Forms.GroupBox();
            this.channels_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.unloadChannel_btn = new System.Windows.Forms.Button();
            this.loadChannel_btn = new System.Windows.Forms.Button();
            this.channel1_txt = new System.Windows.Forms.TextBox();
            this.channel2_txt = new System.Windows.Forms.TextBox();
            this.channel3_txt = new System.Windows.Forms.TextBox();
            this.channel4_txt = new System.Windows.Forms.TextBox();
            this.channel5_txt = new System.Windows.Forms.TextBox();
            this.channel6_txt = new System.Windows.Forms.TextBox();
            this.channel7_txt = new System.Windows.Forms.TextBox();
            this.channel8_txt = new System.Windows.Forms.TextBox();
            this.channel1_chk = new System.Windows.Forms.CheckBox();
            this.channel2_chk = new System.Windows.Forms.CheckBox();
            this.channel3_chk = new System.Windows.Forms.CheckBox();
            this.channel4_chk = new System.Windows.Forms.CheckBox();
            this.channel5_chk = new System.Windows.Forms.CheckBox();
            this.channel6_chk = new System.Windows.Forms.CheckBox();
            this.channel7_chk = new System.Windows.Forms.CheckBox();
            this.channel8_chk = new System.Windows.Forms.CheckBox();
            this.fileName_grp = new System.Windows.Forms.GroupBox();
            this.fileFormat_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.suffix_txt = new System.Windows.Forms.TextBox();
            this.suffix_lbl = new System.Windows.Forms.Label();
            this.fileType_combo = new System.Windows.Forms.ComboBox();
            this.fileType_lbl = new System.Windows.Forms.Label();
            this.fileNameFormat_lbl = new System.Windows.Forms.Label();
            this.fileNameFormat_combo = new System.Windows.Forms.ComboBox();
            this.prefix_lbl = new System.Windows.Forms.Label();
            this.prefix_txt = new System.Windows.Forms.TextBox();
            this.dateFormat_grp = new System.Windows.Forms.GroupBox();
            this.dateFormat_tbl = new System.Windows.Forms.TableLayoutPanel();
            this.dateFormat_lbl = new System.Windows.Forms.Label();
            this.dateFormat_txt = new System.Windows.Forms.TextBox();
            this.feedDate_lbl = new System.Windows.Forms.Label();
            this.feedDate_date = new System.Windows.Forms.DateTimePicker();
            this.fileNameSample_txt = new System.Windows.Forms.TextBox();
            this.controls_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.controls_grp = new System.Windows.Forms.GroupBox();
            this.screenshot_grp = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.screenshotPath_txt = new System.Windows.Forms.TextBox();
            this.saveScreenshot_btn = new System.Windows.Forms.Button();
            this.playControlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageScroller)).BeginInit();
            this.mainLayout_tbl.SuspendLayout();
            this.channelLayout_flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer8)).BeginInit();
            this.optionLayout_flow.SuspendLayout();
            this.channels_grp.SuspendLayout();
            this.channels_tbl.SuspendLayout();
            this.fileName_grp.SuspendLayout();
            this.fileFormat_tbl.SuspendLayout();
            this.dateFormat_grp.SuspendLayout();
            this.dateFormat_tbl.SuspendLayout();
            this.controls_flow.SuspendLayout();
            this.controls_grp.SuspendLayout();
            this.screenshot_grp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playControlTable
            // 
            this.playControlTable.AutoSize = true;
            this.playControlTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playControlTable.ColumnCount = 4;
            this.playControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playControlTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.playControlTable.Controls.Add(this.scrollPlay, 0, 0);
            this.playControlTable.Controls.Add(this.scrollPause, 1, 0);
            this.playControlTable.Controls.Add(this.imageScroller, 2, 0);
            this.playControlTable.Controls.Add(this.displayLabel, 3, 0);
            this.playControlTable.Location = new System.Drawing.Point(3, 16);
            this.playControlTable.Margin = new System.Windows.Forms.Padding(0);
            this.playControlTable.Name = "playControlTable";
            this.playControlTable.Padding = new System.Windows.Forms.Padding(5);
            this.playControlTable.RowCount = 1;
            this.playControlTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playControlTable.Size = new System.Drawing.Size(1086, 63);
            this.playControlTable.TabIndex = 1;
            // 
            // scrollPlay
            // 
            this.scrollPlay.Location = new System.Drawing.Point(8, 8);
            this.scrollPlay.Name = "scrollPlay";
            this.scrollPlay.Size = new System.Drawing.Size(75, 47);
            this.scrollPlay.TabIndex = 1;
            this.scrollPlay.Text = "Play";
            this.scrollPlay.UseVisualStyleBackColor = true;
            this.scrollPlay.Click += new System.EventHandler(this.scrollPlay_Click);
            // 
            // scrollPause
            // 
            this.scrollPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scrollPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollPause.Enabled = false;
            this.scrollPause.Location = new System.Drawing.Point(89, 8);
            this.scrollPause.Name = "scrollPause";
            this.scrollPause.Size = new System.Drawing.Size(75, 47);
            this.scrollPause.TabIndex = 2;
            this.scrollPause.Text = "Pause";
            this.scrollPause.UseVisualStyleBackColor = true;
            this.scrollPause.Click += new System.EventHandler(this.scrollPause_Click);
            // 
            // imageScroller
            // 
            this.imageScroller.Location = new System.Drawing.Point(170, 8);
            this.imageScroller.Maximum = 86399;
            this.imageScroller.Minimum = 1;
            this.imageScroller.Name = "imageScroller";
            this.imageScroller.Size = new System.Drawing.Size(800, 45);
            this.imageScroller.TabIndex = 3;
            this.imageScroller.TickFrequency = 960;
            this.imageScroller.Value = 1;
            this.imageScroller.ValueChanged += new System.EventHandler(this.imageScroller_ValueChanged);
            // 
            // displayLabel
            // 
            this.displayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(976, 25);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(102, 13);
            this.displayLabel.TabIndex = 4;
            this.displayLabel.Text = "00:00:00 / 00:00:00";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playTimer
            // 
            this.playTimer.Interval = 1000;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // mainLayout_tbl
            // 
            this.mainLayout_tbl.AutoSize = true;
            this.mainLayout_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayout_tbl.ColumnCount = 2;
            this.mainLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout_tbl.Controls.Add(this.channelLayout_flow, 1, 0);
            this.mainLayout_tbl.Controls.Add(this.optionLayout_flow, 0, 0);
            this.mainLayout_tbl.Controls.Add(this.controls_flow, 1, 1);
            this.mainLayout_tbl.Location = new System.Drawing.Point(-1, 1);
            this.mainLayout_tbl.Name = "mainLayout_tbl";
            this.mainLayout_tbl.RowCount = 2;
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout_tbl.Size = new System.Drawing.Size(1563, 821);
            this.mainLayout_tbl.TabIndex = 8;
            // 
            // channelLayout_flow
            // 
            this.channelLayout_flow.AutoSize = true;
            this.channelLayout_flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channelLayout_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelLayout_flow.Controls.Add(this.imageViewer1);
            this.channelLayout_flow.Controls.Add(this.imageViewer2);
            this.channelLayout_flow.Controls.Add(this.imageViewer3);
            this.channelLayout_flow.Controls.Add(this.imageViewer4);
            this.channelLayout_flow.Controls.Add(this.imageViewer5);
            this.channelLayout_flow.Controls.Add(this.imageViewer6);
            this.channelLayout_flow.Controls.Add(this.imageViewer7);
            this.channelLayout_flow.Controls.Add(this.imageViewer8);
            this.channelLayout_flow.Location = new System.Drawing.Point(264, 3);
            this.channelLayout_flow.Name = "channelLayout_flow";
            this.channelLayout_flow.Padding = new System.Windows.Forms.Padding(3);
            this.channelLayout_flow.Size = new System.Drawing.Size(1296, 492);
            this.channelLayout_flow.TabIndex = 0;
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer1.ErrorImage")));
            this.imageViewer1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer1.InitialImage")));
            this.imageViewer1.Location = new System.Drawing.Point(4, 4);
            this.imageViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer1.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer1.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(320, 240);
            this.imageViewer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.TabStop = false;
            // 
            // imageViewer2
            // 
            this.imageViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer2.ErrorImage")));
            this.imageViewer2.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer2.InitialImage")));
            this.imageViewer2.Location = new System.Drawing.Point(326, 4);
            this.imageViewer2.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer2.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer2.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer2.Name = "imageViewer2";
            this.imageViewer2.Size = new System.Drawing.Size(320, 240);
            this.imageViewer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer2.TabIndex = 1;
            this.imageViewer2.TabStop = false;
            // 
            // imageViewer3
            // 
            this.imageViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer3.ErrorImage")));
            this.imageViewer3.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer3.InitialImage")));
            this.imageViewer3.Location = new System.Drawing.Point(648, 4);
            this.imageViewer3.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer3.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer3.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer3.Name = "imageViewer3";
            this.imageViewer3.Size = new System.Drawing.Size(320, 240);
            this.imageViewer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer3.TabIndex = 2;
            this.imageViewer3.TabStop = false;
            // 
            // imageViewer4
            // 
            this.imageViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer4.ErrorImage")));
            this.channelLayout_flow.SetFlowBreak(this.imageViewer4, true);
            this.imageViewer4.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer4.InitialImage")));
            this.imageViewer4.Location = new System.Drawing.Point(970, 4);
            this.imageViewer4.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer4.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer4.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer4.Name = "imageViewer4";
            this.imageViewer4.Size = new System.Drawing.Size(320, 240);
            this.imageViewer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer4.TabIndex = 3;
            this.imageViewer4.TabStop = false;
            // 
            // imageViewer5
            // 
            this.imageViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer5.ErrorImage")));
            this.imageViewer5.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer5.InitialImage")));
            this.imageViewer5.Location = new System.Drawing.Point(4, 246);
            this.imageViewer5.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer5.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer5.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer5.Name = "imageViewer5";
            this.imageViewer5.Size = new System.Drawing.Size(320, 240);
            this.imageViewer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer5.TabIndex = 4;
            this.imageViewer5.TabStop = false;
            // 
            // imageViewer6
            // 
            this.imageViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer6.ErrorImage")));
            this.imageViewer6.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer6.InitialImage")));
            this.imageViewer6.Location = new System.Drawing.Point(326, 246);
            this.imageViewer6.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer6.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer6.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer6.Name = "imageViewer6";
            this.imageViewer6.Size = new System.Drawing.Size(320, 240);
            this.imageViewer6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer6.TabIndex = 5;
            this.imageViewer6.TabStop = false;
            // 
            // imageViewer7
            // 
            this.imageViewer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer7.ErrorImage")));
            this.imageViewer7.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer7.InitialImage")));
            this.imageViewer7.Location = new System.Drawing.Point(648, 246);
            this.imageViewer7.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer7.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer7.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer7.Name = "imageViewer7";
            this.imageViewer7.Size = new System.Drawing.Size(320, 240);
            this.imageViewer7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer7.TabIndex = 6;
            this.imageViewer7.TabStop = false;
            // 
            // imageViewer8
            // 
            this.imageViewer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer8.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageViewer8.ErrorImage")));
            this.imageViewer8.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageViewer8.InitialImage")));
            this.imageViewer8.Location = new System.Drawing.Point(970, 246);
            this.imageViewer8.Margin = new System.Windows.Forms.Padding(1);
            this.imageViewer8.MaximumSize = new System.Drawing.Size(320, 240);
            this.imageViewer8.MinimumSize = new System.Drawing.Size(320, 240);
            this.imageViewer8.Name = "imageViewer8";
            this.imageViewer8.Size = new System.Drawing.Size(320, 240);
            this.imageViewer8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer8.TabIndex = 7;
            this.imageViewer8.TabStop = false;
            // 
            // optionLayout_flow
            // 
            this.optionLayout_flow.AutoSize = true;
            this.optionLayout_flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionLayout_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionLayout_flow.Controls.Add(this.channels_grp);
            this.optionLayout_flow.Controls.Add(this.fileName_grp);
            this.optionLayout_flow.Controls.Add(this.dateFormat_grp);
            this.optionLayout_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optionLayout_flow.Location = new System.Drawing.Point(3, 3);
            this.optionLayout_flow.Name = "optionLayout_flow";
            this.mainLayout_tbl.SetRowSpan(this.optionLayout_flow, 2);
            this.optionLayout_flow.Size = new System.Drawing.Size(255, 815);
            this.optionLayout_flow.TabIndex = 3;
            // 
            // channels_grp
            // 
            this.channels_grp.AutoSize = true;
            this.channels_grp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channels_grp.Controls.Add(this.channels_tbl);
            this.channels_grp.Location = new System.Drawing.Point(3, 3);
            this.channels_grp.Name = "channels_grp";
            this.channels_grp.Size = new System.Drawing.Size(246, 494);
            this.channels_grp.TabIndex = 4;
            this.channels_grp.TabStop = false;
            this.channels_grp.Text = "Channels";
            // 
            // channels_tbl
            // 
            this.channels_tbl.AutoSize = true;
            this.channels_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channels_tbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.channels_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.channels_tbl.ColumnCount = 2;
            this.channels_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.channels_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.channels_tbl.Controls.Add(this.unloadChannel_btn, 1, 0);
            this.channels_tbl.Controls.Add(this.loadChannel_btn, 0, 0);
            this.channels_tbl.Controls.Add(this.channel1_txt, 0, 2);
            this.channels_tbl.Controls.Add(this.channel2_txt, 0, 4);
            this.channels_tbl.Controls.Add(this.channel3_txt, 0, 6);
            this.channels_tbl.Controls.Add(this.channel4_txt, 0, 8);
            this.channels_tbl.Controls.Add(this.channel5_txt, 0, 10);
            this.channels_tbl.Controls.Add(this.channel6_txt, 0, 12);
            this.channels_tbl.Controls.Add(this.channel7_txt, 0, 14);
            this.channels_tbl.Controls.Add(this.channel8_txt, 0, 16);
            this.channels_tbl.Controls.Add(this.channel1_chk, 0, 1);
            this.channels_tbl.Controls.Add(this.channel2_chk, 0, 3);
            this.channels_tbl.Controls.Add(this.channel3_chk, 0, 5);
            this.channels_tbl.Controls.Add(this.channel4_chk, 0, 7);
            this.channels_tbl.Controls.Add(this.channel5_chk, 0, 9);
            this.channels_tbl.Controls.Add(this.channel6_chk, 0, 11);
            this.channels_tbl.Controls.Add(this.channel7_chk, 0, 13);
            this.channels_tbl.Controls.Add(this.channel8_chk, 0, 15);
            this.channels_tbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channels_tbl.Location = new System.Drawing.Point(3, 16);
            this.channels_tbl.Name = "channels_tbl";
            this.channels_tbl.RowCount = 17;
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.channels_tbl.Size = new System.Drawing.Size(237, 459);
            this.channels_tbl.TabIndex = 2;
            // 
            // unloadChannel_btn
            // 
            this.unloadChannel_btn.Location = new System.Drawing.Point(122, 5);
            this.unloadChannel_btn.Name = "unloadChannel_btn";
            this.unloadChannel_btn.Size = new System.Drawing.Size(110, 25);
            this.unloadChannel_btn.TabIndex = 1;
            this.unloadChannel_btn.Text = "Unload Channels";
            this.unloadChannel_btn.UseVisualStyleBackColor = true;
            this.unloadChannel_btn.Click += new System.EventHandler(this.unloadChannel_btn_Click);
            // 
            // loadChannel_btn
            // 
            this.loadChannel_btn.Location = new System.Drawing.Point(5, 5);
            this.loadChannel_btn.Name = "loadChannel_btn";
            this.loadChannel_btn.Size = new System.Drawing.Size(109, 25);
            this.loadChannel_btn.TabIndex = 0;
            this.loadChannel_btn.Text = "Load Channels";
            this.loadChannel_btn.UseVisualStyleBackColor = true;
            this.loadChannel_btn.Click += new System.EventHandler(this.loadChannel_btn_Click);
            // 
            // channel1_txt
            // 
            this.channel1_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel1_txt, 2);
            this.channel1_txt.Location = new System.Drawing.Point(5, 63);
            this.channel1_txt.Name = "channel1_txt";
            this.channel1_txt.Size = new System.Drawing.Size(227, 20);
            this.channel1_txt.TabIndex = 3;
            // 
            // channel2_txt
            // 
            this.channel2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel2_txt, 2);
            this.channel2_txt.Location = new System.Drawing.Point(5, 116);
            this.channel2_txt.Name = "channel2_txt";
            this.channel2_txt.Size = new System.Drawing.Size(227, 20);
            this.channel2_txt.TabIndex = 11;
            // 
            // channel3_txt
            // 
            this.channel3_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel3_txt, 2);
            this.channel3_txt.Location = new System.Drawing.Point(5, 169);
            this.channel3_txt.Name = "channel3_txt";
            this.channel3_txt.Size = new System.Drawing.Size(227, 20);
            this.channel3_txt.TabIndex = 12;
            // 
            // channel4_txt
            // 
            this.channel4_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel4_txt, 2);
            this.channel4_txt.Location = new System.Drawing.Point(5, 222);
            this.channel4_txt.Name = "channel4_txt";
            this.channel4_txt.Size = new System.Drawing.Size(227, 20);
            this.channel4_txt.TabIndex = 13;
            // 
            // channel5_txt
            // 
            this.channel5_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel5_txt, 2);
            this.channel5_txt.Location = new System.Drawing.Point(5, 275);
            this.channel5_txt.Name = "channel5_txt";
            this.channel5_txt.Size = new System.Drawing.Size(227, 20);
            this.channel5_txt.TabIndex = 14;
            // 
            // channel6_txt
            // 
            this.channel6_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel6_txt, 2);
            this.channel6_txt.Location = new System.Drawing.Point(5, 328);
            this.channel6_txt.Name = "channel6_txt";
            this.channel6_txt.Size = new System.Drawing.Size(227, 20);
            this.channel6_txt.TabIndex = 15;
            // 
            // channel7_txt
            // 
            this.channel7_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel7_txt, 2);
            this.channel7_txt.Location = new System.Drawing.Point(5, 381);
            this.channel7_txt.Name = "channel7_txt";
            this.channel7_txt.Size = new System.Drawing.Size(227, 20);
            this.channel7_txt.TabIndex = 16;
            // 
            // channel8_txt
            // 
            this.channel8_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channels_tbl.SetColumnSpan(this.channel8_txt, 2);
            this.channel8_txt.Location = new System.Drawing.Point(5, 434);
            this.channel8_txt.Name = "channel8_txt";
            this.channel8_txt.Size = new System.Drawing.Size(227, 20);
            this.channel8_txt.TabIndex = 17;
            // 
            // channel1_chk
            // 
            this.channel1_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel1_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel1_chk, 2);
            this.channel1_chk.Location = new System.Drawing.Point(5, 38);
            this.channel1_chk.Name = "channel1_chk";
            this.channel1_chk.Size = new System.Drawing.Size(227, 17);
            this.channel1_chk.TabIndex = 18;
            this.channel1_chk.Text = "Channel 1";
            this.channel1_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel1_chk.UseVisualStyleBackColor = true;
            // 
            // channel2_chk
            // 
            this.channel2_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel2_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel2_chk, 2);
            this.channel2_chk.Location = new System.Drawing.Point(5, 91);
            this.channel2_chk.Name = "channel2_chk";
            this.channel2_chk.Size = new System.Drawing.Size(227, 17);
            this.channel2_chk.TabIndex = 19;
            this.channel2_chk.Text = "Channel 2";
            this.channel2_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel2_chk.UseVisualStyleBackColor = true;
            // 
            // channel3_chk
            // 
            this.channel3_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel3_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel3_chk, 2);
            this.channel3_chk.Location = new System.Drawing.Point(5, 144);
            this.channel3_chk.Name = "channel3_chk";
            this.channel3_chk.Size = new System.Drawing.Size(227, 17);
            this.channel3_chk.TabIndex = 20;
            this.channel3_chk.Text = "Channel 3";
            this.channel3_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel3_chk.UseVisualStyleBackColor = true;
            // 
            // channel4_chk
            // 
            this.channel4_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel4_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel4_chk, 2);
            this.channel4_chk.Location = new System.Drawing.Point(5, 197);
            this.channel4_chk.Name = "channel4_chk";
            this.channel4_chk.Size = new System.Drawing.Size(227, 17);
            this.channel4_chk.TabIndex = 21;
            this.channel4_chk.Text = "Channel 4";
            this.channel4_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel4_chk.UseVisualStyleBackColor = true;
            // 
            // channel5_chk
            // 
            this.channel5_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel5_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel5_chk, 2);
            this.channel5_chk.Location = new System.Drawing.Point(5, 250);
            this.channel5_chk.Name = "channel5_chk";
            this.channel5_chk.Size = new System.Drawing.Size(227, 17);
            this.channel5_chk.TabIndex = 22;
            this.channel5_chk.Text = "Channel 5";
            this.channel5_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel5_chk.UseVisualStyleBackColor = true;
            // 
            // channel6_chk
            // 
            this.channel6_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel6_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel6_chk, 2);
            this.channel6_chk.Location = new System.Drawing.Point(5, 303);
            this.channel6_chk.Name = "channel6_chk";
            this.channel6_chk.Size = new System.Drawing.Size(227, 17);
            this.channel6_chk.TabIndex = 23;
            this.channel6_chk.Text = "Channel 6";
            this.channel6_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel6_chk.UseVisualStyleBackColor = true;
            // 
            // channel7_chk
            // 
            this.channel7_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel7_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel7_chk, 2);
            this.channel7_chk.Location = new System.Drawing.Point(5, 356);
            this.channel7_chk.Name = "channel7_chk";
            this.channel7_chk.Size = new System.Drawing.Size(227, 17);
            this.channel7_chk.TabIndex = 24;
            this.channel7_chk.Text = "Channel 7";
            this.channel7_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel7_chk.UseVisualStyleBackColor = true;
            // 
            // channel8_chk
            // 
            this.channel8_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.channel8_chk.AutoSize = true;
            this.channels_tbl.SetColumnSpan(this.channel8_chk, 2);
            this.channel8_chk.Location = new System.Drawing.Point(5, 409);
            this.channel8_chk.Name = "channel8_chk";
            this.channel8_chk.Size = new System.Drawing.Size(227, 17);
            this.channel8_chk.TabIndex = 25;
            this.channel8_chk.Text = "Channel 8";
            this.channel8_chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.channel8_chk.UseVisualStyleBackColor = true;
            // 
            // fileName_grp
            // 
            this.fileName_grp.AutoSize = true;
            this.fileName_grp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileName_grp.Controls.Add(this.fileFormat_tbl);
            this.fileName_grp.Location = new System.Drawing.Point(3, 503);
            this.fileName_grp.Name = "fileName_grp";
            this.fileName_grp.Size = new System.Drawing.Size(232, 148);
            this.fileName_grp.TabIndex = 6;
            this.fileName_grp.TabStop = false;
            this.fileName_grp.Text = "File Name Settings";
            // 
            // fileFormat_tbl
            // 
            this.fileFormat_tbl.AutoSize = true;
            this.fileFormat_tbl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileFormat_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.fileFormat_tbl.ColumnCount = 2;
            this.fileFormat_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileFormat_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileFormat_tbl.Controls.Add(this.suffix_txt, 1, 3);
            this.fileFormat_tbl.Controls.Add(this.suffix_lbl, 0, 3);
            this.fileFormat_tbl.Controls.Add(this.fileType_combo, 1, 1);
            this.fileFormat_tbl.Controls.Add(this.fileType_lbl, 0, 1);
            this.fileFormat_tbl.Controls.Add(this.fileNameFormat_lbl, 0, 0);
            this.fileFormat_tbl.Controls.Add(this.fileNameFormat_combo, 1, 0);
            this.fileFormat_tbl.Controls.Add(this.prefix_lbl, 0, 2);
            this.fileFormat_tbl.Controls.Add(this.prefix_txt, 1, 2);
            this.fileFormat_tbl.Location = new System.Drawing.Point(2, 16);
            this.fileFormat_tbl.Margin = new System.Windows.Forms.Padding(0);
            this.fileFormat_tbl.Name = "fileFormat_tbl";
            this.fileFormat_tbl.RowCount = 4;
            this.fileFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileFormat_tbl.Size = new System.Drawing.Size(227, 116);
            this.fileFormat_tbl.TabIndex = 0;
            // 
            // suffix_txt
            // 
            this.suffix_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suffix_txt.Location = new System.Drawing.Point(72, 91);
            this.suffix_txt.Name = "suffix_txt";
            this.suffix_txt.Size = new System.Drawing.Size(150, 20);
            this.suffix_txt.TabIndex = 6;
            this.suffix_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.suffix_txt_KeyUp);
            // 
            // suffix_lbl
            // 
            this.suffix_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suffix_lbl.AutoSize = true;
            this.suffix_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suffix_lbl.Location = new System.Drawing.Point(5, 94);
            this.suffix_lbl.Name = "suffix_lbl";
            this.suffix_lbl.Size = new System.Drawing.Size(59, 13);
            this.suffix_lbl.TabIndex = 4;
            this.suffix_lbl.Text = "Suffix";
            // 
            // fileType_combo
            // 
            this.fileType_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType_combo.DropDownWidth = 150;
            this.fileType_combo.FormattingEnabled = true;
            this.fileType_combo.Items.AddRange(new object[] {
            "jpg",
            "png"});
            this.fileType_combo.Location = new System.Drawing.Point(72, 34);
            this.fileType_combo.Name = "fileType_combo";
            this.fileType_combo.Size = new System.Drawing.Size(150, 21);
            this.fileType_combo.Sorted = true;
            this.fileType_combo.TabIndex = 2;
            this.fileType_combo.SelectedIndexChanged += new System.EventHandler(this.fileType_combo_SelectedIndexChanged);
            // 
            // fileType_lbl
            // 
            this.fileType_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType_lbl.AutoSize = true;
            this.fileType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileType_lbl.Location = new System.Drawing.Point(5, 38);
            this.fileType_lbl.Name = "fileType_lbl";
            this.fileType_lbl.Size = new System.Drawing.Size(59, 13);
            this.fileType_lbl.TabIndex = 2;
            this.fileType_lbl.Text = "File Type";
            // 
            // fileNameFormat_lbl
            // 
            this.fileNameFormat_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameFormat_lbl.AutoSize = true;
            this.fileNameFormat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameFormat_lbl.Location = new System.Drawing.Point(5, 9);
            this.fileNameFormat_lbl.Name = "fileNameFormat_lbl";
            this.fileNameFormat_lbl.Size = new System.Drawing.Size(59, 13);
            this.fileNameFormat_lbl.TabIndex = 0;
            this.fileNameFormat_lbl.Text = "Format";
            // 
            // fileNameFormat_combo
            // 
            this.fileNameFormat_combo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameFormat_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fileNameFormat_combo.DropDownWidth = 150;
            this.fileNameFormat_combo.FormattingEnabled = true;
            this.fileNameFormat_combo.Items.AddRange(new object[] {
            "Date",
            "Number"});
            this.fileNameFormat_combo.Location = new System.Drawing.Point(72, 5);
            this.fileNameFormat_combo.Name = "fileNameFormat_combo";
            this.fileNameFormat_combo.Size = new System.Drawing.Size(150, 21);
            this.fileNameFormat_combo.Sorted = true;
            this.fileNameFormat_combo.TabIndex = 1;
            this.fileNameFormat_combo.SelectedIndexChanged += new System.EventHandler(this.fileNameFormat_combo_SelectedIndexChanged);
            // 
            // prefix_lbl
            // 
            this.prefix_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prefix_lbl.AutoSize = true;
            this.prefix_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefix_lbl.Location = new System.Drawing.Point(5, 66);
            this.prefix_lbl.Name = "prefix_lbl";
            this.prefix_lbl.Size = new System.Drawing.Size(59, 13);
            this.prefix_lbl.TabIndex = 3;
            this.prefix_lbl.Text = "Prefix";
            // 
            // prefix_txt
            // 
            this.prefix_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prefix_txt.Location = new System.Drawing.Point(72, 63);
            this.prefix_txt.Name = "prefix_txt";
            this.prefix_txt.Size = new System.Drawing.Size(150, 20);
            this.prefix_txt.TabIndex = 5;
            this.prefix_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prefix_txt_KeyUp);
            // 
            // dateFormat_grp
            // 
            this.dateFormat_grp.AutoSize = true;
            this.dateFormat_grp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateFormat_grp.Controls.Add(this.dateFormat_tbl);
            this.dateFormat_grp.Location = new System.Drawing.Point(3, 657);
            this.dateFormat_grp.Name = "dateFormat_grp";
            this.dateFormat_grp.Size = new System.Drawing.Size(247, 153);
            this.dateFormat_grp.TabIndex = 7;
            this.dateFormat_grp.TabStop = false;
            this.dateFormat_grp.Text = "Date Format";
            // 
            // dateFormat_tbl
            // 
            this.dateFormat_tbl.AutoSize = true;
            this.dateFormat_tbl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.dateFormat_tbl.ColumnCount = 2;
            this.dateFormat_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dateFormat_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dateFormat_tbl.Controls.Add(this.dateFormat_lbl, 0, 0);
            this.dateFormat_tbl.Controls.Add(this.dateFormat_txt, 0, 1);
            this.dateFormat_tbl.Controls.Add(this.feedDate_lbl, 0, 2);
            this.dateFormat_tbl.Controls.Add(this.feedDate_date, 0, 3);
            this.dateFormat_tbl.Controls.Add(this.fileNameSample_txt, 0, 4);
            this.dateFormat_tbl.Location = new System.Drawing.Point(3, 16);
            this.dateFormat_tbl.Name = "dateFormat_tbl";
            this.dateFormat_tbl.RowCount = 5;
            this.dateFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateFormat_tbl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dateFormat_tbl.Size = new System.Drawing.Size(238, 118);
            this.dateFormat_tbl.TabIndex = 0;
            // 
            // dateFormat_lbl
            // 
            this.dateFormat_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFormat_lbl.AutoSize = true;
            this.dateFormat_tbl.SetColumnSpan(this.dateFormat_lbl, 2);
            this.dateFormat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFormat_lbl.Location = new System.Drawing.Point(5, 2);
            this.dateFormat_lbl.Name = "dateFormat_lbl";
            this.dateFormat_lbl.Size = new System.Drawing.Size(228, 13);
            this.dateFormat_lbl.TabIndex = 0;
            this.dateFormat_lbl.Text = "Date Format";
            this.dateFormat_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateFormat_txt
            // 
            this.dateFormat_tbl.SetColumnSpan(this.dateFormat_txt, 2);
            this.dateFormat_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFormat_txt.Location = new System.Drawing.Point(5, 20);
            this.dateFormat_txt.Name = "dateFormat_txt";
            this.dateFormat_txt.Size = new System.Drawing.Size(228, 20);
            this.dateFormat_txt.TabIndex = 1;
            this.dateFormat_txt.Text = "yyyy-MM-dd_HH-mm-ss";
            this.dateFormat_txt.TextChanged += new System.EventHandler(this.dateFormat_txt_TextChanged);
            this.dateFormat_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateFormat_txt_KeyUp);
            // 
            // feedDate_lbl
            // 
            this.feedDate_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.feedDate_lbl.AutoSize = true;
            this.dateFormat_tbl.SetColumnSpan(this.feedDate_lbl, 2);
            this.feedDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedDate_lbl.Location = new System.Drawing.Point(5, 45);
            this.feedDate_lbl.Name = "feedDate_lbl";
            this.feedDate_lbl.Size = new System.Drawing.Size(228, 13);
            this.feedDate_lbl.TabIndex = 2;
            this.feedDate_lbl.Text = "Date";
            this.feedDate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feedDate_date
            // 
            this.feedDate_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFormat_tbl.SetColumnSpan(this.feedDate_date, 2);
            this.feedDate_date.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.feedDate_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.feedDate_date.Location = new System.Drawing.Point(5, 63);
            this.feedDate_date.Name = "feedDate_date";
            this.feedDate_date.Size = new System.Drawing.Size(228, 20);
            this.feedDate_date.TabIndex = 3;
            this.feedDate_date.ValueChanged += new System.EventHandler(this.feedDate_date_ValueChanged);
            // 
            // fileNameSample_txt
            // 
            this.fileNameSample_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFormat_tbl.SetColumnSpan(this.fileNameSample_txt, 2);
            this.fileNameSample_txt.Location = new System.Drawing.Point(5, 92);
            this.fileNameSample_txt.Name = "fileNameSample_txt";
            this.fileNameSample_txt.ReadOnly = true;
            this.fileNameSample_txt.Size = new System.Drawing.Size(228, 20);
            this.fileNameSample_txt.TabIndex = 4;
            this.fileNameSample_txt.Text = "Unkown Format";
            this.fileNameSample_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // controls_flow
            // 
            this.controls_flow.AutoSize = true;
            this.controls_flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controls_flow.Controls.Add(this.controls_grp);
            this.controls_flow.Controls.Add(this.screenshot_grp);
            this.controls_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.controls_flow.Location = new System.Drawing.Point(264, 501);
            this.controls_flow.Name = "controls_flow";
            this.controls_flow.Size = new System.Drawing.Size(1098, 178);
            this.controls_flow.TabIndex = 10;
            // 
            // controls_grp
            // 
            this.controls_grp.AutoSize = true;
            this.controls_grp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controls_grp.Controls.Add(this.playControlTable);
            this.controls_grp.Location = new System.Drawing.Point(3, 3);
            this.controls_grp.Name = "controls_grp";
            this.controls_grp.Size = new System.Drawing.Size(1092, 95);
            this.controls_grp.TabIndex = 9;
            this.controls_grp.TabStop = false;
            this.controls_grp.Text = "Controls";
            // 
            // screenshot_grp
            // 
            this.screenshot_grp.AutoSize = true;
            this.screenshot_grp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screenshot_grp.Controls.Add(this.flowLayoutPanel1);
            this.screenshot_grp.Location = new System.Drawing.Point(3, 104);
            this.screenshot_grp.Name = "screenshot_grp";
            this.screenshot_grp.Size = new System.Drawing.Size(626, 71);
            this.screenshot_grp.TabIndex = 10;
            this.screenshot_grp.TabStop = false;
            this.screenshot_grp.Text = "Screenshot";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.screenshotPath_txt);
            this.flowLayoutPanel1.Controls.Add(this.saveScreenshot_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(609, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Location";
            // 
            // screenshotPath_txt
            // 
            this.screenshotPath_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.screenshotPath_txt.Location = new System.Drawing.Point(104, 4);
            this.screenshotPath_txt.Name = "screenshotPath_txt";
            this.screenshotPath_txt.Size = new System.Drawing.Size(450, 20);
            this.screenshotPath_txt.TabIndex = 0;
            // 
            // saveScreenshot_btn
            // 
            this.saveScreenshot_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveScreenshot_btn.AutoSize = true;
            this.saveScreenshot_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveScreenshot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScreenshot_btn.Location = new System.Drawing.Point(560, 3);
            this.saveScreenshot_btn.Name = "saveScreenshot_btn";
            this.saveScreenshot_btn.Size = new System.Drawing.Size(46, 23);
            this.saveScreenshot_btn.TabIndex = 1;
            this.saveScreenshot_btn.Text = "Save";
            this.saveScreenshot_btn.UseVisualStyleBackColor = true;
            this.saveScreenshot_btn.Click += new System.EventHandler(this.saveScreenshot_btn_Click);
            // 
            // channelDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.mainLayout_tbl);
            this.Name = "channelDisplayForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Scroller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.playControlTable.ResumeLayout(false);
            this.playControlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageScroller)).EndInit();
            this.mainLayout_tbl.ResumeLayout(false);
            this.mainLayout_tbl.PerformLayout();
            this.channelLayout_flow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer8)).EndInit();
            this.optionLayout_flow.ResumeLayout(false);
            this.optionLayout_flow.PerformLayout();
            this.channels_grp.ResumeLayout(false);
            this.channels_grp.PerformLayout();
            this.channels_tbl.ResumeLayout(false);
            this.channels_tbl.PerformLayout();
            this.fileName_grp.ResumeLayout(false);
            this.fileName_grp.PerformLayout();
            this.fileFormat_tbl.ResumeLayout(false);
            this.fileFormat_tbl.PerformLayout();
            this.dateFormat_grp.ResumeLayout(false);
            this.dateFormat_grp.PerformLayout();
            this.dateFormat_tbl.ResumeLayout(false);
            this.dateFormat_tbl.PerformLayout();
            this.controls_flow.ResumeLayout(false);
            this.controls_flow.PerformLayout();
            this.controls_grp.ResumeLayout(false);
            this.controls_grp.PerformLayout();
            this.screenshot_grp.ResumeLayout(false);
            this.screenshot_grp.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel playControlTable;
		private System.Windows.Forms.Timer playTimer;
		private System.Windows.Forms.Button scrollPlay;
		private System.Windows.Forms.Button scrollPause;
		private System.Windows.Forms.TrackBar imageScroller;
		private System.Windows.Forms.Label displayLabel;
		private System.Windows.Forms.TableLayoutPanel mainLayout_tbl;
		private System.Windows.Forms.FlowLayoutPanel channelLayout_flow;
		private System.Windows.Forms.PictureBox imageViewer1;
		private System.Windows.Forms.PictureBox imageViewer2;
		private System.Windows.Forms.PictureBox imageViewer3;
		private System.Windows.Forms.PictureBox imageViewer4;
		private System.Windows.Forms.PictureBox imageViewer5;
		private System.Windows.Forms.PictureBox imageViewer6;
		private System.Windows.Forms.PictureBox imageViewer7;
		private System.Windows.Forms.PictureBox imageViewer8;
		private System.Windows.Forms.GroupBox controls_grp;
		private System.Windows.Forms.FlowLayoutPanel optionLayout_flow;
		private System.Windows.Forms.Button loadChannel_btn;
		private System.Windows.Forms.Button unloadChannel_btn;
		private System.Windows.Forms.GroupBox channels_grp;
		private System.Windows.Forms.TableLayoutPanel channels_tbl;
		private System.Windows.Forms.TextBox channel1_txt;
		private System.Windows.Forms.TextBox channel2_txt;
		private System.Windows.Forms.TextBox channel3_txt;
		private System.Windows.Forms.TextBox channel4_txt;
		private System.Windows.Forms.TextBox channel5_txt;
		private System.Windows.Forms.TextBox channel6_txt;
		private System.Windows.Forms.TextBox channel7_txt;
		private System.Windows.Forms.TextBox channel8_txt;
		private System.Windows.Forms.GroupBox fileName_grp;
		private System.Windows.Forms.TableLayoutPanel fileFormat_tbl;
		private System.Windows.Forms.ComboBox fileType_combo;
		private System.Windows.Forms.Label fileType_lbl;
		private System.Windows.Forms.Label fileNameFormat_lbl;
		private System.Windows.Forms.ComboBox fileNameFormat_combo;
		private System.Windows.Forms.GroupBox dateFormat_grp;
		private System.Windows.Forms.TableLayoutPanel dateFormat_tbl;
		private System.Windows.Forms.Label dateFormat_lbl;
		private System.Windows.Forms.TextBox dateFormat_txt;
		private System.Windows.Forms.Label feedDate_lbl;
		private System.Windows.Forms.DateTimePicker feedDate_date;
		private System.Windows.Forms.TextBox fileNameSample_txt;
		private System.Windows.Forms.TextBox suffix_txt;
		private System.Windows.Forms.Label suffix_lbl;
		private System.Windows.Forms.Label prefix_lbl;
		private System.Windows.Forms.TextBox prefix_txt;
		private System.Windows.Forms.CheckBox channel1_chk;
		private System.Windows.Forms.CheckBox channel2_chk;
		private System.Windows.Forms.CheckBox channel3_chk;
		private System.Windows.Forms.CheckBox channel4_chk;
		private System.Windows.Forms.CheckBox channel5_chk;
		private System.Windows.Forms.CheckBox channel6_chk;
		private System.Windows.Forms.CheckBox channel7_chk;
		private System.Windows.Forms.CheckBox channel8_chk;
		private System.Windows.Forms.FlowLayoutPanel controls_flow;
		private System.Windows.Forms.GroupBox screenshot_grp;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox screenshotPath_txt;
		private System.Windows.Forms.Button saveScreenshot_btn;
		private System.Windows.Forms.Label label1;
	}
}

