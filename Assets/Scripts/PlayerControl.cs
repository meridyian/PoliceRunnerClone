using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    public Rigidbody2D rb;
    private float dirX;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        //take the input, speeds will be changed, take as direction, maybe animation will be added later on
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

    }
}
