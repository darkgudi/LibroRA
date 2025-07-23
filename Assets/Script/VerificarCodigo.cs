using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VerificarCodigo : MonoBehaviour
{
    [Header("Referencias UI")]
    public TMP_InputField inputField;
    public GameObject panelError; // Panel de error que se muestra temporalmente

    [Header("Parámetros")]
    public string codigoCorrecto = "LIBRO123"; // Cambiá esto por tu código real
    public string nombreEscenaPrincipal = "PantallaPrincipal";
    public float duracionMensajeError = 2f; // Duración del mensaje de error

    public void Verificar()
    {
        if (inputField.text == codigoCorrecto)
        {
            // Guardar acceso permanente
            PlayerPrefs.SetInt("CodigoVerificado", 1);
            PlayerPrefs.Save();

            // Ir a la pantalla principal
            SceneManager.LoadScene(nombreEscenaPrincipal);
        }
        else
        {
            // Mostrar mensaje de error y limpiar input
            if (panelError != null)
            {
                panelError.SetActive(true);
                Invoke("OcultarPanelError", duracionMensajeError);
            }
            inputField.text = "";
        }
    }

    void OcultarPanelError()
    {
        if (panelError != null)
        {
            panelError.SetActive(false);
        }
    }
}

