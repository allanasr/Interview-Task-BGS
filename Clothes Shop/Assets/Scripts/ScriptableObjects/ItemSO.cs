using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Item
{
    [CreateAssetMenu(fileName = "Item")]
    public class ItemSO : ScriptableObject
    {
        public string itemName;
        public string itemQuantity;
        public string itemPrice;
        public Sprite itemIcon;
    }
}
