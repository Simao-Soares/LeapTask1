using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    public Text playerScoreText;

    private int NGreenBalls;
    private int NYellowBalls;
    private int NGreyBalls;

    public Text NGreenBallsText;
    public Text NYellowBallsText;
    public Text NGreyBallsText;
    
    private GameObject GreenBall;
    private GameObject YellowBall;
    private GameObject GreyBall;

    //increment


    public void PlayerScores5(){
        playerScore = playerScore + 5;
        this.playerScoreText.text = playerScore.ToString();

        NGreenBalls += 1;
        this.NGreenBallsText.text = NGreenBalls.ToString();

        Debug.Log("+5 pontos");
        GreenBall = GameObject.Find("Ball1");
        GreenBall.GetComponent<BallLogic>().ResetPos();

    }
        
    public void PlayerScores10(){
        playerScore = playerScore + 10;
        this.playerScoreText.text = playerScore.ToString();

        NYellowBalls += 1;
        this.NYellowBallsText.text = NYellowBalls.ToString();

        Debug.Log("+10 pontos");
        YellowBall = GameObject.Find("Ball2");
        YellowBall.GetComponent<BallLogic>().ResetPos();
    }

    public void PlayerScores1(){
        playerScore = playerScore + 1;
        this.playerScoreText.text = playerScore.ToString();

        NGreyBalls += 1;
        this.NGreyBallsText.text = NGreyBalls.ToString();

        Debug.Log("+1 pontos");
        GreyBall = GameObject.Find("Ball3");
        GreyBall.GetComponent<BallLogic>().ResetPos();
    }
}
