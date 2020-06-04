using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBricks : MonoBehaviour
{
    
    public GameObject brick;
    public GameObject scoreText;

    private Object[] brickArray;
    private int brickScore = 100;

    void Start()
    {
        int depth_size = 2;
        int row_size = 5;
        int column_size = 4;
        brickArray = new Object[depth_size * row_size * column_size];
        for(int d = 0; d < depth_size; d++)
        {
            for(int r = 0; r < row_size; r++)
            {
                for(int c = 0; c < column_size; c++)
                {
                    float width = brick.transform.localScale.x;
                    float height = brick.transform.localScale.y;
                    float depth = brick.transform.localScale.z;
                    var newBrick = Instantiate(brick, 
                        new Vector3(transform.position.x + width * c, 
                                    transform.position.y + height * r,
                                    transform.position.z + depth * d), Quaternion.identity);
                    newBrick.transform.parent = gameObject.transform;
                    newBrick.GetComponent<Brick>().numberOfHitsLeft = d+1;//Random.Range(1, 6);
                    brickArray[d * row_size * column_size + r * column_size + c] = newBrick;
                }
            }
        }
    }

    void Update()
    {
        int numOfDestoryed = 0;
        foreach( Object o in brickArray)
        {
            if(o == null){
                numOfDestoryed++;
            }
        }
        if(numOfDestoryed == brickArray.Length)
        {
            Debug.Log("Game Over");
        }

        scoreText.GetComponent<UnityEngine.UI.Text>().text = (numOfDestoryed * brickScore).ToString();
    }
}
