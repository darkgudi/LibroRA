using UnityEngine;

public class SalirApp : MonoBehaviour
{
    public void SalirAplicacion()
    {
        Application.Quit();

        // Este mensaje solo se ve en el editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
