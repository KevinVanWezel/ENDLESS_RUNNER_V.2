using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour {
    
    public List<GameObject> Enemy;
    public Transform EnemySpawnplace;
    public Transform followerPlace;
    public AntiPlayerCamping follower;
    [SerializeField]
    private float spawntime = 3;
    private float nextEnemy;
    private float spawnbereik;
    public Text ScoreText;
    public int score;

     void Start()
    {
        UpdateScore();
    }
    void Update () {
        spawnbereik = Random.Range(-4f, 3f);
        Vector3 position = new Vector3(EnemySpawnplace.position.x, spawnbereik, -1);
        if (Time.time > nextEnemy)
        {
            nextEnemy = Time.time + spawntime;
            if(follower.FocusShot == true)
            {
                position = new Vector3(EnemySpawnplace.position.x, followerPlace.position.y, -1);
                Instantiate(Enemy[Random.Range(0, 2)], position, EnemySpawnplace.rotation);
                follower.FocusShot = false;
                follower.timer = 0;
            }
            else if (spawnbereik <= -2f)
            {
                Instantiate(Enemy[2], position, EnemySpawnplace.rotation);
            }
            else
            {
                Instantiate(Enemy[Random.Range(0,2)], position, EnemySpawnplace.rotation);
            }
        }
	}
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore ()
    {
        ScoreText.text = "score: " + score;
    }
}

