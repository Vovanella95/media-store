using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.WideCard;
using MediaStore.Infrastructure.Items;
using MediaStore.Infrastructure.Items.Games;
using MediaStore.Infrastructure.Items.TopSpot;
using System;

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
							new TopSpotFeedModel
							{
								Items = new TopSpotModelBase[]
								{
									new TopSpotGameModel
									{
										Title = "Assassin's creed: Origins",
										ImageUrl = "https://vignette.wikia.nocookie.net/assassinscreed/images/8/80/ACO_The_Curse_of_the_Pharaohs.jpg",
										Raiting = 4,
										Descriptopn = "Welcome to ancient Egypt - center of world architecture! You will able to play Bayek and hes wifr Aya. This year is gone! Join the birth of Assassin's Brotherhood and fitgt fith tmem in new exciting game",
										Genres = new[]
										{
											"Action",
											"RPG",
											"Adventure",
											"Stealth"
										},
										PosterUrl = "http://metarankings.ru/wp-content/uploads/Assassins-Creed-Origins-boxart-cover.jpg",
										Platforms = new GamePlatform[]
										{
											GamePlatform.PC,
											GamePlatform.PS_4,
											GamePlatform.XBOX_ONE
										}
									}
								}
							},
							new WideCardsFeedModel
							{
								Title = "LATEST NEWS",
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
									}
								}
							},
							new GamesFeedModel
							{
								Title = "NEW RELEASED GAMES",
								Items = new GamesModelBase[]
								{
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Origins",
										PosterUrl = "https://nextgame.net/upload/iblock/093/Assassins-Creed-Origins-Rus-Game-For-PC_detail.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 5,

									},
									new DefaultGamesModel
									{
										Title = "Uncharted 4: Thief's end",
										PosterUrl = "https://cdn.europosters.eu/image/1300/28402.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 4,
									},
									new DefaultGamesModel
									{
										Title = "The Last of Us: Remastered",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/31NomOK5eiL.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Ezio Collection",
										PosterUrl = "https://ubistatic19-a.akamaihd.net/ubicomstatic/en-us/global/game-info/ac-eziocollection-game_info-boxart-560x698_264181.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Horizon: Zero Dan",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/91xzHeLIqtL.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Middle Earth: Shadow of War",
										PosterUrl = "https://www.igroshop.com/images/detailed/4/Shadow_of_War_box_art.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Need for Speed: Payback",
										PosterUrl = "https://media.contentapi.ea.com/content/dam/needforspeed-18/ru-ru/packshots/nfsppc2dpftru.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									}
								}
							},
							new GamesFeedModel
							{
								Title = "NEW RELEASED SERIES",
								Items = new GamesModelBase[]
								{
									new DefaultGamesModel
									{
										Title = "Breaking Bad",
										PosterUrl = "https://i.pinimg.com/736x/0d/11/2e/0d112e94f0d614e9740ec59f29153639--tv-show-breaking-bad-poster.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 5,

									},
									new DefaultGamesModel
									{
										Title = "Valerian and the city of thousand planets",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkxMDAxNDUyNV5BMl5BanBnXkFtZTgwOTc3MzcxMjI@._V1_UX182_CR0,0,182,268_AL_.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 4,
									},
									new DefaultGamesModel
									{
										Title = "Baby Driver",
										PosterUrl = "http://cdn.shopify.com/s/files/1/0558/2081/files/PCC_BabyDriver_REG_Stroke_1024x1024.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Coco",
										PosterUrl = "https://vignette.wikia.nocookie.net/disney/images/6/62/Coco_Vive_Tu_Momento_Poster.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
									},
									new DefaultGamesModel
									{
										Title = "Moana",
										PosterUrl = "https://i.pinimg.com/736x/8d/75/49/8d7549e4020a90fb22efd9a5f4995b4c--moana---movies.jpg",
										ReleaseDate = DateTime.Now,
										Raiting = 3,
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
