using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsleft;
    public bool takingaway = false;
    public GameObject GameOverScreen;
    public int minutesleft;
    public GameObject OverCollision;
    // Start is called before the first frame update
    IEnumerator TimerTake()
    {
        takingaway = true;
        yield return new WaitForSeconds(1.5f);
        secondsleft -= 1;
        
        textDisplay.GetComponent<Text>().text = "00:" + secondsleft;
        takingaway = false;
    }
    void Start()
    {
        OverCollision.SetActive(false);
        minutesleft = 1;
        textDisplay.GetComponent<Text>().text = "00:" + secondsleft;
    }

    // Update is called once per frame
    void Update()
    {
        if(takingaway == false && minutesleft >= 0)
        {
            StartCoroutine(TimerTake());
        }
        if (secondsleft == 0)
        {
            minutesleft -= 1;

            OverCollision.SetActive(true);
            GameOverScreen.SetActive(true);
            // GameOverScreen.SetActive(true);
        }
       
    }
}
