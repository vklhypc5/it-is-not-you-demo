using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject realout,restart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onfakeoutclicked()
    {
        if (realout.activeInHierarchy)
        {
            realout.SetActive(false);
            restart.SetActive(false);
        }
        else
        {
            realout.SetActive(true);
            restart.SetActive(true);
        }
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Resetlv()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void jumptolv5()
    {
        SceneManager.LoadScene(4);
    }
    public void jumptolv7()
    {
        SceneManager.LoadScene(6);
    }
}
