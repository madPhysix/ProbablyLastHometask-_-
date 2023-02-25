let n = 2552

if((n - n%1000)/1000 == (n%10)  && (n%1000 - n%100)/100 == (n%100 - n%10)/10)
{
    console.log("Yes")
}
else console.log("No")