using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    float jump =0;
    public float jumpSpeed = 4.3f;
    float jumpTimer = 0;

    

	void Start () {
        
	}


    void Update()
    {
        //var pos = this.transform.position;
        //pos.x += 1f * Time.deltaTime;
        //this.transform.position = pos;
        this.transform.Translate(
            Vector2.right * 1.5f * Time.deltaTime
            );

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    this.transform.Translate(
        //    Vector2.up * 9f * Time.deltaTime
        //    );

        //}
        if (jump == 1)
        {
            jumpTimer = jumpTimer + 1.73f;
            if (jumpTimer >= 85)
            {
                jumpTimer = 0;
                jump = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jump == 0)
            {
                var vel = GetComponent<Rigidbody2D>().velocity;
                vel.y = jumpSpeed;
                GetComponent<Rigidbody2D>().velocity = vel;
                //rigidbody2D.velocity.y = jumpSpeed;
                jump = 1;
                
            }
            
        }

    }
}
