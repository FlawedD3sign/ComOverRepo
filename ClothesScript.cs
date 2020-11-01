using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothes Object", menuName = "Inventory System/Items/Clothes")]
public class ClothesScript : ItemScript
{
    public void Awake()
    {
        type = ItemType.Clothes;
    }
}
