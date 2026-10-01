using UnityEngine;

public class WASDKeyMovement : MonoBehaviour
{
    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float deltaX = 0.0f;
        float deltaZ = 0.0f;

        if (Input.GetKey(KeyCode.D)) deltaX += 1.0f;
        if (Input.GetKey(KeyCode.A)) deltaX -= 1.0f;

        if (Input.GetKey(KeyCode.W)) deltaZ += 1.0f;
        if (Input.GetKey(KeyCode.S)) deltaZ -= 1.0f;

        transform.Translate(deltaX * speed * Time.deltaTime, 0.0f, deltaZ * speed * Time.deltaTime, Space.World);
    }
}
