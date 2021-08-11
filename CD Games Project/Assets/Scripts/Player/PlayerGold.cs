using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerGold : MonoBehaviour
    {
        [SerializeField] private Transform playerBackPack;
        [SerializeField] private GameObject board;
        [SerializeField] private GameObject boardBackPack;

        private PlayerMove _playerMove;
        private Vector3 _pos = new Vector3(0, 0.2f, 0);
        private Ray _ray;
        private int _gold = 0;
        private List<GameObject> boardsInBackPack = new List<GameObject>();


        private void Start()
        {
            _playerMove = GetComponent<PlayerMove>();
            StartCoroutine(BoardBuilding());
        }


        public void GoldCheck()
        {
            RayInitialize();

            if (Physics.Raycast(_ray, out RaycastHit hit) & hit.collider != null & hit.distance < 1f &
                hit.collider.CompareTag("Gold"))
            {
                _gold++;

                boardsInBackPack.Add(Instantiate(boardBackPack, playerBackPack.position + _pos, transform.rotation,
                    playerBackPack));
                _pos = new Vector3(0, _pos.y + 0.1f, 0);


                Destroy(hit.collider.gameObject);
            }
        }

        private IEnumerator BoardBuilding()
        {
            int i = boardsInBackPack.Count;
            while (true)
            {
                yield return new WaitForSeconds(0.2f);
                if (_gold >= 2 & !_playerMove.IsOnGround)
                {
                    Instantiate(board, transform.position, transform.rotation);
                    Destroy(boardsInBackPack[i].gameObject);
                    i--;
                }
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