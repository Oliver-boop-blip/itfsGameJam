using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public GameObject plantPrefab;
    private void Start()
    {
        new MyPlant { plant = Instantiate(plantPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject };
        CubeOverview.Instance.cubeGrid[1, 0].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[1, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 0].cube.SetActive(true);
       
    }
    private void OnMouseDown()
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                if (j % 2 == 0)
                {
                    if (transform.position.y == (float)j && transform.position.x == (float)i)
                    {
                        new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i, j, 0), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i + 1, j, 1), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i + 0.5f, j + 1, 1), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i - 0.5f, j + 1, 1), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i - 1, j, 1), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i - 0.5f, j - 1, 1), Quaternion.identity) as GameObject };
                        //new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i + 0.5f, j - 1, 1), Quaternion.identity) as GameObject };
                        CubeOverview.Instance.cubeGrid[i, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i + 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j-1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j-1].cube.SetActive(true);
                        //  Debug.Log("Test");
                    }
                }
                if (j % 2 != 0)
                {
                    if (transform.position.y == (float)j && transform.position.x == (float)i+0.5f)
                    {
                        
                        CubeOverview.Instance.cubeGrid[i + 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j - 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j - 1].cube.SetActive(true);
                        new MyPlant { plant = Instantiate(plantPrefab, new Vector3(i+0.5f, j, 0), Quaternion.identity) as GameObject };
                        CubeOverview.Instance.cubeGrid[i, j].cube.transform.position += new Vector3(0f, 0f, -3f);
                     //   Debug.Log("Test");
                    }
                }
            }
            
        }
    }
    public class MyPlant
    {
        public GameObject plant;
    }
    public class PlaceableTile
    {
        public GameObject placeableTile;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
