using System;
using UnityEngine;

namespace Spawn
{
    public class PlatformObject : MonoBehaviour
    {
        private void Start()
        {
            Destroy(this, 60f);
        }

        private void Update()
        {
            transform.Translate(Vector3.left * (Time.deltaTime * 4f));
        }
    }
}