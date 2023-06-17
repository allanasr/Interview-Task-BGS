using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour , ICollectable
{
    public void Collectable()
    {
        Destroy(gameObject);
    }

}
