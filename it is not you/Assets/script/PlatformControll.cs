using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControll : MonoBehaviour
{
    public GameObject ControlObject,YouObject;
    private float side;
    public float speed,jumpforce;
    private Collider2D _collider;
    private Rigidbody2D _rigidbody2D;
    public OnMouseUpClicked _onMouseUpClicked;
    public bool h;
    public Vector3 p1, p2;
    public static PlatformControll instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
        if (ControlObject)
        {
            setobject(ControlObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody2D)
        {
            float x = Input.GetAxis("Horizontal");
            _rigidbody2D.velocity = new Vector2(speed * x, _rigidbody2D.velocity.y);
            if (Input.GetKeyDown(KeyCode.W) && _GroundCheck()&& !_onMouseUpClicked.DisableJump)
            {
                _rigidbody2D.AddForce(Vector2.up * (jumpforce));
            }
        }
        if (_collider)
        {
            p1 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
            p2 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
            p1.x += (_collider.bounds.size.x / 2) - 0.1f;
            p2.x -= (_collider.bounds.size.x / 2) - 0.1f;
            p1.z = _collider.bounds.size.y;
        }
    }
    bool _GroundCheck()
    {
        side = _collider.bounds.size.y + 1f;
        Vector3 pos1 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
        Vector3 pos2 = new Vector3(_collider.bounds.center.x, _collider.bounds.center.y, _collider.bounds.center.z);
        pos1.x += (_collider.bounds.size.x / 2);
        pos2.x -= (_collider.bounds.size.x / 2);
        if (Physics2D.Raycast(pos2, Vector2.down, side / 2) || Physics2D.Raycast(pos1, Vector2.down, side / 2) || Physics2D.Raycast(_collider.bounds.center, Vector2.down, side / 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void setobject(GameObject obj)
    {
        ControlObject = obj;
        _collider = obj.GetComponent<Collider2D>();
        _rigidbody2D = obj.GetComponent<Rigidbody2D>();
        _onMouseUpClicked = obj.GetComponent<OnMouseUpClicked>();
        YouText.instance.setcontrolobj(obj);
    }
}
