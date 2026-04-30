using UnityEngine;

public class Interactor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame  
    void Update()
    {
        
    }
    IInteractivo objectoDet;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IInteractivo>() != null)
        {
            Debug.Log("Es Interactivo");
            objectoDet=collision.gameObject.GetComponent<IInteractivo>();
        }
        else
        {
            Debug.Log("No es interactivo");
        }
    }
}
