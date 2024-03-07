public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int count = nums.Length;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == val)
            {
                count--;
                nums[i] = 100;
            }
        }
        Array.Sort(nums);
        return count;    
    }
}
