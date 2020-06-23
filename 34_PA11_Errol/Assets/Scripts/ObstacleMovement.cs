using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    private bool added = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.TrueScore >= 10)
        {
            xSpeed = -7f;
        }
        else
            xSpeed = -4f;

        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x < -8 && added == false)
        {
            Player.TrueScore++;
            added = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameLose");
            Debug.Log("Collider");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger");
            SceneManager.LoadScene("GameLose");
        }
    }
}
