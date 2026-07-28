using UnityEngine;

public class CollectibleBone : MonoBehaviour
{
    void OnMouseDown()
    {
        BoneManager.Instance.CollectBone();

        Destroy(gameObject);
    }
}
