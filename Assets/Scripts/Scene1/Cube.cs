using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class Cube : MonoBehaviour
	{
		Rigidbody _rigid;

        void OnEnable()
        {
            if (_rigid == null)
            {
                _rigid = GetComponent<Rigidbody>();
            }

            _rigid.velocity = Vector3.zero;
            _rigid.AddExplosionForce(1000, transform.position, 1f);
            StartCoroutine(DestroyCube());
        }

        IEnumerator DestroyCube()
        {
            yield return new WaitForSeconds(1f);
            // Destroy(gameObject);
            PoolingManager.I.InsertQueue(gameObject);
        }
    }
}