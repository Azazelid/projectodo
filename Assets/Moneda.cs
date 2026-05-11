using UnityEngine;

public class Moneda : MonoBehaviour, IInteractivo
{

    [SerializeField] ItemData scriptableDatos;
    public void Interact()
    {
        Debug.Log("Recogiste Item:");
        Destroy(gameObject);
        AudioSource au= new AudioSource();
        au.PlayOneShot(scriptableDatos.sonidoItem);
        
    }
}
