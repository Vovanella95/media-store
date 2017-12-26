using Caliburn.Micro;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Win10.ViewModels.Messages;

namespace MediaStore.Win10.ViewModels.TitleCards
{
	public class ImageDetailsViewModel : PropertyChangedBase, IMessageHandler<ImageDetailsOpenedMessage>
	{
		private string _imageUrl;
		private bool _isAvailable;

		public string ImageUrl
		{
			get => _imageUrl;
			set
			{
				_imageUrl = value;
				NotifyOfPropertyChange(nameof(ImageUrl));
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

		public ImageDetailsViewModel(IMessageRoot messageRoot)
		{
			messageRoot.Subscribe<ImageDetailsOpenedMessage>(this);
		}

		public void Handle(ImageDetailsOpenedMessage message)
		{
			ImageUrl = message.ImageUrl;
			IsAvailable = true;
		}

		public void Close()
		{
			IsAvailable = false;
		}
	}
}
