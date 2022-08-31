using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LastWaveTimer : MonoBehaviour
{
    public float timer = 60f;
    public Text timerCount;
    private int nextScene;

    // Start is called before the first frame update
    void Start()
    {
        timerCount = GameObject.Find("Timer").GetComponent<Text>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerCount.text = timer.ToString("0");
        if (timer <= 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
