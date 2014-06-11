﻿using System.Collections.Generic;
using PortableLeagueApi.Interfaces.Enums;

namespace PortableLeagueApi.Core.Constants
{
    internal class RegionConsts
    {
        public const string Br = "br";
        public const string Eune = "eune";
        public const string Euw = "euw";
        public const string Kr = "kr";
        public const string Lan = "lan";
        public const string Las = "las";
        public const string Na = "na";
        public const string Oce = "oce";
        public const string Ru = "ru";
        public const string Tr = "tr";

        internal static readonly Dictionary<RegionEnum, string> Regions = new Dictionary<RegionEnum, string>
        {
            { RegionEnum.Br, Br },
            { RegionEnum.Eune, Eune },
            { RegionEnum.Euw, Euw },
            { RegionEnum.Kr, Kr },
            { RegionEnum.Lan, Lan },
            { RegionEnum.Las, Las },
            { RegionEnum.Na, Na },
            { RegionEnum.Oce, Oce },
            { RegionEnum.Ru, Ru },
            { RegionEnum.Tr, Tr }
        };

        public const string SubDomainProd = "prod";
        public const string SubDomainEu = "eu";
        public const string SubDomainKr = "kr";

        internal static readonly Dictionary<RegionEnum, string> SubDomains = new Dictionary<RegionEnum, string>
        {
            { RegionEnum.Br, SubDomainProd },
            { RegionEnum.Eune, SubDomainProd },
            { RegionEnum.Euw, SubDomainProd },
            { RegionEnum.Kr, SubDomainKr },
            { RegionEnum.Lan, SubDomainProd },
            { RegionEnum.Las, SubDomainProd },
            { RegionEnum.Na, SubDomainProd },
            { RegionEnum.Oce, SubDomainProd },
            { RegionEnum.Ru, SubDomainEu },
            { RegionEnum.Tr, SubDomainEu }
        };
    }
}
