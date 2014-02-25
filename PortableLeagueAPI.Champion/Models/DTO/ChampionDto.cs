﻿using Newtonsoft.Json;

namespace PortableLeagueAPI.Champion.Models.DTO
{
    internal class ChampionListDto
    {
        [JsonProperty("champions")]
        public ChampionDto[] Champions { get; set; }
    }

    internal class ChampionDto
    {
        [JsonProperty("botMmEnabled")]
        public bool BotMmEnabled { get; set; }

        [JsonProperty("defenseRank")]
        public int DefenseRank { get; set; }

        [JsonProperty("attackRank")]
        public int AttackRank { get; set; }

        [JsonProperty("id")]
        public int ChampionId { get; set; }

        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }

        [JsonProperty("difficultyRank")]
        public int DifficultyRank { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }

        [JsonProperty("magicRank")]
        public int MagicRank { get; set; }
    }
}
