## Custom dictionary converter in newton JSON

https://zetbit.tech/categories/asp-dot-net-core/26/mastering-json-in-c-sharp-with-newtonsoft-json


    "playerItems":
    {
        "itemsList":
        [
            {
                "type": "coins",
                "amount": 50
            }
        ]
    }

    
    [Serializable]
    public class PlayerInventoryData 
    {
 		[JsonProperty("list")]
        [JsonConverter(typeof(PlayerItemsConverter))] 
        public Dictionary<PlayerItemType, PlayerItemData> List { get; private set; }
    }


    public class PlayerItemData
    {
        public PlayerItemType Type;
        public string Id;
        public float Amount;

        public PlayerItemData(PlayerItemType type, string id, float amount)
        {
            Type = type;
            Id = id;
            Amount = amount;
        }
    }

    public class PlayerItemsConverter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                //TBD
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var items = new Dictionary<PlayerItemType, PlayerItemData>();
                var jToken = JToken.ReadFrom (reader);
                var jArray = jToken as JArray;

                if (jArray == null)
                {
                    return items;
                }

                foreach (var token in jArray)
                {
                    var itemType = token["type"]?.Value<string>();
                    var itemID = token["id"]?.Value<string>();
                    var itemValue =  token["amount"].Value<float>();
                    var inventoryItemType = ConvertToItemType(itemType);
                    PlayerItemData item = new (inventoryItemType, itemID, itemValue);
                    items.Add(inventoryItemType, item);
                }
                
                return items;
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(bool);
            }
        }


    public enum PlayerItemType
    {
        None,
        Energy
    }

