/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        var slow = head;
        var fast = head;
        while(fast is not null && fast.next is not null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        var secondHalf = slow;
        slow = null;

        ListNode prev = null;
        var curr = secondHalf;
        while(curr is not null) {
            var nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }

        var first = head;
        var second = prev;
        while(second is not null) {
            if(first.val != second.val) return false;

            first = first.next;
            second = second.next;
        }

        return true;
    }
}