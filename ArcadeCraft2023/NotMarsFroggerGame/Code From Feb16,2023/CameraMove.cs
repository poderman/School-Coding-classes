using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject MainCamera1;
    public GameObject MainCamera2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            MainCamera1.SetActive(true);
            MainCamera2.SetActive(false);
        }
        else if (other.gameObject.CompareTag("SecondCamera"))
        {
            MainCamera1.SetActive(false);
            MainCamera2.SetActive(true);
        }
    }
}
