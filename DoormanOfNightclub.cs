using System;

/// <summary>
/// Ejercicio 1: El Portero de Discoteca
/// 
/// INSTRUCCIONES:
/// Completa el código para que el portero responda según la edad.
/// 
/// REGLAS:
/// - Menores de 18 años: "Fuera de aquí"
/// - Entre 18 y 60 años (inclusive): "Bienvenido a la fiesta"
/// - Mayores de 60 años: "Señor, el bingo es al lado
/// 
/// EJEMPLOS:
/// CheckAccess(15) → "Fuera de aquí"
/// CheckAccess(25) → "Bienvenido a la fiesta"
/// CheckAccess(65) → "Señor, el bingo es al lado"
/// </summary>
public class DoormanOfNightclub
{   
    // TODO: Usa if/else para asignar el mensaje correcto según la edad
    // Ejemplo: if (age < 18) { mensaje = "..."; }
    public static string CheckAccess(int age)
    {
        string mensaje = ""; 
        if (age < 18)
        {
            mensaje = "Fuera de aquí";
        }
        else if (age >= 18 && age <= 60)
        {
            mensaje = "Bienvenido a la fiesta";
        }
        else // age > 60
        {
            mensaje = "Señor, el bingo es al lado";
        }

        return mensaje;
    }
}