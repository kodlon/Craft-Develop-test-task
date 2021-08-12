using UI.MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private readonly float _speed = 10f;
        private Ray _ray;
        private PlayerGold _playerGold;
        private bool _skate = true;
        public bool IsOnGround { get; private set; } = true;

        private void Start()
        {
            RayInitialize();
            _playerGold = GetComponent<PlayerGold>();
        }

        private void Update()
        {
            if (StartedGame.IsGameStarted)
            {
                RayInitialize();
                OnGroundCheck();
                _playerGold.GoldCheck();
                Move();

                //Position limit
                Vector3 playerPos = transform.position;
                transform.position = new Vector3(playerPos.x, Mathf.Clamp(playerPos.y, 0.4f, 50f), 0);

                if (transform.position.y < 0.41f)
                {
                    PlayerDeath();
                }
            }
        }

        private void Move()
        {
            transform.Translate(Vector3.right * (_speed * Time.deltaTime));
            if (!IsOnGround & _playerGold.Gold <= 0)
            {
                transform.Translate(Vector3.down * (_speed * Time.deltaTime));
            }
        }

        private void OnGroundCheck()
        {
            if (Physics.Raycast(_ray, out RaycastHit hit) & hit.collider != null & hit.distance < 1f)
            {
                IsOnGround = true;
                transform.rotation = Quaternion.Euler(Vector3.zero);
                transform.position = new Vector3(transform.position.x, 0.499f, 0);

                _skate = true;
            }
            else
            {
                IsOnGround = false;

                if (_skate)
                {
                    transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30f));
                    _skate = false;
                }
            }
        }

        public void CheckDirection(float value)
        {
            if (!IsOnGround & StartedGame.IsGameStarted & _playerGold.Gold != 0)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, value));
            }
        }

        private void PlayerDeath()
        {
            StartedGame.IsGameStarted = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void RayInitialize()
        {
            _ray = new Ray(transform.position + new Vector3(1, 1, 0), Vector3.down);
        }

        private void OnDrawGizmos()
        {
            RayInitialize();

            Gizmos.color = IsOnGround ? Color.green : Color.red;
            Gizmos.DrawRay(_ray.origin, _ray.direction);
        }
    }
}