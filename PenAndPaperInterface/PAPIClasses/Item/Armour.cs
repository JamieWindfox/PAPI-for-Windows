﻿using PAPI.Character.General;
using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class Armour : WearableItem
    {


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Son CTOR must contain all traits of a wearable item
        /// </summary>
        /// <param name="_name">if null or empty, the item is not valid</param>
        /// <param name="_basePrice">the price before any modifiers are adjusted</param>
        /// <param name="_encumbrance">the weight of the item</param>
        /// <param name="_rarity"> a value from 0 to 5</param>
        /// <param name="_condition">if null, the item is in perfect condition</param>
        /// <param name="_qualities">if null or empty, the item has no special qualities</param>
        /// <param name="_availableGenres">if null or empty, the item is available in all settings</param>
        /// <param name="_descriptionKey">if null or empty, the item does not have, or doesn't even need a description</param>
        /// <param name="_isEquipped">true, if item is currently equipped to someone</param>
        /// <param name="_soak">the value that gets subtracted from any incoming damage (except falling damage)</param>
        /// <param name="_defense">the number of setback dice any attacker gets if they target this items bearer</param>
        [JsonConstructor]
        public Armour(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition,
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres, string _descriptionKey, bool _isEquipped,
            Value _soak, Defense _defense)
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey, _isEquipped, _soak, _defense)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Armour " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new invalid Armour
        /// </summary>
        public Armour() : base()
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid Armour from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Armour
        /// </summary>
        /// <param name="other">if null, an invalid default Armour is created</param>
        public Armour(Armour other) : base(other)
        {
            if (other == null) return;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Armour from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
