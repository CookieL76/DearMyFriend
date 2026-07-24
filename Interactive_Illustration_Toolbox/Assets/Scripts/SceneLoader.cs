using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Object sceneAsset; // drag your .unity scene file here
    [SerializeField] private string sceneName;  // auto-filled, don't edit manually

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (sceneAsset != null)
            sceneName = sceneAsset.name;
    }
#endif
}