var confirmation = confirm("Seguro que quires ver el contenido de esta web?");
var sConfirmation = prompt("Introduce SI para acceder.");
if (confirmation && sConfirmation.toLowerCase() === "si")
{
    var userName = prompt("Introduce tu nombre.");
    document.body.hidden = false;

    document.getElementById("titulo1").hidden = false;
    document.getElementById("greetings").textContent = "Bienvenido " + userName;
    document.getElementById("greetings").style.textAlign = "center";
    document.getElementById("song").style.color = "magenta";
    document.getElementById("song").style.textAlign = "center";
    document.getElementById("song").style.fontStyle = "italic";

    // Ejercicio 1.

    var ex1_buttonNumber = prompt("Introduce el número de botones.");
    var ex1_columnNum = prompt("Introduce el número de columnas.");
    var ex1_buttonsPerDiv = ex1_buttonNumber / ex1_columnNum;

    var ex1_lastContainer = CreateButtons(ex1_buttonNumber, ex1_columnNum, ex1_buttonsPerDiv);
    let ex1_lastButton = document.createElement("button");
    ex1_lastButton.innerText = 0; // So the first number starts from 1 to X.
    ex1_lastButton.className = "botonNumero";
    ex1_lastButton.style.width = 105 * ex1_buttonsPerDiv + "px";
    ex1_lastContainer.appendChild(ex1_lastButton)
}

function CreateButtons(buttons, columns, buttonsPerDiv)
{
    let ex1_buttonText = 1;
    var ex1_buttonsMade = 0;
    
    var ex1_lastContainer;
    for (i = 0; i < buttonsPerDiv+1; i++)
    {
        var ex1_container = document.createElement("div");
        ex1_container.id = "ex1_contenedor";
        document.body.appendChild(ex1_container);
        for (x = 0; x < ex1_columnNum; x++)
        {
            if (ex1_buttonsMade < buttons)
            {
                let ex1_button = document.createElement("button");
                ex1_button.innerText = ex1_buttonText; // So the first number starts from 1 to X.
                ex1_button.className = "botonNumero";
                ex1_container.appendChild(ex1_button)
                ex1_buttonText++;
                ex1_buttonsMade++;
            }
        }
        if (i == buttonsPerDiv)
        { ex1_lastContainer = ex1_container }
    }
    return ex1_lastContainer;
}