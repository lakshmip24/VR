using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
    int score=0;
    int turn=0;
    Rigidbody rb;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
        rb = GetComponent<Rigidbody>();
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.0f, 0.0f, -0.01f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.0f, 0.0f, 0.01f);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {

            
            rb.isKinematic = false;
             rb.velocity = transform.right * 5;
             rb.useGravity = false;
             rb.freezeRotation = true;
             turn=turn+1;
             Debug.Log("Turn: " + turn);
        }
        if(rb.position.x>1.0f)
        {
            rb.isKinematic = true;
            rb.position = new Vector3(-11.12f, 1.295f, -1.45f);
        }
    }
   void OnCollisionEnter(Collision collision)
{
    
    if (collision.gameObject.CompareTag("sphere"))
    {
        Destroy(collision.gameObject);
        score += 1;
        Debug.Log("Score: " + score);
        UpdateScoreText();
        if(turn<55)
        {
            rb.isKinematic = true;
            rb.position = new Vector3(-11.12f, 1.295f, -1.45f);
           
        }
        
        if (score == 3)
        {
            // Load scene named "2"
            UnityEngine.SceneManagement.SceneManager.LoadScene("2");
        }
        
    }
    

}
void UpdateScoreText()
    {
        if(scoreText != null)
        scoreText.text = "Score: " + score;
    }

}