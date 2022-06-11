using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class box : OnMouseUpClicked
{
    public float size;
    public string type;
    public JumpAnimation anim;

    private void Awake()
    {
        this.gameObject.AddComponent<JumpAnimation>();
        anim = GetComponent<JumpAnimation>();
    }
    private void Update()
    {
        
    }
}
