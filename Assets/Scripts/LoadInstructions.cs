using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadInstructions : MonoBehaviour {
    // Start is called before the first frame update
    public Button instructions_button;
    void Start() {
       instructions_button.onClick.AddListener(LoadTheInstructions); 
    }

    // Update is called once per frame
    void LoadTheInstructions() {
        SceneManager.LoadScene("Instructions");
    }
}
