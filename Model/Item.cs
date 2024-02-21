using System;

namespace DDClothingStoreMAUI.Model
{
    /// <summary>
    /// Model class representing an item.
    /// </summary>
    public class Item
    {
        public Item(string itemName, string itemImage, string itemPrice, CategoryEnum category, string itemUrl, string itemDescription)
        {
            ItemName = itemName;
            ItemImage = itemImage;
            ItemPrice = itemPrice;
            Category = category;
            ItemUrl = itemUrl;
            ItemDescription = itemDescription;
        }

        public string ItemName
        {
            get; set;
        }
        
        public CategoryEnum Category
        {
            get; set;
        }
        public string ItemUrl
        {
            get; set;
        }
        
        public string ItemImage
        {
            get; set;
        }
        public string ItemPrice
        {
            get; set;
        }

        public string ItemDescription
        {
            get; set;
        }
    }
}