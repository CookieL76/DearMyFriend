using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    public string title;

    [TextArea(4, 8)]
    public string description;

    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        ItemInfoUI.Instance.ShowInfo(title, description);
    }
}