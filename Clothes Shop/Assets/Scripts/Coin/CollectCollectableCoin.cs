using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectableCoin : MonoBehaviour , ICollectable
{
    public void Collectable()
    {
        Destroy(gameObject);
    }

}
