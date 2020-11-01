using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")]
public class ItemDatabase : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemScript[] Items;
    public Dictionary<ItemScript, int> GetId = new Dictionary<ItemScript, int>();
    public Dictionary<int, ItemScript> GetItem = new Dictionary<int, ItemScript>();

    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<ItemScript, int>();
        GetItem = new Dictionary<int, ItemScript>();
        for (int i = 0; i < Items.Length; i++)
        {
            GetId.Add(Items[i], i);
            GetItem.Add(i, Items[i]);
        }
    }

    public void OnBeforeSerialize()
    {

    }
}
