using System;
using System.Collections.Generic;
using System.IO;

namespace ImageScroller
{
	public class FileOperation
	{
		public bool saveFile(Dictionary<int, ChannelInfo> channelSet, String currentImageFilename, String destinationBasePath)
		{
			bool saveSuccess = false;

			try
			{
				if (destinationBasePath != null && !string.IsNullOrEmpty(destinationBasePath) && currentImageFilename != null && !string.IsNullOrEmpty(currentImageFilename))
				{
					foreach (KeyValuePair<int, ChannelInfo> channelSetItem in channelSet)
					{
						ChannelInfo _channelInfo = channelSetItem.Value;
						if (_channelInfo.isSelected && _channelInfo.FileBasePath != null && !string.IsNullOrEmpty(_channelInfo.FileBasePath))
						{
							System.Windows.Forms.PictureBox _imageViewer = new System.Windows.Forms.PictureBox();
							String sourcePath = string.Empty;
							String destinationPath = string.Empty;

							int _channelNumber = _channelInfo.ChannelNumber;
							sourcePath = _channelInfo.FileBasePath;

							if (!sourcePath.Substring(sourcePath.Length - 1, 1).Equals("\\"))
							{
								sourcePath = sourcePath + "\\";
							}
							if (!destinationBasePath.Substring(destinationBasePath.Length - 1, 1).Equals("\\"))
							{
								destinationBasePath = destinationBasePath + "\\";
							}

							destinationPath = destinationBasePath + "Channel " + _channelNumber.ToString() + "\\";

							if (!Directory.Exists(destinationPath))
							{
								Directory.CreateDirectory(destinationPath);
							}

							if (File.Exists(sourcePath + currentImageFilename))
							{
								File.Copy(sourcePath + currentImageFilename, destinationPath + currentImageFilename, true);
								saveSuccess = true;
							}
							else
							{
								saveSuccess = false;
								break;
							}

						}
					}
				}
			}
			catch (Exception e)
			{
				saveSuccess = false;
			}

			return saveSuccess;
		}
	}
}
