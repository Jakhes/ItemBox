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

        /// <summary>
        /// References the id of the System Model that this Item was created in.
        /// </summary>
        public int SystemRefId { get; set; }

        public ItemModel() 
        { 
            ID = 0;
            Name = string.Empty;
            Description = string.Empty;
            Value = 0;
            Lore = string.Empty;
            SystemRefId = 0;
        }
        public ItemModel(string p_Name, string p_Description, string p_Value, string p_Lore, string p_SystemRefId)
        {
            Name = p_Name;
            Description = p_Description;

            int value_Number = 0;
            int.TryParse(p_Value, out value_Number);
            Value = value_Number;

            Lore = p_Lore;

            int ref_Id_Number = 0;
            int.TryParse(p_SystemRefId, out ref_Id_Number);
            SystemRefId = ref_Id_Number;
        }
    }
}