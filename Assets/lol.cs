using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    private bool istargeter;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            istargeter = true;
        }

        if (istargeter)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, speed);
        }
    }

    
}
