using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using Item;

namespace Inventory
{
    public class InventoryManager : Singleton<InventoryManager>
    {
        [SerializeField] List<ItemSO> items = new List<ItemSO>();

        [SerializeField] Transform inventoryContent;
        [SerializeField] GameObject gameObject;
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void AddToInventory(ItemSO item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach(var i in items)
            {
                var g = new GameObject();
                g.name = i.itemName;
                Instantiate(g, inventoryContent);
            }
        }
    }

}
