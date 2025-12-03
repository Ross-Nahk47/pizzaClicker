using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{ 
    
     [SerializeField] TextMeshProUGUI textoTimer;
     [SerializeField] float tempoRestante;

    // Update is called once per frame
    void Start() 
    {
        
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos  = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}" , minutos, segundos);
    }

    
    void Update()
    {
        if(tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else
        {
            tempoRestante = 0;
            //GameOver();
            Time.timeScale = 0;
            textoTimer.color = Color.red;
        }


        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos  = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}" , minutos, segundos);
    }

}