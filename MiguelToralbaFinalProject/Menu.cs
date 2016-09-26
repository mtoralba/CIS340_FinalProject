// Miguel Toralba CIS-340 9:00AM Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiguelToralbaFinalProject
{
    class Menu
    {
        static void Main(string[] args)
        {
            //Variable Declared
            string userInput;
            bool wasItValid = true;
            int mealIndex = 0;
            int numberOfMealsOrdered = 0;
            int availableMeals = 0;
            bool mealsAreAvailable = false;
            string selectedMeal = "";
            string mealInputToValidate = "";
            bool isStudent = false;
            bool accessGranted = false;
            string studentInitials = "";
            string enteredSecretCode = "";
            int customerIndex = 0;
            double subtotal = 0;
            int customerCreditBalance = 0;
            double customerMoneyBalance = 0;
            int finalCreditBalance = 0;
            double finalMoneyBalance = 0;
            double salesTax = subtotal * 0.10;
            double totalPrice = salesTax + subtotal;
            bool quitApp = false;
            bool payedWithHonorsCredit = false;
            double remainingHonorsBalance;

            //Meal Array & Customer Array Created
            Meal[] mealArray = new Meal[3];
            Customer[] customerArray = new Customer[3];

            //Play Array & Member Array Elements 
            mealArray[0] = new Meal("Breakfast", 6.25, 10);
            mealArray[1] = new Meal("Lunch", 7.95, 20);
            mealArray[2] = new Meal("Dinner", 9.80, 35);

            customerArray[0] = new Customer("mt", "Miguel", "Toralba", "ASU", "AZ", 3.6, "00", 5, 30.99);
            customerArray[1] = new Customer("bw", "Bruce", "Wayne", "University of Arizona", "AZ", 3.0, "44", 1, 1289.62);
            customerArray[2] = new Customer("sv", "Sofia", "Vergara", "UCLA", "CA", 3.49, "55", 100, 4.25);

            for (int i = 0; i < customerArray.Length; i++)
            {
                if (customerArray[customerIndex].GetCustomerGPA() > 3.5)
                {
                    customerArray[customerIndex].SetHonorsCredit(1);
                }
            }

            do
            {
                do
                {
                    for (int i = 0; i < mealArray.Length; i++)
                    {
                        Console.WriteLine("{0}. {1}\tPrice: {2:C}\tQuantity Available: {3}", i + 1, mealArray[i].GetMealType(), mealArray[i].GetMealPrice(), mealArray[i].GetMealQuantityAvailable());
                    }

                    Console.WriteLine("------------------------------------------------------\n");
                    Console.WriteLine(".::::::::::: Welcome to Oasis Cafeteria! ::::::::::::.\n");
                    Console.Write("Please Enter the Meal Type Number you would like to order to continue or 'Q' to exit: ");

                    userInput = Console.ReadLine();

                    //switch statement to validate userInput
                    switch (userInput)
                    {
                        case "1":
                            wasItValid = true;
                            Console.Clear();
                            Console.WriteLine("Meal Selected: {0}\tPrice: {1:C}\tQuantity Available: {2}", mealArray[0].GetMealType(), mealArray[0].GetMealPrice(), mealArray[0].GetMealQuantityAvailable());
                            Console.WriteLine();
                            break;
                        case "2":
                            wasItValid = true;
                            Console.Clear();
                            Console.WriteLine("Meal Selected: {0}\tPrice: {1:C}\tQuantity Available: {2}", mealArray[1].GetMealType(), mealArray[1].GetMealPrice(), mealArray[1].GetMealQuantityAvailable());
                            Console.WriteLine();
                            break;
                        case "3":
                            wasItValid = true;
                            Console.Clear();
                            Console.WriteLine("Meal Selected: {0}\tPrice: {1:C}\tQuantity Available: {2}", mealArray[2].GetMealType(), mealArray[2].GetMealPrice(), mealArray[2].GetMealQuantityAvailable());
                            Console.WriteLine();
                            break;
                        case "q":
                        case "Q":
                            quitApp = true;
                            wasItValid = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::\nInvalid Entry, Please Enter a meal type 1,2 or 3!\n:::::::::::::::::::::::::::::::::::::::::::::::::\n\n------------------------------------------------------");
                            wasItValid = false;
                            break;
                    }

                } while (wasItValid == false);


                if (!quitApp)
                {
                    mealIndex = Convert.ToInt32(userInput) - 1;

                    do
                    {
                        Console.Write("Please enter the amount of meals you would like to purchase: ");

                        mealInputToValidate = Console.ReadLine();

                        //Meal Limit is 30
                        if (mealInputToValidate != "1" && mealInputToValidate != "2" && mealInputToValidate != "3" &&
                            mealInputToValidate != "4" && mealInputToValidate != "5" && mealInputToValidate != "6" &&
                            mealInputToValidate != "7" && mealInputToValidate != "8" && mealInputToValidate != "9" &&
                            mealInputToValidate != "10" && mealInputToValidate != "11" && mealInputToValidate != "12" &&
                            mealInputToValidate != "13" && mealInputToValidate != "14" && mealInputToValidate != "15" &&
                            mealInputToValidate != "16" && mealInputToValidate != "17" && mealInputToValidate != "18" &&
                            mealInputToValidate != "19" && mealInputToValidate != "20" && mealInputToValidate != "21" &&
                            mealInputToValidate != "22" && mealInputToValidate != "23" && mealInputToValidate != "24" &&
                            mealInputToValidate != "25" && mealInputToValidate != "26" && mealInputToValidate != "27" &&
                            mealInputToValidate != "28" && mealInputToValidate != "29" && mealInputToValidate != "30" &&
                            mealInputToValidate != "31" && mealInputToValidate != "32" && mealInputToValidate != "33" &&
                            mealInputToValidate != "34" && mealInputToValidate != "35" && mealInputToValidate != "0")
                        {
                            Console.Clear();
                            Console.WriteLine("Meal Selected: {0}\tPrice: {1:C}\tQuantity Available: {2}", mealArray[mealIndex].GetMealType(), mealArray[mealIndex].GetMealPrice(), mealArray[mealIndex].GetMealQuantityAvailable());
                            Console.WriteLine("\n:::::::::::::::::::::: Invalid Entry :::::::::::::::::::::::\n\n\tEnter appropriate amount of meals available\n\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
                            mealsAreAvailable = false;
                        }
                        else
                        {
                            //mealInputToValidate has passed validation and now becomes numberOfMeals
                            numberOfMealsOrdered = Convert.ToInt32(mealInputToValidate);
                            //return the available meals for the selected meal type and store it in availableMeals
                            availableMeals = mealArray[mealIndex].GetMealQuantityAvailable();
                            selectedMeal = mealArray[mealIndex].GetMealType();

                            if (numberOfMealsOrdered > availableMeals)
                            {
                                Console.Clear();
                                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n\nSorry there are only " + availableMeals + " meals left available for the " + selectedMeal + " meal.\n\n::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
                                mealsAreAvailable = false;
                            }
                            else
                            {
                                mealsAreAvailable = true;
                            }
                        }
                    } while (!mealsAreAvailable);

                    Console.Clear();
                    Console.WriteLine("\t\t\t\tSubtotal\n--------------------------------------------------------------------\nMeal Selected: " + mealArray[mealIndex].GetMealType() + "\tQuantity Ordered: " + numberOfMealsOrdered + "\tPrice: $" + mealArray[mealIndex].GetMealPrice() * numberOfMealsOrdered + "\n");

                    subtotal = mealArray[mealIndex].GetMealPrice() * numberOfMealsOrdered;

                    Console.Write("To verify Student account enter 's', otherwise enter any key to continue as a Guest: ");
                    userInput = Console.ReadLine().ToLower();

                    if (userInput == "s")
                    {

                        Console.Write("\n:::::::::Login Information::::::::\nPlease Enter Your Initials: ");
                        studentInitials = Console.ReadLine().ToLower();
                        Console.Write("Please Enter Your Secret Code: ");
                        enteredSecretCode = Console.ReadLine();
                        Console.WriteLine("::::::::::::::::::::::::::::::::::");


                        //for loop to match entered login credentials with correct customer, only if login credentials are both valid
                        for (int i = 0; i < customerArray.Length; i++)
                        {
                            if (studentInitials == customerArray[i].GetCustomerInitials() && enteredSecretCode == customerArray[i].GetCustomerCode())
                            {
                                customerIndex = i;
                                Console.Clear();
                                Console.WriteLine("\nWelcome! You are now logged in as " + customerArray[i].GetCustomerFirstName() + " " + customerArray[i].GetCustomerLastName());
                                accessGranted = true;
                                isStudent = true;
                            }
                        }

                        //continue as guest after failed login attemp
                        if (!accessGranted)
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect username or password!\n\nYou are now signed in as a Guest!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\n::::::: Welcome Guest! ::::::::");
                    }

                    customerCreditBalance = 0;
                    customerMoneyBalance = 0;
                    finalCreditBalance = 0;
                    finalMoneyBalance = 0;
                    salesTax = subtotal * 0.10;
                    totalPrice = salesTax + subtotal;

                    wasItValid = true;

                    if (isStudent == true)
                    {
                        do
                        {
                            Console.WriteLine("-------------------------------\nPlease select a payment option:\n-------------------------------\n1. Use Meal Plan Credits\n2. Use Card\n3. View Plan Credit & Card Balance\n4. Cancel");
                            if (customerArray[customerIndex].GetHonorsCredit() == 1)
                            {
                                Console.WriteLine("5. Use honor credit for free meal.");
                            }
                            userInput = Console.ReadLine();
        
                            remainingHonorsBalance = subtotal - mealArray[mealIndex].GetMealPrice();

                            switch (userInput)
                            {
                                case "1":
                                    customerCreditBalance = customerArray[customerIndex].GetCustomerCredits();
                                    customerMoneyBalance = customerArray[customerIndex].GetCustomerBalance();

                                    //check if the member has sufficient credits
                                    if (customerCreditBalance < numberOfMealsOrdered)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Oops! You dont have enough credits to make this purchase.");
                                        //return to payment choices;
                                        Console.WriteLine("Press Enter to return to payment options");
                                        Console.ReadLine();
                                        wasItValid = false;
                                    }
                                    else if (payedWithHonorsCredit == true)
                                    {
                                        finalMoneyBalance = customerMoneyBalance;
                                        finalCreditBalance = (customerCreditBalance - (numberOfMealsOrdered - 1));
                                        customerArray[customerIndex].SetCustomerCredits(finalCreditBalance);
                                        salesTax = 0.00;
                                        wasItValid = true;
                                    }
                                    else
                                    {
                                        finalMoneyBalance = customerMoneyBalance;
                                        finalCreditBalance = (customerCreditBalance - numberOfMealsOrdered);
                                        customerArray[customerIndex].SetCustomerCredits(finalCreditBalance);
                                        salesTax = 0.00;
                                        wasItValid = true;
                                    }
                                    break;

                                case "2":
                                    customerMoneyBalance = customerArray[customerIndex].GetCustomerBalance();
                                    customerCreditBalance = customerArray[customerIndex].GetCustomerCredits();

                                    //check if the member has sufficient money
                                    if (customerMoneyBalance < totalPrice)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Oops! You dont have enough credits to make this purchase.");
                                        //return to payment choices;
                                        Console.WriteLine("Press Enter to return to payment options");
                                        Console.ReadLine();
                                        wasItValid = false;
                                    }
                                    else if (payedWithHonorsCredit == true)
                                    {
                                        salesTax = remainingHonorsBalance * 0.10;
                                        finalCreditBalance = customerCreditBalance;
                                        finalMoneyBalance = (customerMoneyBalance - (remainingHonorsBalance + salesTax));
                                        customerArray[customerIndex].SetCustomerBalance(finalMoneyBalance);
                                        wasItValid = true;
                                    }
                                    else
                                    {
                                        finalCreditBalance = customerCreditBalance;
                                        finalMoneyBalance = (customerMoneyBalance - totalPrice);
                                        customerArray[customerIndex].SetCustomerBalance(finalMoneyBalance);
                                        wasItValid = true;
                                    }
                                    break;

                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("\t   Student Information\n----------------------------------------\nStudent Name: {0} {1}\nSchool:\t      {2}\nState:\t      {3}\nGPA:\t      {4:0.00}\nPlan Credits: {5}\nCard Balance: {6:C}\n----------------------------------------", customerArray[customerIndex].GetCustomerFirstName(), customerArray[customerIndex].GetCustomerLastName(), customerArray[customerIndex].GetCustomerCollegeName(), customerArray[customerIndex].GetCustomerState(), customerArray[customerIndex].GetCustomerGPA(), customerArray[customerIndex].GetCustomerCredits(), customerArray[customerIndex].GetCustomerBalance());
                                    //return to payment choices
                                    Console.WriteLine("Press Enter to return to payment options");
                                    Console.ReadLine();
                                    wasItValid = false;
                                    break;

                                case "4":
                                    Console.Clear();

                                    if(payedWithHonorsCredit == true)
                                    {
                                        // Cancel purchase and set honors credit back to 1
                                        customerArray[customerIndex].SetHonorsCredit(1);
                                    }

                                    //Logout user
                                    accessGranted = false;
                                    isStudent = false;

                                    //return to main menu
                                    wasItValid = true;
                                    break;

                                case "5":
                                    customerCreditBalance = customerArray[customerIndex].GetCustomerCredits();
                                    customerMoneyBalance = customerArray[customerIndex].GetCustomerBalance();

                                    if (customerArray[customerIndex].GetHonorsCredit() == 1 && numberOfMealsOrdered == 1)
                                    {
                                        subtotal = 0;
                                        salesTax = 0;
                                        totalPrice = 0;
                                        wasItValid = true;
                                    }
                                    else if (customerArray[customerIndex].GetHonorsCredit() == 1 && numberOfMealsOrdered > 1)
                                    {
                                        Console.Clear();
                                     
                                        //return to payment choices;
                                        Console.WriteLine("You chose to use 1 free honors credit.\nPress enter to select payment option for remaining balance of {0:C}", remainingHonorsBalance);                         
                                        Console.ReadLine();

                                        //Update the quantity of honors credits left
                                        customerArray[customerIndex].SetHonorsCredit(0);

                                        //Update new totalPrice
                                        totalPrice = remainingHonorsBalance;
               
                                        payedWithHonorsCredit = true;
                                        wasItValid = false;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Oops! You dont have enough credits to make this purchase.");
                                        //return to payment choices;
                                        Console.WriteLine("Press Enter to return to payment options");
                                        Console.ReadLine();
                                        wasItValid = false;
                                    }
                                    break;

                                default:
                                    Console.Clear();
                                    //return to payment choices
                                    Console.WriteLine("Invalid Entry\nPress Enter to return to payment options");
                                    Console.ReadLine();
                                    wasItValid = false;
                                    break;
                            }
                            Console.Clear();
                        } while (wasItValid == false);


                        //Print Receipt
                        switch (userInput)
                        {
                            case "1":
                                //Update the quantity of meals available
                                mealArray[mealIndex].SetMealQuantityAvailable(availableMeals - numberOfMealsOrdered);                               
                                
                                Console.Clear();
                                
                                if (payedWithHonorsCredit == true)
                                {
                                    Console.WriteLine(".::::::::::::::::   Your Ticker Information   ::::::::::::::::.\n");
                                    Console.WriteLine("****************    One Honors Credit Used    *****************.\n");
                                    Console.WriteLine("Old Meal Credits: {0,15}\tOld Balance: {1,10:C}\n---------------------------------------------------------------", customerCreditBalance, customerMoneyBalance);
                                    Console.WriteLine("Meal Type: {0,18} X {1}\tPrice: {2,16:C}", selectedMeal, numberOfMealsOrdered, subtotal);
                                    Console.WriteLine("\t\t\t\t\tSales Tax:{0,13:C}", salesTax);
                                    Console.WriteLine("Meals Remaining: {0,16}\tTotal Cost: {1,11:C}\n---------------------------------------------------------------", mealArray[mealIndex].GetMealQuantityAvailable(), salesTax + subtotal);
                                    Console.WriteLine("Remaining Meal Credits: {0,9}\tNew Balance: {1,10:C}", finalCreditBalance, finalMoneyBalance);
                                }
                                else
                                {
                                    Console.WriteLine(".::::::::::::::::   Your Ticker Information   ::::::::::::::::.\n");
                                    Console.WriteLine("Old Meal Credits: {0,15}\tOld Balance: {1,10:C}\n---------------------------------------------------------------", customerCreditBalance, customerMoneyBalance);
                                    Console.WriteLine("Meal Type: {0,18} X {1}\tPrice: {2,16:C}", selectedMeal, numberOfMealsOrdered, subtotal);
                                    Console.WriteLine("\t\t\t\t\tSales Tax:{0,13:C}", salesTax);
                                    Console.WriteLine("Meals Remaining: {0,16}\tTotal Cost: {1,11:C}\n---------------------------------------------------------------", mealArray[mealIndex].GetMealQuantityAvailable(), salesTax + subtotal);
                                    Console.WriteLine("Remaining Meal Credits: {0,9}\tNew Balance: {1,10:C}", finalCreditBalance, finalMoneyBalance);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Press Enter to make another purchase or q to quit");
                                userInput = Console.ReadLine().ToLower();

                                //Logout user
                                accessGranted = false;
                                isStudent = false;
                                payedWithHonorsCredit = false;

                                Console.Clear();
                                break;

                            case "2":
                                //Update the quantity of meals available
                                mealArray[mealIndex].SetMealQuantityAvailable(availableMeals - numberOfMealsOrdered);

                                Console.Clear();
 
                                if (payedWithHonorsCredit == true)
                                {
                                    Console.WriteLine(".::::::::::::::::   Your Ticker Information   ::::::::::::::::.\n");
                                    Console.WriteLine("****************    One Honors Credit Used    *****************.\n");
                                    Console.WriteLine("Old Meal Credits: {0,15}\tOld Balance: {1,10:C}\n---------------------------------------------------------------", customerCreditBalance, customerMoneyBalance);
                                    Console.WriteLine("Meal Type: {0,18} X {1}\tPrice: {2,16:C}", selectedMeal, numberOfMealsOrdered, remainingHonorsBalance);
                                    Console.WriteLine("\t\t\t\t\tSales Tax:{0,13:C}", salesTax);
                                    Console.WriteLine("Meals Remaining: {0,16}\tTotal Cost: {1,11:C}\n---------------------------------------------------------------", mealArray[mealIndex].GetMealQuantityAvailable(), salesTax + remainingHonorsBalance);
                                    Console.WriteLine("Remaining Meal Credits: {0,9}\tNew Balance: {1,10:C}", finalCreditBalance, finalMoneyBalance);
                                }
                                else
                                {
                                    Console.WriteLine(".::::::::::::::::   Your Ticker Information   ::::::::::::::::.\n");
                                    Console.WriteLine("Old Meal Credits: {0,15}\tOld Balance: {1,10:C}\n---------------------------------------------------------------", customerCreditBalance, customerMoneyBalance);
                                    Console.WriteLine("Meal Type: {0,18} X {1}\tPrice: {2,16:C}", selectedMeal, numberOfMealsOrdered, subtotal);
                                    Console.WriteLine("\t\t\t\t\tSales Tax:{0,13:C}", salesTax);
                                    Console.WriteLine("Meals Remaining: {0,16}\tTotal Cost: {1,11:C}\n---------------------------------------------------------------", mealArray[mealIndex].GetMealQuantityAvailable(), salesTax + subtotal);
                                    Console.WriteLine("Remaining Meal Credits: {0,9}\tNew Balance: {1,10:C}", finalCreditBalance, finalMoneyBalance);
                                }
                                Console.WriteLine();
                                Console.WriteLine("Press Enter to make another purchase or q to quit");
                                userInput = Console.ReadLine().ToLower();

                                //Logout user
                                accessGranted = false;
                                isStudent = false;
                                payedWithHonorsCredit = false;

                                Console.Clear();
                                break;

                            case "5":
                                //Update the quantity of meals available
                                mealArray[mealIndex].SetMealQuantityAvailable(availableMeals - numberOfMealsOrdered);
                                //Update the quantity of honors credits left
                                customerArray[customerIndex].SetHonorsCredit(0);

                                Console.Clear();
                                Console.WriteLine(".::::::::::::::::   Your Ticker Information   ::::::::::::::::.\n");
                                Console.WriteLine(".::::   This is a free meal for being an honors student   ::::.\n");
                                Console.WriteLine("Old Meal Credits: {0,15}\tOld Balance: {1,10:C}\n---------------------------------------------------------------", customerCreditBalance, customerMoneyBalance);
                                Console.WriteLine("Meal Type: {0,18} X {1}\tPrice: {2,16:C}", selectedMeal, numberOfMealsOrdered, subtotal);
                                Console.WriteLine("\t\t\t\t\tSales Tax:{0,13:C}", salesTax);
                                Console.WriteLine("Meals Remaining: {0,16}\tTotal Cost: {1,11:C}\n---------------------------------------------------------------", mealArray[mealIndex].GetMealQuantityAvailable(), totalPrice);
                                Console.WriteLine("Remaining Meal Credits: {0,9}\tNew Balance: {1,10:C}", customerCreditBalance, customerMoneyBalance);
                                Console.WriteLine();
                                Console.WriteLine("Press Enter to make another purchase or q to quit");
                                userInput = Console.ReadLine().ToLower();

                                //Logout user
                                accessGranted = false;
                                isStudent = false;

                                Console.Clear();
                                break;
                        }
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("-------------------------------\nPlease select a payment option:\n-------------------------------\n1. Use Meal Plan Credits\n2. Use Card\n3. View Plan Credit & Card Balance\n4. Cancel");
                            userInput = Console.ReadLine();
                            switch (userInput)
                            {
                                case "1":
                                case "2":
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("You are not a student, please select another payment option");
                                    //return to payment choices
                                    Console.WriteLine("Press Enter to return to payment options");
                                    Console.ReadLine();
                                    wasItValid = false;
                                    break;

                                case "4":
                                    Console.Clear();
                                    //return to main menu
                                    wasItValid = true;
                                    break;

                                default:
                                    Console.Clear();
                                    //return to payment choices
                                    Console.WriteLine("Invalid Entry\nPress Enter to return to payment options");
                                    Console.ReadLine();
                                    wasItValid = false;
                                    break;
                            }
                            Console.Clear();
                        } while (wasItValid == false);
                    }
                }
            } while (userInput.ToLower() != "q");
        }
    }
}