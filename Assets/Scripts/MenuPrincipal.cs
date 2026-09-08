using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
public void Jugar()
{
SceneManager.LoadScene("NivelPrincipal");
}
public void Salir()
{
Application.Quit();
}
}