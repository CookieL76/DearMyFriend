using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitGameButton()
    {
        Debug.Log("Spiel wird geschlossen.");

        Application.Quit();
    }
}
