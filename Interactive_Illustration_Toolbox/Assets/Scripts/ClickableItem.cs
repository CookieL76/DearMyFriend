using UnityEngine;

public class ClickableItem : MonoBehaviour
{
    [TextArea(4, 8)]
    public string description;

    public string title;

    void OnMouseDown()
    {
        Debug.Log("Instance: " + ItemInfoUI.Instance);

        ItemInfoUI.Instance.ShowInfo(title, description);
    }
}
