using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class ChangeText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private Text myText;
    public string level;
    public AudioClip bloop;
    private AudioSource audio { get { return GetComponent<AudioSource>();} }
    void Start()
    {
        myText = GetComponentInChildren<Text>();
        gameObject.AddComponent<AudioSource>(); //initialize Audio Source
        audio.clip = bloop;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        myText.text = "PLAY!";
        audio.PlayOneShot(bloop,.6f); //clip and volume scale
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        myText.text = level;
        

    }
}