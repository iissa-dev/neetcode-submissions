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
    public void ReorderList(ListNode head) {
        if(head is null || head.next is null) return;

        var slow = head;
        var fast = head;

        while(fast is not null && fast.next is not null) {
            fast = fast.next.next;
            slow = slow.next;
        }

        var secondHalf = slow.next;
        slow.next = null;
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
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;
            
            first.next = second;
            second.next = temp1;

            first = temp1;
            second = temp2;
        }

    }
}
