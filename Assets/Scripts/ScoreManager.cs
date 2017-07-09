using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text PlayerOneScore;
    public Text PlayerTwoScore;
    public GameObject ballGO;

    BallMovement Ball;
 
    void Start () {
        Ball = ballGO.GetComponent<BallMovement>(); 
	}
	

	void Update () {
        PlayerOneScore.text = Ball.Scores[0].ToString();
        PlayerTwoScore.text = Ball.Scores[1].ToString();
	}
}
