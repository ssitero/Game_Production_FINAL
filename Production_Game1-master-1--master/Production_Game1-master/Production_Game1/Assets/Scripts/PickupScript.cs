﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour {


	void Update () {
        transform.Rotate(new Vector3(0, 80, 0) * Time.deltaTime);
	}
}
