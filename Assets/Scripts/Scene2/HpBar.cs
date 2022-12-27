using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class HpBar : MonoBehaviour
	{
		[SerializeField] GameObject _prefab = null;
		List<Transform> _objList    = new List<Transform>();
		List<GameObject> _hpBarList = new List<GameObject>();

        Camera _cam = null;

        private void Start()
        {
            _cam = Camera.main;
            GameObject[] _tmpObjects = GameObject.FindGameObjectsWithTag("Player");
            for (int i=0; i < _tmpObjects.Length; i++)
            {
                _objList.Add(_tmpObjects[i].transform);
                GameObject _tmpHpBar = Instantiate(_prefab, _tmpObjects[i].transform.position, Quaternion.identity, transform);
                _hpBarList.Add(_tmpHpBar);
            }

        }

        private void Update()
        {
            for(int i=0; i < _objList.Count; i++)
            {
                _hpBarList[i].transform.position = _cam.WorldToScreenPoint(_objList[i].position + new Vector3(0f, 1.15f, 0f));
            }
        }
    }
}