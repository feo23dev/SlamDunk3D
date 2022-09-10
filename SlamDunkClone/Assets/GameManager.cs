using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Platform;
    [SerializeField] private Image[] QuestImages;
    [SerializeField] private Sprite QuestCompleted;
    [SerializeField] private float BallsRequired;
    int BasketPoints; 

    void Start()
    {
        for( int i=0; i< BallsRequired; i++)
        {
            QuestImages[i].gameObject.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Platform.transform.position.x > -1.1514) 
        {
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Platform.transform.position = Vector3.Lerp(Platform.transform.position, new Vector3(Platform.transform.position.x -0.3f,Platform.transform.position.y,Platform.transform.position.z), 0.050f);

        }
        }
        if(Platform.transform.position.x < 1.2785)
        {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            Platform.transform.position = Vector3.Lerp(Platform.transform.position, new Vector3(Platform.transform.position.x +0.3f,Platform.transform.position.y,Platform.transform.position.z), 0.050f);

        }
        }

    }


    public void Basket()
    {
        BasketPoints++;
        QuestImages[BasketPoints-1].sprite = QuestCompleted;
        
        if(BasketPoints == BallsRequired)
        {
            Debug.Log(" Kazandın");
        }
    }

    public void YouLost()
    {
        Debug.Log(" YOU LOST ");
    }
}

