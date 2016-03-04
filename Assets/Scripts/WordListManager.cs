using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class WordListManager : MonoBehaviour {


	/* game data */


	Dictionary<string, string> words = new Dictionary<string, string> () {
		{"さまたげ", "春はあけぼの"},
		{"枕草子", "夏はホニャララ"},
		{"Unity", "ばんざい"},
		{"ほげ", "hoge"},
		{"33", "どないやね"},
		{"42", "どないやねん"},
		{"カニ", "どないや"},
		{"イクラ", "どねん"},
		{"ホタテ", "どなねん"},
		{"おいしい", "いやねん"},
		{"冬の", "どないねん"},
		{"いわもとくん", "どないや"}
	};


	/* Member variables */


	public GameObject content;
	public GameObject itemNode;


	/* Default Methods */


	// Use this for initialization
	void Start () {
		SetItemToWordList ();
	}


	/* Member Methods */


	void SetItemToWordList () {
		foreach (string key in words.Keys) {
			// ループ内のローカル変数でないと、AddListenerの引数が全て一度目のループの値になるので.
			var lockey = key;
			var go = Instantiate (itemNode);

			go.transform.FindChild ("Text").GetComponent<Text> ().text = lockey;
			go.GetComponent<Button> ().onClick.AddListener (() => DisplayItemData (lockey));

			go.GetComponent<RectTransform> ().SetParent (content.transform);
		}
	}

	void DisplayItemData (string key) {
		print ("key: " + key + ", value: " + words[key]);
	}
}
