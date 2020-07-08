using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Speed
	public float speedMult;

	Vector2 cVec;

	Rigidbody2D rb;

	public float jumpForce;


    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
		if (Input.GetAxisRaw("Horizontal")!=0)
		{
			rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speedMult, rb.velocity.y);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.velocity += new Vector2(0, jumpForce);
		}
    }



}
