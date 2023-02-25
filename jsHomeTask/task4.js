let number = 4321
let number2 = (1000 * (number%10)) + (10 * (number % 100 - number % 10) + ((number%1000 - number%100)/10) 
+ (number%10000 - number%1000)/1000)
console.log(number2)