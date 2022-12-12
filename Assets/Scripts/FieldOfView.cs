using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float fovAngle = 90f;
    public Transform fovPoint;
    public float range = 7;
    public bool isPlayer;
    public Vector2 dir;

    public Transform target;

    void Update()
    {
        FOV();
        if (isPlayer == true)
        {
            Debug.DrawRay(transform.position, dir, Color.red);
        }
    }
    
    
    public void FOV()
    {
        isPlayer = false;
        dir = target.position - transform.position;
        float angle = Vector2.Angle( -fovPoint.up, dir);

        RaycastHit2D r = Physics2D.Raycast(fovPoint.position, dir, range);

        if (angle < fovAngle / 2)
        {
            if (r.collider.CompareTag("Player"))
            {
                isPlayer = true;
                
            }
            else
            {
                isPlayer = false;
            }
        }
        else
        {
            isPlayer = false;
        }

    
    }
    
    
    
}
