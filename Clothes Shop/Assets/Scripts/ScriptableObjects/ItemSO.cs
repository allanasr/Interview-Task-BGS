using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Item
{

    public enum ItemBodyPart
    { 
        HOOD,
        TORSO
    }


    [CreateAssetMenu(fileName = "Item")]
    public class ItemSO : ScriptableObject
    {
        public string itemName;
        public string itemQuantity;
        public string itemPrice;
        public Sprite itemIcon;
        public ItemBodyPart itemBodyPart;
    }
}
