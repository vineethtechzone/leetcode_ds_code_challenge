// Two Sum Leetcode problem solving by using Dictionary (HashMap)
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:
//Input: nums = [2,7,11,15], target = 9 Output: [0,1] Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//******************************************************************************************************************
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pre_map = new Dictionary<int, int>();
        var result = new int[2];
     for (var i = 0; i < nums.Length; i ++) 
     {       
         if (pre_map.ContainsKey(target-nums[i]))
         {
          result[0]=pre_map[target-nums[i]];
          result[1]=i;
          return result;
         } else
         {
             pre_map[nums[i]] = i;
         }000
     }
       return result;
    }
}
