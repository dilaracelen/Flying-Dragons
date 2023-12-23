using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 1f;

        float currentSpawnTime;
        float timeBoundary;

        private void Start()
        {
            ResetTimes();
        }

        private void Update()
        {
            currentSpawnTime += Time.deltaTime;

            if (currentSpawnTime > timeBoundary)
            {
                Spawn();
                ResetTimes();
            }
        }

        protected abstract void Spawn();

        private void ResetTimes()
        {
            currentSpawnTime = 0f;
            timeBoundary = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }
}

