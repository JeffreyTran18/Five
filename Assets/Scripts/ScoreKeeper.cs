using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    // Start is called before the first frame update
    public Text score_that_round;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        score_that_round.text = "Score: " + FiveGame.score_keeper;
    }
}
