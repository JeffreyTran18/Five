using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadTitleScreen : MonoBehaviour {
    // Start is called before the first frame update
    public Button main_menu_button;
    void Start() {
        main_menu_button.onClick.AddListener(LoadTheTitleScreen);
    }

    // Update is called once per frame
    void LoadTheTitleScreen() {
        SceneManager.LoadScene("Title Screen");
    }
}
