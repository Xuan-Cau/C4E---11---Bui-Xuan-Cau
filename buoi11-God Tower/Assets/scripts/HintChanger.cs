using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HintChanger : MonoBehaviour {
//
//	public Image hint1;
//	public Image hint2;

	public List<Image> hintList;
	public Button hintButton;

	int hintCurrentIndex = 0;

	public void OnHintButtonClick (){
		hintCurrentIndex = hintCurrentIndex + 1;

		if (hintCurrentIndex == hintList.Count - 1) {
			hintButton.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			hintButton.transform.localScale = new Vector3 (1,1,1);
		}

		if (hintCurrentIndex == hintList.Count ) {
			hintCurrentIndex = 0;
		}


		for (int i = 0; i <= hintList.Count; i++) {
			if (i == hintCurrentIndex) {
				hintList [i].gameObject.SetActive (true);
			}
				else 
					hintList[i].gameObject.SetActive(false);
			}
		}


//	public void OnHintButtonClick (){
//		if (hintCurrentIndex == 1) {
//			hint1.gameObject.SetActive (false);
//			hint2.gameObject.SetActive (true);
//			hintCurrentIndex = 2;
//		}
//		else 
//	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
