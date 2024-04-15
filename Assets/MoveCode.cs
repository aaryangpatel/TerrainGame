using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MovingCode : MonoBehaviour
{
    public TextMeshProUGUI TextPro;
    void Start()
    {
        transform.position = new Vector3(559f, -156f, -55f);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.05f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.05f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 0.05f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * 0.05f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 0.5f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down, 0.5f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left, 0.5f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right, 0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * 0.1f;
        }
    }

    int score = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gem" || collision.gameObject.tag == "NPC")
        {
            score++;
            TextPro.text = "Score: " + (score);
            Destroy(collision.gameObject);
        }
        if (score == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
}