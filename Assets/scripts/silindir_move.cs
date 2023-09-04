using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silindir_move : MonoBehaviour
{
    public float rotasyonHiz;
    private float moveX;
    
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0)) 
        {
            transform.Rotate(0f, moveX * rotasyonHiz * Time.deltaTime, 0f);
        }
    }
}
