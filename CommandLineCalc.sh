#!/bin/bash
#Now Pseudocode
#This program allow User to choose one of four different calculations
#Then it asks user to enter two number to execute the chosen calculation
#if choice=1 then print $(( num + num2 ))
#if choice=2 print $(( num - num2 ))
#if choice=3 print $(( num * num2 ))
#if choice=4 print $(( num / num2 ))
#Ask user if want to continue, if yes do again .. if no exit and done
#use functions for calculation types Add(), Subtract (), Multiply(), Divide()




echo "                                                     "
echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
echo ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
echo "                                                     "
echo "HEY! WHATS YOUR NAME PLEASE?"
echo "                                                     "
read name
echo "                                                     "
echo "HELLO $name, WELCOME TO COMMAND LINE CALCULATOR"
echo "                                                     "
echo "CHOOSE ONE OF THE FOLLOWING FOUR CALCULATIONS"
echo "                                                     "


Menu () {

echo "Enter 1 to Add"
echo "Enter 2 to Subtract"
echo "Enter 3 to Multiply"
echo "Enter 4 to Divide"
echo "                                                              "

Addition () {

        expr=$(( n1 + n2 ))
}

Subtraction () {

        expr=$(( n1 - n2 ))
}

Multiplication () {

        expr=$(( n1 \* n2 ))
}


Division () {

        expr=$(( n1 / n2 ))
}


Result () {

        echo
        echo The Result Is: $expr
        echo
}

read choice

#__________________________________________________________________________________

if [ $choice == 1 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Addition
Result #Print value of n1 + n2

#__________________________________________________________________________________

elif [ $choice == 2 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Subtraction
Result

#__________________________________________________________________________________

elif [ $choice == 3 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Multiplication
Result

#__________________________________________________________________________________

elif [ $choice == 4 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Division
Result

#__________________________________________________________________________________



else #if the user enter wrong choice

        echo "                                                             "
        echo "THIS IS NOT A VALID OPTION .. PLEASE INPUT OPTION FROM 1 TO 4"
        Menu
fi

#__________________________________________________________________________________


Show () {

if [ $decesion == "YES" ] || [ $decesion == "yes" ] || [ $decesion == "Yes" ]
then
        echo "                                                   "
        echo "Continuing Now"
        echo "                                                   "
        echo ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
        echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
        echo "                                                      "

        Menu


elif [ $decesion == "no" ] || [ $decesion == "NO" ] || [ $decesion == "No" ]
then
        echo ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>"
        echo "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
        echo "                                                      "
        echo "Sorry to see you leave, Bye!!!"

exit


else
        echo "Please choose either to continue or to stop by typing Yes or No "
        read decesion

        Show
fi
}

echo "Do you Want to Make Another Calculation? Yes or No"
read decesion
Show




}
Menu


