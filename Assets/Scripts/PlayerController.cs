using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;

    public float jumpForce;
    public Rigidbody2D playerRb2d;
    public LayerMask groundLayer;
    
    private bool _isGrounded;
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        playerRb2d.linearVelocity = new Vector2(horMove*MoveSpeed, playerRb2d.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var hit = Physics2D.Raycast(transform.position, Vector2.down, 1,groundLayer);
            if(hit)
                playerRb2d.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
        }
    }
}