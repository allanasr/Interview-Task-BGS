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
        private int _currentInventoryCapacity;

        private Action updateCurrency;
        private AudioSource _audioSource;
        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            updateCurrency += GetValues;
            shopItem = GetComponent<ShopItem>();
        }

        // Checks if the player has the money and inventory capacity and if the shopkeeper has enough itens for the player to buy, and if it is all true, it buys the item
        public void BuyItem()
        {
            updateCurrency();
            PlaySound();
            if (_itemPrice <= _currentCoins && _itemQuantity > 0 && _currentInventoryCapacity < 3)
            {
                InventoryManager.Instance.AddToInventory(shopItem.GetItem());
                _itemQuantity--;
                _currentCoins -= _itemPrice;
                SetValues();
            }
            else if (_currentInventoryCapacity >= 3)
                CurrencyManager.Instance.ShowPanel("Inventory full");
            else if (_itemPrice > _currentCoins)
                CurrencyManager.Instance.ShowPanel("Not enough money");
            else if (_itemQuantity == 0)
                CurrencyManager.Instance.ShowPanel("No items to buy");


        }

        // Checks if the inventory has the item the player is selling and them sells it
        public void SellItem()
        {
            updateCurrency();
            PlaySound();
            if (InventoryManager.Instance.GetInventory().Contains(shopItem.GetItem()))
            {
                InventoryManager.Instance.RemoveFromInventory(shopItem.GetItem());
                _currentCoins += _itemPrice;
                _itemQuantity++;
                SetValues();
            }
        }
        

        public void GetValues()
        {
            _currentCoins = CurrencyManager.Instance.GetCoinAmount();
            _itemPrice = shopItem.GetItemPrice();
            _itemQuantity = shopItem.GetItemQuantity();
            _currentInventoryCapacity = InventoryManager.Instance.GetInventory().Count;
        }

        public void SetValues()
        {
            shopItem.SetItemQuantity(_itemQuantity);
            CurrencyManager.Instance.SetCoinCounter(_currentCoins);

        }

        public void PlaySound()
        {
            _audioSource.Play();
        }
    }
}

