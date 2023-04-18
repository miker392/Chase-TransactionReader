# Chase-TransactionReader

This program takes transactions from Chase, sanitizes the data, and prints out a clean table. I get the data from Chase's website itself and just copy and paste the text into a file. The input format should look like this:

```
Mar 31, 2023 	WENDY'S
	
	$11.58 	
Mar 31, 2023 	RAISING CANES
	
	$18.59 	
Mar 31, 2023 	Payment Thank You-Mobile
	— 	-$2,539.02 	
Mar 30, 2023 	SONIC DRIVE IN
	
	$7.00 	
Mar 28, 2023 	OLD NAVY US   
Pay over time
	
	$125.86 	
	
Mar 26, 2023 	DAIRY QUEEN
	
	$10.38 	
Mar 25, 2023 	TARGET.COM *
	
	$4.24 
```
The resulting format should look like this:

```
Date            Amount          Merchant
Mar 31          $11.58          WENDY'S
Mar 31          $18.59          RAISING CANES
Mar 30          $7.00           SONIC DRIVE IN
Mar 28          $125.86         OLD NAVY US
Mar 26          $10.38          DAIRY QUEEN #44857
Mar 25          $4.24           TARGET.COM *
```
