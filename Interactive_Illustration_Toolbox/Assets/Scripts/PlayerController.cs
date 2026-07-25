using UnityEditor.Tilemaps;using UnityEngine;
public class PlayerController : MonoBehaviour{    private float moveSpeed = 4f;    private bool isFacingRight = true;    private SpriteRenderer spriteRenderer;    private Animator animator;    void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()    {
        movePlayer();

        float moveX = Input.GetAxis("Horizontal");

        if (moveX > 0 && !isFacingRight)        {            Flip();        }        else if (moveX < 0 && isFacingRight)        {            Flip();        }    }
    void movePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");

        animator.SetBool("isMoving", moveX != 0);

        Vector3 move = new Vector3(moveX, 0f);

        transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
    }

    void Flip()    {        isFacingRight = !isFacingRight;

        Vector3 scale = transform.localScale;        scale.x *= -1;        transform.localScale = scale;    }

}
