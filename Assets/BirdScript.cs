using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 5;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        // If the bird isn't alive make it rotate a bit
        //if (!birdIsAlive)
        //{
        //    myRigidbody.MoveRotation(myRigidbody.rotation - 40 * Time.fixedDeltaTime);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;

        var impulse = (-40 * Mathf.Deg2Rad) * myRigidbody.inertia;
        myRigidbody.AddTorque(impulse, ForceMode2D.Impulse);
    }
}
