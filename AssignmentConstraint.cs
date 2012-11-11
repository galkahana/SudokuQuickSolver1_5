using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuQuickSolver1_5
{

    // abstract class (notice the protected constructor). This class may only be used as
    // inherited class. the derived class should implement an "Init" method that should fill
    // the mAllowedValues member with number (values). The reason no such private pure method is 
    // defined is due to the fact that the expected sub classes are expected to differ in their
    // init method interface. The init method is expected to respect the property that no value
    // is assigned twice. The best method to achieve this is to init the allowed values member to 
    // the complete expected range and using the "AssignValue" method when assigning values.
    // in regular sudoku that range of number would be 1..9
    abstract class AssignmentConstraint
    {
        protected Dictionary<int,int> mAllowedValues;

        
        protected AssignmentConstraint()
        {
            mAllowedValues = new Dictionary<int, int>();
        }

        public bool AssignValue(int inNumberValue)
        {
            if (CanAssignValue(inNumberValue))
            {
                mAllowedValues.Remove(inNumberValue);
                return true;
            }
            else
                return false;               
        }

        public bool CanAssignValue(int inNumberValue)
        {
            return mAllowedValues.ContainsKey(inNumberValue);
        }

        public AssignmentConstraint Assign(AssignmentConstraint inAssignmentConstraint)
        {
            mAllowedValues.Clear();
            foreach (int number in inAssignmentConstraint.mAllowedValues.Keys)
                mAllowedValues.Add(number, number);
            return this;
        }

        public AssignmentConstraint IntersectWith(AssignmentConstraint inAssignmentConstraint)
        {
            int[] allowedValues = new int[mAllowedValues.Keys.Count];
            mAllowedValues.Keys.CopyTo(allowedValues, 0);
            mAllowedValues.Clear();
            foreach (int number in allowedValues)
                if(inAssignmentConstraint.mAllowedValues.ContainsKey(number))
                    mAllowedValues.Add(number, number);
            return this;
        }

        public ICollection<int> GetAllowedValues()
        {
            return mAllowedValues.Keys;
        }
    }
}
