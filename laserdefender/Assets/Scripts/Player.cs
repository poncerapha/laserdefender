using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float playerSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal");
        var deltaY = Input.GetAxis("Vertical");
        var newXPos = transform.position.x + deltaX * playerSpeed * Time.deltaTime;
        var newYPos = transform.position.y + deltaY * playerSpeed * Time.deltaTime;
        transform.position = new Vector2(newXPos, newYPos);
    }
}
