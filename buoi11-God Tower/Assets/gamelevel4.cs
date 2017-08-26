using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class gamelevel4 : MonoBehaviour {
	public Text levelText2;
	public InputField inputField;
	public Button submitButton;
	public Text hintText;
	public string levelContent2 = "LEVELS";
	public string levelNumber2;
	public string levelAnswer;

	string answer ;

	void Start () {
		levelText2.text = levelContent2;
		StartCoroutine (ChangeLevelTextRoutime ());

	}

	public void GetInput(){
		answer = inputField.text;
		CheckAnwer ();

	}
	public void CheckAnwer(){
		if (answer == levelAnswer) {
			hintText.text = "Yayyyyyyyyyyy";
			SceneManager.LoadScene (5);
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
			levelText2.text = levelContent2;
			// Wait 2 seconds
			yield return new WaitForSeconds (1f);
			//Debug.Log ("????");
			levelText2.text = levelNumber2;
			yield return new WaitForSeconds (1f);
		}
	}
	void Update () {

	}
}
