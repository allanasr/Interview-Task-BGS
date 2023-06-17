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
        void Start()
        {
            Debug.Log("oi");
        }

        void Update()
        {
            
        }
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("oi2");
            _selectedObject = eventData.pointerPress;
            item = InventoryManager.Instance.GetInventoryItem(_selectedObject.name);
            _bodyPartType = item.itemBodyPart;
            bodyPart = GameObject.FindGameObjectWithTag(_bodyPartType.ToString());
            bodyPart.GetComponent<SpriteRenderer>().sprite = item.itemIcon;
        }
    }
}
