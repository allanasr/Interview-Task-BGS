using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Item;

namespace Inventory
{
    public class InventoryController : MonoBehaviour, IPointerClickHandler
    {

        private GameObject _selectedObject;
        
        private ItemBodyPart _bodyPartType; 

        [SerializeField] ItemSO item;
        [SerializeField] GameObject bodyPart;

        // Gets the object the player is clicking and then change the player sprite to match the icon
        public void OnPointerClick(PointerEventData eventData)
        {
            _selectedObject = eventData.pointerPress;
            item = InventoryManager.Instance.GetInventoryItem(_selectedObject.name);
            _bodyPartType = item.itemBodyPart;
            bodyPart = GameObject.FindGameObjectWithTag(_bodyPartType.ToString());
            bodyPart.GetComponent<SpriteRenderer>().sprite = item.itemIcon;
            InventoryManager.Instance.RemoveFromInventory(item);
        }
    }
}
