using UnityEngine;
using UnityEngine.SceneManagement;

public class ComprobarCodigoGuardado : MonoBehaviour
{
    public string nombreEscenaPrincipal = "PantallaPrincipal";

    void Start()
    {
        if (PlayerPrefs.GetInt("CodigoVerificado", 0) == 1)
        {
            // Si el código ya fue verificado antes, cargar la escena principal
            SceneManager.LoadScene(nombreEscenaPrincipal);
        }
    }
}
