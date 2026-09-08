using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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
        textoHUD.text = "Nodos restantes: " + nodosRestantes;
        if (nodosRestantes <= 0)
        {
            PanelVictoria.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    
    public void ReloadScene()
    {
        SceneManager.LoadScene("NivelPrincipal");
    }
    public TMP_Text textoHUD;

}