using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGrid : MonoBehaviour
{
    int rows, columns;
    public MyCube[,] cubeGrid;
    //public MyStone[,] stonePlace;
    [SerializeField]
    GameObject cubePrefab;
    public float hexSize = 70;
    [SerializeField]
    GameObject StonePrefab;
    public int index = 10;
    static CubeOverview instance;
    public static CubeOverview Instance
    {
        get
        { return instance; }
    }
    // Start is called before the first frame update
    private void Awake()
    {
        //if (instance) Destroy(this);
        //else instance = this;
    }
    void Start()
    {
        rows = 12;
        columns = 12;
        cubeGrid = new MyCube[rows, columns];
        FillCubeGrid();
    }
    void FillCubeGrid()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                MakeCube(i, j);
            }
        }
       
    }
    void MakeCube(int i, int j)
    {
        if (j % 2 == 0)
        {
            cubeGrid[i, j] = new MyCube { cube = Instantiate(cubePrefab, new Vector3(i, j, -0.5f), Quaternion.identity) as GameObject };
            cubeGrid[i, j].cube.transform.localScale = Vector3.one * hexSize;
           // cubeGrid[i, j].cube.SetActive(false);
        }
        if (j % 2 != 0)
        {
            cubeGrid[i, j] = new MyCube { cube = Instantiate(cubePrefab, new Vector3(i + 0.5f, j, -0.5f), Quaternion.identity) as GameObject };
            cubeGrid[i, j].cube.transform.localScale = Vector3.one * hexSize;
         //   cubeGrid[i, j].cube.SetActive(false);
        }
    }
}
public class MyCube{

    public GameObject cube;
}
