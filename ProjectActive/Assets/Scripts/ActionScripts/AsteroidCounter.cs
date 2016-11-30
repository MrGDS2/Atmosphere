using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    private int TotalAsteroids;
    public Text CountAsteroids;
    void start()
    {

    }

    void update()
    {
         //count only if something blew up
                 
        TotalAsteroids++;
        CountAsteroids.text = TotalAsteroids.ToString();
        // AddCount(TotalAsteroids);
    }
}