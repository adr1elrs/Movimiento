using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0.0f, 0.0f, 1.0f);
    public float speed = 2.0f;
    public bool usarEspacioMundial = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 desplazamiento = moveDirection * speed * Time.deltaTime;
        
        if (usarEspacioMundial) {
            transform.Translate(desplazamiento.x, desplazamiento.y, desplazamiento.z, Space.World);
        } else {
            transform.Translate(desplazamiento.x, desplazamiento.y, desplazamiento.z, Space.Self);
        }
    }
}