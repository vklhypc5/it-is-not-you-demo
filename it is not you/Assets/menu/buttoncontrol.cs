using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttoncontrol : MonoBehaviour
{
    public int LevelOfThisButton;
    public GameObject starticon;
    private void OnEnable()
    {
        
        
    }
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene(LevelOfThisButton));
        Debug.Log("disable" + "////" + DataSystem.getkey(LevelOfThisButton));
        if (DataSystem.getkey(LevelOfThisButton) == 0)
        {
            this.GetComponent<Button>().interactable = false;
        }
        if (DataSystem.getkey(LevelOfThisButton) == 1)
        {
            //this.GetComponent<Image>().enabled = false;
            //this.GetComponent<Button>().interactable = false;
            starticon.SetActive(false);
        }
        if (LevelOfThisButton == 1)
        {
            this.GetComponent<Button>().interactable = true;
        }
    }
}
