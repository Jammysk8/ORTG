using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowRail : MonoBehaviour
{
    public float moveSpeed;
    private Transform currentTarget;
    private int wavepointIndex = 0;
    GameObject WallCollision;
    float attackTimer;
    bool atScenario;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = RailScript.points[0];
    }

    // Update is called once per frame
    void Update()
    {

       if (!atScenario)
        {
            Vector3 direction = currentTarget.position - transform.position;
            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, currentTarget.position) <= .2f)
            {
                Debug.Log(currentTarget.gameObject.tag);
               if(currentTarget.gameObject.tag=="Scenario")
                {

                    Debug.Log("At Scenario: " + atScenario);
                    atScenario = true;
                }
               else
                {
                    getnextWaypoint();
                }
              
            }
        }
       
    
       


    }

    void getnextWaypoint()
    {
        if (wavepointIndex >= RailScript.points.Length - 1)
        {
            
            //this will be the final waypoint to signify level end
        }
        else
        {
            wavepointIndex++;
            currentTarget = RailScript.points[wavepointIndex];
        }

    }
    public void CompletedScenario()
    {
        atScenario=false;
        getnextWaypoint();
    }
   

}
