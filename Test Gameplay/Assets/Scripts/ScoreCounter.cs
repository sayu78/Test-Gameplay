using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public Text text;
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ball")
        {
            FindObjectOfType<Score>().score++;
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        score = FindObjectOfType<Score>().score;
        text.text = "Score : " + score;   
    }
}
