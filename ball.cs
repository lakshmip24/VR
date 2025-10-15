using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    int score=0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    
        
         void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sphere"))
        {
            Destroy(collision.gameObject);
            score=score+1;
            Debug.Log("Score: "+score);
             UpdateScoreText();
             if(score==2)
             {
                SceneManager.LoadScene("2");
             }

        }
    }
    void UpdateScoreText()
    {
        if(scoreText != null)
        scoreText.text = "Score: " + score;
    }
}
    

