using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadGame : MonoBehaviour {
    // Start is called before the first frame update
    public Button play_button;
    void Start() {
        play_button.onClick.AddListener(LoadTheGame);
    }

    // Update is called once per frame
    void LoadTheGame() {
        SceneManager.LoadScene("Game");
    }
}
