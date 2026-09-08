using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;
    public int nodosRestantes;
    public GameObject PanelVictoria;

    private void Awake()
    {
        instancia = this;
    }

    private void Start()
    {
        nodosRestantes = GameObject.FindGameObjectsWithTag("Energy").Length;
    }

    public void RecolectarNodo()
    {
        nodosRestantes--;

        if (nodosRestantes <= 0)
        {
            PanelVictoria.SetActive(true);
        }
    }
}