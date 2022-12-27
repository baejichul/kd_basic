using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class CreateCube : MonoBehaviour
	{
        public GameObject _prefab = null;

        private void Start()
        {
            StartCoroutine(CreateCoroutine());
        }
        IEnumerator CreateCoroutine()
        {
            while (true)
            {
                yield return null;
                // Instantiate(_prefab, Vector3.zero, Quaternion.identity);
                GameObject obj = PoolingManager.I.GetQueue();
                obj.transform.position = Vector3.zero;
            }
        }
    }
}