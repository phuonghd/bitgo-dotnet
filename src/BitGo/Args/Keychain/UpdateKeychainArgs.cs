using System;
using Newtonsoft.Json;

namespace BitGo.Args.Keychain {
    
    [JsonObject(MemberSerialization.OptIn)]
    internal class UpdateKeychainArgs {

        [JsonProperty("encryptedXprv", Required = Required.Always)]
        public string EncryptedExtendedPrivateKey { get; internal set; }

    }
}