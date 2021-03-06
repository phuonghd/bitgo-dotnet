using System;
using Newtonsoft.Json;

namespace BitGo.Args {
    
    [JsonObject(MemberSerialization.OptIn)]
    internal class CreateBackupKeychainArgs {

        [JsonProperty("provider", Required = Required.Always)]
        public string Provider { get; internal set; }

    }
}