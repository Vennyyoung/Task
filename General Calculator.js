var firstNumber = prompt("Enter Your first Number: ");
var symbol = prompt("Enter An Operational symbol: ");
var secondNumber = prompt("Enter Your Second Number: ");
var result = 0

if (symbol = "+")
{
    result = Number(firstNumber) + Number(secondNumber);
}
else if(symbol = "-")
{
    result = Number(firstNumber) - Number(secondNumber);
}
else if(symbol = "*")
{
    result = Number(firstNumber) * Number(secondNumber);
}
else if(symbol = "/")
{
    result = Number(firstNumber) / Number(secondNumber);
}
alert("The answer is: " + result);
