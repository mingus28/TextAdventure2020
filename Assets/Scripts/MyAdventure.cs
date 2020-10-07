using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        ScreenText("Welkom bij de game");
        ScreenText("Have fun");
        ScreenText(" ");
        ScreenText("Typ start om te beginnen");

    }
    void OnUserInput(string input)
    {
        if (input == "start ")
        {
            StartIntro();
            
            {Terminal.WriteLine("Jij bent Leet!");}

        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude donkere nacht");
        Terminal.WriteLine("Een goede nacht om Fortnite te spelen");
        Terminal.WriteLine("Druk op start om te beginnen");
        
        
    }
    
    
    
    
    
    
    
    void ScreenText(string tekst)
    {
        Terminal.WriteLine(tekst);
    }

    // Update is called once per frame
    void Update()
    {

    }

}