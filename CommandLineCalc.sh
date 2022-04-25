#!/bin/bash
#Now Pseudocode
#This is a Command Line Calculator using Bash
#As Follows:
#The user starts the bash script.
#The script welcomes the user
#The script presents the user with a menu that allows the user to choose between the options add, subtract, multiply, or divide.
#After the user chooses a calculation type, they are prompted to enter the two integers. This can be one integer at a time.
#After pressing enter, the result is presented to the user.
#The user can choose to exit the program or choose to make another calculation.

#Must allow the user to choose which calculation to make.
#Must get both integers from the user.
#Must create a different function for each calculation type and call each function to do that calculation.
#The calculation functions cannot print the result to the screen as this violates the single-responsibility principle (We’ll learn about this later).
#Print the result to the screen by calling a separate function called result.
#After the result is printed to the screen, you must present the user with the option to make another calculation or quit the program.




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


