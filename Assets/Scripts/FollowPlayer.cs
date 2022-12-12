using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
    
    // Update is called once per frame
    public void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
