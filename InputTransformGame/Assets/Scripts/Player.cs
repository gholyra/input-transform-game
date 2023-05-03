using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocity = 10;
    private Transform playerTransform;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        rigidBody = GetComponent<Rigidbody2D>();
        //playerTransform.Translate(1, 1, 0);
        //playerTransform.position = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * velocity;
        float moveY = 0; //Input.GetAxis("Vertical") * Time.deltaTime * velocity;
        playerTransform.Translate(moveX, moveY, 0);

        if (Input.GetButton("Jump"))
        {
            rigidBody.AddForce(new Vector2(0, 1));
        }

    }
}
