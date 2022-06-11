using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samejump : box
{
    public GameObject[] sameobj;
    public Rigidbody2D[] samebd;
    private Rigidbody2D ownbd;

    // Start is called before the first frame update
    private void Awake()
    {
        sameobj = new GameObject[10];
        samebd = new Rigidbody2D[10];
        this.gameObject.tag = this.type;

    }
    void Start()
    {
        ownbd = GetComponent<Rigidbody2D>();
        sameobj = GameObject.FindGameObjectsWithTag(this.type);
        for (int i = 0; i < sameobj.Length; i++)
        {
            samebd[i] = sameobj[i].GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlatformControll.instance.ControlObject == this.gameObject)
        {
            foreach (Rigidbody2D rig in samebd)
            {
                if (rig != null && rig != ownbd)
                {
                    if (ownbd.velocity.y > 0.1f)
                    {
                        rig.velocity = new Vector2(rig.velocity.x, ownbd.velocity.y);
                    }
                    
                }
            }
        }
    }
    void findsameobj()
    {
        sameobj = GameObject.FindGameObjectsWithTag(type);
        for (int i = 0; i < sameobj.Length; i++)
        {
            samebd[i] = sameobj[i].GetComponent<Rigidbody2D>();
        }
    }
    public void OnMouseOver()
    {
        base.OnMouseOver();
        findsameobj();

    }
}
