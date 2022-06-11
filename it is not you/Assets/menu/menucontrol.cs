using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontrol : MonoBehaviour
{
    public GameObject LevelSelectPanel;
    public GameObject PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlayButtonClick()
    {
        if (LevelSelectPanel.activeInHierarchy)
        {
            LevelSelectPanel.SetActive(false);
        }
        else
        {
            LevelSelectPanel.SetActive(true);
            PlayButton.SetActive(false);
        }
    }
}
