using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseUpClicked : MonoBehaviour
{
    public bool DisableJump;
    public float DisableJumpTime,_time;
    // Start is called before the first frame update
    void Start()
    {
        DisableJumpTime = 0.5f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (DisableJump)
        {
            _time += Time.deltaTime;
            if (_time > DisableJumpTime)
            {
                DisableJump = false;
                _time = 0;
            }
        }
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&& this.gameObject.tag!="player")
        {
            MouseController.instance.setobj(this.gameObject);
        }
    }
}
