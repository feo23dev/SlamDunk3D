using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enlargethepot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI time;
    [SerializeField] private int startTime;
    [SerializeField] private GameManager _GameManager;
    
    void Start()
    {
        StartCoroutine(startCountdown());
        
    }
    IEnumerator startCountdown()
    {
        time.text = startTime.ToString();
        while(true)
        {
            yield return new WaitForSeconds(1);
            startTime--;
            time.text = startTime.ToString();
            
            if(startTime <= 3)
            {
                time.color = Color.red;
            }

            if(startTime==0)
            {
                gameObject.SetActive(false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
         gameObject.SetActive(false);
        _GameManager.EnlargeThePot(transform.position);
        
    }
}
