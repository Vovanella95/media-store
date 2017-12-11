using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using MediaStore.Infrastructure.Items.WideCard;
using MediaStore.Infrastructure.Items;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Infrastructure.Items.TopSpot;
using System;
using MediaStore.Infrastructure.Items.Video;

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
							new VideoCollectionFeedModel
							{
								Title="POPULAR VIDEOS",
								Items=new VideoModelBase[]
								{
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://i.ytimg.com/vi/IThRS-3cfmI/maxresdefault.jpg"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://pmcvariety.files.wordpress.com/2017/09/pewdiepie-n-word-response.png?w=1000&h=563&crop=1"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://media.contentapi.ea.com/content/dam/need-for-speed/common/nfs-underglow-platblue-1080-1.jpg.adapt.crop16x9.431p.jpg"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://i.ytimg.com/vi/IThRS-3cfmI/maxresdefault.jpg"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://pmcvariety.files.wordpress.com/2017/09/pewdiepie-n-word-response.png?w=1000&h=563&crop=1"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://media.contentapi.ea.com/content/dam/need-for-speed/common/nfs-underglow-platblue-1080-1.jpg.adapt.crop16x9.431p.jpg"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://i.ytimg.com/vi/IThRS-3cfmI/maxresdefault.jpg"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://pmcvariety.files.wordpress.com/2017/09/pewdiepie-n-word-response.png?w=1000&h=563&crop=1"
									},
									new DefaultVideoModel
									{
										Title = "Shcool 13: Igroorgii - Outlast. #EPISODE 12",
										Source = "Youtube",
										Duration = TimeSpan.FromSeconds(216),
										PublishDate = DateTime.Now.AddSeconds(-18200),
										Views = 312,
										ImageUrl = "https://media.contentapi.ea.com/content/dam/need-for-speed/common/nfs-underglow-platblue-1080-1.jpg.adapt.crop16x9.431p.jpg"
									}
								}
							},
							new GamesFeedModel
							{
								Title = "NEW RELEASED GAMES",
								Items = new MediaModelBase[]
								{
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Origins",
										PosterUrl = "https://nextgame.net/upload/iblock/093/Assassins-Creed-Origins-Rus-Game-For-PC_detail.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 5,
										Genres = new[]
										{
											"Action",
											"RPG"
										}

									},
									new DefaultGamesModel
									{
										Title = "Uncharted 4: Thief's end",
										PosterUrl = "https://cdn.europosters.eu/image/1300/28402.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 4,
										Genres = new[]
										{
											"Action",
											"Adventure",
										}
									},
									new DefaultGamesModel
									{
										Title = "The Last of Us: Remastered",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/31NomOK5eiL.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"Drama",
											"Adventure"
										}
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Ezio Collection",
										PosterUrl = "https://ubistatic19-a.akamaihd.net/ubicomstatic/en-us/global/game-info/ac-eziocollection-game_info-boxart-560x698_264181.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}
									},
									new DefaultGamesModel
									{
										Title = "Horizon: Zero Dan",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/91xzHeLIqtL.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}
									},
									new DefaultGamesModel
									{
										Title = "Middle Earth: Shadow of War",
										PosterUrl = "https://www.igroshop.com/images/detailed/4/Shadow_of_War_box_art.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}
									},
									new DefaultGamesModel
									{
										Title = "Need for Speed: Payback",
										PosterUrl = "https://media.contentapi.ea.com/content/dam/needforspeed-18/ru-ru/packshots/nfsppc2dpftru.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}
									}
								}
							},
							new CollectionFeedModel
							{
								Title = "Breaking Bad Collection",
								SecondTitle = "2001 - 2009",
								BackgroundImageUrl = "https://images-na.ssl-images-amazon.com/images/I/811a2vMsGzL._AC_UL320_SR224,320_.jpg",
								Items = new MediaModelBase[]
								{
									new DefaultSeriesModel
									{
										Title = "Breaking Bad: Season 1",
										PosterUrl = "https://i.pinimg.com/736x/0d/11/2e/0d112e94f0d614e9740ec59f29153639--tv-show-breaking-bad-poster.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 5,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}

									},
									new DefaultSeriesModel
									{
										Title = "Breaking bad: Season 2",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/I/A1IQvWDOHwL._AC_UL320_SR222,320_.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 4,
										Genres = new[]
										{
											"Action",
											"RPG",
											"VR"
										}
									},
									new DefaultSeriesModel
									{
										Title = "Breaking bad: Season 3",
										PosterUrl = "https://i.pinimg.com/736x/72/83/92/728392b482329cfef27833fe110321b8--netflix-series-on-netflix.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									},
									new DefaultSeriesModel
									{
										Title = "Breaking bas: Season 4",
										PosterUrl = "https://vignette.wikia.nocookie.net/breakingbad/images/3/37/Season_3_Poster.jpg/revision/latest?cb=20100330051000",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									},
									new DefaultSeriesModel
									{
										Title = "Breaking bad: Season 5",
										PosterUrl = "http://cdn.collider.com/wp-content/uploads/breaking-bad-season-5-part-2-poster.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									},
									new DefaultSeriesModel
									{
										Title = "Breaking bad: Season 6",
										PosterUrl = "https://static1.squarespace.com/static/577a9a5d2994caf1d490b6d7/577ac05bcd0f68c0f24cad41/577ac060414fb50acf4a1a47/1467662436222/BB_poster.jpg?format=1000w",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									}
								}
							},
							new GamesFeedModel
							{
								Title = "NEW RELEASED SERIES",
								Items = new MediaModelBase[]
								{
									new DefaultSeriesModel
									{
										Title = "Breaking Bad",
										PosterUrl = "https://i.pinimg.com/736x/0d/11/2e/0d112e94f0d614e9740ec59f29153639--tv-show-breaking-bad-poster.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 5,

									},
									new DefaultSeriesModel
									{
										Title = "Valerian and the city of thousand planets",
										PosterUrl = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTkxMDAxNDUyNV5BMl5BanBnXkFtZTgwOTc3MzcxMjI@._V1_UX182_CR0,0,182,268_AL_.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 4,
									},
									new DefaultSeriesModel
									{
										Title = "Baby Driver",
										PosterUrl = "http://cdn.shopify.com/s/files/1/0558/2081/files/PCC_BabyDriver_REG_Stroke_1024x1024.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									},
									new DefaultSeriesModel
									{
										Title = "Coco",
										PosterUrl = "https://vignette.wikia.nocookie.net/disney/images/6/62/Coco_Vive_Tu_Momento_Poster.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									},
									new DefaultSeriesModel
									{
										Title = "Moana",
										PosterUrl = "https://i.pinimg.com/736x/8d/75/49/8d7549e4020a90fb22efd9a5f4995b4c--moana---movies.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
									}
								}
							},
							new CollectionFeedModel
							{
								Title = "ASASSIN'S LEGENDARY COLLECTION",
								SecondTitle = "SELL OUT OF STORE",
								BackgroundImageUrl = "https://geekster.ru/wp-content/uploads/2015/05/Assassin-s-Creed-Syndicate-art-s-sajta-Geekster.ru_-759x486.jpg",
								Items = new DefaultGamesModel[]
								{
									new DefaultGamesModel
									{
										Title = "Assassin's creed II",
										PosterUrl = "https://upload.wikimedia.org/wikipedia/en/7/77/Assassins_Creed_2_Box_Art.JPG",
										ReleaseDate = DateTime.Now,
										Rating = 5,
										Genres = new[]
										{
											"Action",
											"Adventure"
										}

									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed IV: Black Flag",
										PosterUrl = "http://images.vg247.com/current//2013/02/assassins-creed-iv-black-flag-SML.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 4,
										Genres = new[]
										{
											"Action",
											"Adventure"
										}
									},
									new DefaultGamesModel
									{
										Title = "Assassin's Creed",
										PosterUrl = "http://static2.cdn.ubi.com/ubicom/ACFranchise/boxart/UBICOM_ac1_ac-1-gameinfo-boxart.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"Adventure"
										}
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Liberation HD",
										PosterUrl = "https://vignette.wikia.nocookie.net/assassinscreed/images/6/6d/Assassins-creed-liberation-box-art.png/revision/latest?cb=20120605083716",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"Adventure"
										}
									},
									new DefaultGamesModel
									{
										Title = "Assassin's creed: Brotherhood",
										PosterUrl = "http://www.newgamenetwork.com/images/uploads/games/1281030483_assassinscreedbrotherhoodcover.jpg",
										ReleaseDate = DateTime.Now,
										Rating = 3,
										Genres = new[]
										{
											"Action",
											"Adventure"
										}
									}
								}
							},
						}
					}
				}
			};
		}
	}
}
