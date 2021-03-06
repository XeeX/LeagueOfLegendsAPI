﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.League;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.League.Services;

namespace PortableLeagueApi.League.Extensions
{
    public static class RetrieveLeaguesEntryDataExtensions
    {
        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        private static async Task<IEnumerable<ILeague>> RetrieveLeaguesEntryDataAsync(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            if (leagueModel == null) throw new ArgumentNullException("leagueModel");

            var leagueService = new LeagueService(leagueModel.ApiConfiguration);
            return await leagueService.RetrievesLeaguesEntryDataForSummonerAsync(summonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrieveLeaguesEntryDataAsync(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryDataAsync(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Retrieves leagues entry data for summoner, including league entries for all of summoner's teams
        /// </summary>
        public static async Task<IEnumerable<ILeague>> RetrieveLeaguesEntryDataAsync(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await RetrieveLeaguesEntryDataAsync(roster, roster.OwnerId, region);
        }
    }
}
