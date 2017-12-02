using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.WideCard;
using MediaStore.Infrastructure.Items;
using MediaStore.Infrastructure.Items.Games;

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
						Feeds = new LayoutFeedModelBase[]
						{
							new WideCardsFeedModel
							{
								Items = new WideCardModelBase[]
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
									new WideCardGameModel
									{
										GameTitle = "Need for Speed: Payback",
										Genre = "2017, Racing",
										BackgroundUrl = "https://i.ytimg.com/vi/Y_MB6fVg7H4/maxresdefault.jpg",
										Content = "Some text for demonstrating this item. So I am Vovanella and I am an Assassin",
										Id = "12",
										GamePosterUrl ="https://media.contentapi.ea.com/content/dam/need-for-speed/images/2017/06/nfsde-pc-generic.jpg"
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
							},
							new GamesFeedModel
							{
								Items = new GamesModelBase[]
								{
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Origins",
										PosterUrl = "https://nextgame.net/upload/iblock/093/Assassins-Creed-Origins-Rus-Game-For-PC_detail.jpg"
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Origins",
										PosterUrl = "https://cdn.europosters.eu/image/1300/28402.jpg"
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Origins",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/31NomOK5eiL.jpg"
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
