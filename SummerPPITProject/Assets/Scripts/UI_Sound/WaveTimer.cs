using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WaveTimer : MonoBehaviour
{
    public float timer = 60f;
    public Text timerCount;
    private int nextScene;

    void Start()
    {
        timerCount= GameObject.Find("Timer").GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerCount.text = timer.ToString("0");
        if (timer<=0)
        {
            nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
        }
    }
}
