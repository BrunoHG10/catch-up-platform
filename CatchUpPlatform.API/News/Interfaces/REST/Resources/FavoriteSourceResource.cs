namespace CatchUpPlatform.API.News.Interfaces.REST.Resources;

using Swashbuckle.AspNetCore.Annotations;

/// <summary>
///     Represents the data provided by the server about a favorite source.
/// </summary>
/// <param name="Id">The server-generated ID of the favorite source</param>
/// <param name="NewsApiKey">The News API Key provided by NewsAPI</param>
/// <param name="SourceId">The source identifier from NewsAPI</param>
[SwaggerSchema(Description = "A favorite source resource")]
public record FavoriteSourceResource(
	[SwaggerParameter(Description = "The server-generated ID of the favorite source")] int Id,
	[SwaggerParameter(Description = "The News API Key provided by NewsAPI")] string NewsApiKey,
	[SwaggerParameter(Description = "The source identifier from NewsAPI")] string SourceId);
