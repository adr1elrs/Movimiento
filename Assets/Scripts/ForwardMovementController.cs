using UnityEngine;

public class ForwardMovementController : MonoBehaviour
{
    public float speed = 4.0f;
    public float turnSpeed = 90.0f;
    public float rayLength = 30.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float anguloGiro = horizontalInput * turnSpeed * Time.deltaTime;
        transform.Rotate(0.0f, anguloGiro, 0.0f);

        Vector3 desplazamiento = transform.forward * speed * Time.deltaTime;
        transform.Translate(desplazamiento, Space.World);
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.red);
    }
}
