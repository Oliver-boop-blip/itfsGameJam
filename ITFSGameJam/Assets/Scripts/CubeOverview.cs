using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOverview : MonoBehaviour
{
    int rows, columns;
    public MyCube[,] cubeGrid;
    public MyStone[,] stonePlace;
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
        if (instance) Destroy(this);
        else instance = this;
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
       // MakeStone(1, 2);
    }
    void MakeCube(int i, int j)
    {
        if (j % 2 == 0)
        {
            cubeGrid[i, j] = new MyCube { cube = Instantiate(cubePrefab, new Vector3(i, j, 0), Quaternion.identity) as GameObject };
            cubeGrid[i, j].cube.transform.localScale = Vector3.one * hexSize;
            cubeGrid[i, j].cube.SetActive(false);
        }
        if (j % 2 != 0)
        {
            cubeGrid[i, j] = new MyCube { cube = Instantiate(cubePrefab, new Vector3(i + 0.5f, j, 0), Quaternion.identity) as GameObject };
            cubeGrid[i, j].cube.transform.localScale = Vector3.one * hexSize;
            cubeGrid[i, j].cube.SetActive(false);
        }
    }
    void MakeStone(int i, int j)
    {
        stonePlace[i, j] = new MyStone { stone = Instantiate(StonePrefab, new Vector3(i, j, 1), Quaternion.identity) as GameObject };
        stonePlace[i, j].stone.transform.localScale = Vector3.one * 0.5f;
    }
    private void OnMouseDown()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 == 0)
                {
                    if (transform.position.y == (float)j && transform.position.x == (float)i)
                    {
                        MakeStone(i, j);
                    }
                }
                if (j % 2 != 0)
                {
                    if (transform.position.y == (float)j && transform.position.x == (float)i + 0.5f)
                    {
                        MakeStone(i, j);
                    }
                }
            }

        }
      
    }
    // Update is called once per frame
    public void Update()
    {
        
    }
    public class MyCube
    {
        public int index;
        public GameObject cube;
    }
    public class MyStone
    {
        public GameObject stone;
    }
}