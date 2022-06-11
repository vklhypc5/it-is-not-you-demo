using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public PlatformControll platformControll;
    public static MouseController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void setobj(GameObject obj)
    {
        platformControll.setobject(obj);
    }
}
