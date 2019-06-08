using UnityEngine;
using System.Collections;
using System.Collections.Generic;       //Allows us to use Lists. 
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;
    public int TrackNumber = 0;
    public int Obstacle_number = 20;

    private GameObject Canvas;


    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    public void PlayerDied()
    {
        //Debug.Log("You died!");

        Canvas = GameObject.Find("Canvas");
        //Debug.Log(Canvas.transform.GetChild(0).gameObject.activeSelf.ToString());
        Canvas.transform.GetChild(0).gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        TrackNumber = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
}