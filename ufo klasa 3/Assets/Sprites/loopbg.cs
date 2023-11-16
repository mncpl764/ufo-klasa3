using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class loopbg : MonoBehaviour
{
    private int limitPetli = 1000000;

    // Start is called before the first frame update
    void Start()
    {

        // Uruchom w�tek w tle do wykonania p�tli
        Thread watekWtle = new Thread(MetodaPetliWTle);
        watekWtle.Start();

        // Wykonaj inne inicjalizacje w g��wnym w�tku, je�li to konieczne

    }

    // Update is called once per frame
    void MetodaPetliWTle()
    {
        for (int licznik = 0; licznik < limitPetli; licznik++)
        {
            // Tutaj umie�� swoj� logik� p�tli

            // Przyk�ad: Zaloguj warto�� licznika do konsoli
            Debug.Log("Licznik: " + licznik);

            // Dodaj op�nienie, aby unikn�� wysokiego u�ycia procesora
            Thread.Sleep(1);

        }
        UnityMainThreadDispatcher.Instance().Enqueue(() =>
        {
            Debug.Log("Petla w tle zakonczona");
        });
    }
}