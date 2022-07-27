using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //private static readonly float v = Time.deltaTime * 20;

    //[SerializeField] float xTranslate = 0.01f;
    //[SerializeField] float yTranslate = 0.01f;
    //[SerializeField] float zTranslate = 0.01f;
    [SerializeField] float moveSpeed = 1f;
    //float SpeedMove = Time.deltaTime * 20;
    Rigidbody rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Welcome to game!");
        Debug.Log("Let's play");
        Debug.Log("Move with WASD.");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    { 
        
        //float xTranslate = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float xTranslate = Input.GetAxis("Horizontal") * moveSpeed;
        //float xTranslate = Input.GetAxis("Horizontal") * moveSpeed;
        //float zTranslate = Input.GetAxis("Vertical") * moveSpeed;
        float zTranslate = Input.GetAxis("Vertical") * moveSpeed;

        //this.transform.Translate(xTranslate, 0, zTranslate);

        rb.velocity = new Vector3(xTranslate, 0, zTranslate);
    }
}
