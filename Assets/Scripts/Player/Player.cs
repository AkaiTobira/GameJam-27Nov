﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private FSM playerController;

    [SerializeField] private float _movementSpeed;
    [SerializeField] private  float _jumpForce;

    [SerializeField] private  float _jumpHoldTime;

    [SerializeField] private float _inAirMovementSpeed;


    public float InAirMovementSpeed{
        get { return _inAirMovementSpeed;}
    }

    public float JumpHoldTime{
        get { return _jumpHoldTime;}
    }
    public float JumpForce{
        get { return _jumpForce;}
    }

    public float MovementSpeed{
        get { return _movementSpeed;}
    }

    void Start() {
        if( Instance == null ){
            Instance = this;
        }

        playerController = new FSM(new IdleState(gameObject));
    }

    void Update() {
        playerController.Update();
    }

    void FixedUpdate() {
        playerController.FixedUpdate();
    }
}