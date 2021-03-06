﻿using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class EquipmentItem : PAPIItem
    {
        
        public bool _isEquipped { get; private set; }


        /// <summary>
        /// The JSON Constructor must contain all possible traits of an EquipmentItem
        /// </summary>
        /// <param name="_nameKey">if null or empty, the item is not valid</param>
        /// <param name="_basePrice">the price before any modifiers are adjusted</param>
        /// <param name="_encumbrance">the weight of the item</param>
        /// <param name="_rarity"> a value from 0 to 5, otherwise the item is not valid</param>
        /// <param name="_condition">if null, the item is in perfect condition</param>
        /// <param name="_qualities">if null or empty, the item has no special qualities</param>
        /// <param name="_availableGenres">if null or empty, the item is available in all settings</param>
        /// <param name="_descriptionKey">if null or empty, the item does not have, or doesn't even need a description</param>
        /// <param name="_isEquipped">true, if the item is currently equipped on someone/something</param>
        [JsonConstructor]
        public EquipmentItem(string _nameKey, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition, 
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres,string _descriptionKey, bool _isEquipped) 
            : base(_nameKey, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey)
        {
            this._isEquipped = _isEquipped;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new EquipmentItem " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new invalid Equipment Item
        /// </summary>
        public EquipmentItem() : base()
        {
            _isEquipped = false;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid EquipmentItem from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Equipment Item
        /// </summary>
        /// <param name="other">if null, an invalid default equipment item is created</param>
        public EquipmentItem(EquipmentItem other) : base(other)
        {
            if (other == null) return;

            _isEquipped = other._isEquipped;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new EquipmentItem from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}