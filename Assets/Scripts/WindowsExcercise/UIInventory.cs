using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public InvetoryData data;
    private void OnEnable()
    {
        Debug.Log(" INVENTARIO");
        Debug.Log("HP: " + data.hp);
        Debug.Log("STR: " + data.str);
        Debug.Log("LIFE: " + data.life);
    }
}