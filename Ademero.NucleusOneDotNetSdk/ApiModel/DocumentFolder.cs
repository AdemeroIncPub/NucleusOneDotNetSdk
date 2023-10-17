﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ademero.NucleusOneDotNetSdk.ApiModel
{
    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class DocumentFolder : Common.ApiModel.Entity<DocumentFolder>
    {
        public DocumentFolder() { }

        #region Properties

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("UniqueID")]
        public string UniqueId { get; set; }

        [JsonProperty("ParentID")]
        public string ParentId { get; set; }

        [JsonProperty("AncestorIDs")]
        public List<string> AncestorIds { get; set; }

        [JsonProperty("OrganizationID")]
        public string OrganizationId { get; set; }

        [JsonProperty("ProjectID")]
        public string ProjectId { get; set; }

        [JsonProperty("ProjectName")]
        public string ProjectName { get; set; }

        [JsonProperty("ProjectAccess")]
        public ProjectAccess ProjectAccess { get; set; }

        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("CreatedByUserEmail")]
        public string CreatedByUserEmail { get; set; }

        [JsonProperty("CreatedByUserName")]
        public string CreatedByUserName { get; set; }

        [JsonProperty("CreatedByUserID")]
        public string CreatedByUserId { get; set; }

        [JsonProperty("CreatedByWorkflow")]
        public bool CreatedByWorkflow { get; set; }

        [JsonProperty("ModifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("ModifiedByUserEmail")]
        public string ModifiedByUserEmail { get; set; }

        [JsonProperty("ModifiedByUserName")]
        public string ModifiedByUserName { get; set; }

        [JsonProperty("ModifiedByUserID")]
        public string ModifiedByUserId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NameLower")]
        public string NameLower { get; set; }

        [JsonProperty("Depth")]
        public int Depth { get; set; }

        [JsonProperty("AncestorAssignmentUserEmails")]
        public List<string> AncestorAssignmentUserEmails { get; set; }

        [JsonProperty("AssignmentUserEmails")]
        public List<string> AssignmentUserEmails { get; set; }

        [JsonProperty("HexColor")]
        public string HexColor { get; set; }

        #endregion
    }

    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class DocumentFolderCollection : QueryResultEntityCollection<DocumentFolderCollection, DocumentFolder>
    {
        public DocumentFolderCollection() { }

        #region Properties

        [JsonProperty("DocumentFolders")]
        public DocumentFolder[] DocumentFolders
        {
            get => Items;
            set => Items = value;
        }

        #endregion
    }
}
