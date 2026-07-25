using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void MemoriesNeverFade()
    {
        SceneManager.LoadSceneAsync("SandwichMaking");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}