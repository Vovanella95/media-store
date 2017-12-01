using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.WideCard;

namespace MediaStore.Services
{
	public class LayoutService : ILayoutService
	{
		public async Task<FeedsLayoutModel> FetchLayoutAsync()
		{
			await Task.Delay(0);
			return new FeedsLayoutModel
			{
				Categories = new LayoutCategoryModel[]
				{
					new LayoutCategoryModel
					{
						Feeds = new[]
						{
							new WideCardsFeedModel
							{
								Items = new[]
								{
									new WideCardActorModel
									{
										ActorName = "Uladzimir Paliukhovich",
										ActorEmail = "Vovanella95@mail.ru",
										BackgroundUrl = "https://www.w3schools.com/w3css/img_fjords.jpg",
										Content = "Some text for demonstrating this item. So I am Vovanella and I am an Assassin",
										Id = "12",
										ActorImageUrl ="https://pp.userapi.com/c841133/v841133876/3e651/ZLRvkRVO6Og.jpg"
									},
									new WideCardActorModel
									{
										ActorName = "Jonh Reese",
										ActorEmail = "reese-john@gmail.de",
										BackgroundUrl = "https://s3.envato.com/files/212542380/Dark%20Background%20%20%20%2001_preview1%20.JPG",
										Content = "Some text for demonstrating this item. So I am Vovanella and I am an Assassin",
										Id = "12",
										ActorImageUrl ="https://pp.userapi.com/c639327/v639327843/5b527/hBmZ3-USy4U.jpg"
									},
									new WideCardActorModel
									{
										ActorName = "Diana Mescheryakova",
										ActorEmail = "dianisque@mail.ru",
										BackgroundUrl = "http://freedesignfile.com/upload/2017/01/Light-blue-tech-background-vector-02.jpg",
										Content = "Some text for demonstrating this item. So I am Vovanella and I am an Assassin",
										Id = "12",
										ActorImageUrl ="https://pp.userapi.com/c840239/v840239808/42e3d/RzVo58VgUtE.jpg"
									}
								}
							}
						}
					}
				}
			};
		}
	}
}
