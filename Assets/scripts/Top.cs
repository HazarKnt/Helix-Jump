using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public Rigidbody rb;
    public float zýplama;
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
        rb.AddForce(Vector3.up * zýplama);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);//topun altýndaki izi belirtiyor.
        splash.transform.SetParent(other.gameObject.transform);

        string matiralName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Adý :" + matiralName);
        /*if (matiralName == "safe color (Instance)")
        {
            //puan alýcak.
        }*/
        if (matiralName == "çarpmak (Instance)")
        {
            //bölüm yeniden baþlayacak.
            //Debug.Log("game over.");
            gm.RestartGame();
        }
        else if (matiralName == "bitiþ (Instance)")
        {
            //bir sonraki levele geçicek.
            Finish.SetActive(true);
            Debug.Log("Next Level");
        }
    }
}
