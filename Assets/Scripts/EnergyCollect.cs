using UnityEngine;

public class CollectEnergy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instancia.RecolectarNodo();
            gameObject.SetActive(false);
        }
    }
}
