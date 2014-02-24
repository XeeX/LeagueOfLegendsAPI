﻿using System;
using System.Collections.Generic;
using PortableLeagueApi.Core.Models;
using PortableLeagueApi.Core.Services;
using PortableLeagueApi.Interfaces.Core;
using PortableLeagueApi.Interfaces.Team;
using PortableLeagueApi.Team.Models.DTO;

namespace PortableLeagueApi.Team.Models
{
    public class Team : LeagueApiModel, ITeam
    {
        public DateTime CreateDate { get; set; }

        public string FullId { get; set; }

        public DateTime LastGameDate { get; set; }

        public DateTime LastJoinDate { get; set; }

        public DateTime LastJoinedRankedTeamQueueDate { get; set; }

        public IList<IMatchHistorySummary> MatchHistory { get; set; }

        public IMessageOfDay MessageOfDay { get; set; }

        public DateTime ModifyDate { get; set; }

        public string Name { get; set; }

        public IRoster Roster { get; set; }

        public DateTime SecondLastJoinDate { get; set; }

        public string Status { get; set; }

        public string Tag { get; set; }

        public ITeamStatSummary TeamStatSummary { get; set; }

        public DateTime ThirdLastJoinDate { get; set; }

        internal static void CreateMap(AutoMapperService autoMapperService, ILeagueAPI source)
        {
            MatchHistorySummary.CreateMap(autoMapperService, source);
            Models.MessageOfDay.CreateMap(autoMapperService, source);
            Models.Roster.CreateMap(autoMapperService, source);
            Models.TeamStatSummary.CreateMap(autoMapperService, source);

            autoMapperService.CreateMap<TeamDto, ITeam>().As<Team>();
            autoMapperService.CreateMap<TeamDto, Team>()
                .BeforeMap((s, d) =>
                           {
                               d.Source = source;
                           });
        }
    }
}