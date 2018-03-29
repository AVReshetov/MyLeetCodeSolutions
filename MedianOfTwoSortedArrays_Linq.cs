public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        //определение медианных индексов
        var sumLength = nums1.Length + nums2.Length;
        var midInd1 = sumLength / 2;
        var midInd2 = sumLength % 2 == 0 ? midInd1 - 1 : midInd1;
        var nums = nums1.Concat(nums2).OrderBy(i=>i);
        return (nums.ElementAt(midInd1) + nums.ElementAt(midInd2))/2.0;
    }
}