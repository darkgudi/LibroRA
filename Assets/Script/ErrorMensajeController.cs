using System.Collections;
using UnityEngine;
using TMPro;

public class ErrorMensajeController : MonoBehaviour
{
    public GameObject panelError;         // Panel que se activa al fallar
    public TMP_InputField inputCodigo;    // Campo de ingreso de código
    public float duracion = 2f;           // Tiempo que el mensaje se mostrará

    public void MostrarMensajeError()
    {
        panelError.SetActive(true);           // Muestra el panel
        StartCoroutine(DesactivarMensaje());  // Inicia temporizador
    }

    private IEnumerator DesactivarMensaje()
    {
        yield return new WaitForSeconds(duracion);
        panelError.SetActive(false);         // Oculta el panel
        inputCodigo.text = "";               // Limpia el campo de texto
    }
}
