using UnityEngine;

public class ArrowTrigger : MonoBehaviour
{
    [SerializeField] private Collider2D arrowCollider;
    [SerializeField] private SpriteRenderer arrowSprite;

    private void Start()
    {
        arrowCollider.enabled = false;

        Color color = arrowSprite.color;
        color.a = 0.3f;
        arrowSprite.color = color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            arrowCollider.enabled = true;

            Color color = arrowSprite.color;
            color.a = 1f;
            arrowSprite.color = color;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            arrowCollider.enabled = false;

            Color color = arrowSprite.color;
            color.a = 0.3f;
            arrowSprite.color = color;
        }
    }
}