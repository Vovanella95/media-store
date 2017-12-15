using System.Threading.Tasks;
using MediaStore.Infrastructure.Interfaces;
using MediaStore.Infrastructure.Layout;
using MediaStore.Infrastructure.Categories;
using MediaStore.Infrastructure.Feeds;
using System;
using MediaStore.Infrastructure.Items.Media;

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

		public async Task<T> FetchFeedAsync<T>(string id, FeedType type) where T : LayoutFeedModelBase
		{
			await Task.Delay(new Random().Next(500));

			T result = null;

			if (type == FeedType.GAMES_FEED)
			{
				result = new GamesFeedModel
				{
					Title = "SOME TITLE",
					Items = new[]
					{
						new DefaultGamesModel
						{
							Title = "Game 1",
							PosterUrl = "https://pp.userapi.com/c840225/v840225291/58d4e/J88i8Sd3t08.jpg",
							Genres = new[]
							{
								"Action",
								"Rpg"
							}
						},
						new DefaultGamesModel
						{
							Title = "Game 2",
							PosterUrl = "https://pp.userapi.com/c840225/v840225291/58d4e/J88i8Sd3t08.jpg",
							Genres = new[]
							{
								"Action",
								"Rpg"
							}
						}
					}
				} as T;
			}

			return result;
		}
	}
}
