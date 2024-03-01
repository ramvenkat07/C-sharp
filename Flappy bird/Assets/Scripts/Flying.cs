using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flying : MonoBehaviour
{
    Rigidbody2D capsule;
    [SerializeField]
    GameObject score;
    [SerializeField]
    GameObject gameOvertxt;
    [SerializeField]
    GameObject gameOver;
    bool isGameOver = false;
    int maxScore = 0;
    void Start()
    {
        capsule = transform.GetComponent<Rigidbody2D>();
        score.transform.GetComponent<TextMeshProUGUI>().text = 0.ToString();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            capsule.velocity = Vector2.up * 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        score.SetActive(false);
        gameOver.SetActive(true);
        gameOvertxt.SetActive(true);
        isGameOver = true;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "coin")
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        score.transform.GetComponent<TextMeshProUGUI>().text = (int.Parse(score.transform.GetComponent<TextMeshProUGUI>().text) + 1).ToString();



    }
}
