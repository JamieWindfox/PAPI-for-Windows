﻿using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class ItemQuality
    {
        public string _nameKey { get; private set; }

        /// <summary>
        /// Does the quality has to be activated somehow?
        /// </summary>
        public bool _isActive { get; private set; }

        public string _descriptionKey { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Json CTOR must contain all traitsof the item quality
        /// </summary>
        /// <param name="_nameKey"></param>
        /// <param name="_isActive"></param>
        /// <param name="_descriptionKey"></param>
        [JsonConstructor]
        public ItemQuality(string _nameKey, bool _isActive, string _descriptionKey)
        {
            this._nameKey = (_nameKey == null || _nameKey == "") ? "ItemQuality_INVALID_ITEM_QUALITY" : _nameKey;
            this._isActive = _isActive;
            this._descriptionKey = (_descriptionKey == null || _descriptionKey == "") ? "Translation_INVALID_DESCRIPTION" : _descriptionKey;
        }
    }
}