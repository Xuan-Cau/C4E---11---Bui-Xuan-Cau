using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bai1_ss7 : MonoBehaviour {
	void Start () {
		List<int> numbers = new List<int> ();
		for (int i = 0; i < 11; i++) {
			numbers.Add (UnityEngine.Random.Range (0, 100));
			string binary = Convert.ToString (numbers [i], 2);
			print ("number: " + numbers[i] + " == " + binary);
		
		}
	}
}