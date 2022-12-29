using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class CubeN : MonoBehaviour
	{
		[SerializeField] GameObject _debrisPrefab = null;
		[SerializeField] float _force = 0f;
		[SerializeField] Vector3 _offsetVec = Vector3.zero;

		public void Explosion()
        {
			GameObject _debrisClone = Instantiate(_debrisPrefab, transform.position, Quaternion.identity);
			Rigidbody[] _rigid = _debrisClone.GetComponentsInChildren<Rigidbody>();
			for(int i = 0; i < _rigid.Length; i++)
            {
				_rigid[i].AddExplosionForce(_force, transform.position + _offsetVec, 10f);
			}
			gameObject.SetActive(false);
		}


	}
}