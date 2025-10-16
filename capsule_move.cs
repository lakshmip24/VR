/*using UnityEngine;
using UnityEngine.UI;

public class capsule_move : MonoBehaviour
{
    
    public float speed = 5f;
    public Transform camera;
    public Text scoretext; 
   

    void Start()
    {
       
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

       move +=transform.forward;

        if (Input.GetKey(KeyCode.D))
        {
            move +=transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move -=transform.right;
        }
        if(speed ==0)
        {
            return ;
        }
        score.increaseScore();
        Display();
        transform.position += (move.normalized * speed * Time.deltaTime); 
    }
    public void Display()
    {
        scoretext.text="Score:" +score.scoreboard;
    }
}
*/
using UnityEngine;
using UnityEngine.UI;

public class capsule_move : MonoBehaviour
{
    
    public float speed = 5f;
    public bool isJumping=false;
    public float jumpStart,jumpHeight=5f,jumpSpeed=5f;
    public Transform camera;
    public Text scoretext; 
    public GameObject gameover;
   

    void Start()
    {
      gameover.SetActive(false);
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

       move +=transform.forward;

        if (Input.GetKey(KeyCode.D))
        {
            move +=transform.right;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move -=transform.right;
        }
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position +=new Vector3(0,2,0);
        }*/
        /*correct method to jump because in another jump we r just 
        changing the position but the actual logic is that an upward facre shoud act on the body*/
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping=true;
            jumpStart= transform.position.y;
        }
        if(isJumping)
        {
            transform.position += Vector3.up * jumpSpeed *Time.deltaTime;
            if(transform.position.y >= jumpStart + jumpHeight)
            {
                isJumping=false;
            }
        }
        if(speed ==0)
        {
            gameover.SetActive(true);
            return ;
        }
        score.increaseScore();
        Display();
        transform.position += (move.normalized * speed * Time.deltaTime); 
    }
    public void Display()
    {
        scoretext.text="Score:" +score.scoreboard;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("cubes"))
        {
             Debug.Log("Collision Occured");
             speed=0f;
        }
    }

}
