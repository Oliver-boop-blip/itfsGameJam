using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewFlowerGenerator : MonoBehaviour
{
    
    public int index = 0;
    public int[] indexArray = { 0, 1, 2, 3, 4, 5, 6 };
    public Text Textfield;
    public int Score = 10;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Score = 10;
        index = indexArray[Random.Range(0, indexArray.Length)];
        Textfield = GetComponent<Text>();
        // NextFlower = plantPrefab[Random.Range(0, plantPrefab.Length)];
    }

    public void Increment()
    {
        index++;
        if (index == 6)
        {
            index = 0;
        }
        Debug.Log(index);
    }
    // Update is called once per frame
    void Update()
    {
        if(index == 0)
        {
            Textfield.text = "Next up is orange";
        }
        if(index == 1)
        {
            Textfield.text = "Next up is red";
        }
        if(index == 2)
        {
            Textfield.text = "Next up is blue";
        }
        if(index == 3)
        {
            Textfield.text = "Next up is green";
        }
        if(index == 4)
        {
            Textfield.text = "Next up is purple";
        }
        if(index == 5)
        {
            Textfield.text = "Next up is yellow";
        }

        ScoreText.text ="Score: " +Score;
       // index = indexArray[Random.Range(0, indexArray.Length)];
        //Debug.Log(index);
    }
}
