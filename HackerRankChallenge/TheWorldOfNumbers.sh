#!/bin/bash
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




