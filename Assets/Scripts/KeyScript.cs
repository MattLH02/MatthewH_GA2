using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject doorCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorCollider.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorCollider.SetActive(false);
            Destroy(gameObject);
        }
    }
}
