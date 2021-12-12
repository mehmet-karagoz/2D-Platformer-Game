using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerMenuScene : MonoBehaviour
{
    public GameObject dataBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void DataBoardButton()
    {
        DataManager.Instance.LoadData();
        dataBoard.transform.GetChild(2).GetComponent<Text>().text = "TOTAL ENEMY KILLED:\n" + DataManager.Instance.totalEnemyKilled.ToString();
        dataBoard.transform.GetChild(1).GetComponent<Text>().text = "TOTAL BULLET SHOT:\n" +  DataManager.Instance.totalShootBullet.ToString();
        dataBoard.SetActive(true);
    }

    public void XButton()
    {
        dataBoard.SetActive(false);
    }
}
