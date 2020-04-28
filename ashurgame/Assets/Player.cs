using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    Sprite ashur_left;
    Sprite ashur_front;
    Sprite ashur_right;
    SpriteRenderer spriterend;

    float playerSpeed = 10; //speed player moves
    float turnSpeed = 100; // speed player turns
    
    // Start is called before the first frame update
    void Start()
    {
        ashur_left = Resources.Load<Sprite>("ashur_left");
        ashur_front = Resources.Load<Sprite>("ashur_front");
        ashur_right = Resources.Load<Sprite>("ashur_right");
        spriterend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        TurnRightAndLeft();//Player Turning
    }

    void MoveForward()
    {
        if(Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
        {
            transform.Translate(0,playerSpeed * Time.deltaTime,0);
        }
    }
 
    void TurnRightAndLeft()
    {
 
        if(Input.GetKey("right")) //Right arrow key to turn right
        {
            transform.Rotate(-Vector3.forward *turnSpeed* Time.deltaTime);
        }
 
        if(Input.GetKey("left"))//Left arrow key to turn left
        {
            transform.Rotate(Vector3.forward *turnSpeed* Time.deltaTime);
        }
    }
}
