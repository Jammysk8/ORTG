using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class RailScript : MonoBehaviour
{
    public static Transform[] points;
    public static GameObject[] targets;
    // Start is called before the first frame update
    private void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
            //targets[i] = transform.GetChild(i).gameObject;
        }
        
    }
}
