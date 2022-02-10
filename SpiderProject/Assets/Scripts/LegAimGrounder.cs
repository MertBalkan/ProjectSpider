using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegAimGrounder : MonoBehaviour
{
    int layerMask;
    GameObject raycastOrigin;
    void Start()
    {
        layerMask = LayerMask.GetMask("Ground");
        raycastOrigin = transform.parent.gameObject;
    }

    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(raycastOrigin.transform.position + new Vector3(0f, 0.75f, 0f), -transform.up, out hit, Mathf.Infinity, layerMask))
        {
            transform.position = hit.point + new Vector3(0f, 0.5f, 0f);
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
    }
}
