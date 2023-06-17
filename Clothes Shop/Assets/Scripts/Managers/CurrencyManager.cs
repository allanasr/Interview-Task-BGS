using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using TMPro;

namespace Currency
{ 
    public class CurrencyManager : Singleton<CurrencyManager>
    {
        [SerializeField] int coinCounter;
        [SerializeField] int diamondCounter;
        [SerializeField] TMP_Text coinCounterTxt;
        [SerializeField] TMP_Text shopCoinCounterTxt;
        [SerializeField] TMP_Text diamondCounterTxt;
        [SerializeField] TMP_Text shopDiamondCounterTxt;

        protected override void Awake()
        {
            base.Awake();
            coinCounterTxt = GameObject.FindGameObjectWithTag("CoinCounter").GetComponent<TMP_Text>();
            shopCoinCounterTxt = GameObject.FindGameObjectWithTag("ShopCoinCounter").GetComponent<TMP_Text>();
            diamondCounterTxt = GameObject.FindGameObjectWithTag("DiamondCounter").GetComponent<TMP_Text>();
            shopDiamondCounterTxt = GameObject.FindGameObjectWithTag("ShopDiamondCounter").GetComponent<TMP_Text>();
        }

        public void AddCollectable(string tag)
        {
            int result = tag == "Coin" ? coinCounter++ : diamondCounter++;
            UpdateCounter();
        }


        public void UpdateCounter()
        {
            coinCounterTxt.text = shopCoinCounterTxt.text = coinCounter.ToString();
            diamondCounterTxt.text = shopDiamondCounterTxt.text = diamondCounter.ToString();
        }

        public int GetDiamondAmount()
        {
            return diamondCounter;
        }

        public int GetCoinAmount()
        {
            return coinCounter;
        }

        public void SetDiamondCounter(int value)
        {
            diamondCounter = value;
            UpdateCounter();
        }

        public void SetCoinCounter(int value)
        {
            coinCounter = value;
            UpdateCounter();
        }
    }
}
