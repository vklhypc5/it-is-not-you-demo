using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : MonoBehaviour
{
    public Vector3 OriScale, Scale,EndScale;
    public float begin=.15f, end=.25f,time,TotalTime;
    public bool IsJump;
    public Rigidbody2D mybd;
    // Start is called before the first frame update
    void Start()
    {
        TotalTime = begin + end;
        OriScale = this.gameObject.transform.localScale;
        EndScale=new Vector3(.75f, 1.15f, 1);
        mybd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mybd.velocity.y > 5)
        {
            Jump();
        }
        if (IsJump)
        {
            if (time > TotalTime)
            {
                IsJump = false;
                time = 0;
            }
            time += 1 * Time.deltaTime;
            if (time < begin)
            {
                Scale.x = OriScale.x * (1 + (time / begin) * (EndScale.x - 1));
                Scale.y = OriScale.y * (1 + (time / begin) * (EndScale.y - 1));
                Scale.z = 1;
                transform.localScale = Scale;
            }
            else
            {
                Scale.x = OriScale.x * (EndScale.x + ((time-begin) / end) * (1-EndScale.x));
                Scale.y = OriScale.y * (EndScale.y + ((time - begin) / end) * (1-EndScale.y));
                Scale.z = 1;
                transform.localScale = Scale;
            }
            
        }
    }
    public void Jump()
    {
        IsJump = true;
    }
}
