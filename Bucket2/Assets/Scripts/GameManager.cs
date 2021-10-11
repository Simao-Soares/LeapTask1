using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Random = System.Random;

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
    
    public GameObject GreenBall;
	public GameObject YellowBall;
	public GameObject GreyBall;



    //increment

	void Start()
	{
		newBall();
	}




    public void PlayerScores5(){
        playerScore = playerScore + 5;
        this.playerScoreText.text = playerScore.ToString();

        NGreenBalls += 1;
        this.NGreenBallsText.text = NGreenBalls.ToString();

        Debug.Log("+5 pontos");
		GreenBall = GameObject.Find("Ball1(Clone)");
		//Destroy(GreenBall);
		newBall();

    }
        
    public void PlayerScores10(){
        playerScore = playerScore + 10;
        this.playerScoreText.text = playerScore.ToString();

        NYellowBalls += 1;
        this.NYellowBallsText.text = NYellowBalls.ToString();

        Debug.Log("+10 pontos");
		YellowBall = GameObject.Find("Ball2(Clone)");
		//Destroy(YellowBall);
		newBall();
    }

    public void PlayerScores1(){
        playerScore = playerScore + 1;
        this.playerScoreText.text = playerScore.ToString();

        NGreyBalls += 1;
        this.NGreyBallsText.text = NGreyBalls.ToString();

        Debug.Log("+1 pontos");
		GreyBall = GameObject.Find("Ball3(Clone)");
		//Destroy(GreyBall);
		newBall();
    }

	public void newBall(){
		Random rnd = new Random();
		int ballcolour = rnd.Next(1, 4); // creates a number between 1 and 3
		Vector3 center = new Vector3(0.000999927521f, 0.449999988f, -0.527999997f);

		if (ballcolour==1) Instantiate(GreenBall, center, Quaternion.identity);
		else if (ballcolour==2) Instantiate(YellowBall, center, Quaternion.identity);
		else Instantiate(GreyBall, center, Quaternion.identity);
	}

	public void wrongBucket(){
		
	}
}
