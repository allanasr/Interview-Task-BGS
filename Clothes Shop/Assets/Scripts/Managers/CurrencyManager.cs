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
        [SerializeField] TMP_Text diamondCounterTxt;

        protected override void Awake()
        {
            base.Awake();
            coinCounterTxt = GameObject.FindGameObjectWithTag("CoinCounter").GetComponent<TMP_Text>();
            diamondCounterTxt = GameObject.FindGameObjectWithTag("DiamondCounter").GetComponent<TMP_Text>();
        }

        public void AddCollectable(string tag)
        {
            int result = tag == "Coin" ? coinCounter++ : diamondCounter++;
            UpdateCounter();
        }


        public void UpdateCounter()
        {
            coinCounterTxt.text = coinCounter.ToString();
            diamondCounterTxt.text = diamondCounter.ToString();
        }
    }
}
