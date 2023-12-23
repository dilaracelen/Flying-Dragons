using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime = 5f;

        protected float currentTime;

        private void Update()
        {
            currentTime += Time.deltaTime;

            if (currentTime > maxLifeTime)
            {
                KillGameObject();
            }
        }

        public abstract void KillGameObject();
    }
}

