using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadPoint : MonoBehaviour
{
    public int minlevel, maxlevel;
    public int point=0;
    public TextMeshProUGUI point_text;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = minlevel; i < maxlevel; i++)
        {
            if (PlayerPrefs.GetInt("level" + i) == 1)
            {
                point += 1;
            }
        }
        point_text.text = point.ToString() + "/" + SpawnLevelSelectButton.SceneCount; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
