using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{
    [SerializeField] private float policeSpeed;
    public Transform policeOrigin;
    public Rigidbody2D rbPolice;
    public bool isDirRight;

    public void Start()
    {
        rbPolice = gameObject.GetComponent<Rigidbody2D>();
        //give an initial direction
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rbPolice.MovePosition(rbPolice.position + forward * Time.fixedDeltaTime * policeSpeed);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (isDirRight)
            transform.Translate(Vector2.right * policeSpeed * Time.deltaTime);
        else 
            transform.Translate((-Vector2.right * policeSpeed * Time.deltaTime));
        
        
        // if it is more than 10f distance to origin from right start move to left
        if (transform.position.x > policeOrigin.position.x + 10f)
        {
            isDirRight = false;
        }

        if (transform.position.x <= policeOrigin.position.x - 3f)
        {
            isDirRight = true;
        }
        
    }
}
