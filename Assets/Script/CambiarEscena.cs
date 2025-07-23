using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void IrAPantallaInstrucciones()
    {
        SceneManager.LoadScene("PantallaInstrucciones");
    }

    public void IrAPantallaRA()
    {
        SceneManager.LoadScene("PantallaRA");
    }

    public void SalirAplicacion()
    {
        Application.Quit();
    }
}
