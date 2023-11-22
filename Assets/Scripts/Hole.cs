using UnityEngine;

public class Hole : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
      Ball b = collision.gameObject.GetComponent<Ball>();

      if (b)
      {
         GameManager.instant.PlayerScore += b.Point;
         GameManager.instant.playerScoreText.text = $"Score={GameManager.instant.PlayerScore}";
         Destroy(b.gameObject);
      }
   }
}
