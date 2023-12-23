using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controllers;
using UnityEngine;

namespace UdemyProject1.Combats
{
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField] ProjectileController projectilePrefab;
        [SerializeField] Transform projectileTransform;
        [SerializeField] GameObject projectileParent;
        [SerializeField] float delayProjectile = 1f;

        float currentDelayTime = 0f;
        bool canLaunch = false; //0 ve 1 / 0 => false / 1 => true

        private void Update()
        {
            currentDelayTime += Time.deltaTime;

            if (currentDelayTime > delayProjectile)
            {
                canLaunch = true;
                currentDelayTime = 0f;
            }
        }

        public void LaunchAction()
        {
            if (canLaunch)
            {
                ProjectileController newProjectile = Instantiate
                    (projectilePrefab, projectileTransform.position, projectileTransform.transform.rotation);

                newProjectile.transform.parent = projectileParent.transform;

                canLaunch = false;
            }
        }
    }
}

