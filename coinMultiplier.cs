using UnityEngine;

public class coinMultiplier : MonoBehaviour
{
     public GameObject prefab,floor;
     public int numberofcubes=300;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int flag=1;
    for(int i=0;i<numberofcubes/2;i++)
    {
        flag=flag*-1;
        Vector3 position =new Vector3(floor.transform.position.x+flag,0.5f,i*5);
        GameObject newCoin= Instantiate(prefab, position, Quaternion.Euler(90,0,0));
        newCoin.tag="coins";
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

