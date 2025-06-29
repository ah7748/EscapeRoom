using UnityEngine;

public class Recoger_Llave : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.tiene_llave = true;
            Destroy(gameObject);
        }
    }
}
