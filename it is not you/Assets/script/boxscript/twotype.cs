using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twotype : MonoBehaviour
{
    public Sprite Died, NotDie;
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlatformControll.instance.ControlObject == this.gameObject)
        {
            SetNotDieBox();
        }
        else
        {
            SetDieBox();
        }
    }
    void SetDieBox()
    {
        this.gameObject.tag = "destroy";
        sprite.sprite = Died;

    }
    void SetNotDieBox()
    {
        this.gameObject.tag = "Untagged";
        sprite.sprite = NotDie;
    }
}
