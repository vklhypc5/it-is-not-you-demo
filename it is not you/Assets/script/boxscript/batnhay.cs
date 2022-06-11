using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batnhay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*gameinfo.jumpforce*1.3f);
        if(collision.gameObject.TryGetComponent(out OnMouseUpClicked _check))
        {
            _check.DisableJump = true;
        }
    }
}
