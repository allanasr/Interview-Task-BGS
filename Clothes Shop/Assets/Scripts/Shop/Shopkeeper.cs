using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace Shop
{
    public class Shopkeeper : MonoBehaviour, IInteractable
    {

        [SerializeField] GameObject interactablePopUp;

        [SerializeField] Ease ease;
        [SerializeField] float animationDuration = 1f;
        public void Interactable()
        {
            interactablePopUp.SetActive(true);
            interactablePopUp.transform.DOScale(new Vector2(0.5f, 0.5f), animationDuration).SetEase(ease);
           
        }
        void Start()
        {
            interactablePopUp = GameObject.FindGameObjectWithTag("InteractablePopUp");
            interactablePopUp.SetActive(false);
        }
    }

}
