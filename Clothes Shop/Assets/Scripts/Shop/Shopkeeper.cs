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
        void Start()
        {
            interactablePopUp = GameObject.FindGameObjectWithTag("InteractablePopUp");
            interactablePopUp.SetActive(false);
        }
        public void Interactable()
        {
            ShowPopUp();
        }

        private void ShowPopUp()
        {
            interactablePopUp.SetActive(true);
            interactablePopUp.transform.DOScale(new Vector2(0.5f, 0.5f), animationDuration).SetEase(ease);
            Invoke(nameof(HidePopUp), 4f);
            
        } 
        private void HidePopUp()
        {
            interactablePopUp.transform.DOScale(new Vector2(0, 0), animationDuration).SetEase(ease);
        }
    }

}
