using UnityEngine;

public class Moneda : MonoBehaviour, IInteractivo
{

    [SerializeField] ItemData scriptableDatos;
    public void Interact()
    {
        Debug.Log("Recogiste Item");
        Destroy(gameObject);
    }
}
