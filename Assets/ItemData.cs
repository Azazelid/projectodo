using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "Scriptable Objects/ItemData")]
public class ItemData : ScriptableObject
{
    public string nombreItem;
    public int valor;
    public AudioClip sonidoItem;
    public GameObject prefabItem;
}
