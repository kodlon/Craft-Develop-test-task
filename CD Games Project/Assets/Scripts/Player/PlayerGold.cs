using Other;
using UnityEngine;

namespace Player
{
    public class PlayerGold : MonoBehaviour
    {
        private Ray _ray;

        private int _gold = 0;

        public void GoldCheck()
        {
            RayInitialize();

            if (Physics.Raycast(_ray, out RaycastHit hit) & hit.collider != null & hit.distance < 1f)
            {
                Gold gold = hit.collider.GetComponent<Gold>();
                _gold += 2;
                Debug.Log(_gold);
                Destroy(gold.gameObject);
            }
        }

        private void RayInitialize()
        {
            _ray = new Ray(transform.position + new Vector3(1, 1, 0), Vector3.right);
        }

        private void OnDrawGizmos()
        {
            RayInitialize();

            Gizmos.color = Color.red;

            Gizmos.DrawRay(_ray.origin, _ray.direction);
        }
    }
}