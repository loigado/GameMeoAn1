using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysics : MonoBehaviour
{
    public int scores = 0;
    public int lives = 3;
    public Animator animator;

    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        transform.position = new Vector3(mousePosition.x, transform.position.y);
        //Debug.Log("MousePosition: " + mousePosition);
    }

    private void FixedUpdate()
    {
        //Debug.Log("FixedUpdate");
    }

    private void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger");
        animator.SetTrigger("isEat");
        if (collision.tag == "Food")
        {
            Debug.Log("Food");
            scores++;
            uiManager.UpdateScore(scores);

            animator.SetTrigger("isEatFull");
        }
        else
        {
            Debug.Log("FuckFood");
            lives--;
            animator.SetTrigger("isEatFuck");
            uiManager.UpdateLives(lives);

            if (lives <= 0)
            {
                // Game over
                uiManager.ShowGameOver();
            }
        }

        Destroy(collision.gameObject);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }
}
