using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour
{
    private Rigidbody2D myRidgidBody;
    public float bunnyJumpForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        myRidgidBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            myRidgidBody.AddForce(transform.up * bunnyJumpForce);
        }
    }
}
