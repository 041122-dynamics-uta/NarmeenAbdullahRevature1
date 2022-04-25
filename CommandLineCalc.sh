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
#Line-25
Menu () {

echo "Enter 1 to Add"
echo "Enter 2 to Subtract"
echo "Enter 3 to Multiply"
echo "Enter 4 to Divide"
echo "                                                              "

Addition () {
        echo "The Result of Add Operation is:"
        expr $n1 + $n2
}

Subtraction () {
        echo "The Result of Subtract Operation is:"
        expr $n1 - $n2
}

Multiplication () {
        echo "The Result of Multiply Operation is:"
        expr $n1 \* $n2
}


Division () {
        echo "The Result of Divide Operation is:"
        expr $n1 / $n2
}



read choice


if [ $choice == 1 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Addition
echo The Result of Add Operation is: $expr


elif [ $choice == 2 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Subtraction





elif [ $choice == 3 ]
	then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Multiplication





elif [ $choice == 4 ]
then
echo "Enter The First Number"
read n1

echo "Enter The Second Number"
read n2

Division





else

        echo "                                                             "
        echo "THIS IS NOT A VALID OPTION .. PLEASE INPUT OPTION FROM 1 TO 4"
        Menu
fi




#echo "Enter The Second Number"
#read n2

#echo "The Result of Add Operation is:"
#expr $n1 + $n2


#__________________________________________________________________________________

#elif [ $choice == 2 ]
#then
#echo "Enter The First Number"
#read n1

#echo "Enter The Second Number"
#read n2

#echo "The Result of Subtract Operation is:"
#expr $n1 - $n2



#__________________________________________________________________________________

#elif [ $choice == 3 ]
#then
#echo "Enter The First Number"
#read n1
#read n2

#       echo "The Result of Multiply Operation is:"
#expr $n1 \* $n2


#__________________________________________________________________________________

#elif [ $choice == 4 ]
#then
#echo "Enter The First Number"
#read n1

#echo "Enter The Second Number"
#read n2
#Line-90
#       echo "The Result of Divide Operation is:"
#expr $n1 / $n2

#__________________________________________________________________________________

#else

#       echo "                                                             "
#       echo "THIS IS NOT A VALID OPTION .. PLEASE INPUT OPTION FROM 1 TO 4"
#       Menu
#fi



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


