using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Item;
using TMPro;
using UnityEngine.UI;
using Currency;

namespace Shop
{
    public class ShopItem : MonoBehaviour
    {
        [SerializeField] ItemSO itemSO;

        [SerializeField] Sprite itemSprite;
        [SerializeField] string itemQuantity;
        [SerializeField] TMP_Text itemName;

        void Awake()
        {
            itemName = GetComponentInChildren<TMP_Text>();
            itemSprite = GetComponentInChildren<Image>().sprite;

            itemQuantity = itemSO.itemQuantity;
            itemSprite = itemSO.itemIcon;
            itemName.text = itemSO.itemName + " Qt: " + itemQuantity;
            GetComponentInChildren<Image>().sprite = itemSprite; 
        }

        public int GetItemPrice()
        {
            return int.Parse(itemSO.itemPrice);
        }

        public int GetItemQuantity()
        {
            return int.Parse(itemQuantity);
        }

        
        public void SetItemQuantity(int q)
        {
            itemQuantity = q.ToString();
            itemName.text = itemSO.itemName + " Qt: " + itemQuantity;
        }

        public ItemSO GetItem()
        {
            return itemSO;
        }
    }
}

