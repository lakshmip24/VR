using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawning : MonoBehaviour
{
     public GameObject coin,floor;
    
    // Start is called before the first frame update
    void Start()
    {
        int numberOfRows = 3;
int coinsInEachRow = 10;
float rowSpacing =4.0f;
float coinSpacing = 5.0f;

float xOffset = (numberOfRows - 1) * rowSpacing / 2.0f;

for (int row = 0; row < numberOfRows; row++)
{
    for (int i = 0; i < coinsInEachRow; i++)
    {
        float xPos = floor.transform.position.x + (row * rowSpacing) - xOffset;
        float yPos = 0.5f;
        float zPos = i * coinSpacing;
        // Or: float zPos = floor.transform.position.z + (i * coinSpacing);

        Vector3 position = new Vector3(xPos, yPos, zPos);

        GameObject newCoin = Instantiate(coin, position, Quaternion.Euler(90, 0, 0));
        newCoin.tag = "coins";
    }
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


