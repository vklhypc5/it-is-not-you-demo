using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phahuycungloai : MonoBehaviour
{
    // Start is called before the first frame update
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
            if (bx.type == mybox.type)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
