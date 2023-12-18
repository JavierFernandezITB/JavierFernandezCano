document.body.hidden = false;
document.getElementById("greetings").textContent = "Bienvenido Anon";
document.getElementById("greetings").style.textAlign = "center";
document.getElementById("song").style.color = "magenta";
document.getElementById("song").style.textAlign = "center";
document.getElementById("song").style.fontStyle = "italic";
document.getElementById("titulo2").hidden = false;

IsBiggerThan(3,3);

console.log(Mult(3,2,1));

console.log(CalculateAverage(10,10,5));

function IsBiggerThan (a, b)
{
    console.log(a > b ? a + " es mayor que " + b : a + " no es mayor que " + b);
    return (a > b);
}

function Mult(num, times)
{
    var temp = 0;
    for (i = 0; i < times; i++)
    { temp += num; }
    return temp;
}

function Mult(num, num2, num3)
{
    var temp = 0;
    for (i = 0; i < num2; i++)
    { temp += num; }
    for (i = 0; i < num3; i++)
    { temp += num; }
    return temp;
}

function CalculateAverage (mark1, mark2, mark3)
{
    return parseFloat(mark1+mark2+mark3/3).toFixed(1);
}