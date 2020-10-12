using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getScore : MonoBehaviour
{
    public Text countText;
    private int score;

    void Start()
    {
        score = 0;

        SetCountText();
    }


    public void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag.ToString());
        if (other.gameObject.tag == "coin")
        {
           
            score = score + 1;
            
            SetCountText();

           



        }
     
    }

    void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
    }
}


