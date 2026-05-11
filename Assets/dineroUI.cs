using UnityEngine;
using TMPro;

public class dineroUI : MonoBehaviour
{
    TextMeshProUGUI dinero;
    void Start()
    {
        dinero=GetComponent<TextMeshProUGUI>();
    }
    void updateDinero(int valor)
    {
        dinero.text= "Dinero: "+ valor;
    }
}
