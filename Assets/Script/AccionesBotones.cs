using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesAcciones : MonoBehaviour
{
    public void VolverAlInicio()
    {
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void SalirAplicacion()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
