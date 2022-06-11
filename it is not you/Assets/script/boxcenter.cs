using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcenter : MonoBehaviour
{
    public GameObject[] boxs;
    public static boxcenter instance;
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
