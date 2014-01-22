using UnityEngine;
using System.Collections;

public class ScalePosition : MonoBehaviour {

	// Use this for initialization
	 void Awake () {
		float ratio = (float)Screen.width/(float)Screen.height;
		this.transform.localScale =new Vector3(this.transform.localScale.x*ratio,this.transform.localScale.y,this.transform.localScale.z *ratio);
		this.transform.localPosition = new Vector3(this.transform.localPosition.x*ratio, this.transform.localPosition.y*ratio, this.transform.localPosition.z);
	}
}
