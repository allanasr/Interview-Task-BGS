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

        [SerializeField] List<Transform> inventorySlots = new List<Transform>();

        public void AddToInventory(ItemSO item)
        {
            items.Add(item);
        }

        public void RemoveFromInventory(ItemSO item)
        {
            if (items.Contains(item))
                items.Remove(item);
        }

        public void ShowItems()
        {
            var index = 0;
            foreach(var i in items)
            {
                var g = new GameObject();
                g.AddComponent<Image>().sprite = i.itemIcon;
                g.name = i.itemName;
                g.transform.localScale = new Vector2(0.7f, 0.7f);
                Instantiate(g, inventorySlots[index]);
                index++;
            }
        }

        public List<ItemSO> GetInventory()
        {
            return items;
        }
    }

}
