using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosObjective : MonoBehaviour
{
    public GameObject ObjectiveA;
    public GameObject ObjectiveB;
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(PlayerPrefs.GetInt("GameMode"));
        switch(PlayerPrefs.GetInt("GameMode"))
        {
            case 0:
                ObjectiveA.SetActive(true);
                ObjectiveB.SetActive(false);
                break;
            case 1:
                ObjectiveA.SetActive(false);
                ObjectiveB.SetActive(true);
                break;
            case 2:
                ObjectiveA.SetActive(true);
                ObjectiveB.SetActive(true);
                break;               
        }
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
