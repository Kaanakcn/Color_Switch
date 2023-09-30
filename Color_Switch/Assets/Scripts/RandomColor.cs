using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomColor : MonoBehaviour
{

    public SpriteRenderer colorTone;

    public Color cyanC , yellowC , pinkC , purpleC;
    public string currentColor;
    

    void Start()
    {
        RandomChangeColor();
    }

    void OnTriggerEnter2D(Collider2D touch)
    {
        if (touch.tag != currentColor)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    } 
    private void RandomChangeColor()
    {

        int randomNumber = Random.Range(0, 4);

        switch (randomNumber){
            case 0:
                currentColor = "cyan";
                colorTone.color = cyanC;
                break;
            case 1:
                currentColor = "yellow";
                colorTone.color = yellowC;
                break;
            case 2:
                currentColor = "pink";
                colorTone.color = pinkC;
                break;
            case 3:
                currentColor = "purple";
                colorTone.color = purpleC;
                break;
        }
    }
    
}
