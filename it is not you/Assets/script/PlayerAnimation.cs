using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D mybd;
    private Vector3 startscale;
    // Start is called before the first frame update
    void Start()
    {
        startscale = transform.localScale;
        anim = GetComponent<Animator>();
        mybd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mybd.velocity.x < -0.1)
        {
            transform.localScale = new Vector3(-startscale.x, startscale.y, startscale.z);
        }
        if (mybd.velocity.x > 0.1)
        {
            transform.localScale = new Vector3(startscale.x, startscale.y, startscale.z);
        }
        if (mybd.velocity.y > 0.1)
        {
            anim.Play("jump");
        }else
        if (mybd.velocity.y < -0.1)
        {
            anim.Play("fall");
        }
        else
        {
            anim.Play("idle");
        }
    }
}
