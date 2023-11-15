using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore;

    public int PlayerScore { get => playerScore; set => playerScore = value;}
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPosition;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
