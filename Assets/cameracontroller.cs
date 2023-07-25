using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cameracontroller : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
           if(eventData.delta.x > 0)
            {
                print("ku");
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
