﻿using Newtonsoft.Json;

namespace NucleusOneDotNetSdk.ApiModel
{
    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrganizationForClient : Common.ApiModel.Entity<OrganizationForClient>, IOrganizationForClientMixin
    {
        public OrganizationForClient() { }

        #region Properties

        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Name { get; set; }
        public string CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public string CreatedByUserEmail { get; set; }
        public bool? SubscriptionRequired { get; set; }
        public int? SubscriptionFreeUsers { get; set; }
        public string SubscriptionExpiration { get; set; }
        public int? UniqueNonReadOnlyOrganizationMembers { get; set; }
        public int? UniqueReadOnlyOrganizationMembers { get; set; }
        public int? UniqueFreeOrganizationMembers { get; set; }
        public int? UniqueBillableOrganizationMembers { get; set; }
        
        #endregion
    }

    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OrganizationForClientCollection : QueryResultEntityCollection<OrganizationForClientCollection, OrganizationForClient>
    {
        public OrganizationForClientCollection() { }

        #region Properties

        [JsonProperty(nameof(Organizations))]
        public OrganizationForClient[] Organizations { get; set; }

        #endregion
    }

    // Originally generated by nucleus_one_utilities
    public interface IOrganizationForClientMixin
    {
        [JsonProperty("ID")]
        string Id { get; set; }

        [JsonProperty(nameof(CreatedOn))]
        string CreatedOn { get; set; }

        [JsonProperty(nameof(Name))]
        string Name { get; set; }

        [JsonProperty(nameof(CreatedByUserID))]
        string CreatedByUserID { get; set; }

        [JsonProperty(nameof(CreatedByUserName))]
        string CreatedByUserName { get; set; }

        [JsonProperty(nameof(CreatedByUserEmail))]
        string CreatedByUserEmail { get; set; }

        [JsonProperty(nameof(SubscriptionRequired))]
        bool? SubscriptionRequired { get; set; }

        [JsonProperty(nameof(SubscriptionFreeUsers))]
        int? SubscriptionFreeUsers { get; set; }

        [JsonProperty(nameof(SubscriptionExpiration))]
        string SubscriptionExpiration { get; set; }

        [JsonProperty(nameof(UniqueNonReadOnlyOrganizationMembers))]
        int? UniqueNonReadOnlyOrganizationMembers { get; set; }

        [JsonProperty(nameof(UniqueReadOnlyOrganizationMembers))]
        int? UniqueReadOnlyOrganizationMembers { get; set; }

        [JsonProperty(nameof(UniqueFreeOrganizationMembers))]
        int? UniqueFreeOrganizationMembers { get; set; }

        [JsonProperty(nameof(UniqueBillableOrganizationMembers))]
        int? UniqueBillableOrganizationMembers { get; set; }
    }
}