using UnityEngine;

public class CollectibleBone : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;

    void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);

        BoneManager.Instance.CollectBone();

        Destroy(gameObject);
    }
}
