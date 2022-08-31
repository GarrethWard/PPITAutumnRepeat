using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("Enemy") || col.gameObject.CompareTag("Enemy2"))
        {

            Health.health--;
            if (Health.health <= 0)
            {
                SceneManager.LoadScene("Defeated");
                Health.health = 5;
            }
        }
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
