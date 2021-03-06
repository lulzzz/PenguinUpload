﻿using Newtonsoft.Json;

namespace PenguinUpload.DataModels.Auth
{
    /// <summary>
    /// Represents a user who is registered and on record in the database.
    /// </summary>
    public class RegisteredUser : DatabaseObject
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Storage quota in bytes
        /// </summary>
        [JsonProperty("quota")]
        public long? StorageQuota { get; set; }

        /// <summary>
        ///  Storage usage in bytes
        /// </summary>
        [JsonProperty("usage")]
        public long StorageUsage { get; set; } = 0;

        [JsonIgnore]
        public string ApiKey { get; set; }

        [JsonIgnore]
        public ItemCrypto Crypto { get; set; }

        [JsonIgnore]
        public string Identifier { get; set; }

        [JsonIgnore]
        public bool Enabled { get; set; } = true;
    }
}