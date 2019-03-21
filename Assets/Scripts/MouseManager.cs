using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseManager : MonoBehaviour
{
    public EventVector3 OnClickEnvironment;
    public LayerMask clickableLayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            if (hit.collider.gameObject.tag == "Doorway")
            {

            }
            else
            {

            }

            //left click
            if (Input.GetMouseButtonDown(0))
            {
                OnClickEnvironment.Invoke(hit.point);
            }
        }

    }
}


[System.Serializable]
public class EventVector3 : UnityEvent<Vector3> { }