using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Currency;

namespace Shop
{
    public class ShopSellDiamonds : MonoBehaviour
    {
        private int _currentDiamonds;
        private int _currentCoins;

        public void SellDiamonds()
        {
            GetValues();
            if (_currentDiamonds > 0)
            {
                _currentCoins += 5;
                _currentDiamonds -= 1;
            }
            SetValues();
        }


        public void GetValues()
        {
            _currentCoins = CurrencyManager.Instance.GetCoinAmount();
            _currentDiamonds = CurrencyManager.Instance.GetDiamondAmount();
        }
        public void SetValues()
        {
            CurrencyManager.Instance.SetCoinCounter(_currentCoins);
            CurrencyManager.Instance.SetDiamondCounter(_currentDiamonds);
        }
    }
}
