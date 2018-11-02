using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ImageScroller
{
	public partial class channelDisplayForm : Form
	{
		private int scrollIndex = 1;
		private int scrollerMin = 1;
		private int scrollerMax = 86399;
		private String scrollMaxTime = "00:00:00";

		private String fileFormatType = "Date";
		private String fileNameExtension = "jpg";

		private String defaultDateFormat = "yyyy-MM-dd_HH-mm-ss";
		private String fileDateFormat = "yyyy-MM-dd_HH-mm-ss";

		private DateTime referenceDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.Now.Day) - 1);
		private DateTime feedDate;

		private String fileNamePrefix = string.Empty;
		private String fileNameSuffix = string.Empty;

		private String fileNameFormat = "{0}{1}{2}.{3}";
		//private String fileBasePath = @"E:\Workspace\Konsultera\Resources\Cams\2017-09-20\{0}";

		Dictionary<int, ChannelInfo> channelSet = new Dictionary<int, ChannelInfo>();

		public channelDisplayForm()
		{
			InitializeComponent();
			initChannelDisplayForm();
		}

		private void initChannelDisplayForm()
		{
			initSelection();
			initChannels();
		}

		private void initScroller()
		{
			scrollIndex = scrollerMin;
			imageScroller.Minimum = scrollerMin;
			imageScroller.Maximum = scrollerMax;
			imageScroller.Value = scrollIndex;

			scrollMaxTime = getScrollTimeSpan(scrollerMax).ToString();
		}

		private void initSelection()
		{
			unloadChannel_cleanup();
			channel1_txt.Text = null;
			channel2_txt.Text = null;
			channel3_txt.Text = null;
			channel4_txt.Text = null;
			channel5_txt.Text = null;
			channel6_txt.Text = null;
			channel7_txt.Text = null;
			channel8_txt.Text = null;
			fileNameFormat_combo.SelectedIndex = 0;
			fileType_combo.SelectedIndex = 0;
			dateFormat_txt.Text = defaultDateFormat;
			feedDate_date.Value = referenceDateTime;
			getFileFormatSample();
		}

		private void initChannels()
		{
			channelSet.Clear();

			ChannelInfo channelInfo1 = new ChannelInfo();
			ChannelInfo channelInfo2 = new ChannelInfo();
			ChannelInfo channelInfo3 = new ChannelInfo();
			ChannelInfo channelInfo4 = new ChannelInfo();
			ChannelInfo channelInfo5 = new ChannelInfo();
			ChannelInfo channelInfo6 = new ChannelInfo();
			ChannelInfo channelInfo7 = new ChannelInfo();
			ChannelInfo channelInfo8 = new ChannelInfo();

			channelInfo1.ImageViewer = imageViewer1;
			channelInfo1.ChannelNumber = 1;
			channelInfo1.FileBasePath = null;
			channelSet.Add(1, channelInfo1);

			channelInfo2.ImageViewer = imageViewer2;
			channelInfo2.ChannelNumber = 2;
			channelInfo2.FileBasePath = null;
			channelSet.Add(2, channelInfo2);

			channelInfo3.ImageViewer = imageViewer3;
			channelInfo3.ChannelNumber = 3;
			channelInfo3.FileBasePath = null;
			channelSet.Add(3, channelInfo3);

			channelInfo4.ImageViewer = imageViewer4;
			channelInfo4.ChannelNumber = 4;
			channelInfo4.FileBasePath = null;
			channelSet.Add(4, channelInfo4);

			channelInfo5.ImageViewer = imageViewer5;
			channelInfo5.ChannelNumber = 5;
			channelInfo5.FileBasePath = null;
			channelSet.Add(5, channelInfo5);

			channelInfo6.ImageViewer = imageViewer6;
			channelInfo6.ChannelNumber = 6;
			channelInfo6.FileBasePath = null;
			channelSet.Add(6, channelInfo6);

			channelInfo7.ImageViewer = imageViewer7;
			channelInfo7.ChannelNumber = 7;
			channelInfo7.FileBasePath = null;
			channelSet.Add(7, channelInfo7);

			channelInfo8.ImageViewer = imageViewer8;
			channelInfo8.ChannelNumber = 8;
			channelInfo8.FileBasePath = null;
			channelSet.Add(8, channelInfo8);
		}

		private void loadNextImage()
		{

			String fileName = getCurrentImageFileName(scrollIndex);

			//imageViewer1.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer2.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer3.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer4.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer5.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer6.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer7.ImageLocation = string.Format(fileBasePath, fileName);
			//imageViewer8.ImageLocation = string.Format(fileBasePath, fileName);

			foreach (KeyValuePair<int, ChannelInfo> channelSetItem in channelSet)
			{
				ChannelInfo _channelInfo = channelSetItem.Value;
				PictureBox _imageViewer = new PictureBox();
				String _fileBasePath = _channelInfo.FileBasePath;

				if (_fileBasePath != null && !string.IsNullOrEmpty(_fileBasePath))
				{
					if (!_fileBasePath.Substring(_fileBasePath.Length - 1, 1).Equals("\\"))
					{
						_fileBasePath = _fileBasePath + "\\"; 
					}
				}

				_imageViewer = (PictureBox)_channelInfo.ImageViewer;
				_imageViewer.ImageLocation = _fileBasePath + fileName;
			}

			setCurrentDisplayLabel();
		}

		private TimeSpan getScrollTimeSpan(int timeSpanSeconds)
		{
			TimeSpan scrollTimeSpan = new TimeSpan();

			scrollTimeSpan = new TimeSpan(0, 0, timeSpanSeconds);

			return scrollTimeSpan;
		}

		private DateTime getCurrentScrollDateTime(int currentScrollIndex)
		{
			DateTime currentScrollDateTime = referenceDateTime;

			currentScrollDateTime = currentScrollDateTime.Add(getScrollTimeSpan(currentScrollIndex));

			return currentScrollDateTime;
		}

		private String getCurrentDateTimeString(int currentScrollIndex, String _fileDateFormat)
		{
			String currentDateTimeString = String.Empty;

			currentDateTimeString = getCurrentScrollDateTime(currentScrollIndex).ToString(_fileDateFormat);

			return currentDateTimeString;
		}

		private String getCurrentImageFileName(int currentScrollIndex)
		{
			String currentImageFilename = String.Empty;

			if (fileFormatType.Equals("Date", StringComparison.InvariantCultureIgnoreCase))
			{
				currentImageFilename = string.Format(fileNameFormat, fileNamePrefix, getCurrentDateTimeString(scrollIndex, fileDateFormat), fileNameSuffix, fileNameExtension);
			}
			else if (fileFormatType.Equals("Number", StringComparison.InvariantCultureIgnoreCase))
			{
				currentImageFilename = string.Format(fileNameFormat, fileNamePrefix, currentScrollIndex, fileNameSuffix, fileNameExtension);
			}

			return currentImageFilename;
		}

		private String getCurrentPlayTime(int currentScrollIndex)
		{
			String currentPlayTime = String.Empty;

			currentPlayTime = getScrollTimeSpan(currentScrollIndex).ToString(); ;

			return currentPlayTime;
		}

		private void setCurrentDisplayLabel()
		{
			displayLabel.Text = getCurrentPlayTime(scrollIndex) + "/" + scrollMaxTime;
		 }

		private void getFileFormatSample()
		{
			String sampleFormat = "Invalid Format";
			String fileType = string.Empty;
			String _prefix = string.Empty;
			String _suffix = string.Empty;

			if (fileType_combo.SelectedItem != null && !string.IsNullOrEmpty(fileType_combo.SelectedItem.ToString()))
			{
				fileType = fileType_combo.SelectedItem.ToString();

				_prefix = prefix_txt.Text;
				_suffix = suffix_txt.Text;

				if (fileNameFormat_combo.SelectedItem.ToString().Equals("Date", StringComparison.InvariantCultureIgnoreCase))
				{
					DateTime sampleDateTime = feedDate_date.Value;
					String dateFormat = dateFormat_txt.Text;

					sampleFormat = string.Format(fileNameFormat, _prefix, sampleDateTime.ToString(dateFormat), _suffix, fileType);

					dateFormat_grp.Enabled = true;

				}
				else if (fileNameFormat_combo.SelectedItem.ToString().Equals("Number", StringComparison.InvariantCultureIgnoreCase))
				{
					sampleFormat = string.Format(fileNameFormat, _prefix, "1", _suffix, fileType);
					dateFormat_grp.Enabled = false;
				}
			}

			fileNameSample_txt.Text = sampleFormat;
		}

		private void setChannelPath()
		{
			Control _channels_tbl;
			_channels_tbl = channels_tbl;

			foreach (Control cntrl in _channels_tbl.Controls)
			{
				if (cntrl.GetType().Equals(typeof(TextBox)))
				{
					switch (cntrl.Name)
					{
						case "channel1_txt":

							if (channelSet[1].isSelected = channel1_chk.Checked)
							{ channelSet[1].FileBasePath = cntrl.Text; }
							break;
						case "channel2_txt":
							if (channelSet[2].isSelected = channel2_chk.Checked)
							{ channelSet[2].FileBasePath = cntrl.Text; }
							break;
						case "channel3_txt":
							if (channelSet[3].isSelected = channel3_chk.Checked)
							{ channelSet[3].FileBasePath = cntrl.Text; }
							break;
						case "channel4_txt":
							if (channelSet[4].isSelected = channel4_chk.Checked)
							{ channelSet[4].FileBasePath = cntrl.Text; }
							break;
						case "channel5_txt":
							if (channelSet[5].isSelected = channel5_chk.Checked)
							{ channelSet[5].FileBasePath = cntrl.Text; }
							break;
						case "channel6_txt":
							if (channelSet[6].isSelected = channel6_chk.Checked)
							{ channelSet[6].FileBasePath = cntrl.Text; }
							break;
						case "channel7_txt":
							if (channelSet[7].isSelected = channel7_chk.Checked)
							{ channelSet[7].FileBasePath = cntrl.Text; }
							break;
						case "channel8_txt":
							if (channelSet[8].isSelected = channel8_chk.Checked)
							{ channelSet[8].FileBasePath = cntrl.Text; }
							break;
						default:
							break;

					}
				}
			}
		}

		private void setFileNameSettings()
		{
			if (fileNameFormat_combo.SelectedItem != null && !string.IsNullOrEmpty(fileNameFormat_combo.SelectedItem.ToString()))
			{
				fileFormatType = fileNameFormat_combo.SelectedItem.ToString();
			}
			if (fileType_combo.SelectedItem != null && !string.IsNullOrEmpty(fileType_combo.SelectedItem.ToString()))
			{
				fileNameExtension = fileType_combo.SelectedItem.ToString();
			}

			fileNamePrefix = prefix_txt.Text;
			fileNameSuffix = suffix_txt.Text;
			fileDateFormat = dateFormat_txt.Text;
			feedDate = feedDate_date.Value;
			referenceDateTime = new DateTime(feedDate.Year, feedDate.Month, feedDate.Day);
		}

		private void initFeed()
		{
			if (fileFormatType.Equals("Date", StringComparison.InvariantCultureIgnoreCase))
			{
				scrollerMin = (int)feedDate.TimeOfDay.TotalSeconds;
				if (scrollerMin <= 0)
				{
					scrollerMin = 1;
				}
			}
			else if (fileFormatType.Equals("Number", StringComparison.InvariantCultureIgnoreCase))
			{
				scrollerMin = 1;
			}
		}

		private void loadChannel_cleanup()
		{
			loadChannel_btn.Enabled = false;
			unloadChannel_btn.Enabled = true;
			channel1_txt.Enabled = false;
			channel2_txt.Enabled = false;
			channel3_txt.Enabled = false;
			channel4_txt.Enabled = false;
			channel5_txt.Enabled = false;
			channel6_txt.Enabled = false;
			channel7_txt.Enabled = false;
			channel8_txt.Enabled = false;
			fileName_grp.Enabled = false;
			dateFormat_grp.Enabled = false;
			controls_grp.Enabled = true;
			screenshot_grp.Enabled = true;
		}

		private void unloadChannel_cleanup()
		{
			controls_grp.Enabled = false;
			screenshot_grp.Enabled = false;
			loadChannel_btn.Enabled = true;
			unloadChannel_btn.Enabled = false;
			channel1_txt.Enabled = true;
			channel2_txt.Enabled = true;
			channel3_txt.Enabled = true;
			channel4_txt.Enabled = true;
			channel5_txt.Enabled = true;
			channel6_txt.Enabled = true;
			channel7_txt.Enabled = true;
			channel8_txt.Enabled = true;
			fileName_grp.Enabled = true;
			dateFormat_grp.Enabled = true;
		}

		private void loadChannels()
		{
			loadChannel_cleanup();
			setChannelPath();
			setFileNameSettings();
			initFeed();
			initScroller();
		}

		private void unloadChannels()
		{
			pauseScroller();
			initScroller();
			initChannels();
			unloadChannel_cleanup();
		}

		private void playScroller()
		{
			playTimer.Enabled = true;
			scrollPause.Enabled = true;
			scrollPlay.Enabled = false;
			saveScreenshot_btn.Enabled = false;
		}

		private void pauseScroller()
		{
			playTimer.Enabled = false;
			scrollPlay.Enabled = true;
			scrollPause.Enabled = false;
			saveScreenshot_btn.Enabled = true;
		}

		private void beforeSave()
		{
			scrollPlay.Enabled = false;
			unloadChannel_btn.Enabled = false;
			saveScreenshot_btn.Enabled = false;
		}

		private void afterSave()
		{
			scrollPlay.Enabled = true;
			unloadChannel_btn.Enabled = true;
			saveScreenshot_btn.Enabled = true;
		}

		private void saveScreenshot()
		{
			try
			{
				if (screenshotPath_txt.Text != null && !string.IsNullOrEmpty(screenshotPath_txt.Text))
				{
					FileOperation fileOps = new FileOperation();

					if (fileOps.saveFile(channelSet, getCurrentImageFileName(scrollIndex), screenshotPath_txt.Text))
					{
						MessageBox.Show("Screenshot saved");
					}
					else
					{
						MessageBox.Show("There was an error while attempting to save. Saving operation aborted.");
					}
				}
				else
				{
					MessageBox.Show("Please entera a valid path");
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("There was an error while attempting to save. Saving operation aborted.");
			}
		}

		private void imageScroller_ValueChanged(object sender, EventArgs e)
		{
			scrollIndex = imageScroller.Value;
			loadNextImage();
		}

		private void playTimer_Tick(object sender, EventArgs e)
		{
			if (scrollIndex >= scrollerMax)
			{
				scrollIndex = scrollerMax;
				pauseScroller();
			}
			else
			{
				scrollIndex++;
			}

			imageScroller.Value = scrollIndex;
		}

		private void scrollPlay_Click(object sender, EventArgs e)
		{

			playScroller();
		}

		private void scrollPause_Click(object sender, EventArgs e)
		{
			pauseScroller();
		}

		private void fileNameFormat_combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			getFileFormatSample();
		}

		private void fileType_combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			getFileFormatSample();
		}

		private void dateFormat_txt_KeyUp(object sender, KeyEventArgs e)
		{
			getFileFormatSample();
		}

		private void feedDate_date_ValueChanged(object sender, EventArgs e)
		{
			getFileFormatSample();
		}

		private void loadChannel_btn_Click(object sender, EventArgs e)
		{
			loadChannels();
		}

		private void unloadChannel_btn_Click(object sender, EventArgs e)
		{
			unloadChannels();
		}

		private void prefix_txt_KeyUp(object sender, KeyEventArgs e)
		{
			getFileFormatSample();
		}

		private void suffix_txt_KeyUp(object sender, KeyEventArgs e)
		{
			getFileFormatSample();
		}

		private void saveScreenshot_btn_Click(object sender, EventArgs e)
		{
			beforeSave();
			saveScreenshot();
			afterSave();
		}

        private void dateFormat_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
