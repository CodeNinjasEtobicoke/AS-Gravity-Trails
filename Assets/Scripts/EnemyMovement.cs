using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    public float xForce;
    public float xDirection;

    public int maximunXPosition;
    public int minimunXPosition;

    private Rigidbody2D enemyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidbody.AddForce(jumpForce, ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "ThrowingObject")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x <= maximunXPosition)
        {
            xDirection = 1;
            Debug.Log("QAZWSXDEDC");
        }
        if (transform.position.x >= minimunXPosition)
        {
            xDirection = -1;
            Debug.Log("Quack");
        }
        //enemyRigidbody.AddForce(Vector2.right * xDirection * xForce);
    }
}
