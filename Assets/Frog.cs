using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
   public Rigidbody2D rb; 



  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left); 




    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            Debug.Log("GAME OVER!");
            Score.currentScore = 0;

            Car.minSpeed = 8f;
            Car.maxSpeed = 12f; 

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }
}
