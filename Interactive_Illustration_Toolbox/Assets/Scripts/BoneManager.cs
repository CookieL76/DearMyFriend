using UnityEngine;
using UnityEngine.UI;

public class BoneManager : MonoBehaviour
{
    public static BoneManager Instance;

    [SerializeField] private Image[] boneImages;
    [SerializeField] private Animator endAnimator;

    private int collectedBones = 0;
    
    void Awake()
    {
        Instance = this;

        foreach (Image bone in boneImages)
        {
            Color c = bone.color;
            c.a = 0.2f;
            bone.color = c;
        }
    }

    public void CollectBone()
    {
        if (collectedBones >= boneImages.Length)
            return;

        Color c = boneImages[collectedBones].color;
        c.a = 1f;
        boneImages[collectedBones].color = c;

        collectedBones++;

        if (collectedBones == boneImages.Length)
        {
            Debug.Log("Alle Knochen gefunden!");

            endAnimator.SetTrigger("AllBonesCollected");
        }
    }
}
