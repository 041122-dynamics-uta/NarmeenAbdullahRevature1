#!/bin/bash
#Given three integers (, , and ) representing the three sides of a triangle, identify whether the triangle is scalene, isosceles, or equilateral.

#If all three sides are equal, output EQUILATERAL.
#Otherwise, if any two sides are equal, output ISOSCELES.
#Otherwise, output SCALENE.
#Input Format

#Three integers, each on a new line.

#Constraints
#1</=X,Y,Z</=1000
#Output Format
#
#One word: either "SCALENE" or "EQUILATERAL" or "ISOSCELES" (quotation marks excluded).



read X
read Y
read Z

if [ $X -eq $Y ] || [ $X -eq $Z ] || [ $Z -eq $Y ];
then
    if [ $((X+Y)) -eq $((Z*2)) ];
    then
        echo "EQUILATERAL"
    else
        echo "ISOSCELES"
        fi
else
    echo "SCALENE"
fi 


    

