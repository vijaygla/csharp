// custom exception
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
        
    }
}

// model
public class Customer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string EmploymentType { get; set; }
    public double MonthlyIncome { get; set; }
    public double Dues { get; set; }
    public int CreditScore { get; set; }
    public int Defaults { get; set; }   
}

// utility class
public class Utility
{
    public void ValidateCustomer(Customer c)
    {
        if (c.Age < 21 || c.Age > 65)
            throw new CustomException("Invalid age");

        string emp = c.EmploymentType.Trim();

        if (!emp.Equals("Salaried", StringComparison.OrdinalIgnoreCase) &&
            !emp.Equals("Self-Employed", StringComparison.OrdinalIgnoreCase))
        {
            throw new CustomException("Invalid employment type");
        }

        if (c.MonthlyIncome < 20000)
            throw new CustomException("Invalid monthly income");

        if (c.Dues < 0)
            throw new CustomException("Invalid credit dues");

        if (c.CreditScore < 300 || c.CreditScore > 900)
            throw new CustomException("Invalid credit score");

        if (c.Defaults < 0)
            throw new CustomException("Invalid default count");
    }

    public double CalculateCreditLimit(Customer c)
    {
        double debitRatio = c.Dues / (c.MonthlyIncome * 12);

        if (c.CreditScore < 600 || c.Defaults >= 3 || debitRatio > 0.4)
            return 50000;

        if (c.CreditScore >= 750 && c.Defaults == 0 && debitRatio < 0.25)
            return 300000;

        return 150000;
    }
}


// main class 
public class Program
{
    public static Customer customer = new Customer();
    static void Main()
    {
        Utility utility = new Utility();
        try
        {
            Console.WriteLine("Enter customer name");
            customer.Name = Console.ReadLine();

            Console.WriteLine("Enter age");
            customer.Age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter employment types");
            customer.EmploymentType = Console.ReadLine();
            
            Console.WriteLine("Enter montly income");
            customer.MonthlyIncome = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Existing dues");
            customer.Dues = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter credit score:");
            customer.CreditScore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of loan defaults:");
            customer.Defaults = int.Parse(Console.ReadLine());

            // validate customer
            utility.ValidateCustomer(customer);

            // calculate credit limit
            double creditLimit = utility.CalculateCreditLimit(customer);

            Console.WriteLine($"Customer Name : {customer.Name}");
            Console.WriteLine($"Approved credit limit : ₹ {creditLimit}");
        }
        catch(CustomException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}




/* ================================= Problem Statement ==================================
SmartBank – Customer Credit Risk Evaluation System
SmartBank is a banking platform that evaluates customer financial stability and determines the maximum credit limit that can be offered.
The system validates customer financial data and applies risk-based calculations.
Robust custom exception handling is used to handle invalid inputs.

Problem Scenario-----
The UserInterface class accepts the following customer details:
Customer Name
Age
Employment Type
Monthly Income
Existing Credit Card Dues
Credit Score
Number of Loan Defaults
These details are passed to a utility class named CreditRiskProcessor.
Component Specification
1. CreditRiskProcessor (Utility Class)
Type	Method	Parameters	Responsibilities
Class	validateCustomerDetails	int age, String employmentType, double monthlyIncome, double dues, int creditScore, int defaults	Validates customer inputs. Returns true if valid; 
---> otherwise throws InvalidCreditDataException.
Class	calculateCreditLimit	double monthlyIncome, double dues, int creditScore, int defaults	Calculates and returns the customer credit limit.

---> Validation Rules
The validateCustomerDetails() method must validate input according to the following rules:
1. Age
Must be between 21 and 65 (inclusive)
If invalid → throw exception with message:
"Invalid age"
2. Employment Type
Must be "Salaried" or "Self-Employed" (case-sensitive)
If invalid → throw exception with message:
"Invalid employment type"
3. Monthly Income
Must be greater than or equal to ₹20,000
If invalid → throw exception with message:
"Invalid monthly income"
4. Existing Credit Card Dues
Must be greater than or equal to 0
If invalid → throw exception with message:
"Invalid credit dues"
5. Credit Score
Must be between 300 and 900
If invalid → throw exception with message:
"Invalid credit score"
6. Number of Loan Defaults
Must be greater than or equal to 0
If invalid → throw exception with message:
"Invalid default count"

---> Credit Limit Calculation Rules
The calculateCreditLimit() method calculates the credit limit based on risk category.
Risk Assessment Criteria
Debt Ratio
 
Plain Text
Plain Text
Debt Ratio = Existing Dues / (Monthly Income × 12)
 
Risk Categories
High Risk---|
Credit Score < 600
OR Defaults ≥ 3
OR Debt Ratio > 0.4
Credit Limit = ₹50,000
Medium Risk---|
Credit Score between 600 and 749
OR Defaults = 1 or 2
Credit Limit = ₹1,50,000
Low Risk---|
Credit Score ≥ 750
AND Defaults = 0
AND Debt Ratio < 0.25
Credit Limit = ₹3,00,000


2. InvalidCreditDataException
Type	Responsibilities
Class	Custom checked exception extending Exception
Constructor
 
Plain Text
Plain Text
public InvalidCreditDataException(String message) 
This exception is thrown whenever any validation rule fails.

3. UserInterface Class
Contains the main() method
Accepts all customer details using Scanner
Calls validateCustomerDetails()
If validation succeeds:
Calls calculateCreditLimit()
Displays the credit limit
If validation fails:
Catches InvalidCreditDataException
Displays only the exception message
Sample Input & Output – Test Cases
Test Case 1 – Valid (Low Risk)
Input
 
Plain Text
Plain Text
Enter customer name: Arjun Enter age: 35 Enter employment type: Salaried Enter monthly income: 80000 Enter existing credit dues: 100000 Enter credit score: 820 Enter number of loan defaults: 0 
 
Output
 
Plain Text
Plain Text
Customer Name: Arjun Approved Credit Limit: ₹300000 
*/

// Test case
/*
Enter customer name:
Neha
Enter age:
42
Enter employment type:
Self-Employed
Enter monthly income:
60000
Enter existing dues:
200000
Enter credit score:
690
Enter number of loan defaults:
1
*/
