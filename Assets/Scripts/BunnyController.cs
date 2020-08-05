using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour
{
    private Rigidbody2D myRidgidBody;
    private Animator myAnim;

    public float bunnyJumpForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        myRidgidBody = this.GetComponent<Rigidbody2D>();
        myAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            myRidgidBody.AddForce(transform.up * bunnyJumpForce);

        }
        myAnim.SetFloat("vVelocity", myRidgidBody.velocity.y);
    }
}
