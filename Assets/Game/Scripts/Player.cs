using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower = 500;
    public float speed = 5;
    public float rotationSpeed;
    public Rigidbody playerRigidody;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    void Update()
    {
        Jump();
        Move();
        Rotate();
        Attack();
    }

    private void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        }
    }

    private void Rotate()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontalInput*rotationSpeed);
    }

    private void Move()
    {
        var verticalMove = Input.GetAxis("Vertical");
        playerRigidody.linearVelocity = transform.forward*verticalMove * speed;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            playerRigidody.AddForce(Vector3.up * jumpPower);
    }
    
}