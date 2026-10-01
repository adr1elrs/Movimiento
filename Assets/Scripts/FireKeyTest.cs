using UnityEngine;

public class FireKeyTest : MonoBehaviour
{
    void Update()
    {
        // Input.GetButtonDown devuelve true solo en el frame en que se pulsa el botón mapeado
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("¡Disparo accionado mediante la tecla H (Eje virtual Fire1)!");
        }
    }
}