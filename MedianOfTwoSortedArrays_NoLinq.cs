public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var length1 = nums1.Length;
        var length2 = nums2.Length;
        
        //определение медианных индексов
        var sumLength = length1 + length2;
        var midInd1 = sumLength / 2;
        var midInd2 = sumLength % 2 == 0 ? midInd1 - 1 : midInd1;
        
        //установка начальных значений
        int curInd=0, curInd1=0, curInd2=0;
        int midVal1=0, midVal2=0;
        int curVal, curVal1=0, curVal2=0;
        bool continue1 = length1 > 0;
        bool continue2 = length2 > 0;
        if (continue1)
            curVal1 = nums1[0];
        if (continue2)
            curVal2 = nums2[0];
        
        while(curInd <= midInd1)
        {   
            // выбор массива и продвижение по нему
            if (continue1 && (!continue2 || curVal1 <= curVal2))
            {
                curVal = curVal1;
                curInd1++;
            }
            else
            {
                curVal = curVal2;
                curInd2++;
            }
            
            // извлечение следующих значений из массивов
            if (curInd1 < length1)
                curVal1 = nums1[curInd1];
            else
                continue1 = false;
            if (curInd2 < length2)
                curVal2 = nums2[curInd2];
            else
                continue2 = false;
            
            // установка медианных значений при достижении медианных индексов
            if (curInd == midInd1)
                midVal1 = curVal;
            if (curInd == midInd2)
                midVal2 = curVal;
            
            //условие выхода из цикла
            curInd = curInd1 + curInd2;
        }
        
        //подсчет и вывод результата
        return (midVal1 + midVal2) / 2.0;
    }
}