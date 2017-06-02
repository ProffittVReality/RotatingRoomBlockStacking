using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	public Transform block1;
	public Transform block2; 
	public Transform block3;
	public Transform block4;
	public Transform block5;
	public Transform cubes; 
	public string rearrange;
	public Transform room;

	public GameObject RigWalls; 

	private int trial = 0; 

	// Use this for initialization
	void Start () {
		rearrange = "return";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(rearrange))
		{
			if (trial == 0) {
				block1.localPosition = new Vector3 (.704f, .2f, -.134f);
				block2.localPosition = new Vector3 (-1.051f, .15f, .298f);
				block3.localPosition = new Vector3 (-.16f, .125f, -.49f);
				block4.localPosition = new Vector3 (.047f, .1f, .51f);
				block5.localPosition = new Vector3 (-.718f, .075f, -.435f);
				cubes.rotation = room.rotation;

				trial++;

			}else if (trial == 1) {
				block1.position = new Vector3 (.323f, .6f, -.597f);
				block4.position = new Vector3 (-.6231f, .6f, -.1678f);
				block3.position = new Vector3 (-.353f, .5f, .188f);
				block2.position = new Vector3 (.551f, .5f, .264f);
				block5.position = new Vector3 (-.568f, .5f, .49f);
				cubes.rotation = room.rotation;

				trial++;

			} else if (trial == 2) {
				block1.localPosition = new Vector3 (-.781f, .2f, -.19f);
				block2.localPosition = new Vector3 (.767f, .15f, -.054f);
				block3.localPosition = new Vector3 (.412f, .125f, .366f);
				block4.localPosition = new Vector3 (-.38f, .1f, .355f);
				block5.localPosition = new Vector3 (.017f, .075f, -.785f);
				cubes.rotation = room.rotation;

				trial++;
			} 
		}
	}

	public int getTrial() {
		return trial; 
	}

}
