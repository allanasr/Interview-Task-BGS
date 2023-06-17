using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Item;

namespace Player
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] List<GameObject> inventorySlots = new List<GameObject>();
        [SerializeField] List<GameObject> playerInventory = new List<GameObject>();

        private void Start()
        {
            foreach(var i in inventorySlots)
            {
                Instantiate(playerInventory[0], i.transform);
            }
        }

       
    }

}
