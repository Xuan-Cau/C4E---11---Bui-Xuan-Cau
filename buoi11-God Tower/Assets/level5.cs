using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class level5 : MonoBehaviour {
	public Text levelText1;
	public InputField inputField;
	public Button submitButton;
	public Text hintText;
	public string levelContent1 = "LEVELS";
	public string levelNumber1;
	public string levelAnswer;

	string answer ;

	void Start () {
		levelText1.text = levelContent1;
		StartCoroutine (ChangeLevelTextRoutime ());

	}

	public void GetInput(){
		answer = inputField.text;
		CheckAnwer ();

	}
	public void CheckAnwer(){
		if (answer == levelAnswer) {
			hintText.text = "Yayyyyyyyyyyy";
			SceneManager.LoadScene (0);
			// TODO : Change Scence
		}else {
			hintText.text = "WRONGGGGGGGGG!!!!!!";
			hintText.color = Color.red;
			inputField.text = "";
			inputField.ActivateInputField ();
			// con tro se tro vao ngay o vua enter ma khong can dung con tro tro vao
		}

	}
	// ham ne dung de : cu sau 1 khoang time thi se lap lai viec ne
	IEnumerator ChangeLevelTextRoutime(){
		while (true){
			levelText1.text = levelContent1;
			// Wait 2 seconds
			yield return new WaitForSeconds (1f);
			//Debug.Log ("????");
			levelText1.text = levelNumber1;
			yield return new WaitForSeconds (1f);
		}
	}
	void Update () {

	}
}
