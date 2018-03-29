/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum = l1.val + l2.val;
        ListNode currentNode = new ListNode(sum % 10);
        ListNode resultNode = currentNode;
        bool cache = sum > 9;
        ListNode current1 = l1.next;
        ListNode current2 = l2.next;
        while(current1 != null || current2 != null)
        {
            sum = (current1?.val ?? 0)+ (current2?.val ?? 0) + (cache ? 1 : 0);
            cache = sum > 9;
            currentNode.next = new ListNode(sum % 10);
            currentNode = currentNode.next;
            current1 = current1?.next;
            current2 = current2?.next;
        }
        if (cache)
            currentNode.next = new ListNode(1);
        return resultNode;
    }
}