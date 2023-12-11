using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    TMP_Text infoText;
    [SerializeField]
    GameObject ballPrefab;
    [SerializeField]
    Transform ballSpawnLocation;

    [SerializeField]
    PointTrigger trigger101;
    [SerializeField]
    PointTrigger trigger102;
    [SerializeField]
    PointTrigger trigger103;
    [SerializeField]
    PointTrigger trigger104;
    [SerializeField]
    PointTrigger trigger105;
    [SerializeField]
    PointTrigger trigger201;
    [SerializeField]
    PointTrigger trigger202;
    [SerializeField]
    PointTrigger trigger203;
    [SerializeField]
    PointTrigger trigger204;
    [SerializeField]
    PointTrigger trigger301;
    [SerializeField]
    PointTrigger trigger302;
    [SerializeField]
    PointTrigger trigger303;
    [SerializeField]
    GameObject gtrigger101;
    [SerializeField]
    GameObject gtrigger102;
    [SerializeField]
    GameObject gtrigger103;
    [SerializeField]
    GameObject gtrigger104;
    [SerializeField]
    GameObject gtrigger105;
    [SerializeField]
    GameObject gtrigger201;
    [SerializeField]
    GameObject gtrigger202;
    [SerializeField]
    GameObject gtrigger203;
    [SerializeField]
    GameObject gtrigger204;
    [SerializeField]
    GameObject gtrigger301;
    [SerializeField]
    GameObject gtrigger302;
    [SerializeField]
    GameObject gtrigger303;

    int points;
    // Start is called before the first frame update
    void Start()
    {
        trigger101.pointValue = 10;
        trigger102.pointValue = 10;
        trigger103.pointValue = 10;
        trigger104.pointValue = 10;
        trigger105.pointValue = 10;
        trigger201.pointValue = 20;
        trigger202.pointValue = 20;
        trigger203.pointValue = 20;
        trigger204.pointValue = 20;
        trigger301.pointValue = 30;
        trigger302.pointValue = 30;
        trigger303.pointValue = 30;
        points = 0;
        updateScore(points);

        gtrigger101.SetActive(false);
        gtrigger102.SetActive(false);
        gtrigger103.SetActive(false);
        gtrigger104.SetActive(false);
        gtrigger105.SetActive(false);
        gtrigger201.SetActive(false);
        gtrigger202.SetActive(false);
        gtrigger203.SetActive(false);
        gtrigger204.SetActive(false);
        gtrigger301.SetActive(false);
        gtrigger302.SetActive(false);
        gtrigger303.SetActive(false);
    }
    
    public void startGame()
    {
        gtrigger101.SetActive(true);
        gtrigger102.SetActive(true);
        gtrigger103.SetActive(true);
        gtrigger104.SetActive(true);
        gtrigger105.SetActive(true);
        gtrigger201.SetActive(true);
        gtrigger202.SetActive(true);
        gtrigger203.SetActive(true);
        gtrigger204.SetActive(true);        
        gtrigger301.SetActive(true);
        gtrigger302.SetActive(true);
        gtrigger303.SetActive(true);
        spawnBall();
    }
    public void exitGame()
    {
        gtrigger101.SetActive(false);
        gtrigger102.SetActive(false);
        gtrigger103.SetActive(false);
        gtrigger104.SetActive(false);
        gtrigger105.SetActive(false);
        gtrigger201.SetActive(false);
        gtrigger202.SetActive(false);
        gtrigger203.SetActive(false);
        gtrigger204.SetActive(false);
        gtrigger301.SetActive(false);
        gtrigger302.SetActive(false);
        gtrigger303.SetActive(false);
        points = 0;
        updateScore(points);
    }
    void updateScore(int score)
    {
        infoText.text = "Score: " + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBall()
    {
        GameObject.Instantiate<GameObject>(ballPrefab, 
            ballSpawnLocation.position, Quaternion.identity);
    }

    public void sensorDetected(PointTrigger trigger)
    {
        points += trigger.pointValue;
        updateScore(points);
        spawnBall();
    }
}
