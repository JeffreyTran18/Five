using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FiveGame : MonoBehaviour {
    // Start is called before the first frame update
    private float every_five;
    private float seconds;
    private float time_keeper;
    public static float score_keeper;
    public Text time_text;
    public Text score_text;
    public AudioSource for_spacebar;

    private void Start() {
        every_five = 5.0f;
        time_keeper = 1.0f;
        score_keeper = 0.0f;
        seconds = 0.0f;
    }

    // Update is called once per frame
    void Update() {
        seconds += Time.deltaTime;
        time_keeper = Mathf.Round(seconds);
        time_text.text = "Time: " + time_keeper;
        score_text.text = "" + score_keeper;

        if((Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Space))) {
            if((time_keeper % every_five) == 0) {
                score_keeper += 1.0f;
                for_spacebar.Play();
            }

            else {
                SceneManager.LoadScene("Game Over");
            }
        }

        
        if(time_keeper == 15.0f) {
            time_text.gameObject.SetActive(false);
        }
    }
}