﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ademero.NucleusOneDotNetSdk.ApiModel
{
    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AssetItemTag : Common.ApiModel.Entity<AssetItemTag>
    {
        public AssetItemTag()
        {
            _tags = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        #region Fields

        private HashSet<string> _tags;

        #endregion

        #region Properties

        [JsonProperty("AssetID")]
        public string AssetId { get; set; }

        [JsonProperty("AssetName")]
        public string AssetName { get; set; }

        [JsonProperty("AssetItemID")]
        public string AssetItemId { get; set; }

        [JsonProperty("AssetItemName")]
        public string AssetItemName { get; set; }

        #endregion
    }

    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AssetItemTagCollection : QueryResultEntityCollection<AssetItemTagCollection, AssetItemTag>
    {
        public AssetItemTagCollection() { }

        #region Properties

        [JsonProperty("AssetItemTags")]
        public AssetItemTag[] AssetItemTags { get; set; }

        #endregion
    }
}
