#!/bin/bash
#Given two integers, X and Y, find their sum, difference, product, and quotient.
#Input Format
#Two lines containing one integer each (X and Y, respectively).

#Constraints
#-100</=X,Y</=100

#Output Format
#Four lines containing the sum (X+Y), difference (X-Y), product (XxY), and quotient (X/Y), respectively.
#(While computing the quotient, print only the integer part.)

#Solution
#let the computer read inputs X & Y then
#expr x+y and print sum result
#expr x-y and print difference result
#expr x*y and print product result
#expr x/y and print quotiont result

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
