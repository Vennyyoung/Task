var firstNumber = prompt("Enter Your first Number: ");
var secondNumber = prompt("Enter Your Second Number: ");
var symbol = prompt("Enter An Operation Symbol: ");
var result =

if (symbol === "+")
{
    result === firstNumber + secondNumber;
}
else if(symbol === "-")
{
    result === firstNumber - secondNumber;
}
else if(symbol === "*")
{
    result === firstNumber * secondNumber;
}
else if(symbol ==="/")
{
    result === firstNumber / secondNumber;
}
alert("The answer is: " + result);