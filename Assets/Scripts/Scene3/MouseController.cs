using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gacha
{
	public class MouseController : MonoBehaviour
	{
	    

	    // Update is called once per frame
	    void Update()
	    {
	        if (Input.GetMouseButtonDown(0))
            {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				if(Physics.Raycast(ray, out hit, 100f))
                {
					hit.transform.GetComponent<CubeN>().Explosion();
				}
            }
	    }
	}
}