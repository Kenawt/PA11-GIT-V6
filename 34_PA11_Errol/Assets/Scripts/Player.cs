using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public static int TrueScore;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        TrueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "SCORE : " + TrueScore;
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4, 4), transform.position.z);
    }
}
