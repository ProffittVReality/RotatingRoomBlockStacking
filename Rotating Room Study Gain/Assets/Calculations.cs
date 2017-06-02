using UnityEngine;
using System.Collections;
using System;

public class Calculations : MonoBehaviour {

	private double angle;
	private double dX;
	private double dZ;
	private double count;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	public int sort(Vector3 vect) {

		if (vect.x > 0 && vect.z > 0)
			return 1;
		else if (vect.x < 0 && vect.z > 0)
			return 2;
		else if (vect.x < 0 && vect.z < 0)
			return 3;
		else if (vect.x > 0 && vect.z < 0)
			return 4;
		else
			return 0;
	}

	public double calc(Vector3 vect, Vector3 vect2) {
		double dX1 = Math.Abs (vect.x);
		double dZ1 = Math.Abs (vect.z);
		double dX2 = Math.Abs (vect2.x);
		double dZ2 = Math.Abs (vect2.z);

		//count
		count += .5f;
		Debug.Log ("count: " + count);

		if (sort (vect) == sort (vect2) && sort (vect) != 0) {
			Debug.Log ("Option 1");
			if (sort (vect) == 1 || sort (vect) == 3) {
				double angle1 = Math.Atan (dX1 / dZ1);
				angle1 = angle1 * (180 / Math.PI);
				Debug.Log ("angle1: " + angle1);

				double angle2 = Math.Atan (dZ2 / dX2);
				angle2 = angle2 * (180 / Math.PI);
				Debug.Log ("angle2: " + angle2);
		
				angle = 90 - (angle2 + angle1);
				return angle;
			}
			if (sort (vect) == 2 || sort (vect) == 4) {
				double angle1 = Math.Atan (dZ1 / dX1);
				angle1 = angle1 * (180 / Math.PI);
//				Debug.Log ("angle1: " + angle1);

				double angle2 = Math.Atan (dX2 / dZ2);
				angle2 = angle2 * (180 / Math.PI);
//				Debug.Log ("angle2: " + angle2);

				angle = 90 - (angle2 + angle1);
				return angle;
			}

		} else if (sort (vect) == 0 || sort (vect2) == 0) {
			if (sort (vect) != 0) {
				Debug.Log ("Option2");
				if (sort (vect2) == 2 || sort (vect2) == 4) {
					angle = Math.Atan (dX1 / dZ1) * (180 / Math.PI); 
				} else if (sort (vect2) == 1 || sort (vect2) == 3) {
					angle = Math.Atan (dZ1 / dX1) * (180 / Math.PI);
				}

			} else if (sort (vect2) != 0) {
				Debug.Log ("Option3");
				if (sort (vect2) == 2 || sort (vect2) == 4) {
					angle = Math.Atan (dZ1 / dX1); 
				} else if (sort (vect2) == 1 || sort (vect2) == 3) {
					angle = Math.Atan (dX1 / dZ1) * (180 / Math.PI);
				}
				return angle;
			}
		
		} else if (Math.Abs (sort (vect2) - sort (vect)) == 1) { 
			double angle1;
			double angle2;

			Debug.Log ("Option3");
			if (sort (vect) == 1 || sort (vect) == 3) {
				angle1 = Math.Atan (dZ1 / dX1) * (180 / Math.PI);
				angle2 = Math.Atan (dZ2 / dX2) * (180 / Math.PI);
				angle = angle1 + angle2;					
				return angle;
			} else if (sort (vect) == 2 || sort (vect) == 4) {
				angle1 = Math.Atan (dX1 / dZ1) * (180 / Math.PI);
				angle2 = Math.Atan (dX2 / dZ2) * (180 / Math.PI);
				angle = angle1 + angle2;
				return angle;
			}

		} else if (Math.Abs (sort (vect2) - sort (vect)) == 2) {
			double angle1;
			double angle2;
			Debug.Log ("Option4");
			if (sort (vect) + sort (vect2) == 4) {
				angle1 = Math.Atan (dZ1 / dX1) * (180 / Math.PI); 
				angle2 = Math.Atan (dX2 / dZ2) * (180 / Math.PI);
				angle = angle1 + angle2 + 90;
				return angle;
			}

			if (sort (vect) + sort (vect2) == 6) {
				angle1 = Math.Atan (dX1 / dZ1) * (180 / Math.PI); 
				angle2 = Math.Atan (dZ2 / dX2) * (180 / Math.PI);
				angle = angle1 + angle2 + 90;
				return angle; 
			}
		
		} else if (sort (vect) == 0 && sort (vect2) == 0) {
			Debug.Log ("Option5");
			if (dX1 == 0 && dZ1 > 0) {
				if (dZ2 == 0 && dX2 > 0)
					return 90;
				if (dX2 == 0 && dZ2 < 0)
					return 180;
				if (dZ2 == 0 && dX2 < 0)
					return 270;
			} else if (dZ1 == 0 && dX1 > 0) {
				if (dX2 == 0 && dZ2 < 0)
					return 90;
				if (dZ2 == 0 && dX2 < 0)
					return 180;
				if (dX2 == 0 && dZ2 > 0)
					return 270;
			} else if (dX1 == 0 && dZ1 < 0) {
				if (dZ2 == 0 && dX2 < 0)
					return 90;
				if (dX2 == 0 && dZ2 > 0)
					return 180;
				if (dZ2 == 0 && dX2 > 0)
					return 270;
			} else if (dZ1 == 0 && dX1 < 0) {
				if (dX2 == 0 && dZ2 > 0)
					return 90;
				if (dZ2 == 0 && dX2 > 0)
					return 180;
				if (dX2 == 0 && dZ2 < 0)
					return 270;
			}
		}
		Debug.Log ("sort(vect): " + sort (vect));
		Debug.Log ("sort(vect2): " + sort (vect2));
		return -1;
	}
		
}


