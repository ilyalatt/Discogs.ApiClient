# Discogs.ApiClient

[![NuGet version](https://badge.fury.io/nu/Discogs.ApiClient.svg)](https://www.nuget.org/packages/Discogs.ApiClient)

## Quick start

Create a client:
```C#
var credentials = DiscogsApiClientCredentials.FromToken("<TOKEN>");
var environment = DiscogsApiClientEnvironment.CreateDefault(credentials);
var client = DiscogsApiClient.Create(environment);
```

Use it:
```C#
var db = client.Database;
var searchResults = await db.Search("Bang Bang");
var releases = searchResults.Releases;
var artists = searchResults.Artists;
```

For complete example check out [Playground](https://github.com/ilyalatt/Discogs.ApiClient/blob/master/src/Playground/Program.cs).
