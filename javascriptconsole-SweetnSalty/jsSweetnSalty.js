let sw = 0; 
let st = 0;
let swst = 0;
let check = 0; //keep count of how many of each object there is
let line = '';

for ( var s = 1; s <= 1000; s++)// Print the numbers 1 to 1000 to the console. 
{
    console.log(s);
    if (s % 20 == 0)//seperates by 20 
    {
        console.log(line)
        line = '';
    }  
    if (s % 3 == 0 && s % 5 == 0)//divisible by 3 & 5
    {
        console.log("Sweet 'n' Salty ");
        swst++;
    }
    else if ( s % 3 == 0) //divisible by 3
    {
        console.log("Sweet");
        sw++;
    }
    else if (s % 5 == 0)//divisble by 5
    {
        console.log("Salty");
        st++;
    }            
    else
    {
        console.log(s);//Prints the Number
    }
    check++;                
}
//Outputs the Number of each
        console.log();
        console.log(`The Number of Sweet's are: ${sw}`);
        console.log(`The Number of Salty's are: ${st}`);
        console.log(`The Number of Sweet 'n' Salty's are: ${swst}`);
        console.log();