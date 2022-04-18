#!/bin/bash
#Your task is to use for loops to display only odd natural numbers from  to .
#Input Format
#There is no input.
#Output Format
#1
#3
#5
#.
#.
#.
#.
#.
#99  

#Solution:
#Range for loop couting from 1 to 99 only odd number (by adding 2)
#{
#print out the resulted number
# for i in { 1 .. 99 }

for (( i=1; i<100; i+=2 ))
do
	echo $i
done
