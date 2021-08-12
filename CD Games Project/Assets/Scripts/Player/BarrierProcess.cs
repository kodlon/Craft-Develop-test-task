using UnityEngine;

namespace Player
{
    public class BarrierProcess : MonoBehaviour
    {
        private Ray _ray;
        private Ray _rayRight;


        public bool BarrierCheck()
        {
            RayInitialize();

            if (Physics.Raycast(_ray, out RaycastHit hit) & hit.collider != null & hit.distance < 1f ||
                Physics.Raycast(_rayRight, out RaycastHit hitRight) & hitRight.collider != null &
                hitRight.distance < 1f)
            {
                return true;
            }

            return false;
        }

        private void RayInitialize()
        {
            _ray = new Ray(transform.position + new Vector3(1, 1.5f, 0), Vector3.up);
            _rayRight = new Ray(transform.position + new Vector3(0.5f, 1.5f, 0), Vector3.right);
        }

        private void OnDrawGizmos()
        {
            RayInitialize();

            Gizmos.color = Color.blue;
            
            Gizmos.DrawRay(_ray.origin, _ray.direction);
            Gizmos.DrawRay(_rayRight.origin, _rayRight.direction);
        }
    }
}