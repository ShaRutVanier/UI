using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScene : MonoBehaviour {

	public void GoScene (string SceneName) {
		SceneManager.LoadScene(SceneName);
	}
}