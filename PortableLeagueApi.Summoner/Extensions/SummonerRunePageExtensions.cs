﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Enums;
using PortableLeagueApi.Interfaces.Extensions;
using PortableLeagueApi.Interfaces.Summoner;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Summoner.Services;

namespace PortableLeagueApi.Summoner.Extensions
{
    public static class SummonerRunePageExtensions
    {
        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<IEnumerable<IRunePage>> GetRunePages(
            IApiModel leagueModel,
            long summonerId,
            RegionEnum? region = null)
        {
            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetRunePagesBySummonerIdAsync(summonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this IHasSummonerId summoner,
            RegionEnum? region = null)
        {
            return await GetRunePages(summoner, summoner.SummonerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<IEnumerable<IRunePage>> GetRunePages(
            this IRoster roster,
            RegionEnum? region = null)
        {
            return await GetRunePages(roster, roster.OwnerId, region);
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        private static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            IApiModel leagueModel,
            IEnumerable<long> summonerIds,
            RegionEnum? region = null)
        {
            var summonerService = new SummonerService(leagueModel.ApiConfiguration);
            return await summonerService.GetRunePagesBySummonerIdAsync(summonerIds, region);
        }
        
        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<IHasSummonerId> summoners,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = summoners as IList<IHasSummonerId> ?? summoners.ToList();
            if(enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.SummonerId), region);

            return result;
        }

        /// <summary>
        /// Get mastery pages
        /// </summary>
        public static async Task<Dictionary<long, IEnumerable<IRunePage>>> GetRunePages(
            this IEnumerable<IRoster> rosters,
            RegionEnum? region = null)
        {
            var result = new Dictionary<long, IEnumerable<IRunePage>>();

            var enumerable = rosters as IList<IRoster> ?? rosters.ToList();
            if (enumerable.Any())
                result = await GetRunePages(enumerable.First(), enumerable.Select(x => x.OwnerId), region);

            return result;
        }
    }
}
