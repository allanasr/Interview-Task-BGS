using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using Item;
using UnityEngine.UI;

namespace Inventory
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        [SerializeField] List<ItemSO> items = new List<ItemSO>();

        [SerializeField] List<RectTransform> inventorySlots = new List<RectTransform>();

        [SerializeField] GameObject inventoryObjectPrefab;


        public void AddToInventory(ItemSO item)
        {
            items.Add(item);
        }

        public void RemoveFromInventory(ItemSO item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }

        }

        public void ShowItems()
        {
            foreach (var i in inventorySlots)
            {
                if (i.childCount > 0)
                {
                    Transform child = i.GetChild(0);
                    Destroy(child.gameObject);
                }
            }

            var index = 0;
            foreach(var i in items)
            {
                var g = Instantiate(inventoryObjectPrefab, inventorySlots[index]);
                g.name = i.itemName;
                g.GetComponent<Image>().sprite = i.itemIcon;
                g.layer = 5;
                g.transform.localScale = new Vector2(0.7f, 0.7f);
                index++;
            }
        }

        public List<ItemSO> GetInventory()
        {
            return items;
        }

        public ItemSO GetInventoryItem(string name)
        {
            return items.Find(i => i.itemName == name);
        }
    }

}
