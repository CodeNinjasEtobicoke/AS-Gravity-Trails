using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    public GameObject avatar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("SDKGJHDSKLGH");
            avatarRigidbody.gravityScale *= -1;
            Vector3 newDirection = avatar.transform.localScale;
            newDirection.y *= -1;
            avatar.transform.localScale = newDirection;
        }
    }
}
