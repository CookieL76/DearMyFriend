using UnityEngine;

public class ArrowTrigger : MonoBehaviour
{
    [SerializeField] private Collider2D arrowCollider;

    private void Start()
    {
        arrowCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            arrowCollider.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            arrowCollider.enabled = false;
        }
    }
}