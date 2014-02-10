// File Prologue
// Name: Ikani Samani
// CS 1400 Section 003
// Project: Lab 23
// Date: 4/11/2013
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab23
{
    class MyTokenMachine
    {
        const int MAX = 100;
        private int tokens;
        private int quarters;

        //--------constructors--------

        // The default constructor
        // Purpose: intialize all values to zero
        // Parameters: none
        // Return: none
        public MyTokenMachine()
        {
            tokens = 0;
            quarters = 0;
        }
        // parameterized constructor
        // purpose: intialize all values
        // parameters: amount of tokens(t), amount of quarters (q)
        // Returns: none
        public MyTokenMachine(int t, int q)
        {
            tokens = t;
            quarters = q;
        }

        // GetToken Method
        // Purpose: decrease to tokens by one and increase quarters by one
        // Parameters: none
        //Return: none
        public void GetToken()
        {
            --this.tokens;
            ++this.quarters;
        }

        // CountTokens Method
        // Purpose: getter method for tokens
        // parameters: none
        // Return: tokens as an integer 
        public int Tokens
        {
            get
            {
                return tokens;
            }
        }

        // Quarters properties
        public int Quarters
        {
            get
            {
                return quarters;
            }
        }

        // Reset Method
        // Purpose: Reset tokens and quarters to orginal (setter method)
        // Parameters: none
        // Return: none
        public void Reset()
        {
            tokens = MAX;
            quarters = 0;
        }
    }
}
