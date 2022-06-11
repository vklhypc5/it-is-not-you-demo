using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public bool IsLastScene;
    public GameObject[] endgames;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void _LoadNextLevel()
    {
        DataSystem.LevelComplete(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _LoadNextLevel();
        }
    }
}
