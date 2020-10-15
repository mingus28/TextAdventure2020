using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgesprek,
        eind
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
        
    }

    void ShowMainMenu()
    {
        currentState = States.start;
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij TextAdventure");
        Terminal.WriteLine("Have fun ;)");
        Terminal.WriteLine("Typ volgende om te beginnen");
    }

    void StartIntro1()
    {
        currentState = States.intro1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent verdwaald en ziet een huis, je neemt een kijkje");
        Terminal.WriteLine("Je zit eraan te denken om de deur te openen");
        Terminal.WriteLine("Typ verder om de deur te openen");
    }

    void StartIntro2()
    {
        currentState = States.intro2;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt de deur geopend.");
        Terminal.WriteLine("Je loopt naar binnen.");
        Terminal.WriteLine("Typ verder om door te gaan");
    }

    void Delen()
    {
        currentState = States.delen;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent nu in het huis");
        Terminal.WriteLine("Je komt een man tegen, hij loopt naar je toe");
        Terminal.WriteLine("Wil je vluchten? Typ ja. Vertrouw je de man en blijf je in het huis? Typ nee.");
    }

    void Deelnee()
    {
        currentState = States.deelnee;
        Terminal.ClearScreen();
        Terminal.WriteLine("Helaas, de man dacht dat je een inbreker was en viel je aan. Game over.");
        Terminal.WriteLine("Better luck next time");
        Terminal.WriteLine("Typ helaas om door te gaan te gaan.");
    }

    void Deelja()
    {
        currentState = States.deelja;
        Terminal.ClearScreen();
        Terminal.WriteLine("Goede keuze, in het huis blijven had een fatale keuze geweest.");
        Terminal.WriteLine("Je bent veilig. Gefeliciteerd");
        Terminal.WriteLine("Typ nice om door te gaan.");
    }
    
    void eind()
    {
        currentState = States.eind;
        Terminal.ClearScreen();
        Terminal.WriteLine("Bedankt voor het spelen van Textadventure");
        Terminal.WriteLine("Typ stoppen om naar het hoofdmenu te gaan ");



    }
    
    

    void Write(string tekst)
    {
        Terminal.WriteLine(tekst);
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro1();
                }
                else if (input == "volgende")
                {
                    Write("Leuk geprobeerd makker ;). Je moest eigenlijk start typen.");
                }
                else
                {
                    Write("Dat commando bestaat niet");
                }
                break;
            case States.intro1:
                if (input == "verder")
                {
                    StartIntro2();
                }
                else
                {
                    Write("Dat commando bestaat niet");
                }
                break;
            case States.intro2:
                if (input == "verder")
                {
                    Delen();
                }
                else
                {
                    Write("Dat commando bestaat niet");
                }
                break;
            case States.delen:
                if (input == "ja")
                {
                    Deelja();
                }
                else if (input == "nee")
                {
                    Deelnee();
                }
                else
                {
                    Write("Dat commando bestaat niet");
                }
                break;
            case States.deelja:
                if (input == "nice")
                {
                    eind();
                }

                break;
            
            case States.deelnee:
                if (input == "helaas")
                {
                    eind();
                }

                break;


            case States.eind:
                if (input == "stoppen")
                {
                    ShowMainMenu();
                }
                break;
            
        }
        /*
        if (currentState == States.start)
        {
            if (input == "start")
            {
                StartIntro1();
            }else if (input == "1337")
            {
                Write("Jij bent leet!");
            }
        }else if (currentState == States.intro1)
        {
            if (input == "verder")
            {
                StartIntro2();
            }
        }else if (currentState == States.intro2)
        {
            if (input == "verder")
            {
                Delen();
            }
        }else if (currentState == States.delen)
        {
            if (input == "ja")
            {
                Deelja();
            }else if (input == "nee")
            {
                Deelnee();
            }
        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
    }

}