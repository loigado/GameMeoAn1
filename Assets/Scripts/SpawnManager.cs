using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public List<GameObject> lsFoods = new List<GameObject>();
    public float timer = 3;
    public float countdown = 3;
    public float speed;

    public bool isStartGame = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (isStartGame && countdown <= 0)
        {
            countdown = timer;
            // Spawn random food
            int randomIndex = Random.Range(0, lsFoods.Count);
            GameObject goFood = Instantiate(lsFoods[randomIndex], transform);

            float randomPositionX = Random.Range(-2.5f, 2.5f);
            goFood.transform.localPosition = new Vector3(randomPositionX, 0, 0);


        }
    }
}
