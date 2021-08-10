using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private readonly float _speed = 10f;
        private Ray _ray;
        private bool _isOnGround;

        private void Start()
        {
            RayInitialize();
        }

        private void Update()
        {
            RayInitialize();
            OnGroundCheck();
            Move();

            //Position limit
            Vector3 playerPos = transform.position;
            transform.position = new Vector3(playerPos.x, Mathf.Clamp(playerPos.y, 0, 8), 0);
        }

        private void Move()
        {
            transform.Translate(Vector3.right * (_speed * Time.deltaTime));
        }

        private void OnGroundCheck()
        {
            if (Physics.Raycast(_ray, out RaycastHit hit) & hit.collider != null & hit.distance < 1f)
            {
                _isOnGround = true;
                transform.rotation = Quaternion.Euler(Vector3.zero);
            }
            else
            {
                _isOnGround = false;
            }
        }

        public void CheckDirection(float value)
        {
            if (!_isOnGround)
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, value));
        }

        private void RayInitialize()
        {
            _ray = new Ray(transform.position + new Vector3(1, 1, 0), Vector3.down);
        }

        private void OnDrawGizmos()
        {
            RayInitialize();

            Gizmos.color = Color.red;
            Gizmos.DrawRay(_ray.origin, _ray.direction);
        }
    }
}