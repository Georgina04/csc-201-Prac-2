using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs2;


/// <summary>
/// Simple class to handle vectors of integers.
/// These are simple lists of integers, based on a fixed-size array.
/// </summary>
/// <remarks>
/// Author: George Wells
/// Version: 1.0 (23 September 2013)
/// </remarks>
public class DoubleVector
    {
        /// <summary>The array of data.</summary>
        private double[] data;
        /// <summary>Number of elements stored in the vector.</summary>
        private int numElements;

        /// <summary>
        /// Create a new vector.
        /// <para><I>Precondition:</I> <CODE>initSize > 0</CODE>.</para>
        /// </summary>
        /// <param name="initSize">The maximum capacity of the vector.</param>
        /// <exception cref="ArgumentException">if <CODE>initSize</CODE> is negative or zero.</exception>
        public DoubleVector (int initSize)
        {
            if (initSize <= 0)
                throw new System.ArgumentException("Negative or zero size specified", "initSize");
            numElements = 0;
            data = new double[initSize];
        } // Constructor

        /// <summary>
        /// Create a new vector with a default maximum capacity of 100.
        /// </summary>
        public DoubleVector () : this(100) // Default to 100000 elements
        {
        } // Constructor

        /// <summary>
        /// Place a new item at a specified position in an IntegerVector.
        /// <para><I>Precondition:</I> There is space available for another value.</para>
        /// <para><I>Precondition:</I> The position is in range.</para>
        /// <para><I>Postcondition:</I> The value <CODE>item</CODE> appears at
        /// <CODE>position</CODE> in the vector, or at the end of the list if
        /// <CODE>position</CODE> is greater than the original length of the list.</para>
        /// </summary>
        /// <param name="item">The integer value to be added to the vector.</param>
        /// <param name="position">The position in the vector where the item should
        /// be added.</param>
        /// <exception cref="ArgumentException">if <CODE>position</CODE> is negative.</exception>
        /// <exception cref="NoSpaceAvailableException">if no space is available.</exception>
        public void Add (double item, int position)
        {
            if (numElements + 1 > data.Length)
                throw new NoSpaceAvailableException("no space available");
            if (position < 0)
                throw new System.ArgumentException("position is negative");
            if (position >= numElements) // Add at end
                data[numElements++] = item;
            else
            {
                int k;
                for (k = numElements - 1; k >= position; k--)
                    data[k + 1] = data[k]; // Move elements up
                data[position] = item; // Put item in place
                numElements++;
            }
        } // Add

        /// <summary>
        /// Place a new item at the end of an IntegerVector.
        /// <para><I>Precondition:</I> There is space available for another value.</para>
        /// <para><I>Postcondition:</I> The value <CODE>item</CODE> appears at
        /// the end of the vector.</para>
        /// </summary>
        /// <param name="item">The integer value to be added to the vector.</param>
        public void Add(double item)
        {
            Add(item, numElements);
        } // Add

        /// <summary>
        /// Remove the item at a given position in an IntegerVector.
        /// <para><I>Precondition:</I> The position is that of a valid item.</para>
        /// <para><I>Postcondition:</I> The item at <CODE>position</CODE> has been
        /// removed from the vector.</para>
        /// </summary>
        /// <param name="position">The position of the item to be removed from the
        /// vector.</param>
        /// <exception cref="IndexOutOfRangeException">if <CODE>position</CODE> is invalid.</exception>
        public void Remove(int position)
        {
            if (position < 0 || position >= numElements)
                throw new System.IndexOutOfRangeException("position is out of range");
            for (int k = position + 1; k < numElements; k++)
                data[k - 1] = data[k];
            numElements--;
        } // Remove

        /// <summary>
        /// Return the current number of elements in an IntegerVector.
        /// </summary>
        /// <returns>The number of elements in the vector.</returns>
        public int Length()
        { return numElements; }

        /// <summary>
        /// Retrieve an element from an IntegerVector.
        /// <para><I>Precondition:</I> <CODE>index</CODE> is in range.</para>
        /// </summary>
        /// <param name="index">The position of the item to get from the list.</param>
        /// <returns>The element at position <CODE>index</CODE> in the vector.</returns>
        /// <exception cref="IndexOutOfRangeException">If <CODE>index</CODE> is invalid.</exception>
        public double Get(int index)
        {
            if (index < 0 || index >= numElements)
                throw new System.IndexOutOfRangeException("index is out of range");
            return data[index];
        } // Get

    /// <summary>Change the value of an element in an IntegerVector.
    /// <para><I>Precondition:</I> <CODE>index</CODE> is in range.</para>
    /// <para><I>Postcondition:</I> The value of the element at position <CODE>index</CODE>
    ///   in the vector has been changed.</para>
    /// </summary>
    /// <param name="index">The position of the item to be changed in the vector.</param>
    /// <param name="item">The new value for the item.</param>
    /// <exception cref="IndexOutOfRangeException">if <CODE>index</CODE> is invalid.</exception>
    public void Set(int index, double item)
        {
            if (index < 0 || index >= numElements)
                throw new System.IndexOutOfRangeException("index is out of range");
            data[index] = item;
        } // Set

        /// <summary>
        /// Search for a specified item in an IntegerVector.
        /// </summary>
        /// <param name="item">The item to be searched for.</param>
        /// <returns>The position of this item if it is found, otherwise -1</returns>
        public int Position(double item)
        {
            int k;
            for (k = 0; k < numElements; k++)
                if (data[k] == item)
                    break; // Leave for loop
            if (k >= numElements) // item was not found
                return -1;
            else
                return k;
        } // Position

        /// <summary>
        /// Return a string representation of the IntegerVector.
        /// The format is: <CODE>[ <I>item</I>, <I>item</I>, ... ]</CODE>
        /// </summary>
        /// <returns>A string representing the contents of this vector</returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            int k;
            for (k = 0; k < numElements; k++)
            {
                s.Append("" + data[k]);
                if (k < numElements - 1)
                    s.Append(", ");
            }
            s.Append("]");
            return s.ToString();
        } // ToString

    public DoubleVector new_add (DoubleVector vec1, DoubleVector vec2)
    {
        DoubleVector result;
        if (vec1.numElements > vec2.numElements)
        {
            result = new DoubleVector (vec1.numElements);
            int count = 0;
            while (count < vec1.numElements)
            {
                if (vec2.numElements == count)
                {
                    int count1 = count;
                    while (count1 < vec1.numElements)
                    {

                        result.Add(vec1.Get(count1), count1);
                        count1++;
                    }
                    count = count1;
                }
                else
                {
                    result.Add(vec1.Get(count)+ vec2.Get(count), count);
                    count++;
                }
                
                
            }
        }
        else
        {
            result = new DoubleVector (vec2.numElements);
            int count = 0;
            while (count < vec2.numElements)
            {
                if (vec1.numElements == count)
                {
                    int count1 = count;
                    while (count1 < vec2.numElements)
                    {

                        result.Add(vec2.Get(count1));
                        count1++;
                    }
                    count = count1;
                }
                else
                {
                    result.Add(vec1.Get(count) + vec2.Get(count), count);
                    count++;
                }


            }
        }

        
        
        return result;
    }


} // class IntegerVector
