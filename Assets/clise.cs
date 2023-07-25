using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clise : MonoBehaviour
{

    private Rigidbody _rb;
    [SerializeField] private Vector3 offset;

    public void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (globalscript.rez == 0)
            {
                _rb.AddForce(offset);
            }

        }
    }
}
