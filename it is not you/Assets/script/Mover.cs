using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 target;
    float speed;
    private Vector2 Speedd;
    // Start is called before the first frame update
    void Start()
    {
        Speedd = target - transform.position;
        Speedd = Speedd.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target) >= 1)
        {
            Vector3 pos = transform.position;
            pos.x += Speedd.x * Time.deltaTime;
            pos.y += Speedd.y * Time.deltaTime;
            transform.position = pos;
        }
    }
}
