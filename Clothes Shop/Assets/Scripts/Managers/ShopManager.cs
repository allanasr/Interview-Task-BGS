using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;

namespace Shop
{
    public class ShopManager : Singleton<ShopManager>
    {

        public GameObject shopCanvas;

        protected override void Awake()
        {
            base.Awake();
            shopCanvas = GameObject.FindGameObjectWithTag("ShopCanvas");
            shopCanvas.SetActive(false);
        }
        private void Update()
        {
            if (shopCanvas.activeInHierarchy)
                Time.timeScale = 0;
        }
        public void ShowShop()
        {
            shopCanvas.SetActive(true);
        }
    }
}
