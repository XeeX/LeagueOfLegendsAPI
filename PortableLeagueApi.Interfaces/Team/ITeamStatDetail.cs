using PortableLeagueApi.Interfaces.Core;

namespace PortableLeagueApi.Interfaces.Team
{
    public interface ITeamStatDetail : ILeagueModel
    {
        int AverageGamesPlayed { get; set; }
        string FullId { get; set; }
        int Losses { get; set; }
        string TeamStatType { get; set; }
        int Wins { get; set; }
    }
}