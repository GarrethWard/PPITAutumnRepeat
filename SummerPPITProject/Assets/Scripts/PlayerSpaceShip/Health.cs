using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{


    public static int health = 5;
     public int numOfHearts = 5;

    // Start is called before the first frame update
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    void Update()
    {
        if (health > numOfHearts)
         {
             health = numOfHearts;
         }

        foreach (Image image in hearts)
        {
            image.sprite = emptyHeart;
        }
        for (int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }

    }
}
