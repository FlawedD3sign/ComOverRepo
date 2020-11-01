using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum ItemType
{
    Clothes,
    Furniture,
    Default
}
public abstract class ItemScript : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    [TextArea(15,20)]
    public string description;

}
