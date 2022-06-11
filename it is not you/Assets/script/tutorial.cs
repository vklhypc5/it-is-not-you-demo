using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutorial : MonoBehaviour
{
    public GameObject[] beforetutor;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlatformControll.instance.ControlObject != null)
        {
            foreach(GameObject obj in beforetutor)
            {
                obj.SetActive(false);
            }
            text.enabled = true;
        }
    }
}
