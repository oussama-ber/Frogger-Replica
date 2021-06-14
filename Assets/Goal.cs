using UnityEngine;
using UnityEngine.SceneManagement; 


public class Goal : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Frog")
        {
            Debug.Log("Goaaaaaaaaaaaaaaaaaaal !");

            Score.currentScore += 100;

            Car.minSpeed += 3f;
            Car.maxSpeed += 4f;
            Debug.Log("The speed has been increased.! "); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 


        }
    }
}
