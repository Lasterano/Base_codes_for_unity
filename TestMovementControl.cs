using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovementControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Uzay Gemisini Hareket ettirir
        // GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
        //Rigidbody2D myRigidbody2d = GetComponent<Rigidbody2D>();
        //myRigidbody2d.AddForce(new Vector2(5, 5), ForceMode2D.Impulse);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ready-Go");
    }

    // Update is called once per frame
    void Update()
    {
        //Asteroid mouse imlecini takip etsin
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;

    }
}
