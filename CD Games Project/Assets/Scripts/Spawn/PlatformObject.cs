using UnityEngine;

namespace Spawn
{
    public class PlatformObject : MonoBehaviour
    {
        private void Update()
        {
            transform.Translate(Vector3.left * (Time.deltaTime * 4f));
        }
    }
}