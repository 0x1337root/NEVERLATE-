using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private float time = 3f;

    public float countdown;

    private bool control = false;

    private float moveSpeed = 5f;

    public ScoreManager scoremanager;

    Rigidbody rb;

    void Start()
    {
        countdown = time;

        control = true;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (scoremanager.canStartable)
        {
            if (control)
            {
                countdown -= Time.deltaTime;
            }

            if(countdown <= .5f)
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            }

            if(countdown >= 2.5f)
            {
                scoremanager.time.color = Color.black;
            }

            else if(countdown < 2.5f && countdown >= 1.5f)
            {
                scoremanager.time.color = Color.white;
            }

            else
            {
                scoremanager.time.color = Color.red;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "LastWall")
        {
            scoremanager.score++;
            countdown = time;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ScoreWall")
        {
            scoremanager.score++;
        }

        if (other.tag == "FinishWall")
        {
            SceneManager.LoadScene(0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Wall")
        {
            SceneManager.LoadScene(0);
        }
    }
}
