using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform top;
    private Vector3 offset;
    public float smoothspeed;
    void Start()
    {
        offset = transform.position-top.position;
    }

    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position,offset+top.position,smoothspeed);//lerp iki nokta arasýný istediðimiz gibi doldurmak.Ben geçiþ efekti olarak kullandým.
        transform.position = newPos;
        
    }
}
