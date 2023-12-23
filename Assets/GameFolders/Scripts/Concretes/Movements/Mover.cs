using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Enums;
using UnityEngine;

namespace UdemyProject1.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        [SerializeField] DirectionEnum direction;

        Rigidbody2D rigidbody2D;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            rigidbody2D.velocity = SelectNewDirection() * moveSpeed;
        }

        private Vector2 SelectNewDirection()
        {
            Vector2 selectedDirection;

            if (direction == DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }

            return selectedDirection;
        }
    }
}

