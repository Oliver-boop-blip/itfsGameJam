using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    private void OnMouseDown()
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (transform.position.y == (float)j && transform.position.x ==(float)i)
                {
                    CubeOverview.Instance.cubeGrid[i, j].cube.transform.position += new Vector3(0f, 0f, -3f);
                }
            }
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
