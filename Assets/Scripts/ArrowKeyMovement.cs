using UnityEngine;

public class ArrowKeyMovement : MonoBehaviour
{
    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        float deltaX = 0.0f;
        float deltaZ = 0.0f;

        if (Input.GetKey(KeyCode.RightArrow)) deltaX += 1.0f;
        if (Input.GetKey(KeyCode.LeftArrow)) deltaX -= 1.0f;

        if (Input.GetKey(KeyCode.UpArrow)) deltaZ += 1.0f;
        if (Input.GetKey(KeyCode.DownArrow)) deltaZ -= 1.0f;

        transform.Translate(deltaX * speed, 0.0f, deltaZ * speed, Space.World);
    }
}
