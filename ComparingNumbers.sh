#!/bin/bash
#Given two integers, X and Y, identify whether X < Y or X > Y or X=Y.

#Exactly one of the following lines:
#- X is less than Y
#- X is greater than Y
#- X is equal to Y

#Input Format

#Two lines containing one integer each (X and Y, respectively).

#Solution:
#Read X, Read Y,
#if (X<Y) 
#then print (X less than Y)
#elif (X>Y)
#then print (X greater than Y)
#else Print (X equa to Y)


read X
read Y
if [ $x -lt $y ] then
echo X is less than Y
elif [ $x -gt $y ] then
echo X is greater than Y
else echo X is equal to Y
fi
