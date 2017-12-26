using Caliburn.Micro;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Items.Video;
using MediaStore.Win10.ViewModels.Messages;

namespace MediaStore.Win10.ViewModels.TitleCards
{
	public class VideoDetailsViewModel : PropertyChangedBase, IMessageHandler<VideoDetailsOpenedMessage>
	{
		private const string _videoWebPageTemplate = @"<!DOCTYPE html>
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" style=""height: 100%"">
<head>
<meta charset = ""utf-8""/>
<title></title>
</head>
<body style=""margin:0px; padding:0px; height:100%; overflow:hidden;"" >
    <iframe id=""player"" type=""text/html"" width=""100%"" height=""100%"" src=""{0}"" frameborder=""0""></iframe>
</body>
</html>";

		private string _webViewText;
		private bool _isAvailable;
		private VideoModelBase _data;

		public VideoDetailsViewModel(IMessageRoot messageRoot)
		{
			messageRoot.Subscribe<VideoDetailsOpenedMessage>(this);
		}

		public string WebViewText
		{
			get => _webViewText;
			set
			{
				_webViewText = value;
				NotifyOfPropertyChange(nameof(WebViewText));
			}
		}

		public bool IsAvailable
		{
			get => _isAvailable;
			set
			{
				_isAvailable = value;
				NotifyOfPropertyChange(nameof(IsAvailable));
			}
		}

		public VideoModelBase Data
		{
			get => _data;
			set
			{
				_data = value;
				NotifyOfPropertyChange(nameof(Data));
			}
		}

		protected void Initialize()
		{
			WebViewText = string.Format(_videoWebPageTemplate, Data.Url);
		}

		public void Close()
		{
			WebViewText = "r";
			IsAvailable = false;
		}

		public void Handle(VideoDetailsOpenedMessage message)
		{
			IsAvailable = true;
			Data = message.Data;
			Initialize();
		}
	}
}
