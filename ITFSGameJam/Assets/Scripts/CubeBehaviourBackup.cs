using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviourBackup : MonoBehaviour
{
   // public GameObject[] PlantSpawner;
    public GameObject[] plantPrefab;
   // GameObject NextFlower;
    public NewFlowerGenerator FlowerGenerator;
    public int indexus;
    public int[] indexusArray = { 0, 1, 2, 3, 4, 5 };
    bool BlueBlock = false;
    bool OrangeBlock = false;

    private void Awake()
      {
        
        CubeOverview.Instance.cubeGrid[1, 0].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[1, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 0].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 0].cube.transform.position += new Vector3(0f, 0f, -3f);
        FlowerGenerator = GameObject.FindGameObjectWithTag("FlowerGenerator").GetComponent<NewFlowerGenerator>();

    }
    private void Start()
    {

        CubeOverview.Instance.cubeGrid[1, 0].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[1, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 1].cube.SetActive(true);
        CubeOverview.Instance.cubeGrid[0, 0].cube.SetActive(true);
        FlowerGenerator = GameObject.FindGameObjectWithTag("FlowerGenerator").GetComponent<NewFlowerGenerator>();
        FlowerGenerator.Increment();
        new MyPlant { plant = Instantiate(plantPrefab[2], new Vector3(0, 0, 0), Quaternion.identity) as GameObject };
    }
    public void OnMouseDown()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (j % 2 == 0)
                {

                    if (transform.position.y == (float)j && transform.position.x == (float)i)
                    {
                        FlowerGenerator = GameObject.FindGameObjectWithTag("FlowerGenerator").GetComponent<NewFlowerGenerator>();
                        //indexus = indexusArray[Random.Range(0, indexusArray.Length)];
                        new MyPlant { plant = Instantiate(plantPrefab[FlowerGenerator.index], new Vector3(i, j, 0), Quaternion.identity) as GameObject };


                        CubeOverview.Instance.cubeGrid[i, j].cube.transform.position += new Vector3(0f, 0f, -3f);
                        CubeOverview.Instance.cubeGrid[i, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i + 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j + 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i - 1, j - 1].cube.SetActive(true);
                        CubeOverview.Instance.cubeGrid[i, j - 1].cube.SetActive(true);

                        FlowerGenerator.Increment();
                        //if (OrangeBlock == false && FlowerGenerator.index != 1)
                        //{
                        //    Debug.Log("Orange is not overlapping with orange");
                        //}



                    }
                }
                if (j % 2 != 0)
                {
                        if (transform.position.y == (float)j && transform.position.x == (float)i + 0.5f)
                        {
                            CubeOverview.Instance.cubeGrid[i, j].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i + 1, j].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i + 1, j + 1].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i, j + 1].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i - 1, j + 1].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i - 1, j].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i - 1, j - 1].cube.SetActive(true);
                            CubeOverview.Instance.cubeGrid[i, j - 1].cube.SetActive(true);
                            // CubeOverview.Instance.cubeGrid[i, j].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i + 1, j].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i, j + 1].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i - 1, j + 1].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i - 1, j].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i - 1, j-1].cube.SetActive(true);
                            //CubeOverview.Instance.cubeGrid[i, j-1].cube.SetActive(true);
                            // indexus = indexusArray[Random.Range(0, indexusArray.Length)];
                            new MyPlant { plant = Instantiate(plantPrefab[FlowerGenerator.index], new Vector3(i + 0.5f, j, 0), Quaternion.identity) as GameObject };

                            CubeOverview.Instance.cubeGrid[i, j].cube.transform.position += new Vector3(0f, 0f, -3f);
                            FlowerGenerator.Increment();

                        }
                    
                }

            }
        }
    }


    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "Blue")
    //    {
    //        //Other ones= false;
    //        BlueBlock = true;
    //    }
    //    if(other.tag == "Orange")
    //    {
    //        //Other ones= false;
    //        OrangeBlock = true;
    //    }
    //}

    public class MyPlant
    {
        public GameObject plant;
    }
    public class PlaceableTile
    {
        public GameObject placeableTile;
    }
    public void NewFlower()
    {
       
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
