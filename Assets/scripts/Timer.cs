using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{ 
    
     [SerializeField] TextMeshProUGUI textoTimer;
     [SerializeField] float tempoRestante;
    public bool acabou = false;
    // Update is called once per frame
    void Start() 
    {
        
        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos  = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}" , minutos, segundos);
    }

    
    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
        }
        else
        {
            tempoRestante = 0;
            //GameOver();
            textoTimer.color = Color.red;
            acabou = true;
            Time.timeScale = 0;
        }


        int minutos = Mathf.FloorToInt(tempoRestante / 60);
        int segundos  = Mathf.FloorToInt(tempoRestante % 60);
        textoTimer.text = string.Format("{0:00}:{1:00}" , minutos, segundos);
    }

}