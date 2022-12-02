using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardInput : MonoBehaviour
{
    public Car Car;


    // Update is called once per frame
    void Update()
    {
        if (Game.IsRunning())
        {
            if (Input.GetKey(KeyCode.W))
            {
                Car.MoveManually(new Vector3(GameParameters.CarMoveAmount * Car.acceleration, 0f, 0f));
                if (Car.acceleration < GameParameters.MaxForwardSpeed)
                {
                    Car.acceleration += 0.035f;
                }
            }
            else
            {
                Car.acceleration = 0.0f;
            }

            if (Input.GetKey(KeyCode.S))
            {
                Car.MoveManually(new Vector3(GameParameters.CarMoveAmount * Car.deceleration, 0f, 0f));
                if (Car.deceleration > GameParameters.MaxReverseSpeed)
                {
                    Car.deceleration -= 0.035f;
                }
            }
            else
            {
                Car.deceleration = 0.0f;
            }
            
            if (Car.acceleration != 0.0f)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    Car.transform.Rotate(0f, 0f, 1f);
                    Car.Exhaust.Play();
                }
            
                if (Input.GetKey(KeyCode.D))
                {
                    Car.transform.Rotate(0f, 0f, -1f);
                    Car.Exhaust.Play();
                }
            }

            if (Car.deceleration != 0.0f)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    Car.transform.Rotate(0f, 0f, 1f);
                    Car.Exhaust.Play();
                }
            
                if (Input.GetKey(KeyCode.D))
                {
                    Car.transform.Rotate(0f, 0f, -1f);
                    Car.Exhaust.Play();
                }
            }
        }
    }
}