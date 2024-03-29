using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    //TO DO:
    //Suppose that the cover price of a book is $X, but the bookstores get a 40% discount.
    //Shipping costs $3 for the first copy and �75 for each additional copy.

    //Calculate the total wholescale cost and profit (before operational costs) when the bookstore sells Y copies.
    //I want to enter the X and Y values and get the cost and the profit as a meaningful output.

    [SerializeField] int coverPrice, numberOfCopies;
    float totalWholesaleCost, totalProfit;

    // Start is called before the first frame update
    void Start()
    {
        FindCostAndProfit(coverPrice, numberOfCopies);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FindCostAndProfit(int x, int y) 
    {
        float discount = .4f;
        float shippingCost = 0f;

        //Total Final Cost = coverPrice * numberOfCopies 
        float totalFinalCost = x * y;

        if (y > 0) 
        {
            //Shipping Cost total is calculated based on which copy is sold, then the sum of all copies with different discounts is found
            shippingCost = (x * discount) + 3;
            if (y > 1) 
            {
                shippingCost += ((x * discount) * (y - 1)) + 0.75f;
            }
        }

        //totalProfit is the difference between how many copies were sold before the fees and the total shipping cost
        float totalProfit = totalFinalCost - shippingCost;

        print("Total Wholesale Cost: $" + shippingCost.ToString("0.00") + " | Total Profit: $" + totalProfit.ToString("0.00"));        

    }

}
