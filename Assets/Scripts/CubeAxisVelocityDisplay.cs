using UnityEngine;

public class CubeAxisVelocityDisplay : MonoBehaviour
{
    public float velocity = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            float valorEjeVertical = Input.GetAxis("Vertical");
            float resultado = velocity * valorEjeVertical;
            Debug.Log($"UpArrow pulsada -> Velocidad x EjeVertical = {velocity} x {valorEjeVertical:F2} = {resultado:F2}");
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            float valorEjeVertical = Input.GetAxis("Vertical");
            float resultado = velocity * valorEjeVertical;
            Debug.Log($"DownArrow pulsada -> Velocidad x EjeVertical = {velocity} x {valorEjeVertical:F2} = {resultado:F2}");
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            float valorEjeHorizontal = Input.GetAxis("Horizontal");
            float resultado = velocity * valorEjeHorizontal;
            Debug.Log($"RightArrow pulsada -> Velocidad x EjeHorizontal = {velocity} x {valorEjeHorizontal:F2} = {resultado:F2}");
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            float valorEjeHorizontal = Input.GetAxis("Horizontal");
            float resultado = velocity * valorEjeHorizontal;
            Debug.Log($"LeftArrow pulsada -> Velocidad x EjeHorizontal = {velocity} x {valorEjeHorizontal:F2} = {resultado:F2}");
        }
    }
}
