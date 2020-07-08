using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qBox : MonoBehaviour
{
	public enum brickTypes {qBox,brick}
	public brickTypes cBrick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void die()
	{
        if(cBrick == brickTypes.qBox)
		{
			cBrick = brickTypes.brick;
            // Make object
		}
	}


    void OnTriggerEnter2D(Collider2D col)
	{
        if(col.gameObject.tag == "Player")
		{
			//print("bop");
            if(cBrick == brickTypes.qBox)
			{
				die();
			}
		}
	}
}
