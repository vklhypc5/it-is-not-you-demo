using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDataForCurrentScene : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void load()
    {
        string SceneKey = "level" + SceneManager.GetActiveScene().buildIndex;
        
        if (PlayerPrefs.GetInt(SceneKey) == 1)
        {
            leveliscomplete();
            Debug.Log(SceneKey);
        }
        
    }
    void leveliscomplete()
    {
        player.SetActive(false);
    }
}
