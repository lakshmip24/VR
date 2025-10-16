using UnityEngine;

public class camera : MonoBehaviour
{
    public int val;
    public GameObject game;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         val = 0;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.V))
        {
            val = (val + 1) % 3;
        }

        if (val == 2)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            transform.position = game.transform.position;
        }
        else if (val == 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
            transform.position = game.transform.position - new Vector3(0, 0, 10);
        }
        else if (val ==1)
        {
            transform.position = game.transform.position + new Vector3(0, 10, 0);
            transform.rotation = Quaternion.Euler(90,0,0);
        }
        Vector3 move = game.transform.forward;
        game.transform.position += (move.normalized * speed * Time.deltaTime); 
     
    }
}