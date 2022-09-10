using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Platform;
    [SerializeField] private GameObject BigPot;
    [SerializeField] private Image[] QuestImages;
    [SerializeField] private Sprite QuestCompleted;
    [SerializeField] private float BallsRequired;
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject enlarger;
    [SerializeField] private AudioSource[] Sounds;
    [SerializeField] private ParticleSystem[] Effects;
    int BasketPoints; 

    void Start()
    {
        // Invoke("RuneSpawn",2f);
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


    public void Basket(Vector3 Pos)
    {
        Sounds[3].Play();
        BasketPoints++;
        QuestImages[BasketPoints-1].sprite = QuestCompleted;
        Effects[0].transform.position = Pos; 
        Effects[0].gameObject.SetActive(true);
        
        if(BasketPoints == BallsRequired)
        {
           
           YouWon();
        }

        if(BasketPoints ==1)
        {
            RuneSpawn();
        }
    }

    public void YouLost()
    {
        Sounds[1].Play();
        Debug.Log(" YOU LOST ");
    }

    public void EnlargeThePot(Vector3 Pos)
    {
        Sounds[0].Play();
        BigPot.transform.localScale = new Vector3(60,60,60);
        Effects[1].transform.position = Pos; 
        Effects[1].gameObject.SetActive(true);

    }
    
    public void RuneSpawn()
    {
        int random = Random.Range(0,spawnPoints.Length);
        enlarger.transform.position = spawnPoints[random].transform.position;
        enlarger.SetActive(true);
    }
    public void YouWon()
    {
        Sounds[2].Play();   

    }






}

