using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    IInteractivo objectoDet;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent<IInteractivo>(out objectoDet))
        {
            Debug.Log("Es Interactivo");
            objectoDet.Interact();
        }
        else
        {
            //Debug.Log("No es interactivo");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent<IInteractivo>(out IInteractivo interactivo))
        {
            objectoDet = interactivo;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.TryGetComponent<IInteractivo>(out IInteractivo interactivo))
        {
            objectoDet = null;
        }
    }

    public void OnInteract(InputValue Value)
    {
        if(!Value.isPressed)
        return;
        if(!PlayerStateMachine.Instance.CanInteract())
        return;
        objectoDet?.Interact();
    }

}
