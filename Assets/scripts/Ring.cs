using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        if (transform.position.y + 10.5f >= ball.position.y)//10.5f yapma sebebi ilk halka 12f üzerin olduðu için.
        {
            Destroy(gameObject);//yani kendisini yok etsin.
            gm.GameScore(25);
        }
    }
}
