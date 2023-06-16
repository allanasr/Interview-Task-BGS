using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectable : MonoBehaviour , ICollectable
{
    public void Collectable()
    {
        Destroy(gameObject);
    }

}
