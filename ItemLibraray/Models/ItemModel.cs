namespace ItemLibraray.Models
{
    public class ItemModel
    {
        /// <summary>
        /// The Unic Identification for the Model
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The Items Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A short description of the Item.
        /// </summary>
        public string Description { get; set; }

        // public int Image { get; set; } need to find out how to add Images
        /// <summary>
        /// Represents how much the Item is worth in a numeric currency.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Represents the Lore that might be hidden around the Item.
        /// </summary>
        public string Lore { get; set; }

        public ItemModel(string p_Name, string p_Description, string p_Value, string p_Lore)
        {
            Name = p_Name;
            Description = p_Description;

            int value_Number = 0;
            int.TryParse(p_Value, out value_Number);
            Value = value_Number;

            Lore = p_Lore;
        }
    }
}