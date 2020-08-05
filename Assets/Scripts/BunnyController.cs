using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
    }
}
