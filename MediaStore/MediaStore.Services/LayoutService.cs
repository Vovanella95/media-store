using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using System;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Infrastructure.Items.TopSpot;
using MediaStore.Infrastructure.Items;
using MediaStore.Infrastructure.Items.WideCard;
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
						Name = "GAME NEWS",
						Feeds = new LayoutFeedEmptyModel[]
						{
							new LayoutFeedEmptyModel
							{
								Id = "12EE",
								Type = FeedType.TOP_SPOT_FEED
							},
							new LayoutFeedEmptyModel
							{
								Id = "12EE",
								Type = FeedType.WIDE_CARDS_FEED
							},
							new LayoutFeedEmptyModel
							{
								Id = "12E",
								Type = FeedType.GAMES_FEED
							},
							new LayoutFeedEmptyModel
							{
								Id="aaa",
								Type = FeedType.GAMES_FEED
							},
							new LayoutFeedEmptyModel
							{
								Id = "sss",
								Type = FeedType.COLLECTION_FEED
							},
							new LayoutFeedEmptyModel
							{
								Id = "sss",
								Type = FeedType.VIDEO_COLLECTION_FEED
							}
						}
					},
					new LayoutCategoryModel
					{
						Name = "MOVIES AND SERIES",
						Feeds = new LayoutFeedEmptyModel[]
						{
							new LayoutFeedEmptyModel
							{
							}
						}
					},
					new LayoutCategoryModel
					{
						Name = "WORLD NEWS"
					},
					new LayoutCategoryModel
					{
						Name = "MEDIA BASE"
					}
				}
			};
		}

		public async Task<T> FetchFeedAsync<T>(string id, FeedType type) where T : LayoutFeedViewModelBase
		{
			await Task.Delay(new Random().Next(500));

			T result = null;

			if (type == FeedType.GAMES_FEED)
			{
				result = new GamesFeedModel
				{
					Title = "SOME TITLE",
					Items = new MediaModelBase[]
					{
						new DefaultMovieModel
						{
							Title = "Fantastic beasts and where to find them",
							BackgroundUrl = "https://static1.squarespace.com/static/51b3dc8ee4b051b96ceb10de/t/5821fe8003596eb3b2b39db7/1478622851736/",
							PosterUrl = "https://orig00.deviantart.net/7d36/f/2016/252/d/c/fb_poster_by_danielwarner123-dah17kf.jpg",
							Genres = new[]
							{
								"Action",
								"Adventure"
							},
							Screenshots = new[]
							{
								"https://www.kinonews.ru/insimgs/2016/trailer/trailer65584.jpg",
								"http://simhost.org/uploads/posts/2016-08/1471379757_nftl_9ndvkotvari.jpg",
								"https://kor.ill.in.ua/m/610x385/1794232.jpg",
								"http://intofilm.ru/wp-content/uploads/2017/04/fantasticheskie-tvari-i-gde-oni-obitayut-2-1.jpg",
								"https://s1.tchkcdn.com/g-8xayW4S8qo_l83QyHoqRqg/1/311668/660x495/c/0/336_0_700_525/d32_12.jpg"
							},
							TrailerImageUrl = "http://thr.ru/public/article/prephoto/thumb_w320_9814.jpg",
							Country = "United States",
							Director = "Unknown",
							Rating = 4,
							ReleaseDate = new DateTime(2015, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
								new LayoutFeedEmptyModel
								{
									Id = "3",
									Type = FeedType.VIDEO_COLLECTION_FEED
								},
								new LayoutFeedEmptyModel
								{
									Id = "1",
									Type = FeedType.GAMES_FEED
								}
							}
						},
						new DefaultGamesModel
						{
							Title = "Assassin's creed II",
							BackgroundUrl = "https://avante.biz/wp-content/uploads/Assassin%27s-Creed-II-Wallpapers/Assassin%27s-Creed-II-Wallpapers-028.jpg",
							PosterUrl = "https://ubistatic19-a.akamaihd.net/ubicomstatic/ru-ru/global/buy-now/assassinscreed2_boxtablet_mobile_154587.jpg",
							Genres = new[]
							{
								"Action",
								"Adventure"
							},
							TrailerImageUrl = "https://gematsu.com/wp-content/uploads/2009/06/ac2-dated-trailered-e3.jpg",
							Country = "United States",
							Director = "Unknown",
							Rating = 4,
							ReleaseDate = new DateTime(2009, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
								new LayoutFeedEmptyModel
								{
									Id = "1",
									Type = FeedType.VIDEO_COLLECTION_FEED
								},
								new LayoutFeedEmptyModel
								{
									Id = "1",
									Type = FeedType.GAMES_FEED
								}
							},
							Platforms = new[]
							{
								GamePlatform.PC,
								GamePlatform.PS_3,
								GamePlatform.XBOX_360
							},
							Screenshots = new[]
							{
								"https://ubistatic19-a.akamaihd.net/ubicomstatic/en-GB/global/media/ac2_s_031_venice_thiefgolure__6_154603.jpg",
								"https://www.hookedgamers.com/images/765/assassins_creed_ii/screenshot_pc_assassins_creed_ii035.jpg",
								"http://images.psxextreme.com/screenshots/ps3_assassinscreedii/ps3_assassinscreedii_8ddd76783508388e352ad6e795b560061.jpg",
								"https://ubistatic19-a.akamaihd.net/ubicomstatic/en-GB/global/media/ac2_s_008__6_154594.jpg",
								"http://www.moddingway.com/screenshots/games/31/s_262_9.jpg",
								"https://gematsu.com/wp-content/uploads/2009/11/assassins-creed-ii-screens_11-10-09.jpg"
							}
						},
						new DefaultSeriesModel
						{
							Title = "Supertatural",
							BackgroundUrl = "http://digitalspyuk.cdnds.net/17/21/980x490/landscape-1495450444-supernatural-cast.jpg",
							PosterUrl = "https://imgc.allpostersimages.com/img/print/posters/supernatural_a-G-8075459-0.jpg",
							Genres = new[]
							{
								"Supernatiral",
								"Series"
							},
							TrailerImageUrl = "http://thr.ru/public/article/prephoto/thumb_w320_9814.jpg",
							Country = "United States",
							Director = "Unknown",
							Rating = 5,
							SeasonNumber = 2,
							ReleaseDate = new DateTime(2015, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
								new LayoutFeedEmptyModel
								{
									Id = "1",
									Type = FeedType.VIDEO_COLLECTION_FEED
								},
								new LayoutFeedEmptyModel
								{
									Id = "1",
									Type = FeedType.GAMES_FEED
								}
							}
						}
					}
				} as T;
			}

			if (type == FeedType.TOP_SPOT_FEED)
			{
				result = new TopSpotFeedModel
				{
					Items = new[]
					{
						new TopSpotGameModel
						{
							Title = "Skull and Bones",
							PosterUrl = "https://orig00.deviantart.net/7d36/f/2016/252/d/c/fb_poster_by_danielwarner123-dah17kf.jpg",
							Genres = new[]
							{
								"Action",
								"Adventure"
							},
							ActionText = "WATCH NOW",
							Descriptopn = "Some Desctiption Lalalal",
							Raiting = 1,
							Id = "e",
							ImageUrl = "https://pp.userapi.com/c834303/v834303554/5dc01/NpQt7S0tnxg.jpg",
							LogoUrl = "http://www.samesamechina.com/wp-content/uploads/2014/10/ubisoft.png"
						}
					}
				} as T;
			}

			if (type == FeedType.WIDE_CARDS_FEED)
			{
				result = new WideCardsFeedModel
				{
					Title = "LATEST RECENTIONS",
					Items = new WideCardModelBase[]
					{
						new WideCardGameModel
						{
							Title = "New offers this september on PSN Store",
							BackgroundUrl = "https://lh3.googleusercontent.com/EmA5v2n8V8shAY0Q9iyR5i-vzd3ekWBj-9cVKWxUDFtHyU4V2CV8qgF4rRHzqLFAQSB2=h556",
							Content = "This month PS store gives you change to win a games without any payments. For this you need to go to PSN store, add some info about your favourites and got it. This month PS store gives you change to win a games without any payments. For this you need to go to PSN store, add some info about your favourites and got it",
							GamePosterUrl = "https://www.igroshop.com/images/detailed/2/psn15pountds.jpg",
							GameTitle = "PSN",
							Genres = new string[]
							{
								"Action",
								"RPG"
							},
							Id = "e"
						},
						new WideCardGameModel
						{
							Title = "Assassin's creed: Origins - January update",
							BackgroundUrl = "https://store.ubi.com/on/demandware.static/-/Sites-masterCatalog/ru_RU/dwd9b935fd/images/large/5924576188a7e3bc5a8b4568-2.jpg",
							Content = "This month PS store gives you change to win a games without any payments. For this you need to go to PSN store, add some info about your favourites and got it. This month PS store gives you change to win a games without any payments. For this you need to go to PSN store, add some info about your favourites and got it",
							GamePosterUrl = "https://images-na.ssl-images-amazon.com/images/I/51BxvhCk6ZL.jpg",
							GameTitle = "PSN",
							Genres = new string[]
							{
								"Action",
								"RPG"
							},
							Id = "e"
						}
					}
				} as T;
			}

			if (type == FeedType.VIDEO_COLLECTION_FEED)
			{
				if (id == "1")
				{
					result = new VideoCollectionFeedModel
					{
						Title = "RELATED VIDEOS",
						Items = new[]
						{
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Assassin's creed II Main Trailer #2",
							Duration = TimeSpan.FromSeconds(243),
							PublishDate = new DateTime(2016, 12, 10),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "http://www.gamersyde.com/news_e3_assassin_s_creed_2_cgi_trailer-7937.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Ivan Lololian",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c637318/v637318484/61f2d/CzSztLtmGpY.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841028/v841028929/52a00/l07HpCx43vo.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Unamed Name",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c637120/v637120984/61eab/FHCSvWFOTok.jpg"
								}
							}
						},
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Assassin's creed II Fan video Leonardo Da Vinchi contest",
							Duration = TimeSpan.FromSeconds(181),
							PublishDate = new DateTime(2017, 09, 01),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "http://www.gamershell.com/static/streaming/24960/24960_medium.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								}
							}
						},
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Assassin's creed II about world and simulation of temlairs",
							Duration = TimeSpan.FromSeconds(216),
							PublishDate = new DateTime(2014, 09, 2),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "http://www.gamer.ru/system/attached_images/images/000/018/989/original/3.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								}
							}
						}
					}
					} as T;
				}
				else
				{
					result = new VideoCollectionFeedModel
					{
						Title = "RELATED VIDEOS",
						Items = new[]
						{
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Fantastic beasts and where to find them #Trailer1",
							Duration = TimeSpan.FromSeconds(243),
							PublishDate = new DateTime(2016, 12, 10),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "https://i.ytimg.com/vi/ViuDsy7yb8M/maxresdefault.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Ivan Lololian",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c637318/v637318484/61f2d/CzSztLtmGpY.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841028/v841028929/52a00/l07HpCx43vo.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Unamed Name",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c637120/v637120984/61eab/FHCSvWFOTok.jpg"
								}
							}
						},
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Fantastic beasts and where to find them #Trailer1",
							Duration = TimeSpan.FromSeconds(181),
							PublishDate = new DateTime(2017, 09, 01),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "http://img.wennermedia.com/social/fantastic-beasts-trailer-6b785bc8-f905-4a44-af83-6e3b9129cf92.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								}
							}
						},
						new DefaultVideoModel
						{
							Url = "https://www.youtube.com/embed/ViuDsy7yb8M",
							Title = "Fantastic beasts and where to find them, Videos from casting",
							Duration = TimeSpan.FromSeconds(216),
							PublishDate = new DateTime(2014, 09, 2),
							Source = "YouTube",
							Views = 108,
							ImageUrl = "https://i.ytimg.com/vi/Wj1devH5JP4/maxresdefault.jpg",
							Commentaries = new[]
							{
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Uladzimir Paliujkh",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c841023/v841023014/4e333/Z8cIF08j5_M.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Aliaksandr Maroz",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c639426/v639426729/5eb68/MulGAgHWJxg.jpg"
								},
								new VideoCommentDetails
								{
									Author = "Olga Kuzmina",
									Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing ",
									AvatarUrl = "https://pp.userapi.com/c830209/v830209377/21051/h_pllFghcLI.jpg"
								}
							}
						}
					}
					} as T;
				}
			}

			return result;
		}
	}
}
