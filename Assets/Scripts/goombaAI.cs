using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombaAI : MonoBehaviour
{
	public enum enemies {goomba, gShell}
	public enemies cEnemy;

	public Sprite[] eSprites;

	public enum states {moveLeft, moveRight};
	states cState = states.moveLeft;

	public float speed;

	Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
        if(cEnemy == enemies.goomba)
		{
			GetComponent<SpriteRenderer>().sprite = eSprites[0];
		} else if(cEnemy == enemies.gShell)
		{
			GetComponent<SpriteRenderer>().sprite = eSprites[1];
		}
    }

    // Update is called once per frame
    void Update()
    {
        if(cEnemy == enemies.goomba)
		{
            if(cState == states.moveLeft)
			{
				rb.velocity = new Vector2(-speed, rb.velocity.y);
			} else if(cState == states.moveRight)
			{
				rb.velocity = new Vector2(speed, rb.velocity.y);
			}
		} else if(cEnemy == enemies.gShell)
		{
			if (cState == states.moveLeft)
			{
				rb.velocity = new Vector2(-speed, rb.velocity.y);
			}
			else if (cState == states.moveRight)
			{
				rb.velocity = new Vector2(speed, rb.velocity.y);
			}
		}
    }

    public void die()
	{
        if(cEnemy == enemies.goomba)
		{
			Destroy(this.gameObject);
		} else if(cEnemy == enemies.gShell)
		{
			// make shell
			Destroy(this.gameObject);
		}
	}


    void OnCollisionEnter2D(Collision2D col)
	{
	}

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Ground")
		{
            if(cEnemy == enemies.goomba || cEnemy == enemies.gShell)
			{
				if (cState == states.moveLeft)
				{
					cState = states.moveRight;
				}
				else if (cState == states.moveRight)
				{
					cState = states.moveLeft;
				}
			}
			
		}
	}


}
