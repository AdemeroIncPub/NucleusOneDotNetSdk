﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace Ademero.NucleusOneDotNetSdk.Model
{
    // Originally generated by nucleus_one_utilities
    [Serializable]
    public class Field : Common.Model.Entity<ApiModel.Field>
    {
        private Field(NucleusOneApp app) : base(app)
        {
            _childFieldIds = new List<string>();
            _documentTags = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        #region Fields

        private List<string> _childFieldIds;
        private HashSet<string> _documentTags;

        #endregion

        public static Field FromApiModel(ApiModel.Field apiModel, NucleusOneApp app = null)
        {
            return new Field(app)
            {
                Id = apiModel.Id,
                ProjectAccess = ProjectAccess.FromApiModel(apiModel.ProjectAccess),
                Rank = apiModel.Rank,
                AllowDocumentField = apiModel.AllowDocumentField,
                CreatedOn = apiModel.CreatedOn,
                ParentFieldId = apiModel.ParentFieldId,
                ChildFieldIds = apiModel.ChildFieldIds,
                Name = apiModel.Name,
                NameLower = apiModel.NameLower,
                Label = apiModel.Label,
                LabelLower = apiModel.LabelLower,
                LabelOrName = apiModel.LabelOrName,
                LabelOrNameLower = apiModel.LabelOrNameLower,
                Type = apiModel.Type,
                DisplaySelectionList = apiModel.DisplaySelectionList,
                SelectionListIsDependent = apiModel.SelectionListIsDependent,
                AllowMultipleLines = apiModel.AllowMultipleLines,
                Rows = apiModel.Rows,
                AllowMultipleValues = apiModel.AllowMultipleValues,
                AllowNewSelectionListItems = apiModel.AllowNewSelectionListItems,
                SaveNewSelectionListItems = apiModel.SaveNewSelectionListItems,
                DecimalPlaces = apiModel.DecimalPlaces,
                Mask = apiModel.Mask,
                Required = apiModel.Required,
                Sensitive = apiModel.Sensitive,
                UseCreationDate = apiModel.UseCreationDate,
                TextMatchType = apiModel.TextMatchType,
                DocumentTags = apiModel.DocumentTags
            };
        }

        #region Properties

        public string Id { get; set; }

        public ProjectAccess ProjectAccess { get; set; }

        public double Rank { get; set; }

        public bool AllowDocumentField { get; set; }

        public string CreatedOn { get; set; }

        public string ParentFieldId { get; set; }

        public List<string> ChildFieldIds
        {
            get => _childFieldIds;
            set => _childFieldIds = value ?? new List<string>();
        }

        public string Name { get; set; }

        public string NameLower { get; set; }

        public string Label { get; set; }

        public string LabelLower { get; set; }

        public string LabelOrName { get; set; }

        public string LabelOrNameLower { get; set; }

        public bool HideLabel { get; set; }

        public string Type { get; set; }

        public bool DisplaySelectionList { get; set; }

        public bool SelectionListIsDependent { get; set; }

        public bool AllowMultipleLines { get; set; }

        public int Rows { get; set; }

        public bool AllowMultipleValues { get; set; }

        public bool AllowNewSelectionListItems { get; set; }

        public bool SaveNewSelectionListItems { get; set; }

        public int DecimalPlaces { get; set; }

        public string Mask { get; set; }

        public bool Required { get; set; }

        public bool Sensitive { get; set; }

        public bool UseCreationDate { get; set; }

        public string TextMatchType { get; set; }

        public HashSet<string> DocumentTags
        {
            get => _documentTags;
            set => _documentTags = value ?? new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }

        #endregion

        public override ApiModel.Field ToApiModel()
        {
            return new ApiModel.Field()
            {
                Id = Id,
                CreatedOn = CreatedOn,
                ParentFieldId = ParentFieldId,
                Name = Name,
                NameLower = NameLower,
                Label = Label,
                LabelLower = LabelLower,
                LabelOrName = LabelOrName,
                LabelOrNameLower = LabelOrNameLower,
                HideLabel = HideLabel,
                Type = Type,
                DisplaySelectionList = DisplaySelectionList,
                AllowMultipleLines = AllowMultipleLines,
                Rows = Rows,
                AllowMultipleValues = AllowMultipleValues,
                AllowNewSelectionListItems = AllowNewSelectionListItems,
                SaveNewSelectionListItems = SaveNewSelectionListItems,
                DecimalPlaces = DecimalPlaces,
                Mask = Mask,
                Required = Required,
                Sensitive = Sensitive,
                UseCreationDate = UseCreationDate,
                TextMatchType = TextMatchType,
                DocumentTags = DocumentTags
            };
        }
    }

    [Serializable]
    public class FieldCollection : Common.Model.EntityCollection<Field, ApiModel.FieldCollection>
    {
        public FieldCollection(
            Field[] items,
            NucleusOneApp app = null
        ) : base(app, items) { }

        public static FieldCollection FromApiModel(
            ApiModel.FieldCollection apiModel,
            NucleusOneApp app = null
        )
        {
            return new FieldCollection(
                items: apiModel.Fields?.Select((x) => Field.FromApiModel(x, app)).ToArray());
        }

        public override ApiModel.FieldCollection ToApiModel()
        {
            return new ApiModel.FieldCollection()
            {
                Fields = Items.Select((x) => x.ToApiModel()).ToArray()
            };
        }
    }
}