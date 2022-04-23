#!/bin/bash
#Now Pseudocode
#This program allow User to choose one of four different calculations
#Then it asks user to enter two number to execute the chosen calculation 
#if choice=1 then print $(( num + num2 ))
#if choice=2 print $(( num - num2 ))
#if choice=3 print $(( num * num2 ))
#if choice=4 print $(( num / num2 ))
#Ask user if want to continue, if yes do again .. if no exit and done
#use a loop 


echo "                                                     "
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
echo ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "                                                     "
echo "Welcome to Narmeens Calculator"
echo "                                                     "
echo "I Have 4 Calculation Options for you:"
echo "                                                     "

Menu () {

echo "Enter 1 to Add"
echo "Enter 2 to Subtract"
echo "Enter 3 to Multiply"
echo "Enter 4 to Divide"
echo "                                                              "

read choice

#echo "Enter The First Number"
#read n1

#echo "Enter The Second Number"
#read n2

#__________________________________________________________________________________

if [ $choice == 1 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

echo "The Result of Add Operation is:" 
expr $n1 + $n2
fi

#__________________________________________________________________________________

if [ $choice == 2 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

echo "The Result of Subtract Operation is:"
expr $n1 - $n2

fi

#__________________________________________________________________________________

if [ $choice == 3 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

	echo "The Result of Multiply Operation is:"
expr $n1 \* $n2
fi

#__________________________________________________________________________________

if [ $choice == 4 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

	echo "The Result of Divide Operation is:"
expr $n1 / $n2
fi

#__________________________________________________________________________________



#	echo "Please Input A Choice From 1 to 4"
#	Menu

#echo "Enter The First Number"
#read n1

#echo "Enter The Second Number"
#read n2



echo "Do you Want to Make Another Calculation? Yes or No"
read decesion

if [ $decesion == "YES" ] || [ $decesion == "yes" ]
then 
	echo "                                                   "
	echo "Continuing Now"
	echo "                                                   "
	Menu
fi 


if [ $decesion == "no" ] || [ $decesion == "NO" ]
echo " I'm Sorry to see you leave Bye!"
then
exit	
fi

}

Menu

echo "                           "
echo "This Is Not A Valid Choice"     #if user did not enter choice [1..4]
echo "                           "
echo "Please Input A Choice From 1 to 4"
       Menu

echo " Thank you, Wish you All The Best"


