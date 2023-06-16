using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Currency;
using Shop;

namespace Player
{
    public class PlayerInteraction : MonoBehaviour
    {
        public GameObject buttonPopUp;
        public Ease inEase;
        public Ease outEase;
        public string[] tagsToLook;

        [Header("Animation")] 
        public float animationDuration = 1f;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            foreach (var t in tagsToLook)
            {
                if (collision.transform.tag == t)
                {

                    if (collision.transform.GetComponent<IInteractable>() != null)
                    {
                        StartCoroutine(InsideInteractionRange(collision.GetComponent<Collider2D>()));
                        
                    }

                    if (collision.transform.GetComponent<ICollectable>() != null)
                    {
                        CurrencyManager.Instance.AddCollectable(collision.transform.tag);
                        collision.transform.GetComponent<ICollectable>().Collectable();
                    }
                }
            }
        }

        IEnumerator InsideInteractionRange(Collider2D collider2D)
        {
            buttonPopUp.SetActive(true);
            buttonPopUp.transform.DOScale(Vector2.one, animationDuration).SetEase(inEase);

                Debug.Log("cu");
            if(Input.GetKey(KeyCode.E))
            {
                Debug.Log("ue");
                ShopManager.Instance.ShowShop();
            }

            yield return new WaitWhile(() => GetComponent<Collider2D>().IsTouching(collider2D));

            buttonPopUp.transform.DOScale(Vector2.zero, animationDuration).SetEase(outEase);

            yield return new WaitForSeconds(animationDuration);

            buttonPopUp.SetActive(false);
        }

    }

}
