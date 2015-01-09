# I'm not maintining this project anymore. Feel free to fork it or use [RiotSharp](https://github.com/BenFradet/RiotSharp).



Portable C# Library for [League of Legends API](https://developer.riotgames.com)

## Install

- Register [here](https://developer.riotgames.com/)

- Install the library from NuGet. You can find it [here](https://www.nuget.org/packages/Remake.PortableLeagueAPI/).

```
PM> Install-Package Remake.PortableLeagueAPI
```

## Example
```c#

var leagueAPI = new LeagueApi("YOUR API KEY HERE", RegionEnum.Euw, true);

var summoner = await leagueAPI.Summoner.GetSummonerByNameAsync("TuC Ølen");
var recentGames = await summoner.GetRecentGamesAsync();

var item = await leagueAPI.Static.GetItemsAsync(
  1001, 
  ItemDataEnum.All, 
  languageCode: LanguageEnum.French);
  
var imageUrl = await item.Image.GetUrlAsync();

```

**Note** : By default the library doesn't check for the rate limit. But if you want to wait when you reach it, set the third parameter in the LeagueAPI constructor to true.

## Notes

- If your visual studio puts in red some methods from the API. Please, unload and reload your project from the solution.
- If something doesn't work or isn't up to date. Please, check if there is any available updates on NuGet. If it still doesn't work, [create an issue](https://github.com/XeeX/LeagueOfLegendsAPI/issues/new).


## Status

#### Dev
[![PortableLeagueAPI Build Status](https://www.myget.org/BuildSource/Badge/remake?identifier=dc59073d-2442-452f-829b-d8746868ea58)](https://www.myget.org/feed/Packages/remake)

#### NuGet
[![NuGet version](https://badge.fury.io/nu/Remake.PortableLeagueApi.png)](http://badge.fury.io/nu/Remake.PortableLeagueApi)

## Last changes

[Check it here](https://github.com/XeeX/LeagueOfLegendsAPI/releases)

## Disclaimer

This product is not endorsed, certified or otherwise approved in any way by Riot Games, Inc. or any of its affiliates.


## Contact

Do not hesitate to reach me on twitter **[@kRapaille](http://www.twitter.com/kRapaille)** or by **[mail](mailto:myself@kevinrapaille.com)**
