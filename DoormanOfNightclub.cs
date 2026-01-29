using System;

/// <summary>
/// Ejercicio 1: El Portero de Discoteca
/// 
/// INSTRUCCIONES:
/// Completa el código para que el portero responda según la edad.
/// 
/// REGLAS:
    if (age < 18)
    {

        return "Fuera de aquí";
    }
    else if (age <= 60)
    {
        return "Bienvenido a la fiesta";
    }
    else
    {
        return "Señor, el bingo es al lado";
    } 

/// 
/// EJEMPLOS:
/// CheckAccess(15) → "Fuera de aquí"
/// CheckAccess(25) → "Bienvenido a la fiesta"
/// CheckAccess(65) → "Señor, el bingo es al lado"
/// </summary>
public class DoormanOfNightclub
{
    public static string CheckAccess(int age)
    {
        string mensaje = ""; 
        
        // TODO: Usa if/else para asignar el mensaje correcto según la edad
        if (age < 18) { mensaje = "18"; }
        
        return mensaje;
    }
}
