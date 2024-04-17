using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;

public class TestInteractorScript : MonoBehaviour
{
    float timer = 0;
    bool startTimer = false;
    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
     if (timer >= 2)
        {
            gameObject.SetActive(false);
        }
    }

    public void StartTimer()
    {
        Debug.Log("Timer Start" );
        startTimer = true;
    }
    public void StopTimer()
    {
        Debug.Log("Timer Stop");
        startTimer = false;
        timer = 0;
    }
    

    private void OnTriggerStay(Collider other)
    {

      
        if(other.gameObject.tag == "Scenario Correct" )
        {
            timer += Time.deltaTime;
        }
       
        if (timer == 2)
        {
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        timer = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
      
    }

    public GameObject toSetActive;
        public void SetActive()
    {
        toSetActive.SetActive(true);
    }
}
