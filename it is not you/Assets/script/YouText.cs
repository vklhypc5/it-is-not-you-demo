using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouText : MonoBehaviour
{
    public GameObject Controlingobj;
    public static YouText instance;
    private Collider2D col;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controlingobj)
        {
            transform.position = col.bounds.center + new Vector3(0, (col.bounds.size.y + 1f) / 2, 0);
        }
        else
        {
            transform.position = new Vector3(99, 99, 0);
        }
    }
    public void setcontrolobj(GameObject obj)
    {
        Controlingobj = obj;
        col = obj.GetComponent<Collider2D>();
    }
}
