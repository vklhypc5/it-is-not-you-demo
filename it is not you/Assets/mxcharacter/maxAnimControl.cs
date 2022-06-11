using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxAnimControl : MonoBehaviour
{
    public mx_anim mx_Anim;
    public Rigidbody2D mybd;
    private Collider2D _collider;
    public float side;
    // Start is called before the first frame update
    void Start()
    {
        mybd = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mx_Anim.velocity_x = mybd.velocity.x;
        mx_Anim.velocity_y = mybd.velocity.y;
        mx_Anim.IsAir = !_GroundCheck();
        mx_Anim.SomeThingAbove = _PhiaTruoc();
    }
    bool _GroundCheck()
    {
        side = _collider.bounds.size.y + 1f;
        Vector3 pos1 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
        Vector3 pos2 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
        pos1.x += (_collider.bounds.size.x / 2) + 0.1f;
        pos2.x -= (_collider.bounds.size.x / 2) + 0.1f;
        if (Physics2D.Raycast(pos2, Vector2.down, side / 2) || Physics2D.Raycast(pos1, Vector2.down, side / 2) || Physics2D.Raycast(_collider.bounds.center, Vector2.down, side / 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    bool _PhiaTruoc()
    {
        side = _collider.bounds.size.x + 0.6f;
        if (mx_Anim.FaceRight)
        {
            if (Physics2D.Raycast(_collider.bounds.center, Vector2.right, side / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (Physics2D.Raycast(_collider.bounds.center, Vector2.left, side / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
