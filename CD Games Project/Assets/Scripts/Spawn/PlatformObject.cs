using UnityEngine;
using UnityEngine.Serialization;

namespace Spawn
{
    public class PlatformObject : MonoBehaviour
    {
        [SerializeField] private GameObject gold;

        //[SerializeField, Range(1, 100)] private int goldCount = 1;

        private Vector3 _firstGoldPosition;
        private Vector3 _secondGoldPosition;

        [SerializeField] private bool isSpawnComplete;


        // private void Start()
        // {
        //     if (!isSpawnComplete)
        //     {
        //         PlatformInitialize();
        //     }
        // }

        // private void PlatformInitialize()
        // {
        //     transform.localScale = new Vector3(goldCount / 2, 1, 3);
        //     transform.position = new Vector3(transform.position.x + goldCount / 4, 0, 0);
        //
        //     Vector3 position = new Vector3(transform.position.x - (transform.localScale.x / 2), transform.position.y,
        //         transform.position.z);
        //
        //     _firstGoldPosition = position - Vector3.back + Vector3.up;
        //     _secondGoldPosition = position - Vector3.forward + Vector3.up;
        //
        //     for (int i = 0; i < goldCount; i++)
        //     {
        //         Instantiate(gold, _firstGoldPosition, Quaternion.identity);
        //         Instantiate(gold, _secondGoldPosition, Quaternion.identity);
        //
        //         _firstGoldPosition += Vector3.right / 2;
        //         _secondGoldPosition += Vector3.right / 2;
        //     }
        //
        //     isSpawnComplete = true;
        // }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;

            Gizmos.DrawRay(_firstGoldPosition, Vector3.up);
            Gizmos.DrawRay(_secondGoldPosition, Vector3.up);
        }
    }
}