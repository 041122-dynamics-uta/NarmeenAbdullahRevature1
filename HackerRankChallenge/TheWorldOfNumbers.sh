#!/bin/bash
#Given two integers,  and , find their sum, difference, product, and quotient.

#Input Format

#Two lines containing one integer each ( and , respectively).

#Constraints



#Output Format

#Four lines containing the sum (), difference (), product (), and quotient (), respectively.
#(While computing the quotient, print only the integer part.)
echo Enter Number1
read x
echo Enter Number2
read y
echo Sum is:
expr $x + $y
echo Difference is: $(( x - y ))
expr $x - $y
echo Product is: $(( x * y ))
expr $x \* $y
echo Quotiont is: $(( x / y ))
expr $x / $y




