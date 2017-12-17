using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using System;
using MediaStore.Infrastructure.Items.Media;
using MediaStore.Infrastructure.Items.TopSpot;

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
							Rating = 4,
							ReleaseDate = new DateTime(2015, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
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
							Rating = 4,
							ReleaseDate = new DateTime(2009, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
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
							Rating = 5,
							SeasonNumber = 2,
							ReleaseDate = new DateTime(2015, 9, 12),
							Description = @"Fantastic Beasts and Where to Find Them is a 2001 book written by British author J. K. Rowling (under the pen name of the fictitious author Newt Scamander) about the magical creatures in the Harry Potter universe. The original version purports to be Harry Potter's copy of the textbook of the same name mentioned in Harry Potter and the Philosopher's Stone (or Harry Potter and the Sorcerer's Stone in the US), the firstnovel of the Harry Potter series. It includes several notes inside it supposedly handwritten by Harry, Ron Weasley, and Hermione Granger, detailing their own experiences with some of the beasts described, and including in-jokes relating to the original series.",
							RelatedFeeds = new[]
							{
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

			if(type == FeedType.TOP_SPOT_FEED)
			{
				result = new TopSpotFeedModel
				{
					Items = new[]
					{
						new TopSpotGameModel
						{
							Title = "Fantastic beasts and where to find them",
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
							ImageUrl = "https://orig00.deviantart.net/7d36/f/2016/252/d/c/fb_poster_by_danielwarner123-dah17kf.jpg",
							LogoUrl = "https://vignette.wikia.nocookie.net/warner-bros-entertainment/images/a/a1/Fantastic_Beasts_and_where_to_find_them_logo.png/revision/latest?cb=20161114040921"
						}
					}
				} as T;
			}

			return result;
		}
	}
}
