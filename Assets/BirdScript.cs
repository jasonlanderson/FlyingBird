using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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

        Debug.Log("Printing Controllers: " + Gamepad.all.Count.ToString());
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

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

    public void OnFlap(InputAction.CallbackContext context)
    {
        if (birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
