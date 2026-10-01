using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [Header("Ubicación del destino")]
    public Transform marcadorDestino;
    
    [Header("Vector relativo calculado")]
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;
    private bool yaDesplazado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionOriginal = transform.position;

        if (marcadorDestino != null) {
            desplazamiento = marcadorDestino.position - posicionOriginal;
        } else {
            Debug.Log($"El objeto {gameObject.name} no tiene asignado un marcador de destino.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float jumpAxis = Input.GetAxis("Jump");

        if (jumpAxis > 0 && !yaDesplazado) {
            transform.position = posicionOriginal + desplazamiento;
            yaDesplazado = true;

        }
    }
}
