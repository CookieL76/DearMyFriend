using TMPro;
using UnityEngine;

public class ItemInfoUI : MonoBehaviour
{
    public static ItemInfoUI Instance;

    [SerializeField] private GameObject panel;
    [SerializeField] private TMP_Text titleText;
    [SerializeField] private TMP_Text descriptionText;

    void Awake()
    {
        Instance = this;

        Debug.Log("ItemInfoUI Awake wurde ausgeführt.");
    }

    public void ShowInfo(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;

        panel.SetActive(true);
    }

    public void HideInfo()
    {
        panel.SetActive(false);
    }
}
