using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class PoolingManager : MonoBehaviour
	{
		public static PoolingManager I;

		public GameObject _prefab = null;

		public Queue<GameObject> _queue = new Queue<GameObject>();

        void Awake()
        {
			I = this;
        }

        // Start is called before the first frame update
        void Start()
	    {
			for (int i=0; i < 500; i++)
            {
				GameObject gObj = Instantiate(_prefab, Vector3.zero, Quaternion.identity);
				_queue.Enqueue(gObj);
				gObj.SetActive(false);
			}
		}

	    public void InsertQueue(GameObject obj)
        {
			_queue.Enqueue(obj);
			obj.SetActive(false);
        }

		public GameObject GetQueue()
        {
			GameObject obj = _queue.Dequeue();
			obj.SetActive(true);

			return obj;
        }
	}
}