using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Currency;
using System;
using Inventory;
using Item;

namespace Shop
{
    public class ShopItemInteraction : MonoBehaviour
    {
        [SerializeField] ShopItem shopItem;

        private int _currentCoins;
        private int _itemPrice;
        private int _itemQuantity;

        private Action updateCurrency;

        private void Start()
        {
            updateCurrency += GetValues;
            shopItem = GetComponent<ShopItem>();
        }
        public void BuyItem()
        {
            updateCurrency();
            if (_itemPrice <= _currentCoins && _itemQuantity > 0)
            {
                InventoryManager.Instance.AddToInventory(shopItem.GetItem());
                _itemQuantity--;
                _currentCoins -= _itemPrice;
                SetValues();
            }
        }

        public void SellItem()
        {
            updateCurrency();
            if (InventoryManager.Instance.GetInventory().Contains(shopItem.GetItem()))
            {
                InventoryManager.Instance.RemoveFromInventory(shopItem.GetItem());
                _currentCoins += _itemPrice;
                SetValues();
            }
        }
   

        public void GetValues()
        {
            _currentCoins = CurrencyManager.Instance.GetCoinAmount();
            _itemPrice = shopItem.GetItemPrice();
            _itemQuantity = shopItem.GetItemQuantity();
        }

        public void SetValues()
        {
            shopItem.SetItemQuantity(_itemQuantity);
            CurrencyManager.Instance.SetCoinCounter(_currentCoins);

        }
    }
}

