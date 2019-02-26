using System;
using System.Diagnostics;
using System.Text;
/// <summary>
/// Simple class to handle lists of integers, using linked lists.
/// </summary>
/// <remarks>
/// Author: George Wells
/// Version: 1.0 (19 September 2013)
/// </remarks>
public class DoubleList
    {
        private class ListNode
        {
            public double data;
            public ListNode next;
        } // inner class ListNode

        /// <summary>Reference to the first ListNode in a IntegerList.</summary>
        private ListNode first;
        /// <summary>Number of elements in a IntegerList.</summary>
        private int numElements;

        /// <summary>
        /// Create an empty IntegerList.
        /// <para><I>Postcondition:</I> The list is empty.</para>
        /// </summary>
        public DoubleList()
        {
            first = null;
            numElements = 0;
        } // IntegerList constructor

        /// <summary>
        /// Place a new item at a specified position in an IntegerList.
        /// <para><I>Precondition:</I> The specified position is positive or zero.</para>
        /// <para><I>Postcondition:</I> The value <CODE>item</CODE> appears at
        /// <CODE>position</CODE> in the list, or at the end of the list if
        /// <CODE>position</CODE> is greater than the original length of the list.</para>
        /// </summary>
        /// <param name="item">The integer value to be added to the list.</param>
        /// <param name="position">The position in the list where the item should
        /// be added.</param>
        /// <exception cref="ArgumentException">if <CODE>position</CODE> is negative.</exception>
        public void Add(double item, int position)
        {
            if (position < 0)
                throw new ArgumentException("position is negative");
            ListNode node = new ListNode();
            node.data = item;
            ListNode curr = first,
                     prev = null;
            for (int k = 0; k < position && curr != null; k++) // Find position
            {
                prev = curr;
                curr = curr.next;
            }
            node.next = curr;
            if (prev != null)
                prev.next = node;
            else
                first = node;
            numElements++;
        } // Add

        /// <summary>
        /// Place a new item at the end of an IntegerList.
        /// <para><I>Postcondition:</I> The value <CODE>item</CODE> appears at
        /// the end of the list.</para>
        /// </summary>
        /// <param name="item">The integer value to be added to the list.</param>
        public void Add(double item)
        {
            Add(item, numElements);
        } // Add

        /// <summary>
        /// Remove the item at a given position in an IntegerList.
        /// <para><I>Precondition:</I> The position is that of a valid item.</para>
        /// <para><I>Postcondition:</I> The item at <CODE>position</CODE> has been
        ///  removed from the list.</para>
        /// </summary>
        /// <param name="position">The position of the item to be removed from the
        /// list.</param>
        /// <exception cref="IndexOutOfRangeException">if <CODE>position</CODE> is invalid.</exception>
        public void Remove(int position)
        {
            if (position < 0 || position >= numElements)
                throw new IndexOutOfRangeException("position is out of range");
            ListNode curr = first,
                     prev = null;
            for (int k = 0; curr != null && k < position; k++)
            {
                prev = curr;
                curr = curr.next;
            }
            Debug.Assert(curr != null);
            if (prev != null)
                prev.next = curr.next;
            else
                first = curr.next;
            numElements--;
        } // Remove

        /// <summary>
        /// Return the current number of elements in an IntegerList.
        /// </summary>
        /// <returns>The number of elements in the list.</returns>
        public int Length()
        {
            return numElements;
        } // Length

        /// <summary>
        /// Retrieve an element from an IntegerList.
        /// <para><I>Precondition:</I> <CODE>index</CODE> is in range.</para>
        /// </summary>
        /// <param name="index">The position of the item to get from the list.</param>
        /// <returns>The element at position <CODE>index</CODE> in the list.</returns>
        /// <exception cref="IndexOutOfRangeException">if <CODE>index</CODE> is invalid.</exception>
        public double Get(int index)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            ListNode curr = first;
            for (int k = 0; curr != null && k < index; k++)
                curr = curr.next;
            Debug.Assert(curr != null);
            return curr.data;
        } // Get

        /// <summary>
        /// Change the value of an element in an IntegerList.
        /// <para><I>Precondition:</I> <CODE>index</CODE> is in range.</para>
        /// </summary>
        /// <param name="index">The position of the item to be changed in the list.</param>
        /// <param name="item">item The new value for the item.</param>
        /// <exception cref="IndexOutOfRangeException">if <CODE>index</CODE> is invalid.</exception>
        public void Set(int index, double item)
        {
            if (index < 0 || index >= numElements)
                throw new IndexOutOfRangeException("index is out of range");
            ListNode curr = first;
            for (int k = 0; curr != null && k < index; k++)
                curr = curr.next;
            Debug.Assert(curr != null);
            curr.data = item;
        } // Set

        /// <summary>
        /// Find item in an IntegerList.
        /// </summary>
        /// <param name="item">The item to be searched for.</param>
        /// <returns>The position of this item if it is found, otherwise -1</returns>
        public int Position(double item)
        {
            ListNode curr = first;
            int k;
            for (k = 0; curr != null && curr.data != item; k++, curr = curr.next)
                ; // Search for item in IntegerList
            if (curr == null) // item was not found
                return -1;
            else
                return k;
        } // Position

        /// <summary>
        /// Return string representation of the IntegerList.
        /// The format is: <CODE>[ <I>item</I>, <I>item</I>, ... ]</CODE>
        /// </summary>
        /// <returns>A string representing the contents of this list</returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder("[");
            for (ListNode curr = first; curr != null; curr = curr.next)
            {
                s.Append("" + curr.data);
                if (curr.next != null)
                    s.Append(", ");
            }
            s.Append("]");
            return s.ToString();
        } // ToString

        public DoubleList new_add(DoubleList List1, DoubleList List2)
        {
        DoubleList result = new DoubleList();
            if (List1.numElements > List2.numElements)
            {
                
                int count = 0;
                while (count < List1.numElements)
                {
                    if (List2.numElements == count)
                    {
                        int count1 = count;
                        while (count1 < List1.numElements)
                        {

                            result.Add(List1.Get(count1), count1);
                            count1++;
                        }
                        count = count1;
                    }
                    else
                    {
                        result.Add(List1.Get(count) + List2.Get(count), count);
                        count++;
                    }


                }
            }
            else
            {
                
                int count = 0;
                while (count < List2.numElements)
                {
                    if (List1.numElements == count)
                    {
                        int count1 = count;
                        while (count1 < List2.numElements)
                        {

                            result.Add(List2.Get(count1));
                            count1++;
                        }
                        count = count1;
                    }
                    else
                    {
                        result.Add(List1.Get(count) + List2.Get(count), count);
                        count++;
                    }


                }
            }



            return result;
        }

} // class IntegerList
