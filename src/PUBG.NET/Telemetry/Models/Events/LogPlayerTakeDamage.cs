﻿using System;
using Newtonsoft.Json;
using PUBGLibrary.Telemetry;

namespace PUBGLibrary.Telemetry
{
    public class LogPlayerTakeDamage : IEvent
    {
        [JsonProperty("_T")]
        public EventType EventType { get; set; }
        [JsonProperty("_D")]
        public DateTime EventTimestamp { get; set; }
        [JsonProperty("_V")]
        public int EventVersion { get; set; }
        [JsonProperty("Common")]
        public Common EventCommon { get; set; }
        public int AttackId { get; set; }
        public Character Attacker { get; set; }
        public Character Victim { get; set; }
        public DamageTypeCategory DamageTypeCategory { get; set; }
        public DamageReason DamageReason { get; set; }
        public float Damage { get; set; }
        public string DamageCauserName { get; set; }
    }
}
