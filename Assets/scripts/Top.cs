using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public Rigidbody rb;
    public float z�plama;
    public GameObject splashPrefab;
    private GameManager gm;
    public GameObject Finish;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * z�plama);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);//topun alt�ndaki izi belirtiyor.
        splash.transform.SetParent(other.gameObject.transform);

        string matiralName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Ad� :" + matiralName);
        /*if (matiralName == "safe color (Instance)")
        {
            //puan al�cak.
        }*/
        if (matiralName == "�arpmak (Instance)")
        {
            //b�l�m yeniden ba�layacak.
            //Debug.Log("game over.");
            gm.RestartGame();
        }
        else if (matiralName == "biti� (Instance)")
        {
            //bir sonraki levele ge�icek.
            Finish.SetActive(true);
            Debug.Log("Next Level");
        }
    }
}
