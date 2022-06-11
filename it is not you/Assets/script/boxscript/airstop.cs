using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airstop : MonoBehaviour
{
    public float delaytime;
    private Rigidbody2D mybd;
    private bool isjump,isairstop;
    private IEnumerator coroutine;
    // Start is called before the first frame update
    void Start()
    {
        mybd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mybd.velocity.y>2.5 && !isjump)
        {
            isjump = true;
        }
        if (mybd.velocity.y < -0.05 && isjump)
        {
            isairstop = true;
        }
        if (isairstop)
        {
            mybd.constraints = RigidbodyConstraints2D.FreezeAll;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isairstop)
        {
            coroutine = WaitAndDrop(delaytime);
            StartCoroutine(coroutine);
        }
    }
    private IEnumerator WaitAndDrop(float waitTime)
    {
        Debug.Log("unfree");
        yield return new WaitForSeconds(waitTime);
        mybd.constraints = RigidbodyConstraints2D.None;
        mybd.constraints = RigidbodyConstraints2D.FreezeRotation;
        isairstop = false;
        isjump = false;
        if (mybd.gravityScale == 1)
        {
            mybd.gravityScale = 1.001f;
        }
        if (mybd.gravityScale == 1.001f)
        {
            mybd.gravityScale = 1;
        }

    }
}
