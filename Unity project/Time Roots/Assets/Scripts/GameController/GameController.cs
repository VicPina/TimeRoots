using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// References: https://www.youtube.com/watch?v=KFpD7JQerb0
//
//
public class GameController : MonoBehaviour
{
    public string startScene;
    private void Awake()
    {
        // want the game controller to stay alive forever while game is running
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Initialize")
        {
            // TODO - replace with whatever our main game scene is 
            SceneManager.LoadScene(startScene);
        }
    }
}
