using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Movimiento_personaje : MonoBehaviour
{
    [SerializeField] private float Vmovimiento;
    [SerializeField] private float Vrotacion;
    [SerializeField] private CharacterController charactercontroller;
    [SerializeField] private Transform transformPersonaje;
    [SerializeField] private Camera camaraPersonaje;

    private Vector3 movimiento;
    private float rotacionX;


    private void Update()
    {
        MovimientoDelPersonaje();
        MovimientoDeCamara();
    }
    void MovimientoDelPersonaje()
    {
        float movX = InputAction.("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        movimiento = transform.right * movX + transform.forward * movZ;
        charactercontroller.SimpleMove(movimiento * Vmovimiento);
    }

    void MovimientoDeCamara()
    {
        float mouseX = Input.GetAxis("Mouse X") * Vrotacion;
        float mouseY = Input.GetAxis("Mouse Y") * Vrotacion;

        rotacionX -= mouseX;
        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        camaraPersonaje.transform.localRotation = Quaternion.Euler(rotacionX, 0, 0);
        transformPersonaje.Rotate(Vector3.up * mouseX);
    }
}
