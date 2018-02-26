using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    Rigidbody2D rb;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(rb.velocity.y < 0)
        {
            rb.velocity += Physics2D.gravity * (fallMultiplier - 1f) * Time.deltaTime;
        } else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
	}
}
