using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drapping : MonoBehaviour
{

    [SerializeField] private Vector3 offset;
    private bool isdrugging;
    private GameObject druggingobj;
    private void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, Mathf.Infinity))
            {
                if (_hit.transform.tag == "PickUp")
                {
                    druggingobj = _hit.collider.gameObject;
                    isdrugging = true;
                                        }
            }

            
                Vector3.Lerp(druggingobj.transform.position, transform.position - offset, 10);




        }
    }
}
