FixedAmount = int(input("Please input the fixed amount you would like to pay each year: "))
LengthOfPayments = int(input("Please input how long you are paying for: "))
year = 0

print("Year   "+"Start   "+"Paid in   "+"Interest   "+"Final   ")

PaidIn = FixedAmount
interest = PaidIn*0.1
final = FixedAmount + interest
start = 0.0
for year in range (0, LengthOfPayments):
    print(" "+str(year)+ "      "+str(start)+"       "+str(PaidIn)+"       "+str(interest)+"      "+str(final))

    year+=1
    start+=final
    interest = (PaidIn+start)*0.1
    final = PaidIn + interest

