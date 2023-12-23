using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Combats
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] bool isDead;
        public bool IsDead => isDead;

        public event System.Action OnDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }
    }
}

