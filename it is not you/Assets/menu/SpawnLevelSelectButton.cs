using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SpawnLevelSelectButton : MonoBehaviour
{
    public Sprite[] Sprites;
    public Sprite unlocked;
    public static int SceneCount=60,ScenePerLine=12;
    public GameObject LevelButton;
    // Start is called before the first frame update
    private void OnEnable()
    {
        
        //DataSystem.setkey(0, 2);
        for (int i = 0; i < SceneCount; i++){
            GameObject button = Instantiate(LevelButton, this.gameObject.transform);
            button.GetComponent<Image>().sprite = Sprites[i];
            button.GetComponent<buttoncontrol>().LevelOfThisButton=i+1;
            //Debug.Log(DataSystem.getkey(i)+":"+i);
        }
        
    }
}
