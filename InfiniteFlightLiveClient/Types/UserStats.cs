﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfiniteFlightLiveClient.Types
{
    public class UserStats
    {
        [JsonProperty("userId")]
        public Guid UserId { get; set; }
        [JsonProperty("virtualOrganization")]
        public string VirtualOrganization { get; set; }
        [JsonProperty("discourseUsername")]
        public string DiscourseUsername { get; set; }
        [JsonProperty("roles")]
        public int[] Roles { get; set; }
        [JsonProperty("errorCode")]
        public ResponseCode ErrorCode { get; set; }
        [JsonProperty("onlineFlights")]
        public int OnlineFlights { get; set; }
        [JsonProperty("violations")]
        public int Violations { get; set; }
        [JsonProperty("violationCountByLevel")]
        public Dictionary<string, int> ViolationsByLevel { get; set; }
        [JsonProperty("xp")]
        public double Xp { get; set; }
        [JsonProperty("landingCount")]
        public int LandingCount { get; set; }
        [JsonProperty("flightTime")]
        public double FlightTime { get; set; }
        [JsonProperty("atcOperations")]
        public int AtcOperations { get; set; }
        [JsonProperty("atcRank")]
        public AtcRank? AtcRank { get; set; }
        [JsonProperty("grade")]
        public int Grade { get; set; }
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public enum AtcRank
    {
        Observer,
        Trainee,
        Apprentice,
        Specialist,
        Officer,
        Supervisor,
        Recruiter,
        Manager
    }
}
