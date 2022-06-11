using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mx_anim : MonoBehaviour
{
    public float velocity_x, velocity_y;
    public bool FaceRight, SomeThingAbove,IsAir;
    public Animator anim;
    public Vector3 oriscale;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        oriscale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (velocity_x > 0.5)
        {
            FaceRight = true;
        }
        if (velocity_x < -0.5)
        {
            FaceRight = false;
        }
        setanimvar();
    }
    void setanimvar()
    {
        anim.SetFloat("velocityx", Mathf.Abs(velocity_x));
        anim.SetFloat("velocityy", Mathf.Abs(velocity_y));
        anim.SetBool("PhiaTruoc", SomeThingAbove);
        anim.SetBool("isair",IsAir);
        if (FaceRight)
        {
            transform.localScale = oriscale;
        }
        else
        {
            transform.localScale = new Vector3(-oriscale.x, oriscale.y, oriscale.z);
        }
    }

}
