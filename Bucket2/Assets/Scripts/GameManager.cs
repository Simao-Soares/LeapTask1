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

	public GameObject[] GreenBalls;
	public GameObject[] YellowBalls;
	public GameObject[] GreyBalls;


	void Start()
	{
		//newBall();
        //uncomment for bucket task 
	}




    public void PlayerScores5(){
        playerScore = playerScore + 1;
        this.playerScoreText.text = playerScore.ToString();

        NGreenBalls += 1;
        this.NGreenBallsText.text = NGreenBalls.ToString();
		GreenBalls = GameObject.FindGameObjectsWithTag("Green");

		newBall();


    }
        
    public void PlayerScores10(){
        playerScore = playerScore + 1;
        this.playerScoreText.text = playerScore.ToString();

        NYellowBalls += 1;
        this.NYellowBallsText.text = NYellowBalls.ToString();

		YellowBalls = GameObject.FindGameObjectsWithTag("Yellow");

		newBall();

    }

    public void PlayerScores1(){
        playerScore = playerScore + 1;
        this.playerScoreText.text = playerScore.ToString();

        NGreyBalls += 1;
        this.NGreyBallsText.text = NGreyBalls.ToString();

		GreyBalls = GameObject.FindGameObjectsWithTag("Grey");

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


    //---------------------------- ROWING ------------------------------------

    public GameObject LeftRow;
    public GameObject RightRow; 

    IEnumerator Wait05(){
        yield return new WaitForSecondsRealtime(0.5f);
    }

    public void leftRowUI(){
        LeftRow.SetActive(true);
        Wait05();
        LeftRow.SetActive(false);
    }

    public void rightRowUI(){
        RightRow.SetActive(true);
        Wait05();
        RightRow.SetActive(false);
    }


}
