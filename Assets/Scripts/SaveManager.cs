using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
   
   [SerializeField] Text nameText;

   [SerializeField] Text scoreText;

   [SerializeField] Text positonText;

   [SerializeField] string userName;
   [SerializeField] int userScore;
   [SerializeField] Vector3 userPosition;
   
   
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }


    public void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
        PlayerPrefs.SetInt("score", userScore);
        PlayerPrefs.SetFloat("posX", userPosition.x);
        PlayerPrefs.SetFloat("posY", userPosition.y);
        PlayerPrefs.SetFloat("posZ", userPosition.z);
    }

    void LoadData()
    {
        userName = PlayerPrefs.GetString("name", "No name");
        userScore = PlayerPrefs.GetInt("score", 0);
       
        nameText.text = "User Name: " + userName;
        scoreText.text ="User Score: " + userScore.ToString();


        positonText.text = "User Position: " + PlayerPrefs.GetFloat("posX", 0).ToString() + "x "+ PlayerPrefs.GetFloat("posY", 0).ToString() +"y "+ PlayerPrefs.GetFloat("posZ", 0).ToString() + "z";

    }


}


