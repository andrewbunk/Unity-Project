using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Rigidbody2D rb2;
    public GameObject PlayerMovement;
    public Vector2 playerposition;
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        playerposition = transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rb2.transform.Translate(playerposition * 5f * Time.fixedDeltaTime);           
        } 
        
    }
}
