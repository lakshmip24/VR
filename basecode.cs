using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour

{
    public Text scoreText;
    public Text lifeText;  // Reference to the UI Text
    private int score = 0; 
    private int life=3; // Variable to track score

    void Start()
    {
        scoreText.text = "Score: " + score;
        lifeText.text = "Life: " + life; // Initialize display
    }

    // Speed of player movement

    public float movementSpeed = 5f;


    void Update()

    {

        float horizontal = 0f;

        float vertical = 0f;



        // Movement with WASD keys

        if (Input.GetKey(KeyCode.A)) horizontal -= 1f;

        if (Input.GetKey(KeyCode.D)) horizontal += 1f;

        if (Input.GetKey(KeyCode.W)) vertical += 1f;

        if (Input.GetKey(KeyCode.S)) vertical -= 1f;



        // Move the player using Translate (X and Z axis)

        transform.Translate(new Vector3(horizontal, 0, vertical) * movementSpeed * Time.deltaTime);

        if (life <= 0)
             SceneManager.LoadScene("End");

    }



    // Called automatically when the player collides with another collider

    void OnCollisionEnter(Collision collision)

    {




        if (collision.gameObject.CompareTag("Enemy"))
        {

            Destroy(collision.gameObject);
            life-=1;
            lifeText.text = "Life: " + life;
        }
         if (collision.gameObject.CompareTag("Gud"))
        {
            score+=3;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);
        }

    }

}