using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore;

    public int PlayerScore { get => playerScore; set => playerScore = value;}
    [SerializeField] private Ball ballPrefab;
    [SerializeField] private GameObject[] ballPosition;
    public static GameManager instant;
    
    void Start()
    {
        instant = this;
        SetBall(BallColor.White,0);
        SetBall(BallColor.Red,1);
        SetBall(BallColor.Yellow,2);
        SetBall(BallColor.Green,3);
        SetBall(BallColor.Brown,4);
        SetBall(BallColor.Blue,5);
        SetBall(BallColor.Pink,6);
        SetBall(BallColor.Black,7);
        
    }
    
    void Update()
    {
        
    }

    private void SetBall(BallColor col, int i)
    {
        Ball ball = Instantiate(ballPrefab,ballPosition[i].transform.position,Quaternion.identity);
        ball.SetColorAndPoint(col);
    }
}
