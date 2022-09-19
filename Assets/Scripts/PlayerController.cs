using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed; // can be adjust in editor
    public Rigidbody2D theRB;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed*Input.GetAxis("Horizontal"),theRB.velocity.y);
        if (Input.GetButtonUp("Jump"))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
        }
    }
}
