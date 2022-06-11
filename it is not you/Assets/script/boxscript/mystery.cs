using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mystery : MonoBehaviour
{
    private box mybox;
    // Start is called before the first frame update
    void Start()
    {
        mybox = GetComponent<box>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<box>(out box bx))
        {
            foreach(GameObject obj in boxcenter.instance.boxs)
            {
                box obj_box = obj.GetComponent<box>();
                if (bx.type == obj_box.type && obj_box.size == mybox.size && bx.type!=mybox.type) 
                {
                    Instantiate(obj, transform.position, Quaternion.identity);
                    Destroy(this.gameObject);
                } 
            }
        }
    }
}
