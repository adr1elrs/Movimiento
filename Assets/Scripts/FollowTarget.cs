using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform objetivo;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (objetivo == null) return;
        Vector3 posicionPlana = new Vector3(objetivo.position.x, transform.position.y, objetivo.position.z);
        transform.LookAt(posicionPlana);
        
        Vector3 direccion = objetivo.position - transform.position;
        direccion.y = 0;

        if (direccion.magnitude > 0.05f) {
            Vector3 direccionNormalizada = direccion.normalized;

            Vector3 desplazamiento = direccionNormalizada * speed * Time.deltaTime;

            transform.Translate(desplazamiento, Space.World);
        }
    }
}
