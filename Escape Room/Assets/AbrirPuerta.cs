using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.tiene_llave)
        {
            transform.Rotate(0,180,0);
        }
    }
}
