using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//George samuels II
public class Results : MonoBehaviour
{
    //FIXME resetKeys doesn't really work * 12/11/16

    public Text p1score,p2score;
    public Text playerwins;
    public GameObject outterlayer;
    public static Results instance;
    private Image img;
    private string hexStringP1, hexStringP2;

    // Use this for initialization
    void Start()
    {
        instance = this;



    }

    // Update is called once per frame
    void Update()
    {


        p1score.text = PlayerCounting.instance.CountingAsteroidText.text; //gets player 1 count

        p2score.text = Player2Count.instance.CountingAsteroidText2.text;

        CheckWinner(p1score.text, p2score.text);
    }





    void CheckWinner(string p1, string p2)
    {

        //results to display

        if (p1.Equals("10"))
        {

          playerwins.text = "Player 1 Wins";
            playerwins.color = Color.white;

             img = GameObject.Find("DisplayShield").GetComponent<Image>();

            img.color = Color.magenta;
        }
           
        

     if (p2.Equals("10"))
        {

            playerwins.text = "Player 2 Wins";
            playerwins.color = Color.yellow;

            img = GameObject.Find("DisplayShield").GetComponent<Image>();

            img.color = Color.yellow;
        }

    }


    }