﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ademero.NucleusOneDotNetSdk.ApiModel
{
    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Field : Common.ApiModel.Entity<Field>
    {
        public Field() : base()
        {
            _documentTags = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        #region Fields

        private HashSet<string> _documentTags;
        private List<string> _childFieldIds;

        #endregion

        #region Properties

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("OrganizationID")]
        public string OrganizationId { get; set; }

        [JsonProperty("ProjectID")]
        public string ProjectId { get; set; }

        [JsonProperty("ProjectName")]
        public string ProjectName { get; set; }

        [JsonProperty("ProjectAccess")]
        public ProjectAccess ProjectAccess { get; set; }

        [JsonProperty("Rank")]
        public double Rank { get; set; }

        [JsonProperty("AllowDocumentField")]
        public bool AllowDocumentField { get; set; }

        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("ParentFieldID")]
        public string ParentFieldId { get; set; }

        [JsonProperty("ChildFieldIDs")]
        public List<string> ChildFieldIds
        {
            get => _childFieldIds;
            set => _childFieldIds = value ?? new List<string>();
        }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("NameLower")]
        public string NameLower { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("LabelLower")]
        public string LabelLower { get; set; }

        [JsonProperty("LabelOrName")]
        public string LabelOrName { get; set; }

        [JsonProperty("LabelOrNameLower")]
        public string LabelOrNameLower { get; set; }

        [JsonProperty("HideLabel")]
        public bool HideLabel { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("DisplaySelectionList")]
        public bool DisplaySelectionList { get; set; }

        [JsonProperty("SelectionListIsDependent")]
        public bool SelectionListIsDependent { get; set; }

        [JsonProperty("AllowMultipleLines")]
        public bool AllowMultipleLines { get; set; }

        [JsonProperty("Rows")]
        public int Rows { get; set; }

        [JsonProperty("AllowMultipleValues")]
        public bool AllowMultipleValues { get; set; }

        [JsonProperty("AllowNewSelectionListItems")]
        public bool AllowNewSelectionListItems { get; set; }

        [JsonProperty("SaveNewSelectionListItems")]
        public bool SaveNewSelectionListItems { get; set; }

        [JsonProperty("DecimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("Mask")]
        public string Mask { get; set; }

        [JsonProperty("Required")]
        public bool Required { get; set; }

        [JsonProperty("Sensitive")]
        public bool Sensitive { get; set; }

        [JsonProperty("UseCreationDate")]
        public bool UseCreationDate { get; set; }

        [JsonProperty("TextMatchType")]
        public string TextMatchType { get; set; }

        [JsonProperty("DocumentTags")]
        public HashSet<string> DocumentTags
        {
            get => _documentTags;
            set => _documentTags = value ?? new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        #endregion
    }

    // Originally generated by nucleus_one_utilities
    // Serializable members must be explicitly marked with [JsonProperty].
    [Serializable]
    [JsonObject(MemberSerialization.OptIn, ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FieldCollection : QueryResultEntityCollection<FieldCollection, Field>
    {
        #region Properties

        [JsonProperty(nameof(Fields))]
        public Field[] Fields
        {
            get => Items;
            set => Items = value;
        }

        #endregion
    }
}
