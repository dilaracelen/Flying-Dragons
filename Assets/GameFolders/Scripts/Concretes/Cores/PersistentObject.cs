using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Cores
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;

        static bool isFirstTime = true;

        private void Start()
        {
            if (isFirstTime)
            {
                SpawnPersistentObjects();
                isFirstTime = false;
            }
        }

        private void SpawnPersistentObjects()
        {
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
}

