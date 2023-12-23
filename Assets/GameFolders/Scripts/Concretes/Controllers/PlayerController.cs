using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using UdemyProject1.Combats;
using UdemyProject1.Movements;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D rigidbody2D;
        Jump jump;
        PcInputController input;
        LaunchProjectile launchProjectile;
        AudioSource audioSource;
        Dead dead;
        bool isLeftMouseClicked;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            jump = GetComponent<Jump>();
            launchProjectile = GetComponent<LaunchProjectile>();
            audioSource = GetComponent<AudioSource>();
            dead = GetComponent<Dead>();
            input = new PcInputController();
        }

        private void Update()
        {
            if (dead.IsDead) return;

            if (input.LeftMouseClickDown)
            {
                isLeftMouseClicked = true;
            }

            if (input.RightMouseClickDown)
            {
                launchProjectile.LaunchAction();
            }
        }

        private void FixedUpdate()
        {
            if (isLeftMouseClicked)
            {
                jump.JumpAction(rigidbody2D);
                audioSource.Play();
                isLeftMouseClicked = false;
            }
        }
    }
}

