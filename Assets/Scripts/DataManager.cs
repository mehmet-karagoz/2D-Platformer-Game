using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TigerForge;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int shootBullet;


    public int totalShootBullet;
    private int enemyKilled;

    public int totalEnemyKilled;
    public static DataManager Instance;
    EasyFileSave myFile;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            StartProcess();
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int ShotBullet
    {

        get { return shootBullet; }
        set
        {
            shootBullet = value;
            GameObject.Find("ShotBulletText").GetComponent<Text>().text = "SHOT BULLET: " + shootBullet.ToString();
        }

    }

    public int EnemyKilled
    {
        get { return enemyKilled; }
        set
        {
            enemyKilled = value;
            GameObject.Find("EnemyKilledText").GetComponent<Text>().text = "ENEMY KILLED: " + enemyKilled.ToString();
        }
    }

    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();
    }

    public void SaveData()
    {
        totalEnemyKilled += enemyKilled;
        totalShootBullet += shootBullet;

        myFile.Add("totalEnemyKilled", totalEnemyKilled);
        myFile.Add("totalShootBullet", totalShootBullet);

        myFile.Save();
    }

    public void LoadData()
    {
        if (myFile.Load())
        {
            totalShootBullet = myFile.GetInt("totalShootBullet");
            totalEnemyKilled = myFile.GetInt("totalEnemyKilled");
        }
    }
}
