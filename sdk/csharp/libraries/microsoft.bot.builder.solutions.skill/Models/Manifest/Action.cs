﻿using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.Solutions.Skill.Models.Manifest
{
    public class Action
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "definition")]
        public ActionDefinition Definition { get; set; }
    }
}
