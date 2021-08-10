using System.Collections;
using UnityEngine;

namespace Spawn
{
    public class PlatformSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject[] platformObject;
        private int _chosenObject;

        private Coroutine _spawnerActive;


        private void Start()
        {
            _spawnerActive = StartCoroutine(Spawn());
            _chosenObject = Random.Range(0, platformObject.Length);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                GameObject platform = Instantiate(platformObject[_chosenObject], new Vector3(50, 0, 0),
                    transform.rotation);
                yield break;
            }
        }

        public void DeactiveSpawner()
        {
            StopCoroutine(_spawnerActive);
        }
    }
}